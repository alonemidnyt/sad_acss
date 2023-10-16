Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Classrooms

    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim ConnectionString As String = "Server=localhost;Database=acss;userid=root;password=;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshListbox()
    End Sub

    Private Sub RoomListView_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles RoomListView.ItemSelectionChanged
        If e.IsSelected Then
            BTN_Delete.Visible = True
            BTN_Edit.Visible = True
        Else
            BTN_Delete.Visible = False
            BTN_Edit.Visible = False
        End If
    End Sub

    Private Sub TB_Search_Enter(sender As Object, e As EventArgs) Handles TB_Search.Enter
        If TB_Search.Text = "Search Here" And TB_Search.ForeColor = Color.Gray Then
            TB_Search.Clear()
            TB_Search.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TB_Search_Leave(sender As Object, e As EventArgs) Handles TB_Search.Leave
        If TB_Search.Text = "" Then
            TB_Search.Text = "Search Here"
            TB_Search.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub BTN_AddRoom_Click(sender As Object, e As EventArgs) Handles BTN_AddRoom.Click
        BTN_AddRoom.Visible = False
        TB_AddRoomName.Visible = True
        CB_AddRoomType.Visible = True
        TB_AddCapacity.Visible = True
        BTN_AddSave.Visible = True
        BTN_AddCancel.Visible = True
        BTN_Delete.Visible = False
        BTN_Edit.Visible = False
    End Sub

    Private Sub BTN_AddCancel_Click(sender As Object, e As EventArgs) Handles BTN_AddCancel.Click
        If Not TB_AddRoomName.Text.Equals("") AndAlso Not TB_AddRoomName.Text.Equals("Enter Room Name") Then
            Dim result As DialogResult
            result = MessageBox.Show("Do you want to cancel adding room?", "Add Classroom", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.No Then
                Return
            End If
        End If

        RoomCancel()
    End Sub

    Private Sub TB_AddRoomName_Enter(sender As Object, e As EventArgs) Handles TB_AddRoomName.Enter
        If TB_AddRoomName.Text.Equals("Enter Room Name") Then
            TB_AddRoomName.Text = ""
            TB_AddRoomName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TB_AddRoomName_Leave(sender As Object, e As EventArgs) Handles TB_AddRoomName.Leave
        If TB_AddRoomName.Text = "" Then
            TB_AddRoomName.Text = "Enter Room Name"
            TB_AddRoomName.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TB_AddCapacity_Enter(sender As Object, e As EventArgs) Handles TB_AddCapacity.Enter
        TB_AddCapacity.Text = ""
        TB_AddCapacity.ForeColor = Color.Black
    End Sub

    Private Sub TB_AddCapacity_Leave(sender As Object, e As EventArgs) Handles TB_AddCapacity.Leave
        If TB_AddCapacity.Text = "" Then
            TB_AddCapacity.Text = "Capacity"
            TB_AddCapacity.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TB_AddCapacity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_AddCapacity.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Suppress the character
        End If
    End Sub

    Private Sub BTN_AddSave_Click(sender As Object, e As EventArgs) Handles BTN_AddSave.Click
        If TB_AddRoomName.Text.Equals("") Or TB_AddRoomName.Text.Equals("Enter Room Name") Then
            MsgBox("Field Empty")
            Return
        End If

        If CB_AddRoomType.Text.Equals("Room Type") Then
            MsgBox("Field Empty")
            Return
        End If

        If TB_AddCapacity.Text.Equals("") Or TB_AddCapacity.Text.Equals("Capacity") Then
            MsgBox("Field Empty")
            Return
        End If

        Dim roomName As String = TB_AddRoomName.Text.ToUpper
        Dim roomType As String = CB_AddRoomType.Text.ToUpper
        Dim capacity As String = TB_AddCapacity.Text.ToUpper

        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Dim query As String = "SELECT * FROM rooms WHERE room_id = @roomid"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@roomid", roomName)

                Dim reader As MySqlDataReader = cmd.ExecuteReader

                If reader.HasRows Then
                    MessageBox.Show("Room " & roomName & " already exists!", "Save unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                reader.Close()
            End Using
        End Using

        Dim result As DialogResult
        result = MessageBox.Show("Room Information:" & vbCrLf & vbCrLf & "Name: " & roomName & vbCrLf & "Type: " & roomType & vbCrLf & "Capacity: " & capacity & vbCrLf, "Save information?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Using conn As New MySqlConnection(ConnectionString)
                conn.Open()
                Dim query As String = "INSERT INTO  rooms (room_id, room_type, capacity) VALUES (@roomid, @roomtype, @roomcap)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.Add("@roomid", MySqlDbType.VarChar).Value = roomName
                    cmd.Parameters.Add("@roomtype", MySqlDbType.VarChar).Value = roomType
                    cmd.Parameters.Add("@roomcap", MySqlDbType.Int32).Value = Integer.Parse(capacity)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            RoomCancel()
            RefreshListbox()
        ElseIf result = DialogResult.No Then
            TB_AddRoomName.Focus()
        Else
            RoomCancel()
        End If
    End Sub

    Private Sub CB_AddRoomType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_AddRoomType.SelectedIndexChanged
        CB_AddRoomType.ForeColor = Color.Black
    End Sub

    Public Sub RefreshListbox()
        RoomListView.Items.Clear()

        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()

            Dim query As String = "SELECT * FROM rooms"

            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader

                    While reader.Read
                        Dim item As New ListViewItem(reader("room_id").ToString)
                        item.SubItems.Add(reader("room_type").ToString)
                        item.SubItems.Add(reader("capacity").ToString)
                        'change this into a condition later
                        item.SubItems.Add("Temporarily Not Available")

                        RoomListView.Items.Add(item)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub RoomCancel()
        TB_AddRoomName.Text = "Enter Room Name"
        TB_AddRoomName.ForeColor = Color.Gray
        TB_AddCapacity.Text = "Capacity"
        TB_AddCapacity.ForeColor = Color.Gray
        CB_AddRoomType.Text = "Room Type"
        CB_AddRoomType.ForeColor = Color.Gray

        TB_AddRoomName.Visible = False
        CB_AddRoomType.Visible = False
        TB_AddCapacity.Visible = False

        BTN_AddSave.Visible = False
        BTN_AddCancel.Visible = False
        BTN_AddRoom.Visible = True
    End Sub

    Private Sub BTN_Delete_Click(sender As Object, e As EventArgs) Handles BTN_Delete.Click
        If RoomListView.SelectedItems.Count = 0 Then
            MessageBox.Show("Select a room to delete", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRoomIndex As String = RoomListView.SelectedItems(0).SubItems(0).Text

        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Dim query As String = "DELETE FROM rooms WHERE room_id = @roomid"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@roomid", selectedRoomIndex)

                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("There was an error deleting room")
                End Try
                RefreshListbox()
                BTN_Delete.Visible = False
                BTN_Edit.Visible = False
            End Using
        End Using
    End Sub

    Private Sub RoomListView_DoubleClick(sender As Object, e As EventArgs) Handles RoomListView.DoubleClick
        If RoomListView.SelectedItems.Count > 0 Then
            Dim selectedRoom As ListViewItem = RoomListView.SelectedItems(0)

            Dim roomName As String = selectedRoom.SubItems(0).Text
            Dim roomType As String = selectedRoom.SubItems(1).Text
            Dim roomCapacity As String = selectedRoom.SubItems(2).Text
            Dim roomStatus As String = selectedRoom.SubItems(3).Text


            MsgBox(roomName)

        End If
    End Sub

    Private Sub BTN_Edit_Click(sender As Object, e As EventArgs) Handles BTN_Edit.Click
        If RoomListView.SelectedItems.Count > 0 Then
            Dim result As DialogResult
            result = MessageBox.Show("Edit Room Information?", "Rooms", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim selectedRoom As ListViewItem = RoomListView.SelectedItems(0)

                Dim roomName As String = selectedRoom.SubItems(0).Text
                Dim roomType As String = selectedRoom.SubItems(1).Text
                Dim roomCapacity As String = selectedRoom.SubItems(2).Text

                Dim editRoom As New EditRoom(roomName, roomType, roomCapacity)

                editRoom.Show()
                Me.Enabled = False
            End If
        End If
    End Sub
End Class

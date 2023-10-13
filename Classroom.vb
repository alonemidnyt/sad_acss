Imports MySql.Data.MySqlClient

Public Class Classrooms

    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ConnectionString As String = "Server=localhost;Database=acss;userid=root;password=;"
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

    Private Sub RoomListView_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles RoomListView.ItemSelectionChanged
        If e.IsSelected Then
            BTN_Delete.Visible = True
        Else
            BTN_Delete.Visible = False
        End If
    End Sub
    Private Sub RoomListView_Leave(sender As Object, e As EventArgs) Handles RoomListView.Leave
        BTN_Delete.Visible = False
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
    End Sub

    Private Sub BTN_AddCancel_Click(sender As Object, e As EventArgs) Handles BTN_AddCancel.Click
        If Not TB_AddRoomName.Text.Equals("") AndAlso Not TB_AddRoomName.Text.Equals("Enter Room Name") Then
            Dim result As DialogResult
            result = MessageBox.Show("Do you want to cancel adding room?", "Add Classroom", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.No Then
                Return
            End If
        End If

        TB_AddRoomName.Text = "Enter Room Name"
        TB_AddRoomName.ForeColor = Color.Gray
        TB_AddCapacity.Text = "Capacity"
        TB_AddCapacity.ForeColor = Color.Gray

        TB_AddRoomName.Visible = False
        CB_AddRoomType.Visible = False
        TB_AddCapacity.Visible = False

        BTN_AddSave.Visible = False
        BTN_AddCancel.Visible = False
        BTN_AddRoom.Visible = True
    End Sub

    Private Sub TB_AddRoomName_Enter(sender As Object, e As EventArgs) Handles TB_AddRoomName.Enter
        TB_AddRoomName.Text = ""
        TB_AddRoomName.ForeColor = Color.Black
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
End Class
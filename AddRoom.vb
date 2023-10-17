Imports MySql.Data.MySqlClient
Public Class AddRoom
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim ConnectionString As String = "Server=localhost;Database=acss;userid=root;password=;"

    Private Sub AddRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()

            Dim query As String = "SELECT * FROM days"

            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader

                    While reader.Read
                        Dim name As String = reader.GetString("day_name")

                        CLB_DayAvail.Items.Add(name)
                    End While
                End Using
            End Using

            Dim timeQuery As String = "SELECT * FROM time_slots"

            Using timeCMD As New MySqlCommand(timeQuery, conn)
                Using timeReader As MySqlDataReader = timeCMD.ExecuteReader
                    While timeReader.Read
                        Dim id As Integer = timeReader.GetInt32("slot_id")
                        Dim timeOfDay As String
                        If id < 4 Then
                            timeOfDay = "AM"
                        Else
                            timeOfDay = "PM"

                        End If
                        Dim startTime As String = timeReader.GetString("start_time")
                        Dim startParts() As String = startTime.Split(":")
                        Dim formattedStartTime As String = startParts(0) & ":" & startParts(1)

                        Dim endTime As String = timeReader.GetString("end_time")
                        Dim endParts() As String = endTime.Split(":")
                        Dim formattedEndTime As String = endParts(0) & ":" & endParts(1)

                        Dim time As String = formattedStartTime & "-" & formattedEndTime & timeOfDay

                        CLB_TimeAvail.Items.Add(time)
                    End While
                End Using
            End Using
        End Using
        BTN_Cancel.Focus()
    End Sub

    Private Sub CLB_DayAvail_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CLB_DayAvail.ItemCheck
        ' Unsubscribe from the event temporarily
        RemoveHandler CLB_DayAvail.ItemCheck, AddressOf CLB_DayAvail_ItemCheck

        ' Check if the first item (index 0) is being checked or unchecked
        If e.Index = 0 Then
            ' If it's being checked, check all items
            If e.NewValue = CheckState.Checked Then
                For i As Integer = 1 To CLB_DayAvail.Items.Count - 1
                    CLB_DayAvail.SetItemCheckState(i, CheckState.Checked)
                Next
            Else ' It's being unchecked, uncheck all items and uncheck the first item
                For i As Integer = 0 To CLB_DayAvail.Items.Count - 1
                    CLB_DayAvail.SetItemCheckState(i, CheckState.Unchecked)
                Next
            End If
        Else ' Any other item is being unchecked
            If e.NewValue = CheckState.Unchecked Then
                ' Uncheck the first item (index 0)
                CLB_DayAvail.SetItemCheckState(0, CheckState.Unchecked)
            End If
        End If

        ' Reattach the event handler
        AddHandler CLB_DayAvail.ItemCheck, AddressOf CLB_DayAvail_ItemCheck
    End Sub

    Private Sub CLB_TimeAvail_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CLB_TimeAvail.ItemCheck
        ' Unsubscribe from the event temporarily
        RemoveHandler CLB_TimeAvail.ItemCheck, AddressOf CLB_TimeAvail_ItemCheck

        ' Check if the first item (index 0) is being checked or unchecked
        If e.Index = 0 Then
            ' If it's being checked, check all items
            If e.NewValue = CheckState.Checked Then
                For i As Integer = 1 To CLB_TimeAvail.Items.Count - 1
                    CLB_TimeAvail.SetItemCheckState(i, CheckState.Checked)
                Next
            Else ' It's being unchecked, uncheck all items and uncheck the first item
                For i As Integer = 0 To CLB_DayAvail.Items.Count - 1
                    CLB_TimeAvail.SetItemCheckState(i, CheckState.Unchecked)
                Next
            End If
        Else ' Any other item is being unchecked
            If e.NewValue = CheckState.Unchecked Then
                ' Uncheck the first item (index 0)
                CLB_TimeAvail.SetItemCheckState(0, CheckState.Unchecked)
            End If
        End If

        ' Reattach the event handler
        AddHandler CLB_TimeAvail.ItemCheck, AddressOf CLB_TimeAvail_ItemCheck
    End Sub

    Private Sub TB_RoomName_Enter(sender As Object, e As EventArgs) Handles TB_RoomName.Enter
        If TB_RoomName.Text.Equals("Room Name") Then
            TB_RoomName.Clear()
        End If
    End Sub

    Private Sub TB_Capacity_Enter(sender As Object, e As EventArgs) Handles TB_Capacity.Enter
        If TB_Capacity.Text.Equals("Capacity") Then
            TB_Capacity.Clear()
        End If
    End Sub

    Private Sub CB_RoomType_MouseUp(sender As Object, e As MouseEventArgs) Handles CB_RoomType.MouseUp
        CB_RoomType.DroppedDown = True
    End Sub

    Private Sub BTN_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_Cancel.Click
        Me.Close()
    End Sub

    Private Sub BTN_Save_Click(sender As Object, e As EventArgs) Handles BTN_Save.Click
        If TB_RoomName.Text.Equals("") Or TB_RoomName.Text.Equals("Room Name") Then
            TB_RoomName.Focus()
            Return
        End If
        If TB_Capacity.Text.Equals("") Or TB_Capacity.Text.Equals("Capacity") Then
            TB_Capacity.Focus()
            Return
        End If
        If CB_RoomType.Text.Equals("Room Type") Then
            Return
        End If

        Dim roomName As String = TB_RoomName.Text.ToUpper
        Dim roomType As String = CB_RoomType.Text.ToUpper
        Dim roomCapacity As String = TB_Capacity.Text

        Dim selectedDays As New List(Of String)

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
                    cmd.Parameters.Add("@roomcap", MySqlDbType.Int32).Value = Integer.Parse(roomCapacity)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End If
    End Sub

    Private Sub TB_Capacity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_Capacity.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Suppress the character
        End If
    End Sub
End Class
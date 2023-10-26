﻿Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Classrooms

    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim ConnectionString As String = "Server=localhost;Database=acss;userid=root;password=;"


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
        BTN_Delete.Visible = False
        BTN_Edit.Visible = False
        AddRoom.Show()
    End Sub



    Public Sub RefreshListbox()
        RoomListView.Items.Clear()
        BTN_AddRoom.Visible = True
        Dim tempRoom As String

        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()

            Dim query As String = "SELECT * FROM rooms"

            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader
                    While reader.Read
                        Dim item As New ListViewItem(reader("room_id").ToString)
                        tempRoom = reader("room_id").ToString
                        item.SubItems.Add(reader("room_type").ToString)
                        item.SubItems.Add(reader("capacity").ToString)

                        Dim fetchQuery As String = "SELECT COUNT(*) FROM room_availability WHERE room_id = @roomId AND available = 1;"
                        Using fetchConn As New MySqlConnection(ConnectionString)
                            fetchConn.Open()

                            Using fetchCmd As New MySqlCommand(fetchQuery, fetchConn)

                                fetchCmd.Parameters.AddWithValue("@roomId", tempRoom)

                                Dim availableCount As Integer = Convert.ToInt32(fetchCmd.ExecuteScalar)

                                If availableCount > 0 Then
                                    item.SubItems.Add("Slot Available")
                                Else
                                    item.SubItems.Add("Not Available")
                                End If
                            End Using
                        End Using
                        RoomListView.Items.Add(item)
                    End While
                End Using
            End Using
        End Using
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

            Dim roomTimetable As New RoomTimeTable
            roomTimetable.RoomID(roomName, roomType)
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

    Private Sub TB_Search_TextChanged(sender As Object, e As EventArgs) Handles TB_Search.TextChanged
        If TB_Search.Text.Equals("Search Here") Then
            Return
        End If
        Dim searchQuery As String = TB_Search.Text
        Dim tempRoom As String

        Dim query As String = "SELECT * FROM rooms WHERE room_id LIKE @searchText"

        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@searchText", "%" & searchQuery & "%")

                Dim dt As New DataTable

                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using

                RoomListView.Items.Clear()
                For Each row As DataRow In dt.Rows
                    Dim item As New ListViewItem(row("room_id").ToString)
                    tempRoom = row("room_id").ToString
                    item.SubItems.Add(row("room_type").ToString)
                    item.SubItems.Add(row("capacity").ToString)
                    Dim fetchQuery As String = "SELECT COUNT(*) FROM room_availability WHERE room_id = @roomId AND available = 1;"
                    Using fetchConn As New MySqlConnection(ConnectionString)
                        fetchConn.Open()

                        Using fetchCmd As New MySqlCommand(fetchQuery, fetchConn)

                            fetchCmd.Parameters.AddWithValue("@roomId", tempRoom)

                            Dim availableCount As Integer = Convert.ToInt32(fetchCmd.ExecuteScalar)

                            If availableCount > 0 Then
                                item.SubItems.Add("Slot Available")
                            Else
                                item.SubItems.Add("Not Available")
                            End If
                        End Using
                    End Using
                    RoomListView.Items.Add(item)
                Next
            End Using
        End Using
    End Sub

    Private Sub FacultyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacultyToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Classrooms_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Faculty.Show()
    End Sub

    Private Sub Classrooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshListbox()
    End Sub
End Class

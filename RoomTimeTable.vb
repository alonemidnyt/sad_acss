Imports MySql.Data.MySqlClient

Public Class RoomTimeTable

    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim ConnectionString As String = "Server=localhost;Database=acss;userid=root;password=;"
    Dim room As String
    Dim rmtype As String

    Public Sub RoomID(ByVal roomid As String, ByVal roomtype As String)
        room = roomid
        rmtype = roomtype
        Me.Show()
    End Sub

    Private Sub RoomTimeTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_Name.Text = room
        LBL_Type.Text = rmtype
        DataGridView1.AutoResizeColumns()
        PopulateTimetable(room)
    End Sub

    Private Sub PopulateTimetable(roomID As String)
        DataGridView1.Rows.Clear()

        Dim dayName As String

        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Dim query As String = "SELECT slot_id, available FROM room_availability WHERE room_id = @roomID AND day_id = @dayId"
            Using cmd As New MySqlCommand(query, conn)

                For i As Integer = 1 To 7
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@dayId", i)
                    cmd.Parameters.AddWithValue("@roomID", room)

                    Dim newRow As New DataGridViewRow
                    Dim dayCell As New DataGridViewTextBoxCell()

                    Using dayConn As New MySqlConnection(ConnectionString)
                        dayConn.Open()

                        Dim dayQuery As String = "SELECT day_name FROM days WHERE day_id = @dayID"

                        Using dayCmd As New MySqlCommand(dayQuery, dayConn)
                            dayCmd.Parameters.AddWithValue("@dayID", i)
                            dayName = Convert.ToString(dayCmd.ExecuteScalar()).ToUpper
                            dayCell.Value = dayName
                        End Using
                    End Using

                    newRow.Cells.Add(dayCell)

                    Using reader As MySqlDataReader = cmd.ExecuteReader
                        While reader.Read
                            Dim statusCell As New DataGridViewTextBoxCell()
                            Dim timeID As Integer = reader.GetInt32("slot_id")
                            Dim available As Integer = reader.GetInt32("available")
                            Dim status As String = If(available = 1, "Available", "N/A")
                            statusCell.Value = status
                            If status.Equals("Available") Then
                                statusCell.Style.BackColor = Color.Green
                            Else
                                statusCell.Style.BackColor = Color.Red
                            End If
                            newRow.Cells.Add(statusCell)
                        End While
                    End Using
                    DataGridView1.Rows.Add(newRow)
                Next
            End Using
        End Using
    End Sub
End Class

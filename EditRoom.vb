Imports Google.Protobuf
Imports MySql.Data.MySqlClient

Public Class EditRoom

    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim ConnectionString As String = "Server=localhost;Database=acss;userid=root;password=;"


    Dim classRoom As Classrooms = Application.OpenForms.OfType(Of Classrooms).FirstOrDefault()

    Public Sub New(roomName As String, roomType As String, roomCapacity As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LBL_RoomName.Text = roomName
        CB_RoomType.Text = roomType
        TB_Capacity.Text = roomCapacity

    End Sub
    Private Sub EditRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If classRoom IsNot Nothing Then
            Dim x = classRoom.Location.X + (classRoom.Width - Me.Width) / 2
            Dim y = classRoom.Location.Y + (classRoom.Height - Me.Height) / 2
            Me.Location = New Point(x, y)
        End If
    End Sub

    Private Sub BTN_Save_Click(sender As Object, e As EventArgs) Handles BTN_Save.Click
        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Dim query As String = "UPDATE rooms SET room_type = @roomtype, capacity = @roomcapacity WHERE room_id = @roomid"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@roomid", LBL_RoomName.Text)
                cmd.Parameters.AddWithValue("@roomtype", CB_RoomType.Text)
                cmd.Parameters.AddWithValue("@roomcapacity", Integer.Parse(TB_Capacity.Text))

                cmd.ExecuteNonQuery()
            End Using
        End Using
            Me.Close()
    End Sub

    Private Sub EditRoom_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        classRoom.Enabled = True
        classRoom.RefreshListbox()
        classRoom.Focus()
    End Sub
End Class
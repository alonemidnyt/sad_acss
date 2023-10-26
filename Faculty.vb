Imports Org.BouncyCastle.Asn1.X509

Public Class Faculty
    Private Sub TB_Search_Enter(sender As Object, e As EventArgs) Handles TB_Search.Enter
        If TB_Search.Text.Equals("Search Faculty") Then
            TB_Search.Clear()
            TB_Search.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TB_Search_Leave(sender As Object, e As EventArgs) Handles TB_Search.Leave
        If String.IsNullOrWhiteSpace(TB_Search.Text) Then
            TB_Search.Text = "Search Faculty"
            TB_Search.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub ClassroomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassroomToolStripMenuItem.Click
        Classrooms.Show()
        Me.Close()
    End Sub

    Private Sub Faculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
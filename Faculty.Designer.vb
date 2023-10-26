<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Faculty
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        MenuToolStripMenuItem = New ToolStripMenuItem()
        ClassroomToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1 = New GroupBox()
        TB_Search = New TextBox()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(914, 30)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuToolStripMenuItem
        ' 
        MenuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClassroomToolStripMenuItem})
        MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        MenuToolStripMenuItem.Size = New Size(60, 24)
        MenuToolStripMenuItem.Text = "Menu"
        ' 
        ' ClassroomToolStripMenuItem
        ' 
        ClassroomToolStripMenuItem.Name = "ClassroomToolStripMenuItem"
        ClassroomToolStripMenuItem.Size = New Size(161, 26)
        ClassroomToolStripMenuItem.Text = "Classroom"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TB_Search)
        GroupBox1.Controls.Add(ListView1)
        GroupBox1.Location = New Point(12, 33)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(890, 611)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Faculty"
        ' 
        ' TB_Search
        ' 
        TB_Search.Location = New Point(613, 26)
        TB_Search.Name = "TB_Search"
        TB_Search.PlaceholderText = "Search Faculty"
        TB_Search.Size = New Size(271, 27)
        TB_Search.TabIndex = 1
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3})
        ListView1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ListView1.Location = New Point(3, 59)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(881, 546)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Name"
        ColumnHeader1.Width = 300
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Department"
        ColumnHeader2.Width = 200
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Status"
        ColumnHeader3.TextAlign = HorizontalAlignment.Center
        ColumnHeader3.Width = 377
        ' 
        ' Faculty
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 656)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "Faculty"
        Text = "Automated Class Scheduling System"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents TB_Search As TextBox
    Friend WithEvents ClassroomToolStripMenuItem As ToolStripMenuItem
End Class

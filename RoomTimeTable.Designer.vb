<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomTimeTable
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
        DataGridView1 = New DataGridView()
        day = New DataGridViewTextBoxColumn()
        slot1 = New DataGridViewTextBoxColumn()
        slot2 = New DataGridViewTextBoxColumn()
        slot3 = New DataGridViewTextBoxColumn()
        slot4 = New DataGridViewTextBoxColumn()
        slot5 = New DataGridViewTextBoxColumn()
        slot6 = New DataGridViewTextBoxColumn()
        slot7 = New DataGridViewTextBoxColumn()
        LBL_Name = New Label()
        LBL_Type = New Label()
        GroupBox1 = New GroupBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {day, slot1, slot2, slot3, slot4, slot5, slot6, slot7})
        DataGridView1.Location = New Point(6, 22)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(846, 228)
        DataGridView1.TabIndex = 0
        ' 
        ' day
        ' 
        day.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        day.HeaderText = "Day"
        day.Name = "day"
        day.ReadOnly = True
        day.Resizable = DataGridViewTriState.False
        day.Width = 52
        ' 
        ' slot1
        ' 
        slot1.HeaderText = "7:30-9:00AM"
        slot1.Name = "slot1"
        slot1.ReadOnly = True
        slot1.Resizable = DataGridViewTriState.False
        ' 
        ' slot2
        ' 
        slot2.HeaderText = "9:00-10:30AM"
        slot2.Name = "slot2"
        slot2.ReadOnly = True
        slot2.Resizable = DataGridViewTriState.False
        ' 
        ' slot3
        ' 
        slot3.HeaderText = "10:30-12:00PM"
        slot3.Name = "slot3"
        slot3.ReadOnly = True
        slot3.Resizable = DataGridViewTriState.False
        ' 
        ' slot4
        ' 
        slot4.HeaderText = "1:00-2:30PM"
        slot4.Name = "slot4"
        slot4.ReadOnly = True
        slot4.Resizable = DataGridViewTriState.False
        ' 
        ' slot5
        ' 
        slot5.HeaderText = "2:30-4:00PM"
        slot5.Name = "slot5"
        slot5.ReadOnly = True
        slot5.Resizable = DataGridViewTriState.False
        ' 
        ' slot6
        ' 
        slot6.HeaderText = "4:00-5:30PM"
        slot6.Name = "slot6"
        slot6.ReadOnly = True
        slot6.Resizable = DataGridViewTriState.False
        ' 
        ' slot7
        ' 
        slot7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        slot7.HeaderText = "5:30-7:00PM"
        slot7.Name = "slot7"
        slot7.ReadOnly = True
        slot7.Resizable = DataGridViewTriState.False
        ' 
        ' LBL_Name
        ' 
        LBL_Name.AutoSize = True
        LBL_Name.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LBL_Name.Location = New Point(12, 9)
        LBL_Name.Name = "LBL_Name"
        LBL_Name.Size = New Size(55, 21)
        LBL_Name.TabIndex = 1
        LBL_Name.Text = "Name:"
        ' 
        ' LBL_Type
        ' 
        LBL_Type.AutoSize = True
        LBL_Type.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LBL_Type.Location = New Point(12, 30)
        LBL_Type.Name = "LBL_Type"
        LBL_Type.Size = New Size(88, 21)
        LBL_Type.TabIndex = 2
        LBL_Type.Text = "Room Type"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Location = New Point(12, 66)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(862, 261)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Time Availability"
        ' 
        ' RoomTimeTable
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(886, 339)
        Controls.Add(GroupBox1)
        Controls.Add(LBL_Type)
        Controls.Add(LBL_Name)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "RoomTimeTable"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Room Information"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents day As DataGridViewTextBoxColumn
    Friend WithEvents slot1 As DataGridViewTextBoxColumn
    Friend WithEvents slot2 As DataGridViewTextBoxColumn
    Friend WithEvents slot3 As DataGridViewTextBoxColumn
    Friend WithEvents slot4 As DataGridViewTextBoxColumn
    Friend WithEvents slot5 As DataGridViewTextBoxColumn
    Friend WithEvents slot6 As DataGridViewTextBoxColumn
    Friend WithEvents slot7 As DataGridViewTextBoxColumn
    Friend WithEvents LBL_Name As Label
    Friend WithEvents LBL_Type As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class

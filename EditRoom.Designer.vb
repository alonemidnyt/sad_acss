<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditRoom
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
        Label1 = New Label()
        LBL_RoomName = New Label()
        Label3 = New Label()
        CB_RoomType = New ComboBox()
        Label4 = New Label()
        TB_Capacity = New TextBox()
        BTN_Save = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 21)
        Label1.TabIndex = 0
        Label1.Text = "Room Name:"
        ' 
        ' LBL_RoomName
        ' 
        LBL_RoomName.AutoSize = True
        LBL_RoomName.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LBL_RoomName.Location = New Point(119, 9)
        LBL_RoomName.Name = "LBL_RoomName"
        LBL_RoomName.Size = New Size(31, 21)
        LBL_RoomName.TabIndex = 1
        LBL_RoomName.Text = "rm"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 21)
        Label3.TabIndex = 2
        Label3.Text = "Room Type:"
        ' 
        ' CB_RoomType
        ' 
        CB_RoomType.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CB_RoomType.FormattingEnabled = True
        CB_RoomType.Items.AddRange(New Object() {"LEC", "COM-LAB", "SCI-LAB"})
        CB_RoomType.Location = New Point(109, 38)
        CB_RoomType.Name = "CB_RoomType"
        CB_RoomType.Size = New Size(163, 29)
        CB_RoomType.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(12, 76)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 21)
        Label4.TabIndex = 4
        Label4.Text = "Capacity:"
        ' 
        ' TB_Capacity
        ' 
        TB_Capacity.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Capacity.Location = New Point(90, 73)
        TB_Capacity.Name = "TB_Capacity"
        TB_Capacity.Size = New Size(182, 29)
        TB_Capacity.TabIndex = 5
        ' 
        ' BTN_Save
        ' 
        BTN_Save.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BTN_Save.Location = New Point(76, 109)
        BTN_Save.Name = "BTN_Save"
        BTN_Save.Size = New Size(141, 32)
        BTN_Save.TabIndex = 6
        BTN_Save.Text = "SAVE"
        BTN_Save.UseVisualStyleBackColor = True
        ' 
        ' EditRoom
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(284, 153)
        Controls.Add(BTN_Save)
        Controls.Add(TB_Capacity)
        Controls.Add(Label4)
        Controls.Add(CB_RoomType)
        Controls.Add(Label3)
        Controls.Add(LBL_RoomName)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "EditRoom"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Room"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LBL_RoomName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CB_RoomType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_Capacity As TextBox
    Friend WithEvents BTN_Save As Button
End Class

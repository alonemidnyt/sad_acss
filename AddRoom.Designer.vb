<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRoom
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
        TB_RoomName = New TextBox()
        TB_Capacity = New TextBox()
        CB_RoomType = New ComboBox()
        Label2 = New Label()
        BTN_Save = New Button()
        BTN_Cancel = New Button()
        CLB_DayAvail = New CheckedListBox()
        Label1 = New Label()
        CLB_TimeAvail = New CheckedListBox()
        SuspendLayout()
        ' 
        ' TB_RoomName
        ' 
        TB_RoomName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TB_RoomName.Location = New Point(12, 12)
        TB_RoomName.Name = "TB_RoomName"
        TB_RoomName.Size = New Size(273, 29)
        TB_RoomName.TabIndex = 0
        TB_RoomName.Text = "Room Name"
        ' 
        ' TB_Capacity
        ' 
        TB_Capacity.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Capacity.Location = New Point(12, 47)
        TB_Capacity.Name = "TB_Capacity"
        TB_Capacity.Size = New Size(273, 29)
        TB_Capacity.TabIndex = 1
        TB_Capacity.Text = "Capacity"
        ' 
        ' CB_RoomType
        ' 
        CB_RoomType.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CB_RoomType.FormattingEnabled = True
        CB_RoomType.Items.AddRange(New Object() {"LEC", "COM-LAB", "SCI-LAB"})
        CB_RoomType.Location = New Point(12, 82)
        CB_RoomType.Name = "CB_RoomType"
        CB_RoomType.Size = New Size(273, 29)
        CB_RoomType.TabIndex = 2
        CB_RoomType.Text = "Room Type"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 293)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 21)
        Label2.TabIndex = 5
        Label2.Text = "Availability (TIME)"
        ' 
        ' BTN_Save
        ' 
        BTN_Save.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BTN_Save.Location = New Point(55, 471)
        BTN_Save.Name = "BTN_Save"
        BTN_Save.Size = New Size(91, 33)
        BTN_Save.TabIndex = 7
        BTN_Save.Text = "Save"
        BTN_Save.UseVisualStyleBackColor = True
        ' 
        ' BTN_Cancel
        ' 
        BTN_Cancel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BTN_Cancel.Location = New Point(152, 471)
        BTN_Cancel.Name = "BTN_Cancel"
        BTN_Cancel.Size = New Size(91, 33)
        BTN_Cancel.TabIndex = 8
        BTN_Cancel.Text = "Cancel"
        BTN_Cancel.UseVisualStyleBackColor = True
        ' 
        ' CLB_DayAvail
        ' 
        CLB_DayAvail.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CLB_DayAvail.FormattingEnabled = True
        CLB_DayAvail.Items.AddRange(New Object() {"Select All"})
        CLB_DayAvail.Location = New Point(12, 142)
        CLB_DayAvail.Name = "CLB_DayAvail"
        CLB_DayAvail.Size = New Size(273, 148)
        CLB_DayAvail.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 21)
        Label1.TabIndex = 10
        Label1.Text = "Availability (DAY)"
        ' 
        ' CLB_TimeAvail
        ' 
        CLB_TimeAvail.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CLB_TimeAvail.FormattingEnabled = True
        CLB_TimeAvail.Items.AddRange(New Object() {"Select All"})
        CLB_TimeAvail.Location = New Point(12, 317)
        CLB_TimeAvail.Name = "CLB_TimeAvail"
        CLB_TimeAvail.Size = New Size(273, 148)
        CLB_TimeAvail.TabIndex = 11
        ' 
        ' AddRoom
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(297, 515)
        Controls.Add(CLB_TimeAvail)
        Controls.Add(Label1)
        Controls.Add(CLB_DayAvail)
        Controls.Add(BTN_Cancel)
        Controls.Add(BTN_Save)
        Controls.Add(Label2)
        Controls.Add(CB_RoomType)
        Controls.Add(TB_Capacity)
        Controls.Add(TB_RoomName)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "AddRoom"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Room Type"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TB_RoomName As TextBox
    Friend WithEvents TB_Capacity As TextBox
    Friend WithEvents CB_RoomType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_Save As Button
    Friend WithEvents BTN_Cancel As Button
    Friend WithEvents CLB_DayAvail As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CLB_TimeAvail As CheckedListBox
End Class

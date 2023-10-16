<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Classrooms
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        MenuToolStripMenuItem = New ToolStripMenuItem()
        BTN_AddRoom = New Button()
        GB_Classrooms = New GroupBox()
        BTN_Edit = New Button()
        BTN_Delete = New Button()
        RoomListView = New ListView()
        room_id = New ColumnHeader()
        room_type = New ColumnHeader()
        capacity = New ColumnHeader()
        status = New ColumnHeader()
        BTN_Search = New Button()
        TB_Search = New TextBox()
        TB_AddRoomName = New TextBox()
        CB_AddRoomType = New ComboBox()
        TB_AddCapacity = New TextBox()
        BTN_AddSave = New Button()
        BTN_AddCancel = New Button()
        MenuStrip1.SuspendLayout()
        GB_Classrooms.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuToolStripMenuItem
        ' 
        MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        MenuToolStripMenuItem.Size = New Size(50, 20)
        MenuToolStripMenuItem.Text = "Menu"
        ' 
        ' BTN_AddRoom
        ' 
        BTN_AddRoom.Location = New Point(615, 449)
        BTN_AddRoom.Name = "BTN_AddRoom"
        BTN_AddRoom.Size = New Size(173, 31)
        BTN_AddRoom.TabIndex = 2
        BTN_AddRoom.Text = "Add Classroom"
        BTN_AddRoom.UseVisualStyleBackColor = True
        ' 
        ' GB_Classrooms
        ' 
        GB_Classrooms.Controls.Add(BTN_Edit)
        GB_Classrooms.Controls.Add(BTN_Delete)
        GB_Classrooms.Controls.Add(RoomListView)
        GB_Classrooms.Controls.Add(BTN_Search)
        GB_Classrooms.Controls.Add(TB_Search)
        GB_Classrooms.Location = New Point(12, 27)
        GB_Classrooms.Name = "GB_Classrooms"
        GB_Classrooms.Size = New Size(776, 416)
        GB_Classrooms.TabIndex = 3
        GB_Classrooms.TabStop = False
        GB_Classrooms.Text = "Classrooms"
        ' 
        ' BTN_Edit
        ' 
        BTN_Edit.BackColor = Color.Green
        BTN_Edit.BackgroundImage = My.Resources.Resources.edit
        BTN_Edit.BackgroundImageLayout = ImageLayout.Stretch
        BTN_Edit.Location = New Point(37, 22)
        BTN_Edit.Name = "BTN_Edit"
        BTN_Edit.Size = New Size(25, 23)
        BTN_Edit.TabIndex = 4
        BTN_Edit.UseVisualStyleBackColor = False
        BTN_Edit.Visible = False
        ' 
        ' BTN_Delete
        ' 
        BTN_Delete.BackColor = Color.Red
        BTN_Delete.BackgroundImage = My.Resources.Resources.delete
        BTN_Delete.BackgroundImageLayout = ImageLayout.Stretch
        BTN_Delete.ForeColor = SystemColors.ControlLightLight
        BTN_Delete.Location = New Point(6, 22)
        BTN_Delete.Name = "BTN_Delete"
        BTN_Delete.Size = New Size(25, 23)
        BTN_Delete.TabIndex = 3
        BTN_Delete.UseVisualStyleBackColor = False
        BTN_Delete.Visible = False
        ' 
        ' RoomListView
        ' 
        RoomListView.Alignment = ListViewAlignment.Default
        RoomListView.Columns.AddRange(New ColumnHeader() {room_id, room_type, capacity, status})
        RoomListView.FullRowSelect = True
        RoomListView.HeaderStyle = ColumnHeaderStyle.Nonclickable
        RoomListView.Location = New Point(6, 51)
        RoomListView.Name = "RoomListView"
        RoomListView.ShowGroups = False
        RoomListView.Size = New Size(764, 359)
        RoomListView.TabIndex = 2
        RoomListView.UseCompatibleStateImageBehavior = False
        RoomListView.View = View.Details
        ' 
        ' room_id
        ' 
        room_id.Text = "Room Name"
        room_id.Width = 200
        ' 
        ' room_type
        ' 
        room_type.Text = "Room Type"
        room_type.Width = 150
        ' 
        ' capacity
        ' 
        capacity.Text = "Capacity"
        capacity.Width = 100
        ' 
        ' status
        ' 
        status.Text = "Status"
        status.Width = 310
        ' 
        ' BTN_Search
        ' 
        BTN_Search.Location = New Point(695, 22)
        BTN_Search.Name = "BTN_Search"
        BTN_Search.Size = New Size(75, 23)
        BTN_Search.TabIndex = 1
        BTN_Search.Text = "Search"
        BTN_Search.UseVisualStyleBackColor = True
        ' 
        ' TB_Search
        ' 
        TB_Search.ForeColor = Color.Gray
        TB_Search.Location = New Point(439, 22)
        TB_Search.Name = "TB_Search"
        TB_Search.Size = New Size(250, 23)
        TB_Search.TabIndex = 0
        TB_Search.Text = "Search Here"
        ' 
        ' TB_AddRoomName
        ' 
        TB_AddRoomName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TB_AddRoomName.ForeColor = Color.Gray
        TB_AddRoomName.Location = New Point(18, 451)
        TB_AddRoomName.Name = "TB_AddRoomName"
        TB_AddRoomName.Size = New Size(321, 29)
        TB_AddRoomName.TabIndex = 4
        TB_AddRoomName.Text = "Enter Room Name"
        TB_AddRoomName.Visible = False
        ' 
        ' CB_AddRoomType
        ' 
        CB_AddRoomType.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CB_AddRoomType.ForeColor = Color.Gray
        CB_AddRoomType.FormattingEnabled = True
        CB_AddRoomType.Items.AddRange(New Object() {"LEC", "COM-LAB", "SCI-LAB"})
        CB_AddRoomType.Location = New Point(345, 451)
        CB_AddRoomType.Name = "CB_AddRoomType"
        CB_AddRoomType.Size = New Size(138, 29)
        CB_AddRoomType.TabIndex = 5
        CB_AddRoomType.Text = "Room Type"
        CB_AddRoomType.Visible = False
        ' 
        ' TB_AddCapacity
        ' 
        TB_AddCapacity.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TB_AddCapacity.ForeColor = Color.Gray
        TB_AddCapacity.Location = New Point(489, 451)
        TB_AddCapacity.Name = "TB_AddCapacity"
        TB_AddCapacity.Size = New Size(120, 29)
        TB_AddCapacity.TabIndex = 6
        TB_AddCapacity.Text = "Capacity"
        TB_AddCapacity.Visible = False
        ' 
        ' BTN_AddSave
        ' 
        BTN_AddSave.Location = New Point(615, 449)
        BTN_AddSave.Name = "BTN_AddSave"
        BTN_AddSave.Size = New Size(86, 31)
        BTN_AddSave.TabIndex = 7
        BTN_AddSave.Text = "Save"
        BTN_AddSave.UseVisualStyleBackColor = True
        BTN_AddSave.Visible = False
        ' 
        ' BTN_AddCancel
        ' 
        BTN_AddCancel.Location = New Point(707, 449)
        BTN_AddCancel.Name = "BTN_AddCancel"
        BTN_AddCancel.Size = New Size(81, 31)
        BTN_AddCancel.TabIndex = 8
        BTN_AddCancel.Text = "Cancel"
        BTN_AddCancel.UseVisualStyleBackColor = True
        BTN_AddCancel.Visible = False
        ' 
        ' Classrooms
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 492)
        Controls.Add(BTN_AddCancel)
        Controls.Add(BTN_AddSave)
        Controls.Add(TB_AddCapacity)
        Controls.Add(CB_AddRoomType)
        Controls.Add(TB_AddRoomName)
        Controls.Add(GB_Classrooms)
        Controls.Add(BTN_AddRoom)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Classrooms"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Automated Class Scheduling System"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GB_Classrooms.ResumeLayout(False)
        GB_Classrooms.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BTN_AddRoom As Button
    Friend WithEvents GB_Classrooms As GroupBox
    Friend WithEvents BTN_Search As Button
    Friend WithEvents TB_Search As TextBox
    Friend WithEvents RoomListView As ListView
    Friend WithEvents room_id As ColumnHeader
    Friend WithEvents room_type As ColumnHeader
    Friend WithEvents capacity As ColumnHeader
    Friend WithEvents status As ColumnHeader
    Friend WithEvents BTN_Delete As Button
    Friend WithEvents TB_AddRoomName As TextBox
    Friend WithEvents CB_AddRoomType As ComboBox
    Friend WithEvents TB_AddCapacity As TextBox
    Friend WithEvents BTN_AddSave As Button
    Friend WithEvents BTN_AddCancel As Button
    Friend WithEvents BTN_Edit As Button
End Class

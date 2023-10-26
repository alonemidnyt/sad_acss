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
        FacultyToolStripMenuItem = New ToolStripMenuItem()
        BTN_AddRoom = New Button()
        GB_Classrooms = New GroupBox()
        BTN_Edit = New Button()
        BTN_Delete = New Button()
        RoomListView = New ListView()
        room_id = New ColumnHeader()
        room_type = New ColumnHeader()
        capacity = New ColumnHeader()
        status = New ColumnHeader()
        TB_Search = New TextBox()
        MenuStrip1.SuspendLayout()
        GB_Classrooms.SuspendLayout()
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
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuToolStripMenuItem
        ' 
        MenuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FacultyToolStripMenuItem})
        MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        MenuToolStripMenuItem.Size = New Size(60, 24)
        MenuToolStripMenuItem.Text = "Menu"
        ' 
        ' FacultyToolStripMenuItem
        ' 
        FacultyToolStripMenuItem.Name = "FacultyToolStripMenuItem"
        FacultyToolStripMenuItem.Size = New Size(137, 26)
        FacultyToolStripMenuItem.Text = "Faculty"
        ' 
        ' BTN_AddRoom
        ' 
        BTN_AddRoom.Location = New Point(78, 24)
        BTN_AddRoom.Margin = New Padding(3, 4, 3, 4)
        BTN_AddRoom.Name = "BTN_AddRoom"
        BTN_AddRoom.Size = New Size(198, 41)
        BTN_AddRoom.TabIndex = 2
        BTN_AddRoom.Text = "Add Classroom"
        BTN_AddRoom.UseVisualStyleBackColor = True
        ' 
        ' GB_Classrooms
        ' 
        GB_Classrooms.Controls.Add(BTN_Edit)
        GB_Classrooms.Controls.Add(BTN_AddRoom)
        GB_Classrooms.Controls.Add(BTN_Delete)
        GB_Classrooms.Controls.Add(RoomListView)
        GB_Classrooms.Controls.Add(TB_Search)
        GB_Classrooms.Location = New Point(14, 36)
        GB_Classrooms.Margin = New Padding(3, 4, 3, 4)
        GB_Classrooms.Name = "GB_Classrooms"
        GB_Classrooms.Padding = New Padding(3, 4, 3, 4)
        GB_Classrooms.Size = New Size(887, 604)
        GB_Classrooms.TabIndex = 3
        GB_Classrooms.TabStop = False
        GB_Classrooms.Text = "Classrooms"
        ' 
        ' BTN_Edit
        ' 
        BTN_Edit.BackColor = Color.Green
        BTN_Edit.BackgroundImage = My.Resources.Resources.edit
        BTN_Edit.BackgroundImageLayout = ImageLayout.Stretch
        BTN_Edit.Location = New Point(42, 29)
        BTN_Edit.Margin = New Padding(3, 4, 3, 4)
        BTN_Edit.Name = "BTN_Edit"
        BTN_Edit.Size = New Size(29, 31)
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
        BTN_Delete.Location = New Point(7, 29)
        BTN_Delete.Margin = New Padding(3, 4, 3, 4)
        BTN_Delete.Name = "BTN_Delete"
        BTN_Delete.Size = New Size(29, 31)
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
        RoomListView.Location = New Point(7, 68)
        RoomListView.Margin = New Padding(3, 4, 3, 4)
        RoomListView.Name = "RoomListView"
        RoomListView.ShowGroups = False
        RoomListView.Size = New Size(873, 535)
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
        ' TB_Search
        ' 
        TB_Search.ForeColor = Color.Gray
        TB_Search.Location = New Point(502, 29)
        TB_Search.Margin = New Padding(3, 4, 3, 4)
        TB_Search.Name = "TB_Search"
        TB_Search.Size = New Size(378, 27)
        TB_Search.TabIndex = 0
        TB_Search.Text = "Search Here"
        ' 
        ' Classrooms
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 656)
        Controls.Add(GB_Classrooms)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
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
    Friend WithEvents TB_Search As TextBox
    Friend WithEvents RoomListView As ListView
    Friend WithEvents room_id As ColumnHeader
    Friend WithEvents room_type As ColumnHeader
    Friend WithEvents capacity As ColumnHeader
    Friend WithEvents status As ColumnHeader
    Friend WithEvents BTN_Delete As Button
    Friend WithEvents BTN_Edit As Button
    Friend WithEvents FacultyToolStripMenuItem As ToolStripMenuItem
End Class

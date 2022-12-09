<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabPageDatabases = New System.Windows.Forms.TabPage()
        Me.ButtonDrop = New System.Windows.Forms.Button()
        Me.ButtonRestor = New System.Windows.Forms.Button()
        Me.ButtonBackup = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPageConnection = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTPass = New System.Windows.Forms.TextBox()
        Me.lblDBHD = New System.Windows.Forms.Label()
        Me.ComboboxDataBase = New System.Windows.Forms.ComboBox()
        Me.TXTUser = New System.Windows.Forms.TextBox()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.TXTServername = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageDatabases.SuspendLayout()
        Me.TabPageConnection.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPageDatabases
        '
        Me.TabPageDatabases.Controls.Add(Me.Label10)
        Me.TabPageDatabases.Controls.Add(Me.Label9)
        Me.TabPageDatabases.Controls.Add(Me.Label8)
        Me.TabPageDatabases.Controls.Add(Me.ButtonBackup)
        Me.TabPageDatabases.Controls.Add(Me.ButtonRestor)
        Me.TabPageDatabases.Controls.Add(Me.ButtonDrop)
        Me.TabPageDatabases.Location = New System.Drawing.Point(4, 23)
        Me.TabPageDatabases.Name = "TabPageDatabases"
        Me.TabPageDatabases.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDatabases.Size = New System.Drawing.Size(440, 200)
        Me.TabPageDatabases.TabIndex = 2
        Me.TabPageDatabases.Text = "Databases"
        Me.TabPageDatabases.UseVisualStyleBackColor = True
        '
        'ButtonDrop
        '
        Me.ButtonDrop.BackgroundImage = CType(resources.GetObject("ButtonDrop.BackgroundImage"), System.Drawing.Image)
        Me.ButtonDrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonDrop.FlatAppearance.BorderSize = 0
        Me.ButtonDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDrop.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDrop.Location = New System.Drawing.Point(290, 54)
        Me.ButtonDrop.Name = "ButtonDrop"
        Me.ButtonDrop.Size = New System.Drawing.Size(87, 81)
        Me.ButtonDrop.TabIndex = 2
        Me.ButtonDrop.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ButtonDrop, "Drop Database ...")
        Me.ButtonDrop.UseVisualStyleBackColor = True
        '
        'ButtonRestor
        '
        Me.ButtonRestor.BackgroundImage = CType(resources.GetObject("ButtonRestor.BackgroundImage"), System.Drawing.Image)
        Me.ButtonRestor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonRestor.FlatAppearance.BorderSize = 0
        Me.ButtonRestor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRestor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRestor.Location = New System.Drawing.Point(176, 54)
        Me.ButtonRestor.Name = "ButtonRestor"
        Me.ButtonRestor.Size = New System.Drawing.Size(87, 81)
        Me.ButtonRestor.TabIndex = 1
        Me.ButtonRestor.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ButtonRestor, "Restore Database ...")
        Me.ButtonRestor.UseVisualStyleBackColor = True
        '
        'ButtonBackup
        '
        Me.ButtonBackup.BackgroundImage = CType(resources.GetObject("ButtonBackup.BackgroundImage"), System.Drawing.Image)
        Me.ButtonBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonBackup.FlatAppearance.BorderSize = 0
        Me.ButtonBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBackup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBackup.Location = New System.Drawing.Point(62, 54)
        Me.ButtonBackup.Name = "ButtonBackup"
        Me.ButtonBackup.Size = New System.Drawing.Size(87, 81)
        Me.ButtonBackup.TabIndex = 0
        Me.ButtonBackup.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ButtonBackup, "Backup Database ...")
        Me.ButtonBackup.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(316, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 14)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Drop"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(194, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 14)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Restore"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(82, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 14)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Backup"
        '
        'TabPageConnection
        '
        Me.TabPageConnection.Controls.Add(Me.TXTServername)
        Me.TabPageConnection.Controls.Add(Me.ButtonRefresh)
        Me.TabPageConnection.Controls.Add(Me.TXTUser)
        Me.TabPageConnection.Controls.Add(Me.ComboboxDataBase)
        Me.TabPageConnection.Controls.Add(Me.lblDBHD)
        Me.TabPageConnection.Controls.Add(Me.TXTPass)
        Me.TabPageConnection.Controls.Add(Me.Label4)
        Me.TabPageConnection.Controls.Add(Me.Label3)
        Me.TabPageConnection.Controls.Add(Me.Label1)
        Me.TabPageConnection.Location = New System.Drawing.Point(4, 23)
        Me.TabPageConnection.Name = "TabPageConnection"
        Me.TabPageConnection.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageConnection.Size = New System.Drawing.Size(440, 200)
        Me.TabPageConnection.TabIndex = 0
        Me.TabPageConnection.Text = "Connection"
        Me.TabPageConnection.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Location = New System.Drawing.Point(3, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Server N / IP :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Location = New System.Drawing.Point(7, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 22)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "User :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label4.Location = New System.Drawing.Point(7, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 22)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Pasword :"
        '
        'TXTPass
        '
        Me.TXTPass.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.TXTPass.Location = New System.Drawing.Point(183, 87)
        Me.TXTPass.Name = "TXTPass"
        Me.TXTPass.Size = New System.Drawing.Size(244, 28)
        Me.TXTPass.TabIndex = 2
        Me.TXTPass.UseSystemPasswordChar = True
        '
        'lblDBHD
        '
        Me.lblDBHD.AutoSize = True
        Me.lblDBHD.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDBHD.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblDBHD.Location = New System.Drawing.Point(7, 125)
        Me.lblDBHD.Name = "lblDBHD"
        Me.lblDBHD.Size = New System.Drawing.Size(110, 22)
        Me.lblDBHD.TabIndex = 15
        Me.lblDBHD.Text = "Database :"
        '
        'ComboboxDataBase
        '
        Me.ComboboxDataBase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboboxDataBase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboboxDataBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboboxDataBase.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.ComboboxDataBase.FormattingEnabled = True
        Me.ComboboxDataBase.Location = New System.Drawing.Point(183, 122)
        Me.ComboboxDataBase.Name = "ComboboxDataBase"
        Me.ComboboxDataBase.Size = New System.Drawing.Size(244, 30)
        Me.ComboboxDataBase.TabIndex = 3
        '
        'TXTUser
        '
        Me.TXTUser.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.TXTUser.Location = New System.Drawing.Point(183, 53)
        Me.TXTUser.Name = "TXTUser"
        Me.TXTUser.Size = New System.Drawing.Size(244, 28)
        Me.TXTUser.TabIndex = 1
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRefresh.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefresh.ForeColor = System.Drawing.Color.Gray
        Me.ButtonRefresh.Image = CType(resources.GetObject("ButtonRefresh.Image"), System.Drawing.Image)
        Me.ButtonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRefresh.Location = New System.Drawing.Point(183, 157)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(245, 31)
        Me.ButtonRefresh.TabIndex = 4
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.ButtonRefresh, "Refresh")
        Me.ButtonRefresh.UseVisualStyleBackColor = False
        '
        'TXTServername
        '
        Me.TXTServername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXTServername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXTServername.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.TXTServername.ForeColor = System.Drawing.Color.Red
        Me.TXTServername.FormattingEnabled = True
        Me.TXTServername.Location = New System.Drawing.Point(183, 17)
        Me.TXTServername.Name = "TXTServername"
        Me.TXTServername.Size = New System.Drawing.Size(244, 30)
        Me.TXTServername.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageConnection)
        Me.TabControl1.Controls.Add(Me.TabPageDatabases)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(448, 227)
        Me.TabControl1.TabIndex = 0
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(448, 227)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainFrm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BACKUP . RESTORE . DROP ."
        Me.TabPageDatabases.ResumeLayout(False)
        Me.TabPageDatabases.PerformLayout()
        Me.TabPageConnection.ResumeLayout(False)
        Me.TabPageConnection.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TabPageDatabases As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ButtonBackup As System.Windows.Forms.Button
    Friend WithEvents ButtonRestor As System.Windows.Forms.Button
    Friend WithEvents ButtonDrop As System.Windows.Forms.Button
    Friend WithEvents TabPageConnection As System.Windows.Forms.TabPage
    Friend WithEvents TXTServername As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents TXTUser As System.Windows.Forms.TextBox
    Friend WithEvents ComboboxDataBase As System.Windows.Forms.ComboBox
    Friend WithEvents lblDBHD As System.Windows.Forms.Label
    Friend WithEvents TXTPass As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
End Class

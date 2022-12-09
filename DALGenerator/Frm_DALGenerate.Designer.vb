<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_DALGenerate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_DALGenerate))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonDrop = New System.Windows.Forms.Button()
        Me.ButtonRestor = New System.Windows.Forms.Button()
        Me.ButtonBackup = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.TabPageDatabases = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPageConnection = New System.Windows.Forms.TabPage()
        Me.TXTServername = New System.Windows.Forms.ComboBox()
        Me.TXTUser = New System.Windows.Forms.TextBox()
        Me.ComboboxDataBase = New System.Windows.Forms.ComboBox()
        Me.lblDBHD = New System.Windows.Forms.Label()
        Me.TXTPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Rtbox = New System.Windows.Forms.RichTextBox()
        Me.TabPageDatabases.SuspendLayout()
        Me.TabPageConnection.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonDrop
        '
        Me.ButtonDrop.BackgroundImage = CType(resources.GetObject("ButtonDrop.BackgroundImage"), System.Drawing.Image)
        Me.ButtonDrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonDrop.FlatAppearance.BorderSize = 0
        Me.ButtonDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDrop.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDrop.Location = New System.Drawing.Point(249, 50)
        Me.ButtonDrop.Name = "ButtonDrop"
        Me.ButtonDrop.Size = New System.Drawing.Size(75, 75)
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
        Me.ButtonRestor.Location = New System.Drawing.Point(151, 50)
        Me.ButtonRestor.Name = "ButtonRestor"
        Me.ButtonRestor.Size = New System.Drawing.Size(75, 75)
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
        Me.ButtonBackup.Location = New System.Drawing.Point(53, 50)
        Me.ButtonBackup.Name = "ButtonBackup"
        Me.ButtonBackup.Size = New System.Drawing.Size(75, 75)
        Me.ButtonBackup.TabIndex = 0
        Me.ButtonBackup.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ButtonBackup, "Backup Database ...")
        Me.ButtonBackup.UseVisualStyleBackColor = True
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
        Me.ButtonRefresh.Location = New System.Drawing.Point(157, 82)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(210, 29)
        Me.ButtonRefresh.TabIndex = 4
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.ButtonRefresh, "Refresh")
        Me.ButtonRefresh.UseVisualStyleBackColor = False
        '
        'TabPageDatabases
        '
        Me.TabPageDatabases.Controls.Add(Me.Label10)
        Me.TabPageDatabases.Controls.Add(Me.Label9)
        Me.TabPageDatabases.Controls.Add(Me.Label8)
        Me.TabPageDatabases.Controls.Add(Me.ButtonBackup)
        Me.TabPageDatabases.Controls.Add(Me.ButtonRestor)
        Me.TabPageDatabases.Controls.Add(Me.ButtonDrop)
        Me.TabPageDatabases.Location = New System.Drawing.Point(4, 25)
        Me.TabPageDatabases.Name = "TabPageDatabases"
        Me.TabPageDatabases.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPageDatabases.Size = New System.Drawing.Size(874, 379)
        Me.TabPageDatabases.TabIndex = 2
        Me.TabPageDatabases.Text = "Databases"
        Me.TabPageDatabases.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(70, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Backup"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(166, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Restore"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(271, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Drop"
        '
        'TabPageConnection
        '
        Me.TabPageConnection.BackColor = System.Drawing.Color.Cornsilk
        Me.TabPageConnection.Controls.Add(Me.ComboBox1)
        Me.TabPageConnection.Controls.Add(Me.Label2)
        Me.TabPageConnection.Controls.Add(Me.TXTServername)
        Me.TabPageConnection.Controls.Add(Me.ButtonRefresh)
        Me.TabPageConnection.Controls.Add(Me.TXTUser)
        Me.TabPageConnection.Controls.Add(Me.ComboboxDataBase)
        Me.TabPageConnection.Controls.Add(Me.lblDBHD)
        Me.TabPageConnection.Controls.Add(Me.TXTPass)
        Me.TabPageConnection.Controls.Add(Me.Label4)
        Me.TabPageConnection.Controls.Add(Me.Label3)
        Me.TabPageConnection.Controls.Add(Me.Label1)
        Me.TabPageConnection.Location = New System.Drawing.Point(4, 25)
        Me.TabPageConnection.Name = "TabPageConnection"
        Me.TabPageConnection.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPageConnection.Size = New System.Drawing.Size(874, 119)
        Me.TabPageConnection.TabIndex = 0
        Me.TabPageConnection.Text = "Connection"
        '
        'TXTServername
        '
        Me.TXTServername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXTServername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXTServername.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.TXTServername.ForeColor = System.Drawing.Color.Red
        Me.TXTServername.FormattingEnabled = True
        Me.TXTServername.Location = New System.Drawing.Point(157, 16)
        Me.TXTServername.Name = "TXTServername"
        Me.TXTServername.Size = New System.Drawing.Size(210, 27)
        Me.TXTServername.TabIndex = 0
        '
        'TXTUser
        '
        Me.TXTUser.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.TXTUser.Location = New System.Drawing.Point(447, 16)
        Me.TXTUser.Name = "TXTUser"
        Me.TXTUser.Size = New System.Drawing.Size(125, 26)
        Me.TXTUser.TabIndex = 1
        '
        'ComboboxDataBase
        '
        Me.ComboboxDataBase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboboxDataBase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboboxDataBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboboxDataBase.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.ComboboxDataBase.FormattingEnabled = True
        Me.ComboboxDataBase.Location = New System.Drawing.Point(157, 49)
        Me.ComboboxDataBase.Name = "ComboboxDataBase"
        Me.ComboboxDataBase.Size = New System.Drawing.Size(210, 27)
        Me.ComboboxDataBase.TabIndex = 3
        '
        'lblDBHD
        '
        Me.lblDBHD.AutoSize = True
        Me.lblDBHD.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDBHD.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblDBHD.Location = New System.Drawing.Point(6, 52)
        Me.lblDBHD.Name = "lblDBHD"
        Me.lblDBHD.Size = New System.Drawing.Size(99, 19)
        Me.lblDBHD.TabIndex = 15
        Me.lblDBHD.Text = "Database :"
        '
        'TXTPass
        '
        Me.TXTPass.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.TXTPass.Location = New System.Drawing.Point(674, 16)
        Me.TXTPass.Name = "TXTPass"
        Me.TXTPass.Size = New System.Drawing.Size(175, 26)
        Me.TXTPass.TabIndex = 2
        Me.TXTPass.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label4.Location = New System.Drawing.Point(578, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Pasword :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Location = New System.Drawing.Point(378, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "User :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Server N / IP :"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageConnection)
        Me.TabControl1.Controls.Add(Me.TabPageDatabases)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(882, 148)
        Me.TabControl1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(447, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(402, 27)
        Me.ComboBox1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Location = New System.Drawing.Point(378, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Table :"
        '
        'Rtbox
        '
        Me.Rtbox.Location = New System.Drawing.Point(4, 182)
        Me.Rtbox.Name = "Rtbox"
        Me.Rtbox.Size = New System.Drawing.Size(872, 536)
        Me.Rtbox.TabIndex = 2
        Me.Rtbox.Text = ""
        '
        'Frm_DALGenerate
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(880, 719)
        Me.Controls.Add(Me.Rtbox)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_DALGenerate"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DAL Generate"
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Rtbox As System.Windows.Forms.RichTextBox
End Class

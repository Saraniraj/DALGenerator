<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRestor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRestor))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.File = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Database = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonRestor = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxPath = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PastePathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CKOverwrite = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.File, Me.Database, Me.Check})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 107)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(556, 339)
        Me.DataGridView1.TabIndex = 3
        '
        'File
        '
        Me.File.HeaderText = "File"
        Me.File.Name = "File"
        Me.File.ReadOnly = True
        '
        'Database
        '
        Me.Database.DataPropertyName = "name"
        Me.Database.HeaderText = "Database"
        Me.Database.Name = "Database"
        '
        'Check
        '
        Me.Check.FillWeight = 50.0!
        Me.Check.HeaderText = "Check"
        Me.Check.Name = "Check"
        '
        'ButtonRestor
        '
        Me.ButtonRestor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRestor.BackColor = System.Drawing.Color.GhostWhite
        Me.ButtonRestor.ForeColor = System.Drawing.Color.Red
        Me.ButtonRestor.Image = CType(resources.GetObject("ButtonRestor.Image"), System.Drawing.Image)
        Me.ButtonRestor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRestor.Location = New System.Drawing.Point(479, 63)
        Me.ButtonRestor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonRestor.Name = "ButtonRestor"
        Me.ButtonRestor.Size = New System.Drawing.Size(91, 37)
        Me.ButtonRestor.TabIndex = 2
        Me.ButtonRestor.Text = "Restore"
        Me.ButtonRestor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.ButtonRestor, "Restore Database Checked ...")
        Me.ButtonRestor.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(14, 79)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(79, 20)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Check All"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBrowse.Location = New System.Drawing.Point(479, 31)
        Me.ButtonBrowse.Margin = New System.Windows.Forms.Padding(1, 4, 3, 4)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(91, 25)
        Me.ButtonBrowse.TabIndex = 0
        Me.ButtonBrowse.Text = "..."
        Me.ButtonBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Browse Restore Path :"
        '
        'TextBoxPath
        '
        Me.TextBoxPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPath.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBoxPath.Location = New System.Drawing.Point(14, 31)
        Me.TextBoxPath.Margin = New System.Windows.Forms.Padding(3, 4, 0, 4)
        Me.TextBoxPath.Name = "TextBoxPath"
        Me.TextBoxPath.Size = New System.Drawing.Size(464, 23)
        Me.TextBoxPath.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.PastePathToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(130, 48)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'PastePathToolStripMenuItem
        '
        Me.PastePathToolStripMenuItem.Image = CType(resources.GetObject("PastePathToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PastePathToolStripMenuItem.Name = "PastePathToolStripMenuItem"
        Me.PastePathToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.PastePathToolStripMenuItem.Text = "Paste Path"
        '
        'CKOverwrite
        '
        Me.CKOverwrite.AutoSize = True
        Me.CKOverwrite.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CKOverwrite.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.CKOverwrite.Location = New System.Drawing.Point(120, 79)
        Me.CKOverwrite.Name = "CKOverwrite"
        Me.CKOverwrite.Size = New System.Drawing.Size(92, 20)
        Me.CKOverwrite.TabIndex = 6
        Me.CKOverwrite.Text = "Overwrite"
        Me.CKOverwrite.UseVisualStyleBackColor = True
        '
        'FrmRestor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(584, 460)
        Me.Controls.Add(Me.CKOverwrite)
        Me.Controls.Add(Me.ButtonBrowse)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxPath)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ButtonRestor)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "FrmRestor"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Restore Databases ..."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ButtonRestor As Button
    Friend WithEvents File As DataGridViewTextBoxColumn
    Friend WithEvents Database As DataGridViewTextBoxColumn
    Friend WithEvents Check As DataGridViewCheckBoxColumn
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ButtonBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxPath As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PastePathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CKOverwrite As System.Windows.Forms.CheckBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDrop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDrop))
        Me.ButtonDrop = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Database = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CheckBoxBackup = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonDrop
        '
        Me.ButtonDrop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDrop.BackColor = System.Drawing.Color.GhostWhite
        Me.ButtonDrop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonDrop.ForeColor = System.Drawing.Color.Red
        Me.ButtonDrop.Image = CType(resources.GetObject("ButtonDrop.Image"), System.Drawing.Image)
        Me.ButtonDrop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonDrop.Location = New System.Drawing.Point(483, 15)
        Me.ButtonDrop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonDrop.Name = "ButtonDrop"
        Me.ButtonDrop.Size = New System.Drawing.Size(87, 49)
        Me.ButtonDrop.TabIndex = 2
        Me.ButtonDrop.Text = "Drop"
        Me.ButtonDrop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.ButtonDrop, "Drop Database Checked ...")
        Me.ButtonDrop.UseVisualStyleBackColor = False
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Database, Me.Check})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 71)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(556, 375)
        Me.DataGridView1.TabIndex = 3
        '
        'Database
        '
        Me.Database.DataPropertyName = "name"
        Me.Database.HeaderText = "Database"
        Me.Database.Name = "Database"
        Me.Database.ReadOnly = True
        '
        'Check
        '
        Me.Check.FillWeight = 50.0!
        Me.Check.HeaderText = "Check"
        Me.Check.Name = "Check"
        '
        'CheckBoxBackup
        '
        Me.CheckBoxBackup.AutoSize = True
        Me.CheckBoxBackup.ForeColor = System.Drawing.Color.Navy
        Me.CheckBoxBackup.Location = New System.Drawing.Point(14, 15)
        Me.CheckBoxBackup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxBackup.Name = "CheckBoxBackup"
        Me.CheckBoxBackup.Size = New System.Drawing.Size(67, 20)
        Me.CheckBoxBackup.TabIndex = 0
        Me.CheckBoxBackup.Text = "Backup"
        Me.ToolTip1.SetToolTip(Me.CheckBoxBackup, "Backup Database Checked ,Before Drop It ...")
        Me.CheckBoxBackup.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(14, 43)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(79, 20)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Check All"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FrmDrop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CheckBoxBackup)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonDrop)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "FrmDrop"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Drop Databases ..."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonDrop As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database As DataGridViewTextBoxColumn
    Friend WithEvents Check As DataGridViewCheckBoxColumn
    Friend WithEvents CheckBoxBackup As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CheckBox1 As CheckBox
End Class

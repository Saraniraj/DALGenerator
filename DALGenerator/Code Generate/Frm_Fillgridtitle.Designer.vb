<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Fillgridtitle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Fillgridtitle))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txtsuffix = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPrefix = New System.Windows.Forms.TextBox()
        Me.tsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnCreate = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnRename = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnImport = New System.Windows.Forms.ToolStripButton()
        Me.btnSweep = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.RtboxLeft = New System.Windows.Forms.RichTextBox()
        Me.RtboxRight = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.tsToolStrip.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Txtsuffix)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtPrefix)
        Me.Panel1.Location = New System.Drawing.Point(4, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(976, 100)
        Me.Panel1.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label7.Location = New System.Drawing.Point(487, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 19)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Suffix :"
        '
        'Txtsuffix
        '
        Me.Txtsuffix.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Txtsuffix.Location = New System.Drawing.Point(565, 9)
        Me.Txtsuffix.Name = "Txtsuffix"
        Me.Txtsuffix.Size = New System.Drawing.Size(299, 26)
        Me.Txtsuffix.TabIndex = 23
        Me.Txtsuffix.Text = " """
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label6.Location = New System.Drawing.Point(21, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 19)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Prefix :"
        '
        'TxtPrefix
        '
        Me.TxtPrefix.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.TxtPrefix.Location = New System.Drawing.Point(108, 6)
        Me.TxtPrefix.Name = "TxtPrefix"
        Me.TxtPrefix.Size = New System.Drawing.Size(300, 26)
        Me.TxtPrefix.TabIndex = 21
        Me.TxtPrefix.Text = "SSQL &= "" "
        '
        'tsToolStrip
        '
        Me.tsToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tsToolStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCreate, Me.btnDelete, Me.btnRename, Me.btnSearch, Me.btnImport, Me.btnSweep})
        Me.tsToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.tsToolStrip.Name = "tsToolStrip"
        Me.tsToolStrip.Padding = New System.Windows.Forms.Padding(5, 0, 1, 0)
        Me.tsToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsToolStrip.Size = New System.Drawing.Size(980, 25)
        Me.tsToolStrip.TabIndex = 5
        '
        'btnCreate
        '
        Me.btnCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        Me.btnCreate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(23, 22)
        Me.btnCreate.Text = "Create Category"
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(23, 22)
        Me.btnDelete.Text = "Delete Category"
        '
        'btnRename
        '
        Me.btnRename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRename.Image = CType(resources.GetObject("btnRename.Image"), System.Drawing.Image)
        Me.btnRename.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(23, 22)
        Me.btnRename.Text = "Rename Category"
        '
        'btnSearch
        '
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 22)
        Me.btnSearch.Text = "Search List"
        '
        'btnImport
        '
        Me.btnImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Image)
        Me.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(23, 22)
        Me.btnImport.Text = "Import Categories"
        '
        'btnSweep
        '
        Me.btnSweep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSweep.Image = CType(resources.GetObject("btnSweep.Image"), System.Drawing.Image)
        Me.btnSweep.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSweep.Name = "btnSweep"
        Me.btnSweep.Size = New System.Drawing.Size(23, 22)
        Me.btnSweep.Text = "Delete Unused"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Crimson
        Me.GroupBox1.Location = New System.Drawing.Point(465, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(3, 576)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Crimson
        Me.GroupBox2.Location = New System.Drawing.Point(495, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(3, 574)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(468, 183)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(26, 26)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Image = CType(resources.GetObject("btnSelectAll.Image"), System.Drawing.Image)
        Me.btnSelectAll.Location = New System.Drawing.Point(468, 215)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(26, 26)
        Me.btnSelectAll.TabIndex = 9
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'RtboxLeft
        '
        Me.RtboxLeft.Location = New System.Drawing.Point(0, 3)
        Me.RtboxLeft.Name = "RtboxLeft"
        Me.RtboxLeft.Size = New System.Drawing.Size(462, 573)
        Me.RtboxLeft.TabIndex = 11
        Me.RtboxLeft.Text = ""
        '
        'RtboxRight
        '
        Me.RtboxRight.Location = New System.Drawing.Point(497, 3)
        Me.RtboxRight.Name = "RtboxRight"
        Me.RtboxRight.Size = New System.Drawing.Size(476, 573)
        Me.RtboxRight.TabIndex = 12
        Me.RtboxRight.Text = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.RtboxRight)
        Me.Panel2.Controls.Add(Me.RtboxLeft)
        Me.Panel2.Controls.Add(Me.btnSelectAll)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(4, 131)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(976, 579)
        Me.Panel2.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Crimson
        Me.GroupBox3.Location = New System.Drawing.Point(0, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1000, 4)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "yt"
        '
        'Frm_Fillgridtitle
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(980, 719)
        Me.Controls.Add(Me.tsToolStrip)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Fillgridtitle"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fill Grid Title"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tsToolStrip.ResumeLayout(False)
        Me.tsToolStrip.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tsToolStrip As ToolStrip
    Friend WithEvents btnCreate As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnRename As ToolStripButton
    Friend WithEvents btnSearch As ToolStripButton
    Friend WithEvents btnImport As ToolStripButton
    Friend WithEvents btnSweep As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSelectAll As Button
    Friend WithEvents RtboxLeft As RichTextBox
    Friend WithEvents RtboxRight As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPrefix As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txtsuffix As TextBox
    Friend WithEvents GroupBox3 As GroupBox
End Class

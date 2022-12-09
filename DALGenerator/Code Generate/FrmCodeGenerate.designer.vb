<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCodeGenerate
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxtype = New System.Windows.Forms.ComboBox()
        Me.BtnGenerate = New System.Windows.Forms.Button()
        Me.TxtTablename = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Rtbox = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel1.Controls.Add(Me.Btnsave)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbxtype)
        Me.Panel1.Controls.Add(Me.BtnGenerate)
        Me.Panel1.Controls.Add(Me.TxtTablename)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(864, 100)
        Me.Panel1.TabIndex = 0
        '
        'Btnsave
        '
        Me.Btnsave.Location = New System.Drawing.Point(574, 25)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(75, 23)
        Me.Btnsave.TabIndex = 5
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Type"
        '
        'cbxtype
        '
        Me.cbxtype.FormattingEnabled = True
        Me.cbxtype.Items.AddRange(New Object() {"Main", "Line", "Get", "Class"})
        Me.cbxtype.Location = New System.Drawing.Point(135, 52)
        Me.cbxtype.Name = "cbxtype"
        Me.cbxtype.Size = New System.Drawing.Size(228, 24)
        Me.cbxtype.TabIndex = 3
        '
        'BtnGenerate
        '
        Me.BtnGenerate.Location = New System.Drawing.Point(480, 25)
        Me.BtnGenerate.Name = "BtnGenerate"
        Me.BtnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.BtnGenerate.TabIndex = 2
        Me.BtnGenerate.Text = "Generate"
        Me.BtnGenerate.UseVisualStyleBackColor = True
        '
        'TxtTablename
        '
        Me.TxtTablename.Location = New System.Drawing.Point(135, 22)
        Me.TxtTablename.Name = "TxtTablename"
        Me.TxtTablename.Size = New System.Drawing.Size(228, 23)
        Me.TxtTablename.TabIndex = 1
        Me.TxtTablename.Text = "GST_PartyDebitNote_Main"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Table Name"
        '
        'Rtbox
        '
        Me.Rtbox.Location = New System.Drawing.Point(4, 115)
        Me.Rtbox.Name = "Rtbox"
        Me.Rtbox.Size = New System.Drawing.Size(872, 591)
        Me.Rtbox.TabIndex = 1
        Me.Rtbox.Text = ""
        '
        'FrmCodeGenerate
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(881, 723)
        Me.Controls.Add(Me.Rtbox)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmCodeGenerate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class Generate"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtTablename As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnGenerate As System.Windows.Forms.Button
    Friend WithEvents Rtbox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxtype As System.Windows.Forms.ComboBox
    Friend WithEvents Btnsave As System.Windows.Forms.Button
End Class

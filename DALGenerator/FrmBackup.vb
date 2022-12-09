Imports System.Data.SqlClient

Public Class FrmBackup

    Dim Connection As ClsConnections
    Dim DT_LIST As DataTable

    Public Sub New(ByVal DT As DataTable, ByVal C As ClsConnections)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        DT_LIST = DT

        Connection = C

    End Sub

    Private Sub FrmDrop_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        DataGridView1.DataSource = DT_LIST

    End Sub

    Private Sub ButtonDrop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonDrop.Click

        If DataGridView1.Rows.Count() = 0 Then Exit Sub

        '---

        If Not IO.Directory.Exists(TextBoxPath.Text.Trim) Then MsgBox("Check Exist Path, To Backup database ...") : Exit Sub

        '---

        Dim THR As New Threading.Thread(AddressOf ThreadBackup)
        THR.Start()

    End Sub

    Sub ThreadBackup()

        '---

        Me.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        Me.Text = "Thread Backup - Running ..."

        Try

            For i As Integer = DataGridView1.Rows.Count() - 1 To 0 Step -1

                Dim delete As Boolean
                delete = DataGridView1.Rows(i).Cells("Check").Value

                '' if the checkbox cell is checked
                If delete = True Then

                    Dim Db As String = DataGridView1.Rows(i).Cells("Database").Value

                    If Connection.Command("BackUp DataBase [" & Db & "] TO DISK = '" & TextBoxPath.Text & "\" & Db & "-[" & Now.ToString("dd.MM.yyyy") & "].bak'") Then

                        DataGridView1.Rows(i).ErrorText = ""

                    Else

                        DataGridView1.Rows(i).ErrorText = Connection.ErrorTXT

                    End If

                End If

            Next

        Catch ex As Exception
        End Try

        Me.Cursor = Cursors.Default
        Me.Enabled = True

        Me.Text = "Backup Databases ..."

        MsgBox("Done ...", MsgBoxStyle.Information, "Operation Done")

        Try
            Process.Start(TextBoxPath.Text.Trim)
        Catch ex As Exception
        End Try

        '---

    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        Dim BF As New FolderBrowserDialog

        If BF.ShowDialog = DialogResult.OK Then

            TextBoxPath.Text = BF.SelectedPath

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then

            CheckBox1.Text = "UnCheck All"

            For i = 0 To DataGridView1.Rows.Count() - 1
                DataGridView1.Rows(i).Cells("Check").Value = True
            Next
        Else

            CheckBox1.Text = "Check All"

            For i = 0 To DataGridView1.Rows.Count() - 1
                DataGridView1.Rows(i).Cells("Check").Value = False
            Next
        End If

    End Sub

    Private Sub TextBoxPath_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPath.KeyDown
        e.SuppressKeyPress = True
    End Sub

    Private Sub PastePathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PastePathToolStripMenuItem.Click

        Dim CopyPath As String

        If Clipboard.ContainsText Then

            CopyPath = Clipboard.GetText

            If Not IO.Directory.Exists(CopyPath) Then MsgBox("Check Exist Path, To Backup database ...") : Exit Sub

            TextBoxPath.Text = CopyPath

        End If

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        If IO.Directory.Exists(TextBoxPath.Text) Then

            Process.Start(TextBoxPath.Text)

        End If

    End Sub

    Private Sub FrmBackup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub FrmBackup_MaximizedBoundsChanged(sender As Object, e As EventArgs) Handles Me.MaximizedBoundsChanged
        Me.CenterToScreen()
    End Sub

End Class
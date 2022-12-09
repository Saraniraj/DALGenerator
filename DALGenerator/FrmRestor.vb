Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FrmRestor

    Dim Connection As ClsConnections

    Dim Folder_Restor As String = String.Empty

    Public Sub New(ByVal C As ClsConnections)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Connection = C

    End Sub

    Private Sub FrmDrop_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub

    Sub loadBackupFile(STR As String)

        DataGridView1.Rows.Clear()

        Folder_Restor = STR

        TextBoxPath.Text = Folder_Restor

        Dim ListOfFiles = IO.Directory.GetFiles(Folder_Restor, "*.bak")

        For Each f In ListOfFiles

            Dim File = New IO.FileInfo(f.ToString)

            Dim Row = DataGridView1.Rows.Add()
            DataGridView1.Rows(Row).Cells("File").Value = File.Name

            '---
            Dim NameWithoutExtention = File.Name.Substring(0, File.Name.LastIndexOf("."))

            '---1. It is Good
            Dim output As String = New String((From c As Char In NameWithoutExtention Select c Where Char.IsLetter(c)).ToArray())

            ''  Dim match = Regex.Replace(NameWithoutExtention, "[^\d]", "") ' Get Numbers
            ''  Dim match = Regex.Replace(NameWithoutExtention, "[\d]", "") ' Get Strings

            ''  without [^] = remove

            '---2. It is Good
            'Dim match = Regex.Replace(NameWithoutExtention, "[^a-zA-Z]", "") ' Get Letters

            If output Is String.Empty Then
                output = NameWithoutExtention
            End If

            DataGridView1.Rows(Row).Cells("Database").Value = output
            '---

        Next

    End Sub

    Sub ThreadRestore()

        '---

        Me.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        Me.Text = "Thread Restore - Running ..."

        Try

            For i As Integer = DataGridView1.Rows.Count() - 1 To 0 Step -1

                Dim Restore_Check As Boolean
                Restore_Check = DataGridView1.Rows(i).Cells("Check").Value

                '' if the checkbox cell is checked
                If Restore_Check = True Then

                    Dim Db As String = DataGridView1.Rows(i).Cells("Database").Value
                    Dim FileDb As String = DataGridView1.Rows(i).Cells("File").Value

                    '---
                    Dim Exists = "SELECT case when exists (select 1 from sys.Databases " &
                         "Where Name = '" & Db & "') then 1 else 0 end as DbExists"

                    Dim Result = Connection.Query(Exists)

                    Dim Value = Result.Rows(0)("DBExists")

                    Dim Restore_Status As Boolean = False

                    If Value = 1 Then

                        If CKOverwrite.Checked Then

                            If Connection.Command("RESTORE DATABASE [" & Db & "] FROM  DISK = N'" & Folder_Restor & "\" & FileDb & "' WITH REPLACE, FILE = 1,  NOUNLOAD,  STATS = 5") Then
                                Restore_Status = True
                            Else
                                Restore_Status = False
                            End If

                        Else

                            Connection.ErrorTXT = "Database is Exist ..."

                        End If



                    Else

                        If Connection.Command("RESTORE DATABASE [" & Db & "] FROM  DISK = N'" & Folder_Restor & "\" & FileDb & "' WITH FILE = 1,  NOUNLOAD,  STATS = 5") Then
                            Restore_Status = True
                        Else
                            Restore_Status = False
                        End If

                    End If

                '---

                If Restore_Status = True Then
                    DataGridView1.Rows(i).ErrorText = ""
                Else
                    DataGridView1.Rows(i).ErrorText = Connection.ErrorTXT
                End If

                End If

            Next

        Catch ex As Exception
        End Try

        Me.Text = "Restore Databases ..."

        Me.Cursor = Cursors.Default
        Me.Enabled = True

        MsgBox("Done ...", MsgBoxStyle.Information, "Operation Done")

        Threading.Thread.CurrentThread.Abort()

        '---

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

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click

        Dim BF As New FolderBrowserDialog

        If BF.ShowDialog = DialogResult.OK Then
            loadBackupFile(BF.SelectedPath)
        End If

    End Sub
    Private Sub TextBoxPath_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPath.KeyDown
        e.SuppressKeyPress = True
    End Sub

    Private Sub PastePathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PastePathToolStripMenuItem.Click

        Dim CopyPath As String

        If Clipboard.ContainsText Then

            CopyPath = Clipboard.GetText

            If Not IO.Directory.Exists(CopyPath) Then MsgBox("Check Exist Path, To Restore database ...") : Exit Sub

            loadBackupFile(CopyPath)

        End If

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        If IO.Directory.Exists(TextBoxPath.Text) Then

            Process.Start(TextBoxPath.Text)

        End If

    End Sub

    Private Sub ButtonRestor_Click(sender As Object, e As EventArgs) Handles ButtonRestor.Click

        If DataGridView1.Rows.Count() = 0 Then Exit Sub

        If Not IO.Directory.Exists(TextBoxPath.Text.Trim) Then MsgBox("Check Exist Path, To Restore database ...") : Exit Sub

        Dim THR As New Threading.Thread(AddressOf ThreadRestore)
        THR.Start()

    End Sub

    Private Sub FrmRestor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

End Class
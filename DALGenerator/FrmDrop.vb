Imports System.Data.SqlClient

Public Class FrmDrop

    Dim Connection As ClsConnections
    Dim DT_LIST As DataTable

    Dim Folder_Backup As String = String.Empty

    Public Sub New(DT As DataTable, C As ClsConnections)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        DT_LIST = DT

        Connection = C

    End Sub

    Private Sub FrmDrop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.DataSource = DT_LIST

    End Sub

    Private Sub ButtonDrop_Click(sender As Object, e As EventArgs) Handles ButtonDrop.Click
        'Drop DATABASE MyDb

        Dim THR As New Threading.Thread(AddressOf ThreadDrop)

        THR.Start()

    End Sub

    Sub ThreadDrop()

        '---

        Me.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        Me.Text = "Thread Drop - Running ..."

        Try

            For i As Integer = DataGridView1.Rows.Count() - 1 To 0 Step -1

                Dim delete As Boolean
                delete = DataGridView1.Rows(i).Cells("Check").Value

                '' if the checkbox cell is checked
                If delete = True Then

                    'Dim row As DataGridViewRow

                    'Row = DataGridView1.Rows(i)

                    Dim Db As String = DataGridView1.Rows(i).Cells("Database").Value

                    If CheckBoxBackup.Checked Then

                        Try

                            If Connection.Command("BackUp DataBase [" & Db & "] TO DISK = '" & Folder_Backup & "\" & Db & "-[" & Now.ToString("dd.MM.yyyy") & "].bak'") Then

                                If Connection.Command("Drop DATABASE [" & Db & "]") Then

                                    DT_LIST.Rows.RemoveAt(i)
                                    'DataGridView1.Rows.RemoveAt(i)

                                Else

                                    DataGridView1.Rows(i).ErrorText = Connection.ErrorTXT '"Cannot drop this Database, Try again ..."

                                End If

                            Else

                                DataGridView1.Rows(i).ErrorText = Connection.ErrorTXT '"Cannot drop this Database, Try again ..."

                            End If

                        Catch ex As Exception
                            DataGridView1.Rows(i).ErrorText = Connection.ErrorTXT '"Cannot drop this Database, Try again ..."
                        End Try

                    Else

                        If Connection.Command("Drop DATABASE [" & Db & "]") Then

                            DT_LIST.Rows.RemoveAt(i)
                            'DataGridView1.Rows.RemoveAt(i)

                        Else

                            DataGridView1.Rows(i).ErrorText = Connection.ErrorTXT '"Cannot drop this Database, Try again ..."

                        End If

                    End If

                End If

            Next

        Catch ex As Exception
        End Try

        Me.Text = "Drop Databases ..."

        Me.Cursor = Cursors.Default
        Me.Enabled = True

        MsgBox("Done ...", MsgBoxStyle.Information, "Operation Done")

        Threading.Thread.CurrentThread.Abort()

        '---

    End Sub

    Private Sub CheckBoxBackup_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBackup.CheckedChanged
        If CheckBoxBackup.Checked Then
            Dim BF As New FolderBrowserDialog
            If BF.ShowDialog = DialogResult.OK Then
                Folder_Backup = BF.SelectedPath
                ToolTip1.SetToolTip(CheckBoxBackup, Folder_Backup)
            End If
        Else
            Folder_Backup = String.Empty ' Defaullt Path: "C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\Backup"
            ToolTip1.SetToolTip(CheckBoxBackup, "Backup Database Checked ,Before Drop It ...")
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

    Private Sub FrmDrop_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
End Class
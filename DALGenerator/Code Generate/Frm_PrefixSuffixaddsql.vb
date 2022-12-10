Imports System.Data.SqlClient
Imports System.Net

Public Class Frm_PrefixSuffixaddsql

    Dim SERVERNAME_FIELD As String = "ServerName"
    Dim USERNAME_FIELD As String = "Username"
    Dim PASSWORD_FIELD As String = "Password"

    Dim DataBaseListComp As DataTable
    Dim DataBaseListHR As DataTable

    Dim ConnectionCompSelected As New ClsConnections()
    Dim ConnectionData As New ClsConnections()
    Dim ConnectionGenerals As New ClsConnections()

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Control.CheckForIllegalCrossThreadCalls = False

        '--------

        '--------

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim RotateCount As String()
            RtboxRight.Text = "'"
            For i As Integer = 0 To RtboxLeft.Lines.Length - 1
                'RtboxRight.Text = RtboxLeft.Lines(i)
                RtboxRight.Text &= TxtPrefix.Text & RtboxLeft.Lines(i) & Txtsuffix.Text & If(i < RtboxLeft.Lines.Length - 1, Environment.NewLine, "")
            Next

        Catch ex As Exception
            Show_Message(ex.ToString())

        End Try

        'If lstImportPayees.SelectedIndex = -1 Then

        '    Dim strMessage As String = "Select payees from the list on the left and click 'Add'." & vbNewLine

        '    Dim strAdvice As String = "Make sure you have selected a ledger from the dropdown list" & vbNewLine &
        '                              "that contains the payees you want to import."

        '    MessageBox.Show(strMessage, "")

        'Else

        '    For Each strPayee As String In lstImportPayees.SelectedItems

        '        If Not lstMyPayees.Items.Contains(strPayee) Then

        '            lstMyPayees.Items.Add(strPayee)

        '        End If

        '    Next

        'End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

    End Sub
End Class
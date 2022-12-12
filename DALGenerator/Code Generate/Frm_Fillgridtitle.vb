Imports System.Data.SqlClient
Imports System.Net

Public Class Frm_Fillgridtitle

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
            Generate_fillGridtitle()

            'Dim RotateCount As String()
            'RtboxRight.Text = "'"
            'For i As Integer = 0 To RtboxLeft.Lines.Length - 1
            '    'RtboxRight.Text = RtboxLeft.Lines(i)
            '    RtboxRight.Text &= TxtPrefix.Text & RtboxLeft.Lines(i) & Txtsuffix.Text & If(i < RtboxLeft.Lines.Length - 1, Environment.NewLine, "")
            'Next

        Catch ex As Exception
            Show_Message(ex.ToString())

        End Try
    End Sub

    Private Sub Generate_fillGridtitle()

        Try
            RtboxRight.Text = ""
            RtboxRight.Clear()
            Dim irows As Integer = 0
            Dim mlines As Integer = RtboxLeft.Lines.Length - 1
            Dim mReport As String = ""
            Dim nl As String = vbCrLf
            mReport = " " & vbCrLf & "   " & nl

            mReport &= "  Private Sub Fill_Grid_Title_Left()" & nl

            mReport &= "  Try " & nl
            mReport &= "   With c1fgItems" & nl
            mReport &= ".Clear()" & nl
            mReport &= "     .Rows = 1" & nl
            mReport &= "    .Cols = " & RtboxLeft.Lines.Length & nl
            mReport &= "     .FixedCols = 0" & nl

            For i As Integer = 0 To RtboxLeft.Lines.Length - 1
                Dim mstr As String = LTrim(RTrim(RtboxLeft.Lines(i)))

                mReport &= "      .set_TextMatrix(0,  " & i & ",""" & RemoveWhitespace(mstr) & """)" & nl
            Next
            For i As Integer = 0 To RtboxLeft.Lines.Length - 1
                Dim mstr As String = LTrim(RTrim(RtboxLeft.Lines(i)))

                mReport &= "      .set_TextMatrix(" & i & "," & "80" & ")" & nl
            Next
            mReport &= "      .Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpAlignment, 0, 0, 0, " & mlines & "  ) = 3" & nl
            mReport &= "      .Cell(C1.Win.C1FlexGrid.Classic.CellPropertySettings.flexcpFontBold, 0, 0, 0," & mlines & "  ) = True " & nl
            mReport &= "    For iRow As Integer = 1 To .Rows - 1  " & nl
            mReport &= "        .set_TextMatrix(iRow, 0, iRow)  " & nl
            mReport &= " Next  " & nl
            mReport &= "    End With  " & nl
            mReport &= "   Catch ex As Exception  " & nl
            mReport &= "   Show_Message(ex.Message)  " & nl
            mReport &= "    End Try  " & nl
            mReport &= "  End Sub " & nl

            RtboxRight.Text = mReport

        Catch ex As Exception
            Show_Message(ex.ToString())

        End Try
    End Sub
    Function RemoveWhitespace(fullString As String) As String
        Return New String(fullString.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
    End Function
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

    End Sub
End Class
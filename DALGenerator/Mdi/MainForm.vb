Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub CenterFormCenterScreen(ByVal _Object As Object)

        Dim currentArea = Screen.FromControl(_Object).WorkingArea
        _Object.Top = currentArea.Top + CInt((currentArea.Height / 2) - (_Object.Height / 2))
        _Object.Left = currentArea.Left + CInt((currentArea.Width / 2) - (_Object.Width / 2))

    End Sub

    Public Sub ColorTextboxes(ByVal _List As List(Of TextBox))

        For Each txtTextBox As TextBox In _List

            If txtTextBox.Text > 0 Then
                txtTextBox.BackColor = m_clrMyGreen
            End If
            If txtTextBox.Text < 0 Then
                txtTextBox.BackColor = m_clrMyRed
            End If
            If txtTextBox.Text = 0 Then
                txtTextBox.BackColor = Color.White
            End If

        Next

    End Sub
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        Me.Dispose()

    End Sub
    Private Sub mnuCalc_Click(sender As Object, e As EventArgs) Handles mnuCalc.Click

        System.Diagnostics.Process.Start("calc")

    End Sub
End Class
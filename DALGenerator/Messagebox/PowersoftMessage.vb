'    CheckbookMessage is a custom messagebox that supports two styles of text, buttons, and media sounds.
'    Copyright(C) 2018 Christopher Mackay

'    This program Is free software: you can redistribute it And/Or modify
'    it under the terms Of the GNU General Public License As published by
'    the Free Software Foundation, either version 3 Of the License, Or
'    (at your option) any later version.

'    This program Is distributed In the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty Of
'    MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE. See the
'    GNU General Public License For more details.

'    You should have received a copy Of the GNU General Public License
'    along with this program. If Not, see <http: //www.gnu.org/licenses/>.

Imports System.Windows.Forms

Public Class CheckbookMessage

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Dispose()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Dispose()
    End Sub

    Private Sub frmDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim headerMessageBottom As Integer = lblHeaderMessage.Location.Y + lblHeaderMessage.Height 'GETS THE Y LOCATION OF THE BOTTOM
        Dim bodyMessageBottom As Integer = lblBodyMessage.Location.Y + Me.lblBodyMessage.Height 'GETS THE Y LOCATION OF THE BOTTOM

        Dim bodyMessageTop As Integer = headerMessageBottom + 18 'OFFSETS THE TOP OF THE BODY FROM THE BOTTOM OF THE HEADER

        lblBodyMessage.Location = New Drawing.Point(Me.lblBodyMessage.Location.X, bodyMessageTop) 'SETS NEW BODY TOP

        If lblBodyMessage.Text = String.Empty Then

            Me.Height += (lblHeaderMessage.Location.Y + lblHeaderMessage.Height) - 50 'IF ONLY THE HEADER TEXT IS SHOWN THEN MAKE THE FORM A LITTLE SMALLER

        Else

            Me.Height += (lblBodyMessage.Location.Y + lblBodyMessage.Height) - 60

        End If

        centerFormCenterScreen(Me)

    End Sub

    Public Function ShowMessage(ByVal HeaderMessage As String, ByVal Buttons As MsgButtons, Optional ByVal BodyMessage As String = "", Optional ByVal MessageSound As Media.SystemSound = Nothing)

        Me.Height = 157
        Me.lblHeaderMessage.Text = HeaderMessage
        Me.lblBodyMessage.Text = BodyMessage

        'MSG BUTTONS
        Select Case Buttons

            Case MsgButtons.OK

                OK_Button.Visible = False

                Cancel_Button.DialogResult = Windows.Forms.DialogResult.OK
                Cancel_Button.Text = "OK"
                AcceptButton = Cancel_Button
                Cancel_Button.TabIndex = 0
                ActiveControl = Cancel_Button

            Case MsgButtons.OKCancel

                OK_Button.DialogResult = Windows.Forms.DialogResult.OK
                Cancel_Button.DialogResult = Windows.Forms.DialogResult.Cancel

                OK_Button.Text = "OK"
                Cancel_Button.Text = "Cancel"
                AcceptButton = OK_Button
                OK_Button.TabIndex = 0
                Cancel_Button.TabIndex = 1
                ActiveControl = OK_Button

            Case MsgButtons.YesNo

                OK_Button.DialogResult = Windows.Forms.DialogResult.Yes
                Cancel_Button.DialogResult = Windows.Forms.DialogResult.No

                OK_Button.Text = "Yes"
                Cancel_Button.Text = "No"
                AcceptButton = OK_Button
                OK_Button.TabIndex = 0
                Cancel_Button.TabIndex = 1
                ActiveControl = OK_Button

        End Select

        If Not IsNothing(MessageSound) Then

            MessageSound.Play()

        End If

        Me.ShowDialog()

        Dim dialogResult As System.Windows.Forms.DialogResult
        dialogResult = Me.DialogResult

        Return dialogResult
    End Function

    Public Enum MsgButtons

        OK = 0
        OKCancel = 1
        YesNo = 2

    End Enum

    Sub centerFormCenterScreen(ByVal oForm As Object)

        Dim currentArea = Screen.FromControl(oForm).WorkingArea
        oForm.Top = currentArea.Top + CInt((currentArea.Height / 2) - (oForm.Height / 2))
        oForm.Left = currentArea.Left + CInt((currentArea.Width / 2) - (oForm.Width / 2))

    End Sub

End Class

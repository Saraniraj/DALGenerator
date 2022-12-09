Module modFormResize
   
    Public Class ResizeFormClass
        'Original form width.
        Private Shared mvarFormWidth As Long
        Private Shared mvarFormHeight As Long

        Public Shared Sub SubResize(ByVal F As Form, ByVal percentW As Single, ByVal percentH As Single)
            Dim FormHeight As Long
            Dim FormWidth As Long
            Dim HeightChange As Single, WidthChange As Single

            Call SaveInitialStates(F)

            'Calculate the new height and width the form needs to be resized to, based on the current avaible screen area.
            FormHeight = Int((Screen.PrimaryScreen.WorkingArea.Height) * (percentH / 100))
            FormWidth = Int((Screen.PrimaryScreen.WorkingArea.Width) * (percentW / 100))

            'Use the Form that is to be resized.
            With F
                'Change the demensions and position of the form.
                .Height = FormHeight
                .Width = FormWidth
                HeightChange = .ClientSize.Height / mvarFormHeight
                WidthChange = .ClientSize.Width / mvarFormWidth

            End With
            'Calculate ratio current avaible screen area/form size
            'Notify the class that the form has been resized.
            SubChangeWithRatio(F, WidthChange, HeightChange)
        End Sub
        Private Shared Sub SaveInitialStates(ByVal F As Form)
            'Use the form that is being resized.
            With F
                'Set the FormWidth and FormHeight variables to the Form's Scale Width and Height.
                mvarFormWidth = .ClientSize.Width
                mvarFormHeight = .ClientSize.Height
            End With
        End Sub

        Public Shared Sub SubChangeWithRatio(ByVal F As Form, ByVal RatioW As Single, ByVal RatioH As Single)
            'uses a recursive routine

            For Each ctl As Control In F.Controls
                ResizeControlAndIncludedControls(ctl, RatioW, RatioH)
            Next
        End Sub

        Private Shared Sub ResizeControlAndIncludedControls(ByRef ctl As Control, ByVal RatioW As Single, ByVal RatioH As Single)
            Dim ChildCtl As Control
            For Each ChildCtl In ctl.Controls
                ResizeControlAndIncludedControls(ChildCtl, RatioW, RatioH)
            Next
            ControlResize(ctl, RatioW, RatioH)
        End Sub

        Private Shared Sub ControlResize(ByRef ctl As Control, ByVal RatioW As Single, ByVal RatioH As Single)
            Dim lb As New ListBox, intlH As Boolean
            Try
                If TypeOf ctl Is ListBox Then
                    lb = CType(ctl, ListBox)
                    intlH = lb.IntegralHeight
                    lb.IntegralHeight = False

                    lb.Left = CInt(lb.Left * RatioW)
                    lb.Top = CInt(lb.Top * RatioH)
                    lb.Width = CInt(lb.Width * RatioW)
                    lb.Height = CInt(lb.Height * RatioH)
                Else
                    ctl.Left = CInt(ctl.Left * RatioW)
                    ctl.Top = CInt(ctl.Top * RatioH)
                    ctl.Width = CInt(ctl.Width * RatioW)
                    ctl.Height = CInt(ctl.Height * RatioH)
                End If

                Select Case True
                    'If the control is a ListView
                    Case TypeOf ctl Is ListView
                        ResizeColumnsL(ctl, RatioW)
                        'If the control is a Datagridview
                    Case TypeOf ctl Is DataGridView
                        ResizeColumnsD(ctl, RatioW)
                        'If the control is a Datagrid
                    Case TypeOf ctl Is DataGrid
                        ResizeColumnsDg(ctl, RatioW)
                    Case TypeOf ctl Is Button
                        Exit Sub
                End Select
                ResizeControlFont(ctl, RatioW, RatioH)
            Catch ex As Exception
                Show_Message(ex.Message)
            End Try

        End Sub

        Private Shared Sub ResizeControlFont(ByRef Ct As Control, ByVal RatioW As Single, ByVal RatioH As Single)
            Dim dgv As DataGridView
            'Resizes the control font and, in the case of some controls, as the listview
            ' resizes the columns also
            Try

                Dim FSize As Single = Ct.Font.Size
                Dim FStyle As FontStyle = Ct.Font.Style
                Dim FNome As String = Ct.Font.Name
                Dim NewSize As Single = FSize
                'If the control is a Datagridview
                If TypeOf Ct Is DataGridView Then
                    dgv = CType(Ct, DataGridView)
                    dgv.DefaultCellStyle.Font = New Font(dgv.Font.FontFamily, CSng(FSize * Math.Sqrt(RatioW * RatioH)), FontStyle.Bold)

                End If
                NewSize = FSize * Math.Sqrt(RatioW * RatioH)
                Dim NFont As New Font(FNome, CSng(NewSize), FStyle)
                Ct.Font = NFont
            Catch ex As Exception
                Show_Message(ex.Message)
            End Try
        End Sub

        Private Shared Sub ResizeColumnsL(ByRef ct As Control, ByVal RatioW As Single)
            Dim c As ColumnHeader
            For Each c In CType(ct, ListView).Columns
                c.Width = CInt(c.Width * RatioW)
            Next
        End Sub
        Private Shared Sub ResizeColumnsD(ByRef ct As Control, ByVal RatioW As Single)
            Dim c As DataGridViewColumn
            For Each c In CType(ct, DataGridView).Columns
                Console.WriteLine(c.Width)
                c.Width = c.Width * RatioW
                Console.WriteLine(c.Width)
            Next
        End Sub
        Private Shared Sub ResizeColumnsDg(ByRef ct As Control, ByVal RatioW As Single)
            Dim c As DataGridColumnStyle
            For Each c In CType(ct, DataGrid).TableStyles(0).GridColumnStyles
                c.Width = CInt(c.Width * RatioW)
            Next
        End Sub
    End Class
    Public Sub Form_Color(ByVal frm As Form)
        Try
            Dim mColor11, mColor12, mColor13 As Integer
            Dim mColor21, mColor22, mColor23 As Integer

            Dim mColorVar1() = "105, 152, 0".Split(",")
            Dim mColorVar2() = "179, 224, 79".Split(",")

            mColor11 = mColorVar1(0)
            mColor12 = mColorVar1(1)
            mColor13 = mColorVar1(2)

            mColor21 = mColorVar2(0)
            mColor22 = mColorVar2(1)
            mColor23 = mColorVar2(2)

            Dim iBackground As New Bitmap(frm.Width, frm.Height)
            Dim g As Graphics = Graphics.FromImage(iBackground)
            g.FillRectangle(New Drawing2D.LinearGradientBrush(frm.ClientRectangle, Color.FromArgb(mColor11, mColor12, mColor13), _
                                                              Color.FromArgb(mColor21, mColor22, mColor23), 20), frm.ClientRectangle)
            frm.BackgroundImage = iBackground
            g.Dispose()
        Catch ex As Exception
            '  Show_Message("Error : " & ex.Message.ToString)
        End Try
    End Sub
End Module

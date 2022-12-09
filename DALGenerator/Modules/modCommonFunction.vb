Option Explicit On

#Region "Imports"
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Imports System.Math

Imports System.Runtime.InteropServices
#End Region

Module modCommonFunction

#Region "Global Declaration"
    Public msgboxTitle As String = "LS MILLS"
    Public MessageBoxMessage As String = "Can not leave mandatory field as blank"

#End Region

    Public Sub Show_Message(ByVal MessageBoxMessage As String, Optional ByVal MessageBoxTitle As String = Nothing)
        If MessageBoxTitle = Nothing Then
            MsgBox(MessageBoxMessage, MsgBoxStyle.Information, msgboxTitle)
        Else
            MsgBox(MessageBoxMessage, MsgBoxStyle.Information, MessageBoxTitle)
        End If
    End Sub

    Public Function IsBlankTextBox(ByRef st As TextBox, Optional ByVal PromptMessage As String = Nothing, Optional ByVal MessageBoxTitle As String = Nothing) As Boolean
        If st.Text.Trim = "" Then
            If PromptMessage = Nothing Then
                If MessageBoxTitle = Nothing Then
                    Show_Message(MessageBoxMessage)
                Else
                    Show_Message(MessageBoxMessage, MessageBoxTitle)
                End If
            Else
                If MessageBoxTitle = Nothing Then
                    Show_Message(PromptMessage)
                Else
                    Show_Message(PromptMessage, MessageBoxTitle)
                End If
            End If
            st.Focus()
            Return True
        Else
            Return False
        End If
    End Function

    Public Function IsBlankComboBox(ByVal st As ComboBox, Optional ByVal PromptMessage As String = Nothing, Optional ByVal MessageBoxTitle As String = Nothing) As Boolean
        If st.Text.Trim = "" Then
            If PromptMessage = Nothing Then
                If MessageBoxTitle = Nothing Then
                    Show_Message(MessageBoxMessage)
                Else
                    Show_Message(MessageBoxMessage, MessageBoxTitle)
                End If
            Else
                If MessageBoxTitle = Nothing Then
                    Show_Message(PromptMessage)
                Else
                    Show_Message(PromptMessage, MessageBoxTitle)
                End If
            End If
            st.Focus()
            Return True
        Else
            Return False
        End If
    End Function

End Module


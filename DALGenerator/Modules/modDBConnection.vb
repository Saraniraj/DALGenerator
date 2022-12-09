#Region "Imports"
Imports System
Imports System.Data
Imports System.Data.OleDb
#End Region

Module modDBConnection

    Public Function GetConnection(ByVal mvarDatabaseName As String) As String
        Dim mvarConnectionString As String = ""
        Try
            Dim mvarKeyName(3) As String
            Dim mvarKeyValues(3) As String
            Dim mvarINIPath As String = "C:\TexOne.ini"
            'Dim mvarINIFileSectionName As String = mvarApplicationType
            Dim mvarINIFileSectionName As String = "LSMILLS"

            mvarKeyName(1) = "UserName"
            mvarKeyName(2) = "Password"
            mvarKeyName(3) = "ServerName"
            ReadINIFile(mvarINIPath, mvarINIFileSectionName, mvarKeyName, mvarKeyValues)

            mvarConnectionString = "Provider=sqloledb;"
            mvarConnectionString &= "Data Source=" & mvarKeyValues(3) & ";"
            mvarConnectionString &= "Initial Catalog= " & mvarDatabaseName & ";"
            mvarConnectionString &= "User ID= " & mvarKeyValues(1) & ";"
            mvarConnectionString &= "Password= " & mvarKeyValues(2) & ";"
            mvarConnectionString += "Connection Timeout=3600 "

            Return mvarConnectionString
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
        End Try
        Return mvarConnectionString
    End Function

    Public Sub ReadINIFile(ByVal mvarINIPath As String, ByVal mvarSectionName As String, ByVal mvarKeyName As String(), ByRef mvarKeyValue As String())
        Try
            Dim mvarLength As Integer
            Dim mvarStrData As String
            mvarStrData = Space$(1024)
            For i As Integer = 1 To mvarKeyName.Length - 1
                If mvarKeyName(i) <> "" Then
                    mvarLength = GetPrivateProfileString(mvarSectionName, mvarKeyName(i), mvarKeyValue(i), mvarStrData, mvarStrData.Length, LTrim(RTrim((mvarINIPath))))
                    If mvarLength > 0 Then
                        mvarKeyValue(i) = mvarStrData.Substring(0, mvarLength)
                    Else
                        mvarKeyValue(i) = ""
                    End If
                End If
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message.ToString)
        End Try
    End Sub

    Public Function ReturnSingleValue(ByVal MyQuery As String, ByVal mvarDatabaseName As String) As Object
        Try
            thisConnnection = New OleDbConnection(GetConnection(mvarDatabaseName))
            thisCommand = New OleDbCommand(MyQuery, thisConnnection)
            thisConnnection.Open()
            Dim result As Object = thisCommand.ExecuteScalar
            thisConnnection.Close()
            If IsDBNull(result) Then
                Return Nothing
            End If

            Return result
        Catch ex As Exception
            Throw New Exception(ex.Message)
            If thisConnnection.State = ConnectionState.Open Then
                thisConnnection.Close()
            End If
        End Try
        Return Nothing
    End Function

    Public Function InsertDeleteUpdate(ByVal MyQuery As String, ByVal mvarDatabaseName As String) As Long
        Try
            thisConnnection = New OleDbConnection(GetConnection(mvarDatabaseName))
            thisCommand = New OleDbCommand(MyQuery, thisConnnection)
            thisConnnection.Open()
            Dim RowsAffected As Long
            RowsAffected = thisCommand.ExecuteNonQuery()
            thisConnnection.Close()
            Return RowsAffected
        Catch ex As Exception
            Throw New Exception(ex.Message)
            If thisConnnection.State = ConnectionState.Open Then
                thisConnnection.Close()
            End If
        End Try
        Return Nothing
    End Function

    Public Function ReturnMultipleValue(ByVal MyQuery As String, ByVal mvarDatabaseName As String) As DataSet
        Dim ds As New DataSet
        Try
            thisConnnection = New OleDbConnection(GetConnection(mvarDatabaseName))
            thisDataAdapter = New OleDbDataAdapter(MyQuery, thisConnnection)
            ds = New DataSet
            thisConnnection.Open()
            thisDataAdapter.Fill(ds)
            thisConnnection.Close()
            Return ds
        Catch ex As Exception
            Throw New Exception(ex.Message)
            If thisConnnection.State = ConnectionState.Open Then
                thisConnnection.Close()
            End If
        End Try
        Return ds
    End Function

    Public Sub ExecuteCommAndQuery(ByVal comm As OleDbCommand, ByVal mvarDatabaseName As String)
        Try
            thisConnnection = New OleDbConnection(GetConnection(mvarDatabaseName))
            comm.Connection = thisConnnection
            thisConnnection.Open()
            comm.ExecuteNonQuery()
            thisConnnection.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message)
            If thisConnnection.State = ConnectionState.Open Then
                thisConnnection.Close()
            End If
        End Try
    End Sub

End Module

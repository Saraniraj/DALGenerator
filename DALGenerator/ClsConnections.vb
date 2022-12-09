Imports System.Data.SqlClient

Public Class ClsConnections

    Dim _SERVERNAME As String = String.Empty
    Dim _USERID As String = String.Empty
    Dim _PASSWORD As String = String.Empty
    Dim _DATABASE As String = String.Empty

    Public ErrorTXT As String

    Public Sub New()
        SERVERNAME = ""
        USERID = ""
        PASSWORD = ""
        DATABASE = ""

    End Sub
    Public Sub New(Server As String, Usr As String, Pass As String, Optional Db As String = Nothing)
        SERVERNAME = Server
        USERID = Usr
        PASSWORD = Pass
        DATABASE = Db
    End Sub

    Private Property SERVERNAME() As String
        Get
            Return _SERVERNAME
        End Get
        Set(value As String)
            _SERVERNAME = value
        End Set
    End Property

    Private Property USERID() As String
        Get
            Return _USERID
        End Get
        Set(value As String)
            _USERID = value
        End Set
    End Property

    Private Property PASSWORD() As String
        Get
            Return _PASSWORD
        End Get
        Set(value As String)
            _PASSWORD = value
        End Set
    End Property

    Private Property DATABASE() As String
        Get
            Return _DATABASE
        End Get
        Set(value As String)
            _DATABASE = value
        End Set
    End Property

    Private Function ConnectionStr() As String

        If String.IsNullOrEmpty(_SERVERNAME) Then Return Nothing

        If Not String.IsNullOrEmpty(_USERID) Then

            Return "Data Source=" + _SERVERNAME + ";Initial Catalog=" + _DATABASE + ";Persist Security Info=True;User ID=" + _USERID + ";Password=" + _PASSWORD

        Else

            Return "Data Source=" + _SERVERNAME + ";Initial Catalog=;Integrated Security=True;"

        End If

    End Function

    Public Function Command(Str As String) As Boolean

        ErrorTXT = String.Empty

        Dim Con As New SqlConnection(ConnectionStr)
        Con.Open()
        Dim cmd As New SqlCommand(Str, Con)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception

            If Con.State = ConnectionState.Open Then Con.Close()
            ErrorTXT = ex.Message
            Return False

        End Try

        If Con.State = ConnectionState.Open Then Con.Close()
        Return True

    End Function

    Public Function Query(Str As String) As DataTable

        Try

            ErrorTXT = String.Empty

            Dim Con As New SqlConnection(ConnectionStr)
            Dim Dt As New DataTable

            Dim Cmd As New SqlDataAdapter(Str, Con)

            Cmd.Fill(Dt)
            Con.Close()

            Return Dt

        Catch ex As Exception

            ErrorTXT = ex.Message
            Return Nothing

        End Try

    End Function

    Public Function TestConnection() As Boolean

        Dim Con As New SqlConnection(ConnectionStr)

        If Con.State = ConnectionState.Open Then Con.Close()

        Try

            Con.Open()

            If Con.State = ConnectionState.Open Then Con.Close() : Return True

        Catch ex As Exception
            Con.Close()
        End Try

        Return False

    End Function


End Class

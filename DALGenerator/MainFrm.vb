Imports System.Data.SqlClient
Imports System.Net

Public Class MainFrm

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

        Try

            '1.
            TXTServername.Items.Add(".")

            '2.
            Dim IPHost As IPHostEntry
            IPHost = Dns.GetHostByName(Dns.GetHostName())
            TXTServername.Items.Add(IPHost.AddressList(0).ToString())

            '3.
            TXTServername.Items.Add(Dns.GetHostName)

            '---

            TXTServername.SelectedValue = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        '--------
        Dim comp = From controls In Me.TabPageDatabases.Controls.OfType(Of Button)() Select controls

        For Each Btn In comp
            AddHandler Btn.MouseEnter, AddressOf BtnEnter
            AddHandler Btn.MouseLeave, AddressOf BtnLeave
        Next
        '--------

    End Sub

    Private Sub ButtonDrop_Click(sender As Object, e As EventArgs) Handles ButtonDrop.Click

        'If String.IsNullOrEmpty(TXTServername.Text.Trim Is String.Empty) OrElse String.IsNullOrEmpty(TXTUser.Text.Trim) OrElse String.IsNullOrEmpty(TXTPass.Text.Trim) Then TabControl1.SelectedIndex = 0 : ToolTip1.Show("Check Connection Info ...", TXTServername, 2000) : Exit Sub

        If Not ConnectionGenerals.TestConnection Then

            TabControl1.SelectedIndex = 0 : ToolTip1.Show("Check Connection Info ...", TXTServername, 2000) : Exit Sub

        End If

        Me.Hide()

        Dim F As New FrmDrop(DataBaseListComp, ConnectionGenerals)
        F.ShowDialog()

        Me.Show()

    End Sub

    Private Sub TXTPass_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            GET_DB()
        End If
    End Sub

    Private Sub TXTPass_Leave(sender As Object, e As EventArgs) Handles TXTPass.Leave

        Dim TH As New Threading.Thread(AddressOf GET_DB)
        TH.Start()

    End Sub

    Sub GET_DB()

        Me.Cursor = Cursors.WaitCursor

        Try

            ComboboxDataBase.DataSource = Nothing

            ConnectionGenerals = New ClsConnections(TXTServername.Text.Trim, TXTUser.Text.Trim, TXTPass.Text.Trim)

            DataBaseListComp = ConnectionGenerals.Query("SELECT [name] FROM sys.databases Where [name] Not In('master','model','msdb','tempdb','ReportServer','ReportServerTempDB')")

            ComboboxDataBase.DataSource = DataBaseListComp
            ComboboxDataBase.DisplayMember = "name"
            ComboboxDataBase.ValueMember = "name"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ButtonBackup_Click(sender As Object, e As EventArgs) Handles ButtonBackup.Click

        'If String.IsNullOrEmpty(TXTServername.Text.Trim Is String.Empty) OrElse String.IsNullOrEmpty(TXTUser.Text.Trim) OrElse String.IsNullOrEmpty(TXTPass.Text.Trim) Then TabControl1.SelectedIndex = 0 : ToolTip1.Show("Check Connection Info ...", TXTServername, 2000) : Exit Sub

        If Not ConnectionGenerals.TestConnection Then

            TabControl1.SelectedIndex = 0 : ToolTip1.Show("Check Connection Info ...", TXTServername, 2000) : Exit Sub

        End If

        Me.Hide()

        Dim F As New FrmBackup(DataBaseListComp, ConnectionGenerals)
        F.ShowDialog()

        Me.Show()

    End Sub

    Private Sub BtnEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)

        sender.FlatStyle = FlatStyle.Standard

    End Sub

    Private Sub BtnLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)

        sender.FlatStyle = FlatStyle.Flat

    End Sub

    Private Sub ButtonRestor_Click(sender As Object, e As EventArgs) Handles ButtonRestor.Click

        'If String.IsNullOrEmpty(TXTServername.Text.Trim Is String.Empty) OrElse String.IsNullOrEmpty(TXTUser.Text.Trim) OrElse String.IsNullOrEmpty(TXTPass.Text.Trim) Then TabControl1.SelectedIndex = 0 : ToolTip1.Show("Check Connection Info ...", TXTServername, 2000) : Exit Sub

        If Not ConnectionGenerals.TestConnection Then

            TabControl1.SelectedIndex = 0 : ToolTip1.Show("Check Connection Info ...", TXTServername, 2000) : Exit Sub

        End If

        Me.Hide()

        Dim F As New FrmRestor(ConnectionGenerals)
        F.ShowDialog()

        Me.Show()

    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click

        Dim TH As New Threading.Thread(AddressOf GET_DB)
        TH.Start()

    End Sub

End Class
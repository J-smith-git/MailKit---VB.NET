Imports System.IO
Imports System.Net
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Enumerations
Imports Telerik.WinControls.UI


Public Class frmMain

    Protected Overrides ReadOnly Property CreateParams() As CreateParams

        Get
            Dim handleParam As CreateParams = MyBase.CreateParams
            handleParam.ExStyle = handleParam.ExStyle Or &H2000000
            ' WS_EX_COMPOSITED       
            Return handleParam
        End Get

    End Property

#Region "System Tray"

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        If Me.WindowState = FormWindowState.Minimized Then
            ntServer.Visible = True
            Me.Hide()
        End If

    End Sub

    Private Sub ntServer_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ntServer.MouseDoubleClick

        Me.Show()
        Me.WindowState = FormWindowState.Maximized
        ntServer.Visible = False

    End Sub

#End Region

#Region "Load"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        General.TempAttachmentsPath = txtTemporaryAttachments.Text

    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        ' Auto-start
        btnStart.ToggleState = ToggleState.On

    End Sub

#End Region

#Region "Start/Stop Processes"

    Private Sub btnStart_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles btnStart.ToggleStateChanged

        General.SMKit = New SMKit("", 555)

        If args.ToggleState = ToggleState.On Then

            If Not CreateConnection() Then
                btnStart.ToggleState = ToggleState.Off
            End If

            CreateBlacklist()
            CreateAliasManager()
            StartAttachmentManager()

            If General.Connection.Status = Connection.ConnectionStatus.OK Then
                btnMailServer.Enabled = True
                btnMailServer.ToggleState = ToggleState.On
            End If

        Else

            ' Stop database connection and all other processes
            General.Connection.Status = Connection.ConnectionStatus.NotConnected
            btnMailServer.Enabled = False
            btnMailServer.ToggleState = ToggleState.Off

        End If

        UpdateConnectionString()

    End Sub

    Private Sub btnStartMailServer_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles btnMailServer.ToggleStateChanged

        If args.ToggleState = ToggleState.On Then
            StartMailServer()
        Else
            StopMailServer()
        End If

    End Sub

    Private Function CreateConnection() As Boolean

        ' Create database connection
        General.Connection = New Connection(txtServer.Text,
                                      txtDatabase.Text,
                                      txtUsername.Text,
                                      txtPassword.Text)

        If General.Connection.Status = Prism_Server.Connection.ConnectionStatus.Failed Then

            Dim l As New ServerLog
            l.Text = "Database connection failed."
            l.Save()

            Return False

        End If

        Return True

    End Function

    Private Sub CreateBlacklist()

        If IsNothing(General.Blacklist) Then
            General.Blacklist = New Blacklist
        End If

    End Sub

    Private Sub CreateAliasManager()

        If IsNothing(General.AliasManager) Then
            General.AliasManager = New AliasManager
        End If

    End Sub

    Private Sub StartAttachmentManager()

        If IsNothing(General.AttachmentManager) Then
            General.AttachmentManager = New AttachmentManager
        End If

    End Sub

    Private Sub StartMailServer()

        ' Create mail sorting office
        General.MailSorter = New MailSorter
        grdInboxes.DataSource = General.MailSorter.Inboxes

        Dim PortString As String = txtSMTPPort.Text
        PortString = PortString.Replace(" ", "")
        Dim PortList As New List(Of String)(PortString.Split(","c))
        Dim SMTPPorts(PortList.Count) As Integer

        For i As Integer = 0 To PortList.Count - 1
            SMTPPorts(i) = Convert.ToInt32(PortList(i))
        Next

        ' Start mail monitor
        General.MailMonitor = New MailMonitor(txtPOP3Host.Text,
                                              txtPOP3Username.Text,
                                              txtPOP3Password.Text,
                                              txtPOP3Port.Text,
                                              txtSMTPUsername.Text,
                                              txtSMTPPassword.Text,
                                              SMTPPorts)
        ' Create outbox
        General.Outbox = New Outbox(txtSMTPServer.Text,
                                    txtTemporaryAttachments.Text)

    End Sub

    Private Sub StopMailServer()

        grdInboxes.DataSource = Nothing

        ' Stop mail processes
        If Not IsNothing(General.MailMonitor) Then
            General.MailMonitor.StopMonitoring()
            General.Outbox.StopSending()
        End If

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        StopMailServer()

        If Not IsNothing(General.MailMonitor) Then
            General.MailMonitor.Dispose()
        End If

    End Sub

#End Region

#Region "Check Process Statuses"

    Private Sub ReconnectToDatabase()

        ' Check if database is connected
        General.Connection.Poll()
        lblConnectionStatus.Text = General.Connection.Status.ToString

        If General.Connection.Status = Prism_Server.Connection.ConnectionStatus.Failed Then

            Dim l As New ServerLog
            l.Text = "Database connection failed."
            l.Save()

            btnStart.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
            btnMailServer.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off

        End If

    End Sub

    Private Sub UpdateConnectionString()

        lblDatabase.Text = General.Connection.Database
        lblConnectionStatus.Text = General.Connection.Status.ToString

    End Sub

#End Region

#Region "Top Menu"

#Region "Read Me"

    Private Sub mnuReadMe_Click(sender As Object, e As EventArgs) Handles mnuReadMe.Click

    End Sub

#End Region

#Region "Email"

    Private Sub mnuToolsAliasSetup_Click(sender As Object, e As EventArgs) Handles mnuToolsAliasSetup.Click

        Dim AliasSetup As New frmAliasSetup
        AliasSetup.Show()

    End Sub

    Private Sub mnuToolsReImport_Click(sender As Object, e As EventArgs) Handles mnuToolsReImport.Click

        Dim Dialog As New OpenFileDialog

        If Dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Email As New Email(Dialog.FileName, True, False, False, DateTime.Now)
        End If

    End Sub

    Private Sub mnuSearchByContact_Click(sender As Object, e As EventArgs) Handles mnuSearchByContact.Click

        Dim SearchByContact As New frmSearchByContact
        SearchByContact.Show()

    End Sub

    Private Sub mnuToolsEmailCounter_Click(sender As Object, e As EventArgs) Handles mnuToolsEmailCounter.Click

        Dim EmailCounter As New frmEmailCounter
        EmailCounter.Show()

    End Sub

    Private Sub mnuToolsDeleteAttachments_Click(sender As Object, e As EventArgs) Handles mnuToolsDeleteAttachments.Click

        General.MailMonitor.DeleteAttachments()

    End Sub

#End Region

#End Region

#Region "Grid"

    Private IsUnchecking As Boolean

    Private Sub grdInboxes_ValueChanged(sender As Object, e As EventArgs) Handles grdInboxes.ValueChanged

        If IsUnchecking Then
            Exit Sub
        End If

        grdInboxes.EndEdit()

        If grdInboxes.CurrentColumn.Name = "colPostmaster" Then

            Dim CurrentCell As GridDataCellElement = grdInboxes.CurrentCell
            Dim Original As String
            Dim Selected As String

            If CurrentCell.Value = True Then

                IsUnchecking = True

                Selected = grdInboxes.CurrentRow.Cells("colEmailAddress").Value

                For Each Row In grdInboxes.Rows

                    If Not Row.Index = CurrentCell.RowIndex Then

                        If Row.Cells("colPostmaster").Value = True Then
                            Row.Cells("colPostmaster").Value = False
                            Original = Row.Cells("colEmailAddress").Value
                        End If

                    End If

                Next

                Using Connection As MySqlConnection = New MySqlConnection(General.Connection.Text)

                    Connection.Open()

                    Dim CommandText As String = "UPDATE email_2017_employees " &
                        "SET Is_Postmaster = @Value " &
                        "WHERE Email_Address = @EmailAddress"

                    Using Command As New MySqlCommand(CommandText, Connection)
                        Command.Parameters.AddWithValue("@Value", 0)
                        Command.Parameters.AddWithValue("@EmailAddress", Original)
                        Command.ExecuteNonQuery()
                    End Using

                    Using Command As New MySqlCommand(CommandText, Connection)
                        Command.Parameters.AddWithValue("@Value", 1)
                        Command.Parameters.AddWithValue("@EmailAddress", Selected)
                        Command.ExecuteNonQuery()
                    End Using

                    Connection.Close()

                End Using

                IsUnchecking = False

            Else

                Dim PostmasterFound As Boolean

                For Each Row In grdInboxes.Rows

                    If Row.Cells("colPostmaster").Value = True Then
                        PostmasterFound = True
                        Exit For
                    End If

                Next

                If Not PostmasterFound Then

                    MessageBox.Show("Prism server must have a postmaster to deliver misaddressed email to.",
                                    "",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation)
                    grdInboxes.CurrentRow.Cells("colPostmaster").Value = True

                End If

            End If

        End If

    End Sub

#End Region

End Class

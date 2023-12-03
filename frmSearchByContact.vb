Imports Telerik.WinControls.UI
Imports MySql.Data.MySqlClient

Public Class frmSearchByContact

    Private Emails As New DataTable

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim CommandText As String = "SELECT Subject, Date_Time, Name, Path " & _
            "FROM email_2017 " & _
            "JOIN email_2017_folders ON Folder_ID = email_2017_folders.Data_ID " & _
            "WHERE email_2017.Data_ID IN " & _
            "(SELECT Email_ID FROM email_2017_contacts WHERE Email_Address LIKE '%" & txtEmailAddress.Text & "%') " & _
            "ORDER BY Date_Time DESC " & _
            "LIMIT 500"

        Using Connection As New MySqlConnection(General.Connection.Text)

            Using Command As New MySqlCommand(CommandText, Connection)

                Command.CommandType = CommandType.Text

                Using Adapter As New MySqlDataAdapter(Command)

                    Adapter.Fill(Emails)
                    grdEmails.DataSource = Emails

                End Using
            End Using

        End Using

    End Sub

End Class


Imports Telerik.WinControls.UI
Imports MySql.Data.MySqlClient

Public Class frmEmailCounter

    Private Sub frmEmailCounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim CommandText As String = "SELECT * " & _
            "FROM email_2017_count " & _
            "ORDER BY Date DESC"
        Dim Table As New DataTable

        Using Connection As MySqlConnection = New MySqlConnection(General.Connection.Text)

            Connection.Open()

            Using Adapter = New MySqlDataAdapter(CommandText, Connection)

                Adapter.Fill(Table)

            End Using

            grdCounter.DataSource = Table

            Connection.Close()

        End Using

    End Sub

End Class


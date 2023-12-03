Imports Telerik.WinControls.UI
Imports MySql.Data.MySqlClient
Imports Prism_Server.AliasManager

Public Class frmAliasSetup

    Private Actions As New DataTable
    Private ToDelete As New List(Of EmailAlias)

    Private Sub frmAliasSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Setup combobox column
        Dim colAction As GridViewComboBoxColumn = grdAlias.Columns("colAction")
        colAction.DataSource = [Enum].GetValues(GetType(AliasManager.EmailAlias.AliasAction))

        ' Set datasource
        grdAlias.DataSource = General.AliasManager.Aliases

    End Sub

#Region "Grid"

    Private Sub grdAlias_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles grdAlias.ViewCellFormatting

        Dim Action = e.Row.Cells("colAction").Value

        If IsDBNull(Action) Then
            Exit Sub
        End If

        If IsNothing(Action) Then
            Exit Sub
        End If

        If Action.ToString = "" Then
            Exit Sub
        End If

        ' Forwarding address not required
        If e.Column.Name = "colForwardingAddress" Then
            e.CellElement.Enabled = IIf(Action = AliasManager.EmailAlias.AliasAction.Forward, True, False)
        End If

        ' Replace address not required
        If e.Column.Name = "colReplaceAddress" Then
            e.CellElement.Enabled = IIf(Action = AliasManager.EmailAlias.AliasAction.Replace, True, False)
        End If

    End Sub

    Private Sub grdAlias_CellValueChanged(sender As Object, e As GridViewCellEventArgs) Handles grdAlias.CellValueChanged

        If e.Column.Name = "colAction" Then

            If e.Value = AliasManager.EmailAlias.AliasAction.Delete Then
                e.Row.Cells("colForwardingAddress").Value = ""
                e.Row.Cells("colReplaceAddress").Value = ""
            End If

        End If

    End Sub

    Private Sub grdAlias_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles grdAlias.RowsChanged

        If e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Remove Then

            Dim Row As GridViewDataRowInfo = e.NewItems(0)
            ToDelete.Add(Row.DataBoundItem)

        End If

    End Sub

#End Region

#Region "Save/Close"

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        ' Remove any deleted entries
        For Each Address In ToDelete
            General.AliasManager.Delete(Address)
        Next

        ' Update the table
        General.AliasManager.Update()

        Me.Close()

    End Sub

    Private Sub frmAliasSetup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        General.AliasManager.RefreshAliasSetup()

    End Sub

#End Region

End Class


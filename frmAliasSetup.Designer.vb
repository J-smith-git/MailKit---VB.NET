<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAliasSetup
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewComboBoxColumn1 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.grdAlias = New Telerik.WinControls.UI.RadGridView()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.grdAlias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAlias.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdAlias
        '
        Me.grdAlias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdAlias.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdAlias.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdAlias.EnableHotTracking = False
        Me.grdAlias.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.grdAlias.ForeColor = System.Drawing.Color.Black
        Me.grdAlias.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.grdAlias.Location = New System.Drawing.Point(0, 3)
        '
        '
        '
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "AliasAddress"
        GridViewTextBoxColumn1.HeaderText = "Alias Address"
        GridViewTextBoxColumn1.Name = "colAliasAddress"
        GridViewTextBoxColumn1.Width = 160
        GridViewComboBoxColumn1.EnableExpressionEditor = False
        GridViewComboBoxColumn1.FieldName = "Action"
        GridViewComboBoxColumn1.HeaderText = "Action"
        GridViewComboBoxColumn1.Name = "colAction"
        GridViewComboBoxColumn1.Width = 160
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "ForwardingAddress"
        GridViewTextBoxColumn2.HeaderText = "Forwarding Address"
        GridViewTextBoxColumn2.Name = "colForwardingAddress"
        GridViewTextBoxColumn2.Width = 160
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "ReplaceAddress"
        GridViewTextBoxColumn3.HeaderText = "Replace With Address"
        GridViewTextBoxColumn3.Name = "colReplaceAddress"
        GridViewTextBoxColumn3.Width = 160
        Me.grdAlias.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewComboBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3})
        Me.grdAlias.MasterTemplate.EnableGrouping = False
        Me.grdAlias.MasterTemplate.EnableSorting = False
        Me.grdAlias.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.grdAlias.Name = "grdAlias"
        Me.grdAlias.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grdAlias.ShowGroupPanel = False
        Me.grdAlias.Size = New System.Drawing.Size(680, 686)
        Me.grdAlias.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(570, 693)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 24)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Location = New System.Drawing.Point(0, 697)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(311, 18)
        Me.RadLabel1.TabIndex = 2
        Me.RadLabel1.Text = "N.B.: Forwarding/replacement addresses can be internal only."
        '
        'frmAliasSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 718)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grdAlias)
        Me.Name = "frmAliasSetup"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Email Alias Setup"
        CType(Me.grdAlias.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAlias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdAlias As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
End Class


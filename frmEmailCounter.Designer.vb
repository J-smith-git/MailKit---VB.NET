<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmailCounter
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.grdCounter = New Telerik.WinControls.UI.RadGridView()
        CType(Me.grdCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCounter.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdCounter
        '
        Me.grdCounter.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdCounter.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdCounter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCounter.EnableHotTracking = False
        Me.grdCounter.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.grdCounter.ForeColor = System.Drawing.Color.Black
        Me.grdCounter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.grdCounter.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "Date"
        GridViewTextBoxColumn1.FormatString = "{0:d}"
        GridViewTextBoxColumn1.HeaderText = "Date"
        GridViewTextBoxColumn1.Name = "colDate"
        GridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn1.Width = 100
        GridViewComboBoxColumn1.EnableExpressionEditor = False
        GridViewComboBoxColumn1.FieldName = "Email_Received"
        GridViewComboBoxColumn1.HeaderText = "Email Received"
        GridViewComboBoxColumn1.MinWidth = 6
        GridViewComboBoxColumn1.Name = "colEmailReceived"
        GridViewComboBoxColumn1.Width = 100
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "Spam_Intercepted"
        GridViewTextBoxColumn2.HeaderText = "Spam Intercepted"
        GridViewTextBoxColumn2.Name = "colSpamIntercepted"
        GridViewTextBoxColumn2.Width = 100
        Me.grdCounter.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewComboBoxColumn1, GridViewTextBoxColumn2})
        Me.grdCounter.MasterTemplate.EnableGrouping = False
        Me.grdCounter.MasterTemplate.EnableSorting = False
        Me.grdCounter.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.grdCounter.Name = "grdCounter"
        Me.grdCounter.ReadOnly = True
        Me.grdCounter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grdCounter.ShowGroupPanel = False
        Me.grdCounter.Size = New System.Drawing.Size(576, 411)
        Me.grdCounter.TabIndex = 0
        '
        'frmEmailCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 411)
        Me.Controls.Add(Me.grdCounter)
        Me.Name = "frmEmailCounter"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Email Counter"
        CType(Me.grdCounter.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdCounter As Telerik.WinControls.UI.RadGridView
End Class


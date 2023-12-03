<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchByContact
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
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.grdEmails = New Telerik.WinControls.UI.RadGridView()
        Me.btnSearch = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtEmailAddress = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.grdEmails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEmails.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmailAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdEmails
        '
        Me.grdEmails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdEmails.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdEmails.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdEmails.EnableHotTracking = False
        Me.grdEmails.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.grdEmails.ForeColor = System.Drawing.Color.Black
        Me.grdEmails.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.grdEmails.Location = New System.Drawing.Point(0, 26)
        '
        '
        '
        Me.grdEmails.MasterTemplate.AllowColumnReorder = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "Subject"
        GridViewTextBoxColumn1.HeaderText = "Subject"
        GridViewTextBoxColumn1.MaxWidth = 300
        GridViewTextBoxColumn1.MinWidth = 300
        GridViewTextBoxColumn1.Name = "colSubject"
        GridViewTextBoxColumn1.Width = 300
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "Date_Time"
        GridViewTextBoxColumn2.HeaderText = "Date/Time"
        GridViewTextBoxColumn2.MaxWidth = 120
        GridViewTextBoxColumn2.MinWidth = 120
        GridViewTextBoxColumn2.Name = "colDateTime"
        GridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewTextBoxColumn2.Width = 120
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "Name"
        GridViewTextBoxColumn3.HeaderText = "Folder Name"
        GridViewTextBoxColumn3.MaxWidth = 300
        GridViewTextBoxColumn3.MinWidth = 300
        GridViewTextBoxColumn3.Name = "colFolderName"
        GridViewTextBoxColumn3.Width = 300
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "Path"
        GridViewTextBoxColumn4.HeaderText = "Folder Path"
        GridViewTextBoxColumn4.MaxWidth = 300
        GridViewTextBoxColumn4.MinWidth = 300
        GridViewTextBoxColumn4.Name = "colFolderPath"
        GridViewTextBoxColumn4.Width = 300
        Me.grdEmails.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4})
        Me.grdEmails.MasterTemplate.EnableGrouping = False
        Me.grdEmails.MasterTemplate.EnableSorting = False
        Me.grdEmails.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.grdEmails.Name = "grdEmails"
        Me.grdEmails.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grdEmails.ShowGroupPanel = False
        Me.grdEmails.Size = New System.Drawing.Size(1038, 583)
        Me.grdEmails.TabIndex = 0
        Me.grdEmails.Text = "RadGridView1"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(373, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(60, 20)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(2, 4)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(172, 18)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Email Address, or Part of Address"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(177, 3)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(193, 20)
        Me.txtEmailAddress.TabIndex = 4
        '
        'frmSearchByContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 609)
        Me.Controls.Add(Me.txtEmailAddress)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.grdEmails)
        Me.Name = "frmSearchByContact"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Search for Email(s) by Contact"
        CType(Me.grdEmails.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEmails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmailAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdEmails As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnSearch As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtEmailAddress As Telerik.WinControls.UI.RadTextBox
End Class


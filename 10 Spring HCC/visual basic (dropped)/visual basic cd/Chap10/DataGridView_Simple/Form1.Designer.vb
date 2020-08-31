<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.SalesStaffDataSet = New DataGridView_Simple.SalesStaffDataSet
		Me.SalesStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.SalesStaffTableAdapter = New DataGridView_Simple.SalesStaffDataSetTableAdapters.SalesStaffTableAdapter
		Me.SalesStaffBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
		Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
		Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
		Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
		Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
		Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
		Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
		Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
		Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
		Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
		Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
		Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
		Me.SalesStaffBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
		Me.SalesStaffDataGridView = New System.Windows.Forms.DataGridView
		Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
		CType(Me.SalesStaffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SalesStaffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SalesStaffBindingNavigator.SuspendLayout()
		CType(Me.SalesStaffDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'SalesStaffDataSet
		'
		Me.SalesStaffDataSet.DataSetName = "SalesStaffDataSet"
		Me.SalesStaffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'SalesStaffBindingSource
		'
		Me.SalesStaffBindingSource.DataMember = "SalesStaff"
		Me.SalesStaffBindingSource.DataSource = Me.SalesStaffDataSet
		'
		'SalesStaffTableAdapter
		'
		Me.SalesStaffTableAdapter.ClearBeforeFill = True
		'
		'SalesStaffBindingNavigator
		'
		Me.SalesStaffBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
		Me.SalesStaffBindingNavigator.BindingSource = Me.SalesStaffBindingSource
		Me.SalesStaffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
		Me.SalesStaffBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
		Me.SalesStaffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SalesStaffBindingNavigatorSaveItem})
		Me.SalesStaffBindingNavigator.Location = New System.Drawing.Point(0, 0)
		Me.SalesStaffBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
		Me.SalesStaffBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
		Me.SalesStaffBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
		Me.SalesStaffBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
		Me.SalesStaffBindingNavigator.Name = "SalesStaffBindingNavigator"
		Me.SalesStaffBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
		Me.SalesStaffBindingNavigator.Size = New System.Drawing.Size(648, 25)
		Me.SalesStaffBindingNavigator.TabIndex = 0
		Me.SalesStaffBindingNavigator.Text = "BindingNavigator1"
		'
		'BindingNavigatorMoveFirstItem
		'
		Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
		Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorMoveFirstItem.Text = "Move first"
		'
		'BindingNavigatorMovePreviousItem
		'
		Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
		Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
		'
		'BindingNavigatorSeparator
		'
		Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
		Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
		'
		'BindingNavigatorPositionItem
		'
		Me.BindingNavigatorPositionItem.AccessibleName = "Position"
		Me.BindingNavigatorPositionItem.AutoSize = False
		Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
		Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
		Me.BindingNavigatorPositionItem.Text = "0"
		Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
		'
		'BindingNavigatorCountItem
		'
		Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
		Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 13)
		Me.BindingNavigatorCountItem.Text = "of {0}"
		Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
		'
		'BindingNavigatorSeparator1
		'
		Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
		Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
		'
		'BindingNavigatorMoveNextItem
		'
		Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
		Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
		Me.BindingNavigatorMoveNextItem.Text = "Move next"
		'
		'BindingNavigatorMoveLastItem
		'
		Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
		Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
		Me.BindingNavigatorMoveLastItem.Text = "Move last"
		'
		'BindingNavigatorSeparator2
		'
		Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
		Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
		'
		'BindingNavigatorAddNewItem
		'
		Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
		Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorAddNewItem.Text = "Add new"
		'
		'BindingNavigatorDeleteItem
		'
		Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
		Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
		Me.BindingNavigatorDeleteItem.Text = "Delete"
		'
		'SalesStaffBindingNavigatorSaveItem
		'
		Me.SalesStaffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.SalesStaffBindingNavigatorSaveItem.Image = CType(resources.GetObject("SalesStaffBindingNavigatorSaveItem.Image"), System.Drawing.Image)
		Me.SalesStaffBindingNavigatorSaveItem.Name = "SalesStaffBindingNavigatorSaveItem"
		Me.SalesStaffBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
		Me.SalesStaffBindingNavigatorSaveItem.Text = "Save Data"
		'
		'SalesStaffDataGridView
		'
		Me.SalesStaffDataGridView.AutoGenerateColumns = False
		Me.SalesStaffDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
		Me.SalesStaffDataGridView.DataSource = Me.SalesStaffBindingSource
		Me.SalesStaffDataGridView.Location = New System.Drawing.Point(0, 28)
		Me.SalesStaffDataGridView.Name = "SalesStaffDataGridView"
		Me.SalesStaffDataGridView.Size = New System.Drawing.Size(684, 391)
		Me.SalesStaffDataGridView.TabIndex = 1
		'
		'DataGridViewTextBoxColumn1
		'
		Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
		Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
		Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		'
		'DataGridViewTextBoxColumn5
		'
		Me.DataGridViewTextBoxColumn5.DataPropertyName = "Last_Name"
		Me.DataGridViewTextBoxColumn5.HeaderText = "Last_Name"
		Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
		'
		'DataGridViewTextBoxColumn6
		'
		Me.DataGridViewTextBoxColumn6.DataPropertyName = "First_Name"
		Me.DataGridViewTextBoxColumn6.HeaderText = "First_Name"
		Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
		'
		'DataGridViewCheckBoxColumn2
		'
		Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Full_Time"
		Me.DataGridViewCheckBoxColumn2.HeaderText = "Full_Time"
		Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
		'
		'DataGridViewTextBoxColumn7
		'
		Me.DataGridViewTextBoxColumn7.DataPropertyName = "Hire_Date"
		Me.DataGridViewTextBoxColumn7.HeaderText = "Hire_Date"
		Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
		'
		'DataGridViewTextBoxColumn8
		'
		Me.DataGridViewTextBoxColumn8.DataPropertyName = "Salary"
		Me.DataGridViewTextBoxColumn8.HeaderText = "Salary"
		Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(648, 421)
		Me.Controls.Add(Me.SalesStaffDataGridView)
		Me.Controls.Add(Me.SalesStaffBindingNavigator)
		Me.Name = "Form1"
		Me.Text = "Company SaleStaff Table"
		CType(Me.SalesStaffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SalesStaffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SalesStaffBindingNavigator.ResumeLayout(False)
		Me.SalesStaffBindingNavigator.PerformLayout()
		CType(Me.SalesStaffDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullTimeDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents HireDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents SalaryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents SalesStaffDataSet As DataGridView_Simple.SalesStaffDataSet
	Friend WithEvents SalesStaffBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents SalesStaffTableAdapter As DataGridView_Simple.SalesStaffDataSetTableAdapters.SalesStaffTableAdapter
	Friend WithEvents SalesStaffBindingNavigator As System.Windows.Forms.BindingNavigator
	Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
	Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
	Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
	Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
	Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
	Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
	Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
	Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
	Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents SalesStaffBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
	Friend WithEvents SalesStaffDataGridView As System.Windows.Forms.DataGridView
	Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

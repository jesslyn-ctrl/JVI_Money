<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class transaction
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.JVIMainBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JVI_MoneyDataSet = New JVIMoney.JVI_MoneyDataSet()
        Me.JVIMainBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransactionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JVI_MoneyDataSet1 = New JVIMoney.JVI_MoneyDataSet()
        Me.TransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JVIMainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JVI_MainTableAdapter = New JVIMoney.JVI_MoneyDataSetTableAdapters.JVI_MainTableAdapter()
        Me.main_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategorynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.memo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.JVIMainBindingSource2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.JVI_MoneyDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.JVIMainBindingSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TransactionBindingSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.JVI_MoneyDataSet1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TransactionBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.JVIMainBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.JVIMoney.My.Resources.Resources.menu
        Me.PictureBox1.Location = New System.Drawing.Point(7, 6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.JVIMoney.My.Resources.Resources.plus
        Me.PictureBox2.Location = New System.Drawing.Point(167, 415)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = false
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Add transaction")
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "My Wallet"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Rp."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(150, 62)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "0"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.JVIMoney.My.Resources.Resources.more
        Me.PictureBox3.Location = New System.Drawing.Point(325, 6)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(60, 52)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = false
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 415)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 52)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Income"
        Me.GroupBox1.Visible = false
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(9, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Label4"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(240, 415)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(145, 52)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Expense"
        Me.GroupBox2.Visible = false
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(6, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Label5"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = false
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.main_id, Me.DateDataGridViewTextBoxColumn, Me.CategorynameDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.memo})
        Me.DataGridView1.DataSource = Me.JVIMainBindingSource2
        Me.DataGridView1.EnableHeadersVisualStyles = false
        Me.DataGridView1.GridColor = System.Drawing.Color.Silver
        Me.DataGridView1.Location = New System.Drawing.Point(9, 98)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(378, 310)
        Me.DataGridView1.TabIndex = 11
        '
        'JVIMainBindingSource2
        '
        Me.JVIMainBindingSource2.DataMember = "JVI_Main"
        Me.JVIMainBindingSource2.DataSource = Me.JVI_MoneyDataSet
        '
        'JVI_MoneyDataSet
        '
        Me.JVI_MoneyDataSet.DataSetName = "JVI_MoneyDataSet"
        Me.JVI_MoneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JVIMainBindingSource1
        '
        Me.JVIMainBindingSource1.DataMember = "JVI_Main"
        Me.JVIMainBindingSource1.DataSource = Me.JVI_MoneyDataSet
        '
        'TransactionBindingSource1
        '
        Me.TransactionBindingSource1.DataMember = "Transaction"
        Me.TransactionBindingSource1.DataSource = Me.JVI_MoneyDataSet1
        '
        'JVI_MoneyDataSet1
        '
        Me.JVI_MoneyDataSet1.DataSetName = "JVI_MoneyDataSet"
        Me.JVI_MoneyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransactionBindingSource
        '
        Me.TransactionBindingSource.DataMember = "Transaction"
        Me.TransactionBindingSource.DataSource = Me.JVI_MoneyDataSet
        '
        'JVIMainBindingSource
        '
        Me.JVIMainBindingSource.DataMember = "JVI_Main"
        Me.JVIMainBindingSource.DataSource = Me.JVI_MoneyDataSet
        '
        'JVI_MainTableAdapter
        '
        Me.JVI_MainTableAdapter.ClearBeforeFill = true
        '
        'main_id
        '
        Me.main_id.DataPropertyName = "main_id"
        Me.main_id.HeaderText = "main_id"
        Me.main_id.MinimumWidth = 6
        Me.main_id.Name = "main_id"
        Me.main_id.ReadOnly = true
        Me.main_id.Visible = false
        Me.main_id.Width = 125
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.Width = 125
        '
        'CategorynameDataGridViewTextBoxColumn
        '
        Me.CategorynameDataGridViewTextBoxColumn.DataPropertyName = "category_name"
        Me.CategorynameDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategorynameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CategorynameDataGridViewTextBoxColumn.Name = "CategorynameDataGridViewTextBoxColumn"
        Me.CategorynameDataGridViewTextBoxColumn.Width = 125
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.Width = 125
        '
        'memo
        '
        Me.memo.DataPropertyName = "memo"
        Me.memo.HeaderText = "Notes"
        Me.memo.MinimumWidth = 6
        Me.memo.Name = "memo"
        Me.memo.Width = 125
        '
        'transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.JVIMoney.My.Resources.Resources.bggui_uas2
        Me.ClientSize = New System.Drawing.Size(397, 484)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "transaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "transaction"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.JVIMainBindingSource2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.JVI_MoneyDataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.JVIMainBindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TransactionBindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.JVI_MoneyDataSet1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TransactionBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.JVIMainBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents JVI_MoneyDataSet As JVI_MoneyDataSet
    Friend WithEvents JVIMainBindingSource As BindingSource
    Friend WithEvents JVI_MainTableAdapter As JVI_MoneyDataSetTableAdapters.JVI_MainTableAdapter
    Friend WithEvents TransactionBindingSource As BindingSource
    Friend WithEvents JVI_MoneyDataSet1 As JVI_MoneyDataSet
    Friend WithEvents TransactionBindingSource1 As BindingSource
    Friend WithEvents JVIMainBindingSource1 As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents JVIMainBindingSource2 As BindingSource
    Friend WithEvents main_id As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategorynameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents memo As DataGridViewTextBoxColumn
End Class

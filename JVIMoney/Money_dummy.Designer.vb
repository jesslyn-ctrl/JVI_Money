<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Money_dummy
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.JVI_MoneyDataSet = New JVIMoney.JVI_MoneyDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New JVIMoney.JVI_MoneyDataSetTableAdapters.UsersTableAdapter()
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.JVI_MoneyDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UsersBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = false
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.JVI_MoneyDataSet
        Me.DataGridView1.Location = New System.Drawing.Point(42, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(674, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'JVI_MoneyDataSet
        '
        Me.JVI_MoneyDataSet.DataSetName = "JVI_MoneyDataSet"
        Me.JVI_MoneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.JVI_MoneyDataSet
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = true
        '
        'Money_dummy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Money_dummy"
        Me.Text = "Money_dummy"
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.JVI_MoneyDataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UsersBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents JVI_MoneyDataSet As JVI_MoneyDataSet
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As JVI_MoneyDataSetTableAdapters.UsersTableAdapter
End Class

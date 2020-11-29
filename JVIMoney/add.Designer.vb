<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CategoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JVI_MoneyDataSet = New JVIMoney.JVI_MoneyDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.JVI_MoneyDataSet1 = New JVIMoney.JVI_MoneyDataSet()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryTableAdapter = New JVIMoney.JVI_MoneyDataSetTableAdapters.CategoryTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        CType(Me.CategoryBindingSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.JVI_MoneyDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.JVI_MoneyDataSet1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CategoryBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.BackgroundImage = Global.JVIMoney.My.Resources.Resources.backbutton1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(7, 6)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 49)
        Me.Button1.TabIndex = 11
        Me.Button1.UseVisualStyleBackColor = false
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox1.Location = New System.Drawing.Point(105, 78)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 37)
        Me.TextBox1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 31)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Rp."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CategoryBindingSource1
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ComboBox1.FormattingEnabled = true
        Me.ComboBox1.Location = New System.Drawing.Point(64, 73)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(185, 33)
        Me.ComboBox1.TabIndex = 15
        '
        'CategoryBindingSource1
        '
        Me.CategoryBindingSource1.DataMember = "Category"
        Me.CategoryBindingSource1.DataSource = Me.JVI_MoneyDataSet
        '
        'JVI_MoneyDataSet
        '
        Me.JVI_MoneyDataSet.DataSetName = "JVI_MoneyDataSet"
        Me.JVI_MoneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 271)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Note"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(107, 271)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(224, 54)
        Me.RichTextBox1.TabIndex = 17
        Me.RichTextBox1.Text = ""
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(46, 341)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(285, 26)
        Me.DateTimePicker1.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkOrange
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(243, 401)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 42)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = false
        '
        'JVI_MoneyDataSet1
        '
        Me.JVI_MoneyDataSet1.DataSetName = "JVI_MoneyDataSet1"
        Me.JVI_MoneyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.JVI_MoneyDataSet1
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = true
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Book Antiqua", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(43, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 142)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Category"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = true
        Me.RadioButton2.Location = New System.Drawing.Point(154, 31)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(105, 28)
        Me.RadioButton2.TabIndex = 17
        Me.RadioButton2.TabStop = true
        Me.RadioButton2.Text = "Expense"
        Me.RadioButton2.UseVisualStyleBackColor = true
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = true
        Me.RadioButton1.Location = New System.Drawing.Point(50, 31)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(98, 28)
        Me.RadioButton1.TabIndex = 16
        Me.RadioButton1.TabStop = true
        Me.RadioButton1.Text = "Income"
        Me.RadioButton1.UseVisualStyleBackColor = true
        '
        'add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.JVIMoney.My.Resources.Resources.bggui_uas2
        Me.ClientSize = New System.Drawing.Size(379, 475)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add"
        CType(Me.CategoryBindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.JVI_MoneyDataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.JVI_MoneyDataSet1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CategoryBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents JVI_MoneyDataSet1 As JVI_MoneyDataSet
    Friend WithEvents CategoryBindingSource As BindingSource
    Friend WithEvents CategoryTableAdapter As JVI_MoneyDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents JVI_MoneyDataSet As JVI_MoneyDataSet
    Friend WithEvents CategoryBindingSource1 As BindingSource
End Class

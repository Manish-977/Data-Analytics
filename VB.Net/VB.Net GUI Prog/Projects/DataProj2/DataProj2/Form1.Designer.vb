<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataSet1 = New DataProj2.DataSet1()
        Me.DEPTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DEPTTableAdapter = New DataProj2.DataSet1TableAdapters.DEPTTableAdapter()
        Me.DEPTNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEPTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DEPTNODataGridViewTextBoxColumn, Me.DNAMEDataGridViewTextBoxColumn, Me.LOCDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DEPTBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(272, 169)
        Me.DataGridView1.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DEPTBindingSource
        '
        Me.DEPTBindingSource.DataMember = "DEPT"
        Me.DEPTBindingSource.DataSource = Me.DataSet1
        '
        'DEPTTableAdapter
        '
        Me.DEPTTableAdapter.ClearBeforeFill = True
        '
        'DEPTNODataGridViewTextBoxColumn
        '
        Me.DEPTNODataGridViewTextBoxColumn.DataPropertyName = "DEPTNO"
        Me.DEPTNODataGridViewTextBoxColumn.HeaderText = "DEPTNO"
        Me.DEPTNODataGridViewTextBoxColumn.Name = "DEPTNODataGridViewTextBoxColumn"
        '
        'DNAMEDataGridViewTextBoxColumn
        '
        Me.DNAMEDataGridViewTextBoxColumn.DataPropertyName = "DNAME"
        Me.DNAMEDataGridViewTextBoxColumn.HeaderText = "DNAME"
        Me.DNAMEDataGridViewTextBoxColumn.Name = "DNAMEDataGridViewTextBoxColumn"
        '
        'LOCDataGridViewTextBoxColumn
        '
        Me.LOCDataGridViewTextBoxColumn.DataPropertyName = "LOC"
        Me.LOCDataGridViewTextBoxColumn.HeaderText = "LOC"
        Me.LOCDataGridViewTextBoxColumn.Name = "LOCDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEPTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As DataProj2.DataSet1
    Friend WithEvents DEPTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DEPTTableAdapter As DataProj2.DataSet1TableAdapters.DEPTTableAdapter
    Friend WithEvents DEPTNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

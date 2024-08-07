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
        Me.DataSet1 = New Dataproj3.DataSet1()
        Me.EMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPTableAdapter = New Dataproj3.DataSet1TableAdapters.EMPTableAdapter()
        Me.EMPNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MGRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HIREDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPTNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EMPNODataGridViewTextBoxColumn, Me.ENAMEDataGridViewTextBoxColumn, Me.JOBDataGridViewTextBoxColumn, Me.MGRDataGridViewTextBoxColumn, Me.HIREDATEDataGridViewTextBoxColumn, Me.SALDataGridViewTextBoxColumn, Me.COMMDataGridViewTextBoxColumn, Me.DEPTNODataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EMPBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(68, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(382, 264)
        Me.DataGridView1.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPBindingSource
        '
        Me.EMPBindingSource.DataMember = "EMP"
        Me.EMPBindingSource.DataSource = Me.DataSet1
        '
        'EMPTableAdapter
        '
        Me.EMPTableAdapter.ClearBeforeFill = True
        '
        'EMPNODataGridViewTextBoxColumn
        '
        Me.EMPNODataGridViewTextBoxColumn.DataPropertyName = "EMPNO"
        Me.EMPNODataGridViewTextBoxColumn.HeaderText = "EMPNO"
        Me.EMPNODataGridViewTextBoxColumn.Name = "EMPNODataGridViewTextBoxColumn"
        '
        'ENAMEDataGridViewTextBoxColumn
        '
        Me.ENAMEDataGridViewTextBoxColumn.DataPropertyName = "ENAME"
        Me.ENAMEDataGridViewTextBoxColumn.HeaderText = "ENAME"
        Me.ENAMEDataGridViewTextBoxColumn.Name = "ENAMEDataGridViewTextBoxColumn"
        '
        'JOBDataGridViewTextBoxColumn
        '
        Me.JOBDataGridViewTextBoxColumn.DataPropertyName = "JOB"
        Me.JOBDataGridViewTextBoxColumn.HeaderText = "JOB"
        Me.JOBDataGridViewTextBoxColumn.Name = "JOBDataGridViewTextBoxColumn"
        '
        'MGRDataGridViewTextBoxColumn
        '
        Me.MGRDataGridViewTextBoxColumn.DataPropertyName = "MGR"
        Me.MGRDataGridViewTextBoxColumn.HeaderText = "MGR"
        Me.MGRDataGridViewTextBoxColumn.Name = "MGRDataGridViewTextBoxColumn"
        '
        'HIREDATEDataGridViewTextBoxColumn
        '
        Me.HIREDATEDataGridViewTextBoxColumn.DataPropertyName = "HIREDATE"
        Me.HIREDATEDataGridViewTextBoxColumn.HeaderText = "HIREDATE"
        Me.HIREDATEDataGridViewTextBoxColumn.Name = "HIREDATEDataGridViewTextBoxColumn"
        '
        'SALDataGridViewTextBoxColumn
        '
        Me.SALDataGridViewTextBoxColumn.DataPropertyName = "SAL"
        Me.SALDataGridViewTextBoxColumn.HeaderText = "SAL"
        Me.SALDataGridViewTextBoxColumn.Name = "SALDataGridViewTextBoxColumn"
        '
        'COMMDataGridViewTextBoxColumn
        '
        Me.COMMDataGridViewTextBoxColumn.DataPropertyName = "COMM"
        Me.COMMDataGridViewTextBoxColumn.HeaderText = "COMM"
        Me.COMMDataGridViewTextBoxColumn.Name = "COMMDataGridViewTextBoxColumn"
        '
        'DEPTNODataGridViewTextBoxColumn
        '
        Me.DEPTNODataGridViewTextBoxColumn.DataPropertyName = "DEPTNO"
        Me.DEPTNODataGridViewTextBoxColumn.HeaderText = "DEPTNO"
        Me.DEPTNODataGridViewTextBoxColumn.Name = "DEPTNODataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 348)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As Dataproj3.DataSet1
    Friend WithEvents EMPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPTableAdapter As Dataproj3.DataSet1TableAdapters.EMPTableAdapter
    Friend WithEvents EMPNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MGRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HIREDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COMMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPTNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

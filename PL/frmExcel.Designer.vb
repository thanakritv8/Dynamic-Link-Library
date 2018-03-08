<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExcel
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
        Me.dgvEmp = New System.Windows.Forms.DataGridView()
        Me.cId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cFirstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cLastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btExport = New System.Windows.Forms.Button()
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmp
        '
        Me.dgvEmp.AllowUserToAddRows = False
        Me.dgvEmp.AllowUserToDeleteRows = False
        Me.dgvEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cId, Me.cFirstname, Me.cLastname, Me.cUsername, Me.cPassword, Me.cAddress, Me.cTel})
        Me.dgvEmp.Location = New System.Drawing.Point(12, 86)
        Me.dgvEmp.Name = "dgvEmp"
        Me.dgvEmp.ReadOnly = True
        Me.dgvEmp.RowHeadersVisible = False
        Me.dgvEmp.Size = New System.Drawing.Size(597, 317)
        Me.dgvEmp.TabIndex = 0
        '
        'cId
        '
        Me.cId.HeaderText = "Id"
        Me.cId.Name = "cId"
        Me.cId.ReadOnly = True
        '
        'cFirstname
        '
        Me.cFirstname.HeaderText = "Firstname"
        Me.cFirstname.Name = "cFirstname"
        Me.cFirstname.ReadOnly = True
        '
        'cLastname
        '
        Me.cLastname.HeaderText = "Lastname"
        Me.cLastname.Name = "cLastname"
        Me.cLastname.ReadOnly = True
        '
        'cUsername
        '
        Me.cUsername.HeaderText = "Username"
        Me.cUsername.Name = "cUsername"
        Me.cUsername.ReadOnly = True
        '
        'cPassword
        '
        Me.cPassword.HeaderText = "Password"
        Me.cPassword.Name = "cPassword"
        Me.cPassword.ReadOnly = True
        '
        'cAddress
        '
        Me.cAddress.HeaderText = "Address"
        Me.cAddress.Name = "cAddress"
        Me.cAddress.ReadOnly = True
        '
        'cTel
        '
        Me.cTel.HeaderText = "Tel"
        Me.cTel.Name = "cTel"
        Me.cTel.ReadOnly = True
        '
        'btExport
        '
        Me.btExport.Location = New System.Drawing.Point(12, 13)
        Me.btExport.Name = "btExport"
        Me.btExport.Size = New System.Drawing.Size(75, 23)
        Me.btExport.TabIndex = 1
        Me.btExport.Text = "Export"
        Me.btExport.UseVisualStyleBackColor = True
        '
        'frmExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 415)
        Me.Controls.Add(Me.btExport)
        Me.Controls.Add(Me.dgvEmp)
        Me.Name = "frmExcel"
        Me.Text = "frmExcel"
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvEmp As System.Windows.Forms.DataGridView
    Friend WithEvents cId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cFirstname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cLastname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUsername As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPassword As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btExport As System.Windows.Forms.Button
End Class

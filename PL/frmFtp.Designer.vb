<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFtp
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
        Me.btGetFile = New System.Windows.Forms.Button()
        Me.btDownload = New System.Windows.Forms.Button()
        Me.btDeiete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btGetFile
        '
        Me.btGetFile.Location = New System.Drawing.Point(12, 12)
        Me.btGetFile.Name = "btGetFile"
        Me.btGetFile.Size = New System.Drawing.Size(75, 23)
        Me.btGetFile.TabIndex = 0
        Me.btGetFile.Text = "Upload"
        Me.btGetFile.UseVisualStyleBackColor = True
        '
        'btDownload
        '
        Me.btDownload.Location = New System.Drawing.Point(12, 41)
        Me.btDownload.Name = "btDownload"
        Me.btDownload.Size = New System.Drawing.Size(75, 23)
        Me.btDownload.TabIndex = 1
        Me.btDownload.Text = "Download"
        Me.btDownload.UseVisualStyleBackColor = True
        '
        'btDeiete
        '
        Me.btDeiete.Location = New System.Drawing.Point(12, 70)
        Me.btDeiete.Name = "btDeiete"
        Me.btDeiete.Size = New System.Drawing.Size(75, 23)
        Me.btDeiete.TabIndex = 2
        Me.btDeiete.Text = "Delete"
        Me.btDeiete.UseVisualStyleBackColor = True
        '
        'PL_Ftp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btDeiete)
        Me.Controls.Add(Me.btDownload)
        Me.Controls.Add(Me.btGetFile)
        Me.Name = "PL_Ftp"
        Me.Text = "FTP"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btGetFile As System.Windows.Forms.Button
    Friend WithEvents btDownload As System.Windows.Forms.Button
    Friend WithEvents btDeiete As System.Windows.Forms.Button

End Class

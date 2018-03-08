<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPicDiff
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
        Me.picDiff = New System.Windows.Forms.PictureBox()
        Me.picB = New System.Windows.Forms.PictureBox()
        Me.btDiff = New System.Windows.Forms.Button()
        Me.btPicB = New System.Windows.Forms.Button()
        Me.btPicA = New System.Windows.Forms.Button()
        Me.picA = New System.Windows.Forms.PictureBox()
        CType(Me.picDiff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDiff
        '
        Me.picDiff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDiff.Location = New System.Drawing.Point(268, 12)
        Me.picDiff.Name = "picDiff"
        Me.picDiff.Size = New System.Drawing.Size(250, 250)
        Me.picDiff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDiff.TabIndex = 11
        Me.picDiff.TabStop = False
        '
        'picB
        '
        Me.picB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picB.Location = New System.Drawing.Point(524, 12)
        Me.picB.Name = "picB"
        Me.picB.Size = New System.Drawing.Size(250, 250)
        Me.picB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picB.TabIndex = 10
        Me.picB.TabStop = False
        '
        'btDiff
        '
        Me.btDiff.Location = New System.Drawing.Point(340, 268)
        Me.btDiff.Name = "btDiff"
        Me.btDiff.Size = New System.Drawing.Size(96, 33)
        Me.btDiff.TabIndex = 9
        Me.btDiff.Text = "Difference"
        Me.btDiff.UseVisualStyleBackColor = True
        '
        'btPicB
        '
        Me.btPicB.Location = New System.Drawing.Point(596, 268)
        Me.btPicB.Name = "btPicB"
        Me.btPicB.Size = New System.Drawing.Size(96, 33)
        Me.btPicB.TabIndex = 8
        Me.btPicB.Text = "Load Picture B"
        Me.btPicB.UseVisualStyleBackColor = True
        '
        'btPicA
        '
        Me.btPicA.Location = New System.Drawing.Point(84, 268)
        Me.btPicA.Name = "btPicA"
        Me.btPicA.Size = New System.Drawing.Size(96, 33)
        Me.btPicA.TabIndex = 7
        Me.btPicA.Text = "Load Picture A"
        Me.btPicA.UseVisualStyleBackColor = True
        '
        'picA
        '
        Me.picA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picA.Location = New System.Drawing.Point(12, 12)
        Me.picA.Name = "picA"
        Me.picA.Size = New System.Drawing.Size(250, 250)
        Me.picA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picA.TabIndex = 6
        Me.picA.TabStop = False
        '
        'frmPicDiff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 313)
        Me.Controls.Add(Me.picDiff)
        Me.Controls.Add(Me.picB)
        Me.Controls.Add(Me.btDiff)
        Me.Controls.Add(Me.btPicB)
        Me.Controls.Add(Me.btPicA)
        Me.Controls.Add(Me.picA)
        Me.Name = "frmPicDiff"
        Me.Text = "frmDiffImg"
        CType(Me.picDiff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picDiff As System.Windows.Forms.PictureBox
    Friend WithEvents picB As System.Windows.Forms.PictureBox
    Friend WithEvents btDiff As System.Windows.Forms.Button
    Friend WithEvents btPicB As System.Windows.Forms.Button
    Friend WithEvents btPicA As System.Windows.Forms.Button
    Friend WithEvents picA As System.Windows.Forms.PictureBox
End Class

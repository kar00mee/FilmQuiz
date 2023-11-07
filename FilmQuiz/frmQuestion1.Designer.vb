<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuestion1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestion1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnAnswer1 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer2 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer3 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProgressBarQ1 = New System.Windows.Forms.ProgressBar()
        Me.trmQuestion1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 127)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(231, 278)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(663, 380)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(125, 58)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(40, 76)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(572, 25)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "In what year was the first Harry Potter film made ?"
        '
        'btnAnswer1
        '
        Me.btnAnswer1.AutoSize = True
        Me.btnAnswer1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer1.Location = New System.Drawing.Point(17, 34)
        Me.btnAnswer1.Name = "btnAnswer1"
        Me.btnAnswer1.Size = New System.Drawing.Size(83, 33)
        Me.btnAnswer1.TabIndex = 3
        Me.btnAnswer1.TabStop = True
        Me.btnAnswer1.Text = "2000"
        Me.btnAnswer1.UseVisualStyleBackColor = True
        '
        'btnAnswer2
        '
        Me.btnAnswer2.AutoSize = True
        Me.btnAnswer2.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer2.Location = New System.Drawing.Point(17, 67)
        Me.btnAnswer2.Name = "btnAnswer2"
        Me.btnAnswer2.Size = New System.Drawing.Size(83, 33)
        Me.btnAnswer2.TabIndex = 4
        Me.btnAnswer2.TabStop = True
        Me.btnAnswer2.Text = "2001"
        Me.btnAnswer2.UseVisualStyleBackColor = True
        '
        'btnAnswer3
        '
        Me.btnAnswer3.AutoSize = True
        Me.btnAnswer3.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer3.Location = New System.Drawing.Point(17, 100)
        Me.btnAnswer3.Name = "btnAnswer3"
        Me.btnAnswer3.Size = New System.Drawing.Size(83, 33)
        Me.btnAnswer3.TabIndex = 5
        Me.btnAnswer3.TabStop = True
        Me.btnAnswer3.Text = "2002"
        Me.btnAnswer3.UseVisualStyleBackColor = True
        '
        'btnAnswer4
        '
        Me.btnAnswer4.AutoSize = True
        Me.btnAnswer4.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer4.Location = New System.Drawing.Point(17, 139)
        Me.btnAnswer4.Name = "btnAnswer4"
        Me.btnAnswer4.Size = New System.Drawing.Size(83, 33)
        Me.btnAnswer4.TabIndex = 6
        Me.btnAnswer4.TabStop = True
        Me.btnAnswer4.Text = "2003"
        Me.btnAnswer4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAnswer1)
        Me.GroupBox1.Controls.Add(Me.btnAnswer4)
        Me.GroupBox1.Controls.Add(Me.btnAnswer2)
        Me.GroupBox1.Controls.Add(Me.btnAnswer3)
        Me.GroupBox1.Location = New System.Drawing.Point(301, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(122, 209)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'ProgressBarQ1
        '
        Me.ProgressBarQ1.Location = New System.Drawing.Point(305, 393)
        Me.ProgressBarQ1.Name = "ProgressBarQ1"
        Me.ProgressBarQ1.Size = New System.Drawing.Size(195, 23)
        Me.ProgressBarQ1.TabIndex = 8
        '
        'trmQuestion1
        '
        Me.trmQuestion1.Interval = 1000
        '
        'frmQuestion1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ProgressBarQ1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmQuestion1"
        Me.Text = "frmQuestion1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNext As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnAnswer1 As RadioButton
    Friend WithEvents btnAnswer2 As RadioButton
    Friend WithEvents btnAnswer3 As RadioButton
    Friend WithEvents btnAnswer4 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ProgressBarQ1 As ProgressBar
    Friend WithEvents trmQuestion1 As Timer
End Class

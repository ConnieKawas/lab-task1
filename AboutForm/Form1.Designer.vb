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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Btnversion = New System.Windows.Forms.Label()
        Me.Btncalculator = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnShow = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btnexit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btnversion
        '
        Me.Btnversion.AutoSize = True
        Me.Btnversion.Font = New System.Drawing.Font("Modern No. 20", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnversion.Location = New System.Drawing.Point(12, 280)
        Me.Btnversion.Name = "Btnversion"
        Me.Btnversion.Size = New System.Drawing.Size(106, 22)
        Me.Btnversion.TabIndex = 0
        Me.Btnversion.Text = "Version  1.0"
        Me.Btnversion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btncalculator
        '
        Me.Btncalculator.AutoSize = True
        Me.Btncalculator.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncalculator.Location = New System.Drawing.Point(7, 9)
        Me.Btncalculator.Name = "Btncalculator"
        Me.Btncalculator.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Btncalculator.Size = New System.Drawing.Size(214, 32)
        Me.Btncalculator.TabIndex = 2
        Me.Btncalculator.Text = "CALCULATOR"
        Me.Btncalculator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 43)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Click"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnShow
        '
        Me.BtnShow.Location = New System.Drawing.Point(7, 354)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(121, 38)
        Me.BtnShow.TabIndex = 5
        Me.BtnShow.Text = "Show"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(36, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 223)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Btnexit
        '
        Me.Btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btnexit.Location = New System.Drawing.Point(248, 399)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(91, 42)
        Me.Btnexit.TabIndex = 7
        Me.Btnexit.Text = "Exit"
        Me.Btnexit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(364, 453)
        Me.Controls.Add(Me.Btnexit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnShow)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btncalculator)
        Me.Controls.Add(Me.Btnversion)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnversion As Label
    Friend WithEvents Btncalculator As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnShow As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btnexit As Button
End Class

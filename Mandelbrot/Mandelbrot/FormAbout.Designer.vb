<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbout
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAbout))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabelWebsite = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelGithub = New System.Windows.Forms.LinkLabel()
        Me.PictureBoxBMC = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxBMC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 69)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mandelbrot"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(265, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Made by JulWas797"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(265, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(314, 192)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(264, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Release 1.3"
        '
        'LinkLabelWebsite
        '
        Me.LinkLabelWebsite.AutoSize = True
        Me.LinkLabelWebsite.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LinkLabelWebsite.Location = New System.Drawing.Point(261, 404)
        Me.LinkLabelWebsite.Name = "LinkLabelWebsite"
        Me.LinkLabelWebsite.Size = New System.Drawing.Size(193, 16)
        Me.LinkLabelWebsite.TabIndex = 7
        Me.LinkLabelWebsite.TabStop = True
        Me.LinkLabelWebsite.Text = "Take a look at my website here"
        '
        'LinkLabelGithub
        '
        Me.LinkLabelGithub.AutoSize = True
        Me.LinkLabelGithub.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LinkLabelGithub.Location = New System.Drawing.Point(261, 382)
        Me.LinkLabelGithub.Name = "LinkLabelGithub"
        Me.LinkLabelGithub.Size = New System.Drawing.Size(314, 16)
        Me.LinkLabelGithub.TabIndex = 3
        Me.LinkLabelGithub.TabStop = True
        Me.LinkLabelGithub.Text = "Check out my GitHub for more open source software"
        '
        'PictureBoxBMC
        '
        Me.PictureBoxBMC.Image = Global.Mandelbrot.My.Resources.Resources.BMCButton
        Me.PictureBoxBMC.Location = New System.Drawing.Point(264, 436)
        Me.PictureBoxBMC.Name = "PictureBoxBMC"
        Me.PictureBoxBMC.Size = New System.Drawing.Size(203, 53)
        Me.PictureBoxBMC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxBMC.TabIndex = 8
        Me.PictureBoxBMC.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 502)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FormAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 502)
        Me.Controls.Add(Me.PictureBoxBMC)
        Me.Controls.Add(Me.LinkLabelWebsite)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabelGithub)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormAbout"
        Me.Text = "About"
        CType(Me.PictureBoxBMC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabelWebsite As LinkLabel
    Friend WithEvents LinkLabelGithub As LinkLabel
    Friend WithEvents PictureBoxBMC As PictureBox
End Class

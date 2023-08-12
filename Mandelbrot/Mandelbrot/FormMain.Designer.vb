<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.CheckBoxLiveRender = New System.Windows.Forms.CheckBox()
        Me.LabelYOffset = New System.Windows.Forms.Label()
        Me.SelectorYOffset = New System.Windows.Forms.NumericUpDown()
        Me.LabelXOffset = New System.Windows.Forms.Label()
        Me.SelectorXOffset = New System.Windows.Forms.NumericUpDown()
        Me.ButtonZoomOut = New System.Windows.Forms.Button()
        Me.ButtonZoomIn = New System.Windows.Forms.Button()
        Me.ButtonSaveImage = New System.Windows.Forms.Button()
        Me.LabelHeight = New System.Windows.Forms.Label()
        Me.SelectorHeight = New System.Windows.Forms.NumericUpDown()
        Me.LabelWidth = New System.Windows.Forms.Label()
        Me.SelectorWidth = New System.Windows.Forms.NumericUpDown()
        Me.CheckBoxResolution = New System.Windows.Forms.CheckBox()
        Me.LabelDepth = New System.Windows.Forms.Label()
        Me.SelectorDepth = New System.Windows.Forms.NumericUpDown()
        Me.LabelScale = New System.Windows.Forms.Label()
        Me.SelectorScale = New System.Windows.Forms.NumericUpDown()
        Me.LabelCut = New System.Windows.Forms.Label()
        Me.SelectorCut = New System.Windows.Forms.NumericUpDown()
        Me.CheckBoxColor = New System.Windows.Forms.CheckBox()
        Me.ToolStripMain = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownSettings = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuTogglePanel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuResetZoom = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuSwitchFractals = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuMandelbrot = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuBurningShip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuJulia = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuTricorn = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuBuffalo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButtonAbout = New System.Windows.Forms.ToolStripButton()
        Me.PanelPictureBox = New System.Windows.Forms.Panel()
        Me.PictureBoxFractal = New System.Windows.Forms.PictureBox()
        Me.ScrollTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripMenuResetPosition = New System.Windows.Forms.ToolStripMenuItem()
        Me.SidePanel.SuspendLayout()
        CType(Me.SelectorYOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectorXOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectorHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectorWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectorDepth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectorScale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectorCut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripMain.SuspendLayout()
        Me.PanelPictureBox.SuspendLayout()
        CType(Me.PictureBoxFractal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonRefresh.Location = New System.Drawing.Point(0, 582)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(200, 47)
        Me.ButtonRefresh.TabIndex = 1
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'SidePanel
        '
        Me.SidePanel.Controls.Add(Me.CheckBoxLiveRender)
        Me.SidePanel.Controls.Add(Me.LabelYOffset)
        Me.SidePanel.Controls.Add(Me.SelectorYOffset)
        Me.SidePanel.Controls.Add(Me.LabelXOffset)
        Me.SidePanel.Controls.Add(Me.SelectorXOffset)
        Me.SidePanel.Controls.Add(Me.ButtonZoomOut)
        Me.SidePanel.Controls.Add(Me.ButtonZoomIn)
        Me.SidePanel.Controls.Add(Me.ButtonSaveImage)
        Me.SidePanel.Controls.Add(Me.LabelHeight)
        Me.SidePanel.Controls.Add(Me.SelectorHeight)
        Me.SidePanel.Controls.Add(Me.LabelWidth)
        Me.SidePanel.Controls.Add(Me.SelectorWidth)
        Me.SidePanel.Controls.Add(Me.CheckBoxResolution)
        Me.SidePanel.Controls.Add(Me.LabelDepth)
        Me.SidePanel.Controls.Add(Me.SelectorDepth)
        Me.SidePanel.Controls.Add(Me.LabelScale)
        Me.SidePanel.Controls.Add(Me.SelectorScale)
        Me.SidePanel.Controls.Add(Me.LabelCut)
        Me.SidePanel.Controls.Add(Me.SelectorCut)
        Me.SidePanel.Controls.Add(Me.CheckBoxColor)
        Me.SidePanel.Controls.Add(Me.ButtonRefresh)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.SidePanel.Location = New System.Drawing.Point(968, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(200, 629)
        Me.SidePanel.TabIndex = 2
        '
        'CheckBoxLiveRender
        '
        Me.CheckBoxLiveRender.AutoSize = True
        Me.CheckBoxLiveRender.Checked = True
        Me.CheckBoxLiveRender.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxLiveRender.Location = New System.Drawing.Point(15, 319)
        Me.CheckBoxLiveRender.Name = "CheckBoxLiveRender"
        Me.CheckBoxLiveRender.Size = New System.Drawing.Size(120, 20)
        Me.CheckBoxLiveRender.TabIndex = 24
        Me.CheckBoxLiveRender.Text = "Live Rendering"
        Me.CheckBoxLiveRender.UseVisualStyleBackColor = True
        '
        'LabelYOffset
        '
        Me.LabelYOffset.AutoSize = True
        Me.LabelYOffset.Location = New System.Drawing.Point(12, 232)
        Me.LabelYOffset.Name = "LabelYOffset"
        Me.LabelYOffset.Size = New System.Drawing.Size(53, 16)
        Me.LabelYOffset.TabIndex = 23
        Me.LabelYOffset.Text = "Y Offset"
        '
        'SelectorYOffset
        '
        Me.SelectorYOffset.DecimalPlaces = 7
        Me.SelectorYOffset.Location = New System.Drawing.Point(103, 230)
        Me.SelectorYOffset.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.SelectorYOffset.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.SelectorYOffset.Name = "SelectorYOffset"
        Me.SelectorYOffset.Size = New System.Drawing.Size(88, 22)
        Me.SelectorYOffset.TabIndex = 22
        '
        'LabelXOffset
        '
        Me.LabelXOffset.AutoSize = True
        Me.LabelXOffset.Location = New System.Drawing.Point(12, 205)
        Me.LabelXOffset.Name = "LabelXOffset"
        Me.LabelXOffset.Size = New System.Drawing.Size(52, 16)
        Me.LabelXOffset.TabIndex = 21
        Me.LabelXOffset.Text = "X Offset"
        '
        'SelectorXOffset
        '
        Me.SelectorXOffset.DecimalPlaces = 7
        Me.SelectorXOffset.Location = New System.Drawing.Point(103, 203)
        Me.SelectorXOffset.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.SelectorXOffset.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.SelectorXOffset.Name = "SelectorXOffset"
        Me.SelectorXOffset.Size = New System.Drawing.Size(88, 22)
        Me.SelectorXOffset.TabIndex = 20
        '
        'ButtonZoomOut
        '
        Me.ButtonZoomOut.Location = New System.Drawing.Point(103, 260)
        Me.ButtonZoomOut.Name = "ButtonZoomOut"
        Me.ButtonZoomOut.Size = New System.Drawing.Size(85, 23)
        Me.ButtonZoomOut.TabIndex = 18
        Me.ButtonZoomOut.Text = "Zoom Out"
        Me.ButtonZoomOut.UseVisualStyleBackColor = True
        '
        'ButtonZoomIn
        '
        Me.ButtonZoomIn.Location = New System.Drawing.Point(15, 260)
        Me.ButtonZoomIn.Name = "ButtonZoomIn"
        Me.ButtonZoomIn.Size = New System.Drawing.Size(86, 23)
        Me.ButtonZoomIn.TabIndex = 17
        Me.ButtonZoomIn.Text = "Zoom In"
        Me.ButtonZoomIn.UseVisualStyleBackColor = True
        '
        'ButtonSaveImage
        '
        Me.ButtonSaveImage.Location = New System.Drawing.Point(15, 289)
        Me.ButtonSaveImage.Name = "ButtonSaveImage"
        Me.ButtonSaveImage.Size = New System.Drawing.Size(173, 23)
        Me.ButtonSaveImage.TabIndex = 16
        Me.ButtonSaveImage.Text = "Save Image"
        Me.ButtonSaveImage.UseVisualStyleBackColor = True
        '
        'LabelHeight
        '
        Me.LabelHeight.AutoSize = True
        Me.LabelHeight.Location = New System.Drawing.Point(12, 177)
        Me.LabelHeight.Name = "LabelHeight"
        Me.LabelHeight.Size = New System.Drawing.Size(46, 16)
        Me.LabelHeight.TabIndex = 15
        Me.LabelHeight.Text = "Height"
        '
        'SelectorHeight
        '
        Me.SelectorHeight.Location = New System.Drawing.Point(123, 175)
        Me.SelectorHeight.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.SelectorHeight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SelectorHeight.Name = "SelectorHeight"
        Me.SelectorHeight.Size = New System.Drawing.Size(68, 22)
        Me.SelectorHeight.TabIndex = 14
        Me.SelectorHeight.Value = New Decimal(New Integer() {256, 0, 0, 0})
        '
        'LabelWidth
        '
        Me.LabelWidth.AutoSize = True
        Me.LabelWidth.Location = New System.Drawing.Point(12, 150)
        Me.LabelWidth.Name = "LabelWidth"
        Me.LabelWidth.Size = New System.Drawing.Size(41, 16)
        Me.LabelWidth.TabIndex = 13
        Me.LabelWidth.Text = "Width"
        '
        'SelectorWidth
        '
        Me.SelectorWidth.Location = New System.Drawing.Point(123, 148)
        Me.SelectorWidth.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.SelectorWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SelectorWidth.Name = "SelectorWidth"
        Me.SelectorWidth.Size = New System.Drawing.Size(68, 22)
        Me.SelectorWidth.TabIndex = 12
        Me.SelectorWidth.Value = New Decimal(New Integer() {256, 0, 0, 0})
        '
        'CheckBoxResolution
        '
        Me.CheckBoxResolution.AutoSize = True
        Me.CheckBoxResolution.Location = New System.Drawing.Point(15, 123)
        Me.CheckBoxResolution.Name = "CheckBoxResolution"
        Me.CheckBoxResolution.Size = New System.Drawing.Size(141, 20)
        Me.CheckBoxResolution.TabIndex = 11
        Me.CheckBoxResolution.Text = "Custom Resolution"
        Me.CheckBoxResolution.UseVisualStyleBackColor = True
        '
        'LabelDepth
        '
        Me.LabelDepth.AutoSize = True
        Me.LabelDepth.Location = New System.Drawing.Point(12, 17)
        Me.LabelDepth.Name = "LabelDepth"
        Me.LabelDepth.Size = New System.Drawing.Size(43, 16)
        Me.LabelDepth.TabIndex = 10
        Me.LabelDepth.Text = "Depth"
        '
        'SelectorDepth
        '
        Me.SelectorDepth.Location = New System.Drawing.Point(123, 15)
        Me.SelectorDepth.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.SelectorDepth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SelectorDepth.Name = "SelectorDepth"
        Me.SelectorDepth.Size = New System.Drawing.Size(68, 22)
        Me.SelectorDepth.TabIndex = 9
        Me.SelectorDepth.Value = New Decimal(New Integer() {256, 0, 0, 0})
        '
        'LabelScale
        '
        Me.LabelScale.AutoSize = True
        Me.LabelScale.Location = New System.Drawing.Point(12, 71)
        Me.LabelScale.Name = "LabelScale"
        Me.LabelScale.Size = New System.Drawing.Size(97, 16)
        Me.LabelScale.TabIndex = 8
        Me.LabelScale.Text = "Scale per point"
        '
        'SelectorScale
        '
        Me.SelectorScale.Location = New System.Drawing.Point(123, 69)
        Me.SelectorScale.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.SelectorScale.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SelectorScale.Name = "SelectorScale"
        Me.SelectorScale.Size = New System.Drawing.Size(68, 22)
        Me.SelectorScale.TabIndex = 7
        Me.SelectorScale.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LabelCut
        '
        Me.LabelCut.AutoSize = True
        Me.LabelCut.BackColor = System.Drawing.SystemColors.Control
        Me.LabelCut.Location = New System.Drawing.Point(12, 44)
        Me.LabelCut.Name = "LabelCut"
        Me.LabelCut.Size = New System.Drawing.Size(63, 16)
        Me.LabelCut.TabIndex = 6
        Me.LabelCut.Text = "Cut Layer"
        '
        'SelectorCut
        '
        Me.SelectorCut.Location = New System.Drawing.Point(123, 42)
        Me.SelectorCut.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.SelectorCut.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SelectorCut.Name = "SelectorCut"
        Me.SelectorCut.Size = New System.Drawing.Size(68, 22)
        Me.SelectorCut.TabIndex = 5
        Me.SelectorCut.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CheckBoxColor
        '
        Me.CheckBoxColor.AutoSize = True
        Me.CheckBoxColor.Location = New System.Drawing.Point(15, 97)
        Me.CheckBoxColor.Name = "CheckBoxColor"
        Me.CheckBoxColor.Size = New System.Drawing.Size(86, 20)
        Me.CheckBoxColor.TabIndex = 4
        Me.CheckBoxColor.Text = "Multicolor"
        Me.CheckBoxColor.UseVisualStyleBackColor = True
        '
        'ToolStripMain
        '
        Me.ToolStripMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownSettings, Me.ToolStripButtonAbout})
        Me.ToolStripMain.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripMain.Name = "ToolStripMain"
        Me.ToolStripMain.Size = New System.Drawing.Size(968, 27)
        Me.ToolStripMain.TabIndex = 3
        Me.ToolStripMain.Text = "ToolStrip1"
        '
        'ToolStripDropDownSettings
        '
        Me.ToolStripDropDownSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuTogglePanel, Me.ToolStripMenuResetZoom, Me.ToolStripMenuResetPosition, Me.ToolStripMenuSwitchFractals})
        Me.ToolStripDropDownSettings.Image = Global.Mandelbrot.My.Resources.Resources.HammerIcon
        Me.ToolStripDropDownSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownSettings.Name = "ToolStripDropDownSettings"
        Me.ToolStripDropDownSettings.Size = New System.Drawing.Size(96, 24)
        Me.ToolStripDropDownSettings.Text = "Settings"
        '
        'ToolStripMenuTogglePanel
        '
        Me.ToolStripMenuTogglePanel.Name = "ToolStripMenuTogglePanel"
        Me.ToolStripMenuTogglePanel.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuTogglePanel.Text = "Toggle Panel"
        '
        'ToolStripMenuResetZoom
        '
        Me.ToolStripMenuResetZoom.Name = "ToolStripMenuResetZoom"
        Me.ToolStripMenuResetZoom.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuResetZoom.Text = "Reset Zoom"
        '
        'ToolStripMenuSwitchFractals
        '
        Me.ToolStripMenuSwitchFractals.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuMandelbrot, Me.ToolStripMenuBurningShip, Me.ToolStripMenuJulia, Me.ToolStripMenuTricorn, Me.ToolStripMenuBuffalo})
        Me.ToolStripMenuSwitchFractals.Name = "ToolStripMenuSwitchFractals"
        Me.ToolStripMenuSwitchFractals.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuSwitchFractals.Text = "Switch Fractal "
        '
        'ToolStripMenuMandelbrot
        '
        Me.ToolStripMenuMandelbrot.Name = "ToolStripMenuMandelbrot"
        Me.ToolStripMenuMandelbrot.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuMandelbrot.Text = "Mandelbrot"
        '
        'ToolStripMenuBurningShip
        '
        Me.ToolStripMenuBurningShip.Name = "ToolStripMenuBurningShip"
        Me.ToolStripMenuBurningShip.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuBurningShip.Text = "Burning ship"
        '
        'ToolStripMenuJulia
        '
        Me.ToolStripMenuJulia.Name = "ToolStripMenuJulia"
        Me.ToolStripMenuJulia.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuJulia.Text = "Julia"
        '
        'ToolStripMenuTricorn
        '
        Me.ToolStripMenuTricorn.Name = "ToolStripMenuTricorn"
        Me.ToolStripMenuTricorn.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuTricorn.Text = "Tricorn"
        '
        'ToolStripMenuBuffalo
        '
        Me.ToolStripMenuBuffalo.Name = "ToolStripMenuBuffalo"
        Me.ToolStripMenuBuffalo.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuBuffalo.Text = "Buffalo"
        '
        'ToolStripButtonAbout
        '
        Me.ToolStripButtonAbout.Image = Global.Mandelbrot.My.Resources.Resources.HelpIcon
        Me.ToolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAbout.Name = "ToolStripButtonAbout"
        Me.ToolStripButtonAbout.Size = New System.Drawing.Size(74, 24)
        Me.ToolStripButtonAbout.Text = "About"
        '
        'PanelPictureBox
        '
        Me.PanelPictureBox.Controls.Add(Me.PictureBoxFractal)
        Me.PanelPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPictureBox.Location = New System.Drawing.Point(0, 27)
        Me.PanelPictureBox.Name = "PanelPictureBox"
        Me.PanelPictureBox.Size = New System.Drawing.Size(968, 602)
        Me.PanelPictureBox.TabIndex = 4
        '
        'PictureBoxFractal
        '
        Me.PictureBoxFractal.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBoxFractal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxFractal.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxFractal.Name = "PictureBoxFractal"
        Me.PictureBoxFractal.Size = New System.Drawing.Size(968, 602)
        Me.PictureBoxFractal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxFractal.TabIndex = 0
        Me.PictureBoxFractal.TabStop = False
        '
        'ScrollTimer
        '
        '
        'ToolStripMenuResetPosition
        '
        Me.ToolStripMenuResetPosition.Name = "ToolStripMenuResetPosition"
        Me.ToolStripMenuResetPosition.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuResetPosition.Text = "Reset Position"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 629)
        Me.Controls.Add(Me.PanelPictureBox)
        Me.Controls.Add(Me.ToolStripMain)
        Me.Controls.Add(Me.SidePanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.Text = "Mandelbrot"
        Me.SidePanel.ResumeLayout(False)
        Me.SidePanel.PerformLayout()
        CType(Me.SelectorYOffset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectorXOffset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectorHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectorWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectorDepth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectorScale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectorCut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripMain.ResumeLayout(False)
        Me.ToolStripMain.PerformLayout()
        Me.PanelPictureBox.ResumeLayout(False)
        CType(Me.PictureBoxFractal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxFractal As PictureBox
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents SidePanel As Panel
    Friend WithEvents CheckBoxColor As CheckBox
    Friend WithEvents LabelScale As Label
    Friend WithEvents SelectorScale As NumericUpDown
    Friend WithEvents LabelCut As Label
    Friend WithEvents SelectorCut As NumericUpDown
    Friend WithEvents LabelDepth As Label
    Friend WithEvents SelectorDepth As NumericUpDown
    Friend WithEvents LabelHeight As Label
    Friend WithEvents SelectorHeight As NumericUpDown
    Friend WithEvents LabelWidth As Label
    Friend WithEvents SelectorWidth As NumericUpDown
    Friend WithEvents CheckBoxResolution As CheckBox
    Friend WithEvents ButtonSaveImage As Button
    Friend WithEvents ButtonZoomOut As Button
    Friend WithEvents ButtonZoomIn As Button
    Friend WithEvents LabelYOffset As Label
    Friend WithEvents SelectorYOffset As NumericUpDown
    Friend WithEvents LabelXOffset As Label
    Friend WithEvents SelectorXOffset As NumericUpDown
    Friend WithEvents ToolStripMain As ToolStrip
    Friend WithEvents ToolStripDropDownSettings As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuTogglePanel As ToolStripMenuItem
    Friend WithEvents ToolStripMenuResetZoom As ToolStripMenuItem
    Friend WithEvents ToolStripMenuSwitchFractals As ToolStripMenuItem
    Friend WithEvents ToolStripMenuMandelbrot As ToolStripMenuItem
    Friend WithEvents ToolStripMenuBurningShip As ToolStripMenuItem
    Friend WithEvents ToolStripButtonAbout As ToolStripButton
    Friend WithEvents PanelPictureBox As Panel
    Friend WithEvents ToolStripMenuJulia As ToolStripMenuItem
    Friend WithEvents ToolStripMenuTricorn As ToolStripMenuItem
    Friend WithEvents ToolStripMenuBuffalo As ToolStripMenuItem
    Friend WithEvents CheckBoxLiveRender As CheckBox
    Friend WithEvents ScrollTimer As Timer
    Friend WithEvents ToolStripMenuResetPosition As ToolStripMenuItem
End Class

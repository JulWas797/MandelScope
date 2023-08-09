Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Public Class FormMain

    Private scaleFactor As Double = 2
    Private ptX As Double = 0
    Private ptY As Double = 0
    Private currentAlg As IAlgorithm = New Mandelbrot
    Private clicked As Boolean = False
    Private scrollRendered As Boolean = True

    Private Sub RenderImage()
        Dim pixelScale As Double = SelectorScale.Value
        DrawCanvas(pixelScale, SelectorXOffset.Value, SelectorYOffset.Value)
    End Sub

    Private Sub DrawCanvas(ByVal pixelScale As Double, ByVal xOff As Double, ByVal yOff As Double)
        Dim invPixelScale As Double = 1 / pixelScale
        Dim canvas As New Bitmap(Scaler.FloorAndCast(GetWidth() * invPixelScale), Scaler.FloorAndCast(GetHeight() * invPixelScale))
        Dim rect As New Rectangle(0, 0, canvas.Width, canvas.Height)
        Dim bmpData As BitmapData = canvas.LockBits(rect, ImageLockMode.WriteOnly, canvas.PixelFormat)
        Dim bytesPerPixel As Integer = Bitmap.GetPixelFormatSize(canvas.PixelFormat) / 8
        Dim stride As Integer = bmpData.Stride
        Dim buffer(bmpData.Stride * bmpData.Height - 1) As Byte
        For y As Integer = 0 To canvas.Height - 1
            Parallel.For(0,
                         canvas.Width - 1,
                         Sub(x)
                             Dim sCoord As Types.Pixel = Scaler.ScalePixel(x, y, GetWidth, GetHeight, scaleFactor, pixelScale)
                             Dim scaledX As Double = sCoord.x + xOff
                             Dim scaledY As Double = sCoord.y + yOff
                             Dim iter As Integer = currentAlg.IterationCnt(scaledX, scaledY, SelectorDepth.Value)
                             Dim colorCode As Integer
                             If CheckBoxColor.Checked Then
                                 colorCode = iter Mod 510
                             Else
                                 Dim colorScaleRatio As Double = iter / SelectorDepth.Value
                                 colorCode = colorScaleRatio * 255
                             End If
                             If iter < SelectorCut.Value Then
                                 colorCode = 0
                             End If
                             Dim pixelOffset As Integer = y * stride + x * bytesPerPixel
                             Dim currentColor As Color
                             If iter = SelectorDepth.Value Then
                                 currentColor = Color.Black
                             Else
                                 currentColor = If(CheckBoxColor.Checked, Color.FromArgb(Scaler.GradientAround(colorCode Mod 100, 50), Scaler.GradientAround(colorCode Mod 100, 50), Scaler.GradientAround(colorCode, 255)), Color.FromArgb(colorCode, colorCode, colorCode))
                             End If
                             buffer(pixelOffset) = currentColor.R
                             buffer(pixelOffset + 1) = currentColor.G
                             buffer(pixelOffset + 2) = currentColor.B
                             buffer(pixelOffset + 3) = 255
                         End Sub)
        Next
        Marshal.Copy(buffer, 0, bmpData.Scan0, buffer.Length)
        canvas.UnlockBits(bmpData)
        If PictureBoxFractal.Image IsNot Nothing Then
            PictureBoxFractal.Image.Dispose()
        End If
        PictureBoxFractal.Image = canvas
        PictureBoxFractal.Refresh()
        bmpData = Nothing
        buffer = Nothing
        Marshal.CleanupUnusedObjectsInCurrentContext()
    End Sub

    Private Sub FormMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        RenderImage()
    End Sub

    Private Function GetWidth() As Integer
        Return If(CheckBoxResolution.Checked, SelectorWidth.Value, PictureBoxFractal.Width)
    End Function

    Private Function GetHeight() As Integer
        Return If(CheckBoxResolution.Checked, SelectorHeight.Value, PictureBoxFractal.Height)
    End Function

    Private Sub ButtonSaveImage_Click(sender As Object, e As EventArgs) Handles ButtonSaveImage.Click
        Dim saveDialog As New SaveFileDialog()
        With saveDialog ' Visual Basic "With" loops are best things ever designed!
            .Filter = "PNG Files (*.png)|*.png"
            .DefaultExt = "png"
            .AddExtension = True
        End With
        Try
            If saveDialog.ShowDialog() = DialogResult.OK Then
                PictureBoxFractal.Image.Save(saveDialog.FileName, ImageFormat.Png)
            End If
        Finally
            saveDialog.Dispose()
        End Try
    End Sub

    Private Sub ButtonZoomIn_Click(sender As Object, e As EventArgs) Handles ButtonZoomIn.Click
        scaleFactor /= 2
        RenderImage()
    End Sub

    Private Sub ButtonZoomOut_Click(sender As Object, e As EventArgs) Handles ButtonZoomOut.Click
        scaleFactor *= 2
        RenderImage()
    End Sub

    Private Sub PictureBoxFractal_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBoxFractal.MouseDown
        clicked = True
        ptX = e.X
        ptY = e.Y
    End Sub

    Private Sub PictureBoxFractal_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBoxFractal.MouseUp
        clicked = False
        SelectorXOffset.Value = newXOffset(e)
        SelectorYOffset.Value = newYOffset(e)
        RenderImage()
    End Sub

    Private Function newXOffset(ByRef e As MouseEventArgs) As Double
        Dim deltaX As Integer = ptX - e.X
        Return SelectorXOffset.Value + (2 * deltaX / PictureBoxFractal.Width) * scaleFactor
    End Function

    Private Function newYOffset(ByRef e As MouseEventArgs) As Double
        Dim deltaY As Integer = ptY - e.Y
        Return SelectorYOffset.Value + (2 * deltaY / PictureBoxFractal.Height) * scaleFactor
    End Function

    Private Sub ToolStripTogglePanel_Click(sender As Object, e As EventArgs) Handles ToolStripMenuTogglePanel.Click
        SidePanel.Visible = Not SidePanel.Visible
    End Sub

    Private Sub ToolStripButtonAbout_Click(sender As Object, e As EventArgs) Handles ToolStripButtonAbout.Click
        My.Forms.FormAbout.Show()
    End Sub

    Private Sub ToolStripMenuMandelbrot_Click(sender As Object, e As EventArgs) Handles ToolStripMenuMandelbrot.Click
        SetAlgorithm(New Mandelbrot)
    End Sub

    Private Sub ToolStripMenuBurningShip_Click(sender As Object, e As EventArgs) Handles ToolStripMenuBurningShip.Click
        SetAlgorithm(New BurningShip)
    End Sub

    Private Sub ToolStripMenuJulia_Click(sender As Object, e As EventArgs) Handles ToolStripMenuJulia.Click
        SetAlgorithm(New Julia)
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        RenderImage()
    End Sub

    Private Sub ToolStripMenuResetZoom_Click(sender As Object, e As EventArgs) Handles ToolStripMenuResetZoom.Click
        scaleFactor = 2
        RenderImage()
    End Sub

    Private Sub SetAlgorithm(ByRef algorithm As IAlgorithm)
        currentAlg = algorithm
        RenderImage()
    End Sub

    Private Sub ToolStripMenuTricorn_Click(sender As Object, e As EventArgs) Handles ToolStripMenuTricorn.Click
        SetAlgorithm(New Tricorn)
    End Sub

    Private Sub ToolStripMenuBuffalo_Click(sender As Object, e As EventArgs) Handles ToolStripMenuBuffalo.Click
        SetAlgorithm(New Buffalo)
    End Sub

    Private Sub PictureBoxFractal_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBoxFractal.MouseMove
        Dim newXOff As Double = newXOffset(e)
        Dim newYOff As Double = newYOffset(e)
        If clicked And CheckBoxLiveRender.Checked Then
            DrawIfChecked(newXOff, newYOff)
        End If
    End Sub

    Private Sub PictureBoxFractal_MouseWheel(sender As Object, e As MouseEventArgs) Handles PictureBoxFractal.MouseWheel
        Dim chDelta As Double = e.Delta / 1000
        If e.Delta > 0 Then
            scaleFactor *= 1 + chDelta
        Else
            scaleFactor /= 1 - chDelta
        End If
        DrawIfChecked(SelectorXOffset.Value, SelectorYOffset.Value)
        ScrollTimer.Stop()
        ScrollTimer.Start()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ScrollTimer.Stop()
    End Sub

    Private Sub ScrollTimer_Tick(sender As Object, e As EventArgs) Handles ScrollTimer.Tick
        RenderImage()
        ScrollTimer.Stop()
    End Sub

    Private Sub DrawIfChecked(ByRef x As Double, ByRef y As Double)
        If CheckBoxLiveRender.Checked Then
            DrawCanvas(5, x, y)
        End If
    End Sub
End Class

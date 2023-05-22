Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Public Class FormMain

    Private scaleFactor As Double = 2
    Private ptX As Double = 0
    Private ptY As Double = 0
    Private currentAlg As IAlgorithm = New Mandelbrot

    Private Sub RenderImage()
        Dim pixelScale As Double = SelectorScale.Value
        Dim invPixelScale As Double = 1 / pixelScale
        Dim canvas As New Bitmap(Scaler.FloorAndCast(GetWidth() * invPixelScale), Scaler.FloorAndCast(GetHeight() * invPixelScale))
        Dim rect As New Rectangle(0, 0, canvas.Width, canvas.Height)
        Dim bmpData As BitmapData = canvas.LockBits(rect, ImageLockMode.WriteOnly, canvas.PixelFormat)
        Dim bytesPerPixel As Integer = Bitmap.GetPixelFormatSize(canvas.PixelFormat) / 8
        Dim stride As Integer = bmpData.Stride
        Dim buffer(stride * bmpData.Height - 1) As Byte
        For y As Integer = 0 To canvas.Height - 1
            Parallel.For(0,
                         canvas.Width - 1,
                         Sub(x)
                             Dim sCoord As Types.Pixel = Scaler.ScalePixel(x, y, GetWidth, GetHeight, scaleFactor, pixelScale)
                             Dim scaledX As Double = sCoord.x + SelectorXOffset.Value
                             Dim scaledY As Double = sCoord.y + SelectorYOffset.Value
                             Dim iter As Integer = currentAlg.IterationCnt(scaledX, scaledY, SelectorDepth.Value)
                             Dim colorScaleRatio As Double = iter / SelectorDepth.Value
                             Dim colorCode As Integer = If(CheckBoxColor.Checked, colorScaleRatio * 6777216 + 10000000, colorScaleRatio * 255)
                             If iter < SelectorCut.Value Then
                                 colorCode = 0
                             End If
                             Dim pixelOffset As Integer = y * stride + x * bytesPerPixel
                             Dim currentColor As Color = If(CheckBoxColor.Checked, ColorTranslator.FromWin32(colorCode), Color.FromArgb(colorCode, colorCode, colorCode))
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
        ptX = e.X
        ptY = e.Y
    End Sub

    Private Sub PictureBoxFractal_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBoxFractal.MouseUp
        Dim deltaX As Integer = ptX - e.X
        Dim deltaY As Integer = ptY - e.Y
        SelectorXOffset.Value += (deltaX / PictureBoxFractal.Width) * scaleFactor
        SelectorYOffset.Value += (deltaY / PictureBoxFractal.Height) * scaleFactor
        RenderImage()
    End Sub

    Private Sub ToolStripTogglePanel_Click(sender As Object, e As EventArgs) Handles ToolStripMenuTogglePanel.Click
        SidePanel.Visible = Not SidePanel.Visible
    End Sub

    Private Sub ToolStripButtonAbout_Click(sender As Object, e As EventArgs) Handles ToolStripButtonAbout.Click
        My.Forms.FormAbout.Show()
    End Sub

    Private Sub ToolStripMenuMandelbrot_Click(sender As Object, e As EventArgs) Handles ToolStripMenuMandelbrot.Click
        currentAlg = New Mandelbrot
        RenderImage()
    End Sub

    Private Sub ToolStripMenuBurningShip_Click(sender As Object, e As EventArgs) Handles ToolStripMenuBurningShip.Click
        currentAlg = New BurningShip
        RenderImage()
    End Sub

    Private Sub ToolStripMenuJulia_Click(sender As Object, e As EventArgs) Handles ToolStripMenuJulia.Click
        currentAlg = New Julia
        RenderImage()
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        RenderImage()
    End Sub

    Private Sub ToolStripMenuResetZoom_Click(sender As Object, e As EventArgs) Handles ToolStripMenuResetZoom.Click
        scaleFactor = 2
        RenderImage()
    End Sub
End Class

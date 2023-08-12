Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Public Class FormMain

    Private scaleFactor As Double = 2
    Private ptX As Double = 0
    Private ptY As Double = 0
    Private currentAlg As IAlgorithm = New Mandelbrot
    Private clicked As Boolean = False, scrollRendered As Boolean = True

    Private Sub RenderImage()
        Dim pixelScale As Double = SelectorScale.Value
        DrawCanvas(pixelScale, SelectorXOffset.Value, SelectorYOffset.Value)
    End Sub

    Private Sub DrawCanvas(pixelScale As Double, xOff As Double, yOff As Double)
        Dim invPixelScale As Double = 1 / pixelScale
        Dim width = Scaler.FloorAndCast(GetWidth() * invPixelScale), height = Scaler.FloorAndCast(GetHeight() * invPixelScale)
        Dim canvas As New Bitmap(width, height)
        Dim rect As New Rectangle(0, 0, width, height)
        Dim format = canvas.PixelFormat
        Dim bmpData = canvas.LockBits(rect, ImageLockMode.WriteOnly, format)
        Dim bytesPerPixel As Integer = Bitmap.GetPixelFormatSize(format) / 8
        Dim stride = bmpData.Stride
        Dim buffer(stride * height - 1) As Byte
        For y = 0 To height - 1
            Parallel.For(0,
                         width - 1,
                         Sub(x)

                             Dim sCoord = Scaler.ScalePixel(x, y, GetWidth, GetHeight, scaleFactor, pixelScale)
                             Dim scaledX = sCoord.x + xOff, scaledY = sCoord.y + yOff
                             Dim iter = currentAlg.IterationCnt(scaledX, scaledY, SelectorDepth.Value)
                             Dim pixelOffset = y * stride + x * bytesPerPixel
                             Dim R = 0, G = 0, B = 0
                             Dim colorCode = 0

                             If iter >= SelectorCut.Value Then
                                 If CheckBoxColor.Checked Then
                                     colorCode = iter Mod 510
                                 Else
                                     Dim colorScaleRatio As Double = iter / SelectorDepth.Value
                                     colorCode = colorScaleRatio * 255
                                 End If
                             End If

                             If Not iter = SelectorDepth.Value Then
                                 If CheckBoxColor.Checked Then
                                     R = Scaler.GradientAround(colorCode Mod 100, 50)
                                     B = Scaler.GradientAround(colorCode, 255)
                                 Else
                                     R = colorCode
                                     B = R
                                 End If
                                 G = R
                             End If

                             buffer(pixelOffset) = R
                             buffer(pixelOffset + 1) = G
                             buffer(pixelOffset + 2) = B
                             buffer(pixelOffset + 3) = 255

                         End Sub)
        Next
        Marshal.Copy(buffer, 0, bmpData.Scan0, buffer.Length)
        canvas.UnlockBits(bmpData)
        With PictureBoxFractal
            .Image?.Dispose()
            .Image = canvas
            .Refresh()
        End With
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
        Dim newXOff = newXOffset(e)
        Dim newYOff = newYOffset(e)
        If clicked And CheckBoxLiveRender.Checked Then
            DrawIfChecked(newXOff, newYOff)
        End If
    End Sub

    Private Sub PictureBoxFractal_MouseWheel(sender As Object, e As MouseEventArgs) Handles PictureBoxFractal.MouseWheel
        Dim chDelta = e.Delta / 1000
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

    Private Sub ToolStripMenuResetPosition_Click(sender As Object, e As EventArgs) Handles ToolStripMenuResetPosition.Click
        SelectorXOffset.Value = 0
        SelectorYOffset.Value = 0
        ToolStripMenuResetZoom_Click(sender, e)
    End Sub

    Private Sub DrawIfChecked(ByRef x As Double, ByRef y As Double)
        If CheckBoxLiveRender.Checked Then
            DrawCanvas(5, x, y)
        End If
    End Sub
End Class

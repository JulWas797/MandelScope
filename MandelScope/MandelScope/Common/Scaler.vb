Public Class Scaler
    Public Shared Function ScalePixel(ByRef x As Integer, ByRef y As Integer, ByRef width As Integer, ByRef height As Integer, ByRef scaleFactor As Double, ByRef pixelsScaleFactor As Integer) As Types.Pixel
        Dim tPix As New Types.Pixel
        Dim centerX As Integer = Math.Floor(width * (1 / pixelsScaleFactor) / 2)
        Dim centerY As Integer = Math.Floor(height * (1 / pixelsScaleFactor) / 2)
        Dim ratio = scaleFactor / Math.Max(centerY, centerX)
        tPix.x = (x - centerX) * ratio
        tPix.y = (y - centerY) * ratio
        Return tPix
    End Function

    Public Shared Function FloorAndCast(ByRef x As Double) As Integer
        Return Convert.ToInt32(Math.Floor(x))
    End Function

    Public Shared Function GradientAround(ByRef value As Integer, ByRef around As Integer) As Integer
        Return If(value > around, value + 2 * (around - value), value)
    End Function
End Class

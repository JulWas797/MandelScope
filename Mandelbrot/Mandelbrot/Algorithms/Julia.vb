Public Class Julia
    Implements IAlgorithm

    Public Function IterationCnt(ByRef x As Double, ByRef y As Double, ByRef depth As Integer) As Integer Implements IAlgorithm.IterationCnt
        Dim ax As Double = x
        Dim ay As Double = y
        Dim axD As Double = 0
        Dim ayD As Double = 0
        Dim i As Integer = 0
        Do While axD + ayD <= 4 And i < depth
            axD = ax * ax
            ayD = ay * ay
            ay = 2 * ax * ay + 0.156
            ax = axD - ayD - 0.8
            i += 1
        Loop
        Return i
    End Function
End Class

Public Class Julia
    Implements IAlgorithm

    Public Function IterationCnt(ByRef x As Double, ByRef y As Double, ByRef depth As Integer) As Integer Implements IAlgorithm.IterationCnt
        Dim ax As Double = x
        Dim ay As Double = y
        Dim i As Integer = 0
        Do While (ax * ax + ay * ay <= 4) And i < depth
            Dim xTemp As Double = ax * ax - ay * ay
            ay = 2 * ax * ay + 0.156
            ax = xTemp - 0.8
            i += 1
        Loop
        Return i
    End Function
End Class

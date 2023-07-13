Public Class Tricorn
    Implements IAlgorithm
    Public Function IterationCnt(ByRef x As Double, ByRef y As Double, ByRef depth As Integer) As Integer Implements IAlgorithm.IterationCnt
        Dim ax As Double = 0
        Dim ay As Double = 0
        Dim i As Integer = 0
        Do While ax * ax + ay * ay <= 4 And i < depth
            Dim xTemp As Double = ax * ax - ay * ay + x
            ay = -2 * ax * ay + y
            ax = xTemp
            i += 1
        Loop
        Return i
    End Function
End Class

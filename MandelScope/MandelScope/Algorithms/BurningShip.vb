﻿Public Class BurningShip
    Implements IAlgorithm

    Private Function IterationCnt(ByRef x As Double, ByRef y As Double, ByRef depth As Integer) As Integer Implements IAlgorithm.IterationCnt
        Dim ax As Double = 0, ay As Double = 0
        Dim axD As Double = 0, ayD As Double = 0
        Dim i = 0
        Do While axD + ayD <= 4 And i < depth
            axD = ax * ax
            ayD = ay * ay
            ay = Math.Abs(2 * ax * ay) + y
            ax = axD - ayD + x
            i += 1
        Loop
        Return i
    End Function
End Class

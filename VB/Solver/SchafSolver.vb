Partial Module Program
    Sub SchafSolver()
        Const r As Double = 1
        Dim alpha As Double
        Const maxError As Double = 0.00001
        Const initStep As Double = 0.1
        Const maxStep = 10000
        For i = 0 To maxStep
            Dim e = Err(r, alpha)
            If (Math.Abs(e) < maxError) Then
                Exit For
            End If
            If e < 0 Then
                alpha = alpha - initStep * (1 - i / maxStep)
            Else
                alpha = alpha + initStep * (1 - i / maxStep)
            End If
        Next

        Dim l_over_r As Double = 2 * r * Math.Cos(alpha)
        Console.WriteLine($"wenn l / r gleich {l_over_r} ist, wird die Fläche gleichmäßig aufgeteilt")
    End Sub

    Private Function Err(r As Double, a As Double) As Double
        Return (Math.PI * (r ^ 2) / 2) + a * ((2 * r * Math.Cos(a)) ^ 2 - 2 * r ^ 2) - 2 * r ^ 2 * Math.Cos(a) * Math.Sin(a)
    End Function
End Module
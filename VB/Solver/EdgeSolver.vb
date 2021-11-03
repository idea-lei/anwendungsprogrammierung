Partial Module Program
    Sub EdgeSolver()
        Console.WriteLine("geben Sie die Fläche ein:")
        Dim area As Double = Double.Parse(Console.ReadLine())
        Console.WriteLine("geben Sie die Kantelänge ein:")
        Dim a As Double = Double.Parse(Console.ReadLine())

        Dim stepLength As Double = 0.1
        Const MaxStep = 10000
        Dim b As Double = 0
        Const MaxError = 0.00001

        For i = 0 To MaxStep
            Dim currentArea = b * a
            If (Math.Abs(currentArea - area) < MaxError) Then
                Exit For
            End If
            If currentArea < area Then
                b = b + stepLength * (1 - i / MaxStep)
            Else
                b = b - stepLength * (1 - i / MaxStep)
            End If
        Next i

        Console.WriteLine($"b = {b}, error = {(b * a - area) / area}")
    End Sub
End Module
Module BasicContent
    Sub Variable()
        Dim Str1 = "Hello World with variable"
        Dim Str2 As String = "another string with manual defined type"
        Dim num1 As Integer
        num1 = 1
        Console.WriteLine($"firstString: {Str1}") '$"{variable as string}"
    End Sub

    Sub Array1()
        Dim array(5) As Integer

        array(0) = 0
        array(1) = 1
        array(2) = 2
        array(3) = 3
        array(4) = 4

        For i As Integer = 0 To array.Length - 1
            Console.WriteLine(array(i))
        Next
    End Sub

    Sub Array2()
        Dim array() As Integer = {
            2, 4, 5, 6, 7, 3, 2}

        For Each i As Integer In array
            Console.WriteLine(i)
        Next
    End Sub

    Sub Array3()
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        Dim nums(,,) As Integer = {
            {{12, 2, 8}},
            {{14, 5, 2}},
            {{3, 26, 9}},
            {{4, 11, 2}}
        }

        For i = 0 To UBound(nums, 1)
            For j = 0 To UBound(nums, 2)
                For k = 0 To UBound(nums, 3)
                    Console.Write(CStr(nums(i, j, k)) + " ")
                Next k
            Next j
            Console.Write(vbCrLf)
        Next i
    End Sub
End Module

Module FlowControl
    Sub IfElse()
        Console.WriteLine($"input a integer:")
        Dim num As Integer = Console.ReadLine()
        If num > 10 Then
            Console.WriteLine(">10")
        ElseIf num < 0 Then
            Console.WriteLine("<0")
        Else
            Console.WriteLine(">=0 & <=10")
        End If
    End Sub

    Sub SelectCase()
        Console.WriteLine($"input a integer:")
        Dim num As Integer = Console.ReadLine()
        Select Case num
            Case 1
                Console.WriteLine("your input is 1")
            Case 2
                Console.WriteLine("your input is 2")
            Case Else
                Console.WriteLine("your input is neither 1 nor 2")
        End Select
    End Sub

    Sub DoWhileHeadLoop()
        Dim num = 0
        Do While num < 10   'change 10 to 0 and check the difference
            num = num + 1
            Console.Write($"{num}, ")
        Loop
        Console.Write(vbCrLf)
    End Sub

    Sub DoWhileFootLoop()
        Dim num = 0
        Do
            num = num + 1
            Console.Write($"{num}, ")
        Loop While num < 10     'change 10 to 0 and check the difference
        Console.Write(vbCrLf)
    End Sub

    Sub DoUntilLoop()
        Dim num = 0
        Do Until num > 10
            num = num + 1
            Console.Write($"{num}, ")
        Loop
        Console.Write(vbCrLf)
    End Sub

    ''' <summary>
    ''' for practice, usually only use while loop
    ''' </summary>
    Sub WhileLoop()
        Dim num As Integer = 0
        While (num < 10)
            num = num + 1
            If ((num Mod 2) = 0) Then
                Exit While  'change Exit to Continue to see the difference
            End If
            Console.Write(num.ToString() + ", ")

        End While
        Console.Write(vbCrLf)
    End Sub

    Sub ForNext()
        For num = 0 To 10
            Console.Write($"{num}, ")
        Next
        Console.Write(vbCrLf)
    End Sub

    Sub ForEach()
        Dim planets() As String = {"Mercury", "Venus",
            "Earth", "Mars", "Jupiter", "Saturn",
            "Uranus", "Neptune"}

        For Each planet As String In planets
            Console.WriteLine(planet)
        Next
    End Sub
End Module

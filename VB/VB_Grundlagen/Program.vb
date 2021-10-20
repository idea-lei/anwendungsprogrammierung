Imports System  'this is import of necessary modules

''' <summary>
''' this defines a module, or same concept as "class" in C# or other language,
''' syntax: 
'''     Module ModuleName
'''         --Content--
'''     End Module
''' </summary>
Module HauptProgram
    ''' <summary>
    ''' Sub means sub procedure
    ''' this defines a Sub, the "Main" Sub is the entry of the program, every VB project should have one and only one "Main" Sub
    ''' Sub has no Return!
    ''' syntax for other Sub definition:
    '''     Sub SubName(p1 As Type1, p2 As Type2...)
    '''         --Content--
    '''     End Sub
    ''' </summary>
    Sub Main(args As String())
        'uncomment (remove the quote symbol) to run the corresponding Subs

        Console.WriteLine("Hello World!") 'call the pre-defined Sub

        'DoWhileHeadLoop()
        'DoWhileFootLoop()
        'WhileLoop()
        'ForNext()

        Dim s1 As New Student
        With s1
            .Birthday = New Date(2000, 1, 1)
            .Major = "Maschinenbau"
            .MatNr = "1234567"
            .Name = "Alex Mustermann"
            .Sex = Sex.Male
        End With

        's1.Name = "neuer Name"      'uncomment this and see the difference

        Console.WriteLine($"{s1.Name} is {s1.Age()} years old, studing {s1.Major} with MatNr {s1.MatNr}")
    End Sub
End Module




Module OOP
    ''' <summary>
    '''Sub	                                                                                    Function
    '''A Sub performs() a task but does Not Return a value.	                                    A Function returns a value Of the tasks performed.
    '''Subs can be recalled from anywhere In the program And In multiple types.	                Functions are called by a variable.
    '''Subs cannot be used directly In spreadsheets As formulas.	                            Functions are used directly In spreadsheets As formulas.
    '''Users must insert a value In the desired cell before getting the result Of the Sub.	    Functions can be used To perform repetitive tasks And Return a value.
    '''Excel users can execute a VBA Sub.                                                       Excel users cannot execute VBA functions.
    ''' </summary>
    Public Class Student
        Public Name As String
        Public MatNr As String
        Public Major As String
        Public Birthday As Date
        Public Sex As Sex

        Public Function Age() As Integer
            Return Date.Today.Year - Birthday.Year
        End Function
    End Class

    Public Enum Sex
        Male
        Female
        Other
    End Enum
End Module

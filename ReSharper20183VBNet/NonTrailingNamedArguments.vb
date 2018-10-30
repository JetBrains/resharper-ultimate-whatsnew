Public Class NonTrailingNamedArguments

    Public Class Example
        Public Sub Run()
            'In older VB versions, this would error because we are mixing positional and non-positional (named) arguments
            'When switching to VB 15.5, this is supported making it more readable (which argument is set to Nothing? email!)
            Dim person As New Person("Maarten", "Balliauw", email:=Nothing, 35)
        End Sub
    End Class

    Public Class Person
        Private ReadOnly _firstName As String
        Private ReadOnly _lastName As String
        Private ReadOnly _email As String
        Private ReadOnly _age As Integer

        Public Sub New(firstName As String, lastName As String, email As String, age As Integer)
            _firstName = firstName
            _lastName = lastName
            _email = email
            _age = age
        End Sub
    End Class

End Class
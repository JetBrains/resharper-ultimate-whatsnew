Public Class StringInterpolation
    Sub ConvertStringFormat(name As String)
        Dim message = String.Format("Hello {0}", name)
        Console.WriteLine(message)
    End Sub

    Function ConvertConcatenation(forename As String, surname As String) As String
        return forename + surname
    End Function

    Function ConvertStringLiteral()
        ' Context action on string literal to convert to $"..."
        return "Hello world"
    End Function
End Class

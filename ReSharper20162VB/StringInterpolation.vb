Option Strict On

' 20162EAP4: VB string interpolation
Public Class StringInterpolation
    Sub ConvertStringFormat(name As String)
        Dim message = String.Format("Hello {0}", name)
        Console.WriteLine(message)
    End Sub

    Function ConvertConcatenation(forename As String, surname As String) As String
        ' Alt+Enter on concatenation below and "Convert concatenation to interpolation"
        Return "Hello " & forename & surname
    End Function

    Function ConvertStringLiteral() As String
        ' Context action on string literal to convert to $"..."
        Return "Hello world"
    End Function
End Class
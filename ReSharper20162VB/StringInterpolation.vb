﻿Option Strict On

Public Class StringInterpolation
    Sub ConvertStringFormat(name As String)
        Dim message = String.Format("Hello {0}", name)
        Console.WriteLine(message)
    End Sub

    Function ConvertConcatenation(forename As String, surname As String) As String
        ' Alt+Enter on concatenation below and "Convert concatenation to interpolation"
        return "Hello " & forename & surname
    End Function

    Function ConvertStringLiteral() As String
        ' Context action on string literal to convert to $"..."
        return "Hello world"
    End Function
End Class

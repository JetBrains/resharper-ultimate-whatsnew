Public Class InferredTupleElementNames
    'https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/data-types/tuples#inferred-tuple-element-names
    Public Sub Example()
        Dim firstName = "Maarten"
        Dim lastName = "Balliauw"
        Dim email = "maarten.balliauw@jetbrains.com"

        Dim person = (firstName, lastName, email)

        'In earlier VB versions, our "person" tuple would expose Item1, Item2, Item3
        'In newer VB versions, the "person" tuple will have inferred named elements
        Console.WriteLine($"E-mail for {person.firstName}: {person.lastName}")
    End Sub
End Class
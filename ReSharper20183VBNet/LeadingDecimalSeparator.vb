Public Class LeadingDecimalSeparator
    'https://docs.microsoft.com/en-us/dotnet/visual-basic/getting-started/whats-new#visual-basic-155
    Public Sub Example()
        'This syntax would not work in older VB.NET
        'Before: Dim hexNumber As Integer = &HC305_F860
        Dim hexNumber As Integer = &H_C305_F860

        'Before: Dim octNumber As Integer = &O200
        Dim octNumber As Integer = &O_200

        'Before: Dim subnet As Integer = &B11111111_1111111_11000000_00000000
        Dim subnet As Integer = &B_11111111_1111111_11000000_00000000
    End Sub
End Class
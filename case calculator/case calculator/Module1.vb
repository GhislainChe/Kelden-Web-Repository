Module Module1
    Sub Main()
        Dim num1, num2, result As Double
        Dim operation As String

        Console.Write("Enter first number: ")
        num1 = Double.Parse(Console.ReadLine())

        Console.Write("Enter second number: ")
        num2 = Double.Parse(Console.ReadLine())

        Console.Write("Enter operation (+, -, *, /): ")
        operation = Console.ReadLine()

        Select Case operation
            Case "+"
                result = num1 + num2
            Case "-"
                result = num1 - num2
            Case "*"
                result = num1 * num2
            Case "/"
                If num2 <> 0 Then
                    result = num1 / num2
                Else
                    Console.WriteLine("Error: Division by zero.")
                    Exit Sub
                End If
            Case Else
                Console.WriteLine("Invalid operation.")
                Exit Sub
        End Select

        Console.WriteLine("Result: " & result)

        Console.WriteLine("Press Enter to exit...")
        Console.ReadLine()
    End Sub
End Module



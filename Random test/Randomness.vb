Module Randomness
    Dim MyValue As Integer
    Dim currentNumber As Integer
    Dim numbers(7) As Integer

    Sub Main()

        For i = 0 To 9

            Do
                getrnd()
                Console.WriteLine(MyValue)
                Console.ReadLine()
                TwoDimensionalArary()
                Console.WriteLine(getrnd)
            Loop

            currentNumber = getrnd()
            numbers(currentNumber) += 1


        Next



    End Sub


    Sub TwoDimensionalArary()
        Dim numbers(9, 9) As Integer
        Dim temp As String

        For row = 0 To 9
            For column = 0 To 9
                numbers(row, column) = row + column
            Next
        Next

        For row = 0 To 9
            For column = 0 To 9
                temp = CStr(numbers(row, column) & " |")
                Console.Write(temp.PadLeft(6))
            Next
            Console.WriteLine()

        Next
        Console.ReadLine()
    End Sub

    Function getrnd() As Integer
        MyValue = Int((10 * Rnd()) + 1)
        Return MyValue
    End Function

End Module

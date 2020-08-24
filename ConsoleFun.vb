Option Strict On
Option Explicit On



Module ConsoleFun

    Sub Main()
        Dim userInput As String
        'Console.WriteLine("Please Type Some Text Then Press Enter...")
        'userInput = Console.ReadLine()
        'Console.WriteLine("Thanks!! You entered: " & userInput & ". Good Work!!")
        'Console.ReadLine()

        Dim firstNumber As Integer
        Dim result As Integer
        Console.WriteLine("Please Enter a Number")
        userInput = Console.ReadLine()
        firstNumber = CInt(userInput)
        'firstNumber = Console.ReadLine()
        result = 5 + firstNumber
        Console.WriteLine(result)
        Console.ReadLine()


    End Sub

End Module

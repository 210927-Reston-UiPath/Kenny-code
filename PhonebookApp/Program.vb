Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        dim repeat as Boolean = True 
        Do While repeat
            Console.WriteLine("[0] Say hello")
            Console.WriteLine("[x] Exit")
            Dim input as string = Console.Readline()
            Select Case input
                Case "0"
                    Console.WriteLine("Hello")
                Case "x"
                    Console.WriteLine("goodbye")
                    repeat = false
            End Select
        Loop
    End Sub
End Module

Class Person
    Implements IPerson
    Sub getPerson() Implements IPerson.getPerson
        dim age As Integer
            age = 25
        dim Name As string
            Name = "Jessica"
        Console.WriteLine(age)
        Console.WriteLine(Name)
    End Sub
    
End Class

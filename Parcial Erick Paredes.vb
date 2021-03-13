Module Module1
    Sub Main()
        Dim num(14) As Integer
        Dim suma As Integer = 0
        Dim media As Integer = 0
        Console.WriteLine("Bienvenido Al Programa")
        For i As Integer = 0 To num.Length - 1
            Console.WriteLine("")
            Console.WriteLine("Ingrese el numero " & i + 1)
            num(i) = Console.ReadLine()
            suma += num(i)
            media = suma / num.Length
        Next
        Array.Sort(num)
        Console.WriteLine("La media es de " & media)
        Console.WriteLine("El numero menor es: {0}", num(0))
        Console.WriteLine("El numero mayor es: {0}", num(num.Length - 1))
        Console.ReadLine()

    End Sub
End Module

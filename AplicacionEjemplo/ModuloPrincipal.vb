Module ModuloPrincipal

    Sub Main()

        'Declarar variables
        Dim Base, Altura, Area As Double
        Dim Texto As String

        'Solicitar valores
        Console.WriteLine("Calcular área de triángulo")

        'Asignar base
        Console.WriteLine("Ingrese el valor de la base:")
        Texto = Console.ReadLine()
        'Verificar si valor es numérico
        If IsNumeric(Texto) Then
            Base = CDbl(Texto)
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("El valor de la base no es válido.")
            Console.ReadLine()
            Return
        End If

        'Asignar altura
        Console.WriteLine("Ingrese el valor de la altura:")
        Texto = Console.ReadLine()
        'Verificar si valor es numérico
        If IsNumeric(Texto) Then
            Altura = CDbl(Texto)
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("El valor de la altura no es válido.")
            Console.ReadLine()
            Return
        End If

        'Calcular área
        Area = CalcularAreaTriangulo(Base, Altura)

        'Mostrar nombre
        Console.WriteLine("El área del triángulo es {0}", Area)

        'Esperar que el usuario presione Enter
        Console.ReadLine()

    End Sub

End Module

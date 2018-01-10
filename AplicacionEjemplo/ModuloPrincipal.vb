Module ModuloPrincipal

    Sub Main()

        'Declarar variables
        Dim Base, Altura, Area As Double

        'Solicitar valores
        Console.WriteLine("Calcular área de triángulo")

        'Asignar base
        Console.WriteLine("Ingrese el valor de la base:")
        Base = CDbl(Console.ReadLine())

        'Asignar altura
        Console.WriteLine("Ingrese el valor de la altura:")
        Altura = CDbl(Console.ReadLine())

        'Calcular área
        Area = CalcularAreaTriangulo(Base, Altura)

        'Mostrar nombre
        Console.WriteLine("El área del triángulo es {0}", Area)

        'Esperar que el usuario presione Enter
        Console.ReadLine()

    End Sub

    Function CalcularAreaTriangulo(Base As Double, Altura As Double)
        Dim Area As Double
        Area = (Base * Altura) / 2
        Return Area
    End Function

End Module

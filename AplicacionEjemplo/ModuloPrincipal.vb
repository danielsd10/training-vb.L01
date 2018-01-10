Module ModuloPrincipal

    Sub Main()

        'Declarar variable
        Dim Nombre As String

        'Solicitar nombre
        Console.WriteLine("Ingrese su nombre:")

        'Asignar valor con texto ingresado por el usuario
        Nombre = Console.ReadLine()

        'Mostrar nombre
        Console.WriteLine("Hola {0}!", Nombre)

        'Esperar que el usuario presione Enter
        Console.ReadLine()

    End Sub

End Module

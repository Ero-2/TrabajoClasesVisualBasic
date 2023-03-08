Module Module1

    Sub Main()
        Try
            Dim lista As List(Of contacto) = New List(Of contacto)()
            Dim salir As Boolean = False
            Console.WriteLine("¿Cuántos contactos desea guardar?")
            Dim i As Integer = Integer.Parse(Console.ReadLine())
            Dim a As Integer = 0
            While Not salir
                a += 1
            End While

            Dim x As contacto
            x = New contacto()
            Console.WriteLine("Nombre")
            x.Nombre = Console.ReadLine()
            Console.WriteLine("Telefono")
            x.Telefono = Console.ReadLine()
            Console.WriteLine("Fecha de Nacimiento")
            x.FechaNacimiento = DateTime.Parse(Console.ReadLine())
            Console.WriteLine("Favor de ingresar un numero de telefono")
            x.Telefono = Console.ReadLine()
            lista.Add(x)
            If i = a Then
                salir = True
            End If

            Console.Clear()
            Console.WriteLine("Nombre--Edad--Numero de telefono")
            For Each c As contacto In lista
                Console.WriteLine(x.ToString())
            Next
        Catch e As FormatException
            Console.WriteLine(e.Message)
        End Try

        Console.ReadKey()
    End Sub

End Module

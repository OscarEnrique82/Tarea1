Module Module1
    ' Oscar Enrique Mejía Chávez DSNP011423
    Sub Main()
        ' Declaración de variables
        Dim Edad As Integer
        ' Toma de datos
        While True
            Console.WriteLine("------------------------------")
            Console.WriteLine("Ingrese la edad de la persona:")
            Console.WriteLine("------------------------------")
            Edad = Console.ReadLine()

            ' Evalaución de datos
            If (Edad >= 18) Then
                ' Mostrar en pantalla el resultado
                Console.WriteLine("------------------------------------------------------")
                Console.WriteLine("La persona tiene " & Edad & " años por lo tanto es mayor de edad")
                Console.WriteLine("------------------------------------------------------")
                Console.WriteLine()
            Else
                ' Mostrar en pantalla el resultado
                Console.WriteLine("------------------------------------------------------")
                Console.WriteLine("La persona tiene " & Edad & " años por lo tanto es menor de edad")
                Console.WriteLine("------------------------------------------------------")
                Console.WriteLine()
            End If
            Dim resp As String
            Console.WriteLine("----------------------------------------------------------------------")
            Console.WriteLine("Presione cualquier tecla para comparar otra edad o digite s para salir")
            Console.WriteLine("----------------------------------------------------------------------")
            resp = Console.ReadLine()
            If resp = "s" Or resp = "S" Then
                Exit While
            End If
        End While
    End Sub

End Module
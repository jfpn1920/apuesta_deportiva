Imports System
Module apuesta_deportiva
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim deportes(9) As String
        Dim eventos(9) As String
        Dim equiposParticipantes(9) As String
        Dim tiposApuesta(9) As String
        Dim cuotas(9) As Double
        Dim montosApostados(9) As Double
        Dim gananciasPotenciales(9) As Double
        Dim fechas(9) As String
        Dim estados(9) As String
        Dim observaciones(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '-----------------------------------------'
        '--|menu_principal_de_apuesta_deportiva|--'
        '-----------------------------------------'
        Do
            Console.WriteLine("menu principal de apuesta deportiva")
            Console.WriteLine("1) Registrar apuesta")
            Console.WriteLine("2) Editar apuesta")
            Console.WriteLine("3) Listar apuestas")
            Console.WriteLine("4) Buscar apuesta")
            Console.WriteLine("5) Eliminar apuesta")
            Console.WriteLine("6) Mostrar analisis")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '-----------------------'
                '--|registrar_apuesta|--'
                '-----------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas apuestas.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.Write("Deporte: ")
                        deportes(cantidad) = Console.ReadLine()
                        Console.Write("Evento: ")
                        eventos(cantidad) = Console.ReadLine()
                        Console.Write("Equipo o participante: ")
                        equiposParticipantes(cantidad) = Console.ReadLine()
                        Console.Write("Tipo de apuesta: ")
                        tiposApuesta(cantidad) = Console.ReadLine()
                        Console.Write("Cuota: ")
                        cuotas(cantidad) = Convert.ToDouble(Console.ReadLine())
                        Console.Write("Monto apostado: ")
                        montosApostados(cantidad) = Convert.ToDouble(Console.ReadLine())
                        gananciasPotenciales(cantidad) = montosApostados(cantidad) * cuotas(cantidad)
                        Console.Write("Fecha: ")
                        fechas(cantidad) = Console.ReadLine()
                        Console.Write("Estado: ")
                        estados(cantidad) = Console.ReadLine()
                        Console.Write("Observacion: ")
                        observaciones(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Apuesta registrada correctamente.")
                    End If
                '--------------------'
                '--|editar_apuesta|--'
                '--------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen apuestas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Deporte: " & deportes(i) & " | Evento: " & eventos(i) & " | Equipo o participante: " & equiposParticipantes(i) & " | Tipo de apuesta: " & tiposApuesta(i) & " | Cuota: " & cuotas(i) & " | Monto apostado: " & montosApostados(i) & " | Ganancia potencial: " & gananciasPotenciales(i) & " | Fecha: " & fechas(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID de la apuesta a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo deporte: ")
                            deportes(posicion) = Console.ReadLine()
                            Console.Write("Nuevo evento: ")
                            eventos(posicion) = Console.ReadLine()
                            Console.Write("Nuevo equipo o participante: ")
                            equiposParticipantes(posicion) = Console.ReadLine()
                            Console.Write("Nuevo tipo de apuesta: ")
                            tiposApuesta(posicion) = Console.ReadLine()
                            Console.Write("Nueva cuota: ")
                            cuotas(posicion) = Convert.ToDouble(Console.ReadLine())
                            Console.Write("Nuevo monto apostado: ")
                            montosApostados(posicion) = Convert.ToDouble(Console.ReadLine())
                            gananciasPotenciales(posicion) = montosApostados(posicion) * cuotas(posicion)
                            Console.Write("Nueva fecha: ")
                            fechas(posicion) = Console.ReadLine()
                            Console.Write("Nuevo estado: ")
                            estados(posicion) = Console.ReadLine()
                            Console.Write("Nueva observacion: ")
                            observaciones(posicion) = Console.ReadLine()
                            Console.WriteLine("Apuesta actualizada correctamente.")

                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|listar_apuestas|--'
                '---------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen apuestas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Deporte: " & deportes(i) & " | Evento: " & eventos(i) & " | Equipo o participante: " & equiposParticipantes(i) & " | Tipo de apuesta: " & tiposApuesta(i) & " | Cuota: " & cuotas(i) & " | Monto apostado: " & montosApostados(i) & " | Ganancia potencial: " & gananciasPotenciales(i) & " | Fecha: " & fechas(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                    End If
                '--------------------'
                '--|buscar_apuesta|--'
                '--------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen apuestas registradas.")
                    Else
                        Console.Write("Ingrese el ID de la apuesta a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("ID: " & ids(posicion) & " | Deporte: " & deportes(posicion) & " | Evento: " & eventos(posicion) & " | Equipo o participante: " & equiposParticipantes(posicion) & " | Tipo de apuesta: " & tiposApuesta(posicion) & " | Cuota: " & cuotas(posicion) & " | Monto apostado: " & montosApostados(posicion) & " | Ganancia potencial: " & gananciasPotenciales(posicion) & " | Fecha: " & fechas(posicion) & " | Estado: " & estados(posicion) & " | Observacion: " & observaciones(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '----------------------'
                '--|eliminar_apuesta|--'
                '----------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen apuestas registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Deporte: " & deportes(i) & " | Evento: " & eventos(i) & " | Equipo o participante: " & equiposParticipantes(i) & " | Tipo de apuesta: " & tiposApuesta(i) & " | Cuota: " & cuotas(i) & " | Monto apostado: " & montosApostados(i) & " | Ganancia potencial: " & gananciasPotenciales(i) & " | Fecha: " & fechas(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID de la apuesta a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                deportes(i) = deportes(i + 1)
                                eventos(i) = eventos(i + 1)
                                equiposParticipantes(i) = equiposParticipantes(i + 1)
                                tiposApuesta(i) = tiposApuesta(i + 1)
                                cuotas(i) = cuotas(i + 1)
                                montosApostados(i) = montosApostados(i + 1)
                                gananciasPotenciales(i) = gananciasPotenciales(i + 1)
                                fechas(i) = fechas(i + 1)
                                estados(i) = estados(i + 1)
                                observaciones(i) = observaciones(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Apuesta eliminada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '----------------------'
                '--|mostrar_analisis|--'
                '----------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen apuestas registradas.")
                    Else
                        Dim pendientes As Integer = 0
                        Dim ganadas As Integer = 0
                        Dim perdidas As Integer = 0
                        Dim anuladas As Integer = 0
                        Dim montoTotalApostado As Double = 0
                        Dim gananciaPotencialTotal As Double = 0
                        Dim sumaCuotas As Double = 0
                        Dim cuotaMasAlta As Double = cuotas(0)
                        Dim apuestaCuotaMasAlta As String = eventos(0)
                        Dim futbol As Integer = 0
                        Dim baloncesto As Integer = 0
                        Dim beisbol As Integer = 0
                        Dim tenis As Integer = 0
                        Dim otro As Integer = 0
                        For i As Integer = 0 To cantidad - 1
                            montoTotalApostado += montosApostados(i)
                            gananciaPotencialTotal += gananciasPotenciales(i)
                            sumaCuotas += cuotas(i)
                            If cuotas(i) > cuotaMasAlta Then
                                cuotaMasAlta = cuotas(i)
                                apuestaCuotaMasAlta = eventos(i)
                            End If
                            Select Case estados(i).ToLower()
                                Case "pendiente"
                                    pendientes += 1
                                Case "ganada"
                                    ganadas += 1
                                Case "perdida"
                                    perdidas += 1
                                Case "anulada"
                                    anuladas += 1
                            End Select
                            Select Case deportes(i).ToLower()
                                Case "futbol", "fútbol"
                                    futbol += 1
                                Case "baloncesto"
                                    baloncesto += 1
                                Case "beisbol", "béisbol"
                                    beisbol += 1
                                Case "tenis", "tennis"
                                    tenis += 1
                                Case Else
                                    otro += 1
                            End Select
                        Next
                        Dim promedioApostado As Double = montoTotalApostado / cantidad
                        Dim cuotaPromedio As Double = sumaCuotas / cantidad
                        Dim deporteMasApostado As String = "Futbol"
                        Dim mayorCantidad As Integer = futbol
                        If baloncesto > mayorCantidad Then
                            mayorCantidad = baloncesto
                            deporteMasApostado = "Baloncesto"
                        End If
                        If beisbol > mayorCantidad Then
                            mayorCantidad = beisbol
                            deporteMasApostado = "Beisbol"
                        End If
                        If tenis > mayorCantidad Then
                            mayorCantidad = tenis
                            deporteMasApostado = "Tenis"
                        End If
                        If otro > mayorCantidad Then
                            mayorCantidad = otro
                            deporteMasApostado = "Otro"
                        End If
                        Console.WriteLine("Apuestas: " & cantidad & " | Pendientes: " & pendientes & " | Ganadas: " & ganadas & " | Perdidas: " & perdidas & " | Anuladas: " & anuladas & " | Monto total apostado: " & montoTotalApostado & " | Ganancia potencial total: " & gananciaPotencialTotal & " | Promedio apostado: " & promedioApostado & " | Cuota promedio: " & cuotaPromedio & " | Cuota mas alta: " & cuotaMasAlta & " | Apuesta con cuota mas alta: " & apuestaCuotaMasAlta & " | Deporte con mas apuestas: " & deporteMasApostado)
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Apuesta Deportiva.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module
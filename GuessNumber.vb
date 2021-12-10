Option Strict On
Module GuessNumber
    Sub Main()
        Try
            Dim name As String
            Dim opt As Integer
            Dim attemps As Integer = 1
            Dim cont As Char
            Do
                Console.WriteLine("Tell me your name: ")
                name = Convert.ToString(Console.ReadLine())
                Console.WriteLine("Choose an option!")
                Console.WriteLine("1) Easy Level / 2) Middle Level / 3) Hard Level / 4) Exit")
                opt = Convert.ToInt32(Console.ReadLine())
                If (opt = 1) Then
                    Dim numero As Integer
                    Console.WriteLine("Welcome to the Easy Level")
                    Dim random As Random = New Random
                    Dim randomNumber = random.Next(1, 10)
                    While (attemps <= 3)
                        Console.WriteLine("This is your try number: " & attemps & "º. Tell me a number between 1 and 10:")
                        numero = Convert.ToInt32(Console.ReadLine())
                        If (numero <= 10) Then
                            If (numero = randomNumber) Then
                                Console.WriteLine("You got it!")
                                Console.WriteLine("Congratulations " & name & ". You are the best <3")
                                Exit While
                            ElseIf (numero < randomNumber) Then
                                Console.WriteLine("The number is higher")
                            ElseIf (numero > randomNumber) Then
                                Console.WriteLine("The number is lower")
                            End If
                            attemps += 1

                            If (attemps > 3) Then
                                Console.WriteLine("The correct number is: " & randomNumber)
                            End If
                        ElseIf (numero > 10 And numero <= 50) Then
                            Console.WriteLine("That number is not valid for this level. Better go to the Middle Level")
                        ElseIf (numero > 50) Then
                            Console.WriteLine("That number is not valid for this level. Better go to the Hard Level")
                        End If
                    End While
                ElseIf (opt = 2) Then
                    Dim numero As Integer
                    Console.WriteLine("Welcome al Middle Level")
                    Dim random As Random = New Random
                    Dim randomNumber = random.Next(1, 50)
                    While (attemps <= 5)
                        Console.WriteLine("This is your try number: " & attemps & "º. Tell me a number between 1 and 50:")
                        numero = Convert.ToInt32(Console.ReadLine())
                        If (numero <= 50) Then
                            If (numero = randomNumber) Then
                                Console.WriteLine("You got it!")
                                Console.WriteLine("Congratulations " & name & ". You are the best <3")
                                Exit While
                            ElseIf (numero < randomNumber) Then
                                Console.WriteLine("The number is higher")
                            ElseIf (numero > randomNumber) Then
                                Console.WriteLine("The number is lower")
                            End If
                            attemps += 1

                            If (attemps > 5) Then
                                Console.WriteLine("The Correct Number is: " & randomNumber)
                            End If

                        ElseIf (numero > 50) Then
                            Console.WriteLine("That number is not valid for this level. Better go to the Hard Level")
                        End If
                    End While
                ElseIf (opt = 3) Then
                    Dim numero As Integer
                    Console.WriteLine("Welcome to the Hard Level")
                    Dim random As Random = New Random
                    Dim randomNumber = random.Next(1, 100)
                    While (attemps <= 8)
                        Console.WriteLine(randomNumber)
                        Console.WriteLine("This is your try number: " & attemps & " º. Tell me a number between 1 and 100:")
                        numero = Convert.ToInt32(Console.ReadLine())
                        If (numero <= 100) Then
                            If (numero = randomNumber) Then
                                Console.WriteLine("You got it!")
                                Console.WriteLine("Congratulations " & name & ". You are the best <3")
                                Exit While
                            ElseIf (numero < randomNumber) Then
                                Console.WriteLine("The number is higher")
                            ElseIf (numero > randomNumber) Then
                                Console.WriteLine("The number is lower")
                            End If
                            attemps += 1

                            If (attemps > 8) Then
                                Console.WriteLine("The Correct Number is: " & randomNumber)
                            End If

                        ElseIf (numero > 100) Then
                            Console.WriteLine("The number exceeds the limit")
                        End If
                    End While
                ElseIf (opt = 4) Then
                    Console.WriteLine("Bye Bye")
                    Exit Do
                ElseIf (opt > 5) Then
                    Console.WriteLine("Option doesn't exist")
                End If
                Console.WriteLine("Do you want to play again?")
                cont = Convert.ToChar(Console.ReadLine())
                Console.Clear()
            Loop While cont = "y"c
            Console.ReadLine()
        Catch ex As Exception

        End Try

    End Sub

End Module

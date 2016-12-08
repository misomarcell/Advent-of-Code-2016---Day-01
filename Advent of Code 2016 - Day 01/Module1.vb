Module Module1
    Dim input_file As String = "input.txt"
    Sub Main()
        Dim command() As String
        command = readFile.split(", ")

        Dim x As Integer
        Dim y As Integer
        Dim turn As Integer = 1
        For i As Integer = 0 To command.Length - 1
            command(i) = command(i).Replace(" ", "")
            Dim direction As String = command(i)(0)
            Dim distance As Integer = command(i).Replace(direction, "")
            Console.WriteLine(direction & "-" & distance)

            If direction = "R" Then
                If turn < 4 Then
                    turn = turn + 1
                Else
                    turn = 1
                End If
            ElseIf direction = "L" Then
                If turn > 1 Then
                    turn = turn - 1
                Else
                    turn = 4
                End If
            End If
            Console.WriteLine("TURN: " & turn)

            If turn = 1 Then
                y = y + distance
            ElseIf turn = 2 Then
                x = x + distance
            ElseIf turn = 3 Then
                y = y - distance
            ElseIf turn = 4 Then
                x = x - distance
            End If
        Next

        Console.WriteLine("POSITIONS: " & x & "; " & y)
        Console.WriteLine("SOLUTION: " & Math.Abs(x) + Math.Abs(y))


        Dim k As String = Console.ReadLine
    End Sub

    Function readFile()
        Return System.IO.File.ReadAllText("./" & input_file)
    End Function

End Module

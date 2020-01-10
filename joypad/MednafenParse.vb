Imports System.IO

Module MednafenParse
    Dim ExactPadName As String

    Public Sub ParseJoypad()
        MedPad.ListBox2.Items.Clear()
        Dim CAgain As Integer = 0
        Dim row As String

AGAIN:
        Try
            Using reader As New StreamReader(MedPad.MedPath & "\stdout.txt")
                While Not reader.EndOfStream
                    row = reader.ReadLine
                    If row.Contains("Joystick ") Or row.Contains("ID: ") Then
                        MedPad.ListBox2.Items.Add(row.Trim)
                    End If
                End While
                reader.Dispose()
                reader.Close()
            End Using
            MedPad.ListBox2.Items.Add("Mouse")
        Catch
            If CAgain < 50 Then
                CAgain += 1
                GoTo AGAIN
            Else
                MsgBox("There are problems in intercepting the joypads detected by mednafen." & vbCrLf &
                       "If you have Mednafen started try to close it," & vbCrLf &
                       "otherwise try to enable forced recognition of pads via Direct Input" & vbCrLf &
                       "and press refresh button", vbOKOnly + MsgBoxStyle.Exclamation, "Unrecognized Pad...")
                Exit Sub
            End If
        End Try

        If MedPad.ListBox1.Items.Count <> MedPad.ListBox2.Items.Count Then
            If MedPad.firststart = True Then
                MedPad.firststart = False
                MedPad.Button3.PerformClick()
            Else
                MsgBox("MedPad has detected more pads that Mednafen has detected ." & vbCrLf & "Try pressing the MedPad refresh button, otherwise unplug and reconnect the pads and press again refresh button." & vbCrLf &
                       "Try also to force Direct Input Detection and press again refresh button", vbOKOnly + vbInformation, "Refresh Connected Pad...")
            End If
        End If
    End Sub

    Public Sub ParseTypePad()
        MedPad.PadInputName.Items.Clear()
        MedPad.InputAlreadyAssigned.Items.Clear()
        Dim row, splitrow() As String
        Try
            Using reader As New StreamReader(MedPad.MedPath & "\" & MedPad.DMedConf & ".cfg")
                While Not reader.EndOfStream
                    row = reader.ReadLine
                    If row.Contains(";" & MedPad.ComboConsole.Text & ",") Then
                        splitrow = Split(row, ", ")
                        If splitrow.Length >= 3 Then
                            Dim Ve1 As Boolean = False
                            If MedPad.ComboPort.Items.Contains(splitrow(1)) Then Ve1 = True
                            If Ve1 = False Then MedPad.ComboPort.Items.Add(splitrow(1))
                        End If
                    End If
                End While
                reader.Dispose()
                reader.Close()
            End Using

            If MedPad.ComboPort.Items.Count > 0 Then MedPad.ComboPort.SelectedIndex = 0
        Catch
        End Try
    End Sub

    Public Sub ParseListInput()
        MedPad.ComboPad.Items.Clear()
        Dim row, splitrow(), splitrow1() As String
        Try
            Using reader As New StreamReader(MedPad.MedPath & "\" & MedPad.DMedConf & ".cfg")
                While Not reader.EndOfStream
                    row = reader.ReadLine
                    If row.Contains(";" & MedPad.ComboConsole.Text & ", " & MedPad.ComboPort.Text & ", ") Then
                        splitrow = Split(row, ", ")
                        If splitrow.Length >= 3 Then
                            Dim Ve1 As Boolean = False
                            splitrow1 = Split(splitrow(2), ": ")
                            If MedPad.ComboPad.Items.Contains(splitrow1(0)) Then Ve1 = True
                            If Ve1 = False Then MedPad.ComboPad.Items.Add(splitrow1(0))
                        End If
                    End If
                End While
                reader.Dispose()
                reader.Close()
            End Using

            If MedPad.ComboPad.Items.Count > 0 Then MedPad.ComboPad.SelectedIndex = 0
        Catch
        End Try

    End Sub

    Public Sub ParseNameListInput()
        MedPad.PadInputName.Items.Clear()
        Dim row, splitrow(), splitrow1() As String
        Try
            Using reader As New StreamReader(MedPad.MedPath & "\" & MedPad.DMedConf & ".cfg")
                While Not reader.EndOfStream
                    row = reader.ReadLine
                    If row.Contains(";" & MedPad.ComboConsole.Text & ", " & MedPad.ComboPort.Text & ", " & MedPad.ComboPad.Text & ": ") Then
                        splitrow = Split(row, ", ")
                        If splitrow(0) & ", " = ";" & MedPad.ComboConsole.Text & ", " Then
                            If splitrow.Length = 3 Then
                                splitrow1 = Split(splitrow(2), ": ")
                                MedPad.PadInputName.Items.Add(splitrow1(1))
                            ElseIf splitrow.Length = 4 Then
                                splitrow1 = Split(splitrow(2) & ", " & splitrow(3), ": ")
                                MedPad.PadInputName.Items.Add(splitrow1(1))
                            End If
                        End If
                    End If
                End While
                reader.Dispose()
                reader.Close()
            End Using
        Catch
        End Try
    End Sub

    Public Sub PerAInputValue()
        Dim count As Integer = 0
        Dim row, splitrow() As String

        'For Each myItem In MedPad.PadInputName.Items
        'Dim controltry As Boolean = False
        Try
            Using reader As New StreamReader(MedPad.MedPath & "\pgconfig\" & MedPad.SpecificGame.Text & "." & MedPad.ComboConsole.Text & ".cfg")

                While Not reader.EndOfStream
                    row = reader.ReadLine
                    count += 1
                    If row.Contains(";" & MedPad.ComboConsole.Text & ", " & MedPad.ComboPort.Text & ", " & MedPad.ComboPad.Text & ": ") Then
                        'controltry = True
                        splitrow = Split(readNthLine(MedPad.MedPath & "\pgconfig\" & MedPad.SpecificGame.Text & "." & MedPad.ComboConsole.Text & ".cfg", count), " ")
                        Select Case splitrow.Length
                            Case 1, 2, 0, Nothing
                                MedPad.InputAlreadyAssigned.Items.Add("Not Setted")
                            Case 2
                                MedPad.InputAlreadyAssigned.Items.Add(splitrow(1))
                            Case 3
                                MedPad.InputAlreadyAssigned.Items.Add(splitrow(1) & " " & splitrow(2))
                            Case 4
                                MedPad.InputAlreadyAssigned.Items.Add(splitrow(1) & " " & splitrow(3))
                            Case 8
                                MedPad.InputAlreadyAssigned.Items.Add(splitrow(1) & " " & splitrow(3) & " + " & splitrow(5) & " " & splitrow(7))
                        End Select
                    End If

                End While
                reader.Dispose()
                reader.Close()
            End Using

            'If controltry = False Then
            'MedPad.InputAlreadyAssigned.Items.Add("Not Setted")
            'Else
            'count += 2
            'End If

            'Next
        Catch
        End Try

    End Sub

    Public Sub AssignedInputValue()
        MedPad.InputAlreadyAssigned.Items.Clear()

        If MedPad.CheckBox1.Checked = True Then
            If File.Exists(MedPad.MedPath & "\pgconfig\" & MedPad.SpecificGame.Text & "." & MedPad.ComboConsole.Text & ".cfg") = False Then
                MakeNewPerConfig()
            End If
            PerAInputValue()
            Exit Sub
        End If

        Dim row, splitrow() As String
        Dim count As Integer = 0

        Try
            Using reader As New StreamReader(MedPad.MedPath & "\" & MedPad.DMedConf & ".cfg")

                While Not reader.EndOfStream
                    row = reader.ReadLine
                    count += 1
                    If row.Contains(";" & MedPad.ComboConsole.Text & ", " & MedPad.ComboPort.Text & ", " & MedPad.ComboPad.Text & ": ") Then
                        splitrow = Split(readNthLine(MedPad.MedPath & "\" & MedPad.DMedConf & ".cfg", count), " ")
                        Select Case splitrow.Length
                            Case 1, 2, 0, Nothing
                                MedPad.InputAlreadyAssigned.Items.Add("Not Setted")
                            Case 2
                                MedPad.InputAlreadyAssigned.Items.Add(splitrow(1))
                            Case 3
                                MedPad.InputAlreadyAssigned.Items.Add(splitrow(1) & " " & splitrow(2))
                            Case 4
                                MedPad.InputAlreadyAssigned.Items.Add(splitrow(1) & " " & splitrow(3))
                            Case 8
                                MedPad.InputAlreadyAssigned.Items.Add(splitrow(1) & " " & splitrow(3) & " + " & splitrow(5) & " " & splitrow(7))
                        End Select
                    End If
                End While
                reader.Dispose()
                reader.Close()
            End Using
        Catch
        End Try
    End Sub

    Public Sub ReadParameter()
        Dim row, splitpar() As String
        Dim count As Integer = 0
        Try
            Using reader As New StreamReader(MedPad.MedPath & "\" & MedPad.DMedConf & ".cfg")

                While Not reader.EndOfStream
                    row = reader.ReadLine
                    count += 1
                    If row.Contains(";" & MedPad.ComboConsole.Text & ", " & MedPad.ComboPort.Text & ", " & MedPad.ComboPad.Text & ": " & MedPad.PadInputName.SelectedItem.ToString) Then
                        Exit While
                    End If
                End While
                reader.Dispose()
                reader.Close()
            End Using
            splitpar = Split(readNthLine(MedPad.MedPath & "\" & MedPad.DMedConf & ".cfg", count), " ")
            MedPad.MedPar = "-" & (splitpar(0))
        Catch
        End Try
    End Sub

    Public Function readNthLine(fileAndPath As String, lineNumber As Integer) As String
        Dim nthLine As String = Nothing
        Dim n As Integer
        Try
            Using sr As StreamReader = New StreamReader(fileAndPath)
                n = 0
                Do While (sr.Peek() >= 0) And (n < lineNumber)
                    sr.ReadLine()
                    n += 1
                Loop
                If sr.Peek() >= 0 Then
                    nthLine = sr.ReadLine()
                End If
            End Using
        Catch ex As Exception
            Throw
        End Try
        readNthLine = nthLine
    End Function

End Module
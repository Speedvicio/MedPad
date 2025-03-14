﻿Imports System.IO

Public Class PreconfiguredPad
    Dim PlayerPAD As String
    Dim PreInput_Value As String
    Dim MedPad_Value As String
    Dim myfile As String
    Dim Pad_Name As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SplitPadName() As String = Split(MedPad.ListBox2.SelectedItem.ToString, " - ")
        If SplitPadName.Length > 0 Then Pad_Name = SplitPadName(1).Trim

        myfile = MedPad.MCF.Text
        PlayerPAD = ".port" & NumericUpDown1.Value & "."
        Pad_Name += "_" & NumericUpDown1.Value
        Get_Input_Template()
    End Sub

    Private Function Assign_template(File_replace As String) As String
        If File.Exists(Path.Combine(Application.StartupPath, "dbpad\mit_.txt")) Then
            Using reader As StreamReader = New StreamReader(Path.Combine(Application.StartupPath, "dbpad\mit_.txt"))
                Dim a As String

                While Not reader.EndOfStream
                    a = reader.ReadLine
                    Dim Split_a() As String = a.Split("=")
                    If a.Contains(" = " & File_replace) Then
                        Dim MedInputValue As String = Replace(Split_a(0), ".portX.", PlayerPAD)
                        Create_OConfig(myfile, MedInputValue, PreInput_Value)
                        myfile = Replace(MedPad.MCF.Text, "mednafen.cfg", Pad_Name & ".cfg_bak")
                        'MsgBox(Replace(Split_a(0), ".portX.", PlayerPAD) & PreInput_Value)
                    End If
                End While
            End Using
        End If
    End Function

    Private Function Get_Input_Template() As String
        Using reader As StreamReader = New StreamReader(Path.Combine(Application.StartupPath, "dbpad\" & MedPad.UniqueId) & ".txt")
            Dim a As String

            While Not reader.EndOfStream
                a = reader.ReadLine
                Dim Split_a() As String = a.Split("=")
                If Split_a(0).Trim <> "" Then
                    PreInput_Value = Split_a(1).Trim
                    Assign_template(Split_a(0).Trim)
                End If
            End While
        End Using
        If File.Exists(Replace(MedPad.MCF.Text, "mednafen.cfg", Pad_Name & ".cfg")) Then
            Dim npad() As String = MedPad.ListBox1.SelectedItem.ToString.Split("GUID")
            MsgBox("All mednafen module configured on: " & npad(0).Trim & vbCrLf &
                   "For player: " & NumericUpDown1.Value, vbOKOnly + MsgBoxStyle.Information, Pad_Name & " template applied")
            File.Delete(Replace(MedPad.MCF.Text, "mednafen.cfg", Pad_Name & ".cfg_bak"))
        End If
    End Function

    Private Function Create_OConfig(source As String, filter As String, replacer As String)
        Dim OutputFile As String = Replace(MedPad.MCF.Text, "mednafen.cfg", Pad_Name & ".cfg")
        Dim PreviousLine As String = ""
        Dim CurrentLine As String = ""
        Using sr As StreamReader = New StreamReader(source)
            Using sw As StreamWriter = New StreamWriter(OutputFile)

                CurrentLine = sr.ReadLine

                Do While (Not CurrentLine Is Nothing)

                    Dim lineToWrite = CurrentLine

                    If CurrentLine.Contains(filter) Then
                        lineToWrite = filter & replacer
                    End If

                    sw.WriteLine(lineToWrite)

                    PreviousLine = CurrentLine
                    CurrentLine = sr.ReadLine 
                Loop
            End Using
        End Using
        File.Copy(OutputFile, OutputFile & "_bak", True)
    End Function
End Class
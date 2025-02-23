Imports System.IO

Public Class PreconfiguredPad
    Dim PlayerPAD As String
    Dim PreInput_Value As String
    Dim MedPad_Value As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PlayerPAD = ".port" & NumericUpDown1.Value & "."
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
                        MsgBox(Replace(Split_a(0), ".portX.", PlayerPAD) & PreInput_Value)
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
    End Function

End Class
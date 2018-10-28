Imports System.IO

Module PerGameConfig

    Public Sub EditConfig()

        If MedPad.CheckBox1.Checked = True Then
            If File.Exists(MedPad.ConfigPath) = False Then MakeNewPerConfig() : Exit Sub
        End If
        Dim RowEx As Integer = 0
        If MedPad.PadInputName.Items.Count <= 0 Then Exit Sub
        Dim parclean As String = ""
        parclean = MedPad.MedPar.Remove(0, 1)
        parclean = Replace(parclean, """", "")
        Dim SearchRow As String = ";" & MedPad.ComboConsole.Text & ", " & MedPad.ComboPort.Text & ", " & MedPad.ComboPad.Text &
                          ": " & MedPad.PadInputName.SelectedItem
        Dim linee As String() = IO.File.ReadAllLines(MedPad.ConfigPath)
        For i As Integer = 0 To linee.Length - 1
            If linee(i) = (SearchRow) Then
                If MedPad.CheckBox3.Checked = True And MedPad.DMedConf = "mednafen" Then
                    Dim splitpar() As String = Split(linee(i + 1), " ")
                    parclean = linee(i + 1) & " ||" & Replace(parclean, splitpar(0), Nothing)
                End If
                linee(i + 1) = parclean
                RowEx += 1
            End If
        Next

        If RowEx > 0 Then
            File.WriteAllLines(MedPad.ConfigPath, linee)
        Else
            MakeNewPerConfig()
            RowEx = 0
        End If

    End Sub

    Public Sub MakeNewPerConfig()
        Dim count As Integer = 0
        Dim row As String
        Dim file As StreamWriter

        For Each myItem In MedPad.PadInputName.Items
            Dim controltry As Boolean = False
            Using reader As New StreamReader(MedPad.MedPath & "\" & MedPad.DMedConf & ".cfg")
                While Not reader.EndOfStream
                    row = reader.ReadLine
                    count += 1
                    If row.Contains(";" & MedPad.ComboConsole.Text & ", " & MedPad.ComboPort.Text & ", " & MedPad.ComboPad.Text & ": " & myItem) Then
                        file = My.Computer.FileSystem.OpenTextFileWriter(MedPad.MedPath & "\pgconfig\" & MedPad.SpecificGame.Text & "." & MedPad.ComboConsole.Text & ".cfg", True)
                        file.WriteLine(row)
                        Dim splitclean() = Split(readNthLine(MedPad.MedPath & "\" & MedPad.DMedConf & ".cfg", count), " ")
                        file.WriteLine(splitclean(0))
                        file.Close()
                        Exit While
                    End If
                End While
                reader.Dispose()
                reader.Close()
            End Using
            count = 0
        Next
        MsgBox("Added values for " & MedPad.ComboPort.Text & " - " & MedPad.ComboPad.Text, MsgBoxStyle.OkOnly + vbInformation, "File Maked...")
        MedPad.ControlSpecificFileExist()
    End Sub

    Public Sub RemoveThisPad()
        Try
            Dim linee As String() = IO.File.ReadAllLines(MedPad.ConfigPath)
            For Each myItem In MedPad.PadInputName.Items
                Dim SearchRow As String = ";" & MedPad.ComboConsole.Text & ", " & MedPad.ComboPort.Text & ", " & MedPad.ComboPad.Text &
                  ": " & myItem
                For i As Integer = 0 To linee.Length - 1
                    If linee(i) = (SearchRow) Then
                        linee(i + 1) = ""
                        linee(i) = ""
                    End If
                Next
                File.WriteAllLines(MedPad.ConfigPath, linee)
            Next

            Dim linee1 As String() = IO.File.ReadAllLines(MedPad.ConfigPath)
            Dim lineArray As New ArrayList()
            For x As Integer = 0 To linee1.Length - 1
                If linee1(x) <> "" Then lineArray.Add(linee1(x))
            Next

            Dim Carray() As String = CType(lineArray.ToArray(GetType(String)), String())
            File.WriteAllLines(MedPad.ConfigPath, Carray)

            MsgBox(MedPad.ComboPort.Text & " - " & MedPad.ComboPad.Text & " removed from config!" + vbOKOnly + vbInformation, "Removed Input...")
        Catch
        End Try
    End Sub

    Public Sub ResetThisPad()
        If MedPad.InputAlreadyAssigned.Items.Count < 0 Then Exit Sub

        Dim linee As String() = IO.File.ReadAllLines(MedPad.ConfigPath)
        Dim SplitLinee As String()
        For Each myItem In MedPad.PadInputName.Items
            Dim SearchRow As String = ";" & MedPad.ComboConsole.Text & ", " & MedPad.ComboPort.Text & ", " & MedPad.ComboPad.Text &
                  ": " & myItem
            For i As Integer = 0 To linee.Length - 1
                If linee(i) = (SearchRow) Then
                    SplitLinee = Split(linee(i + 1), " ")
                    linee(i + 1) = SplitLinee(0) & " "
                End If
            Next
            File.WriteAllLines(MedPad.ConfigPath, linee)
        Next
    End Sub

End Module
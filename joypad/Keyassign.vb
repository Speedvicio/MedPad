Module Keyassign
    Public tasti, sdlKey As String, vbkey As Integer

    Public Sub TransKeyTosdlKey()

        'controllo di alcune lettere,IL PROGRAMMA ne segna solo una ma in
        'realtà il sistema permette di leggere anche più tasti contemporaneamente

        If Val(vbkey) >= 112 And Val(vbkey) <= 123 Then
            MsgBox(tasti & " key is not assignable" &
       vbCrLf & "Please select another key", MsgBoxStyle.Information) : tasti = "" : sdlKey = "" : Exit Sub
        ElseIf Val(vbkey) >= 48 And Val(vbkey) <= 57 Then
            MsgBox(tasti & " key is not assignable" &
       vbCrLf & "Please select another key", MsgBoxStyle.Information) : tasti = "" : sdlKey = "" : Exit Sub
        End If
        Select Case vbkey
            Case 131089, 262161, 262162, 65552, 16, 17, 18, 91, 92, 93, 27, 20, 144
                MsgBox(tasti & " key is not assignable" &
                       vbCrLf & "Please select another key", MsgBoxStyle.Information) : tasti = "" : sdlKey = "" : Exit Sub
            Case 8
                sdlKey = 8
            Case 9
                sdlKey = 9
            Case 46
                sdlKey = 127
            Case 13
                sdlKey = 13
            Case 19
                sdlKey = 19
            Case 32
                sdlKey = 32
            Case 219
                sdlKey = 45
            Case 0
                sdlKey = 48
            Case 1
                sdlKey = 49
            Case 2
                sdlKey = 50
            Case 3
                sdlKey = 51
            Case 4
                sdlKey = 52
            Case 5
                sdlKey = 53
            Case 6
                sdlKey = 54
            Case 7
                sdlKey = 55
            Case 8
                sdlKey = 56
            Case 9
                sdlKey = 57
            Case 226
                sdlKey = 60
            Case 221
                sdlKey = 61

                'Uppercase letters
            Case 65
                sdlKey = 97
            Case 66
                sdlKey = 98
            Case 67
                sdlKey = 99
            Case 68
                sdlKey = 100
            Case 69
                sdlKey = 101
            Case 70
                sdlKey = 102
            Case 71
                sdlKey = 103
            Case 72
                sdlKey = 104
            Case 73
                sdlKey = 105
            Case 74
                sdlKey = 106
            Case 75
                sdlKey = 107
            Case 76
                sdlKey = 108
            Case 77
                sdlKey = 109
            Case 78
                sdlKey = 110
            Case 79
                sdlKey = 111
            Case 80
                sdlKey = 112
            Case 81
                sdlKey = 113
            Case 82
                sdlKey = 114
            Case 83
                sdlKey = 115
            Case 84
                sdlKey = 116
            Case 85
                sdlKey = 117
            Case 86
                sdlKey = 118
            Case 87
                sdlKey = 119
            Case 88
                sdlKey = 120
            Case 89
                sdlKey = 121
            Case 189
                sdlKey = 47

                'Special
            Case 90
                sdlKey = 122
            Case 220
                sdlKey = 96
            Case 186
                sdlKey = 91
            Case 187
                sdlKey = 93
            Case 188
                sdlKey = 44
            Case 190
                sdlKey = 46
            Case 192
                sdlKey = 59
            Case 222
                sdlKey = 39
            Case 191
                sdlKey = 92

                '/* Numeric keypad */
            Case 96
                sdlKey = 256
            Case 97
                sdlKey = 257
            Case 98
                sdlKey = 258
            Case 99
                sdlKey = 259
            Case 100
                sdlKey = 260
            Case 101
                sdlKey = 261
            Case 102
                sdlKey = 262
            Case 103
                sdlKey = 263
            Case 104
                sdlKey = 264
            Case 105
                sdlKey = 265
            Case 110
                sdlKey = 266
            Case 111
                sdlKey = 267
            Case 106
                sdlKey = 268
            Case 109
                sdlKey = 269
            Case 107
                sdlKey = 270
                'Case KP_ENTER" Then sdlKey = 271
                'Case KP_EQUALS" Then sdlKey = 272

                '/* Arrows + Home/End pad */
            Case 38
                sdlKey = 273
            Case 40
                sdlKey = 274
            Case 39
                sdlKey = 275
            Case 37
                sdlKey = 276
            Case 45
                sdlKey = 277
            Case 36
                sdlKey = 278
            Case 35
                sdlKey = 279
            Case 33
                sdlKey = 280
            Case 34
                sdlKey = 281

                '/* Function keys */
            Case 112
                sdlKey = 282
            Case 113
                sdlKey = 283
            Case 114
                sdlKey = 284
            Case 115
                sdlKey = 285
            Case 116
                sdlKey = 286
            Case 117
                sdlKey = 287
            Case 118
                sdlKey = 288
            Case 119
                sdlKey = 289
            Case 120
                sdlKey = 290
            Case 121
                sdlKey = 291
            Case 122
                sdlKey = 292
            Case 124
                sdlKey = 294
            Case 125
                sdlKey = 295
            Case 126
                sdlKey = 296
            Case Else

        End Select
    End Sub

End Module
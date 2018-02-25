Module Keyassign
    Public tasti, sdlKey As String, vbkey As Integer

    Public Sub TransKeyTosdlKey()

        'controllo di alcune lettere,IL PROGRAMMA ne segna solo una ma in
        'realtà il sistema permette di leggere anche più tasti contemporaneamente

        If MedPad.DMedConf = "mednafen" Then
            TransKeyToSdl_2()
            Exit Sub
        End If

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

    Public Sub TransKeyToSdl_2()
        Select Case vbkey
        'Escape
            Case 27
                sdlKey = 41

'F1
            Case 112
                sdlKey = 58

'F2
            Case 113
                sdlKey = 59

'F3
            Case 114
                sdlKey = 60

'F4
            Case 115
                sdlKey = 61

'F5
            Case 116
                sdlKey = 62

'F6
            Case 117
                sdlKey = 63

'F7
            Case 118
                sdlKey = 64

'F8
            Case 119
                sdlKey = 65

'F9
            Case 120
                sdlKey = 66

'F10
            Case 121
                sdlKey = 67

'F11
            Case 122
                sdlKey = 68

'F12
            Case 123
                sdlKey = 69

'D1
            Case 49
                sdlKey = 30

'D2
            Case 50
                sdlKey = 31

'D3
            Case 51
                sdlKey = 32

'D4
            Case 52
                sdlKey = 33

'D5
            Case 53
                sdlKey = 34

'D6
            Case 54
                sdlKey = 35

'D7
            Case 55
                sdlKey = 36

'D8
            Case 56
                sdlKey = 37

'D9
            Case 57
                sdlKey = 38

'D0
            Case 48
                sdlKey = 39

'Q
            Case 81
                sdlKey = 20

'W
            Case 87
                sdlKey = 26

'E
            Case 69
                sdlKey = 8

'R
            Case 82
                sdlKey = 21

'T
            Case 84
                sdlKey = 23

'Y
            Case 89
                sdlKey = 28

'U
            Case 85
                sdlKey = 24

'I
            Case 73
                sdlKey = 12

'O
            Case 79
                sdlKey = 18

'P
            Case 80
                sdlKey = 19

'A
            Case 65
                sdlKey = 4

'S
            Case 83
                sdlKey = 22

'D
            Case 68
                sdlKey = 7

'F
            Case 70
                sdlKey = 9

'G
            Case 71
                sdlKey = 10

'H
            Case 72
                sdlKey = 11

'J
            Case 74
                sdlKey = 13

'K
            Case 75
                sdlKey = 14

'L
            Case 76
                sdlKey = 15

'Z
            Case 90
                sdlKey = 29

'X
            Case 88
                sdlKey = 27

'C
            Case 67
                sdlKey = 6

'V
            Case 86
                sdlKey = 25

'B
            Case 66
                sdlKey = 5

'N
            Case 78
                sdlKey = 17

'M
            Case 77
                sdlKey = 16

'Backslash
            Case 220
                sdlKey = 49

'Unused/Generic
            Case 223
                sdlKey = 96

'Back
            Case 8
                sdlKey = 42

'Tab
            Case 9
                sdlKey = 43

'Return
            Case 13
                sdlKey = 40

'Capital
            Case 20
                sdlKey = 57

'[
            Case 219
                sdlKey = 47

']
            Case 221
                sdlKey = 48

';
            Case 186
                sdlKey = 51

'tilde
            Case 192
                sdlKey = 100

''
            Case 222
                sdlKey = 52

'ShiftKey
            Case 16
                sdlKey = 225

'Bracket
            Case 226
                sdlKey = 47

'comma
            Case 188
                sdlKey = 54

'Period
            Case 190
                sdlKey = 55

'Question
            Case 191
                'sdl =

'ControlKey
            Case 17
                sdlKey = 224

'LWin
            Case 91
                sdlKey = 227

'Alt
            Case 18
                sdlKey = 226

'Space
            Case 32
                sdlKey = 44

'RWin
            Case 92
                sdlKey = 231

'Apps
            Case 93
                sdlKey = 101

'PrintScreen
            Case 44
                sdlKey = 70

'Scroll
            Case 145
                sdlKey = 71

'Pause
            Case 19
                sdlKey = 72

'Insert
            Case 45
                sdlKey = 73

'Home
            Case 36
                sdlKey = 74

'PageUp
            Case 33
                sdlKey = 75

'PageDown
            Case 34
                sdlKey = 78

'End
            Case 35
                sdlKey = 77

'Delete
            Case 46
                sdlKey = 76

'Up
            Case 38
                sdlKey = 82

'Down
            Case 40
                sdlKey = 81

'Left
            Case 37
                sdlKey = 80

'Right
            Case 39
                sdlKey = 79

'SelectMedia
            Case 181
                sdlKey = 263

'VolumeMute
            Case 173
                sdlKey = 262

'VolumeDown
            Case 174
                sdlKey = 129

'VolumeUp
            Case 175
                sdlKey = 128

'MediaStop
            Case 178
                sdlKey = 260

'MediaPreviousTrack
            Case 177
                sdlKey = 259

'MediaPlayPause
            Case 179
                sdlKey = 261

'MediaNextTrack
            Case 176
                sdlKey = 258

'LaunchMail
            Case 180
                sdlKey = 265

'BrowserHome
            Case 172
                sdlKey = 264

'LaunchApplication2
            Case 183
                'sdl =

'NumLock
            Case 144
                sdlKey = 83

'KP_0
            Case 96
                sdlKey = 98

'KP_1
            Case 97
                sdlKey = 89

'KP_2
            Case 98
                sdlKey = 90

'KP_3
            Case 99
                sdlKey = 91

'KP_4
            Case 100
                sdlKey = 92

'KP_5
            Case 101
                sdlKey = 93

'KP_6
            Case 102
                sdlKey = 94

'KP_7
            Case 103
                sdlKey = 95

'KP_8
            Case 104
                sdlKey = 96

'KP_9
            Case 105
                sdlKey = 97

'Divide
            Case 111
                sdlKey = 84

'Multiply
            Case 106
                sdlKey = 85

'Subtract
            Case 109
                sdlKey = 86

'Add
            Case 107
                sdlKey = 87

'Decimal
            Case 110
                sdlKey = 220

'Clear
            Case 12
                sdlKey = 156
            Case Else
                MsgBox(tasti & " with code " & vbkey & " is not assigned" &
                vbCrLf & "Please report KEYCODE " & vbkey & " to MedGuiR topic to add it in the next release", MsgBoxStyle.Information) : tasti = ""
        End Select
        sdlKey = "0x0 " & sdlKey
    End Sub

End Module
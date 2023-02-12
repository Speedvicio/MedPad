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

    Public Function TransKeyToScan_Code(ScanCode)
        If ScanCode.ToString.Contains("Not Setted") Then MedPad.JButtons.Text = "" : Exit Function

        If ScanCode.ToString.StartsWith("keyboard ") = False Then MedPad.JButtons.Text = "" : Exit Function

        ScanCode = ScanCode.Replace("keyboard ", "")

        Select Case ScanCode

            Case 41
                MedPad.JButtons.Text = "Esc"
            Case 58
                MedPad.JButtons.Text = "F1"
            Case 59
                MedPad.JButtons.Text = "F2"
            Case 60
                MedPad.JButtons.Text = "F3"
            Case 61
                MedPad.JButtons.Text = "F4"
            Case 62
                MedPad.JButtons.Text = "F5"
            Case 63
                MedPad.JButtons.Text = "F6"
            Case 64
                MedPad.JButtons.Text = "F7"
            Case 65
                MedPad.JButtons.Text = "F8"
            Case 66
                MedPad.JButtons.Text = "F9"
            Case 67
                MedPad.JButtons.Text = "F10"
            Case 68
                MedPad.JButtons.Text = "F11"
            Case 69
                MedPad.JButtons.Text = "F12"
            Case 30
                MedPad.JButtons.Text = "1"
            Case 31
                MedPad.JButtons.Text = "2"
            Case 32
                MedPad.JButtons.Text = "3"

'D4
            Case 33
                MedPad.JButtons.Text = "4"

'D5
            Case 34
                MedPad.JButtons.Text = "5"

'D6
            Case 35
                MedPad.JButtons.Text = "6"

'D7
            Case 36
                MedPad.JButtons.Text = "7"

'D8
            Case 37
                MedPad.JButtons.Text = "8"

'D9
            Case 38
                MedPad.JButtons.Text = "9"

'D0
            Case 39
                MedPad.JButtons.Text = "0"

'Q
            Case 20
                MedPad.JButtons.Text = "Q"

'W
            Case 26
                MedPad.JButtons.Text = "W"

'E
            Case 8
                MedPad.JButtons.Text = "E"

'R
            Case 21
                MedPad.JButtons.Text = "R"

'T
            Case 23
                MedPad.JButtons.Text = "T"

'Y
            Case 28
                MedPad.JButtons.Text = "Y"

'U
            Case 24
                MedPad.JButtons.Text = "U"

'I
            Case 12
                MedPad.JButtons.Text = "I"

'O
            Case 18
                MedPad.JButtons.Text = "O"

'P
            Case 19
                MedPad.JButtons.Text = "P"

'A
            Case 4
                MedPad.JButtons.Text = "A"

'S
            Case 22
                MedPad.JButtons.Text = "S"

'D
            Case 7
                MedPad.JButtons.Text = "D"

'F
            Case 9
                MedPad.JButtons.Text = "F"

'G
            Case 10
                MedPad.JButtons.Text = "G"

'H
            Case 11
                MedPad.JButtons.Text = "H"

'J
            Case 13
                MedPad.JButtons.Text = "J"

'K
            Case 14
                MedPad.JButtons.Text = "K"

'L
            Case 15
                MedPad.JButtons.Text = "L"

'Z
            Case 29
                MedPad.JButtons.Text = "Z"

'X
            Case 27
                MedPad.JButtons.Text = "X"

'C
            Case 6
                MedPad.JButtons.Text = "C"

'V
            Case 25
                MedPad.JButtons.Text = "V"

'B
            Case 5
                MedPad.JButtons.Text = "B"

'N
            Case 17
                MedPad.JButtons.Text = "N"

'M
            Case 16
                MedPad.JButtons.Text = "M"

'Backslash
            Case 49
                MedPad.JButtons.Text = "\"

'Back
            Case 42
                MedPad.JButtons.Text = "BACK"

'Tab
            Case 43
                MedPad.JButtons.Text = "TAB"

'Return
            Case 40
                MedPad.JButtons.Text = "RETURN"

'Capital
            Case 57
                MedPad.JButtons.Text = "CAPS"

'[
            Case 47
                MedPad.JButtons.Text = "["

']
            Case 48
                MedPad.JButtons.Text = "]"

';
            Case 51
                MedPad.JButtons.Text = ";"

'tilde
            Case 100
                MedPad.JButtons.Text = "~"

''
            Case 52
                MedPad.JButtons.Text = "'"

'ShiftKey
            Case 225
                MedPad.JButtons.Text = "SHIFT"

'Bracket
            Case 47
                MedPad.JButtons.Text = "BRACKET"

'comma
            Case 54
                MedPad.JButtons.Text = ","

'Period
            Case 55
                MedPad.JButtons.Text = "."

'Question
            Case 191
                'sdl =

'ControlKey
            Case 224
                MedPad.JButtons.Text = "CTRL"

'LWin
            Case 227
                MedPad.JButtons.Text = "LWIN"

'Alt
            Case 226
                MedPad.JButtons.Text = "ALT"

'Space
            Case 44
                MedPad.JButtons.Text = "SPACE"

'RWin
            Case 231
                MedPad.JButtons.Text = "RWIN"

'Apps
            Case 101
                'MedPad.JButtons.Text =

'PrintScreen
            Case 70
                MedPad.JButtons.Text = "PRINT"

'Scroll
            Case 145
                MedPad.JButtons.Text = "SCROLL"

'Pause
            Case 72
                MedPad.JButtons.Text = "PAUSE"

'Insert
            Case 73
                MedPad.JButtons.Text = "INS"

'Home
            Case 74
                MedPad.JButtons.Text = "HOME"

'PageUp
            Case 75
                MedPad.JButtons.Text = "PAGEUP"

'PageDown
            Case 78
                MedPad.JButtons.Text = "PAGEDOWN"

'End
            Case 77
                MedPad.JButtons.Text = "END"

'Delete
            Case 76
                MedPad.JButtons.Text = "DEL"

'Up
            Case 82
                MedPad.JButtons.Text = "UP"

'Down
            Case 81
                MedPad.JButtons.Text = "DOWN"

'Left
            Case 80
                MedPad.JButtons.Text = "LEFT"

'Right
            Case 79
                MedPad.JButtons.Text = "RIGHT"

'SelectMedia
            Case 263
                MedPad.JButtons.Text = "SelectMedia"

'VolumeMute
            Case 262
                MedPad.JButtons.Text = "VolumeMute"

'VolumeDown
            Case 129
                MedPad.JButtons.Text = "VolumeDown"

'VolumeUp
            Case 128
                MedPad.JButtons.Text = "VolumeUp"

'MediaStop
            Case 260
                MedPad.JButtons.Text = "MediaStop"

'MediaPreviousTrack
            Case 259
                MedPad.JButtons.Text = "Previous"

'MediaPlayPause
            Case 261
                MedPad.JButtons.Text = "PlayPause"

'MediaNextTrack
            Case 258
                MedPad.JButtons.Text = "Next"

'LaunchMail
            Case 265
                MedPad.JButtons.Text = "Mail"

'BrowserHome
            Case 264
                MedPad.JButtons.Text = "Browser"

'LaunchApplication2
            Case 183
                'sdl =

'NumLock
            Case 83
                MedPad.JButtons.Text = "NUMLOCK"

'KP_0
            Case 98
                MedPad.JButtons.Text = "KEYPAD 0"

'KP_1
            Case 89
                MedPad.JButtons.Text = "KEYPAD 1"

'KP_2
            Case 90
                MedPad.JButtons.Text = "KEYPAD 2"

'KP_3
            Case 91
                MedPad.JButtons.Text = "KEYPAD 3"

'KP_4
            Case 92
                MedPad.JButtons.Text = "KEYPAD 4"

'KP_5
            Case 93
                MedPad.JButtons.Text = "KEYPAD 5"

'KP_6
            Case 94
                MedPad.JButtons.Text = "KEYPAD 6"

'KP_7
            Case 95
                MedPad.JButtons.Text = "KEYPAD 7"

'KP_8
            Case 96
                MedPad.JButtons.Text = "KEYPAD 8"

'KP_9
            Case 97
                MedPad.JButtons.Text = "KEYPAD 9"

'Divide
            Case 84
                MedPad.JButtons.Text = "KEYPAD /"

'Multiply
            Case 85
                MedPad.JButtons.Text = "KEYPAD *"

'Subtract
            Case 86
                MedPad.JButtons.Text = "KEYPAD -"

'Add
            Case 87
                MedPad.JButtons.Text = "KEYPAD +"

'Decimal
            Case 220
                MedPad.JButtons.Text = "KEYPAD ."

'Clear
            Case 156
                MedPad.JButtons.Text = "CLEAR"
            Case Else
                MedPad.JButtons.Text = ""
        End Select

    End Function

End Module
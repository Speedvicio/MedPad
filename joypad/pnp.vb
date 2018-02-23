Imports System.Management

Public Class pnp

    Public Shared Function GetUSBDevices() As List(Of USBDeviceInfo)
        Dim devices As New List(Of USBDeviceInfo)()

        Dim collection As ManagementObjectCollection
        Using searcher = New ManagementObjectSearcher("Select * From Win32_PnPEntity")
            collection = searcher.[Get]()
        End Using

        Dim count As Integer = 0
        Dim SplitId() As String
        For Each device In collection
            If (device.ToString.Contains("HID\\VID_")) And (device.ToString.Contains("IG_")) Then '
                devices.Add(New USBDeviceInfo(DirectCast(device.GetPropertyValue("DeviceID"), String), DirectCast(device.GetPropertyValue("PNPDeviceID"), String), DirectCast(device.GetPropertyValue("Description"), String)))

                gamepad = New SlimDX.XInput.Controller(count)
                If gamepad.IsConnected = True Then

                    If Not MedPad.ListBox1.Items.Contains("XInput Unknown " & gamepad.GetType.Name & " GUID " & gamepad.GetType.GUID.ToString & gamepad.GetHashCode) Then
                        MedPad.ListBox1.Items.Add("XInput Unknown " & gamepad.GetType.Name & " GUID " & gamepad.GetType.GUID.ToString & gamepad.GetHashCode)
                    End If
                    'MedPad.ListBox1.Items.Add("XInput Unknown " & gamepad.GetType.Name & " GUID " & gamepad.GetType.GUID.ToString)
                End If
                'SplitId = Split(devices.Item(count).DeviceID(), "&")
                'MedPad.ListBox3.Items.Add(devices.Item(count).Description() & " " & devices.Item(count).DeviceID())
                'MedPad.ListBox3.Items.Add(devices.Item(count).Description() & " " & SplitId(1).Replace("PID_", "") & " " & SplitId(0).Replace("HID\\VID_", ""))
                count += 1
            End If
        Next

        collection.Dispose()
        Return devices
    End Function

End Class
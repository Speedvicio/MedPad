Public Class USBDeviceInfo

    Public Sub New(deviceID As String, pnpDeviceID As String, description As String)
        Me.DeviceID = deviceID
        Me.PnpDeviceID = pnpDeviceID
        Me.Description = description
    End Sub

    Public Property DeviceID() As String
        Get
            Return m_DeviceID
        End Get
        Private Set(value As String)
            m_DeviceID = value
        End Set
    End Property

    Private m_DeviceID As String

    Public Property PnpDeviceID() As String
        Get
            Return m_PnpDeviceID
        End Get
        Private Set(value As String)
            m_PnpDeviceID = value
        End Set
    End Property

    Private m_PnpDeviceID As String

    Public Property Description() As String
        Get
            Return m_Description
        End Get
        Private Set(value As String)
            m_Description = value
        End Set
    End Property

    Private m_Description As String
End Class
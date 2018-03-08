Public Class objMapDrive

#Region "Variable"

    Private Shared _Username As String
    Private Shared _Password As String
    Public Shared WriteOnly Property Username As String
        Set(ByVal value As String)
            _Username = value
        End Set
    End Property
    Public Shared WriteOnly Property Password As String
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property

#End Region

#Region "Map Drive"

    ''' <summary>
    ''' Use Map Drive Ex. MapDrive(\\10.0.0.2\d$\Program, Z)
    ''' </summary>
    ''' <param name="PathServer"></param>
    ''' <param name="DriveMap"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function MapDrive(ByVal PathServer As String, ByVal DriveMap As String) As Boolean
        Dim objNetwork, ojbFSO
        ojbFSO = CreateObject("Scripting.FileSystemObject")
        If ojbFSO.FolderExists(PathServer) = False Then
            Threading.Thread.Sleep(1000)
            objNetwork = CreateObject("WScript.Network")
            On Error Resume Next
            objNetwork.MapNetworkDrive(DriveMap & ":", PathServer, False, _Username, _Password)
            If Err.Number <> 0 Then
                Err.Clear()
                ojbFSO = Nothing
                objNetwork = Nothing
                Return False
            Else
                ojbFSO = Nothing
                objNetwork = Nothing
                Return True
            End If
        Else
            Return True
        End If
    End Function

#End Region

End Class

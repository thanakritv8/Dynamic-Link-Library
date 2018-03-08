Imports System.Net
Imports System.IO

Public Class objFtp

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

#Region "FTP"

    ''' <summary>
    ''' Use upload file from ftp
    ''' </summary>
    ''' <param name="PathFile"></param>
    ''' <param name="PathServer"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UploadFile(ByVal PathFile As String, ByVal PathServer As String) As Boolean
        Try
            Dim ftpRequest As FtpWebRequest = CType(WebRequest.Create(PathServer), FtpWebRequest)   'Path Server
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile
            ftpRequest.Credentials = New NetworkCredential(_Username, _Password)  'user, pass
            Dim bytes() As Byte = System.IO.File.ReadAllBytes(PathFile) 'Path File
            ftpRequest.ContentLength = bytes.Length
            Using UploadStream As Stream = ftpRequest.GetRequestStream()
                UploadStream.Write(bytes, 0, bytes.Length)
                UploadStream.Close()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Use download file from ftp
    ''' </summary>
    ''' <param name="PathFile"></param>
    ''' <param name="PathServer"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DownloadFile(ByVal PathFile As String, ByVal PathServer As String) As Boolean
        Dim request As New WebClient()
        request.Credentials = New NetworkCredential(_Username, _Password) 'user, pass
        Dim bytes() As Byte = request.DownloadData(PathServer)
        Try
            Dim DownloadStream As FileStream = IO.File.Create(PathFile)
            DownloadStream.Write(bytes, 0, bytes.Length)
            DownloadStream.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Use delete file from ftp
    ''' </summary>
    ''' <param name="PathServer"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DeleteFile(ByVal PathServer As String) As Boolean
        Try
            Dim Request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create(PathServer), System.Net.FtpWebRequest)
            Request.Credentials = New System.Net.NetworkCredential(_Username, _Password)
            Request.Method = System.Net.WebRequestMethods.Ftp.DeleteFile
            Request.GetResponse()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region

End Class

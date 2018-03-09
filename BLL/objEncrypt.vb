Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Windows.Forms

Public Class objEncrypt

#Region "Encoder text"
    ''' <summary>
    ''' Get MD5
    ''' </summary>
    ''' <param name="strInput"></param>
    ''' <param name="strKey"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function MD5Hash(ByVal strInput As String, ByVal strKey As String) As String
        Dim md5 As MD5 = New MD5CryptoServiceProvider()
        Dim result As Byte()
        result = md5.ComputeHash(Encoding.ASCII.GetBytes(strInput & strKey))
        Dim strBuilder As New StringBuilder()
        For i As Integer = 0 To result.Length - 1
            strBuilder.Append(result(i).ToString("x2"))
        Next
        Return strBuilder.ToString
    End Function
#End Region

#Region "Encryption & Decryption file"

    Private Function AES_EncryptByte(ByVal input As Byte(), ByVal key As String) As Byte()
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim SHA256 As New System.Security.Cryptography.SHA256Cng
        Try
            AES.Key = SHA256.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(key))
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = input
            Return DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function AES_DecryptByte(ByVal input As Byte(), ByVal key As String) As Byte()
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim SHA256 As New System.Security.Cryptography.SHA256Cng
        Try
            AES.Key = SHA256.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(key))
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = input
            Return DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Encyrption file
    ''' </summary>
    ''' <param name="file"></param>
    ''' <param name="key"></param>
    ''' <remarks></remarks>
    Public Sub Encyrption(ByVal file As String, ByVal key As String)
        If My.Computer.FileSystem.FileExists(file) Then
            My.Computer.FileSystem.WriteAllBytes(file, AES_EncryptByte(My.Computer.FileSystem.ReadAllBytes(file), key), False)
        End If
    End Sub

    ''' <summary>
    ''' Decyrption file
    ''' </summary>
    ''' <param name="file"></param>
    ''' <param name="key"></param>
    ''' <remarks></remarks>
    Public Sub Decyrption(ByVal file As String, ByVal key As String)
        If My.Computer.FileSystem.FileExists(file) Then
            Dim DESDecrypter() As Byte = AES_DecryptByte(My.Computer.FileSystem.ReadAllBytes(file), key)
            If Not DESDecrypter Is Nothing Then
                My.Computer.FileSystem.WriteAllBytes(file, DESDecrypter, False)
            End If
        End If
    End Sub
#End Region

End Class

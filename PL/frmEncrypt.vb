Imports BLL
Public Class frmEncrypt

    Private Sub frmEncrypt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objEncrypt As objEncrypt = New objEncrypt
        Dim strInput As String = objEncrypt.MD5Hash("abcdefg", "Secrets")
        Dim a = Application.StartupPath
        'objEncrypt.Encyrption("D:\test1.xlsx", "1234")
        objEncrypt.Decyrption("D:\test1.xlsx", "1234")
    End Sub
End Class
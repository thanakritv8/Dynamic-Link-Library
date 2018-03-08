Imports BLL
Public Class frmFtp

    Private Sub btGetFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGetFile.Click
        Dim PathServer As String = "ftp://" 'Simple ftp://10.0.0.1/Folder/
        Dim dialog = New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog() Then
            Dim objFtp As objFtp = New objFtp
            Dim bUpload As Boolean = objFtp.UploadFile(dialog.FileName, PathServer & dialog.SafeFileName)
            If bUpload Then
                MsgBox("Upload Complete", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Upload Incomplete", MsgBoxStyle.Critical, "Information")
            End If
        End If
    End Sub

    Private Sub btDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDownload.Click
        Dim Filename As String = "Pic.png"
        Dim PathServer As String = "ftp://" 'Simple "ftp://10.0.0.1/Folder/" & Filename
        Dim dialog = New FolderBrowserDialog()
        If DialogResult.OK = dialog.ShowDialog() Then
            Dim objFtp As objFtp = New objFtp
            Dim bDownload As Boolean = objFtp.DownloadFile(dialog.SelectedPath & "\" & Filename, PathServer)
            If bDownload Then
                MsgBox("Download Complete", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Download Incomplete", MsgBoxStyle.Critical, "Information")
            End If
        End If
    End Sub

    Private Sub btDeiete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDeiete.Click
        If MsgBox("You want delete file ?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
            Dim PathServer As String = "ftp://" 'Simple "ftp://10.0.0.1/Folder/" & Filename
            Dim objFtp As objFtp = New objFtp
            Dim bDownload As Boolean = objFtp.DeleteFile(PathServer)
            If bDownload Then
                MsgBox("Delete Done", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Deleted is not finished.", MsgBoxStyle.Critical, "Information")
            End If
        End If

    End Sub

    Private Sub PL_Ftp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objFtp.Username = ""
        objFtp.Password = ""
    End Sub

End Class

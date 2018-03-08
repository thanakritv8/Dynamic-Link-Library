Imports BLL
Public Class frmMapDrive

    Private Sub frmMapDrive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objMapDrive.Username = ""
        objMapDrive.Password = ""
    End Sub

    Private Sub btMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMap.Click
        Dim PathServer As String = ""
        Dim MapDrive As String = ""
        Dim objMapDrive As objMapDrive = New objMapDrive
        If objMapDrive.MapDrive(PathServer, MapDrive) Then
            MsgBox("Map Complete", MsgBoxStyle.Information, "Information")
        Else
            MsgBox("Map Incomplete", MsgBoxStyle.Critical, "Information")
        End If
    End Sub
End Class
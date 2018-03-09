Imports BLL
Public Class frmText

    Private Sub frmText_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objText As objText = New objText
        objText.CreateFile("D:/text1.txt")
        objText.WriteFile("D:/text1.txt", "TEST")
        Dim lsText As List(Of String) = objText.ReadLine("D:/text1.txt")
        objText.OpenFile("D:/text1.txt")
    End Sub
End Class
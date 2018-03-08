Imports BLL
Public Class frmPicDiff

    Private Sub btPicA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPicA.Click
        Dim openfile As New OpenFileDialog
        If openfile.ShowDialog = Windows.Forms.DialogResult.OK Then
            picA.Image = Image.FromFile(openfile.FileName)
        End If
    End Sub

    Private Sub btPicB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPicB.Click
        Dim openfile As New OpenFileDialog
        If openfile.ShowDialog = Windows.Forms.DialogResult.OK Then
            picB.Image = Image.FromFile(openfile.FileName)
        End If
    End Sub

    Private Sub btDiff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDiff.Click
        ' Load the images.
        Cursor = Cursors.WaitCursor
        Application.DoEvents()
        Dim bmPicA As New Bitmap(picA.Image)
        Dim bmPicB As New Bitmap(picB.Image)
        Dim objPicdiff As objPicDiff = New objPicDiff
        picDiff.Image = objPicdiff.DiffPic(bmPicA, bmPicB)
        bmPicA.Dispose()
        bmPicB.Dispose()
        Cursor = Cursors.Default
    End Sub

    Private Sub frmPicDiff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
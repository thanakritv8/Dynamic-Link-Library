Imports System.Drawing
Public Class objPicDiff

    ''' <summary>
    ''' Find the difference
    ''' </summary>
    ''' <param name="bmPicA"></param>
    ''' <param name="bmPicB"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DiffPic(ByVal bmPicA As Bitmap, ByVal bmPicB As Bitmap) As Bitmap
        ' Make a difference image.
        Dim wid As Integer = Math.Min(bmPicA.Width, bmPicB.Width)
        Dim hgt As Integer = Math.Min(bmPicA.Height, bmPicB.Height)
        Dim bmPicDiff As New Bitmap(wid, hgt)

        ' Create the difference image.
        Dim eq_color As Color = Color.White
        Dim ng_color As Color = Color.Red
        For x As Integer = 0 To wid - 1
            For y As Integer = 0 To hgt - 1
                If bmPicA.GetPixel(x, y).Equals(bmPicB.GetPixel(x, y)) Then
                    bmPicDiff.SetPixel(x, y, eq_color)
                Else
                    bmPicDiff.SetPixel(x, y, ng_color)
                End If
            Next
        Next
        Return bmPicDiff
    End Function
End Class

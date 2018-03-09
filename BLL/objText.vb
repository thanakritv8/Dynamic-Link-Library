Imports System.IO

Public Class objText

    ''' <summary>
    ''' Read text line
    ''' </summary>
    ''' <param name="Path"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ReadLine(ByVal Path As String) As List(Of String)
        Dim lsLine As New List(Of String)
        Dim line As String = String.Empty
        Using reader As StreamReader = New StreamReader(Path)
            Do While (Not line Is Nothing)
                line = reader.ReadLine
                If Not line Is Nothing Then
                    lsLine.Add(line)
                End If
            Loop
        End Using
        Return lsLine
    End Function

    ''' <summary>
    ''' Create text file
    ''' </summary>
    ''' <param name="Path"></param>
    ''' <remarks></remarks>
    Public Sub CreateFile(ByVal Path As String)
        If Not System.IO.File.Exists(Path) Then
            System.IO.File.Create(Path).Dispose()
        End If
    End Sub

    ''' <summary>
    ''' Write text file
    ''' </summary>
    ''' <param name="Path"></param>
    ''' <param name="InputText"></param>
    ''' <remarks></remarks>
    Public Sub WriteFile(ByVal Path As String, ByVal InputText As String)
        Dim sr As New StreamReader(Path)
        Dim text As String = sr.ReadToEnd()
        sr.Close()
        Dim sw As New StreamWriter(Path)
        sw.Write(Mid(text, 1, text.Length))
        sw.WriteLine(InputText)
        sw.Close()
    End Sub

    ''' <summary>
    ''' Open text file
    ''' </summary>
    ''' <param name="Path"></param>
    ''' <remarks></remarks>
    Public Sub OpenFile(ByVal Path As String)
        If System.IO.File.Exists(Path) = True Then
            Process.Start(Path)
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub

End Class

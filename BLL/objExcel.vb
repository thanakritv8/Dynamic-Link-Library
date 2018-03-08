Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Windows.Forms
Public Class objExcel

    Public Sub WriteDgvToExcel(ByVal Path As String, ByVal Sheet As String, ByVal dgv As DataGridView)
        Dim ex As Excel.Application = New Excel.Application
        Dim w As Excel.Workbook = ex.Workbooks.Open(Path)
        Dim s As Excel.Worksheet = w.Sheets(Sheet)
        For _c As Integer = 0 To dgv.Columns.Count - 1
            s.Cells(1, _c + 1).Value = dgv.Columns(_c).DataPropertyName
        Next
        For _r As Integer = 0 To dgv.Rows.Count - 1
            For _c As Integer = 0 To dgv.Columns.Count - 1
                s.Cells(_r + 2, _c + 1).Value = dgv.Rows(_r).Cells(_c).Value.ToString
            Next
        Next
        w.Save()
        w.Close()
        ex.Quit()
    End Sub

    Public Function WriteDataToExcel()

    End Function

End Class

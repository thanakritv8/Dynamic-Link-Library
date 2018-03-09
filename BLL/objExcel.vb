Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Windows.Forms
Public Class objExcel

    ''' <summary>
    ''' Write DataGridview to excel
    ''' </summary>
    ''' <param name="Path"></param>
    ''' <param name="Sheet"></param>
    ''' <param name="dgv"></param>
    ''' <remarks></remarks>
    Public Sub WriteDgvToExcel(ByVal Path As String, ByVal Sheet As String, ByVal dgv As DataGridView)
        Dim xlApp As Excel.Application = New Excel.Application
        Dim xlWorkbook As Excel.Workbook = xlApp.Workbooks.Open(Path)
        Dim xlWorksheet As Excel.Worksheet = xlWorkbook.Sheets(Sheet)
        For _c As Integer = 0 To dgv.Columns.Count - 1
            xlWorksheet.Cells(1, _c + 1).Value = dgv.Columns(_c).HeaderText
        Next
        For _r As Integer = 0 To dgv.Rows.Count - 1
            For _c As Integer = 0 To dgv.Columns.Count - 1
                xlWorksheet.Cells(_r + 2, _c + 1).Value = dgv.Rows(_r).Cells(_c).Value.ToString
            Next
        Next
        xlWorkbook.Save()
        xlWorkbook.Close()
        xlApp.Quit()
    End Sub

    ''' <summary>
    ''' Write input to excel
    ''' </summary>
    ''' <param name="Path"></param>
    ''' <param name="Sheet"></param>
    ''' <param name="InputText"></param>
    ''' <param name="iRow"></param>
    ''' <param name="iCol"></param>
    ''' <remarks></remarks>
    Public Sub WriteInputToExcel(ByVal Path As String, ByVal Sheet As String, ByVal InputText As String, ByVal iRow As Integer, ByVal iCol As Integer)
        Dim xlApp As Excel.Application = New Excel.Application
        Dim xlWorkbook As Excel.Workbook = xlApp.Workbooks.Open(Path)
        Dim xlWorksheet As Excel.Worksheet = xlWorkbook.Sheets(Sheet)
        xlWorksheet.Cells(iRow, iCol).Value = InputText
        xlWorkbook.Save()
        xlWorkbook.Close()
        xlApp.Quit()
    End Sub

    ''' <summary>
    ''' Create file excel
    ''' </summary>
    ''' <param name="Path"></param>
    ''' <remarks></remarks>
    Public Sub CreateExcel(ByVal Path As String)
        Dim xlApp As New Excel.Application
        Dim xlWorkbook As Excel.Workbook = xlApp.Workbooks.Add()
        Dim xlWorksheet As Excel.Worksheet = CType(xlWorkbook.Sheets("sheet1"), Excel.Worksheet)

        xlWorksheet.SaveAs(Path)
        xlWorkbook.Close()
        xlApp.Quit()

        xlApp = Nothing
        xlWorkbook = Nothing
        xlWorksheet = Nothing
    End Sub

    ''' <summary>
    ''' Open file excel
    ''' </summary>
    ''' <param name="_Path"></param>
    ''' <remarks></remarks>
    Public Sub OpenExcel(ByVal _Path As String)
        Dim xlApp As New Excel.Application
        Dim xlWorkbook As Excel.Workbook
        xlWorkbook = xlApp.Workbooks.Open(_Path)
        xlApp.Visible = True
        xlWorkbook.Activate()
    End Sub

End Class

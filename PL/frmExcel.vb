Imports BLL
Public Class frmExcel

    Private Sub frmExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvEmp.Rows.Add("1", "Jong", "Gana", "Jong@gmail.com", "123456", "999/1", "08145789654")
        dgvEmp.Rows.Add("2", "Win", "Desel", "Win@gmail.com", "789456", "999/2", "08145789655")
        dgvEmp.Rows.Add("3", "Worm", "Jaidee", "Worm@gmail.com", "147852", "999/3", "08145789656")
        dgvEmp.Rows.Add("4", "Takky", "Malong", "Takky@gmail.com", "369852", "999/4", "08145789657")
        dgvEmp.Rows.Add("5", "Ball", "Freebey", "Jong@gmail.com", "159632", "999/5", "08145789658")
    End Sub

    Private Sub btWriteDgv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btWriteDgv.Click
        Dim Path As String = "D:\test1.xlsx"
        Dim Sheet As String = "sheet1"
        Dim objExcel As objExcel = New objExcel
        objExcel.WriteDgvToExcel(Path, Sheet, dgvEmp)
    End Sub

    Private Sub btCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCreate.Click
        Dim Path As String = "D:\test1.xlsx"
        Dim objExcel As objExcel = New objExcel
        objExcel.CreateExcel(Path)
    End Sub

    Private Sub btOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOpen.Click
        Dim Path As String = "D:\test1.xlsx"
        Dim objExcel As objExcel = New objExcel
        objExcel.OpenExcel(Path)
    End Sub

    Private Sub btInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btInput.Click
        Dim _Input As String = InputBox("Send Input To Excel", "Input")
        Dim Path As String = "D:\test1.xlsx"
        Dim Sheet As String = "sheet1"
        Dim objExcel As objExcel = New objExcel
        objExcel.WriteInputToExcel(Path, Sheet, _Input, 1, 1)
    End Sub
End Class
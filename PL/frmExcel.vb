Imports BLL
Public Class frmExcel

    Private Sub frmExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvEmp.Rows.Add("1", "Jong", "Gana", "Jong@gmail.com", "123456", "999/1", "08145789654")
        dgvEmp.Rows.Add("2", "Win", "Desel", "Win@gmail.com", "789456", "999/2", "08145789655")
        dgvEmp.Rows.Add("3", "Worm", "Jaidee", "Worm@gmail.com", "147852", "999/3", "08145789656")
        dgvEmp.Rows.Add("4", "Takky", "Malong", "Takky@gmail.com", "369852", "999/4", "08145789657")
        dgvEmp.Rows.Add("5", "Ball", "Freebey", "Jong@gmail.com", "159632", "999/5", "08145789658")
    End Sub

    Private Sub btExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExport.Click
        Dim objExcel As objExcel = New objExcel
        objExcel.WriteDgvToExcel("", "", dgvEmp)
    End Sub
End Class
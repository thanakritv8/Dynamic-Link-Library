Imports BLL
Imports System.Data.SqlClient

Public Class frmDB

    Private Sub frmDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As SqlConnection
        con = objDB.ConnectDB("10.0.0.2", "", "")

        Dim _SQL As String = "Select * From nametable"
        dgv.DataSource = objDB.SelectSQL(_SQL, con)
        _SQL = "Insert into nametable ....."
        If objDB.ExecuteSQL(_SQL, con) Then
            'Insert Success
        End If
        objDB.DisconnectDB(con)
    End Sub
End Class
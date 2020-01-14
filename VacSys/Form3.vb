Imports System.Data.OleDb
Public Class Form3
    Dim code3 As String = Form1.TextBox1.Text
    Dim cna As OleDbConnection
    Dim cma As OleDbCommand
    Dim daa As OleDbDataAdapter
    Dim dsa As DataSet
    Dim cnb As OleDbConnection
    Dim cmb As OleDbCommand
    Dim dab As OleDbDataAdapter
    Dim dsb As DataSet
    Private Sub exit3_Click(sender As Object, e As EventArgs) Handles exit3.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cna = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        daa = New OleDbDataAdapter("select * from Patients where 患者编号='" & code3 & "'", cna)
        dsa = New DataSet
        daa.Fill(dsa, "Patients")
        selfdata3.DataSource = dsa.Tables("Patients")
        cnb = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        dab = New OleDbDataAdapter("select 疫苗名称 from Vac,Patients where Patients.患者编号='" & code3 & "' AND Patients.年龄>Vac.适用年龄开始 AND Patients.年龄 < Vac.适用年龄结束", cnb)
        dsb = New DataSet
        dab.Fill(dsb, "Vac")
        vacuse3.DataSource = dsb.Tables("Vac")
    End Sub
End Class
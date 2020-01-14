Imports System.Data.OleDb
Public Class Form2
    Dim code2 As String = Form1.TextBox1.Text
    Dim cna As OleDbConnection
    Dim cma As OleDbCommand
    Dim daa As OleDbDataAdapter
    Dim dsa As DataSet
    Dim cnb As OleDbConnection
    Dim cmb As OleDbCommand
    Dim dab As OleDbDataAdapter
    Dim dsb As DataSet
    Dim cnc As OleDbConnection
    Dim cmc As OleDbCommand
    Dim dac As OleDbDataAdapter
    Dim dsc As DataSet
    Dim cnd As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dad As OleDbDataAdapter
    Dim dsd As DataSet
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cna = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        daa = New OleDbDataAdapter("select * from Doctor where 医师编号 = '" & code2 & "'", cna)
        dsa = New DataSet
        daa.Fill(dsa, "Doctor")
        selfdata2.DataSource = dsa.Tables("Doctor")
        cnb = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        dab = New OleDbDataAdapter("select * from Company where 单位编号 in (select 工作单位编号 from Doctor where 医师编号 = '" & code2 & "')", cnb)
        dsb = New DataSet
        dab.Fill(dsb, "Company")
        workdata2.DataSource = dsb.Tables("Company")
        cnc = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        dac = New OleDbDataAdapter("(select * from Vac where 疫苗编号 in (select 疫苗编号 from VacBuy where 买家编号 in (select 工作单位编号 from Doctor where 医师编号='" & code2 & "'))) UNION  (select * from Vac where 疫苗编号 in (select 疫苗编号 from VacGiv where 接收方编号 in (select 工作单位编号 from Doctor where 医师编号='" & code2 & "')))", cna)
        dsc = New DataSet
        dac.Fill(dsa, "Vac")
        vacnow2.DataSource = dsa.Tables("Vac")
    End Sub

    Private Sub exit2_Click(sender As Object, e As EventArgs) Handles exit2.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub getvac2_Click(sender As Object, e As EventArgs) Handles getvac2.Click
        Dim Name As String = TextBox1.Text
        Dim Vac As String = TextBox2.Text
        If Name = "" Or Vac = "" Then
            MessageBox.Show("字段未填写，请再次填写")
            Exit Sub
        End If
        cnd = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\DBex2_1.mdb;Persist Security Info=False")
        cnd.Open()
        Dim sql As String = "insert into lyb (Name,Vac) values ( ' " & Name & " ' , ' " & Vac & " ' ) "
        cmd = New OleDbCommand(sql, cnd)
        cmd.ExecuteNonQuery()
        cnd.Close()
        MessageBox.Show("申请成功！！！")
    End Sub
End Class
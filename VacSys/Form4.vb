Imports System.Data.OleDb
Public Class Form4
    Dim code4 As String = Form1.TextBox1.Text
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
    Dim cne As OleDbConnection
    Dim cme As OleDbCommand
    Dim dae As OleDbDataAdapter
    Dim dse As DataSet
    Dim cnf As OleDbConnection
    Dim cmf As OleDbCommand
    Dim daf As OleDbDataAdapter
    Dim dsf As DataSet
    Dim cng As OleDbConnection
    Dim cmg As OleDbCommand
    Dim dag As OleDbDataAdapter
    Dim dsg As DataSet
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cna = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        daa = New OleDbDataAdapter("select * from Chemers where 药厂技师编号 = '" & code4 & "'", cna)
        dsa = New DataSet
        daa.Fill(dsa, "Chemers")
        selfdata4.DataSource = dsa.Tables(0)
        cnb = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        dab = New OleDbDataAdapter("select * from Company where 单位编号 in (select 工作单位编号 from Chemers where 药厂技师编号 = '" & code4 & "')", cnb)
        dsb = New DataSet
        dab.Fill(dsb, "Company")
        workdata4.DataSource = dsb.Tables(0)
        cnc = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        dac = New OleDbDataAdapter("select * from Vac where 疫苗编号 in (select 疫苗编号 from VacPro where 生产方编号 in ( select 工作单位编号 from Chemers where 药厂技师编号 = '" & code4 & "'))", cnc)
        dsc = New DataSet
        dac.Fill(dsc, "Vac")
        DataGridView1.DataSource = dsc.Tables(0)
        cnd = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\DBex2_1.mdb;Persist Security Info=False")
        dad = New OleDbDataAdapter("select * from lyb", cnd)
        dsd = New DataSet
        dad.Fill(dsd, "lyb")
        DataGridView2.DataSource = dsd.Tables(0)
    End Sub

    Private Sub exit4_Click(sender As Object, e As EventArgs) Handles exit4.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cnc = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        dac = New OleDbDataAdapter("select * from Vac where 疫苗编号 in (select 疫苗编号 from VacPro where 生产方编号 in ( select 工作单位编号 from Chemers where 药厂技师编号 = '" & code4 & "'))", cnc)
        dsc = New DataSet
        dac.Fill(dsc, "Vac")
        DataGridView1.DataSource = dsc.Tables(0)
        cnd = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\DBex2_1.mdb;Persist Security Info=False")
        dad = New OleDbDataAdapter("select * from lyb", cnd)
        dsd = New DataSet
        dad.Fill(dsd, "lyb")
        DataGridView2.DataSource = dsd.Tables(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prono As String = TextBox1.Text
        Dim proer As String = TextBox2.Text
        Dim vacno As String = TextBox3.Text
        If prono = "" Or proer = "" Or vacno = "" Then
            MessageBox.Show("字段未填写，请再次填写")
            Exit Sub
        End If
        cne = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        cne.Open()
        Dim sql As String = "insert into VacPro (生产编号,生产方编号,疫苗编号) values ( '" & prono & "' , '" & proer & "' , '" & vacno & "' ) "
        cme = New OleDbCommand(sql, cne)
        cme.ExecuteNonQuery()
        cne.Close()
        MessageBox.Show("制造成功！！！")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim delevacno As String = TextBox4.Text
        If delevacno = "" Then
            MessageBox.Show("请输入要删除的编号")
            Exit Sub
        End If
        cnf = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        cnf.Open()
        Dim sql As String = "delete from VacPro where 疫苗编号='" & delevacno & "' AND 生产方编号 in (select 工作单位编号 from Chemers where 药厂技师编号 = '" & code4 & "') "
        cmf = New OleDbCommand(sql, cnf)
        cmf.ExecuteNonQuery()
        cnf.Close()
        MessageBox.Show("删除成功！！！")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim deleno As String = TextBox5.Text
        If deleno = "" Then
            MessageBox.Show("请输入要删除的编号")
            Exit Sub
        End If
        cng = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\DBex2_1.mdb;Persist Security Info=False")
        cng.Open()
        Dim sql As String = "delete from lyb where ID = " & deleno & " "
        cmg = New OleDbCommand(sql, cng)
        cmg.ExecuteNonQuery()
        cng.Close()
        MessageBox.Show("删除成功！！！")
    End Sub
End Class
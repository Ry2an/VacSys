Imports System.Data.OleDb
Public Class Form5
    Dim code5 As String = Form1.TextBox1.Text
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
    Dim cnh As OleDbConnection
    Dim cmh As OleDbCommand
    Dim dah As OleDbDataAdapter
    Dim dsh As DataSet
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cna = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        daa = New OleDbDataAdapter("select * from Cdcers where CDC工作人员编号= '" & code5 & "'", cna)
        dsa = New DataSet
        daa.Fill(dsa, "Doctor")
        selfdata5.DataSource = dsa.Tables(0)
        cnb = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        dab = New OleDbDataAdapter("select * from Company where 单位编号 in (select 工作单位编号 from Cdcers where CDC工作人员编号 = '" & code5 & "')", cnb)
        dsb = New DataSet
        dab.Fill(dsb, "Company")
        workdata5.DataSource = dsb.Tables(0)
        cnd = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\DBex2_1.mdb;Persist Security Info=False")
        dad = New OleDbDataAdapter("select * from lyb", cnd)
        dsd = New DataSet
        dad.Fill(dsd, "lyb")
        DataGridView3.DataSource = dsd.Tables(0)
        cne = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        dae = New OleDbDataAdapter("select * from VacGiv where 给予方编号 in (select 工作单位编号 from Cdcers where CDC工作人员编号 = '" & code5 & "')", cne)
        dse = New DataSet
        dae.Fill(dse, "VacGiv")
        vacgiv.DataSource = dse.Tables(0)
        cnf = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        daf = New OleDbDataAdapter("select * from VacBuy where 买家编号 in (select 工作单位编号 from Cdcers where CDC工作人员编号 = '" & code5 & "')", cnf)
        dsf = New DataSet
        daf.Fill(dsf, "VacBuy")
        vacbuy.DataSource = dsf.Tables(0)
    End Sub

    Private Sub exit5_Click(sender As Object, e As EventArgs) Handles exit5.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub getvac5_Click(sender As Object, e As EventArgs) Handles getvac5.Click
        Dim Name As String = TextBox1.Text
        Dim Vac As String = TextBox2.Text
        If Name = "" Or Vac = "" Then
            MessageBox.Show("字段未填写，请再次填写")
            Exit Sub
        End If
        cnc = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\DBex2_1.mdb;Persist Security Info=False")
        cnc.Open()
        Dim sql As String = "insert into lyb (Name,Vac) values ( ' " & Name & " ' , ' " & Vac & " ' ) "
        cmc = New OleDbCommand(sql, cnc)
        cmc.ExecuteNonQuery()
        cnc.Close()
        MessageBox.Show("申请成功！！！")
    End Sub

    Private Sub flash_Click(sender As Object, e As EventArgs) Handles flash.Click
        cnd = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\DBex2_1.mdb;Persist Security Info=False")
        dad = New OleDbDataAdapter("select * from lyb", cnd)
        dsd = New DataSet
        dad.Fill(dsd, "lyb")
        DataGridView3.DataSource = dsd.Tables(0)
        cne = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        dae = New OleDbDataAdapter("select * from VacGiv where 给予方编号 in (select 工作单位编号 from Cdcers where CDC工作人员编号 = '" & code5 & "')", cne)
        dse = New DataSet
        dae.Fill(dse, "VacGiv")
        vacgiv.DataSource = dse.Tables(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim givno As String = TextBox3.Text
        Dim giverno As String = TextBox4.Text
        Dim gived As String = TextBox5.Text
        Dim vacno As String = TextBox6.Text
        If givno = "" Or giverno = "" Or vacno = "" Or gived = "" Then
            MessageBox.Show("字段未填写，请再次填写")
            Exit Sub
        End If
        cng = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        cng.Open()
        Dim sql As String = "insert into VacGiv (分发编号,给予方编号,接收方编号,疫苗编号) values ( '" & givno & "' , '" & giverno & "' , '" & gived & "' , '" & vacno & "') "
        cmg = New OleDbCommand(sql, cng)
        cmg.ExecuteNonQuery()
        cng.Close()
        MessageBox.Show("分发成功！！！")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim delegivno As String = TextBox7.Text
        If delegivno = "" Then
            MessageBox.Show("请输入要删除的编号")
            Exit Sub
        End If
        cnf = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        cnf.Open()
        Dim sql As String = "delete from VacGiv where 分发编号='" & delegivno & "'"
        cmf = New OleDbCommand(sql, cnf)
        cmf.ExecuteNonQuery()
        cnf.Close()
        MessageBox.Show("删除成功！！！")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim deleno As String = TextBox8.Text
        If deleno = "" Then
            MessageBox.Show("请输入要删除的编号")
            Exit Sub
        End If
        cnh = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\DBex2_1.mdb;Persist Security Info=False")
        cnh.Open()
        Dim sql As String = "delete from lyb where ID = " & deleno & " "
        cmh = New OleDbCommand(sql, cnh)
        cmh.ExecuteNonQuery()
        cnh.Close()
        MessageBox.Show("删除成功！！！")
    End Sub
End Class
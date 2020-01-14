Imports System.Data.OleDb
Public Class Form6
    Dim code6 As String = Form1.TextBox1.Text
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
    Dim cni As OleDbConnection
    Dim cmi As OleDbCommand
    Dim dai As OleDbDataAdapter
    Dim dsi As DataSet
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cna = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        daa = New OleDbDataAdapter("select * from Sellers where 销售人员编号 = '" & code6 & "'", cna)
        dsa = New DataSet
        daa.Fill(dsa, "Sellers")
        selfdata6.DataSource = dsa.Tables(0)
        cnb = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        dab = New OleDbDataAdapter("select * from Company where 单位编号 in (select 工作单位编号 from Sellers where 销售人员编号 = '" & code6 & "')", cnb)
        dsb = New DataSet
        dab.Fill(dsb, "Company")
        workdata6.DataSource = dsb.Tables(0)
        cnc = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        dac = New OleDbDataAdapter("select * from VacBuy where 买家编号 in (select 工作单位编号 from Sellers where 销售人员编号 = '" & code6 & "')", cnb)
        dsc = New DataSet
        dac.Fill(dsc, "VacBuy")
        DataGridView1.DataSource = dsc.Tables(0)
        cnd = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        dad = New OleDbDataAdapter("select * from VacBuy where 卖家编号 in (select 工作单位编号 from Sellers where 销售人员编号 = '" & code6 & "')", cnb)
        dsd = New DataSet
        dad.Fill(dsd, "VacBuy")
        DataGridView2.DataSource = dsd.Tables(0)
        cne = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\DBex2_1.mdb;Persist Security Info=False")
        dae = New OleDbDataAdapter("select * from lyb", cne)
        dse = New DataSet
        dae.Fill(dse, "lyb")
        DataGridView3.DataSource = dse.Tables(0)
    End Sub

    Private Sub exit6_Click(sender As Object, e As EventArgs) Handles exit6.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cnc = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        dac = New OleDbDataAdapter("select * from VacBuy where 买家编号 in (select 工作单位编号 from Sellers where 销售人员编号 = '" & code6 & "')", cnb)
        dsc = New DataSet
        dac.Fill(dsc, "VacBuy")
        DataGridView1.DataSource = dsc.Tables(0)
        cnd = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        dad = New OleDbDataAdapter("select * from VacBuy where 卖家编号 in (select 工作单位编号 from Sellers where 销售人员编号 = '" & code6 & "')", cnb)
        dsd = New DataSet
        dad.Fill(dsd, "VacBuy")
        DataGridView2.DataSource = dsd.Tables(0)
        cne = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\DBex2_1.mdb;Persist Security Info=False")
        dae = New OleDbDataAdapter("select * from lyb", cne)
        dse = New DataSet
        dae.Fill(dse, "lyb")
        DataGridView3.DataSource = dse.Tables(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sellno As String = TextBox1.Text
        Dim vacno As String = TextBox2.Text
        Dim seller As String = TextBox3.Text
        Dim buyer As String = TextBox4.Text
        If sellno = "" Or vacno = "" Or seller = "" Or buyer = "" Then
            MessageBox.Show("字段未填写，请再次填写")
            Exit Sub
        End If
        cnf = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        cnf.Open()
        Dim sql As String = "insert into VacBuy (交易编号,疫苗编号,卖家编号,买家编号) values ( '" & sellno & "' , '" & vacno & "' , '" & seller & "' , '" & buyer & "') "
        cmf = New OleDbCommand(sql, cnf)
        cmf.ExecuteNonQuery()
        cnf.Close()
        MessageBox.Show("买卖成功！！！")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim deleselno As String = TextBox5.Text
        If deleselno = "" Then
            MessageBox.Show("请输入要删除的编号")
            Exit Sub
        End If
        cng = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\VaccineProductDB.mdb;Persist Security Info=False")
        cng.Open()
        Dim sql As String = "delete from VacBuy where 交易编号='" & deleselno & "'"
        cmg = New OleDbCommand(sql, cng)
        cmg.ExecuteNonQuery()
        cng.Close()
        MessageBox.Show("删除成功！！！")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Name As String = TextBox6.Text
        Dim Vac As String = TextBox7.Text
        If Name = "" Or Vac = "" Then
            MessageBox.Show("字段未填写，请再次填写")
            Exit Sub
        End If
        cnh = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\DBex2_1.mdb;Persist Security Info=False")
        cnh.Open()
        Dim sql As String = "insert into lyb (Name,Vac) values ( ' " & Name & " ' , ' " & Vac & " ' ) "
        cmh = New OleDbCommand(sql, cnh)
        cmh.ExecuteNonQuery()
        cnh.Close()
        MessageBox.Show("申请成功！！！")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim deleno As String = TextBox8.Text
        If deleno = "" Then
            MessageBox.Show("请输入要删除的编号")
            Exit Sub
        End If
        cni = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\VacSys\DBex2_1.mdb;Persist Security Info=False")
        cni.Open()
        Dim sql As String = "delete from lyb where ID = " & deleno & " "
        cmi = New OleDbCommand(sql, cni)
        cmi.ExecuteNonQuery()
        cni.Close()
        MessageBox.Show("删除成功！！！")
    End Sub
End Class
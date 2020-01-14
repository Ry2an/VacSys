<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.exit2 = New System.Windows.Forms.Button()
        Me.selfdata2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.workdata2 = New System.Windows.Forms.DataGridView()
        Me.vacnow2 = New System.Windows.Forms.DataGridView()
        Me.getvac2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.selfdata2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.workdata2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vacnow2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exit2
        '
        Me.exit2.BackColor = System.Drawing.Color.DimGray
        Me.exit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exit2.Font = New System.Drawing.Font("微软雅黑", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.exit2.ForeColor = System.Drawing.Color.White
        Me.exit2.Location = New System.Drawing.Point(952, 12)
        Me.exit2.Name = "exit2"
        Me.exit2.Size = New System.Drawing.Size(100, 100)
        Me.exit2.TabIndex = 0
        Me.exit2.Text = "退出登录"
        Me.exit2.UseVisualStyleBackColor = False
        '
        'selfdata2
        '
        Me.selfdata2.BackgroundColor = System.Drawing.Color.DimGray
        Me.selfdata2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.selfdata2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.selfdata2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("微软雅黑", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.selfdata2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.selfdata2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.selfdata2.Location = New System.Drawing.Point(212, 123)
        Me.selfdata2.Name = "selfdata2"
        Me.selfdata2.RowTemplate.Height = 23
        Me.selfdata2.Size = New System.Drawing.Size(347, 85)
        Me.selfdata2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(66, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "个人信息"
        '
        'workdata2
        '
        Me.workdata2.BackgroundColor = System.Drawing.Color.DimGray
        Me.workdata2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.workdata2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.workdata2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("微软雅黑", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.workdata2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.workdata2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.workdata2.Location = New System.Drawing.Point(212, 214)
        Me.workdata2.Name = "workdata2"
        Me.workdata2.RowTemplate.Height = 23
        Me.workdata2.Size = New System.Drawing.Size(417, 95)
        Me.workdata2.TabIndex = 3
        '
        'vacnow2
        '
        Me.vacnow2.BackgroundColor = System.Drawing.Color.DimGray
        Me.vacnow2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.vacnow2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.vacnow2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.vacnow2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vacnow2.Location = New System.Drawing.Point(212, 315)
        Me.vacnow2.Name = "vacnow2"
        Me.vacnow2.RowTemplate.Height = 23
        Me.vacnow2.Size = New System.Drawing.Size(670, 198)
        Me.vacnow2.TabIndex = 4
        '
        'getvac2
        '
        Me.getvac2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.getvac2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.getvac2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.getvac2.ForeColor = System.Drawing.Color.White
        Me.getvac2.Location = New System.Drawing.Point(550, 556)
        Me.getvac2.Name = "getvac2"
        Me.getvac2.Size = New System.Drawing.Size(100, 30)
        Me.getvac2.TabIndex = 6
        Me.getvac2.Text = "申请"
        Me.getvac2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(212, 562)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 21)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(374, 562)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(140, 21)
        Me.TextBox2.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Location = New System.Drawing.Point(66, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 36)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "工作单位"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label3.Location = New System.Drawing.Point(12, 374)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 36)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "院内已有疫苗"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightPink
        Me.Label4.Location = New System.Drawing.Point(66, 547)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 36)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "疫苗申请"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label5.Location = New System.Drawing.Point(207, 533)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 26)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "申请人"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label6.Location = New System.Drawing.Point(369, 533)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 26)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "疫苗编号"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightPink
        Me.Label7.Location = New System.Drawing.Point(706, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(207, 50)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "医师，您好"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.getvac2)
        Me.Controls.Add(Me.vacnow2)
        Me.Controls.Add(Me.workdata2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.selfdata2)
        Me.Controls.Add(Me.exit2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "医师窗口"
        CType(Me.selfdata2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.workdata2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vacnow2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exit2 As Button
    Friend WithEvents selfdata2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents workdata2 As DataGridView
    Friend WithEvents vacnow2 As DataGridView
    Friend WithEvents getvac2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class

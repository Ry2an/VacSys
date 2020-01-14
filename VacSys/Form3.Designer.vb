<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.exit3 = New System.Windows.Forms.Button()
        Me.selfdata3 = New System.Windows.Forms.DataGridView()
        Me.vacuse3 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.selfdata3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vacuse3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exit3
        '
        Me.exit3.BackColor = System.Drawing.Color.DimGray
        Me.exit3.Font = New System.Drawing.Font("微软雅黑", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.exit3.ForeColor = System.Drawing.Color.White
        Me.exit3.Location = New System.Drawing.Point(934, 12)
        Me.exit3.Name = "exit3"
        Me.exit3.Size = New System.Drawing.Size(100, 100)
        Me.exit3.TabIndex = 0
        Me.exit3.Text = "退出登录"
        Me.exit3.UseVisualStyleBackColor = False
        '
        'selfdata3
        '
        Me.selfdata3.BackgroundColor = System.Drawing.Color.DimGray
        Me.selfdata3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.selfdata3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.selfdata3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.selfdata3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.selfdata3.GridColor = System.Drawing.Color.LightPink
        Me.selfdata3.Location = New System.Drawing.Point(285, 217)
        Me.selfdata3.Name = "selfdata3"
        Me.selfdata3.RowTemplate.Height = 23
        Me.selfdata3.Size = New System.Drawing.Size(591, 160)
        Me.selfdata3.TabIndex = 1
        '
        'vacuse3
        '
        Me.vacuse3.BackgroundColor = System.Drawing.Color.DimGray
        Me.vacuse3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.vacuse3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.vacuse3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.vacuse3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vacuse3.Location = New System.Drawing.Point(285, 403)
        Me.vacuse3.Name = "vacuse3"
        Me.vacuse3.RowTemplate.Height = 23
        Me.vacuse3.Size = New System.Drawing.Size(248, 198)
        Me.vacuse3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightPink
        Me.Label1.Location = New System.Drawing.Point(669, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 50)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "家长，您好"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Location = New System.Drawing.Point(60, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 36)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "儿童个人信息"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightPink
        Me.Label3.Location = New System.Drawing.Point(33, 403)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 36)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "需要注射的疫苗"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vacuse3)
        Me.Controls.Add(Me.selfdata3)
        Me.Controls.Add(Me.exit3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "免疫窗口"
        CType(Me.selfdata3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vacuse3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exit3 As Button
    Friend WithEvents selfdata3 As DataGridView
    Friend WithEvents vacuse3 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class

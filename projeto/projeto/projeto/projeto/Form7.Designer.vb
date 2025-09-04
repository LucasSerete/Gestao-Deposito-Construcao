<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cadastroprodutos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastroprodutos))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txt_precoc = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txt_precov = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_quant = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_salvar_edicao = New System.Windows.Forms.Button()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.txt_precoc)
        Me.Panel6.Location = New System.Drawing.Point(309, 96)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(197, 34)
        Me.Panel6.TabIndex = 66
        '
        'txt_precoc
        '
        Me.txt_precoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_precoc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precoc.Location = New System.Drawing.Point(19, 7)
        Me.txt_precoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_precoc.Name = "txt_precoc"
        Me.txt_precoc.Size = New System.Drawing.Size(173, 22)
        Me.txt_precoc.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.txt_precov)
        Me.Panel7.Location = New System.Drawing.Point(76, 96)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(197, 34)
        Me.Panel7.TabIndex = 65
        '
        'txt_precov
        '
        Me.txt_precov.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_precov.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precov.Location = New System.Drawing.Point(19, 7)
        Me.txt_precov.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_precov.Name = "txt_precov"
        Me.txt_precov.Size = New System.Drawing.Size(173, 22)
        Me.txt_precov.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txt_quant)
        Me.Panel3.Location = New System.Drawing.Point(541, 98)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(285, 34)
        Me.Panel3.TabIndex = 63
        '
        'txt_quant
        '
        Me.txt_quant.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_quant.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quant.Location = New System.Drawing.Point(19, 7)
        Me.txt_quant.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_quant.Name = "txt_quant"
        Me.txt_quant.Size = New System.Drawing.Size(228, 22)
        Me.txt_quant.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.cmb_categoria)
        Me.Panel2.Location = New System.Drawing.Point(908, 209)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(285, 34)
        Me.Panel2.TabIndex = 64
        '
        'cmb_categoria
        '
        Me.cmb_categoria.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(3, 2)
        Me.cmb_categoria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(279, 29)
        Me.cmb_categoria.TabIndex = 32
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txt_nome)
        Me.Panel1.Location = New System.Drawing.Point(76, 27)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(429, 34)
        Me.Panel1.TabIndex = 62
        '
        'txt_nome
        '
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(19, 7)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(317, 22)
        Me.txt_nome.TabIndex = 1
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_salvar.Location = New System.Drawing.Point(861, 64)
        Me.btn_salvar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(125, 38)
        Me.btn_salvar.TabIndex = 61
        Me.btn_salvar.Text = "SALVAR"
        Me.btn_salvar.UseVisualStyleBackColor = False
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_dados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Location = New System.Drawing.Point(364, 375)
        Me.dgv_dados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.RowHeadersWidth = 51
        Me.dgv_dados.Size = New System.Drawing.Size(1072, 341)
        Me.dgv_dados.TabIndex = 68
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.btn_salvar)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Location = New System.Drawing.Point(364, 181)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1071, 160)
        Me.Panel4.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 16)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Cadastro de Produtos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(371, 356)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Estoque"
        '
        'btn_salvar_edicao
        '
        Me.btn_salvar_edicao.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_salvar_edicao.Location = New System.Drawing.Point(1039, 544)
        Me.btn_salvar_edicao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_salvar_edicao.Name = "btn_salvar_edicao"
        Me.btn_salvar_edicao.Size = New System.Drawing.Size(125, 49)
        Me.btn_salvar_edicao.TabIndex = 68
        Me.btn_salvar_edicao.Text = "SALVAR ALTERAÇÕES"
        Me.btn_salvar_edicao.UseVisualStyleBackColor = False
        '
        'cadastroprodutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1800, 897)
        Me.Controls.Add(Me.btn_salvar_edicao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "cadastroprodutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estoque de Produtos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txt_precoc As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txt_precov As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_quant As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmb_categoria As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents btn_salvar As Button
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_salvar_edicao As Button
End Class

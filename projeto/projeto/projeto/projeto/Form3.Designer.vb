<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cadastro_usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastro_usuario))
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_cpf = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_cidade = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txt_cep = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txt_uf = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_data_nascimento = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txt_telefone = New System.Windows.Forms.TextBox()
        Me.btn_foto = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.btn_cadastro = New System.Windows.Forms.Button()
        Me.btn_salvar_edicao = New System.Windows.Forms.Button()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AllowUserToAddRows = False
        Me.dgv_clientes.AllowUserToDeleteRows = False
        Me.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Location = New System.Drawing.Point(525, 449)
        Me.dgv_clientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        Me.dgv_clientes.RowHeadersWidth = 51
        Me.dgv_clientes.Size = New System.Drawing.Size(727, 252)
        Me.dgv_clientes.TabIndex = 23
        '
        'img_foto
        '
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(384, 194)
        Me.img_foto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(150, 155)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_foto.TabIndex = 22
        Me.img_foto.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(736, 271)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 17)
        Me.Label5.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txt_nome)
        Me.Panel1.Location = New System.Drawing.Point(547, 194)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 34)
        Me.Panel1.TabIndex = 29
        '
        'txt_nome
        '
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(19, 7)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(319, 22)
        Me.txt_nome.TabIndex = 1
        '
        'txt_cpf
        '
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(19, 7)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cpf.MaxLength = 14
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(319, 22)
        Me.txt_cpf.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txt_cpf)
        Me.Panel2.Location = New System.Drawing.Point(547, 236)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(431, 34)
        Me.Panel2.TabIndex = 30
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.txt_cidade)
        Me.Panel4.Location = New System.Drawing.Point(547, 320)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(431, 34)
        Me.Panel4.TabIndex = 32
        '
        'txt_cidade
        '
        Me.txt_cidade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cidade.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cidade.Location = New System.Drawing.Point(19, 7)
        Me.txt_cidade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cidade.Name = "txt_cidade"
        Me.txt_cidade.Size = New System.Drawing.Size(319, 22)
        Me.txt_cidade.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.txt_cep)
        Me.Panel6.Location = New System.Drawing.Point(985, 236)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(313, 34)
        Me.Panel6.TabIndex = 34
        '
        'txt_cep
        '
        Me.txt_cep.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cep.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cep.Location = New System.Drawing.Point(19, 7)
        Me.txt_cep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(271, 22)
        Me.txt_cep.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.txt_bairro)
        Me.Panel7.Location = New System.Drawing.Point(985, 278)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(431, 34)
        Me.Panel7.TabIndex = 35
        '
        'txt_bairro
        '
        Me.txt_bairro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_bairro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bairro.Location = New System.Drawing.Point(19, 7)
        Me.txt_bairro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(319, 22)
        Me.txt_bairro.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.txt_uf)
        Me.Panel8.Location = New System.Drawing.Point(985, 320)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(124, 34)
        Me.Panel8.TabIndex = 36
        '
        'txt_uf
        '
        Me.txt_uf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_uf.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uf.Location = New System.Drawing.Point(19, 7)
        Me.txt_uf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.Size = New System.Drawing.Size(65, 22)
        Me.txt_uf.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txt_data_nascimento)
        Me.Panel3.Location = New System.Drawing.Point(985, 194)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(431, 34)
        Me.Panel3.TabIndex = 31
        '
        'txt_data_nascimento
        '
        Me.txt_data_nascimento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_data_nascimento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_data_nascimento.Location = New System.Drawing.Point(19, 7)
        Me.txt_data_nascimento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_data_nascimento.MaxLength = 14
        Me.txt_data_nascimento.Name = "txt_data_nascimento"
        Me.txt_data_nascimento.Size = New System.Drawing.Size(319, 22)
        Me.txt_data_nascimento.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.txt_endereco)
        Me.Panel5.Location = New System.Drawing.Point(547, 278)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(431, 34)
        Me.Panel5.TabIndex = 37
        '
        'txt_endereco
        '
        Me.txt_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_endereco.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endereco.Location = New System.Drawing.Point(19, 7)
        Me.txt_endereco.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(319, 22)
        Me.txt_endereco.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.Controls.Add(Me.txt_telefone)
        Me.Panel9.Location = New System.Drawing.Point(1117, 320)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(299, 34)
        Me.Panel9.TabIndex = 38
        '
        'txt_telefone
        '
        Me.txt_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_telefone.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone.Location = New System.Drawing.Point(19, 7)
        Me.txt_telefone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(187, 22)
        Me.txt_telefone.TabIndex = 1
        '
        'btn_foto
        '
        Me.btn_foto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_foto.Location = New System.Drawing.Point(399, 357)
        Me.btn_foto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_foto.Name = "btn_foto"
        Me.btn_foto.Size = New System.Drawing.Size(124, 28)
        Me.btn_foto.TabIndex = 39
        Me.btn_foto.Text = "Selecionar Foto"
        Me.btn_foto.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.Controls.Add(Me.txt_numero)
        Me.Panel10.Location = New System.Drawing.Point(1319, 236)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(97, 34)
        Me.Panel10.TabIndex = 33
        '
        'txt_numero
        '
        Me.txt_numero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_numero.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.Location = New System.Drawing.Point(19, 7)
        Me.txt_numero.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(53, 22)
        Me.txt_numero.TabIndex = 1
        '
        'btn_cadastro
        '
        Me.btn_cadastro.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_cadastro.Location = New System.Drawing.Point(1299, 379)
        Me.btn_cadastro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cadastro.Name = "btn_cadastro"
        Me.btn_cadastro.Size = New System.Drawing.Size(113, 43)
        Me.btn_cadastro.TabIndex = 40
        Me.btn_cadastro.Text = "CADASTRO"
        Me.btn_cadastro.UseVisualStyleBackColor = False
        '
        'btn_salvar_edicao
        '
        Me.btn_salvar_edicao.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_salvar_edicao.Location = New System.Drawing.Point(1117, 379)
        Me.btn_salvar_edicao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_salvar_edicao.Name = "btn_salvar_edicao"
        Me.btn_salvar_edicao.Size = New System.Drawing.Size(135, 43)
        Me.btn_salvar_edicao.TabIndex = 41
        Me.btn_salvar_edicao.Text = "SALVAR ALTERAÇÕES"
        Me.btn_salvar_edicao.UseVisualStyleBackColor = False
        '
        'cadastro_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1800, 897)
        Me.Controls.Add(Me.btn_salvar_edicao)
        Me.Controls.Add(Me.btn_cadastro)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.btn_foto)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Controls.Add(Me.img_foto)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "cadastro_usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Cliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_clientes As DataGridView
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_cpf As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_cidade As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txt_cep As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txt_uf As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_data_nascimento As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txt_telefone As TextBox
    Friend WithEvents btn_foto As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents btn_cadastro As Button
    Friend WithEvents btn_salvar_edicao As Button
End Class

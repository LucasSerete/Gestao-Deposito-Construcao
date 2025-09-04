<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cadastrousuario
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastrousuario))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmb_perfil = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_cpf = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.pic_user = New System.Windows.Forms.PictureBox()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.btn_foto = New System.Windows.Forms.Button()
        Me.dgv_usuarios = New System.Windows.Forms.DataGridView()
        Me.btn_salvar_edicao = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txt_nome)
        Me.Panel1.Location = New System.Drawing.Point(467, 103)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 34)
        Me.Panel1.TabIndex = 30
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.cmb_perfil)
        Me.Panel2.Location = New System.Drawing.Point(467, 166)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(167, 34)
        Me.Panel2.TabIndex = 31
        '
        'cmb_perfil
        '
        Me.cmb_perfil.FormattingEnabled = True
        Me.cmb_perfil.Location = New System.Drawing.Point(4, 5)
        Me.cmb_perfil.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_perfil.Name = "cmb_perfil"
        Me.cmb_perfil.Size = New System.Drawing.Size(160, 24)
        Me.cmb_perfil.TabIndex = 32
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txt_email)
        Me.Panel3.Location = New System.Drawing.Point(467, 234)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(431, 34)
        Me.Panel3.TabIndex = 31
        '
        'txt_email
        '
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_email.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(19, 7)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(319, 22)
        Me.txt_email.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.txt_cpf)
        Me.Panel4.Location = New System.Drawing.Point(467, 306)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(431, 34)
        Me.Panel4.TabIndex = 32
        '
        'txt_cpf
        '
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(19, 7)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(319, 22)
        Me.txt_cpf.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.txt_senha)
        Me.Panel5.Location = New System.Drawing.Point(467, 390)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(431, 34)
        Me.Panel5.TabIndex = 33
        '
        'txt_senha
        '
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(19, 7)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(319, 22)
        Me.txt_senha.TabIndex = 1
        '
        'pic_user
        '
        Me.pic_user.Image = CType(resources.GetObject("pic_user.Image"), System.Drawing.Image)
        Me.pic_user.Location = New System.Drawing.Point(1056, 103)
        Me.pic_user.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pic_user.Name = "pic_user"
        Me.pic_user.Size = New System.Drawing.Size(277, 233)
        Me.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_user.TabIndex = 34
        Me.pic_user.TabStop = False
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_salvar.Location = New System.Drawing.Point(1207, 426)
        Me.btn_salvar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(127, 38)
        Me.btn_salvar.TabIndex = 35
        Me.btn_salvar.Text = "SALVAR"
        Me.btn_salvar.UseVisualStyleBackColor = False
        '
        'btn_foto
        '
        Me.btn_foto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_foto.Location = New System.Drawing.Point(1132, 343)
        Me.btn_foto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_foto.Name = "btn_foto"
        Me.btn_foto.Size = New System.Drawing.Size(127, 38)
        Me.btn_foto.TabIndex = 36
        Me.btn_foto.Text = "Selecionar Foto"
        Me.btn_foto.UseVisualStyleBackColor = False
        '
        'dgv_usuarios
        '
        Me.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_usuarios.Location = New System.Drawing.Point(467, 491)
        Me.dgv_usuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_usuarios.Name = "dgv_usuarios"
        Me.dgv_usuarios.RowHeadersWidth = 51
        Me.dgv_usuarios.Size = New System.Drawing.Size(867, 302)
        Me.dgv_usuarios.TabIndex = 38
        '
        'btn_salvar_edicao
        '
        Me.btn_salvar_edicao.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_salvar_edicao.Location = New System.Drawing.Point(760, 767)
        Me.btn_salvar_edicao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_salvar_edicao.Name = "btn_salvar_edicao"
        Me.btn_salvar_edicao.Size = New System.Drawing.Size(144, 39)
        Me.btn_salvar_edicao.TabIndex = 39
        Me.btn_salvar_edicao.Text = "Salvar Alterações"
        Me.btn_salvar_edicao.UseVisualStyleBackColor = False
        '
        'cadastrousuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1800, 897)
        Me.Controls.Add(Me.btn_salvar_edicao)
        Me.Controls.Add(Me.dgv_usuarios)
        Me.Controls.Add(Me.btn_foto)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.pic_user)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "cadastrousuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Usuario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmb_perfil As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_cpf As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents pic_user As PictureBox
    Friend WithEvents btn_salvar As Button
    Friend WithEvents btn_foto As Button
    Friend WithEvents dgv_usuarios As DataGridView
    Friend WithEvents btn_salvar_edicao As Button
End Class

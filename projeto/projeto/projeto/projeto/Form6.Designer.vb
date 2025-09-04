<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_pedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pedidos))
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.txt_totalitem = New System.Windows.Forms.TextBox()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.txt_precovenda = New System.Windows.Forms.TextBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.txt_qtd = New System.Windows.Forms.TextBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.lbl_descricao = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txt_idproduto = New System.Windows.Forms.TextBox()
        Me.panel = New System.Windows.Forms.Panel()
        Me.txt_sub = New System.Windows.Forms.TextBox()
        Me.dgv_pedidos = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_idcliente = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lbl_endereco = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lbl_telefone = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lbl_cidade = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_bairro = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel11.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.panel.SuspendLayout()
        CType(Me.dgv_pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_registrar
        '
        Me.btn_registrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_registrar.Location = New System.Drawing.Point(1223, 726)
        Me.btn_registrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(100, 50)
        Me.btn_registrar.TabIndex = 37
        Me.btn_registrar.Text = "Registrar Pedido"
        Me.btn_registrar.UseVisualStyleBackColor = False
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel11.Controls.Add(Me.btn_add)
        Me.Panel11.Controls.Add(Me.Panel16)
        Me.Panel11.Controls.Add(Me.Panel15)
        Me.Panel11.Controls.Add(Me.Panel14)
        Me.Panel11.Controls.Add(Me.Panel13)
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Location = New System.Drawing.Point(477, 391)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(844, 100)
        Me.Panel11.TabIndex = 1
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_add.Location = New System.Drawing.Point(585, 60)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(100, 33)
        Me.btn_add.TabIndex = 37
        Me.btn_add.Text = "ADICIONAR"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.White
        Me.Panel16.Controls.Add(Me.txt_totalitem)
        Me.Panel16.Location = New System.Drawing.Point(243, 58)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(201, 34)
        Me.Panel16.TabIndex = 36
        '
        'txt_totalitem
        '
        Me.txt_totalitem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_totalitem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalitem.Location = New System.Drawing.Point(19, 7)
        Me.txt_totalitem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_totalitem.Name = "txt_totalitem"
        Me.txt_totalitem.Size = New System.Drawing.Size(179, 22)
        Me.txt_totalitem.TabIndex = 1
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.White
        Me.Panel15.Controls.Add(Me.txt_precovenda)
        Me.Panel15.Location = New System.Drawing.Point(4, 58)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(201, 34)
        Me.Panel15.TabIndex = 35
        '
        'txt_precovenda
        '
        Me.txt_precovenda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_precovenda.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precovenda.Location = New System.Drawing.Point(19, 7)
        Me.txt_precovenda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_precovenda.Name = "txt_precovenda"
        Me.txt_precovenda.Size = New System.Drawing.Size(179, 22)
        Me.txt_precovenda.TabIndex = 1
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.White
        Me.Panel14.Controls.Add(Me.txt_qtd)
        Me.Panel14.Location = New System.Drawing.Point(585, 9)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(132, 34)
        Me.Panel14.TabIndex = 34
        '
        'txt_qtd
        '
        Me.txt_qtd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_qtd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtd.Location = New System.Drawing.Point(4, 7)
        Me.txt_qtd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_qtd.Name = "txt_qtd"
        Me.txt_qtd.Size = New System.Drawing.Size(124, 22)
        Me.txt_qtd.TabIndex = 1
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.White
        Me.Panel13.Controls.Add(Me.lbl_desc)
        Me.Panel13.Controls.Add(Me.lbl_descricao)
        Me.Panel13.Location = New System.Drawing.Point(164, 9)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(396, 34)
        Me.Panel13.TabIndex = 33
        '
        'lbl_desc
        '
        Me.lbl_desc.AutoSize = True
        Me.lbl_desc.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl_desc.Location = New System.Drawing.Point(12, 11)
        Me.lbl_desc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(67, 16)
        Me.lbl_desc.TabIndex = 39
        Me.lbl_desc.Text = "descricao"
        '
        'lbl_descricao
        '
        Me.lbl_descricao.AutoSize = True
        Me.lbl_descricao.Location = New System.Drawing.Point(4, 11)
        Me.lbl_descricao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_descricao.Name = "lbl_descricao"
        Me.lbl_descricao.Size = New System.Drawing.Size(0, 16)
        Me.lbl_descricao.TabIndex = 38
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.Controls.Add(Me.txt_idproduto)
        Me.Panel12.Location = New System.Drawing.Point(4, 9)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(132, 34)
        Me.Panel12.TabIndex = 32
        '
        'txt_idproduto
        '
        Me.txt_idproduto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_idproduto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idproduto.Location = New System.Drawing.Point(19, 7)
        Me.txt_idproduto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_idproduto.Name = "txt_idproduto"
        Me.txt_idproduto.Size = New System.Drawing.Size(109, 22)
        Me.txt_idproduto.TabIndex = 1
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.White
        Me.panel.Controls.Add(Me.txt_sub)
        Me.panel.Location = New System.Drawing.Point(973, 737)
        Me.panel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(201, 34)
        Me.panel.TabIndex = 36
        '
        'txt_sub
        '
        Me.txt_sub.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_sub.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sub.Location = New System.Drawing.Point(4, 9)
        Me.txt_sub.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_sub.Name = "txt_sub"
        Me.txt_sub.Size = New System.Drawing.Size(179, 22)
        Me.txt_sub.TabIndex = 1
        '
        'dgv_pedidos
        '
        Me.dgv_pedidos.AllowUserToOrderColumns = True
        Me.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pedidos.Location = New System.Drawing.Point(477, 532)
        Me.dgv_pedidos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_pedidos.Name = "dgv_pedidos"
        Me.dgv_pedidos.RowHeadersWidth = 51
        Me.dgv_pedidos.Size = New System.Drawing.Size(845, 185)
        Me.dgv_pedidos.TabIndex = 37
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txt_idcliente)
        Me.Panel3.Location = New System.Drawing.Point(24, 22)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(132, 34)
        Me.Panel3.TabIndex = 32
        '
        'txt_idcliente
        '
        Me.txt_idcliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_idcliente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idcliente.Location = New System.Drawing.Point(19, 7)
        Me.txt_idcliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_idcliente.Name = "txt_idcliente"
        Me.txt_idcliente.Size = New System.Drawing.Size(109, 22)
        Me.txt_idcliente.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.lbl_nome)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Location = New System.Drawing.Point(215, 22)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(565, 34)
        Me.Panel6.TabIndex = 32
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl_nome.Location = New System.Drawing.Point(4, 11)
        Me.lbl_nome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(41, 16)
        Me.lbl_nome.TabIndex = 39
        Me.lbl_nome.Text = "nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 37
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.lbl_endereco)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Location = New System.Drawing.Point(24, 81)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(440, 34)
        Me.Panel7.TabIndex = 32
        '
        'lbl_endereco
        '
        Me.lbl_endereco.AutoSize = True
        Me.lbl_endereco.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl_endereco.Location = New System.Drawing.Point(15, 11)
        Me.lbl_endereco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_endereco.Name = "lbl_endereco"
        Me.lbl_endereco.Size = New System.Drawing.Size(65, 16)
        Me.lbl_endereco.TabIndex = 37
        Me.lbl_endereco.Text = "endereco"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 38
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.lbl_telefone)
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Location = New System.Drawing.Point(539, 81)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(241, 34)
        Me.Panel8.TabIndex = 35
        '
        'lbl_telefone
        '
        Me.lbl_telefone.AutoSize = True
        Me.lbl_telefone.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl_telefone.Location = New System.Drawing.Point(12, 11)
        Me.lbl_telefone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_telefone.Name = "lbl_telefone"
        Me.lbl_telefone.Size = New System.Drawing.Size(55, 16)
        Me.lbl_telefone.TabIndex = 40
        Me.lbl_telefone.Text = "telefone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 37
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.Controls.Add(Me.lbl_cidade)
        Me.Panel9.Controls.Add(Me.Label4)
        Me.Panel9.Location = New System.Drawing.Point(24, 142)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(375, 34)
        Me.Panel9.TabIndex = 32
        '
        'lbl_cidade
        '
        Me.lbl_cidade.AutoSize = True
        Me.lbl_cidade.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl_cidade.Location = New System.Drawing.Point(15, 11)
        Me.lbl_cidade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cidade.Name = "lbl_cidade"
        Me.lbl_cidade.Size = New System.Drawing.Size(49, 16)
        Me.lbl_cidade.TabIndex = 39
        Me.lbl_cidade.Text = "cidade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 16)
        Me.Label4.TabIndex = 38
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.Controls.Add(Me.lbl_estado)
        Me.Panel10.Controls.Add(Me.Label5)
        Me.Panel10.Location = New System.Drawing.Point(452, 142)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(165, 34)
        Me.Panel10.TabIndex = 36
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl_estado.Location = New System.Drawing.Point(4, 11)
        Me.lbl_estado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(49, 16)
        Me.lbl_estado.TabIndex = 41
        Me.lbl_estado.Text = "estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 11)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 16)
        Me.Label5.TabIndex = 38
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(477, 119)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(844, 253)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lbl_bairro)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(640, 142)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(165, 34)
        Me.Panel2.TabIndex = 42
        '
        'lbl_bairro
        '
        Me.lbl_bairro.AutoSize = True
        Me.lbl_bairro.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl_bairro.Location = New System.Drawing.Point(4, 11)
        Me.lbl_bairro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_bairro.Name = "lbl_bairro"
        Me.lbl_bairro.Size = New System.Drawing.Size(42, 16)
        Me.lbl_bairro.TabIndex = 41
        Me.lbl_bairro.Text = "bairro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 11)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 16)
        Me.Label7.TabIndex = 38
        '
        'frm_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1800, 897)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.dgv_pedidos)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_pedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel11.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.dgv_pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_registrar As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents txt_qtd As TextBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents txt_idproduto As TextBox
    Friend WithEvents btn_add As Button
    Friend WithEvents Panel16 As Panel
    Friend WithEvents txt_totalitem As TextBox
    Friend WithEvents panel As Panel
    Friend WithEvents txt_sub As TextBox
    Friend WithEvents lbl_descricao As Label
    Friend WithEvents dgv_pedidos As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_idcliente As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lbl_endereco As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lbl_telefone As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lbl_cidade As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents lbl_estado As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_bairro As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_nome As Label
    Friend WithEvents lbl_desc As Label
    Friend WithEvents txt_precovenda As TextBox
End Class

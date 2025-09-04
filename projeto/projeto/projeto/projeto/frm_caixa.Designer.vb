<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_caixa
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_caixa))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_idpedido = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.cmb_formapagamento = New System.Windows.Forms.ComboBox()
        Me.dgv_caixa = New System.Windows.Forms.DataGridView()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_caixa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txt_idpedido)
        Me.Panel1.Location = New System.Drawing.Point(408, 229)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(224, 34)
        Me.Panel1.TabIndex = 63
        '
        'txt_idpedido
        '
        Me.txt_idpedido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_idpedido.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idpedido.Location = New System.Drawing.Point(19, 7)
        Me.txt_idpedido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_idpedido.Name = "txt_idpedido"
        Me.txt_idpedido.Size = New System.Drawing.Size(201, 22)
        Me.txt_idpedido.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txt_valor)
        Me.Panel3.Location = New System.Drawing.Point(1175, 229)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(217, 34)
        Me.Panel3.TabIndex = 65
        '
        'txt_valor
        '
        Me.txt_valor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_valor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor.Location = New System.Drawing.Point(19, 7)
        Me.txt_valor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(173, 22)
        Me.txt_valor.TabIndex = 1
        '
        'cmb_formapagamento
        '
        Me.cmb_formapagamento.FormattingEnabled = True
        Me.cmb_formapagamento.Location = New System.Drawing.Point(408, 293)
        Me.cmb_formapagamento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_formapagamento.Name = "cmb_formapagamento"
        Me.cmb_formapagamento.Size = New System.Drawing.Size(219, 24)
        Me.cmb_formapagamento.TabIndex = 66
        '
        'dgv_caixa
        '
        Me.dgv_caixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_caixa.Location = New System.Drawing.Point(408, 380)
        Me.dgv_caixa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_caixa.Name = "dgv_caixa"
        Me.dgv_caixa.RowHeadersWidth = 51
        Me.dgv_caixa.Size = New System.Drawing.Size(984, 288)
        Me.dgv_caixa.TabIndex = 67
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_confirmar.Location = New System.Drawing.Point(1175, 304)
        Me.btn_confirmar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(127, 38)
        Me.btn_confirmar.TabIndex = 69
        Me.btn_confirmar.Text = "SALVAR"
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'frm_caixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1800, 897)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.dgv_caixa)
        Me.Controls.Add(Me.cmb_formapagamento)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_caixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caixa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgv_caixa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_idpedido As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_valor As TextBox
    Friend WithEvents cmb_formapagamento As ComboBox
    Friend WithEvents dgv_caixa As DataGridView
    Friend WithEvents btn_confirmar As Button
End Class

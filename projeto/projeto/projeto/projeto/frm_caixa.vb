Imports System.Data.SqlClient

Public Class frm_caixa

    Public PerfilUsuario As String
    Private Sub frm_caixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1) Configurações iniciais da ComboBox
        cmb_formapagamento.Items.Clear()
        cmb_formapagamento.Items.AddRange({"Dinheiro", "Cartão Débito", "Cartão Crédito", "Pix"})
        cmb_formapagamento.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_formapagamento.SelectedIndex = -1

        ' 2) Carrega o grid e adiciona botões/eventos
        CarregarCaixa()
        AdicionarBotaoPagamento()
        AddHandler dgv_caixa.CellFormatting, AddressOf dgv_caixa_CellFormatting
        AddHandler dgv_caixa.CellClick, AddressOf dgv_caixa_CellClick

        ' 3) Controle de perfil
        If PerfilUsuario.ToLower() = "gerente" Then
            btn_confirmar.Enabled = False
        End If

        ' 4) Placeholders iniciais
        txt_idpedido.Text = "ID do Pedido"
        txt_idpedido.ForeColor = Color.DarkGray

        txt_valor.Text = "Valor Total"
        txt_valor.ForeColor = Color.DarkGray
    End Sub

    ' === Novo: preenche txt_idpedido e txt_valor ao clicar numa linha ===
    Private Sub dgv_caixa_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 Then Return

        Dim row = dgv_caixa.Rows(e.RowIndex)

        ' ID e Valor
        txt_idpedido.Text = row.Cells("ID Pedido").Value?.ToString()
        txt_idpedido.ForeColor = Color.Black

        txt_valor.Text = row.Cells("Valor Total").Value?.ToString()
        txt_valor.ForeColor = Color.Black

        ' Forma de Pagamento (pode vir vazia)
        Dim forma = row.Cells("Pagamento").Value?.ToString()
        If String.IsNullOrEmpty(forma) Then
            cmb_formapagamento.SelectedIndex = -1
        Else
            cmb_formapagamento.SelectedItem = forma
        End If
    End Sub

    ' === Placeholder ID Pedido ===
    Private Sub txt_idpedido_GotFocus(sender As Object, e As EventArgs) Handles txt_idpedido.GotFocus
        If txt_idpedido.Text = "ID do Pedido" AndAlso txt_idpedido.ForeColor = Color.DarkGray Then
            txt_idpedido.Text = ""
            txt_idpedido.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_idpedido_LostFocus(sender As Object, e As EventArgs) Handles txt_idpedido.LostFocus
        If txt_idpedido.Text = "" Then
            txt_idpedido.Text = "ID do Pedido"
            txt_idpedido.ForeColor = Color.DarkGray
        ElseIf txt_idpedido.ForeColor = Color.Black Then
            BuscarPedido()
        End If
    End Sub

    ' === Placeholder Nome Vendedor ===


    ' === Placeholder Valor ===
    Private Sub txt_valor_GotFocus(sender As Object, e As EventArgs) Handles txt_valor.GotFocus
        If txt_valor.Text = "Valor Total" AndAlso txt_valor.ForeColor = Color.DarkGray Then
            txt_valor.Text = ""
            txt_valor.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_valor_LostFocus(sender As Object, e As EventArgs) Handles txt_valor.LostFocus
        If txt_valor.Text = "" Then
            txt_valor.Text = "Valor Total"
            txt_valor.ForeColor = Color.DarkGray
        End If
    End Sub

    ' === Buscar informações do pedido ===
    Private Sub BuscarPedido()
        If txt_idpedido.Text = "ID do Pedido" OrElse String.IsNullOrWhiteSpace(txt_idpedido.Text) Then
            MessageBox.Show("Digite o ID do pedido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            AbrirConexao()

            Dim sql As String = "SELECT valor_total FROM pedidos WHERE id = @id"
            Dim cmd As New SqlCommand(sql, conexao)
            cmd.Parameters.AddWithValue("@id", txt_idpedido.Text)

            Dim valor = cmd.ExecuteScalar()

            If valor IsNot Nothing Then
                txt_valor.Text = valor.ToString()
                txt_valor.ForeColor = Color.Black
            Else
                MessageBox.Show("Pedido não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_valor.Text = "Valor Total"
                txt_valor.ForeColor = Color.DarkGray
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao buscar pedido: " & ex.Message)
        Finally
            FecharConexao()
        End Try
    End Sub

    ' === Finalizar venda ===
    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        ' Validação dos campos
        If txt_idpedido.Text = "ID do Pedido" Or txt_valor.Text = "Valor Total" Or cmb_formapagamento.SelectedIndex = -1 Then
            MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            AbrirConexao()

            ' 1) Busca o nome_vendedor diretamente da tabela pedidos
            Dim nomeVendedor As String = ""
            Using cmdNome As New SqlCommand(
            "SELECT nome_vendedor 
               FROM pedidos 
              WHERE id = @idPedido", conexao)

                cmdNome.Parameters.AddWithValue("@idPedido", txt_idpedido.Text)
                Dim obj = cmdNome.ExecuteScalar()
                If obj Is Nothing Then
                    MessageBox.Show("Pedido não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                nomeVendedor = obj.ToString()
            End Using

            ' 2) Prepara o INSERT na tabela caixa (omitindo a coluna identity)
            Dim sql As String =
            "INSERT INTO caixa (id_pedido, nome_vendedor, valor_total, forma_pagamento) " &
            "VALUES (@idPedido, @vendedor, @valor, @forma)"
            Using cmd As New SqlCommand(sql, conexao)

                ' Converte texto para Decimal
                Dim valorDecimal As Decimal
                If Not Decimal.TryParse(
                txt_valor.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                valorDecimal) Then

                    MessageBox.Show("Valor inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ' Monta os parâmetros
                cmd.Parameters.AddWithValue("@idPedido", txt_idpedido.Text)
                cmd.Parameters.AddWithValue("@vendedor", nomeVendedor)
                cmd.Parameters.Add("@valor", SqlDbType.Decimal).Value = valorDecimal
                cmd.Parameters.AddWithValue("@forma", cmb_formapagamento.Text)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Venda registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Atualiza DataGridView com a nova venda
            CarregarCaixa()

            ' Limpa os campos
            txt_idpedido.Text = "ID do Pedido"
            txt_idpedido.ForeColor = Color.DarkGray

            txt_valor.Text = "Valor Total"
            txt_valor.ForeColor = Color.DarkGray

            cmb_formapagamento.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Erro ao registrar venda: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharConexao()
        End Try
    End Sub

    Private Sub frm_caixa_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_menu.Show()
    End Sub
    Private Sub CarregarCaixa()
        Try
            AbrirConexao()

            Dim sql As String =
        "SELECT 
            c.id            AS [ID Caixa],     
            p.id            AS [ID Pedido],
            p.idcliente     AS [ID Cliente],
            p.nome_vendedor AS Vendedor,
            p.valor_total   AS [Valor Total],
            ISNULL(c.forma_pagamento, '')   AS [Pagamento],
            c.data_pagamento                AS [Data Pagamento],
            ISNULL(c.status_pagamento, '')  AS [Status]
         FROM pedidos p
         LEFT JOIN caixa c ON c.id_pedido = p.id
         ORDER BY p.id DESC"

            Dim da As New SqlDataAdapter(sql, conexao)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgv_caixa.DataSource = dt
            dgv_caixa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgv_caixa.ReadOnly = True

            ' Se você não quiser que o usuário veja esse ID, esconda a coluna:
            If dgv_caixa.Columns.Contains("ID Caixa") Then
                dgv_caixa.Columns("ID Caixa").Visible = False
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados do caixa: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharConexao()
        End Try
    End Sub

    Private Sub AdicionarBotaoPagamento()
        Dim botaoColuna As New DataGridViewButtonColumn()
        botaoColuna.Name = "btnPagar"
        botaoColuna.HeaderText = "Ação"
        botaoColuna.Text = "Marcar como Pago"
        botaoColuna.UseColumnTextForButtonValue = True

        If dgv_caixa.Columns.Contains("btnPagar") = False Then
            dgv_caixa.Columns.Add(botaoColuna)
        End If
    End Sub

    Private Sub dgv_caixa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_caixa.CellContentClick
        If e.RowIndex >= 0 AndAlso dgv_caixa.Columns(e.ColumnIndex).Name = "btnPagar" Then
            Dim idCaixa As Integer = CInt(dgv_caixa.Rows(e.RowIndex).Cells("ID Caixa").Value)
            Dim statusAtual As String = dgv_caixa.Rows(e.RowIndex).Cells("Status").Value.ToString()

            If statusAtual = "Pago" Then
                MessageBox.Show("Este pedido já foi marcado como pago.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Try
                AbrirConexao()
                Dim sql As String = "UPDATE caixa SET status_pagamento = 'Pago' WHERE id = @id"
                Dim cmd As New SqlCommand(sql, conexao)
                cmd.Parameters.AddWithValue("@id", idCaixa)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Pagamento confirmado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CarregarCaixa()

            Catch ex As Exception
                MessageBox.Show("Erro ao atualizar status de pagamento: " & ex.Message)
            Finally
                FecharConexao()
            End Try
        End If
    End Sub

    Private Sub dgv_caixa_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_caixa.CellFormatting
        If dgv_caixa.Columns(e.ColumnIndex).Name = "Status" AndAlso e.Value IsNot Nothing Then
            Dim status As String = e.Value.ToString()

            If status = "Pago" Then
                e.CellStyle.BackColor = Color.ForestGreen
                e.CellStyle.ForeColor = Color.White
            ElseIf status = "Pendente" Then
                e.CellStyle.BackColor = Color.IndianRed
                e.CellStyle.ForeColor = Color.White
            End If
        End If
    End Sub
End Class

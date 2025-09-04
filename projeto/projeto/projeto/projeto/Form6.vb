Imports System.Data.SqlClient
Imports System.Runtime.InteropServices.ComTypes

Public Class frm_pedidos
    Public PerfilUsuario As String
    Private Sub frm_pedidos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.ActiveControl = Nothing
    End Sub
    Private Sub frm_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If PerfilUsuario.ToLower() = "gerente" Then
            btn_add.Enabled = False
            btn_registrar.Enabled = False
        End If

        SetPlaceholder(txt_idcliente, "ID do Cliente")
        SetPlaceholder(txt_idproduto, "ID do produto")
        SetPlaceholder(txt_qtd, "Quantidade")
        SetPlaceholder(txt_precovenda, "Valor do Produto")
        SetPlaceholder(txt_totalitem, "Total do Item")
        SetPlaceholder(txt_sub, "Valor Total")

        dgv_pedidos.Columns.Clear()
        dgv_pedidos.Columns.Add("ID", "ID Produto")
        dgv_pedidos.Columns.Add("Descricao", "Descrição")
        dgv_pedidos.Columns.Add("Quantidade", "Qtd")
        dgv_pedidos.Columns.Add("ValorUnit", "Valor Unitário")
        dgv_pedidos.Columns.Add("Total", "Total")


        btn_add.Enabled = False

    End Sub


    Private Sub SetPlaceholder(txt As TextBox, placeholder As String)
        txt.Text = placeholder
        txt.ForeColor = Color.DarkGray
    End Sub

    Private Sub CalcularTotalItem()

        If IsNumeric(txt_qtd.Text) AndAlso IsNumeric(txt_precovenda.Text) Then
            Dim quantidade As Double = CDbl(txt_qtd.Text)
            Dim valorUnitario As Double = CDbl(txt_precovenda.Text)
            Dim total As Double = quantidade * valorUnitario

            txt_totalitem.Text = total.ToString("F2")
            txt_totalitem.ForeColor = Color.Black
        Else
            txt_totalitem.Text = "Total do Item"
            txt_totalitem.ForeColor = Color.DarkGray
        End If
    End Sub



    Private Sub txt_idcliente_Leave(sender As Object, e As EventArgs) Handles txt_idcliente.Leave
        If txt_idcliente.Text = "" Then
            SetPlaceholder(txt_idcliente, "ID do Cliente")
        End If
    End Sub
    Private Sub txt_qtd_Enter(sender As Object, e As EventArgs) Handles txt_qtd.Enter
        If txt_qtd.Text = "Quantidade" Then
            txt_qtd.Text = ""
            txt_qtd.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_qtd_Leave(sender As Object, e As EventArgs) Handles txt_qtd.Leave
        If txt_qtd.Text = "" Then
            SetPlaceholder(txt_qtd, "Quantidade")
        ElseIf txt_qtd.Text <> "Quantidade" Then
            CalcularTotalItem()
        End If

    End Sub

    Private Sub txt_valor_Enter(sender As Object, e As EventArgs) Handles txt_precovenda.Enter
        If txt_precovenda.Text = "Valor do Produto" Then
            txt_precovenda.Text = ""
            txt_precovenda.ForeColor = Color.Black
        End If

    End Sub

    Private Sub txt_valor_Leave(sender As Object, e As EventArgs) Handles txt_precovenda.Leave
        If txt_precovenda.Text = "" Then
            SetPlaceholder(txt_precovenda, "Valor do Produto")
        ElseIf txt_precovenda.Text <> "Valor do Produto" Then
            CalcularTotalItem()
        End If
    End Sub

    Private Sub txt_totalitem_Enter(sender As Object, e As EventArgs) Handles txt_totalitem.Enter
        If txt_totalitem.Text = "Total do Item" Then
            txt_totalitem.Text = ""
            txt_totalitem.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_totalitem_Leave(sender As Object, e As EventArgs) Handles txt_totalitem.Leave
        If txt_totalitem.Text = "" Then
            SetPlaceholder(txt_totalitem, "Total do Item")
        End If
    End Sub

    Private Sub txt_sub_Enter(sender As Object, e As EventArgs) Handles txt_sub.Enter
        If txt_sub.Text = "Valor Total" Then
            txt_sub.Text = ""
            txt_sub.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_sub_Leave(sender As Object, e As EventArgs) Handles txt_sub.Leave
        If String.IsNullOrWhiteSpace(txt_sub.Text) Then
            SetPlaceholder(txt_sub, "Valor Total")
        End If
    End Sub

    Private Sub VerificarCampos()
        Dim camposPreenchidos As Boolean =
            txt_idproduto.Text <> "" AndAlso txt_idproduto.Text <> "ID do produto" AndAlso
            txt_qtd.Text <> "" AndAlso txt_qtd.Text <> "Quantidade" AndAlso
            txt_precovenda.Text <> "" AndAlso txt_precovenda.Text <> "Valor do Produto"

        Dim numerosValidos As Boolean = IsNumeric(txt_qtd.Text) AndAlso IsNumeric(txt_precovenda.Text)

        btn_add.Enabled = camposPreenchidos AndAlso numerosValidos
    End Sub

    Private Sub txt_idproduto_TextChanged(sender As Object, e As EventArgs) Handles txt_idproduto.TextChanged
        VerificarCampos()
    End Sub

    Private Sub txt_valor_TextChanged(sender As Object, e As EventArgs) Handles txt_precovenda.TextChanged
        VerificarCampos()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        ' Validação
        If Not IsNumeric(txt_qtd.Text) Or Not IsNumeric(txt_precovenda.Text) Then
            MsgBox("Quantidade e Preço devem ser números válidos.", MsgBoxStyle.Critical, "Erro")
            Exit Sub
        End If

        ' Captura os dados
        Dim id As Integer = CInt(txt_idproduto.Text)
        Dim nome As String = lbl_desc.Text
        Dim qtd As Integer = CInt(txt_qtd.Text)
        Dim preco As Double = CDbl(txt_precovenda.Text)
        Dim total As Double = qtd * preco

        ' Verificar estoque disponível
        Try
            AbrirConexao()

            Dim cmdEstoque As New SqlCommand("SELECT quantidade FROM produtos WHERE id = @id", conexao)
            cmdEstoque.Parameters.AddWithValue("@id", id)

            Dim qtdEstoque As Integer = CInt(cmdEstoque.ExecuteScalar())

            If qtd > qtdEstoque Then
                MsgBox($"Estoque insuficiente para o produto selecionado." & vbCrLf &
                   $"Disponível: {qtdEstoque}, Solicitado: {qtd}", MsgBoxStyle.Exclamation, "Estoque")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Erro ao verificar o estoque: " & ex.Message, MsgBoxStyle.Critical, "Erro")
            Exit Sub
        Finally
            FecharConexao()
        End Try

        ' Adiciona ao DataGridView
        dgv_pedidos.Rows.Add(id, nome, qtd, preco.ToString("F2"), total.ToString("F2"))

        ' Atualiza subtotal
        Dim subtotal As Double = 0
        For Each row As DataGridViewRow In dgv_pedidos.Rows
            If Not row.IsNewRow Then
                subtotal += CDbl(row.Cells(4).Value)
            End If
        Next
        txt_sub.Text = subtotal.ToString("F2")
        txt_sub.ForeColor = Color.Black

        ' Limpa campos e placeholders
        SetPlaceholder(txt_idproduto, "ID do produto")
        SetPlaceholder(txt_qtd, "Quantidade")
        SetPlaceholder(txt_precovenda, "Valor do Produto")
        SetPlaceholder(txt_totalitem, "Total do Item")
        lbl_desc.Text = ""

        btn_add.Enabled = False
    End Sub



    Private Sub BuscarDescricaoProduto()
        Dim conexao As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Deposito_Materiais;Integrated Security=True")
        Dim comando As New SqlCommand("SELECT nome FROM Produtos WHERE id = @id", conexao)

        Try
            comando.Parameters.AddWithValue("@id", CInt(txt_idproduto.Text))

            conexao.Open()
            Dim leitor As SqlDataReader = comando.ExecuteReader()

            If leitor.Read() Then
                lbl_desc.Text = leitor("nome").ToString()
            Else
                lbl_desc.Text = "Produto não encontrado"
            End If

            conexao.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao buscar produto: " & ex.Message)
        End Try
    End Sub

    Private Sub txt_idproduto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_idproduto.KeyDown
        If e.KeyCode = Keys.Enter Then
            BuscarDescricaoProduto()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub BuscarDadosCliente()
        Dim conexao As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Deposito_Materiais;Integrated Security=True")
        Dim comando As New SqlCommand("
        SELECT nome, endereco, telefone, cidade, uf, bairro 
        FROM tb_clientes 
        WHERE id = @id", conexao)

        Try
            comando.Parameters.AddWithValue("@id", CInt(txt_idcliente.Text))

            conexao.Open()
            Dim leitor As SqlDataReader = comando.ExecuteReader()

            If leitor.Read() Then
                lbl_nome.Text = leitor("nome").ToString()
                lbl_endereco.Text = leitor("endereco").ToString()
                lbl_telefone.Text = leitor("telefone").ToString()
                lbl_cidade.Text = leitor("cidade").ToString()
                lbl_estado.Text = leitor("uf").ToString()
                lbl_bairro.Text = leitor("bairro").ToString()
            Else
                MessageBox.Show("Cliente não encontrado.")
            End If

            conexao.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao buscar cliente: " & ex.Message)
        End Try
    End Sub

    Private Sub txt_idcliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_idcliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            BuscarDadosCliente()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txt_idcliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_idcliente.KeyPress
        ' Só bloqueia se o campo não estiver com o placeholder
        If txt_idcliente.Text = "ID do Cliente" Then Exit Sub

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_idproduto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_idproduto.KeyPress
        ' Só bloqueia se o campo não estiver com o placeholder
        If txt_idproduto.Text = "ID do produto" Then Exit Sub

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_idcliente_Enter(sender As Object, e As EventArgs) Handles txt_idcliente.Enter
        If txt_idcliente.Text = "ID do Cliente" Then
            txt_idcliente.Text = ""
            txt_idcliente.ForeColor = Color.Black
        End If
        txt_idcliente.SelectAll()
    End Sub

    Private Sub txt_idproduto_Enter(sender As Object, e As EventArgs) Handles txt_idproduto.Enter
        If txt_idproduto.Text = "ID do produto" Then
            txt_idproduto.Text = ""
            txt_idproduto.ForeColor = Color.Black
        End If
        txt_idproduto.SelectAll()
    End Sub

    Private Sub txt_idproduto_Leave(sender As Object, e As EventArgs) Handles txt_idproduto.Leave
        If txt_idproduto.Text = "" Or txt_idproduto.Text = "ID do produto" Then
            lbl_desc.Text = ""
            SetPlaceholder(txt_precovenda, "Valor do Produto")
            Exit Sub
        End If

        Try
            AbrirConexao() ' Abre a conexão e inicializa a variável global "conexao"
            Dim cmd As New SqlCommand("SELECT nome, precovenda FROM produtos WHERE id = @id", conexao)
            cmd.Parameters.AddWithValue("@id", CInt(txt_idproduto.Text))

            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                lbl_desc.Text = dr("nome").ToString()
                txt_precovenda.Text = Convert.ToDecimal(dr("precovenda")).ToString("F2")
                txt_precovenda.ForeColor = Color.Black
            Else
                MessageBox.Show("Produto não encontrado.")
                lbl_desc.Text = ""
                SetPlaceholder(txt_precovenda, "Valor do Produto")
            End If
            dr.Close()
            conexao.Close()

            If IsNumeric(txt_qtd.Text) Then
                CalcularTotalItem()
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao buscar produto: " & ex.Message)
        End Try
    End Sub


    Private Sub txt_qtd_TextChanged(sender As Object, e As EventArgs) Handles txt_qtd.TextChanged
        If Not String.IsNullOrEmpty(txt_precovenda.Text) Then
            CalcularTotalItem()
            VerificarCampos()
        End If
    End Sub

    Private Sub frm_pedidos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_menu.Show()
    End Sub



    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        Try
            AbrirConexao()

            ' Validação cliente
            Dim idcliente As Integer = 0
            If Not Integer.TryParse(txt_idcliente.Text, idcliente) Then
                MessageBox.Show("ID do cliente inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim verificaClienteCmd As New SqlCommand("SELECT COUNT(*) FROM tb_clientes WHERE id = @id", conexao)
            verificaClienteCmd.Parameters.AddWithValue("@id", idcliente)
            Dim existeCliente As Integer = CInt(verificaClienteCmd.ExecuteScalar())

            If existeCliente = 0 Then
                MessageBox.Show("Cliente não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Validação valor total
            If txt_sub.Text = "Valor Total" OrElse String.IsNullOrWhiteSpace(txt_sub.Text) Then
                MessageBox.Show("Informe o valor total do pedido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Conversão valor total
            Dim valorTotalDecimal As Decimal
            Dim textoValor As String = txt_sub.Text.Trim().Replace(",", ".")

            If Not Decimal.TryParse(textoValor, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, valorTotalDecimal) Then
                MessageBox.Show("Valor total inválido. Verifique o valor antes de registrar o pedido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim transaction As SqlTransaction = conexao.BeginTransaction()

            Dim cmdPedido As New SqlCommand("INSERT INTO pedidos (idcliente, data_pedido, valor_total, nome_vendedor) OUTPUT INSERTED.id VALUES (@idcliente, @data_pedido, @valor_total, @nome_vendedor)", conexao, transaction)
            cmdPedido.Parameters.Add("@idcliente", SqlDbType.Int).Value = idcliente
            cmdPedido.Parameters.Add("@data_pedido", SqlDbType.DateTime).Value = Date.Now
            cmdPedido.Parameters.Add("@valor_total", SqlDbType.Decimal).Value = valorTotalDecimal
            cmdPedido.Parameters.Add("@nome_vendedor", SqlDbType.VarChar, 100).Value = frm_menu.lbl_nome.Text


            Dim idPedido As Integer = CInt(cmdPedido.ExecuteScalar())

            ' Inserir itens do pedido e atualizar estoque
            For Each row As DataGridViewRow In dgv_pedidos.Rows
                If row.IsNewRow Then Continue For

                Dim idProduto As Integer = If(IsNumeric(row.Cells("ID").Value), CInt(row.Cells("ID").Value), 0)
                Dim descricao As String = If(row.Cells("Descricao").Value IsNot Nothing, row.Cells("Descricao").Value.ToString(), "")
                Dim quantidade As Integer = If(IsNumeric(row.Cells("Quantidade").Value), CInt(row.Cells("Quantidade").Value), 0)

                Dim precoVendaDecimal As Decimal = 0D
                Dim precoVendaTexto As String = If(row.Cells("ValorUnit").Value IsNot Nothing, row.Cells("ValorUnit").Value.ToString().Replace(",", "."), "0")
                If Not Decimal.TryParse(precoVendaTexto, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, precoVendaDecimal) Then
                    precoVendaDecimal = 0D
                End If

                ' VALIDAÇÃO DO ESTOQUE DISPONÍVEL
                Dim cmdVerificaEstoque As New SqlCommand("SELECT quantidade FROM produtos WHERE id = @idproduto", conexao, transaction)
                cmdVerificaEstoque.Parameters.AddWithValue("@idproduto", idProduto)
                Dim estoqueDisponivel As Integer = Convert.ToInt32(cmdVerificaEstoque.ExecuteScalar())

                If estoqueDisponivel < quantidade Then
                    MessageBox.Show($"Estoque insuficiente para o produto '{descricao}'. Estoque atual: {estoqueDisponivel}, quantidade solicitada: {quantidade}.", "Erro de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    transaction.Rollback()
                    Return
                End If

                ' Insere item no pedido
                Dim cmdItem As New SqlCommand(
                "INSERT INTO itens_pedido (idpedido, idproduto, descricao_produto, quantidade, precovenda) " &
                "VALUES (@idpedido, @idproduto, @descricao, @quantidade, @precovenda)", conexao, transaction)

                cmdItem.Parameters.Add("@idpedido", SqlDbType.Int).Value = idPedido
                cmdItem.Parameters.Add("@idproduto", SqlDbType.Int).Value = idProduto
                cmdItem.Parameters.Add("@descricao", SqlDbType.VarChar, 200).Value = descricao
                cmdItem.Parameters.Add("@quantidade", SqlDbType.Int).Value = quantidade
                cmdItem.Parameters.Add("@precovenda", SqlDbType.Decimal).Value = precoVendaDecimal

                cmdItem.ExecuteNonQuery()

                ' Atualiza estoque
                Dim cmdAtualizaEstoque As New SqlCommand("UPDATE produtos SET quantidade = quantidade - @quantidade WHERE id = @idproduto", conexao, transaction)
                cmdAtualizaEstoque.Parameters.AddWithValue("@quantidade", quantidade)
                cmdAtualizaEstoque.Parameters.AddWithValue("@idproduto", idProduto)
                cmdAtualizaEstoque.ExecuteNonQuery()
            Next

            transaction.Commit()

            MessageBox.Show("Pedido registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Limpar tela
            dgv_pedidos.Rows.Clear()
            SetPlaceholder(txt_sub, "Valor Total")
            SetPlaceholder(txt_idcliente, "ID do Cliente")
            lbl_nome.Text = ""
            lbl_endereco.Text = ""
            lbl_bairro.Text = ""
            lbl_telefone.Text = ""
            lbl_estado.Text = ""
            lbl_cidade.Text = ""

        Catch ex As Exception
            MessageBox.Show("Erro ao registrar pedido: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Try
                If conexao.State = ConnectionState.Open Then
                    conexao.Close()
                End If
            Catch
                ' Ignore
            End Try
        Finally
            If conexao.State = ConnectionState.Open Then
                conexao.Close()
            End If
        End Try
    End Sub

    Private Sub CarregarPedidos()
        Try
            AbrirConexao()

            Dim sql As String = "
        SELECT p.id, c.nome AS Cliente, p.data_pedido, p.valor_total
        FROM pedidos p
        INNER JOIN tb_clientes c ON p.idcliente = c.id
        ORDER BY p.data_pedido DESC"

            Dim cmd As New SqlCommand(sql, conexao)
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)

            da.Fill(dt)

            MessageBox.Show("Pedidos encontrados: " & dt.Rows.Count.ToString())

            dgv_pedidos.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar pedidos: " & ex.Message)
        Finally
            FecharConexao()
        End Try
    End Sub

    Private Sub dgv_pedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedidos.CellContentClick

    End Sub
End Class

Imports System.Data.SqlClient

Public Class cadastroprodutos
    Public PerfilUsuario As String

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarDados()
        If PerfilUsuario.ToLower() = "gerente" Then
            btn_salvar.Enabled = False
        End If
        btn_salvar_edicao.Visible = False
        txt_nome.Text = "Nome"
        txt_nome.ForeColor = Color.DarkGray
        txt_quant.Text = "Quantidade"
        txt_quant.ForeColor = Color.DarkGray
        txt_precov.Text = "Preço de Venda"
        txt_precov.ForeColor = Color.DarkGray
        txt_precoc.Text = "Preço de Compra"
        txt_precoc.ForeColor = Color.DarkGray
        cmb_categoria.Items.Add("Materiais de Construção")
        cmb_categoria.Items.Add("Acabamentos")
        cmb_categoria.Items.Add("Hidráulica")
        cmb_categoria.Items.Add("Elétrica")
        cmb_categoria.Items.Add("Pintura")
        cmb_categoria.Items.Add("Ferramentas e Ferragens")
        cmb_categoria.Items.Add("Portas, Janelas, Louças e Metais")
        cmb_categoria.Items.Add("Acessórios e Diversos")
        cmb_categoria.SelectedIndex = -1
        cmb_categoria.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub


    Private Sub txt_nome_Click(sender As Object, e As EventArgs) Handles txt_nome.Click
        If txt_nome.ForeColor = Color.DarkGray Then
            txt_nome.SelectionStart = 0
            txt_nome.SelectionLength = 0
        End If
    End Sub

    Private Sub txt_nome_GotFocus(sender As Object, e As EventArgs) Handles txt_nome.GotFocus
        If txt_nome.Text = "Nome" AndAlso txt_nome.ForeColor = Color.DarkGray Then
            txt_nome.SelectionStart = 0
            txt_nome.SelectionLength = 0
        End If
    End Sub

    Private Sub txt_nome_TextChanged(sender As Object, e As EventArgs) Handles txt_nome.TextChanged
        ' Se o campo estiver vazio, mostrar o placeholder
        If String.IsNullOrWhiteSpace(txt_nome.Text) Then
            txt_nome.Text = "Nome"
            txt_nome.ForeColor = Color.DarkGray
            txt_nome.SelectionStart = 0
            Exit Sub
        End If

        ' Se o placeholder ainda estiver visível e o usuário digitar
        If txt_nome.ForeColor = Color.DarkGray AndAlso txt_nome.Text <> "Nome" Then
            Dim textoDigitado As String = txt_nome.Text.Replace("Nome", "")
            If textoDigitado.Length > 0 Then
                txt_nome.ForeColor = Color.Black
                txt_nome.Text = textoDigitado
                txt_nome.SelectionStart = txt_nome.Text.Length
            End If
        End If
    End Sub

    Private Sub txt_precov_Click(sender As Object, e As EventArgs) Handles txt_precov.Click
        If txt_precov.ForeColor = Color.DarkGray Then
            txt_precov.SelectionStart = 0
            txt_precov.SelectionLength = 0
        End If
    End Sub
    Private Sub txt_precov_GotFocus(sender As Object, e As EventArgs) Handles txt_precov.GotFocus
        If txt_precov.Text = "Preço de Venda" AndAlso txt_precov.ForeColor = Color.DarkGray Then
            txt_precov.SelectionStart = 0
            txt_precov.SelectionLength = 0
        End If
    End Sub

    Private Sub txt_precov_TextChanged(sender As Object, e As EventArgs) Handles txt_precov.TextChanged
        If String.IsNullOrWhiteSpace(txt_precov.Text) Then
            txt_precov.Text = "Preço de Venda"
            txt_precov.ForeColor = Color.DarkGray
            txt_precov.SelectionStart = 0
            Exit Sub
        End If

        If txt_precov.ForeColor = Color.DarkGray AndAlso txt_precov.Text <> "Preço de Venda" Then
            Dim textoDigitado As String = txt_precov.Text.Replace("Preço de Venda", "")
            If textoDigitado.Length > 0 Then
                txt_precov.ForeColor = Color.Black
                txt_precov.Text = textoDigitado
                txt_precov.SelectionStart = txt_precov.Text.Length
            End If
        End If
    End Sub

    Private Sub txt_precov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precov.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_precoc_Click(sender As Object, e As EventArgs) Handles txt_precoc.Click
        If txt_precoc.ForeColor = Color.DarkGray Then
            txt_precoc.SelectionStart = 0
            txt_precoc.SelectionLength = 0
        End If
    End Sub
    Private Sub txt_precoc_GotFocus(sender As Object, e As EventArgs) Handles txt_precoc.GotFocus
        If txt_precoc.Text = "Preço de Compra" AndAlso txt_precoc.ForeColor = Color.DarkGray Then
            txt_precoc.SelectionStart = 0
            txt_precoc.SelectionLength = 0
        End If
    End Sub

    Private Sub txt_precoc_TextChanged(sender As Object, e As EventArgs) Handles txt_precoc.TextChanged
        If String.IsNullOrWhiteSpace(txt_precoc.Text) Then
            txt_precoc.Text = "Preço de Compra"
            txt_precoc.ForeColor = Color.DarkGray
            txt_precoc.SelectionStart = 0
            Exit Sub
        End If

        If txt_precoc.ForeColor = Color.DarkGray AndAlso txt_precoc.Text <> "Preço de Compra" Then
            Dim textoDigitado As String = txt_precoc.Text.Replace("Preço de Compra", "")
            If textoDigitado.Length > 0 Then
                txt_precoc.ForeColor = Color.Black
                txt_precoc.Text = textoDigitado
                txt_precoc.SelectionStart = txt_precoc.Text.Length
            End If
        End If
    End Sub
    Private Sub txt_precoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precoc.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_quant_Click(sender As Object, e As EventArgs) Handles txt_quant.Click
        If txt_quant.ForeColor = Color.DarkGray Then
            txt_quant.SelectionStart = 0
            txt_quant.SelectionLength = 0
        End If
    End Sub
    Private Sub txt_quant_GotFocus(sender As Object, e As EventArgs) Handles txt_quant.GotFocus
        If txt_quant.Text = "Quantidade" AndAlso txt_quant.ForeColor = Color.DarkGray Then
            txt_quant.SelectionStart = 0
            txt_quant.SelectionLength = 0
        End If
    End Sub

    Private Sub txt_quant_TextChanged(sender As Object, e As EventArgs) Handles txt_quant.TextChanged
        If String.IsNullOrWhiteSpace(txt_quant.Text) Then
            txt_quant.Text = "Quantidade"
            txt_quant.ForeColor = Color.DarkGray
            txt_quant.SelectionStart = 0
            Exit Sub
        End If

        If txt_quant.ForeColor = Color.DarkGray AndAlso txt_quant.Text <> "Quantidade" Then
            Dim textoDigitado As String = txt_quant.Text.Replace("Quantidade", "")
            If textoDigitado.Length > 0 Then
                txt_quant.ForeColor = Color.Black
                txt_quant.Text = textoDigitado
                txt_quant.SelectionStart = txt_quant.Text.Length
            End If
        End If
    End Sub
    Private Sub txt_quant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_quant.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub AplicarPlaceholder(txt As TextBox, placeholder As String)
        If String.IsNullOrWhiteSpace(txt.Text) Then
            txt.Text = placeholder
            txt.ForeColor = Color.DarkGray
            txt.SelectionStart = 0
        End If
    End Sub


    Private Sub RemoverPlaceholder(txt As TextBox, placeholder As String)
        If txt.ForeColor = Color.DarkGray AndAlso txt.Text = placeholder Then

            txt.SelectionStart = 0
        ElseIf txt.ForeColor = Color.DarkGray Then

            txt.ForeColor = Color.Black
            txt.Text = txt.Text.Replace(placeholder, "")
            txt.SelectionStart = txt.Text.Length
        End If
    End Sub


    Private Sub VerificarPlaceholderVazio(txt As TextBox, placeholder As String)
        If String.IsNullOrWhiteSpace(txt.Text) Then
            AplicarPlaceholder(txt, placeholder)
        End If
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click

        If txt_nome.Text = "Nome" Or txt_quant.Text = "Quantidade" Or txt_precov.Text = "Preço de Venda" Or txt_precoc.Text = "Preço de Compra" Or cmb_categoria.SelectedIndex = -1 Then
            MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            AbrirConexao()

            Dim sql As String = "INSERT INTO produtos (nome, quantidade, precovenda, precocompra, categoria) VALUES (@nome, @quant, @precov, @precoc, @categoria)"
            Dim comando As New SqlCommand(sql, conexao)

            comando.Parameters.AddWithValue("@nome", txt_nome.Text)
            comando.Parameters.AddWithValue("@quant", txt_quant.Text)
            comando.Parameters.AddWithValue("@precov", txt_precov.Text)
            comando.Parameters.AddWithValue("@precoc", txt_precoc.Text)
            comando.Parameters.AddWithValue("@categoria", cmb_categoria.Text)

            comando.ExecuteNonQuery()

            MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)


            txt_nome.Text = "Nome"
            txt_nome.ForeColor = Color.DarkGray

            txt_quant.Text = "Quantidade"
            txt_quant.ForeColor = Color.DarkGray

            txt_precov.Text = "Preço de Venda"
            txt_precov.ForeColor = Color.DarkGray

            txt_precoc.Text = "Preço de Compra"
            txt_precoc.ForeColor = Color.DarkGray

            cmb_categoria.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Erro ao cadastrar: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharConexao()
        End Try
        CarregarDados()
    End Sub
    Public Sub CarregarDados()
        Try
            AbrirConexao()

            Dim sql As String = "SELECT * FROM produtos"
            Dim comando As New SqlCommand(sql, conexao)
            Dim adaptador As New SqlDataAdapter(comando)
            Dim tabela As New DataTable()

            adaptador.Fill(tabela)
            dgv_dados.DataSource = tabela

            AdicionarColunasAcaoEstoque()

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharConexao()
        End Try
    End Sub

    Private Sub LimparCampos()
        txt_nome.Text = "Nome"
        txt_nome.ForeColor = Color.DarkGray

        txt_quant.Text = "Quantidade"
        txt_quant.ForeColor = Color.DarkGray

        txt_precov.Text = "Preço de Venda"
        txt_precov.ForeColor = Color.DarkGray

        txt_precoc.Text = "Preço de Compra"
        txt_precoc.ForeColor = Color.DarkGray

        cmb_categoria.SelectedIndex = -1
    End Sub

    Private Sub AdicionarColunasAcaoEstoque()
        ' Coluna Editar
        Dim editarCol As New DataGridViewImageColumn()
        editarCol.Name = "Editar"
        editarCol.HeaderText = "Editar"
        editarCol.Image = Image.FromFile("icones/icone_editar.png") ' Caminho do ícone
        editarCol.ImageLayout = DataGridViewImageCellLayout.Zoom
        editarCol.Width = 30
        editarCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

        ' Coluna Excluir
        Dim excluirCol As New DataGridViewImageColumn()
        excluirCol.Name = "Excluir"
        excluirCol.HeaderText = "Excluir"
        excluirCol.Image = Image.FromFile("icones/icone_excluir.png")
        excluirCol.ImageLayout = DataGridViewImageCellLayout.Zoom
        excluirCol.Width = 30
        excluirCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None

        ' Adiciona as colunas apenas se ainda não estiverem presentes
        If Not dgv_dados.Columns.Contains("Editar") Then
            dgv_dados.Columns.Add(editarCol)
        End If
        If Not dgv_dados.Columns.Contains("Excluir") Then
            dgv_dados.Columns.Add(excluirCol)
        End If
    End Sub



    Private Sub cadastroprodutos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_menu.Show()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim idProduto As Integer = CInt(dgv_dados.Rows(e.RowIndex).Cells("id").Value)

        If dgv_dados.Columns(e.ColumnIndex).Name = "Editar" Then
            ' Chama função de carregar os dados do produto para edição
            CarregarProdutoParaEdicao(idProduto)
        ElseIf dgv_dados.Columns(e.ColumnIndex).Name = "Excluir" Then
            Dim resp = MessageBox.Show("Deseja excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = DialogResult.Yes Then
                Try
                    AbrirConexao()
                    Dim cmd As New SqlCommand("DELETE FROM produtos WHERE id = @id", conexao)
                    cmd.Parameters.AddWithValue("@id", idProduto)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Produto excluído com sucesso!")
                    CarregarDados() ' Recarrega o DataGridView
                Catch ex As Exception
                    MessageBox.Show("Erro ao excluir produto: " & ex.Message)
                Finally
                    FecharConexao()
                End Try
            End If
        End If
    End Sub

    Private Sub CarregarProdutoParaEdicao(id As Integer)
        Try
            AbrirConexao()
            Dim cmd As New SqlCommand("SELECT * FROM produtos WHERE id = @id", conexao)
            cmd.Parameters.AddWithValue("@id", id)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txt_nome.Text = reader("nome").ToString()
                txt_quant.Text = reader("quantidade").ToString()
                txt_precov.Text = reader("precovenda").ToString()
                txt_precoc.Text = reader("precocompra").ToString()

                Dim categoria = reader("categoria").ToString()
                Dim index As Integer = cmb_categoria.Items.IndexOf(categoria)
                If index >= 0 Then cmb_categoria.SelectedIndex = index

                ' Remove o placeholder se estiver usando
                txt_nome.ForeColor = Color.Black
                txt_quant.ForeColor = Color.Black
                txt_precov.ForeColor = Color.Black
                txt_precoc.ForeColor = Color.Black

                btn_salvar_edicao.Visible = True ' ou habilita botão de edição
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar produto para edição: " & ex.Message)
        Finally
            FecharConexao()
        End Try
    End Sub

    Private Sub btn_salvar_edicao_Click(sender As Object, e As EventArgs) Handles btn_salvar_edicao.Click
        ' Validações básicas
        If txt_nome.Text = "" OrElse txt_quant.Text = "" OrElse
           txt_precov.Text = "" OrElse txt_precoc.Text = "" OrElse
           cmb_categoria.SelectedIndex = -1 Then
            MessageBox.Show("Preencha todos os campos corretamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim idProduto As Integer = CInt(dgv_dados.CurrentRow.Cells("id").Value)
            Dim nome As String = txt_nome.Text.Trim()
            Dim quantidade As Integer = CInt(txt_quant.Text)
            Dim precoVenda As Decimal = Decimal.Parse(txt_precov.Text.Replace(",", "."), Globalization.CultureInfo.InvariantCulture)
            Dim precoCompra As Decimal = Decimal.Parse(txt_precoc.Text.Replace(",", "."), Globalization.CultureInfo.InvariantCulture)
            Dim categoria As String = cmb_categoria.SelectedItem.ToString()

            AbrirConexao()

            Dim sql As String = "UPDATE produtos SET nome = @nome, quantidade = @quantidade, precovenda = @precovenda, precocompra = @precocompra, categoria = @categoria WHERE id = @id"
            Dim cmd As New SqlCommand(sql, conexao)
            cmd.Parameters.AddWithValue("@id", idProduto)
            cmd.Parameters.AddWithValue("@nome", nome)
            cmd.Parameters.AddWithValue("@quantidade", quantidade)
            cmd.Parameters.AddWithValue("@precovenda", precoVenda)
            cmd.Parameters.AddWithValue("@precocompra", precoCompra)
            cmd.Parameters.AddWithValue("@categoria", categoria)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Atualiza o DataGridView
            CarregarDados()

            ' Limpa os campos
            LimparCampos()

            btn_salvar_edicao.Visible = False

        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar o produto: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharConexao()
        End Try
    End Sub

End Class
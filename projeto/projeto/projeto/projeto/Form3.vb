Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Web.Script.Serialization

Public Class cadastro_usuario
    Public PerfilUsuario As String

    Private Sub ConsultaCEP(cep As String)
        Try
            Dim url As String = $"https://viacep.com.br/ws/{cep}/json/"

            Dim request As WebRequest = WebRequest.Create(url)
            Dim response As WebResponse = request.GetResponse()

            Using dataStream As Stream = response.GetResponseStream()
                Using reader As New StreamReader(dataStream)
                    Dim responseFromServer As String = reader.ReadToEnd()

                    Dim js As New JavaScriptSerializer()
                    Dim endereco As Dictionary(Of String, Object) = js.Deserialize(Of Dictionary(Of String, Object))(responseFromServer)

                    If endereco.ContainsKey("erro") Then
                        MessageBox.Show("CEP não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        txt_endereco.Text = endereco("logradouro").ToString()
                        txt_endereco.ForeColor = Color.Black

                        txt_bairro.Text = endereco("bairro").ToString()
                        txt_bairro.ForeColor = Color.Black

                        txt_cidade.Text = endereco("localidade").ToString()
                        txt_cidade.ForeColor = Color.Black

                        txt_uf.Text = endereco("uf").ToString()
                        txt_uf.ForeColor = Color.Black
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o CEP: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cadastro_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarClientes()
        AdicionarColunasAcao()
        btn_salvar_edicao.Visible = False
        If PerfilUsuario.ToLower() = "gerente" Then
            btn_cadastro.Enabled = False
            btn_salvar_edicao.Enabled = False
        End If

        Me.ActiveControl = Nothing
        txt_nome.Text = "Nome"
        txt_nome.ForeColor = Color.DarkGray
        txt_data_nascimento.Text = "Data de Nascimento"
        txt_data_nascimento.ForeColor = Color.DarkGray
        txt_cpf.Text = "CPF"
        txt_cpf.ForeColor = Color.DarkGray
        txt_cep.Text = "CEP"
        txt_cep.ForeColor = Color.DarkGray
        txt_cep.MaxLength = 9
        txt_endereco.Text = "Endereço"
        txt_endereco.ForeColor = Color.DarkGray
        txt_bairro.Text = "Bairro"
        txt_bairro.ForeColor = Color.DarkGray
        txt_cidade.Text = "Cidade"
        txt_cidade.ForeColor = Color.DarkGray
        txt_uf.Text = "UF"
        txt_uf.ForeColor = Color.DarkGray
        txt_telefone.Text = "Telefone"
        txt_telefone.ForeColor = Color.DarkGray
        txt_numero.Text = "N°"
        txt_numero.ForeColor = Color.DarkGray

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

    Private Sub txt_cpf_Click(sender As Object, e As EventArgs) Handles txt_cpf.Click
        If txt_cpf.ForeColor = Color.DarkGray Then
            txt_cpf.SelectionStart = 0
            txt_cpf.SelectionLength = 0
        End If
    End Sub
    Private Sub txt_cpf_GotFocus(sender As Object, e As EventArgs) Handles txt_cpf.GotFocus
        If txt_cpf.Text = "CPF" AndAlso txt_cpf.ForeColor = Color.DarkGray Then
            txt_cpf.SelectionStart = 0
            txt_cpf.SelectionLength = 0
        End If
    End Sub
    Private Sub txt_cpf_TextChanged(sender As Object, e As EventArgs) Handles txt_cpf.TextChanged
        RemoveHandler txt_cpf.TextChanged, AddressOf txt_cpf_TextChanged

        ' Se estiver vazio, volta o placeholder
        If String.IsNullOrWhiteSpace(txt_cpf.Text) Then
            txt_cpf.Text = "CPF"
            txt_cpf.ForeColor = Color.DarkGray
            txt_cpf.SelectionStart = 0
            AddHandler txt_cpf.TextChanged, AddressOf txt_cpf_TextChanged
            Exit Sub
        End If

        ' Ao começar a digitar, remove o placeholder
        If txt_cpf.ForeColor = Color.DarkGray AndAlso txt_cpf.Text <> "CPF" Then
            txt_cpf.ForeColor = Color.Black
            txt_cpf.Text = txt_cpf.Text.Replace("CPF", "")
            txt_cpf.SelectionStart = txt_cpf.Text.Length
        End If

        ' Se já estiver digitando
        If txt_cpf.ForeColor = Color.Black Then
            ' Pega só os números
            Dim numeros As String = New String(txt_cpf.Text.Where(Function(c) Char.IsDigit(c)).ToArray())

            ' Limita a 11 dígitos
            If numeros.Length > 11 Then
                numeros = numeros.Substring(0, 11)
            End If

            ' Aplica a máscara: 000.000.000-00
            Dim formatado As String = ""
            Select Case numeros.Length
                Case <= 3
                    formatado = numeros
                Case <= 6
                    formatado = numeros.Substring(0, 3) & "." & numeros.Substring(3)
                Case <= 9
                    formatado = numeros.Substring(0, 3) & "." & numeros.Substring(3, 3) & "." & numeros.Substring(6)
                Case Else
                    formatado = numeros.Substring(0, 3) & "." & numeros.Substring(3, 3) & "." & numeros.Substring(6, 3) & "-" & numeros.Substring(9)
            End Select

            txt_cpf.Text = formatado
            txt_cpf.SelectionStart = txt_cpf.Text.Length
        End If

        AddHandler txt_cpf.TextChanged, AddressOf txt_cpf_TextChanged
    End Sub



    Private isEditingData As Boolean = False ' flag para evitar loop

    Private Sub txt_data_nascimento_Click(sender As Object, e As EventArgs) Handles txt_data_nascimento.Click
        If txt_data_nascimento.ForeColor = Color.DarkGray Then
            txt_data_nascimento.SelectionStart = 0
            txt_data_nascimento.SelectionLength = 0
        End If
    End Sub

    Private Sub txt_data_nascimento_GotFocus(sender As Object, e As EventArgs) Handles txt_data_nascimento.GotFocus
        If txt_data_nascimento.Text = "Data de Nascimento" AndAlso txt_data_nascimento.ForeColor = Color.DarkGray Then
            txt_data_nascimento.SelectionStart = 0
            txt_data_nascimento.SelectionLength = 0
        End If
    End Sub

    Private Sub txt_data_nascimento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_data_nascimento.KeyPress
        ' Impede caracteres não numéricos (exceto Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
            Exit Sub
        End If

        ' Se o texto ainda é o placeholder
        If txt_data_nascimento.Text = "Data de Nascimento" AndAlso txt_data_nascimento.ForeColor = Color.DarkGray Then
            If e.KeyChar = ChrW(Keys.Back) Then
                e.Handled = True ' Não faz nada com backspace no placeholder
                Exit Sub
            End If

            ' Substitui placeholder por caractere digitado
            txt_data_nascimento.Text = e.KeyChar.ToString()
            txt_data_nascimento.ForeColor = Color.Black
            txt_data_nascimento.SelectionStart = txt_data_nascimento.Text.Length
            e.Handled = True
        End If
    End Sub

    Private Sub txt_data_nascimento_TextChanged(sender As Object, e As EventArgs) Handles txt_data_nascimento.TextChanged
        ' Se for o placeholder, não formata
        If txt_data_nascimento.Text = "Data de Nascimento" AndAlso txt_data_nascimento.ForeColor = Color.DarkGray Then
            Exit Sub
        End If

        ' Se limpar o campo, volta o placeholder
        If txt_data_nascimento.Text.Trim() = "" Then
            txt_data_nascimento.Text = "Data de Nascimento"
            txt_data_nascimento.ForeColor = Color.DarkGray
            txt_data_nascimento.SelectionStart = 0
            Exit Sub
        End If

        ' Formatação da data
        Dim pos As Integer = txt_data_nascimento.SelectionStart
        Dim textoSemBarra As String = txt_data_nascimento.Text.Replace("/", "")
        textoSemBarra = New String(textoSemBarra.Where(Function(c) Char.IsDigit(c)).ToArray())

        If textoSemBarra.Length = 0 Then Exit Sub

        Dim textoFormatado As String = ""
        If textoSemBarra.Length <= 2 Then
            textoFormatado = textoSemBarra
        ElseIf textoSemBarra.Length <= 4 Then
            textoFormatado = textoSemBarra.Insert(2, "/")
        Else
            textoFormatado = textoSemBarra.Insert(2, "/").Insert(5, "/")
            If textoFormatado.Length > 10 Then
                textoFormatado = textoFormatado.Substring(0, 10)
            End If
        End If

        If txt_data_nascimento.Text <> textoFormatado Then
            txt_data_nascimento.Text = textoFormatado
            If pos = 3 Or pos = 6 Then
                pos += 1
            ElseIf pos > textoFormatado.Length Then
                pos = textoFormatado.Length
            End If
            txt_data_nascimento.SelectionStart = pos
        End If
    End Sub






    Private Sub txt_cep_TextChanged(sender As Object, e As EventArgs) Handles txt_cep.TextChanged
        If txt_cep.Focused = False Then Exit Sub


        If txt_cep.Text = "CEP" OrElse txt_cep.Text = "" Then Exit Sub


        Dim cepNumerico As String = New String(txt_cep.Text.Where(AddressOf Char.IsDigit).ToArray())


        If cepNumerico.Length > 8 Then
            cepNumerico = cepNumerico.Substring(0, 8)
        End If


        If cepNumerico.Length >= 6 Then
            txt_cep.Text = cepNumerico.Substring(0, 5) & "-" & cepNumerico.Substring(5)
        Else
            txt_cep.Text = cepNumerico
        End If

        txt_cep.SelectionStart = txt_cep.Text.Length
    End Sub

    Private Sub txt_cep_GotFocus(sender As Object, e As EventArgs) Handles txt_cep.GotFocus
        If txt_cep.Text = "CEP" Then
            txt_cep.Text = ""
            txt_cep.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        If txt_cep.Text = "" Then
            txt_cep.Text = "CEP"
            txt_cep.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub txt_cep_Leave(sender As Object, e As EventArgs) Handles txt_cep.Leave
        ' Retira possíveis espaços e caracteres não numéricos para consulta correta
        Dim cep As String = New String(txt_cep.Text.Where(Function(c) Char.IsDigit(c)).ToArray())

        If cep.Length = 8 Then
            ConsultaCEP(cep)

        End If
    End Sub

    Private Sub txt_telefone_Click(sender As Object, e As EventArgs) Handles txt_telefone.Click
        If txt_telefone.ForeColor = Color.DarkGray Then
            txt_telefone.SelectionStart = 0
            txt_telefone.SelectionLength = 0
        End If
    End Sub
    Private Sub txt_telefone_GotFocus(sender As Object, e As EventArgs) Handles txt_telefone.GotFocus
        If txt_telefone.Text = "Telefone" AndAlso txt_telefone.ForeColor = Color.DarkGray Then
            txt_telefone.SelectionStart = 0
            txt_telefone.SelectionLength = 0
        End If
    End Sub
    Private Sub txt_telefone_TextChanged(sender As Object, e As EventArgs) Handles txt_telefone.TextChanged
        RemoveHandler txt_telefone.TextChanged, AddressOf txt_telefone_TextChanged

        ' Se estiver vazio, volta o placeholder
        If String.IsNullOrWhiteSpace(txt_telefone.Text) Then
            txt_telefone.Text = "Telefone"
            txt_telefone.ForeColor = Color.DarkGray
            txt_telefone.SelectionStart = 0
            AddHandler txt_telefone.TextChanged, AddressOf txt_telefone_TextChanged
            Exit Sub
        End If

        ' Ao começar a digitar, remove o placeholder
        If txt_telefone.ForeColor = Color.DarkGray AndAlso txt_telefone.Text <> "Telefone" Then
            txt_telefone.ForeColor = Color.Black
            txt_telefone.Text = txt_telefone.Text.Replace("Telefone", "")
            txt_telefone.SelectionStart = txt_telefone.Text.Length
        End If

        ' Se já estiver digitando
        If txt_telefone.ForeColor = Color.Black Then
            Dim numeros As String = New String(txt_telefone.Text.Where(Function(c) Char.IsDigit(c)).ToArray())

            If numeros.Length > 11 Then
                numeros = numeros.Substring(0, 11)
            End If

            Dim formatado As String = ""
            Select Case numeros.Length
                Case <= 2
                    formatado = "(" & numeros
                Case <= 7
                    formatado = "(" & numeros.Substring(0, 2) & ") " & numeros.Substring(2)
                Case Else
                    formatado = "(" & numeros.Substring(0, 2) & ") " & numeros.Substring(2, 5) & "-" & numeros.Substring(7)
            End Select

            txt_telefone.Text = formatado
            txt_telefone.SelectionStart = txt_telefone.Text.Length
        End If

        AddHandler txt_telefone.TextChanged, AddressOf txt_telefone_TextChanged
    End Sub

    Private Sub btn_foto_Click(sender As Object, e As EventArgs) Handles btn_foto.Click
        Dim dialogo As New OpenFileDialog
        dialogo.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp"
        dialogo.Title = "Selecione uma foto do usuário"

        If dialogo.ShowDialog() = DialogResult.OK Then
            Try
                Dim origem As String = dialogo.FileName
                Dim pastaDestino As String = Application.StartupPath & "\Fotos"

                If Not IO.Directory.Exists(pastaDestino) Then
                    IO.Directory.CreateDirectory(pastaDestino)
                End If

                Dim nomeArquivo As String = IO.Path.GetFileName(origem)
                Dim destinoCompleto As String = IO.Path.Combine(pastaDestino, nomeArquivo)

                IO.File.Copy(origem, destinoCompleto, True)

                img_foto.Load(destinoCompleto)
                img_foto.SizeMode = PictureBoxSizeMode.StretchImage


                Dim caminhoImagem As String = destinoCompleto

            Catch ex As Exception
                MsgBox("Erro ao carregar imagem: " & ex.Message, MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        If CamposVazios() Then
            MessageBox.Show("Por favor, preencha todos os campos antes de cadastrar.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim dataNascimento As Date
        If Not Date.TryParseExact(txt_data_nascimento.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, dataNascimento) Then
            MessageBox.Show("Data de nascimento inválida. Use o formato dd/MM/yyyy.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            AbrirConexao()

            ' Verificar se o CPF já existe, exceto para o cliente que está sendo atualizado (se houver)
            Dim queryCheckCpf As String
            Dim cmdCheckCpf As SqlCommand

            If txt_nome.Tag Is Nothing Then
                ' Novo cadastro: verificar se CPF já existe
                queryCheckCpf = "SELECT COUNT(*) FROM tb_clientes WHERE cpf = @cpf"
                cmdCheckCpf = New SqlCommand(queryCheckCpf, conexao)
                cmdCheckCpf.Parameters.AddWithValue("@cpf", txt_cpf.Text.Trim())
            Else
                ' Atualização: verificar se CPF existe em outro cliente diferente deste
                queryCheckCpf = "SELECT COUNT(*) FROM tb_clientes WHERE cpf = @cpf AND id <> @id"
                cmdCheckCpf = New SqlCommand(queryCheckCpf, conexao)
                cmdCheckCpf.Parameters.AddWithValue("@cpf", txt_cpf.Text.Trim())
                cmdCheckCpf.Parameters.AddWithValue("@id", CInt(txt_nome.Tag))
            End If

            Dim countCpf As Integer = Convert.ToInt32(cmdCheckCpf.ExecuteScalar())

            If countCpf > 0 Then
                MessageBox.Show("O CPF informado já está cadastrado para outro cliente.", "CPF duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If txt_nome.Tag Is Nothing Then
                ' Inserir cliente usando a conexão aberta
                Dim query = "INSERT INTO tb_clientes (nome, cpf, data_nascimento, cep, endereco, numero, bairro, cidade, uf, telefone)" &
                        " VALUES (@nome, @cpf, @data_nascimento, @cep, @endereco, @numero, @bairro, @cidade, @uf, @telefone)"

                Using cmd As New SqlCommand(query, conexao)
                    cmd.Parameters.AddWithValue("@nome", txt_nome.Text.Trim())
                    cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text.Trim())
                    cmd.Parameters.AddWithValue("@data_nascimento", dataNascimento)
                    cmd.Parameters.AddWithValue("@cep", txt_cep.Text.Trim())
                    cmd.Parameters.AddWithValue("@endereco", txt_endereco.Text.Trim())
                    cmd.Parameters.AddWithValue("@numero", txt_numero.Text.Trim())
                    cmd.Parameters.AddWithValue("@bairro", txt_bairro.Text.Trim())
                    cmd.Parameters.AddWithValue("@cidade", txt_cidade.Text.Trim())
                    cmd.Parameters.AddWithValue("@uf", txt_uf.Text.Trim())
                    cmd.Parameters.AddWithValue("@telefone", txt_telefone.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                ' Atualizar cliente usando a conexão aberta
                Dim query As String = "UPDATE tb_clientes SET 
                               nome = @nome, 
                               cpf = @cpf, 
                               data_nascimento = @data_nascimento, 
                               cep = @cep, 
                               endereco = @endereco, 
                               numero = @numero, 
                               bairro = @bairro, 
                               cidade = @cidade, 
                               uf = @uf, 
                               telefone = @telefone 
                               WHERE id = @id"

                Using cmd As New SqlCommand(query, conexao)
                    cmd.Parameters.AddWithValue("@id", CInt(txt_nome.Tag))
                    cmd.Parameters.AddWithValue("@nome", txt_nome.Text.Trim())
                    cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text.Trim())
                    cmd.Parameters.AddWithValue("@data_nascimento", dataNascimento)
                    cmd.Parameters.AddWithValue("@cep", txt_cep.Text.Trim())
                    cmd.Parameters.AddWithValue("@endereco", txt_endereco.Text.Trim())
                    cmd.Parameters.AddWithValue("@numero", txt_numero.Text.Trim())
                    cmd.Parameters.AddWithValue("@bairro", txt_bairro.Text.Trim())
                    cmd.Parameters.AddWithValue("@cidade", txt_cidade.Text.Trim())
                    cmd.Parameters.AddWithValue("@uf", txt_uf.Text.Trim())
                    cmd.Parameters.AddWithValue("@telefone", txt_telefone.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Cliente atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_nome.Tag = Nothing
            End If

            LimparCampos()
            CarregarClientes()

        Catch ex As Exception
            MessageBox.Show("Erro ao cadastrar/atualizar cliente: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            FecharConexao()
        End Try
    End Sub

    Public Sub CarregarClientes()
        Try
            AbrirConexao()

            Dim sql As String = "SELECT * FROM tb_clientes" ' ajuste conforme sua tabela
            Dim cmd As New SqlCommand(sql, conexao)
            Dim dt As New DataTable()

            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

            dgv_clientes.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar clientes: " & ex.Message)
        Finally
            FecharConexao()
        End Try
    End Sub



    Private Function CamposVazios() As Boolean
        If String.IsNullOrWhiteSpace(txt_nome.Text) OrElse txt_nome.ForeColor = Color.DarkGray Then
            Return True
        End If
        If String.IsNullOrWhiteSpace(txt_cpf.Text) OrElse txt_cpf.ForeColor = Color.DarkGray Then
            Return True
        End If
        If String.IsNullOrWhiteSpace(txt_data_nascimento.Text) OrElse txt_data_nascimento.ForeColor = Color.DarkGray Then
            Return True
        End If
        If String.IsNullOrWhiteSpace(txt_cep.Text) OrElse txt_cep.ForeColor = Color.DarkGray Then
            Return True
        End If
        If String.IsNullOrWhiteSpace(txt_endereco.Text) OrElse txt_endereco.ForeColor = Color.DarkGray Then
            Return True
        End If
        If String.IsNullOrWhiteSpace(txt_numero.Text) OrElse txt_numero.ForeColor = Color.DarkGray Then
            Return True
        End If
        If String.IsNullOrWhiteSpace(txt_bairro.Text) OrElse txt_bairro.ForeColor = Color.DarkGray Then
            Return True
        End If
        If String.IsNullOrWhiteSpace(txt_cidade.Text) OrElse txt_cidade.ForeColor = Color.DarkGray Then
            Return True
        End If
        If String.IsNullOrWhiteSpace(txt_uf.Text) OrElse txt_uf.ForeColor = Color.DarkGray Then
            Return True
        End If
        If String.IsNullOrWhiteSpace(txt_telefone.Text) OrElse txt_telefone.ForeColor = Color.DarkGray Then
            Return True
        End If

        Return False
    End Function


    Private Sub LimparCampos()
        txt_nome.Text = "Nome"
        txt_nome.ForeColor = Color.DarkGray

        txt_data_nascimento.Text = "Data de Nascimento"
        txt_data_nascimento.ForeColor = Color.DarkGray

        txt_cep.Text = "CEP"
        txt_cep.ForeColor = Color.DarkGray

        txt_endereco.Text = "Endereço"
        txt_endereco.ForeColor = Color.DarkGray

        txt_numero.Text = "N°"
        txt_numero.ForeColor = Color.DarkGray

        txt_bairro.Text = "Bairro"
        txt_bairro.ForeColor = Color.DarkGray

        txt_cidade.Text = "Cidade"
        txt_cidade.ForeColor = Color.DarkGray

        txt_uf.Text = "UF"
        txt_uf.ForeColor = Color.DarkGray

        RemoveHandler txt_cpf.TextChanged, AddressOf txt_cpf_TextChanged
        txt_cpf.Text = "CPF"
        txt_cpf.ForeColor = Color.DarkGray
        txt_cpf.SelectionStart = 0
        AddHandler txt_cpf.TextChanged, AddressOf txt_cpf_TextChanged

        ' faça isso para os outros campos também se necessário

        ' Exemplo para telefone:
        RemoveHandler txt_telefone.TextChanged, AddressOf txt_telefone_TextChanged
        txt_telefone.Text = "Telefone"
        txt_telefone.ForeColor = Color.DarkGray
        txt_telefone.SelectionStart = 0
        AddHandler txt_telefone.TextChanged, AddressOf txt_telefone_TextChanged
        ' Se precisar, limpe outros campos aqui
    End Sub

    Private Sub txt_numero_Click(sender As Object, e As EventArgs) Handles txt_numero.Click
        If txt_numero.ForeColor = Color.DarkGray Then
            txt_numero.SelectionStart = 0
            txt_numero.SelectionLength = 0
        End If
    End Sub

    Private Sub txt_numero_GotFocus(sender As Object, e As EventArgs) Handles txt_numero.GotFocus
        If txt_numero.Text = "N°" AndAlso txt_numero.ForeColor = Color.DarkGray Then
            txt_numero.SelectionStart = 0
            txt_numero.SelectionLength = 0
        End If
    End Sub

    Private Sub txt_numero_TextChanged(sender As Object, e As EventArgs) Handles txt_numero.TextChanged
        If String.IsNullOrWhiteSpace(txt_numero.Text) Then
            txt_numero.Text = "N°"
            txt_numero.ForeColor = Color.DarkGray
            txt_numero.SelectionStart = 0
            Exit Sub
        End If

        ' Se o placeholder ainda estiver visível e o usuário digitar
        If txt_numero.ForeColor = Color.DarkGray AndAlso txt_numero.Text <> "N°" Then
            Dim textoDigitado As String = txt_numero.Text.Replace("N°", "")
            If textoDigitado.Length > 0 Then
                txt_numero.ForeColor = Color.Black
                txt_numero.Text = textoDigitado
                txt_numero.SelectionStart = txt_numero.Text.Length
            End If
        End If
    End Sub

    Private Sub cadastro_usuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_menu.Show()
    End Sub

    ' Evento do DataGridView que trata editar e excluir
    Private Sub dgv_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim cpfSelecionado As String = dgv_clientes.Rows(e.RowIndex).Cells("cpf").Value.ToString()

        ' Ação: EDITAR
        If dgv_clientes.Columns(e.ColumnIndex).Name = "Editar" Then
            Try
                AbrirConexao()

                Dim sql As String = "SELECT * FROM tb_clientes WHERE cpf = @cpf"
                Dim cmd As New SqlCommand(sql, conexao)
                cmd.Parameters.AddWithValue("@cpf", cpfSelecionado)

                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    txt_nome.Text = reader("nome").ToString()
                    txt_data_nascimento.Text = Convert.ToDateTime(reader("data_nascimento")).ToString("dd/MM/yyyy")
                    txt_cpf.Text = reader("cpf").ToString()
                    txt_cep.Text = reader("cep").ToString()
                    txt_endereco.Text = reader("endereco").ToString()
                    txt_numero.Text = reader("numero").ToString()
                    txt_bairro.Text = reader("bairro").ToString()
                    txt_cidade.Text = reader("cidade").ToString()
                    txt_uf.Text = reader("uf").ToString()
                    txt_telefone.Text = reader("telefone").ToString()

                    ' Remove estilo de placeholder
                    For Each ctrl In Me.Controls
                        If TypeOf ctrl Is TextBox Then
                            DirectCast(ctrl, TextBox).ForeColor = Color.Black
                        End If
                    Next

                    ' Mostra o botão salvar edição para o usuário poder confirmar as alterações
                    btn_salvar_edicao.Visible = True
                End If
                reader.Close()

            Catch ex As Exception
                MessageBox.Show("Erro ao buscar cliente: " & ex.Message)
            Finally
                FecharConexao()
            End Try

            ' Ação: EXCLUIR
        ElseIf dgv_clientes.Columns(e.ColumnIndex).Name = "Excluir" Then
            Dim confirmar = MessageBox.Show("Deseja realmente excluir o cliente com CPF: " & cpfSelecionado & "?",
                                        "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmar = DialogResult.Yes Then
                Try
                    AbrirConexao()

                    ' Verifica se o cliente está vinculado a pedidos
                    Dim verificaCmd As New SqlCommand("
                    SELECT COUNT(*) 
                    FROM pedidos 
                    WHERE idcliente = (SELECT id FROM tb_clientes WHERE cpf = @cpf)
                ", conexao)
                    verificaCmd.Parameters.AddWithValue("@cpf", cpfSelecionado)
                    Dim temPedidos As Integer = CInt(verificaCmd.ExecuteScalar())

                    If temPedidos > 0 Then
                        MessageBox.Show("Este cliente possui pedidos registrados e não pode ser excluído.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    ' Prossegue com a exclusão
                    Dim excluirCmd As New SqlCommand("DELETE FROM tb_clientes WHERE cpf = @cpf", conexao)
                    excluirCmd.Parameters.AddWithValue("@cpf", cpfSelecionado)
                    excluirCmd.ExecuteNonQuery()

                    MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CarregarClientes()
                    AdicionarColunasAcao()

                Catch ex As Exception
                    MessageBox.Show("Erro ao excluir cliente: " & ex.Message)
                Finally
                    FecharConexao()
                End Try
            End If
        End If
    End Sub




    Private Sub AdicionarColunasAcao()
        ' Coluna Editar
        Dim editarCol As New DataGridViewImageColumn()
        editarCol.Name = "Editar"
        editarCol.HeaderText = "Editar"
        editarCol.Image = Image.FromFile("icones/icone_editar.png") ' extensão correta
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
        If Not dgv_clientes.Columns.Contains("Editar") Then
            dgv_clientes.Columns.Add(editarCol)
        End If
        If Not dgv_clientes.Columns.Contains("Excluir") Then
            dgv_clientes.Columns.Add(excluirCol)
        End If
    End Sub

    Private Sub btn_salvar_edicao_Click(sender As Object, e As EventArgs) Handles btn_salvar_edicao.Click
        ' Validação básica
        If txt_cpf.Text = "CPF" OrElse String.IsNullOrWhiteSpace(txt_cpf.Text) Then
            MessageBox.Show("CPF inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txt_nome.Text = "Nome" OrElse String.IsNullOrWhiteSpace(txt_nome.Text) Then
            MessageBox.Show("Nome inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            AbrirConexao()

            Dim sql As String = "
            UPDATE tb_clientes SET 
                nome = @nome,
                data_nascimento = @data_nascimento,
                cep = @cep,
                endereco = @endereco,
                numero = @numero,
                bairro = @bairro,
                cidade = @cidade,
                uf = @uf,
                telefone = @telefone
            WHERE cpf = @cpf
        "

            Dim cmd As New SqlCommand(sql, conexao)
            cmd.Parameters.AddWithValue("@nome", txt_nome.Text)
            cmd.Parameters.AddWithValue("@data_nascimento", Date.ParseExact(txt_data_nascimento.Text, "dd/MM/yyyy", Nothing))
            cmd.Parameters.AddWithValue("@cep", txt_cep.Text)
            cmd.Parameters.AddWithValue("@endereco", txt_endereco.Text)
            cmd.Parameters.AddWithValue("@numero", txt_numero.Text)
            cmd.Parameters.AddWithValue("@bairro", txt_bairro.Text)
            cmd.Parameters.AddWithValue("@cidade", txt_cidade.Text)
            cmd.Parameters.AddWithValue("@uf", txt_uf.Text)
            cmd.Parameters.AddWithValue("@telefone", txt_telefone.Text)
            cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Dados do cliente atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Atualiza grid e ações
            CarregarClientes()
            AdicionarColunasAcao()

            ' Oculta o botão depois de salvar
            btn_salvar_edicao.Visible = False

            ' Opcional: limpa campos ou deixa pronto para novo cadastro
            ' LimparCampos()

        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar cliente: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharConexao()
        End Try

        LimparCampos()

    End Sub

    Private Sub SetPlaceholder(caixa As TextBox, texto As String)
        caixa.Text = texto
        caixa.ForeColor = Color.DarkGray
    End Sub



End Class
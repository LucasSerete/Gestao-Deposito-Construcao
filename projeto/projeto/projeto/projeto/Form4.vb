Imports System.Data.SqlClient

Public Class cadastrousuario

    Private caminhoImagem As String = String.Empty
    Public PerfilUsuario As String


    Private Sub AdicionarColunasAcaoUsuarios()
        If Not dgv_usuarios.Columns.Contains("Editar") Then
            Dim colEditar As New DataGridViewImageColumn()
            colEditar.Name = "Editar"
            colEditar.HeaderText = "Editar"
            colEditar.Image = Image.FromFile("icones/icone_editar.png")
            colEditar.Width = 50
            colEditar.ImageLayout = DataGridViewImageCellLayout.Zoom
            dgv_usuarios.Columns.Add(colEditar)
        End If

        If Not dgv_usuarios.Columns.Contains("Excluir") Then
            Dim colExcluir As New DataGridViewImageColumn()
            colExcluir.Name = "Excluir"
            colExcluir.HeaderText = "Excluir"
            colExcluir.Image = Image.FromFile("icones/icone_excluir.png")
            colExcluir.Width = 50
            colExcluir.ImageLayout = DataGridViewImageCellLayout.Zoom
            dgv_usuarios.Columns.Add(colExcluir)
        End If
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


    Private Sub txt_email_Click(sender As Object, e As EventArgs) Handles txt_email.Click
        If txt_email.ForeColor = Color.DarkGray Then
            txt_email.SelectionStart = 0
            txt_email.SelectionLength = 0
        End If
    End Sub

    Private Sub txt_email_GotFocus(sender As Object, e As EventArgs) Handles txt_email.GotFocus
        If txt_email.Text = "Email" AndAlso txt_email.ForeColor = Color.DarkGray Then
            txt_email.SelectionStart = 0
            txt_email.SelectionLength = 0
        End If
    End Sub

    Private Sub txt_email_TextChanged(sender As Object, e As EventArgs) Handles txt_email.TextChanged
        If String.IsNullOrWhiteSpace(txt_email.Text) Then
            txt_email.Text = "Email"
            txt_email.ForeColor = Color.DarkGray
            txt_email.SelectionStart = 0
            Exit Sub
        End If

        If txt_email.ForeColor = Color.DarkGray AndAlso txt_email.Text <> "Email" Then
            Dim textoDigitado As String = txt_email.Text.Replace("Email", "")
            If textoDigitado.Length > 0 Then
                txt_email.ForeColor = Color.Black
                txt_email.Text = textoDigitado
                txt_email.SelectionStart = txt_email.Text.Length
            End If
        End If
    End Sub







    Private Sub txt_senha_Click(sender As Object, e As EventArgs) Handles txt_senha.Click
        If txt_senha.ForeColor = Color.DarkGray Then
            txt_senha.SelectionStart = 0
            txt_senha.SelectionLength = 0
        End If
    End Sub

    Private Sub txt_senha_GotFocus(sender As Object, e As EventArgs) Handles txt_senha.GotFocus
        If txt_senha.Text = "Senha" AndAlso txt_senha.ForeColor = Color.DarkGray Then
            txt_senha.SelectionStart = 0
            txt_senha.SelectionLength = 0
        End If
    End Sub

    Private Sub txt_senha_TextChanged(sender As Object, e As EventArgs) Handles txt_senha.TextChanged
        If String.IsNullOrWhiteSpace(txt_senha.Text) Then
            txt_senha.UseSystemPasswordChar = False
            txt_senha.Text = "Senha"
            txt_senha.ForeColor = Color.DarkGray
            txt_senha.SelectionStart = 0
            Exit Sub
        End If

        If txt_senha.ForeColor = Color.DarkGray AndAlso txt_senha.Text <> "Senha" Then
            Dim textoDigitado As String = txt_senha.Text.Replace("Senha", "")
            If textoDigitado.Length > 0 Then
                txt_senha.ForeColor = Color.Black
                txt_senha.Text = textoDigitado
                txt_senha.SelectionStart = txt_senha.Text.Length
                txt_senha.UseSystemPasswordChar = True
            End If
        End If
    End Sub

    Private Sub cadastrousuario_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.ActiveControl = Nothing
        txt_cpf.Text = "CPF"
        txt_cpf.ForeColor = Color.DarkGray
        txt_cpf.SelectionStart = 0
    End Sub

    Private Sub cadastrousuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarUsuarios()
        AdicionarColunasAcaoUsuarios()
        btn_salvar_edicao.Visible = False
        dgv_usuarios.AllowUserToAddRows = False

        If PerfilUsuario.ToLower() = "gerente" Then
            btn_salvar.Enabled = False
            btn_salvar_edicao.Enabled = False
        End If

        txt_nome.Text = "Nome"
        txt_nome.ForeColor = Color.DarkGray

        txt_email.Text = "Email"
        txt_email.ForeColor = Color.DarkGray

        txt_senha.Text = "Senha"
        txt_senha.ForeColor = Color.DarkGray ' <- Aqui estava faltando!

        cmb_perfil.Items.Add("Vendedor")
        cmb_perfil.Items.Add("Estoquista")
        cmb_perfil.Items.Add("Caixa")
        cmb_perfil.Items.Add("Adm")
        cmb_perfil.Items.Add("Gerente")

        cmb_perfil.SelectedIndex = -1
        cmb_perfil.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub pic_user_Click(sender As Object, e As EventArgs) Handles pic_user.Click

    End Sub

    Private Sub btn_foto_Click(sender As Object, e As EventArgs) Handles btn_foto.Click
        Dim dialogo As New OpenFileDialog
        dialogo.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp"
        dialogo.Title = "Selecione uma foto do usuário"

        ' ←– GARANTE QUE A PASTA JA EXISTA ANTES DO SHOWDIALOG
        Dim pastaDestino As String = IO.Path.Combine(Application.StartupPath, "Fotos")
        If Not IO.Directory.Exists(pastaDestino) Then
            IO.Directory.CreateDirectory(pastaDestino)
        End If
        dialogo.InitialDirectory = pastaDestino
        ' ––>

        If dialogo.ShowDialog() = DialogResult.OK Then
            Try
                Dim origem As String = dialogo.FileName
                Dim nomeArquivo As String = IO.Path.GetFileName(origem)
                Dim destinoCompleto As String = IO.Path.Combine(pastaDestino, nomeArquivo)

                ' libera handle se já estiver carregado
                If IO.File.Exists(destinoCompleto) Then
                    If pic_user.Image IsNot Nothing Then
                        pic_user.Image.Dispose()
                        pic_user.Image = Nothing
                    End If
                End If

                IO.File.Copy(origem, destinoCompleto, True)

                pic_user.Load(destinoCompleto)
                pic_user.SizeMode = PictureBoxSizeMode.StretchImage

                caminhoImagem = destinoCompleto

            Catch ex As Exception
                MsgBox("Erro ao carregar imagem: " & ex.Message, MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        ' Validação básica
        If txt_nome.Text = "" Or txt_email.Text = "" Or txt_cpf.Text = "" Or txt_senha.Text = "" Or cmb_perfil.SelectedIndex = -1 Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation, "Atenção")
            Exit Sub
        End If

        If String.IsNullOrEmpty(caminhoImagem) Then
            MsgBox("Por favor, selecione uma foto antes de salvar.", MsgBoxStyle.Exclamation, "Atenção")
            Exit Sub
        End If

        ' VERIFICA SE CPF JÁ EXISTE
        If CPFExiste(txt_cpf.Text) Then
            MsgBox("CPF já cadastrado! Informe outro CPF.", MsgBoxStyle.Exclamation, "Aviso")
            txt_cpf.Focus()
            Exit Sub
        End If

        ' Continua com o cadastro
        Try
            AbrirConexao()

            Dim comando As New SqlCommand("INSERT INTO usuarios (nome, cpf, senha, perfil, email, foto) VALUES (@nome, @cpf, @senha, @perfil, @email, @foto)", conexao)
            comando.Parameters.AddWithValue("@nome", txt_nome.Text)
            comando.Parameters.AddWithValue("@cpf", txt_cpf.Text)
            comando.Parameters.AddWithValue("@senha", txt_senha.Text)
            comando.Parameters.AddWithValue("@perfil", cmb_perfil.Text)
            comando.Parameters.AddWithValue("@email", txt_email.Text)
            comando.Parameters.AddWithValue("@foto", caminhoImagem)

            comando.ExecuteNonQuery()

            MsgBox("Usuário cadastrado com sucesso!", MsgBoxStyle.Information, "Sucesso")

            Dim resposta = MsgBox("Deseja cadastrar outro usuário?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Continuar?")

            If resposta = MsgBoxResult.Yes Then
                ' Limpa os campos para novo cadastro
                txt_nome.Text = ""
                cmb_perfil.SelectedIndex = -1
                txt_email.Text = ""
                txt_cpf.Text = ""
                txt_senha.Text = ""
                pic_user.Image = Nothing
                caminhoImagem = String.Empty
            Else
                ' Volta ao menu
                Me.Hide()
                frm_menu.Show()
            End If

        Catch ex As Exception
            MsgBox("Erro ao salvar: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        Finally
            FecharConexao()
        End Try
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



    Private Sub cadastrousuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frm_menu.Show()
    End Sub

    Private Sub CarregarUsuarios()
        Try
            AbrirConexao()
            Dim dt As New DataTable()
            Dim sql As String = "SELECT id, nome, cpf, perfil, email FROM usuarios"
            Dim cmd As New SqlCommand(sql, conexao)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

            dgv_usuarios.DataSource = dt

            ' Opcional: ajustar cabeçalhos, largura etc.
            dgv_usuarios.Columns("id").HeaderText = "ID"
            dgv_usuarios.Columns("nome").HeaderText = "Nome"
            dgv_usuarios.Columns("cpf").HeaderText = "CPF"
            dgv_usuarios.Columns("perfil").HeaderText = "Perfil"
            dgv_usuarios.Columns("email").HeaderText = "E-mail"

            ' Se quiser esconder a coluna id, pode fazer:
            ' dgv_usuarios.Columns("id").Visible = False

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar usuários: " & ex.Message)
        Finally
            FecharConexao()
        End Try
    End Sub

    Private Function CPFExiste(cpf As String) As Boolean
        Try
            AbrirConexao()
            Dim sql As String = "SELECT COUNT(*) FROM usuarios WHERE cpf = @cpf"
            Dim cmd As New SqlCommand(sql, conexao)
            cmd.Parameters.AddWithValue("@cpf", cpf)
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            Return (count > 0)
        Catch ex As Exception
            MessageBox.Show("Erro ao verificar CPF: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True ' Evita cadastrar em caso de erro
        Finally
            FecharConexao()
        End Try
    End Function

    Private Sub dgv_usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim cpfSelecionado As String = dgv_usuarios.Rows(e.RowIndex).Cells("cpf").Value.ToString()

        ' === EDITAR ===
        If dgv_usuarios.Columns(e.ColumnIndex).Name = "Editar" Then
            Try
                AbrirConexao()
                Dim sql As String = "SELECT * FROM usuarios WHERE cpf = @cpf"
                Dim cmd As New SqlCommand(sql, conexao)
                cmd.Parameters.AddWithValue("@cpf", cpfSelecionado)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    txt_nome.Text = reader("nome").ToString()
                    txt_email.Text = reader("email").ToString()
                    txt_cpf.Text = reader("cpf").ToString()
                    txt_senha.Text = reader("senha").ToString()
                    cmb_perfil.Text = reader("perfil").ToString()

                    For Each ctrl In Me.Controls
                        If TypeOf ctrl Is TextBox Then
                            DirectCast(ctrl, TextBox).ForeColor = Color.Black
                        End If
                    Next

                    btn_salvar_edicao.Visible = True
                End If
                reader.Close()

            Catch ex As Exception
                MessageBox.Show("Erro ao carregar dados do usuário: " & ex.Message)
            Finally
                FecharConexao()
            End Try

            ' === EXCLUIR ===
        ElseIf dgv_usuarios.Columns(e.ColumnIndex).Name = "Excluir" Then
            Dim confirmar = MessageBox.Show("Deseja realmente excluir o usuário com CPF: " & cpfSelecionado & "?",
                                        "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmar = DialogResult.Yes Then
                Try
                    AbrirConexao()
                    Dim cmdDel As New SqlCommand("DELETE FROM usuarios WHERE cpf = @cpf", conexao)
                    cmdDel.Parameters.AddWithValue("@cpf", cpfSelecionado)
                    cmdDel.ExecuteNonQuery()

                    MessageBox.Show("Usuário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CarregarUsuarios()
                    AdicionarColunasAcaoUsuarios()

                Catch ex As Exception
                    MessageBox.Show("Erro ao excluir usuário: " & ex.Message)
                Finally
                    FecharConexao()
                End Try
            End If
        End If
    End Sub

    Private Sub btn_salvar_edicao_Click(sender As Object, e As EventArgs) Handles btn_salvar_edicao.Click
        If txt_nome.Text = "Nome" Or txt_email.Text = "Email" Or txt_cpf.Text = "CPF" Or txt_senha.Text = "Senha" Or cmb_perfil.SelectedIndex = -1 Then
            MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            AbrirConexao()

            Dim sql As String = "UPDATE usuarios SET nome = @nome, email = @email, senha = @senha, perfil = @perfil WHERE cpf = @cpf"
            Dim cmd As New SqlCommand(sql, conexao)
            cmd.Parameters.AddWithValue("@nome", txt_nome.Text)
            cmd.Parameters.AddWithValue("@email", txt_email.Text)
            cmd.Parameters.AddWithValue("@senha", txt_senha.Text)
            cmd.Parameters.AddWithValue("@perfil", cmb_perfil.Text)
            cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Atualiza o DataGrid e limpa os campos
            CarregarUsuarios()
            LimparCamposUsuarios()
            btn_salvar_edicao.Visible = False

        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar usuário: " & ex.Message)
        Finally
            FecharConexao()
        End Try
    End Sub

    Private Sub LimparCamposUsuarios()
        SetPlaceholder(txt_nome, "Nome")
        SetPlaceholder(txt_email, "Email")
        SetPlaceholder(txt_cpf, "CPF")
        SetPlaceholder(txt_senha, "Senha")
        cmb_perfil.SelectedIndex = -1
    End Sub

    Private Sub SetPlaceholder(caixa As TextBox, texto As String)
        caixa.Text = texto
        caixa.ForeColor = Color.DarkGray
    End Sub


End Class
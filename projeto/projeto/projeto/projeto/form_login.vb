Imports System.Data.SqlClient
Imports System.Security.Claims

Public Class form_login

    Private Const adminUsuario As String = "admin"
    Private Const adminSenha As String = "123"

    Private Sub txt_usuario_GotFocus(sender As Object, e As EventArgs) Handles txt_usuario.GotFocus
        If txt_usuario.Text = "Usuário" Then
            txt_usuario.Text = ""
            txt_usuario.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_usuario_LostFocus(sender As Object, e As EventArgs) Handles txt_usuario.LostFocus
        If txt_usuario.Text = "" Then
            txt_usuario.Text = "Usuário"
            txt_usuario.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txt_senha_GotFocus(sender As Object, e As EventArgs) Handles txt_senha.GotFocus
        If txt_senha.Text = "Senha" Then
            txt_senha.Text = ""
            txt_senha.PasswordChar = "*"
            txt_senha.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_senha_LostFocus(sender As Object, e As EventArgs) Handles txt_senha.LostFocus
        If txt_senha.Text = "" Then
            txt_senha.Text = "Senha"
            txt_senha.PasswordChar = ""
            txt_senha.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.
            txt_usuario.Text = "Usuário"
        txt_usuario.ForeColor = Color.DarkGray

        txt_senha.Text = "Senha"
        txt_senha.ForeColor = Color.DarkGray
    End Sub

    Private Sub form_login_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.ActiveControl = Nothing
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        ' Verifica se é o usuário admin fixo
        If txt_usuario.Text = "admin" AndAlso txt_senha.Text = "admin" Then
            frm_menu.lbl_nome.Text = "admin"
            frm_menu.lbl_funcao.Text = "Administrador"
            frm_menu.CaminhoFotoUsuario = ""

            ' Admin tem acesso total — não precisa esconder nada
            frm_menu.Show()
            Me.Hide()
            Return
        End If

        AbrirConexao()

        Try
            Dim comando As New SqlCommand("SELECT * FROM usuarios WHERE nome = @nome AND senha = @senha", conexao)
            comando.Parameters.AddWithValue("@nome", txt_usuario.Text)
            comando.Parameters.AddWithValue("@senha", txt_senha.Text)

            Dim leitor As SqlDataReader = comando.ExecuteReader()

            If leitor.HasRows Then
                leitor.Read()

                frm_menu.lbl_nome.Text = leitor("nome").ToString()
                frm_menu.lbl_funcao.Text = leitor("perfil").ToString()
                frm_menu.CaminhoFotoUsuario = leitor("foto").ToString()
                frm_menu.perfilUsuarioLogado = leitor("perfil").ToString()

                Dim perfil As String = leitor("perfil").ToString().ToLower()

                Select Case perfil
                    Case "vendedor"
                        frm_menu.btn_estoque.Enabled = False
                        frm_menu.btn_caixa.Enabled = False
                        frm_menu.btn_usuarios.Enabled = False
                    Case "estoquista"
                        frm_menu.btn_pedidos.Enabled = False
                        frm_menu.btn_caixa.Enabled = False
                        frm_menu.btn_usuarios.Enabled = False
                    Case "caixa"
                        frm_menu.btn_pedidos.Enabled = False
                        frm_menu.btn_estoque.Enabled = False
                        frm_menu.btn_usuarios.Enabled = False
                    Case "adm", "gerente"
                        ' Acesso total — todos os botões permanecem habilitados
                    Case Else
                        MessageBox.Show("Perfil de usuário desconhecido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                End Select

                frm_menu.Show()
                Me.Hide()
            Else
                MessageBox.Show("Usuário ou senha inválidos!", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar: " & ex.Message)
        Finally
            conexao.Close()
        End Try
    End Sub

    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged

    End Sub
End Class

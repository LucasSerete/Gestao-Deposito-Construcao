Public Class frm_menu

    Public perfilUsuarioLogado As String
    Public Property CaminhoFotoUsuario As String

    Private Sub btn_acessoC_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        cadastro_usuario.PerfilUsuario = Me.lbl_funcao.Text ' <-- Passa o perfil
        cadastro_usuario.Show()
        Me.Hide()
    End Sub

    Private Sub btn_acessoU_Click(sender As Object, e As EventArgs) Handles btn_usuarios.Click
        cadastrousuario.PerfilUsuario = Me.lbl_funcao.Text ' <-- Passa o perfil
        cadastrousuario.Show()
        Me.Hide()
    End Sub

    Private Sub btn_acessoP_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click
        frm_pedidos.PerfilUsuario = Me.lbl_funcao.Text
        frm_pedidos.Show()
        Me.Hide()
    End Sub

    Private Sub btn_mudar_usuario_Click(sender As Object, e As EventArgs) Handles btn_mudar_usuario.Click
        form_login.Show()
        Me.Close()
    End Sub

    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AplicarPermissoes()
    End Sub

    Private Sub AplicarPermissoes()
        If String.IsNullOrWhiteSpace(perfilUsuarioLogado) Then
            Exit Sub
        End If
        Select Case perfilUsuarioLogado.ToLower()
            Case "adm", "gerente"
            ' Acesso total, não esconde nada

            Case "vendedor"
                btn_clientes.Enabled = False
                btn_estoque.Enabled = False
                btn_usuarios.Enabled = False
                btn_caixa.Enabled = False

            Case "estoquista"
                btn_clientes.Enabled = False
                btn_pedidos.Enabled = False
                btn_usuarios.Enabled = False
                btn_caixa.Enabled = False

            Case "caixa"
                btn_clientes.Enabled = False
                btn_pedidos.Enabled = False
                btn_usuarios.Enabled = False
                btn_estoque.Enabled = False
        End Select

        If Not String.IsNullOrEmpty(CaminhoFotoUsuario) AndAlso IO.File.Exists(CaminhoFotoUsuario) Then
            pic_usuario.Load(CaminhoFotoUsuario)
            pic_usuario.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            pic_usuario.Image = Nothing
        End If
    End Sub

    Private Sub btn_acessoD_Click(sender As Object, e As EventArgs) Handles btn_estoque.Click
        cadastroprodutos.PerfilUsuario = Me.lbl_funcao.Text
        cadastroprodutos.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_caixa.Click
        frm_caixa.PerfilUsuario = Me.lbl_funcao.Text
        frm_caixa.Show()
        Me.Hide()
    End Sub
End Class
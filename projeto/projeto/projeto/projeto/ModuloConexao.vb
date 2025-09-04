Imports System.Data.SqlClient

Module ModuloConexao
    Public conexao As SqlConnection

    Public Sub AbrirConexao()
        Try
            conexao = New SqlConnection("Server=localhost\SQLEXPRESS;Database=Deposito_Materiais;Trusted_Connection=True;")
            conexao.Open()
        Catch ex As Exception
            MessageBox.Show("Erro ao conectar: " & ex.Message)
        End Try
    End Sub

    Public Sub FecharConexao()
        If conexao IsNot Nothing AndAlso conexao.State = ConnectionState.Open Then
            conexao.Close()
        End If
    End Sub




End Module

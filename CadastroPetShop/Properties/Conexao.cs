using System;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace CadastroPetShop
{
    public static class Autenticacao
    {
        private static readonly string stringConexao = "Server=localhost;Database=petshop_tecnico;Uid=root;Pwd=;";

        public static bool Validar(string usuario, string senha)
        {
            using (var conexao = new MySqlConnection(stringConexao))
            {
                conexao.Open();

                using (var cmd = new MySqlCommand("SELECT senha_hash FROM usuarios WHERE usuario = @usuario", conexao))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    var resultado = cmd.ExecuteScalar();

                    return resultado != null && BCrypt.Net.BCrypt.Verify(senha, resultado.ToString());
                }
            }
        }

        public static string GerarHashSenha(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }
    }
}
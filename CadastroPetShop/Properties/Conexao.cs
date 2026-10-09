using MySql.Data.MySqlClient;
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

                using (var cmd = new MySqlCommand("SELECT senha_hash FROM usuarios WHERE usuario = @usuario LIMIT 1", conexao))
                {
                    cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = usuario;
                    var resultado = cmd.ExecuteScalar();
                    var senhaHash = Convert.ToString(resultado)?.Trim();

                    return !string.IsNullOrWhiteSpace(senhaHash)
                        && BCrypt.Net.BCrypt.Verify(senha, senhaHash);
                }
            }
        }

        public static string GerarHashSenha(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }
    }
}
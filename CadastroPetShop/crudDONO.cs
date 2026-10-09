using System;
using System.Data;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CadastroPetShop
{
    public partial class crudDONO : Form
    {
        private readonly string connStr = "Server=localhost;Database=petshop_tecnico;Uid=root;Pwd=;";
        private static readonly HttpClient httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(5) };
        private int idDonoSelecionado = 0;

        public crudDONO()
        {
            InitializeComponent();
            btnSalvar.Click += async (s, e) => await SalvarDono(false);
            btnAlterar.Click += async (s, e) => await SalvarDono(true);
            btnExcluir.Click += BtnExcluir_Click;
            btnLimpar.Click += (s, e) => LimparCampos();
            dgvDonos.CellClick += DgvDonos_CellClick;
            CarregarDonos();
        }

        private void CarregarDonos()
        {
            try
            {
                using MySqlConnection conexao = new MySqlConnection(connStr);
                using MySqlDataAdapter adaptador = new MySqlDataAdapter(
                    "SELECT id_dono AS ID, cpf AS CPF, nome AS Nome, telefone AS Telefone, email AS Email, endereco AS CEP FROM donos",
                    conexao);

                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dgvDonos.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os donos:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SalvarDono(bool alteracao)
        {
            if (alteracao && idDonoSelecionado == 0)
            {
                MessageBox.Show("Selecione um dono para alterar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Preencha o nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            if (!txtCpf.MaskCompleted)
            {
                MessageBox.Show("Preencha o CPF completo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                return;
            }

            if (!txtEndereco.MaskCompleted)
            {
                MessageBox.Show("Informe um CEP com 8 dígitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndereco.Focus();
                return;
            }

            if (!await CepExisteAsync(txtEndereco.Text))
                return;

            string sql = alteracao
                ? "UPDATE donos SET cpf = @cpf, nome = @nome, telefone = @telefone, email = @email, endereco = @endereco WHERE id_dono = @id"
                : "INSERT INTO donos (cpf, nome, telefone, email, endereco) VALUES (@cpf, @nome, @telefone, @email, @endereco)";

            try
            {
                using MySqlConnection conexao = new MySqlConnection(connStr);
                using MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@cpf", txtCpf.Text.Trim());
                comando.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                comando.Parameters.AddWithValue("@telefone", txtTelefone.Text.Trim());
                comando.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                comando.Parameters.AddWithValue("@endereco", txtEndereco.Text.Trim());

                if (alteracao)
                    comando.Parameters.AddWithValue("@id", idDonoSelecionado);

                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show(alteracao ? "Dono alterado com sucesso." : "Dono cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                CarregarDonos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o dono:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> CepExisteAsync(string cep)
        {
            try
            {
                using HttpResponseMessage resposta = await httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
                resposta.EnsureSuccessStatusCode();
                using JsonDocument dados = JsonDocument.Parse(await resposta.Content.ReadAsStringAsync());
                return !dados.RootElement.TryGetProperty("erro", out JsonElement erro) || !erro.GetBoolean();
            }
            catch (HttpRequestException)
            {
                return false;
            }
            catch (TaskCanceledException)
            {
                return false;
            }
            catch (JsonException)
            {
                return false;
            }
        }

        private void BtnExcluir_Click(object? sender, EventArgs e)
        {
            if (idDonoSelecionado == 0)
            {
                MessageBox.Show("Selecione um dono para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja excluir o dono selecionado?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using MySqlConnection conexao = new MySqlConnection(connStr);
                using MySqlCommand comando = new MySqlCommand(
                    "DELETE FROM donos WHERE id_dono = @id", conexao);

                comando.Parameters.AddWithValue("@id", idDonoSelecionado);
                conexao.Open();
                comando.ExecuteNonQuery();

                LimparCampos();
                CarregarDonos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível excluir o dono.\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvDonos_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow linha = dgvDonos.Rows[e.RowIndex];

            if (linha.Cells["ID"].Value == null)
            {
                return;
            }

            idDonoSelecionado = Convert.ToInt32(linha.Cells["ID"].Value);
            txtCpf.Text = linha.Cells["CPF"].Value?.ToString();
            txtNome.Text = linha.Cells["Nome"].Value?.ToString();
            string telefone = linha.Cells["Telefone"].Value?.ToString() ?? "";
            txtTelefone.Mask = telefone.Length == 10 ? "(00) 0000-0000" : "(00) 00000-0000";
            txtTelefone.Text = telefone;
            txtEmail.Text = linha.Cells["Email"].Value?.ToString();
            txtEndereco.Text = linha.Cells["CEP"].Value?.ToString();
        }

        private void LimparCampos()
        {
            idDonoSelecionado = 0;
            txtCpf.Clear();
            txtNome.Clear();
            txtTelefone.Mask = "(00) 90000-0000";
            txtTelefone.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtCpf.Focus();
        }

    }
}

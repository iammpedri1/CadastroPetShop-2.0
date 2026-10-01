using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CadastroPetShop
{
    public partial class crudDONO : Form
    {
        private readonly string connStr = "Server=localhost;Database=petshop_tecnico;Uid=root;Pwd=;";
        private int idDonoSelecionado = 0;

        public crudDONO()
        {
            InitializeComponent();
            btnSalvar.Click += (s, e) => SalvarDono(false);
            btnAlterar.Click += (s, e) => SalvarDono(true);
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
                    "SELECT id_dono AS ID, cpf AS CPF, nome AS Nome, telefone AS Telefone, email AS Email, endereco AS Endereço FROM donos",
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

        private void SalvarDono(bool alteracao)
        {
            if (alteracao && idDonoSelecionado == 0)
            {
                MessageBox.Show("Selecione um dono para alterar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CpfValido(txtCpf.Text))
            {
                MessageBox.Show("Informe um CPF válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) &&
                !Regex.IsMatch(txtEmail.Text.Trim(), @"^[^\s@]+@[^\s@]+\.[^\s@]+$"))
            {
                MessageBox.Show("Informe um e-mail válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCpf.Text) || string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o CPF e o nome do dono.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                return;
            }

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
                {
                    comando.Parameters.AddWithValue("@id", idDonoSelecionado);
                }

                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show(
                    alteracao ? "Dono alterado com sucesso." : "Dono cadastrado com sucesso.",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                CarregarDonos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o dono:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtTelefone.Text = linha.Cells["Telefone"].Value?.ToString();
            txtEmail.Text = linha.Cells["Email"].Value?.ToString();
            txtEndereco.Text = linha.Cells["Endereço"].Value?.ToString();
        }

        private void LimparCampos()
        {
            idDonoSelecionado = 0;
            txtCpf.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtCpf.Focus();
        }

        private bool CpfValido(string cpf)
        {
            string numeros = Regex.Replace(cpf, "[^0-9]", "");

            if (numeros.Length != 11 || new string(numeros[0], 11) == numeros)
            {
                return false;
            }

            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(numeros[i].ToString()) * (10 - i);
            }

            int primeiroDigito = (soma * 10) % 11;
            if (primeiroDigito == 10) primeiroDigito = 0;

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(numeros[i].ToString()) * (11 - i);
            }

            int segundoDigito = (soma * 10) % 11;
            if (segundoDigito == 10) segundoDigito = 0;

            return primeiroDigito == int.Parse(numeros[9].ToString()) &&
                   segundoDigito == int.Parse(numeros[10].ToString());
        }
    }
}

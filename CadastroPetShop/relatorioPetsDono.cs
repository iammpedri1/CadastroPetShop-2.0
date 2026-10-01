using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CadastroPetShop
{
    public class relatorioPetsDono : Form
    {
        private readonly string connStr = "Server=localhost;Database=petshop_tecnico;Uid=root;Pwd=;";
        private readonly ComboBox cmbDono = new ComboBox();
        private readonly Button btnGerar = new Button();
        private readonly DataGridView dgvPets = new DataGridView();

        public relatorioPetsDono()
        {
            Text = "Relatório de PETs por dono";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(800, 500);

            Label lblDono = new Label
            {
                Text = "Dono:",
                Location = new Point(20, 20),
                AutoSize = true
            };

            cmbDono.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDono.Location = new Point(70, 16);
            cmbDono.Size = new Size(280, 25);

            btnGerar.Text = "Gerar relatório";
            btnGerar.Location = new Point(365, 16);
            btnGerar.Size = new Size(130, 25);
            btnGerar.Click += (s, e) => CarregarPets();

            dgvPets.Location = new Point(20, 65);
            dgvPets.Size = new Size(740, 370);
            dgvPets.ReadOnly = true;
            dgvPets.AllowUserToAddRows = false;
            dgvPets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Controls.Add(lblDono);
            Controls.Add(cmbDono);
            Controls.Add(btnGerar);
            Controls.Add(dgvPets);

            CarregarDonos();
        }

        private void CarregarDonos()
        {
            try
            {
                using MySqlConnection conexao = new MySqlConnection(connStr);
                using MySqlDataAdapter adaptador = new MySqlDataAdapter(
                    "SELECT id_dono, nome FROM donos ORDER BY nome", conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);

                cmbDono.DataSource = tabela;
                cmbDono.DisplayMember = "nome";
                cmbDono.ValueMember = "id_dono";
                cmbDono.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar donos:\n{ex.Message}", "Erro");
            }
        }

        private void CarregarPets()
        {
            if (cmbDono.SelectedValue == null)
            {
                MessageBox.Show("Selecione um dono.", "Atenção");
                return;
            }

            try
            {
                using MySqlConnection conexao = new MySqlConnection(connStr);
                using MySqlCommand comando = new MySqlCommand(
                    @"SELECT p.id_pet AS ID, p.nome AS PET, p.especie AS Espécie,
                             p.idade AS Idade, p.porte AS Porte, p.sexo AS Sexo
                      FROM pets p
                      WHERE p.id_dono = @id_dono
                      ORDER BY p.nome", conexao);
                comando.Parameters.AddWithValue("@id_dono", cmbDono.SelectedValue);

                using MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dgvPets.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar relatório:\n{ex.Message}", "Erro");
            }
        }
    }
}

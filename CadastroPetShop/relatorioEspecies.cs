using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CadastroPetShop
{
    public class relatorioEspecies : Form
    {
        private readonly string connStr = "Server=localhost;Database=petshop_tecnico;Uid=root;Pwd=;";
        private readonly DataGridView dgvEspecies = new DataGridView();

        public relatorioEspecies()
        {
            Text = "Quantidade de PETs por espécie";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(550, 450);

            dgvEspecies.Location = new Point(20, 20);
            dgvEspecies.Size = new Size(490, 350);
            dgvEspecies.ReadOnly = true;
            dgvEspecies.AllowUserToAddRows = false;
            dgvEspecies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEspecies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Controls.Add(dgvEspecies);

            CarregarQuantidade();
        }

        private void CarregarQuantidade()
        {
            try
            {
                using MySqlConnection conexao = new MySqlConnection(connStr);
                using MySqlDataAdapter adaptador = new MySqlDataAdapter(
                    @"SELECT especie AS Espécie, COUNT(*) AS Quantidade
                      FROM pets
                      GROUP BY especie
                      ORDER BY Quantidade DESC", conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dgvEspecies.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar relatório:\n{ex.Message}", "Erro");
            }
        }
    }
}

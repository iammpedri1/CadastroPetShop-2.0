using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CadastroPetShop
{
    public partial class crudPet : Form
    {
        private readonly string connStr = "Server=localhost;Database=petshop_tecnico;Uid=root;Pwd=;";
        private int idPetSelecionado = 0;
        private Image? fotoPetSelecionada;

        public crudPet()
        {
            InitializeComponent();
            pnlCard.Paint += (s, e) => DesenharCard(e);
            cmbDono.SelectedIndexChanged += CmbDono_SelectedIndexChanged;
            btnSalvar.Click += (s, e) => SalvarPet(false);
            btnAlterar.Click += (s, e) => SalvarPet(true);
            btnExcluir.Click += BtnExcluir_Click;
            btnLimpar.Click += (s, e) => LimparCampos();
            dgvPets.CellClick += DgvPets_CellClick;
            btnPesquisar.Click += (s, e) => CarregarPets(txtPesquisa.Text.Trim());
            btnFoto.Click += BtnFoto_Click;

            if (!DesignMode)
            {
                CarregarDonos();
                CarregarPets();
            }
        }

        private DataTable BuscarTabela(string sql)
        {
            using var conexao = new MySqlConnection(connStr);
            var dt = new DataTable();
            new MySqlDataAdapter(sql, conexao).Fill(dt);
            return dt;
        }

        private void CarregarDonos()
        {
            try
            {
                cmbDono.DataSource = BuscarTabela("SELECT id_dono, nome, telefone, email FROM donos");
                cmbDono.DisplayMember = "nome";
                cmbDono.ValueMember = "id_dono";
                cmbDono.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os donos:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pnlVacina_Paint(object? sender, PaintEventArgs e)
        {
        }
        private void CarregarPets(string filtro = "")
        {
            string sql = @"SELECT p.id_pet AS ID, p.nome AS PET, d.nome AS Dono, 
                                  p.idade AS Idade, p.porte AS Porte, p.sexo AS Sexo, 
                                  p.especie AS Espécie, p.cor AS Cor, p.raca AS Raça, 
                                  IF(p.vacina_raiva=1, 'Sim', 'Não') AS Vacina, 
                                  IF(p.castrado=1, 'Sim', 'Não') AS Castrado, 
                                  p.doencas AS Doenças 
                           FROM pets p INNER JOIN donos d ON p.id_dono = d.id_dono
                           WHERE p.nome LIKE @filtro OR d.nome LIKE @filtro";

            try
            {
                using var conexao = new MySqlConnection(connStr);
                using var comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@filtro", $"%{filtro}%");
                using var adaptador = new MySqlDataAdapter(comando);
                var tabela = new DataTable();
                adaptador.Fill(tabela);
                dgvPets.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os PETs:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFoto_Click(object? sender, EventArgs e)
        {
            using OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";
            dialogo.Title = "Selecione a foto do PET";

            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            using Image imagem = Image.FromFile(dialogo.FileName);
            fotoPetSelecionada?.Dispose();
            fotoPetSelecionada = new Bitmap(imagem);
            picFoto.Image = fotoPetSelecionada;
        }

        private void SalvarPet(bool Alteracao)
        {
            if (Alteracao && idPetSelecionado == 0) return;
            if (cmbDono.SelectedValue == null || string.IsNullOrWhiteSpace(txtNome.Text)) return;

            string sql = Alteracao
                ? "UPDATE pets SET nome=@nome, idade=@idade, porte=@porte, sexo=@sexo, vacina_raiva=@vacina, especie=@especie, cor=@cor, raca=@raca, castrado=@castrado, doencas=@doencas, id_dono=@id_dono WHERE id_pet=@id"
                : "INSERT INTO pets (nome, idade, porte, sexo, vacina_raiva, especie, cor, raca, castrado, doencas, id_dono) VALUES (@nome, @idade, @porte, @sexo, @vacina, @especie, @cor, @raca, @castrado, @doencas, @id_dono)";

            try
            {
                using var conexao = new MySqlConnection(connStr);
                using var cmd = new MySqlCommand(sql, conexao);
                conexao.Open();

                if (Alteracao) cmd.Parameters.AddWithValue("@id", idPetSelecionado);

                int.TryParse(txtIdade.Text, out int idade);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                cmd.Parameters.AddWithValue("@idade", idade);
                cmd.Parameters.AddWithValue("@porte", cmbPorte.Text);
                cmd.Parameters.AddWithValue("@sexo", rbMasc.Checked ? "Masculino" : "Feminino");
                cmd.Parameters.AddWithValue("@vacina", rbVacinaSim.Checked);
                cmd.Parameters.AddWithValue("@especie", cmbEspecie.Text);
                cmd.Parameters.AddWithValue("@cor", txtCor.Text.Trim());
                cmd.Parameters.AddWithValue("@raca", txtRaca.Text.Trim());
                cmd.Parameters.AddWithValue("@castrado", rbCastradoSim.Checked);
                cmd.Parameters.AddWithValue("@doencas", txtDoencas.Text.Trim());
                cmd.Parameters.AddWithValue("@id_dono", cmbDono.SelectedValue);

                cmd.ExecuteNonQuery();
                LimparCampos();
                CarregarPets();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnExcluir_Click(object? sender, EventArgs e)
        {
            if (idPetSelecionado == 0) return;

            try
            {
                using var conn = new MySqlConnection(connStr);
                using var cmd = new MySqlCommand("DELETE FROM pets WHERE id_pet = @id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", idPetSelecionado);
                cmd.ExecuteNonQuery();

                LimparCampos();
                CarregarPets();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void lblTitulo_Click(object? sender, EventArgs e)
        {
        }
        private void DgvPets_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvPets.Rows[e.RowIndex].Cells["ID"].Value == null) return;

            var r = dgvPets.Rows[e.RowIndex];
            idPetSelecionado = Convert.ToInt32(r.Cells["ID"].Value);

            txtNome.Text = r.Cells["PET"].Value?.ToString();
            txtCor.Text = r.Cells["Cor"].Value?.ToString();
            cmbDono.Text = r.Cells["Dono"].Value?.ToString();
            txtIdade.Text = r.Cells["Idade"].Value?.ToString();
            cmbPorte.Text = r.Cells["Porte"].Value?.ToString();
            cmbEspecie.Text = r.Cells["Espécie"].Value?.ToString();
            txtRaca.Text = r.Cells["Raça"].Value?.ToString();
            txtDoencas.Text = r.Cells["Doenças"].Value?.ToString();

            rbMasc.Checked = r.Cells["Sexo"].Value?.ToString() == "Masculino";
            rbFem.Checked = !rbMasc.Checked;
            rbVacinaSim.Checked = r.Cells["Vacina"].Value?.ToString() == "Sim";
            rbVacinaNao.Checked = !rbVacinaSim.Checked;
            rbCastradoSim.Checked = r.Cells["Castrado"].Value?.ToString() == "Sim";
            rbCastradoNao.Checked = !rbCastradoSim.Checked;
        }

        private void CmbDono_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbDono.SelectedItem is DataRowView dono)
            {
                txtTelefone.Text = dono["telefone"].ToString();
                txtEmail.Text = dono["email"].ToString();
                txtTelefone.ForeColor = txtEmail.ForeColor = Color.Black;
            }
            else
            {
                txtTelefone.Text = txtEmail.Text = "automático";
                txtTelefone.ForeColor = txtEmail.ForeColor = Color.Gray;
            }
        }

        private void LimparCampos()
        {
            idPetSelecionado = 0;
            txtNome.Clear(); txtIdade.Clear(); txtCor.Clear(); txtRaca.Clear(); txtDoencas.Clear();
            txtPesquisa.Clear();
            fotoPetSelecionada?.Dispose();
            fotoPetSelecionada = null;
            picFoto.Image = null;
            cmbDono.SelectedIndex = cmbPorte.SelectedIndex = cmbEspecie.SelectedIndex = -1;
            rbMasc.Checked = rbVacinaSim.Checked = rbCastradoSim.Checked = true;
        }

        private void DesenharCard(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using var path = new GraphicsPath();
            int d = 30, w = pnlCard.Width - 1, h = pnlCard.Height - 1;
            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(w - d, 0, d, d, 270, 90);
            path.AddArc(w - d, h - d, d, d, 0, 90);
            path.AddArc(0, h - d, d, d, 90, 90);
            e.Graphics.DrawPath(new Pen(Color.FromArgb(215, 225, 235)), path);
        }

        private void cmbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

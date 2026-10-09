using System.Drawing;
using System.Windows.Forms;

namespace CadastroPetShop
{
    public partial class crudPet
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crudPet));
            pnlCard = new Panel();
            lblNome = new Label();
            txtNome = new TextBox();
            lblDono = new Label();
            cmbDono = new ComboBox();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblIdade = new Label();
            txtIdade = new TextBox();
            lblPorte = new Label();
            cmbPorte = new ComboBox();
            lblSexo = new Label();
            pnlSexo = new Panel();
            rbMasc = new RadioButton();
            rbFem = new RadioButton();
            lblVacina = new Label();
            pnlVacina = new Panel();
            rbVacinaSim = new RadioButton();
            rbVacinaNao = new RadioButton();
            lblEspecie = new Label();
            cmbEspecie = new ComboBox();
            lblCor = new Label();
            txtCor = new TextBox();
            lblRaca = new Label();
            txtRaca = new TextBox();
            lblCastrado = new Label();
            pnlCastrado = new Panel();
            rbCastradoSim = new RadioButton();
            rbCastradoNao = new RadioButton();
            lblDoencas = new Label();
            txtDoencas = new TextBox();
            btnSalvar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            dgvPets = new DataGridView();
            lblPesquisa = new Label();
            txtPesquisa = new TextBox();
            btnPesquisar = new Button();
            picFoto = new PictureBox();
            btnFoto = new Button();
            pnlCard.SuspendLayout();
            pnlSexo.SuspendLayout();
            pnlVacina.SuspendLayout();
            pnlCastrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(lblNome);
            pnlCard.Controls.Add(txtNome);
            pnlCard.Controls.Add(lblDono);
            pnlCard.Controls.Add(cmbDono);
            pnlCard.Controls.Add(lblTelefone);
            pnlCard.Controls.Add(txtTelefone);
            pnlCard.Controls.Add(lblEmail);
            pnlCard.Controls.Add(txtEmail);
            pnlCard.Controls.Add(lblIdade);
            pnlCard.Controls.Add(txtIdade);
            pnlCard.Controls.Add(lblPorte);
            pnlCard.Controls.Add(cmbPorte);
            pnlCard.Controls.Add(lblSexo);
            pnlCard.Controls.Add(pnlSexo);
            pnlCard.Controls.Add(lblVacina);
            pnlCard.Controls.Add(pnlVacina);
            pnlCard.Controls.Add(lblEspecie);
            pnlCard.Controls.Add(cmbEspecie);
            pnlCard.Controls.Add(lblCor);
            pnlCard.Controls.Add(txtCor);
            pnlCard.Controls.Add(lblRaca);
            pnlCard.Controls.Add(txtRaca);
            pnlCard.Controls.Add(lblCastrado);
            pnlCard.Controls.Add(pnlCastrado);
            pnlCard.Controls.Add(lblDoencas);
            pnlCard.Controls.Add(txtDoencas);
            pnlCard.Controls.Add(btnSalvar);
            pnlCard.Controls.Add(btnAlterar);
            pnlCard.Controls.Add(btnExcluir);
            pnlCard.Controls.Add(btnLimpar);
            pnlCard.Controls.Add(dgvPets);
            pnlCard.Controls.Add(lblPesquisa);
            pnlCard.Controls.Add(txtPesquisa);
            pnlCard.Controls.Add(btnPesquisar);
            pnlCard.Controls.Add(picFoto);
            pnlCard.Controls.Add(btnFoto);
            pnlCard.Location = new Point(13, 12);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(856, 595);
            pnlCard.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNome.Location = new Point(20, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(97, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome do animal";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 9.5F);
            txtNome.Location = new Point(20, 42);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(180, 24);
            txtNome.TabIndex = 1;
            // 
            // lblDono
            // 
            lblDono.AutoSize = true;
            lblDono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDono.Location = new Point(215, 20);
            lblDono.Name = "lblDono";
            lblDono.Size = new Size(93, 15);
            lblDono.TabIndex = 2;
            lblDono.Text = "Dono do animal";
            // 
            // cmbDono
            // 
            cmbDono.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDono.Font = new Font("Segoe UI", 9.5F);
            cmbDono.Location = new Point(215, 42);
            cmbDono.Name = "cmbDono";
            cmbDono.Size = new Size(190, 25);
            cmbDono.TabIndex = 3;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefone.Location = new Point(420, 20);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(104, 15);
            lblTelefone.TabIndex = 4;
            lblTelefone.Text = "Telefone do dono";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 9.5F);
            txtTelefone.ForeColor = Color.Gray;
            txtTelefone.Location = new Point(420, 42);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.ReadOnly = true;
            txtTelefone.Size = new Size(170, 24);
            txtTelefone.TabIndex = 5;
            txtTelefone.Text = "automático";
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(605, 20);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(89, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "E-mail do dono";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(605, 42);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(185, 24);
            txtEmail.TabIndex = 7;
            txtEmail.Text = "automático";
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIdade.Location = new Point(20, 85);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(38, 15);
            lblIdade.TabIndex = 8;
            lblIdade.Text = "Idade";
            // 
            // txtIdade
            // 
            txtIdade.Font = new Font("Segoe UI", 9.5F);
            txtIdade.Location = new Point(20, 107);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(120, 24);
            txtIdade.TabIndex = 9;
            // 
            // lblPorte
            // 
            lblPorte.AutoSize = true;
            lblPorte.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPorte.Location = new Point(155, 85);
            lblPorte.Name = "lblPorte";
            lblPorte.Size = new Size(38, 15);
            lblPorte.TabIndex = 10;
            lblPorte.Text = "Porte";
            // 
            // cmbPorte
            // 
            cmbPorte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPorte.Font = new Font("Segoe UI", 9.5F);
            cmbPorte.FormattingEnabled = true;
            cmbPorte.Items.AddRange(new object[] { "Pequeno", "Médio", "Grande" });
            cmbPorte.Location = new Point(155, 107);
            cmbPorte.Name = "cmbPorte";
            cmbPorte.Size = new Size(120, 25);
            cmbPorte.TabIndex = 11;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSexo.Location = new Point(290, 85);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(35, 15);
            lblSexo.TabIndex = 12;
            lblSexo.Text = "Sexo";
            // 
            // pnlSexo
            // 
            pnlSexo.Controls.Add(rbMasc);
            pnlSexo.Controls.Add(rbFem);
            pnlSexo.Location = new Point(290, 107);
            pnlSexo.Name = "pnlSexo";
            pnlSexo.Size = new Size(160, 28);
            pnlSexo.TabIndex = 13;
            // 
            // rbMasc
            // 
            rbMasc.AutoSize = true;
            rbMasc.Checked = true;
            rbMasc.Font = new Font("Segoe UI", 9.5F);
            rbMasc.Location = new Point(0, 3);
            rbMasc.Name = "rbMasc";
            rbMasc.Size = new Size(85, 21);
            rbMasc.TabIndex = 0;
            rbMasc.TabStop = true;
            rbMasc.Text = "Masculino";
            // 
            // rbFem
            // 
            rbFem.AutoSize = true;
            rbFem.Font = new Font("Segoe UI", 9.5F);
            rbFem.Location = new Point(85, 3);
            rbFem.Name = "rbFem";
            rbFem.Size = new Size(78, 21);
            rbFem.TabIndex = 1;
            rbFem.Text = "Feminino";
            // 
            // lblVacina
            // 
            lblVacina.AutoSize = true;
            lblVacina.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVacina.Location = new Point(465, 85);
            lblVacina.Name = "lblVacina";
            lblVacina.Size = new Size(172, 15);
            lblVacina.TabIndex = 14;
            lblVacina.Text = "Vacina da raiva no último ano?";
            // 
            // pnlVacina
            // 
            pnlVacina.Controls.Add(rbVacinaSim);
            pnlVacina.Controls.Add(rbVacinaNao);
            pnlVacina.Location = new Point(476, 107);
            pnlVacina.Name = "pnlVacina";
            pnlVacina.Size = new Size(140, 28);
            pnlVacina.TabIndex = 15;
            pnlVacina.Paint += pnlVacina_Paint;
            // 
            // rbVacinaSim
            // 
            rbVacinaSim.AutoSize = true;
            rbVacinaSim.Checked = true;
            rbVacinaSim.Font = new Font("Segoe UI", 9.5F);
            rbVacinaSim.Location = new Point(0, 3);
            rbVacinaSim.Name = "rbVacinaSim";
            rbVacinaSim.Size = new Size(47, 21);
            rbVacinaSim.TabIndex = 0;
            rbVacinaSim.TabStop = true;
            rbVacinaSim.Text = "Sim";
            // 
            // rbVacinaNao
            // 
            rbVacinaNao.AutoSize = true;
            rbVacinaNao.Font = new Font("Segoe UI", 9.5F);
            rbVacinaNao.Location = new Point(53, 4);
            rbVacinaNao.Name = "rbVacinaNao";
            rbVacinaNao.Size = new Size(51, 21);
            rbVacinaNao.TabIndex = 1;
            rbVacinaNao.Text = "Não";
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEspecie.Location = new Point(20, 150);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(48, 15);
            lblEspecie.TabIndex = 16;
            lblEspecie.Text = "Espécie";
            // 
            // cmbEspecie
            // 
            cmbEspecie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecie.Font = new Font("Segoe UI", 9.5F);
            cmbEspecie.FormattingEnabled = true;
            cmbEspecie.Items.AddRange(new object[] { "Cachorro", "Gato", "Pássaro", "Outro" });
            cmbEspecie.Location = new Point(20, 172);
            cmbEspecie.Name = "cmbEspecie";
            cmbEspecie.Size = new Size(140, 25);
            cmbEspecie.TabIndex = 17;
            cmbEspecie.SelectedIndexChanged += cmbEspecie_SelectedIndexChanged;
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCor.Location = new Point(175, 150);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(26, 15);
            lblCor.TabIndex = 18;
            lblCor.Text = "Cor";
            // 
            // txtCor
            // 
            txtCor.Font = new Font("Segoe UI", 9.5F);
            txtCor.Location = new Point(175, 172);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(130, 24);
            txtCor.TabIndex = 19;
            // 
            // lblRaca
            // 
            lblRaca.AutoSize = true;
            lblRaca.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRaca.Location = new Point(320, 150);
            lblRaca.Name = "lblRaca";
            lblRaca.Size = new Size(33, 15);
            lblRaca.TabIndex = 20;
            lblRaca.Text = "Raça";
            // 
            // txtRaca
            // 
            txtRaca.Font = new Font("Segoe UI", 9.5F);
            txtRaca.Location = new Point(320, 172);
            txtRaca.Name = "txtRaca";
            txtRaca.Size = new Size(150, 24);
            txtRaca.TabIndex = 21;
            // 
            // lblCastrado
            // 
            lblCastrado.AutoSize = true;
            lblCastrado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCastrado.Location = new Point(485, 150);
            lblCastrado.Name = "lblCastrado";
            lblCastrado.Size = new Size(55, 15);
            lblCastrado.TabIndex = 22;
            lblCastrado.Text = "Castrado";
            // 
            // pnlCastrado
            // 
            pnlCastrado.Controls.Add(rbCastradoSim);
            pnlCastrado.Controls.Add(rbCastradoNao);
            pnlCastrado.Location = new Point(485, 172);
            pnlCastrado.Name = "pnlCastrado";
            pnlCastrado.Size = new Size(105, 25);
            pnlCastrado.TabIndex = 23;
            // 
            // rbCastradoSim
            // 
            rbCastradoSim.AutoSize = true;
            rbCastradoSim.Checked = true;
            rbCastradoSim.Font = new Font("Segoe UI", 9.5F);
            rbCastradoSim.Location = new Point(0, 3);
            rbCastradoSim.Name = "rbCastradoSim";
            rbCastradoSim.Size = new Size(47, 21);
            rbCastradoSim.TabIndex = 0;
            rbCastradoSim.TabStop = true;
            rbCastradoSim.Text = "Sim";
            // 
            // rbCastradoNao
            // 
            rbCastradoNao.AutoSize = true;
            rbCastradoNao.Font = new Font("Segoe UI", 9.5F);
            rbCastradoNao.Location = new Point(55, 3);
            rbCastradoNao.Name = "rbCastradoNao";
            rbCastradoNao.Size = new Size(51, 21);
            rbCastradoNao.TabIndex = 1;
            rbCastradoNao.Text = "Não";
            // 
            // lblDoencas
            // 
            lblDoencas.AutoSize = true;
            lblDoencas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDoencas.Location = new Point(643, 85);
            lblDoencas.Name = "lblDoencas";
            lblDoencas.Size = new Size(54, 15);
            lblDoencas.TabIndex = 24;
            lblDoencas.Text = "Doenças";
            // 
            // txtDoencas
            // 
            txtDoencas.Font = new Font("Segoe UI", 9.5F);
            txtDoencas.Location = new Point(640, 111);
            txtDoencas.Name = "txtDoencas";
            txtDoencas.Size = new Size(160, 24);
            txtDoencas.TabIndex = 25;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(225, 238, 255);
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderColor = Color.FromArgb(160, 195, 255);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.FromArgb(20, 60, 140);
            btnSalvar.Location = new Point(20, 220);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(95, 32);
            btnSalvar.TabIndex = 26;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(225, 238, 255);
            btnAlterar.Cursor = Cursors.Hand;
            btnAlterar.FlatAppearance.BorderColor = Color.FromArgb(160, 195, 255);
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAlterar.ForeColor = Color.FromArgb(20, 60, 140);
            btnAlterar.Location = new Point(125, 220);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(95, 32);
            btnAlterar.TabIndex = 27;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(225, 238, 255);
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.FlatAppearance.BorderColor = Color.FromArgb(160, 195, 255);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.FromArgb(20, 60, 140);
            btnExcluir.Location = new Point(230, 220);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(95, 32);
            btnExcluir.TabIndex = 28;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(225, 238, 255);
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.FlatAppearance.BorderColor = Color.FromArgb(160, 195, 255);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.FromArgb(20, 60, 140);
            btnLimpar.Location = new Point(335, 220);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(95, 32);
            btnLimpar.TabIndex = 29;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // dgvPets
            // 
            dgvPets.AllowUserToAddRows = false;
            dgvPets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPets.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(232, 238, 245);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(30, 40, 60);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPets.EnableHeadersVisualStyles = false;
            dgvPets.Location = new Point(42, 323);
            dgvPets.MultiSelect = false;
            dgvPets.Name = "dgvPets";
            dgvPets.ReadOnly = true;
            dgvPets.RowHeadersVisible = false;
            dgvPets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPets.Size = new Size(770, 227);
            dgvPets.TabIndex = 30;
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPesquisa.Location = new Point(50, 283);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(67, 17);
            lblPesquisa.TabIndex = 31;
            lblPesquisa.Text = "Pesquisar";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(123, 283);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "PET ou dono";
            txtPesquisa.Size = new Size(220, 23);
            txtPesquisa.TabIndex = 32;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(349, 283);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(90, 25);
            btnPesquisar.TabIndex = 33;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // picFoto
            // 
            picFoto.BorderStyle = BorderStyle.FixedSingle;
            picFoto.Location = new Point(643, 150);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(150, 127);
            picFoto.SizeMode = PictureBoxSizeMode.Zoom;
            picFoto.TabIndex = 34;
            picFoto.TabStop = false;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(657, 283);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(123, 25);
            btnFoto.TabIndex = 35;
            btnFoto.Text = "Selecionar foto";
            btnFoto.UseVisualStyleBackColor = true;
            // 
            // crudPet
            // 
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(889, 574);
            Controls.Add(pnlCard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "crudPet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD de PETs - Pet Ville";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlSexo.ResumeLayout(false);
            pnlSexo.PerformLayout();
            pnlVacina.ResumeLayout(false);
            pnlVacina.PerformLayout();
            pnlCastrado.ResumeLayout(false);
            pnlCastrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPets).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbDono;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.ComboBox cmbPorte;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.RadioButton rbVacinaSim;
        private System.Windows.Forms.RadioButton rbVacinaNao;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.RadioButton rbCastradoSim;
        private System.Windows.Forms.RadioButton rbCastradoNao;
        private System.Windows.Forms.TextBox txtDoencas;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgvPets;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnFoto;
        private Label lblNome;
        private Label lblDono;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblIdade;
        private Label lblPorte;
        private Label lblSexo;
        private Panel pnlSexo;
        private Label lblVacina;
        private Panel pnlVacina;
        private Label lblEspecie;
        private Label lblCor;
        private Label lblRaca;
        private Label lblCastrado;
        private Panel pnlCastrado;
        private Label lblDoencas;
    }
}
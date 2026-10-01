namespace CadastroPetShop
{
    partial class crudDONO
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblCpf = new Label();
            txtCpf = new TextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblEndereco = new Label();
            txtEndereco = new TextBox();
            btnSalvar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            dgvDonos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDonos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(15, 30, 60);
            lblTitulo.Location = new Point(25, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(190, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CRUD de Donos";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCpf.Location = new Point(25, 75);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(25, 15);
            lblCpf.TabIndex = 1;
            lblCpf.Text = "CPF";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(25, 98);
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "000.000.000-00";
            txtCpf.Size = new Size(150, 23);
            txtCpf.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNome.Location = new Point(205, 75);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(205, 98);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome completo";
            txtNome.Size = new Size(260, 23);
            txtNome.TabIndex = 3;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefone.Location = new Point(485, 75);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(55, 15);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(485, 98);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "(00) 00000-0000";
            txtTelefone.Size = new Size(170, 23);
            txtTelefone.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(25, 140);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(25, 163);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "email@exemplo.com";
            txtEmail.Size = new Size(260, 23);
            txtEmail.TabIndex = 6;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEndereco.Location = new Point(305, 140);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(61, 15);
            lblEndereco.TabIndex = 7;
            lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(305, 163);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = "Rua, número, bairro";
            txtEndereco.Size = new Size(350, 23);
            txtEndereco.TabIndex = 8;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(25, 210);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 35);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(145, 210);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(110, 35);
            btnAlterar.TabIndex = 10;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(265, 210);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 35);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(385, 210);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(110, 35);
            btnLimpar.TabIndex = 12;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // dgvDonos
            // 
            dgvDonos.AllowUserToAddRows = false;
            dgvDonos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonos.BackgroundColor = Color.White;
            dgvDonos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonos.Location = new Point(25, 265);
            dgvDonos.MultiSelect = false;
            dgvDonos.Name = "dgvDonos";
            dgvDonos.ReadOnly = true;
            dgvDonos.RowHeadersVisible = false;
            dgvDonos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDonos.Size = new Size(695, 240);
            dgvDonos.TabIndex = 13;
            // 
            // crudDONO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(750, 540);
            Controls.Add(dgvDonos);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnSalvar);
            Controls.Add(txtEndereco);
            Controls.Add(lblEndereco);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(txtCpf);
            Controls.Add(lblCpf);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "crudDONO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pet Ville - Donos";
            ((System.ComponentModel.ISupportInitialize)dgvDonos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Label lblCpf;
        private TextBox txtCpf;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblEndereco;
        private TextBox txtEndereco;
        private Button btnSalvar;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnLimpar;
        private DataGridView dgvDonos;
    }
}

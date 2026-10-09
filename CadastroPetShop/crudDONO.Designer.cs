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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crudDONO));
            lblCpf = new Label();
            txtCpf = new MaskedTextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            lblTelefone = new Label();
            txtTelefone = new MaskedTextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblEndereco = new Label();
            txtEndereco = new MaskedTextBox();
            btnSalvar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            dgvDonos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDonos).BeginInit();
            SuspendLayout();
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCpf.Location = new Point(25, 23);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(27, 15);
            lblCpf.TabIndex = 1;
            lblCpf.Text = "CPF";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(25, 51);
            txtCpf.Mask = "000.000.000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(150, 23);
            txtCpf.TabIndex = 2;
            txtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNome.Location = new Point(195, 23);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(41, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(195, 51);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome completo";
            txtNome.Size = new Size(260, 23);
            txtNome.TabIndex = 3;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefone.Location = new Point(485, 23);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(56, 15);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(485, 52);
            txtTelefone.Mask = "(00) 90000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(170, 23);
            txtTelefone.TabIndex = 5;
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(25, 106);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(25, 132);
            txtEmail.MaxLength = 254;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "email@exemplo.com";
            txtEmail.Size = new Size(260, 23);
            txtEmail.TabIndex = 6;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEndereco.Location = new Point(305, 106);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(27, 15);
            lblEndereco.TabIndex = 7;
            lblEndereco.Text = "CEP";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(305, 132);
            txtEndereco.Mask = "00000-000";
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(76, 23);
            txtEndereco.TabIndex = 8;
            txtEndereco.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(225, 238, 255);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.FromArgb(20, 60, 140);
            btnSalvar.Location = new Point(23, 183);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 35);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(225, 238, 255);
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAlterar.ForeColor = Color.FromArgb(20, 60, 140);
            btnAlterar.Location = new Point(139, 183);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(110, 35);
            btnAlterar.TabIndex = 10;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(225, 238, 255);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.FromArgb(20, 60, 140);
            btnExcluir.Location = new Point(254, 183);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(110, 35);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(225, 238, 255);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.FromArgb(20, 60, 140);
            btnLimpar.Location = new Point(370, 183);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(110, 35);
            btnLimpar.TabIndex = 12;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // dgvDonos
            // 
            dgvDonos.AllowUserToAddRows = false;
            dgvDonos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonos.BackgroundColor = Color.White;
            dgvDonos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonos.Location = new Point(25, 234);
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
            ClientSize = new Size(750, 490);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "crudDONO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pet Ville - Donos";
            ((System.ComponentModel.ISupportInitialize)dgvDonos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lblCpf;
        private MaskedTextBox txtCpf;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblTelefone;
        private MaskedTextBox txtTelefone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblEndereco;
        private MaskedTextBox txtEndereco;
        private Button btnSalvar;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnLimpar;
        private DataGridView dgvDonos;
    }
}

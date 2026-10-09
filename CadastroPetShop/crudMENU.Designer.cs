namespace CadastroPetShop
{
    partial class crudMENU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crudMENU));
            lblTitulo = new Label();
            lblBoasVindas = new Label();
            btnPets = new Button();
            btnDonos = new Button();
            btnSair = new Button();
            btnRelatorioDono = new Button();
            btnEspecies = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(15, 30, 60);
            lblTitulo.Location = new Point(35, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(210, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Menu Principal";
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.AutoSize = true;
            lblBoasVindas.Font = new Font("Segoe UI", 12F);
            lblBoasVindas.Location = new Point(40, 85);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(109, 21);
            lblBoasVindas.TabIndex = 1;
            lblBoasVindas.Text = "Bem-vindo(a)!";
            // 
            // btnPets
            // 
            btnPets.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPets.Location = new Point(40, 140);
            btnPets.Name = "btnPets";
            btnPets.Size = new Size(220, 50);
            btnPets.TabIndex = 2;
            btnPets.Text = "Cadastro de Pets";
            btnPets.UseVisualStyleBackColor = true;
            btnPets.Click += btnPets_Click;
            // 
            // btnDonos
            // 
            btnDonos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDonos.Location = new Point(275, 140);
            btnDonos.Name = "btnDonos";
            btnDonos.Size = new Size(150, 50);
            btnDonos.TabIndex = 3;
            btnDonos.Text = "Cadastro de Donos";
            btnDonos.UseVisualStyleBackColor = true;
            btnDonos.Click += btnDonos_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 11F);
            btnSair.Location = new Point(440, 140);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(120, 50);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnRelatorioDono
            // 
            btnRelatorioDono.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRelatorioDono.Location = new Point(40, 205);
            btnRelatorioDono.Name = "btnRelatorioDono";
            btnRelatorioDono.Size = new Size(250, 45);
            btnRelatorioDono.TabIndex = 5;
            btnRelatorioDono.Text = "PETs por dono";
            btnRelatorioDono.UseVisualStyleBackColor = true;
            btnRelatorioDono.Click += btnRelatorioDono_Click;
            // 
            // btnEspecies
            // 
            btnEspecies.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEspecies.Location = new Point(310, 205);
            btnEspecies.Name = "btnEspecies";
            btnEspecies.Size = new Size(250, 45);
            btnEspecies.TabIndex = 6;
            btnEspecies.Text = "Quantidade por espécie";
            btnEspecies.UseVisualStyleBackColor = true;
            btnEspecies.Click += btnEspecies_Click;
            // 
            // crudMENU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(600, 290);
            Controls.Add(btnSair);
            Controls.Add(btnDonos);
            Controls.Add(btnPets);
            Controls.Add(btnRelatorioDono);
            Controls.Add(btnEspecies);
            Controls.Add(lblBoasVindas);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "crudMENU";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pet Ville - Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Label lblBoasVindas;
        private Button btnPets;
        private Button btnDonos;
        private Button btnSair;
        private Button btnRelatorioDono;
        private Button btnEspecies;
    }
}

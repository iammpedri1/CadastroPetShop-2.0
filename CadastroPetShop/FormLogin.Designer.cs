namespace CadastroPetShop
{
    partial class FormLogin
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btn_login = new Button();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            labelTitulo = new Label();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(51, 135);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 32);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(51, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 32);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.LightSkyBlue;
            btn_login.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btn_login.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(113, 223);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(169, 50);
            btn_login.TabIndex = 6;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txtSenha
            // 
            txtSenha.Cursor = Cursors.Hand;
            txtSenha.Font = new Font("Segoe UI", 14F);
            txtSenha.Location = new Point(95, 135);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(208, 32);
            txtSenha.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14F);
            txtUsuario.Location = new Point(95, 83);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(208, 32);
            txtUsuario.TabIndex = 3;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.Black;
            labelTitulo.Location = new Point(139, 22);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(111, 40);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Login";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(labelTitulo);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(133, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(381, 322);
            panel1.TabIndex = 9;
            // 
            // pictureBox4
            // 
            pictureBox4.ErrorImage = null;
            pictureBox4.InitialImage = null;
            pictureBox4.Location = new Point(309, 146);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(653, 423);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pet Ville";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitulo;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btn_login;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox4;
    }
}
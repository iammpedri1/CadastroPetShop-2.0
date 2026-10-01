using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CadastroPetShop
{
    public partial class FormLogin : Form
    {
        private bool senhaVisivel = false;

        public string UsuarioAutenticado { get; private set; } = string.Empty;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;

            pictureBox4.Image = Properties.Resources.fechar_o_olho;
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Click -= pictureBox4_Click;
            pictureBox4.Click += pictureBox4_Click;
            pictureBox4.BringToFront();

            AcceptButton = btn_login;
        }

        private void pictureBox4_Click(object? sender, EventArgs e)
        {
            senhaVisivel = !senhaVisivel;

           
            txtSenha.UseSystemPasswordChar = !senhaVisivel;
            txtSenha.PasswordChar = senhaVisivel ? '\0' : '*';

            pictureBox4.Image = senhaVisivel
                ? Properties.Resources.olho_brilhante
                : Properties.Resources.fechar_o_olho;
        }

        private void panel1_Paint(object? sender, PaintEventArgs e)
        {
            Panel? painel = sender as Panel;
            if (painel == null) return;

            int raioDoCanto = 35;
            int diametro = raioDoCanto * 2;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle retangulo = new Rectangle(0, 0, painel.Width - 1, painel.Height - 1);

            using (GraphicsPath caminho = new GraphicsPath())
            {
                if (diametro > retangulo.Width) diametro = retangulo.Width;
                if (diametro > retangulo.Height) diametro = retangulo.Height;
                Size tamanhoArco = new Size(diametro, diametro);

                caminho.AddArc(new Rectangle(retangulo.Location, tamanhoArco), 180, 90);
                caminho.AddArc(new Rectangle(new Point(retangulo.Right - diametro, retangulo.Top), tamanhoArco), 270, 90);
                caminho.AddArc(new Rectangle(new Point(retangulo.Right - diametro, retangulo.Bottom - diametro), tamanhoArco), 0, 90);
                caminho.AddArc(new Rectangle(new Point(retangulo.Left, retangulo.Bottom - diametro), tamanhoArco), 90, 90);
                caminho.CloseFigure();

                using (SolidBrush pincelFundo = new SolidBrush(Color.White))
                {
                    e.Graphics.FillPath(pincelFundo, caminho);
                }

                using (Pen caneta = new Pen(Color.FromArgb(200, 200, 200), 1))
                {
                    e.Graphics.DrawPath(caneta, caminho);
                }
            }
        }

        private void btn_login_Click(object? sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Informe o usuário e a senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Autenticacao.Validar(usuario, senha))
                {
                    UsuarioAutenticado = usuario;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro ao acessar o banco de dados:\n{ex.Message}", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
using System;
using System.Windows.Forms;

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

        private void btn_login_Click(object? sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Informe o usuário e a senha.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Autenticacao.Validar(usuario, senha))
            {
                UsuarioAutenticado = usuario;
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            MessageBox.Show("Usuário ou senha inválidos.", "Acesso Negado",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
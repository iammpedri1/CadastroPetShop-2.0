using System;
using System.Windows.Forms;

namespace CadastroPetShop
{
    public partial class crudMENU : Form
    {
        public crudMENU(string usuario)
        {
            InitializeComponent();
            lblBoasVindas.Text = $"Bem-vindo(a), {usuario}!";
        }

        public crudMENU()
        {
        }

        private void btnPets_Click(object? sender, EventArgs e)
        {
            using crudPet telaPets = new crudPet();
            telaPets.ShowDialog();
        }

        private void btnDonos_Click(object? sender, EventArgs e)
        {
            using crudDONO telaDonos = new crudDONO();
            telaDonos.ShowDialog();
        }

        private void btnSair_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void btnRelatorioDono_Click(object? sender, EventArgs e)
        {
            using relatorioPetsDono relatorio = new relatorioPetsDono();
            relatorio.ShowDialog();
        }

        private void btnEspecies_Click(object? sender, EventArgs e)
        {
            using relatorioEspecies relatorio = new relatorioEspecies();
            relatorio.ShowDialog();
        }
    }
}

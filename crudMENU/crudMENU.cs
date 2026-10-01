#nullable disable

using System;
using System.Windows.Forms;

namespace CadastroPetShop
{
    public partial class crudMENU : Form
    {
        public crudMENU()
        {
            InitializeComponent();
        }

        private void btnPets_Click(object sender, EventArgs e)
        {
            new crudPet().ShowDialog();
        }

        private void btnDonos_Click(object sender, EventArgs e)
        {
            new crudDono().ShowDialog();
        }
    }
}
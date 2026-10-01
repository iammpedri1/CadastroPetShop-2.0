#nullable disable

using System;
using System.Windows.Forms;

namespace CadastroPetShop
{
    partial class crudMENU
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

        private void InitializeComponent()
        {
            this.btnPets = new System.Windows.Forms.Button();
            this.btnDonos = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnPets
            this.btnPets.Location = new System.Drawing.Point(50, 50);
            this.btnPets.Name = "btnPets";
            this.btnPets.Size = new System.Drawing.Size(150, 50);
            this.btnPets.TabIndex = 0;
            this.btnPets.Text = "CRUD PETS";
            this.btnPets.UseVisualStyleBackColor = true;
            this.btnPets.Click += new System.EventHandler(this.btnPets_Click);

            // btnDonos
            this.btnDonos.Location = new System.Drawing.Point(220, 50);
            this.btnDonos.Name = "btnDonos";
            this.btnDonos.Size = new System.Drawing.Size(150, 50);
            this.btnDonos.TabIndex = 1;
            this.btnDonos.Text = "CRUD DONOS";
            this.btnDonos.UseVisualStyleBackColor = true;
            this.btnDonos.Click += new System.EventHandler(this.btnDonos_Click);

            // crudMENU
            this.ClientSize = new System.Drawing.Size(420, 160);
            this.Controls.Add(this.btnPets);
            this.Controls.Add(this.btnDonos);
            this.Name = "crudMENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnPets;
        private System.Windows.Forms.Button btnDonos;
    }
}
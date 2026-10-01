namespace CadastroPetShop
{
    partial class crudDONO
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNome = new Label();
            txtCPF = new TextBox();
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            maskedNumero = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(15, 30, 60);
            lblTitulo.Location = new Point(28, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(185, 32);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "CRUD de Dono";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNome.Location = new Point(28, 79);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(27, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "CPF";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(28, 106);
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "000-000-000-00";
            txtCPF.Size = new Size(155, 23);
            txtCPF.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(206, 79);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 5;
            label1.Text = "CPF";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(206, 106);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome Completo";
            txtNome.Size = new Size(325, 23);
            txtNome.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(28, 161);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 7;
            label2.Text = "CPF";
            // 
            // maskedNumero
            // 
            maskedNumero.Location = new Point(28, 189);
            maskedNumero.Mask = "(00) 00000-0000";
            maskedNumero.Name = "maskedNumero";
            maskedNumero.Size = new Size(155, 23);
            maskedNumero.TabIndex = 8;
            // 
            // crudDONO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 538);
            Controls.Add(maskedNumero);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(txtCPF);
            Controls.Add(lblNome);
            Controls.Add(lblTitulo);
            Name = "crudDONO";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNome;
        private TextBox txtCPF;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private MaskedTextBox maskedNumero;
    }
}

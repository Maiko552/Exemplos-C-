using System;
using System.Drawing;
using System.Windows.Forms;

namespace AcademiaJBM
{
    public partial class MenuPrincipal : Form
    {
        private Form telaCliente;

        public MenuPrincipal()
        {
            InitializeComponent();
            
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            panelMenu.BackColor = Color.FromArgb(119, 136, 153);
            panelLogo.BackColor = Color.FromArgb(0, 0, 205);
            panelTitulo.BackColor = Color.FromArgb(0, 0, 255);
            panelPrincipal.BackColor = Color.FromArgb(0, 0, 128);

        }

        private void AbrirFormCliente(Form Cliente) //Abrir forms  Filme 
        {
            if (telaCliente != null)
            {
                telaCliente.Close();
            }
            telaCliente = Cliente;
            Cliente.TopLevel = false;
            Cliente.FormBorderStyle = FormBorderStyle.None;
            Cliente.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(Cliente);
            panelPrincipal.Tag = Cliente;
            Cliente.BringToFront();
            Cliente.Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente telaCliente = new Cliente();
            telaCliente.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormCliente(new Cliente());
        }
    }
}

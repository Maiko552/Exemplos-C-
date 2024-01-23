using System;
using System.Drawing;
using System.Windows.Forms;

namespace AcademiaJBM
{
    public partial class MenuPrincipal : Form
    {

        Cliente telaCliente = new Cliente();
        Treino telaTreino = new Treino();
        Suplemento telaSuplemento = new Suplemento();

        public MenuPrincipal()
        {
            InitializeComponent();
            
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            panelMenu.BackColor = Color.FromArgb(112, 128, 144);
            panelLogo.BackColor = Color.FromArgb(169, 169, 169);
            panelTitulo.BackColor = Color.FromArgb(169, 169, 169);
            panelPrincipal.BackColor = Color.FromArgb(128, 128, 128);

        }


        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente telaCliente = new Cliente();
            telaCliente.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            telaCliente.ShowDialog();
        }

        private void btnTreino_Click(object sender, EventArgs e)
        {
            telaTreino.ShowDialog();
        }

        private void btnSuplemento_Click(object sender, EventArgs e)
        {
            telaSuplemento.ShowDialog();
        }
    }
}

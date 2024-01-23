using System;
using System.Windows.Forms;

namespace AcademiaJBM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" & txtPassword.Text == "")
            {
                MessageBox.Show("Login realizado com sucesso", "Login Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                MenuPrincipal telaPrincipal = new MenuPrincipal();                
                telaPrincipal.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Login recusado", "Login negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

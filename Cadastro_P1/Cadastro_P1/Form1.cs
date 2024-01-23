using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_P1
{
    public partial class Form1 : Form
    {
        
        Cliente cliente = new Cliente();    
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente.setNome(txtName.Text);
            cliente.setSobrenome(txtSobrenome.Text);
            cliente.setEmail(txtEmail.Text);
            cliente.setSenha(txtSenha.Text);
            cliente.setConfirmeSenha(txtConfir.Text);
            cliente.setTelefone(txtTel.Text);
            cliente.setNascimento(txtNasc.Text);
            cliente.setCEP(txtCEP.Text);
            cliente.setRua(txtRua.Text);
            cliente.setBairro(txtBairro.Text);
  
            MessageBox.Show("Dados salvos", "Salvo", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string consul = "Nome: " + cliente.getNome() + "\t" + cliente.getSobrenome() +
                "\nEmail: " + cliente.getEmail() +
                "\nData de Nascimento: " + cliente.getNascimento() + 
                "\nCelular: " + cliente.getTelefone() + 
                "\nCEP: " + cliente.getCEP() +
                "\nRua :" + cliente.getRua() + 
                "\nBairro: " + cliente.getBairro() +
                "\nSenha: " + cliente.getSenha();
            MessageBox.Show(consul, "Credenciais", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O cadastro será cancelado!", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

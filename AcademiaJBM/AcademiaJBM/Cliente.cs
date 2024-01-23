using System;
using System.Windows.Forms;

namespace AcademiaJBM
{
    public partial class Cliente : Form
    {
        ClienteCadastro cliente = new ClienteCadastro();


        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            cliente.setNomeCompleto(txtNomeCompleto.Text);
            cliente.setCelular(txtCelular.Text);
            cliente.setEmail(txtEmail.Text);
            cliente.setNascimento(dtpNascimento.Text);
            cliente.setRG(txtRG.Text);
            cliente.setCPF(txtCPF.Text);
            cliente.setObjetivo(cbxObjetivo.Text);
            cliente.setRua(txtRua.Text);
            cliente.setNumeroCasa(txtNumero.Text);
            cliente.setCidade(txtCidade.Text);
            MessageBox.Show("Cadastro realizado com sucesso", "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Botão consultar
            dgvComeco.Rows.Add(cliente.getNomeCompleto(), cliente.getCelular(), cliente.getEmail()
                             , cliente.getNascimento(), cliente.getRG());
            dgvFim.Rows.Add(cliente.getCPF(), cliente.getObjetivo(), cliente.getRua(), cliente.getNumeroCasa()
                             , cliente.getCidade());

        }
    }
}

using System;
using System.Windows.Forms;

namespace AcademiaJBM
{
    public partial class Suplemento : Form
    {
        SuplementoCadastro produto = new SuplementoCadastro();// criação do objeto
        public Suplemento()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Salvar
            produto.setID(txtId.Text);
            produto.setNome(txtNome.Text);
            produto.setQtd_Estoque(cbxqtd_Estoque.Text);
            produto.setSabor(txtSabor.Text);
            produto.setPreco(txtpreco.Text);          
            produto.setPesoKg(txtPeso.Text);
            produto.setMarca(txtMarca.Text);
            produto.setDescricao(txtDescricao.Text);
            produto.setDataCadastro(dtpDataCadastro.Text);
            produto.setValidade(dtpValide.Text);
            MessageBox.Show("Enviado com sucesso!", "Cliente inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Suplemento_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
                        dgvComeco.Rows.Add(produto.getId(), produto.getNome(), produto.getQtd_Estoque()
                             , produto.getSabor(), produto.getPreco());
            dgvFim.Rows.Add(produto.getPesoKg(), produto.getMarca(), produto.getDescricao(),
                               produto.getDataCadastro(), produto.getValidade());
        }
    }
}

using System;
using System.Windows.Forms;

namespace AcademiaJBM
{
    public partial class Treino : Form
    {
        TreinoCadastro treino = new TreinoCadastro(); //criação do objeto
        public Treino()
        {
            InitializeComponent();
        }

        private void Treino_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Salvar
            treino.setTreino(txtTreino.Text);
            treino.setGenero(cbxGenero.Text);
            treino.SetFrequencia(cbxFrequencia.Text);
            treino.setSeries(cbxSeries.Text);
            treino.SetRepeticao(cbxRepeticao.Text);
            treino.setIntensidade(cbxIntensidade.Text);          
            treino.setSelecao_Exercicios(txtSelecaoExerc.Text);     
            treino.setHorario_Treino(txthoraTreino.Text);
            treino.setDataTreino(txtDataTreino.Text);
            treino.setQuantHoras(txtHorasTreino.Text);
            MessageBox.Show("Cadastro realizado com sucesso", "Cadastro Treino", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvComeco.Rows.Add(treino.getTreino(), treino.getGenero(), treino.getFrequencia()
                             , treino.getSeries(), treino.getRepeticao());
            dgvFim.Rows.Add(treino.getIntensidade(), treino.getSelecaoExercicios(), treino.getHorario_Treino(),
                               treino.getDataTreino(), treino.getQuantHoras());

        }
    }
 }


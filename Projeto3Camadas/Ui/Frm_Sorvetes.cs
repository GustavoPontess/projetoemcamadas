using System;
using System.Windows.Forms;

//Importação da camada de negócio
using Projeto3Camadas.Code.BLL; //nomeProjeto.nomeDaPasta.nomeDaPasta
using Projeto3Camadas.Code.DTO;

namespace Projeto3Camadas
{
    public partial class Frm_Sorvetes : Form
    {
        //Criação dos objetos que acessam a camada de negócio
        SorveteBLL medbll = new SorveteBLL();
        SorveteDTO meddto = new SorveteDTO();

        public Frm_Sorvetes()
        {
            InitializeComponent();
            dgvSorvetes.DataSource = medbll.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto 
            meddto.Id = int.Parse(txtId.Text);
            meddto.Sabor = txtSabor.Text;
            meddto.Marca = txtMarca.Text;

            //Envio do dto preenchido para o método inserir
            medbll.Inserir(meddto);

            //mensagem de cadastrado 
            MessageBox.Show("Cadastrado com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvSorvetes.DataSource = medbll.Listar();
            //limpar campos
            txtId.Clear();
            txtMarca.Clear();
            txtSabor.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto 
            meddto.Id = int.Parse(txtId.Text);
            meddto.Sabor = txtSabor.Text;
            meddto.Marca = txtMarca.Text;

            //Envio do dto preenchido para o método inserir
            medbll.Editar(meddto);

            //mensagem de cadastrado 
            MessageBox.Show("Editado com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvSorvetes.DataSource = medbll.Listar();
            //limpar campos
            txtId.Clear();
            txtMarca.Clear();
            txtSabor.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto 
            meddto.Id = int.Parse(txtId.Text);
            meddto.Sabor = txtSabor.Text;
            meddto.Marca = txtMarca.Text;

            //Envio do dto preenchido para o método inserir
            medbll.Excluir(meddto);

            //mensagem de cadastrado 
            MessageBox.Show("Excluido com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvSorvetes.DataSource = medbll.Listar();
            //limpar campos
            txtId.Clear();
            txtMarca.Clear();
            txtSabor.Clear();
        }

        private void dgvSorvetes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvSorvetes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSabor.Text = dgvSorvetes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMarca.Text = dgvSorvetes.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}

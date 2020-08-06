using Secao_02.Banco;
using Secao_02.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secao_02
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            //a daa gri recebe os dados que foram pegos no Dao
            dgvResultado.DataSource = FuncionarioDAO.GetFuncionario();

            //chama o metodo para atualizar a tabela
            AtualizarTabela();
           
        }
        public void AtualizarTabela()
        {
            //pega o valor atualizado e passa para a Grid
            dgvResultado.DataSource = FuncionarioDAO.GetFuncionario();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //PASSA ELE MESMO PARA ATUALIZAR A TABELA
             TelaCadastro cadastro = new TelaCadastro(this);
               cadastro.Show(); 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //quando o usuario selecionar a linha vai pegar no idice 0 e pegar a
            //primeira coluna e o valor da celula selecionada 
           int id  = (int) dgvResultado.SelectedRows[0].Cells[0].Value;
            TelaCadastro cadastro = new TelaCadastro(this);
        }
    }
}

using Secao_02.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using Secao_02.Banco;

namespace Secao_02.View
{
    public partial class TelaCadastro : Form
    {
        //pega uma copia da tela 
        private TelaPrincipal telaPrincipal;
        private int Id;

       //passsa a tela principal no Construtor
        public TelaCadastro(TelaPrincipal tela)
        {
            telaPrincipal = tela;
            InitializeComponent();
        }

        public TelaCadastro(TelaPrincipal tela , int id)
        {
            id = id;
            telaPrincipal = tela;
            InitializeComponent();

            FuncionarioTela(FuncionarioDAO.GetFuncionario(id));
        }

        public void FuncionarioTela(Funcionario funcionario)
        {
             txtNome.Text = funcionario.Nome;
             txtEmail.Text = funcionario.Email;
            txtSalario.Text = funcionario.Salario.ToString();
            //se o radMasculino for igual a true atribui M caso contrario atribui F
            if (funcionario.Sexo == "M")
            {
                radMasculino.Checked = true;
            }
            else
            {
                radFeminino.Checked = true;
            }

            //se clt estiver checado atribui CLT senão se radPj estiver checado atribui PJ caso contrario Autonomo

            if (funcionario.TipoContrato == "CLT") {
                radCLT.Checked = true;
            }else if(funcionario.TipoContrato == "PJ")
            {
                radPJ.Checked = true;
            }
            else
            {
                radAUTONOMO.Checked = true;
            }
           
            funcionario.DataCadastro = DateTime.Now;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //mover os dados para a classe funcionario
            try
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Nome = txtNome.Text;
                funcionario.Email = txtEmail.Text;
                funcionario.Salario = Convert.ToDecimal(txtSalario.Text);
                //se o radMasculino for igual a true atribui M caso contrario atribui F
                funcionario.Sexo = (radMasculino.Checked) ? "M" : "F";
                //se clt estiver checado atribui CLT senão se radPj estiver checado atribui PJ caso contrario Autonomo
                funcionario.TipoContrato = (radCLT.Checked) ? "CLT" : (radPJ.Checked) ? "PJ" : "Autonomo";
                funcionario.DataCadastro = DateTime.Now;

                //validando
                List<ValidationResult> lisErros = new List<ValidationResult>();
                ValidationContext contexto = new ValidationContext(funcionario);
               bool validado =  Validator.TryValidateObject(funcionario, contexto, lisErros,true);

                if (validado)
                {
                    telaPrincipal.AtualizarTabela();
                    lblErro.Text = "";
                    FuncionarioDAO.SalvarFuncionario(funcionario);
                    
                }
                else
                {
                    StringBuilder sb = new StringBuilder();

                    foreach (ValidationResult erro in lisErros)
                    {
                        sb.Append(erro.ErrorMessage + "\n");

                    }
                    lblErro.Text = sb.ToString();


                }

            }
            catch (Exception a)
            {
                MessageBox.Show("Erro ao Salvar", "Erro: " + a, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        /*
         * stringBuilder atualiza um texto na tela assim que especifico as infoemações
         * 
         * private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder atualiza = new StringBuilder(txtNome.Text);
             

            label1.Text = atualiza.ToString();

        } */
    }
}

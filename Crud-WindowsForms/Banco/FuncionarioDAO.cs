using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlServerCe;
using Secao_02.Model;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Secao_02.Banco
{
    public class FuncionarioDAO
    {
        private static          //string de conex~~ao com o banco 
            SqlCeConnection conn = new SqlCeConnection(@"Data Source=C:\Users\wcogeo\Documents\__Estudos-CSharp\Secao_02\Banco\Cadastrar.sdf");
        public static DataTable GetFuncionario()
        {

            //prepara o sql e passa a conexao
            SqlCeDataAdapter da = new SqlCeDataAdapter(@"select * from Funcionario",conn);

            //ds pegue os dados
            DataSet ds = new DataSet();

            //passe todos os dados para o da
            da.Fill(ds);

            //retorna os dados em uma tabela 
            return ds.Tables[0];
        }

        public static Boolean SalvarFuncionario(Funcionario funcionario)
        {
            string sql = "insert into [Funcionario] (Nome, Email , Salario,Sexo,TipoContrato,DataCadastro)  values(@Nome, @Email , @Salario,@Sexo,@TipoContrato,@DataCadastro)";
            SqlCeCommand salvar = new SqlCeCommand(sql,conn);
            salvar.Parameters.Add("@Nome", funcionario.Nome);
            salvar.Parameters.Add("@Email", funcionario.Email);
            salvar.Parameters.Add("@Salario", funcionario.Salario);
            salvar.Parameters.Add("@Sexo", funcionario.Sexo);
            salvar.Parameters.Add("@TipoContrato", funcionario.TipoContrato);
            salvar.Parameters.Add("@DataCadastro", funcionario.DataCadastro);
            conn.Open();
            //salva e não retorna informação
           if(salvar.ExecuteNonQuery() > 0)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
            
        }

       public static Funcionario GetFuncionario(int id)
        {
            string sql = "select * from funcionario where Id == @Id";
            SqlCeCommand salvar = new SqlCeCommand(sql, conn);
            salvar.Parameters.Add("@Id",id);
            conn.Open();
            //salva e não retorna informação
     
                conn.Close();
            SqlCeDataReader resposta = salvar.ExecuteReader();
            Funcionario funcionario = new Funcionario();
            //vai ler  a reposta 
            while (resposta.Read())
            {
                //indice do Id e com base no indice pega a resposta
                funcionario.Id = resposta.GetInt32(0); //posição de cada Coluna
                funcionario.Nome = resposta.GetString(1);
                funcionario.Email = resposta.GetString(2);
                funcionario.Salario = resposta.GetDecimal(3);
                funcionario.Sexo = resposta.GetString(4);
                funcionario.TipoContrato = resposta.GetString(5);
                funcionario.DataCadastro = resposta.GetDateTime(6);
                funcionario.DataCadastro = resposta.GetDateTime(7);
            }

            //retorna todos os dados do Funcionario
            return funcionario;
        }



    }
}

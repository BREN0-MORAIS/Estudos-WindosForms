using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//validar formulario , utiliza data annotations
using System.ComponentModel.DataAnnotations;
namespace Secao_02.Model
{
    public class Funcionario
    {
        public int Id { get; set; }
        //faz com que o campo seja Obrigatorio e que o campo seja no maximo 70 e no minumo 7
        [Required] [StringLength(70, MinimumLength = 7)]
        public string Nome { get; set; }
        [Required][EmailAddress]
        public string Email { get; set; }
        public decimal Salario { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        public string TipoContrato { get; set; }

        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}

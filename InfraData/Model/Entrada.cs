using System.ComponentModel.DataAnnotations;

namespace SharedProject.Model
{
    public class Entrada : Base
    {
        [Required (ErrorMessage = "Informe um nome para esse valor por exemplo: Salário, Bônus, Alugel.")]
        [MinLength (3, ErrorMessage = "Use pelo menos 3 caracteres.")]
        public string Nome { get; set; }
        public double Valor { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}

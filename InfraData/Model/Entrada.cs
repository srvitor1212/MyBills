using System.ComponentModel.DataAnnotations;

namespace InfraData.Model
{
    public class Entrada : Base
    {
        [Required (ErrorMessage = "Nome não foi informado")]
        public string Nome { get; set; }
        public double Valor { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}

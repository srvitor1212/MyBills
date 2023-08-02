namespace InfraData.Model
{
    public class Entrada : Base
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}

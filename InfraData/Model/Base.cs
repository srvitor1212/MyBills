namespace SharedProject.Model
{
    public class Base
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DataCriacaoRegistro { get; set; }
        public DateTime DataAlteracaoRegistro { get; set; }
    }
}

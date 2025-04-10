namespace ProConsulta.Models
{
    public class PacienteModel
    {
        public int Id { get; set; }

        public string Nome { get; set; } = null!;

        public string Documento { get; set; }

        public string Email { get; set; }

        public string Celular { get; set; }

        public DateTime DataNascimento { get; set; }

        public ICollection<AgendamentoModel> Agendamentos { get; set; } = new List<AgendamentoModel>();
    }
}

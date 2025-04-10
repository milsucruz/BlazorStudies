namespace ProConsulta.Models
{
    public class MedicoModel
    {
        public int Id { get; set; }

        public string Nome { get; set; } = null!;

        public string Documento { get; set; }

        public string CRM { get; set; }

        public string Celular { get; set; }

        public DateTime DataCadastro { get; set; }

        public int EspecialidadeId { get; set; }

        public EspecialidadeModel Especialidade { get; set; }

        public ICollection<AgendamentoModel> Agendamentos { get; set; } = new List<AgendamentoModel>();
    }
}

namespace ProConsulta.Models
{
    public class AgendamentoModel
    {
        public int Id { get; set; }

        public string Observacao { get; set; }

        public int PacienteId { get; set; }

        public int MedicoId { get; set; }

        public TimeSpan HoraConsulta {  get; set; }

        public DateTime DataConsulta { get; set; }

        public PacienteModel Paciente { get; set; } = null!;

        public MedicoModel Medico { get; set; } = null!;
    }
}

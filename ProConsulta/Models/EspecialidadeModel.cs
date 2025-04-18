﻿namespace ProConsulta.Models
{
    public class EspecialidadeModel
    {
        public int Id { get; set; }

        public string Nome { get; set; } = null!;

        public string Descricao { get; set; }

        public ICollection<MedicoModel> Medicos { get; set; } = new List<MedicoModel>();
    }
}

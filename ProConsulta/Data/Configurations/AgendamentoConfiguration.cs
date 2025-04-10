using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProConsulta.Models;

namespace ProConsulta.Data.Configurations
{
    public class AgendamentoConfiguration : IEntityTypeConfiguration<AgendamentoModel>
    {
        public void Configure(EntityTypeBuilder<AgendamentoModel> builder)
        {
            builder.ToTable("Agendamentos");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Observacao)
                .IsRequired(true)
                .HasColumnType("VARCHAR(250)");

            builder.Property(a => a.PacienteId)
                .IsRequired();

            builder.Property(a => a.MedicoId)
                .IsRequired();
        }
    }
}

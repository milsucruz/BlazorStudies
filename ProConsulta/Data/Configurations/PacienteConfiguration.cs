using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProConsulta.Models;

namespace ProConsulta.Data.Configurations
{
    public class PacienteConfiguration : IEntityTypeConfiguration<PacienteModel>
    {
        public void Configure(EntityTypeBuilder<PacienteModel> builder)
        {
            builder.ToTable("Pacientes");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired(true)
                .HasColumnType("VARCHAR(50)");

            builder.Property(p => p.Documento)
                .IsRequired(true)
                .HasColumnType("NVARCHAR(11)");

            builder.Property(p => p.Email)
                .IsRequired(true)
                .HasColumnType("VARCHAR(50)");

            builder.Property(p => p.Celular)
                .IsRequired(true)
                .HasColumnType("NVARCHAR(11)");

            builder.HasIndex(p => p.Documento)
                .IsUnique();

            builder.HasMany(a => a.Agendamentos)
                .WithOne(p => p.Paciente)
                .HasForeignKey(a => a.PacienteId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

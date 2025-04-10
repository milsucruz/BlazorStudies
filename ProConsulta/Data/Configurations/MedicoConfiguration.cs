using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProConsulta.Models;

namespace ProConsulta.Data.Configurations
{
    public class MedicoConfiguration : IEntityTypeConfiguration<MedicoModel>
    {
        public void Configure(EntityTypeBuilder<MedicoModel> builder)
        {
            builder.ToTable("Medicos");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Nome)
                .IsRequired(true)
                .HasColumnType("VARCHAR(50)");

            builder.Property(m => m.Documento)
                .IsRequired(true)
                .HasColumnType("NVARCHAR(11)");

            builder.Property(m => m.CRM)
                .IsRequired(true)
                .HasColumnType("NVARCHAR(8)");

            builder.Property(m => m.Celular)
                .IsRequired(true)
                .HasColumnType("NVARCHAR(11)");

            builder.Property(m => m.EspecialidadeId)
                .IsRequired(true);

            builder.HasIndex(m => m.Documento)
                .IsUnique();

            builder.HasMany(m => m.Agendamentos)
                .WithOne(m => m.Medico)
                .HasForeignKey(a => a.MedicoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

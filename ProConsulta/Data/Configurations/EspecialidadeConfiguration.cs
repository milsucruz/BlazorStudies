using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProConsulta.Models;

namespace ProConsulta.Data.Configurations
{
    public class EspecialidadeConfiguration : IEntityTypeConfiguration<EspecialidadeModel>
    {
        public void Configure(EntityTypeBuilder<EspecialidadeModel> builder)
        {
            builder.ToTable("Especialidades");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome)
                .IsRequired(true)
                .HasColumnType("VARCHAR(60)");

            builder.Property(e => e.Descricao)
                .IsRequired(false)
                .HasColumnType("VARCHAR(150)");

            builder.HasMany(e => e.Medicos)
                .WithOne(m => m.Especialidade)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}

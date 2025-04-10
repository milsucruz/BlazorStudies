using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProConsulta.Models;
using System.Reflection;

namespace ProConsulta.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<MedicoModel> medicos { get; set; }

        public DbSet<EspecialidadeModel> especialidades { get; set; }

        public DbSet<PacienteModel> pacientes { get; set; }

        public DbSet<AgendamentoModel> agendamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            new DbInitializer(builder).Seed();

            base.OnModelCreating(builder);
        }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProConsulta.Models;

namespace ProConsulta.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder _modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        internal void Seed()
        {
            _modelBuilder.Entity<IdentityRole>().HasData
            (
                new IdentityRole
                {
                    Id = "b401550d-3793-42b8-9c82-c1471ee77294",
                    Name = "Atendente",
                    NormalizedName = "ATENDENTE"
                },
                new IdentityRole
                {
                    Id = "ed6f67eb-3718-4ed7-84f4-5a392ad1be1a",
                    Name = "Medico",
                    NormalizedName = "MEDICO"
                }
            );

            var hasher = new PasswordHasher<IdentityUser>();

            _modelBuilder.Entity<AtendenteModel>().HasData
            (
                new AtendenteModel
                {
                    Id = "4a4a7cbb-4acc-4c29-a132-8783e2e489c5",
                    Nome = "Atendente",
                    Email = "blazorStudies@gmail.com",
                    EmailConfirmed = true,
                    UserName = "blazorStudies@gmail.com",
                    NormalizedEmail = "BLAZORSTUDIES@GMAIL.COM",
                    NormalizedUserName = "BLAZORSTUDIES@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                }
            );

            _modelBuilder.Entity<IdentityUserRole<string>>().HasData
            (
                new IdentityUserRole<string>
                {
                    RoleId = "b401550d-3793-42b8-9c82-c1471ee77294",
                    UserId = "4a4a7cbb-4acc-4c29-a132-8783e2e489c5"
                }
            );

            _modelBuilder.Entity<EspecialidadeModel>().HasData
            (
                new EspecialidadeModel
                {
                    Id = 1,
                    Nome = "Cardiologia",
                    Descricao = "Diagnóstico e tratamento de doenças do coração e sistema circulatório."
                },
                new EspecialidadeModel
                {
                    Id = 2,
                    Nome = "Dermatologia",
                    Descricao = "Tratamento de doenças da pele, cabelo e unhas."
                },
                new EspecialidadeModel
                {
                    Id = 3,
                    Nome = "Neurologia",
                    Descricao = "Especialidade que trata distúrbios do sistema nervoso."
                },
                new EspecialidadeModel
                {
                    Id = 4,
                    Nome = "Pediatria",
                    Descricao = "Cuida da saúde de crianças e adolescentes."
                },
                new EspecialidadeModel
                {
                    Id = 5,
                    Nome = "Ortopedia",
                    Descricao = "Diagnóstico e tratamento de problemas nos ossos e articulações."
                },
                new EspecialidadeModel
                {
                    Id = 6,
                    Nome = "Ginecologia",
                    Descricao = "Atendimento à saúde do sistema reprodutor feminino."
                },
                new EspecialidadeModel
                {
                    Id = 7,
                    Nome = "Psiquiatria",
                    Descricao = "Diagnóstico e tratamento de transtornos mentais."
                },
                new EspecialidadeModel
                {
                    Id = 8,
                    Nome = "Oftalmologia",
                    Descricao = "Trata doenças e condições relacionadas à visão."
                },
                new EspecialidadeModel
                {
                    Id = 9,
                    Nome = "Endocrinologia",
                    Descricao = "Estuda distúrbios hormonais e glândulas endócrinas."
                },
                new EspecialidadeModel
                {
                    Id = 10,
                    Nome = "Gastroenterologia",
                    Descricao = "Diagnóstico e tratamento de doenças do sistema digestivo."
                }
            );
        }
    }
}

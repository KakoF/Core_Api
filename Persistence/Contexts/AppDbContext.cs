using System;
using Agendamento.API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Agendamento.API.Persistence.Contexts
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options){ }
        public DbSet<Usuario> Usuarios {get;set;}

         public DbSet<Sala> Salas {get;set;}

          public DbSet<Domain.Models.Agendamento> Agendamentos {get;set;}

        protected override void OnModelCreating (ModelBuilder builder){
            base.OnModelCreating (builder);
            builder.Entity<Usuario> ().HasKey(propertyNames => propertyNames.Id);
            builder.Entity<Usuario> ().Property(propertyNames => propertyNames.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Usuario> ().Property(propertyNames=> propertyNames.Nome).IsRequired().HasMaxLength(100);
            builder.Entity<Usuario> ().Property(propertyNames=> propertyNames.Email).IsRequired().HasMaxLength(100);
            builder.Entity<Usuario> ().Property(propertyNames=> propertyNames.Senha).IsRequired().HasMaxLength(100);
            builder.Entity<Usuario> ().HasMany
                (p => p.Agendamentos).WithOne(p => p.Usuario).HasForeignKey(p => p.UsuarioId);

            builder.Entity<Usuario> ().HasData (
                new Usuario { Id = 1, Nome = "Usuário1", Email = "usuario1@gmail.com", Senha = "123456" },
                new Usuario { Id = 2, Nome = "Usuário2", Email = "usuario2@gmail.com", Senha = "789456" },
                new Usuario { Id = 3, Nome = "Usuário3", Email = "usuario3@gmail.com", Senha = "789123" }
            );


            builder.Entity<Sala> ().HasKey(propertyNames => propertyNames.Id);
            builder.Entity<Sala> ().Property(propertyNames => propertyNames.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Sala> ().Property(propertyNames=> propertyNames.Nome).IsRequired().HasMaxLength(100);
            builder.Entity<Sala> ().HasMany
                (p => p.Agendamentos).WithOne(p => p.Sala).HasForeignKey(p => p.UsuarioId);

             builder.Entity<Sala> ().HasData (
                new Sala { Id = 1, Nome = "Sala 1"},
                new Sala { Id = 2, Nome = "Sala 2"},
                new Sala { Id = 3, Nome = "Sala 3"},
                new Sala { Id = 4, Nome = "Sala 4"},
                new Sala { Id = 5, Nome = "Sala 5"},
                new Sala { Id = 6, Nome = "Sala 6"},
                new Sala { Id = 7, Nome = "Sala 7"},
                new Sala { Id = 8, Nome = "Sala 8"}
            );



            builder.Entity<Domain.Models.Agendamento> ().HasKey(propertyNames => propertyNames.Id);
            builder.Entity<Domain.Models.Agendamento> ().Property(propertyNames => propertyNames.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Domain.Models.Agendamento> ().Property(propertyNames=> propertyNames.Nome).IsRequired().HasMaxLength(100);
            builder.Entity<Domain.Models.Agendamento> ().Property(propertyNames=> propertyNames.DataInicio).IsRequired();
            builder.Entity<Domain.Models.Agendamento> ().Property(propertyNames=> propertyNames.DataFim).IsRequired();
            builder.Entity<Domain.Models.Agendamento> ().Property(propertyNames=> propertyNames.Intervalo).IsRequired();
            builder.Entity<Domain.Models.Agendamento> ().HasOne(p => p.Usuario);
            builder.Entity<Domain.Models.Agendamento> ().HasOne(p => p.Sala);

             builder.Entity<Domain.Models.Agendamento> ().HasData (
                new Domain.Models.Agendamento { Id = 1, Nome = "Agendamento 1", DataInicio = DateTime.Now, DataFim = DateTime.Now.AddDays(1), Intervalo = EIntervalo.Dia, UsuarioId = 1, SalaId = 1  },
                new Domain.Models.Agendamento { Id = 2, Nome = "Agendamento 2", DataInicio = DateTime.Now, DataFim = DateTime.Now.AddDays(7), Intervalo = EIntervalo.Semana, UsuarioId = 1, SalaId = 2  },
                new Domain.Models.Agendamento { Id = 3, Nome = "Agendamento 3", DataInicio = DateTime.Now, DataFim = DateTime.Now.AddDays(7), Intervalo = EIntervalo.Semana, UsuarioId = 3, SalaId = 1  },
                new Domain.Models.Agendamento { Id = 4, Nome = "Agendamento 4", DataInicio = DateTime.Now, DataFim = DateTime.Now.AddDays(30), Intervalo = EIntervalo.Mes, UsuarioId = 3, SalaId = 4  },
                new Domain.Models.Agendamento { Id = 5, Nome = "Agendamento 5", DataInicio = DateTime.Now, DataFim = DateTime.Now.AddDays(1), Intervalo = EIntervalo.Dia, UsuarioId = 1, SalaId = 5  },
                new Domain.Models.Agendamento { Id = 6, Nome = "Agendamento 6", DataInicio = DateTime.Now, DataFim = DateTime.Now.AddDays(30), Intervalo = EIntervalo.Mes, UsuarioId = 1, SalaId = 8  }
            );




        }        
    }
}
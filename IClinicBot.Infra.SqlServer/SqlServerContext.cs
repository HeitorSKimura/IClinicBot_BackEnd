﻿using IClinicBot.Domain.CadastroContext;
using IClinicBot.Domain.ConsultaContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Infra.SqlServer
{
    public class SqlServerContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=IClinicBot");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().UseTpcMappingStrategy();

            // ENUM Consulta -> TipoConsulta
            modelBuilder.Entity<Consulta>()
                .Property(c => c.Tipo)
                .HasConversion<int>();

            // ENUM Agenda -> StatusAgenda
            modelBuilder.Entity<Agenda>()
                .Property(c => c.Status)
                .HasConversion<int>();

            // Endereco --> Consulta        -- Um para Muitos
            modelBuilder.Entity<Endereco>()
                .HasMany(e => e.Consultas)
                .WithOne(e => e.Endereco)
                .HasForeignKey(e => e.idEndereco)
                .IsRequired();

            // Paciente --> Consulta        -- Um para Muitos
            modelBuilder.Entity<Paciente>()
                .HasMany(e => e.Consultas)
                .WithOne(e => e.Paciente)
                .HasForeignKey(e => e.idPaciente)
                .IsRequired();

            // Medico --> Consulta          -- Muitos para Muitos
            modelBuilder.Entity<Medico>()
                .HasMany(e => e.Consultas)
                .WithMany(e => e.Medicos)
                .UsingEntity<MedicoConsulta>();

            // Paciente --> Exame           -- Um para Muitos
            modelBuilder.Entity<Paciente>()
                .HasMany(e => e.Exames)
                .WithOne(e => e.Paciente)
                .HasForeignKey(e => e.idPaciente)
                .IsRequired();

            // Medico --> Exame             -- Muitos para Muitos
            modelBuilder.Entity<Medico>()
                .HasMany(e => e.Exames)
                .WithMany(e => e.Medicos)
                .UsingEntity<MedicoExame>();

            // Medico --> Agenda            -- Um para Muitos
            modelBuilder.Entity<Medico>()
                .HasMany(e => e.Agendas)
                .WithOne(e => e.Medico)
                .HasForeignKey(e => e.idMedico)
                .IsRequired();

            // Consulta --> Agenda          -- Um Para Muitos
            modelBuilder.Entity<Consulta>()
                .HasMany(e => e.Agendas)
                .WithOne(e => e.Consulta)
                .HasForeignKey(e => e.idConsulta)
                .IsRequired(false);

            // Consulta --> AgendaMedico          -- Um Para Muitos
            modelBuilder.Entity<Medico>()
                .HasMany(e => e.AgendasMedico)
                .WithOne(e => e.Medico)
                .HasForeignKey(e => e.idMedico)
                .IsRequired();

            modelBuilder.Entity<AgendaChatBot>()
                .HasKey(a => a.idAgendaChatBot);

            modelBuilder.Entity<AgendaMedico>()
                .HasKey(a => a.idAgendaMedico);
        }

        // CadastroContext
        public DbSet<User> Users { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        // ConsultaContext
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<ConsultaChatBot> ConsultasChatBot { get; set; }
        public DbSet<ConsultaPresencial> ConsultasPresencial { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<MedicoConsulta> MedicoConsultas { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<MedicoExame> MedicoExames { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<AgendaChatBot> AgendasChatBot { get; set; }
        public DbSet<AgendaMedico> AgendasMedico { get; set; }
    }
}

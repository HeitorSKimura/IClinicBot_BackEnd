﻿// <auto-generated />
using System;
using IClinicBot.Infra.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IClinicBot.Infra.SqlServer.Migrations
{
    [DbContext(typeof(SqlServerContext))]
    [Migration("20241030225457_seguranca")]
    partial class seguranca
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("UserSequence");

            modelBuilder.Entity("IClinicBot.Domain.CadastroContext.User", b =>
                {
                    b.Property<int>("idCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR [UserSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<int>("idCadastro"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistroCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCadastro");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("IClinicBot.Domain.ConsultaContext.Agenda", b =>
                {
                    b.Property<int>("idAgenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idAgenda"));

                    b.Property<DateTime>("DataAgenda")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RegistroAgenda")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("idConsulta")
                        .HasColumnType("int");

                    b.Property<int>("idMedico")
                        .HasColumnType("int");

                    b.HasKey("idAgenda");

                    b.HasIndex("idConsulta");

                    b.HasIndex("idMedico");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("IClinicBot.Domain.ConsultaContext.AgendaChatBot", b =>
                {
                    b.Property<int>("idAgendaChatBot")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idAgendaChatBot"));

                    b.Property<string>("Cel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataAgendaChatBot")
                        .HasColumnType("datetime2");

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormaPagamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idAgendaChatBot");

                    b.ToTable("AgendasChatBot");
                });

            modelBuilder.Entity("IClinicBot.Domain.ConsultaContext.AgendaMedico", b =>
                {
                    b.Property<int>("idAgendaMedico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idAgendaMedico"));

                    b.Property<DateTime>("DataAgendaDisponivel")
                        .HasColumnType("datetime2");

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idMedico")
                        .HasColumnType("int");

                    b.HasKey("idAgendaMedico");

                    b.HasIndex("idMedico");

                    b.ToTable("AgendasMedico");
                });

            modelBuilder.Entity("IClinicBot.Domain.ConsultaContext.Consulta", b =>
                {
                    b.Property<int>("idConsulta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idConsulta"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<DateTime>("RegistroConsulta")
                        .HasColumnType("datetime2");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<int>("idEndereco")
                        .HasColumnType("int");

                    b.Property<int>("idPaciente")
                        .HasColumnType("int");

                    b.HasKey("idConsulta");

                    b.HasIndex("idEndereco");

                    b.HasIndex("idPaciente");

                    b.ToTable("Consultas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Consulta");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("IClinicBot.Domain.ConsultaContext.Endereco", b =>
                {
                    b.Property<int>("idEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idEndereco"));

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UF")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idEndereco");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("IClinicBot.Domain.ConsultaContext.Exame", b =>
                {
                    b.Property<int>("idExame")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idExame"));

                    b.Property<DateTime>("DataExame")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RegistroExame")
                        .HasColumnType("datetime2");

                    b.Property<int>("idPaciente")
                        .HasColumnType("int");

                    b.HasKey("idExame");

                    b.HasIndex("idPaciente");

                    b.ToTable("Exames");
                });

            modelBuilder.Entity("IClinicBot.Domain.ConsultaContext.MedicoConsulta", b =>
                {
                    b.Property<int>("idMedicoConsulta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idMedicoConsulta"));

                    b.Property<int>("ConsultaidConsulta")
                        .HasColumnType("int");

                    b.Property<int>("MedicoidCadastro")
                        .HasColumnType("int");

                    b.Property<int>("idConsulta")
                        .HasColumnType("int");

                    b.Property<int>("idMedico")
                        .HasColumnType("int");

                    b.HasKey("idMedicoConsulta");

                    b.HasIndex("ConsultaidConsulta");

                    b.HasIndex("MedicoidCadastro");

                    b.ToTable("MedicoConsultas");
                });

            modelBuilder.Entity("IClinicBot.Domain.ConsultaContext.MedicoExame", b =>
                {
                    b.Property<int>("idMedicoExame")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idMedicoExame"));

                    b.Property<int>("ExameidExame")
                        .HasColumnType("int");

                    b.Property<int>("MedicoidCadastro")
                        .HasColumnType("int");

                    b.Property<int>("idExame")
                        .HasColumnType("int");

                    b.Property<int>("idMedico")
                        .HasColumnType("int");

                    b.HasKey("idMedicoExame");

                    b.HasIndex("ExameidExame");

                    b.HasIndex("MedicoidCadastro");

                    b.ToTable("MedicoExames");
                });

            modelBuilder.Entity("IClinicBot.Domain.Entidades.CadastroContext.Contato", b =>
                {
                    b.Property<int>("idContato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idContato"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mensagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idContato");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("IClinicBot.Domain.CadastroContext.Medico", b =>
                {
                    b.HasBaseType("IClinicBot.Domain.CadastroContext.User");

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("IClinicBot.Domain.CadastroContext.Paciente", b =>
                {
                    b.HasBaseType("IClinicBot.Domain.CadastroContext.User");

                    b.Property<string>("Idade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Peso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tamanho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("IClinicBot.Domain.ConsultaContext.ConsultaChatBot", b =>
                {
                    b.HasBaseType("IClinicBot.Domain.ConsultaContext.Consulta");

                    b.Property<string>("Conversa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ConsultaChatBot");
                });

            modelBuilder.Entity("IClinicBot.Domain.ConsultaContext.ConsultaPresencial", b =>
                {
                    b.HasBaseType("IClinicBot.Domain.ConsultaContext.Consulta");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ConsultaPresencial");
                });

            modelBuilder.Entity("IClinicBot.Domain.ConsultaContext.Agenda", b =>
                {
                    b.HasOne("IClinicBot.Domain.ConsultaContext.Consulta", "Consulta")
                        .WithMany("Agendas")
                        .HasForeignKey("idConsulta");

                    b.HasOne("IClinicBot.Domain.CadastroContext.Medico", "Medico")
                        .WithMany("Agendas")
                        .HasForeignKey("idMedico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consulta");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("IClinicBot.Domain.ConsultaContext.AgendaMedico", b =>
                {
                    b.HasOne("IClinicBot.Domain.CadastroContext.Medico", "Medico")
                        .WithMany("AgendasMedico")
                        .HasForeignKey("idMedico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("IClinicBot.Domain.ConsultaContext.Consulta", b =>
                {
                    b.HasOne("IClinicBot.Domain.ConsultaContext.Endereco", "Endereco")
                        .WithMany("Consultas")
                        .HasForeignKey("idEndereco")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IClinicBot.Domain.CadastroContext.Paciente", "Paciente")
                        .WithMany("Consultas")
                        .HasForeignKey("idPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("IClinicBot.Domain.ConsultaContext.Exame", b =>
                {
                    b.HasOne("IClinicBot.Domain.CadastroContext.Paciente", "Paciente")
                        .WithMany("Exames")
                        .HasForeignKey("idPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("IClinicBot.Domain.ConsultaContext.MedicoConsulta", b =>
                {
                    b.HasOne("IClinicBot.Domain.ConsultaContext.Consulta", "Consulta")
                        .WithMany()
                        .HasForeignKey("ConsultaidConsulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IClinicBot.Domain.CadastroContext.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoidCadastro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consulta");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("IClinicBot.Domain.ConsultaContext.MedicoExame", b =>
                {
                    b.HasOne("IClinicBot.Domain.ConsultaContext.Exame", "Exame")
                        .WithMany()
                        .HasForeignKey("ExameidExame")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IClinicBot.Domain.CadastroContext.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoidCadastro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exame");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("IClinicBot.Domain.ConsultaContext.Consulta", b =>
                {
                    b.Navigation("Agendas");
                });

            modelBuilder.Entity("IClinicBot.Domain.ConsultaContext.Endereco", b =>
                {
                    b.Navigation("Consultas");
                });

            modelBuilder.Entity("IClinicBot.Domain.CadastroContext.Medico", b =>
                {
                    b.Navigation("Agendas");

                    b.Navigation("AgendasMedico");
                });

            modelBuilder.Entity("IClinicBot.Domain.CadastroContext.Paciente", b =>
                {
                    b.Navigation("Consultas");

                    b.Navigation("Exames");
                });
#pragma warning restore 612, 618
        }
    }
}

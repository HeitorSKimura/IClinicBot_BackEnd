﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IClinicBot.Infra.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "UserSequence");

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    idEndereco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.idEndereco);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    idCadastro = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [UserSequence]"),
                    NomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CRM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.idCadastro);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    idCadastro = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [UserSequence]"),
                    NomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Peso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tamanho = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.idCadastro);
                });

            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    idConsulta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataConsulta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistroConsulta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idEndereco = table.Column<int>(type: "int", nullable: false),
                    idPaciente = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Conversa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.idConsulta);
                    table.ForeignKey(
                        name: "FK_Consultas_Enderecos_idEndereco",
                        column: x => x.idEndereco,
                        principalTable: "Enderecos",
                        principalColumn: "idEndereco",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultas_Pacientes_idPaciente",
                        column: x => x.idPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "idCadastro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exames",
                columns: table => new
                {
                    idExame = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataExame = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistroExame = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idPaciente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exames", x => x.idExame);
                    table.ForeignKey(
                        name: "FK_Exames_Pacientes_idPaciente",
                        column: x => x.idPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "idCadastro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicoConsultas",
                columns: table => new
                {
                    idMedicoConsulta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idMedico = table.Column<int>(type: "int", nullable: false),
                    MedicoidCadastro = table.Column<int>(type: "int", nullable: false),
                    idConsulta = table.Column<int>(type: "int", nullable: false),
                    ConsultaidConsulta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoConsultas", x => x.idMedicoConsulta);
                    table.ForeignKey(
                        name: "FK_MedicoConsultas_Consultas_ConsultaidConsulta",
                        column: x => x.ConsultaidConsulta,
                        principalTable: "Consultas",
                        principalColumn: "idConsulta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicoConsultas_Medicos_MedicoidCadastro",
                        column: x => x.MedicoidCadastro,
                        principalTable: "Medicos",
                        principalColumn: "idCadastro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicoExames",
                columns: table => new
                {
                    idMedicoExame = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idMedico = table.Column<int>(type: "int", nullable: false),
                    MedicoidCadastro = table.Column<int>(type: "int", nullable: false),
                    idExame = table.Column<int>(type: "int", nullable: false),
                    ExameidExame = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoExames", x => x.idMedicoExame);
                    table.ForeignKey(
                        name: "FK_MedicoExames_Exames_ExameidExame",
                        column: x => x.ExameidExame,
                        principalTable: "Exames",
                        principalColumn: "idExame",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicoExames_Medicos_MedicoidCadastro",
                        column: x => x.MedicoidCadastro,
                        principalTable: "Medicos",
                        principalColumn: "idCadastro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_idEndereco",
                table: "Consultas",
                column: "idEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_idPaciente",
                table: "Consultas",
                column: "idPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_Exames_idPaciente",
                table: "Exames",
                column: "idPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoConsultas_ConsultaidConsulta",
                table: "MedicoConsultas",
                column: "ConsultaidConsulta");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoConsultas_MedicoidCadastro",
                table: "MedicoConsultas",
                column: "MedicoidCadastro");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoExames_ExameidExame",
                table: "MedicoExames",
                column: "ExameidExame");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoExames_MedicoidCadastro",
                table: "MedicoExames",
                column: "MedicoidCadastro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicoConsultas");

            migrationBuilder.DropTable(
                name: "MedicoExames");

            migrationBuilder.DropTable(
                name: "Consultas");

            migrationBuilder.DropTable(
                name: "Exames");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropSequence(
                name: "UserSequence");
        }
    }
}

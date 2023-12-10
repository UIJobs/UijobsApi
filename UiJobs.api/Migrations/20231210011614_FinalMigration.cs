using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UijobsApi.Migrations
{
    /// <inheritdoc />
    public partial class FinalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beneficio",
                columns: table => new
                {
                    idBeneficio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeBeneficio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficio", x => x.idBeneficio);
                });

            migrationBuilder.CreateTable(
                name: "Candidato",
                columns: table => new
                {
                    idCandidato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    nomeMae = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    dataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidato", x => x.idCandidato);
                });

            migrationBuilder.CreateTable(
                name: "Conhecimentos",
                columns: table => new
                {
                    idConhecimentos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeConhecimento = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conhecimentos", x => x.idConhecimentos);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    idCursos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeCurso = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    DiplomaCurso = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.idCursos);
                });

            migrationBuilder.CreateTable(
                name: "Escolaridade",
                columns: table => new
                {
                    idEscolaridade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeEscolaridade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escolaridade", x => x.idEscolaridade);
                });

            migrationBuilder.CreateTable(
                name: "Idiomas",
                columns: table => new
                {
                    idIdiomas = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeIdioma = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idiomas", x => x.idIdiomas);
                });

            migrationBuilder.CreateTable(
                name: "Nivel",
                columns: table => new
                {
                    idNivel = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    niveisDisponiveis = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nivel", x => x.idNivel);
                });

            migrationBuilder.CreateTable(
                name: "Portes",
                columns: table => new
                {
                    idPortes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tiposPortes = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portes", x => x.idPortes);
                });

            migrationBuilder.CreateTable(
                name: "SituacaoVaga",
                columns: table => new
                {
                    idSituacaoVaga = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    situacaoAtual = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituacaoVaga", x => x.idSituacaoVaga);
                });

            migrationBuilder.CreateTable(
                name: "EnderecoCandidato",
                columns: table => new
                {
                    idCandidato = table.Column<int>(type: "int", nullable: false),
                    cep = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    logradouro = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    endereco = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    numero = table.Column<int>(type: "int", nullable: false),
                    complemento = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    bairro = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    uf = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecoCandidato", x => x.idCandidato);
                    table.ForeignKey(
                        name: "FK_EnderecoCandidato_Candidato_idCandidato",
                        column: x => x.idCandidato,
                        principalTable: "Candidato",
                        principalColumn: "idCandidato",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Curriculo",
                columns: table => new
                {
                    idCurriculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idEscolaridade = table.Column<int>(type: "int", nullable: false),
                    idCandidato = table.Column<int>(type: "int", nullable: false),
                    objetivo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    dcCurriculo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    duCurriculo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curriculo", x => x.idCurriculo);
                    table.ForeignKey(
                        name: "FK_Curriculo_Candidato_idCandidato",
                        column: x => x.idCandidato,
                        principalTable: "Candidato",
                        principalColumn: "idCandidato",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Curriculo_Escolaridade_idEscolaridade",
                        column: x => x.idEscolaridade,
                        principalTable: "Escolaridade",
                        principalColumn: "idEscolaridade",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    idEmpresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idPortes = table.Column<int>(type: "int", nullable: false),
                    cnpj = table.Column<string>(type: "nvarchar(19)", maxLength: 19, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    razaoSocial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nomeFantasia = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.idEmpresa);
                    table.ForeignKey(
                        name: "FK_Empresa_Portes_idPortes",
                        column: x => x.idPortes,
                        principalTable: "Portes",
                        principalColumn: "idPortes",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarreiraProfissional",
                columns: table => new
                {
                    sqCarreiraProfissional = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idCurriculo = table.Column<int>(type: "int", nullable: false),
                    nomeEmpresa = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    tempoInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tempoFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cargo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarreiraProfissional", x => x.sqCarreiraProfissional);
                    table.ForeignKey(
                        name: "FK_CarreiraProfissional_Curriculo_idCurriculo",
                        column: x => x.idCurriculo,
                        principalTable: "Curriculo",
                        principalColumn: "idCurriculo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CurriculoConhecimentos",
                columns: table => new
                {
                    idCurriculo = table.Column<int>(type: "int", nullable: false),
                    idConhecimentos = table.Column<int>(type: "int", nullable: false),
                    idNivel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculoConhecimentos", x => new { x.idCurriculo, x.idConhecimentos });
                    table.ForeignKey(
                        name: "FK_CurriculoConhecimentos_Conhecimentos_idConhecimentos",
                        column: x => x.idConhecimentos,
                        principalTable: "Conhecimentos",
                        principalColumn: "idConhecimentos",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CurriculoConhecimentos_Curriculo_idCurriculo",
                        column: x => x.idCurriculo,
                        principalTable: "Curriculo",
                        principalColumn: "idCurriculo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CurriculoConhecimentos_Nivel_idNivel",
                        column: x => x.idNivel,
                        principalTable: "Nivel",
                        principalColumn: "idNivel",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CurriculoIdiomas",
                columns: table => new
                {
                    idCurriculo = table.Column<int>(type: "int", nullable: false),
                    idIdiomas = table.Column<int>(type: "int", nullable: false),
                    idNivel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculoIdiomas", x => new { x.idCurriculo, x.idIdiomas });
                    table.ForeignKey(
                        name: "FK_CurriculoIdiomas_Curriculo_idCurriculo",
                        column: x => x.idCurriculo,
                        principalTable: "Curriculo",
                        principalColumn: "idCurriculo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CurriculoIdiomas_Idiomas_idIdiomas",
                        column: x => x.idIdiomas,
                        principalTable: "Idiomas",
                        principalColumn: "idIdiomas",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CurriculoIdiomas_Nivel_idNivel",
                        column: x => x.idNivel,
                        principalTable: "Nivel",
                        principalColumn: "idNivel",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormacaoAcademica",
                columns: table => new
                {
                    idFormacaoAcademica = table.Column<int>(type: "int", nullable: false),
                    idCurriculo = table.Column<int>(type: "int", nullable: false),
                    idCursos = table.Column<int>(type: "int", nullable: false),
                    diCurso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dfCurso = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormacaoAcademica", x => new { x.idFormacaoAcademica, x.idCurriculo });
                    table.ForeignKey(
                        name: "FK_FormacaoAcademica_Curriculo_idCurriculo",
                        column: x => x.idCurriculo,
                        principalTable: "Curriculo",
                        principalColumn: "idCurriculo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormacaoAcademica_Cursos_idCursos",
                        column: x => x.idCursos,
                        principalTable: "Cursos",
                        principalColumn: "idCursos",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EnderecoEmpresa",
                columns: table => new
                {
                    idEmpresa = table.Column<int>(type: "int", nullable: false),
                    cep = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    logradouro = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    endereco = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    numero = table.Column<int>(type: "int", nullable: false),
                    complemento = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    bairro = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    uf = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecoEmpresa", x => x.idEmpresa);
                    table.ForeignKey(
                        name: "FK_EnderecoEmpresa_Empresa_idEmpresa",
                        column: x => x.idEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "idEmpresa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vagas",
                columns: table => new
                {
                    idVagas = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idEscolaridade = table.Column<int>(type: "int", nullable: false),
                    idSituacaoVaga = table.Column<int>(type: "int", nullable: false),
                    idEmpresa = table.Column<int>(type: "int", nullable: false),
                    cargo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    inicioVigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    finalVigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    salario = table.Column<float>(type: "real", nullable: true),
                    cargaHoraria = table.Column<short>(type: "smallint", nullable: false),
                    localidade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    percAderencia = table.Column<float>(type: "real", nullable: false),
                    tempoSemanal = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vagas", x => x.idVagas);
                    table.ForeignKey(
                        name: "FK_Vagas_Empresa_idEmpresa",
                        column: x => x.idEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "idEmpresa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vagas_Escolaridade_idEscolaridade",
                        column: x => x.idEscolaridade,
                        principalTable: "Escolaridade",
                        principalColumn: "idEscolaridade",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vagas_SituacaoVaga_idSituacaoVaga",
                        column: x => x.idSituacaoVaga,
                        principalTable: "SituacaoVaga",
                        principalColumn: "idSituacaoVaga",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BeneficioVagas",
                columns: table => new
                {
                    idVagas = table.Column<int>(type: "int", nullable: false),
                    idBeneficio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeneficioVagas", x => new { x.idVagas, x.idBeneficio });
                    table.ForeignKey(
                        name: "FK_BeneficioVagas_Beneficio_idBeneficio",
                        column: x => x.idBeneficio,
                        principalTable: "Beneficio",
                        principalColumn: "idBeneficio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BeneficioVagas_Vagas_idVagas",
                        column: x => x.idVagas,
                        principalTable: "Vagas",
                        principalColumn: "idVagas",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VagasCandidato",
                columns: table => new
                {
                    idVagas = table.Column<int>(type: "int", nullable: false),
                    idCurriculo = table.Column<int>(type: "int", nullable: false),
                    dcCurriculo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    vtEmpresa = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    vtCandidato = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    percAderencia = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VagasCandidato", x => new { x.idCurriculo, x.idVagas });
                    table.ForeignKey(
                        name: "FK_VagasCandidato_Curriculo_idCurriculo",
                        column: x => x.idCurriculo,
                        principalTable: "Curriculo",
                        principalColumn: "idCurriculo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VagasCandidato_Vagas_idVagas",
                        column: x => x.idVagas,
                        principalTable: "Vagas",
                        principalColumn: "idVagas",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VagasConhecimentos",
                columns: table => new
                {
                    idVagas = table.Column<int>(type: "int", nullable: false),
                    idConhecimentos = table.Column<int>(type: "int", nullable: false),
                    idNivel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VagasConhecimentos", x => new { x.idVagas, x.idConhecimentos });
                    table.ForeignKey(
                        name: "FK_VagasConhecimentos_Conhecimentos_idConhecimentos",
                        column: x => x.idConhecimentos,
                        principalTable: "Conhecimentos",
                        principalColumn: "idConhecimentos",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VagasConhecimentos_Nivel_idNivel",
                        column: x => x.idNivel,
                        principalTable: "Nivel",
                        principalColumn: "idNivel",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VagasConhecimentos_Vagas_idVagas",
                        column: x => x.idVagas,
                        principalTable: "Vagas",
                        principalColumn: "idVagas",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VagasIdiomas",
                columns: table => new
                {
                    idVagas = table.Column<int>(type: "int", nullable: false),
                    idIdiomas = table.Column<int>(type: "int", nullable: false),
                    idNivel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VagasIdiomas", x => new { x.idVagas, x.idIdiomas });
                    table.ForeignKey(
                        name: "FK_VagasIdiomas_Idiomas_idIdiomas",
                        column: x => x.idIdiomas,
                        principalTable: "Idiomas",
                        principalColumn: "idIdiomas",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VagasIdiomas_Nivel_idNivel",
                        column: x => x.idNivel,
                        principalTable: "Nivel",
                        principalColumn: "idNivel",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VagasIdiomas_Vagas_idVagas",
                        column: x => x.idVagas,
                        principalTable: "Vagas",
                        principalColumn: "idVagas",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Beneficio",
                columns: new[] { "idBeneficio", "nomeBeneficio" },
                values: new object[,]
                {
                    { 1, "Assistência Médica" },
                    { 2, "Assistência Odontológica" },
                    { 3, "Vale-Refeição" },
                    { 4, "Vale-Alimentação" },
                    { 5, "Vale-Transporte" },
                    { 6, "Auxílio Creche" },
                    { 7, "Home Office Flexível" },
                    { 8, "Programa de Desenvolvimento Profissional" },
                    { 9, "Horário Flexível" },
                    { 10, "Bônus Anual" },
                    { 11, "Participação nos Lucros e Resultados (PLR)" },
                    { 12, "Dias de Férias Adicionais" },
                    { 13, "Seguro de Vida" },
                    { 14, "Previdência Privada" },
                    { 15, "Ginástica Laboral" },
                    { 16, "Café da Manhã Grátis" },
                    { 17, "Auxílio-Educação" }
                });

            migrationBuilder.InsertData(
                table: "Conhecimentos",
                columns: new[] { "idConhecimentos", "nomeConhecimento" },
                values: new object[,]
                {
                    { 1, "HTML" },
                    { 2, "CSS" },
                    { 3, "JavaScript" },
                    { 4, "Java" },
                    { 5, "C#" },
                    { 6, "PHP" },
                    { 7, "SQL" },
                    { 8, "React" },
                    { 9, "Angular" },
                    { 10, "Vue.js" },
                    { 11, "Node.js" },
                    { 12, "Ruby" },
                    { 13, "Swift" },
                    { 14, "C" },
                    { 15, "C++" },
                    { 16, "COBOL" }
                });

            migrationBuilder.InsertData(
                table: "Escolaridade",
                columns: new[] { "idEscolaridade", "nomeEscolaridade" },
                values: new object[,]
                {
                    { 1, "Ensino Médio" },
                    { 2, "Ensino Médio Prof" },
                    { 3, "Técnico" },
                    { 4, "Graduação Tecnológica" },
                    { 5, "Graduação" },
                    { 6, "Pós Graduação" },
                    { 7, "Mestrado" },
                    { 8, "Doutorado" }
                });

            migrationBuilder.InsertData(
                table: "Idiomas",
                columns: new[] { "idIdiomas", "nomeIdioma" },
                values: new object[,]
                {
                    { 1, "Inglês" },
                    { 2, "Espanhol" },
                    { 3, "Francês" },
                    { 4, "Alemão" },
                    { 5, "Italiano" },
                    { 6, "Português" },
                    { 7, "Japonês" },
                    { 8, "Chinês" },
                    { 9, "Russo" },
                    { 10, "Árabe" },
                    { 11, "Corenao" },
                    { 12, "Holandês" },
                    { 13, "Sueco" },
                    { 14, "Dinamarquês" },
                    { 15, "Finlandês" }
                });

            migrationBuilder.InsertData(
                table: "Nivel",
                columns: new[] { "idNivel", "niveisDisponiveis" },
                values: new object[,]
                {
                    { 1, "Básico" },
                    { 2, "Intermediário" },
                    { 3, "Avançado" },
                    { 4, "Especialista" },
                    { 5, "Domínio" }
                });

            migrationBuilder.InsertData(
                table: "Portes",
                columns: new[] { "idPortes", "tiposPortes" },
                values: new object[,]
                {
                    { 1, "MicroEmpresa" },
                    { 2, "Pequena" },
                    { 3, "Média" },
                    { 4, "Grande" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BeneficioVagas_idBeneficio",
                table: "BeneficioVagas",
                column: "idBeneficio");

            migrationBuilder.CreateIndex(
                name: "IX_BeneficioVagas_idVagas_idBeneficio",
                table: "BeneficioVagas",
                columns: new[] { "idVagas", "idBeneficio" });

            migrationBuilder.CreateIndex(
                name: "IX_Candidato_email",
                table: "Candidato",
                column: "email");

            migrationBuilder.CreateIndex(
                name: "IX_CarreiraProfissional_idCurriculo",
                table: "CarreiraProfissional",
                column: "idCurriculo");

            migrationBuilder.CreateIndex(
                name: "IX_Curriculo_idCandidato",
                table: "Curriculo",
                column: "idCandidato");

            migrationBuilder.CreateIndex(
                name: "IX_Curriculo_idEscolaridade",
                table: "Curriculo",
                column: "idEscolaridade");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculoConhecimentos_idConhecimentos",
                table: "CurriculoConhecimentos",
                column: "idConhecimentos");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculoConhecimentos_idCurriculo_idConhecimentos",
                table: "CurriculoConhecimentos",
                columns: new[] { "idCurriculo", "idConhecimentos" });

            migrationBuilder.CreateIndex(
                name: "IX_CurriculoConhecimentos_idNivel",
                table: "CurriculoConhecimentos",
                column: "idNivel");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculoIdiomas_idCurriculo_idIdiomas",
                table: "CurriculoIdiomas",
                columns: new[] { "idCurriculo", "idIdiomas" });

            migrationBuilder.CreateIndex(
                name: "IX_CurriculoIdiomas_idIdiomas",
                table: "CurriculoIdiomas",
                column: "idIdiomas");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculoIdiomas_idNivel",
                table: "CurriculoIdiomas",
                column: "idNivel");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_DiplomaCurso",
                table: "Cursos",
                column: "DiplomaCurso");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_idPortes",
                table: "Empresa",
                column: "idPortes");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoCandidato_idCandidato",
                table: "EnderecoCandidato",
                column: "idCandidato");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoEmpresa_idEmpresa",
                table: "EnderecoEmpresa",
                column: "idEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_FormacaoAcademica_idCurriculo",
                table: "FormacaoAcademica",
                column: "idCurriculo");

            migrationBuilder.CreateIndex(
                name: "IX_FormacaoAcademica_idCursos",
                table: "FormacaoAcademica",
                column: "idCursos");

            migrationBuilder.CreateIndex(
                name: "IX_Vagas_idEmpresa",
                table: "Vagas",
                column: "idEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Vagas_idEscolaridade",
                table: "Vagas",
                column: "idEscolaridade");

            migrationBuilder.CreateIndex(
                name: "IX_Vagas_idSituacaoVaga",
                table: "Vagas",
                column: "idSituacaoVaga");

            migrationBuilder.CreateIndex(
                name: "IX_VagasCandidato_idVagas",
                table: "VagasCandidato",
                column: "idVagas");

            migrationBuilder.CreateIndex(
                name: "IX_VagasConhecimentos_idConhecimentos",
                table: "VagasConhecimentos",
                column: "idConhecimentos");

            migrationBuilder.CreateIndex(
                name: "IX_VagasConhecimentos_idNivel",
                table: "VagasConhecimentos",
                column: "idNivel");

            migrationBuilder.CreateIndex(
                name: "IX_VagasIdiomas_idIdiomas",
                table: "VagasIdiomas",
                column: "idIdiomas");

            migrationBuilder.CreateIndex(
                name: "IX_VagasIdiomas_idNivel",
                table: "VagasIdiomas",
                column: "idNivel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BeneficioVagas");

            migrationBuilder.DropTable(
                name: "CarreiraProfissional");

            migrationBuilder.DropTable(
                name: "CurriculoConhecimentos");

            migrationBuilder.DropTable(
                name: "CurriculoIdiomas");

            migrationBuilder.DropTable(
                name: "EnderecoCandidato");

            migrationBuilder.DropTable(
                name: "EnderecoEmpresa");

            migrationBuilder.DropTable(
                name: "FormacaoAcademica");

            migrationBuilder.DropTable(
                name: "VagasCandidato");

            migrationBuilder.DropTable(
                name: "VagasConhecimentos");

            migrationBuilder.DropTable(
                name: "VagasIdiomas");

            migrationBuilder.DropTable(
                name: "Beneficio");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Curriculo");

            migrationBuilder.DropTable(
                name: "Conhecimentos");

            migrationBuilder.DropTable(
                name: "Idiomas");

            migrationBuilder.DropTable(
                name: "Nivel");

            migrationBuilder.DropTable(
                name: "Vagas");

            migrationBuilder.DropTable(
                name: "Candidato");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Escolaridade");

            migrationBuilder.DropTable(
                name: "SituacaoVaga");

            migrationBuilder.DropTable(
                name: "Portes");
        }
    }
}

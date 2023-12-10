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
                table: "Candidato",
                columns: new[] { "idCandidato", "dataNascimento", "email", "nome", "nomeMae" },
                values: new object[,]
                {
                    { 1, new DateTime(1995, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "hungos0223@gmail.com", "Hugo", "Yasmin Fonseca da Silva" },
                    { 2, new DateTime(1990, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "caio@gmail.com", "Caio", "Rosana Caetano Romero" },
                    { 3, new DateTime(1987, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "peddro@gmail.com", "Peddro", "Mariestela Araujo da Silva" },
                    { 4, new DateTime(1992, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "nicole@gmail.com", "Nicole", "Giovanna Nascimento Gomes" },
                    { 5, new DateTime(1988, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "geovanna@gmail.com", "Geovanna", "Islayne Bragança Ervano" },
                    { 6, new DateTime(1991, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "yago@gmail.com", "Yago", "Agostinha Araujo Rezende" },
                    { 7, new DateTime(1985, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "erika@gmail.com", "Erika", "Marcy Vabo Silvino" },
                    { 8, new DateTime(1983, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "tarsi@outlook.com", "Tarcísio Felizardo Lopez", "Cristiane Vidal Felizardo" },
                    { 9, new DateTime(1982, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "rioslavanda2492@outlook.com", "Isaque Rios Sá", "Neiva Negris Rios" },
                    { 10, new DateTime(1989, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "maycontwo02@gmail.com", "Maycon Camara Leite", "Emanuelle Theodoro Camara" }
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
                table: "Cursos",
                columns: new[] { "idCursos", "DiplomaCurso", "nomeCurso" },
                values: new object[,]
                {
                    { 1, "S", "Ciências da Computação" },
                    { 2, "S", "Redes e Segurança" },
                    { 3, "S", "Banco de Dados" },
                    { 4, "N", "Excel" },
                    { 5, "N", "Office" },
                    { 6, "S", "Aprender Python" },
                    { 7, "N", "Marketing Digital" },
                    { 8, "S", "InfraEstrutura" },
                    { 9, "S", "World" },
                    { 10, "S", "PowerPoint" }
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

            migrationBuilder.InsertData(
                table: "SituacaoVaga",
                columns: new[] { "idSituacaoVaga", "situacaoAtual" },
                values: new object[,]
                {
                    { 1, "Inciada" },
                    { 2, "Concluída" },
                    { 3, "Suspensa" },
                    { 4, "Cancelada" }
                });

            migrationBuilder.InsertData(
                table: "Curriculo",
                columns: new[] { "idCurriculo", "dcCurriculo", "duCurriculo", "idCandidato", "idEscolaridade", "objetivo" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "Meu Objetivo é ser o maior fullstack do Brasil e do mundo, estou entrando nessa empresa com conhecimentos técnicos para atingir meu objetivo" },
                    { 2, new DateTime(2022, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "Estou em busca de um emprego para desenvolver minhas habilidades em JAVA" },
                    { 3, new DateTime(2014, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, "Só alcança quem começa" },
                    { 4, new DateTime(2012, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2, "O dinheiro não é o problema, a falta de ideias criativas para ganhá-lo que é" },
                    { 5, new DateTime(2015, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2, "Até agora, tenho estado a evitar a sua inevitabilidade." },
                    { 6, new DateTime(2020, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2, "É possível, mas achamos bastante duvidoso." },
                    { 7, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2, "As pessoas devem olhar para mim para a consistência e perseverança." },
                    { 8, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 2, "As pessoas devem olhar para mim para a consistência e perseverança." },
                    { 9, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 2, "As pessoas devem olhar para mim para a consistência e perseverança." },
                    { 10, new DateTime(2009, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 2, "O número de combinações possíveis e consequentes utilizações parece ilimitado." }
                });

            migrationBuilder.InsertData(
                table: "Empresa",
                columns: new[] { "idEmpresa", "cnpj", "email", "idPortes", "nomeFantasia", "razaoSocial" },
                values: new object[,]
                {
                    { 1, "11.722.246/0001-93", "suportes@testes.com", 2, "Teste", "Ficticios para Testes SA" },
                    { 2, "07.476.034/0001-04", "edson@marciolimpeza.com", 1, "Edcios Limpezas", "Edson e Márcio Limpeza Ltda" },
                    { 3, "78.311.160/0001-49", "clara@otavioassessoria.com", 2, "Acessoria Jurídica do Salvador", "Clara e Otávio Assessoria Jurídica ME" },
                    { 4, "66.267.347/0001-03", "daiane@pedrocontabil.com", 3, "Remus Contabil", "Daiane e Pedro Contábil Ltda" },
                    { 5, "55.116.850/0001-41", "malu@renancasanoturna.com", 1, "The Noitada Malunan", "Malu e Renan Casa Noturna Ltda" },
                    { 6, "87.356.417/0001-70", "elias@mateusinformatica.com", 3, "Eltias Tech", "Elias e Mateus Informática Ltda" },
                    { 7, "07.139.029/0001-06", "lorenzo@rafaelafotografias.com", 3, "Photorela", "Lorenzo e Rafaela Fotografias Ltda" },
                    { 8, "89.150.471/0001-90", "manoel@alanaautomoveis.com", 2, "Manoel Automóveis", "Manoel e Alana Locações de Automóveis Ltda" },
                    { 9, "21.799.677/0001-01", "benjamin@isabelfinanceira.com", 2, "Benj&Isa Finaceiros", "Benjamin e Isabel Consultoria Financeira ME" },
                    { 10, "53.034.779/0001-22", "emily@giovannaautomoveis.com", 4, "Metrono Auto", "Emily e Giovanna Locações de Automóveis ME" }
                });

            migrationBuilder.InsertData(
                table: "EnderecoCandidato",
                columns: new[] { "idCandidato", "bairro", "cep", "cidade", "complemento", "endereco", "logradouro", "numero", "uf" },
                values: new object[,]
                {
                    { 1, "Vila Guilherme", "77007116", "São Paulo", null, "Alcantara", "Rua", 354, "SP" },
                    { 2, "Aerolândia", "64601203", "Picos", "Apt 13 Bloco A", "Projetada", "Rua", 28, "PI" },
                    { 3, "Marianga", "49504462", "Salvador", null, "E", "Rua", 2242, "BA" },
                    { 4, "Vila Lobos", "77020004", "São Sebastião", null, "Itau", "Avenida", 34, "MG" },
                    { 5, "Liberdade", "69911202", "São Paulo", "2 Andar", "Japão Liberdade", "Rua", 34, "SP" },
                    { 6, "São Joaquin", "77804170", "Lima Campos", "5 Andar Bloco C", "Roraima", "Avenida", 4343, "RJ" },
                    { 7, "Santo Antônio", "69908070", "Aracaju", null, "José do Rio Preto", "Rua", 45, "SE" },
                    { 8, "Novo Paraíso", "65140970", "Aracaju", "5 Andar Bloco C", "Claudio Batista 122", "Rua", 122, "SE" },
                    { 9, "São Joaquin", "15047224", "Lima Campos", null, "Alberto Belintani", "Rua", 734, "RJ" },
                    { 10, "Wilson", "97578146", "Santana do Livramento", null, "João Flores da Cunha", "Rua", 666, "RS" }
                });

            migrationBuilder.InsertData(
                table: "CarreiraProfissional",
                columns: new[] { "sqCarreiraProfissional", "cargo", "idCurriculo", "nomeEmpresa", "tempoFim", "tempoInicio" },
                values: new object[,]
                {
                    { 1, "Gerente", 1, "Bradesco", new DateTime(2022, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Desenvolvedor", 2, "Ubisoft", new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Analista de Banco de Dados", 3, "Oracle", new DateTime(2020, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Engenheiro de Software", 4, "Google", new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Arquiteto de Soluções", 5, "Amazon", new DateTime(2018, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Especialista em Cloud Computing", 6, "Microsoft", new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Designer de Jogos", 7, "ChibiliKid", new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Gerente de Projetos", 8, "Bradesco", new DateTime(2022, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Especialista em Inovação Tecnológica", 9, "Tech Innovations", new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Analista de Sistemas", 10, "FutureTech", new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CurriculoConhecimentos",
                columns: new[] { "idConhecimentos", "idCurriculo", "idNivel" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 1, 3 },
                    { 3, 2, 1 },
                    { 4, 2, 2 },
                    { 5, 3, 3 },
                    { 6, 3, 1 },
                    { 7, 4, 2 },
                    { 8, 4, 3 },
                    { 9, 5, 3 },
                    { 10, 5, 1 },
                    { 11, 6, 2 },
                    { 12, 6, 3 },
                    { 13, 7, 3 },
                    { 14, 7, 1 },
                    { 12, 8, 3 },
                    { 15, 8, 2 },
                    { 13, 9, 3 },
                    { 14, 9, 1 },
                    { 12, 10, 3 },
                    { 15, 10, 2 }
                });

            migrationBuilder.InsertData(
                table: "CurriculoIdiomas",
                columns: new[] { "idCurriculo", "idIdiomas", "idNivel" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 1, 3, 3 },
                    { 2, 2, 1 },
                    { 2, 5, 5 },
                    { 3, 1, 3 },
                    { 3, 4, 2 },
                    { 4, 2, 4 },
                    { 4, 3, 1 },
                    { 5, 1, 4 },
                    { 5, 5, 5 },
                    { 6, 3, 2 },
                    { 6, 4, 1 },
                    { 7, 1, 3 },
                    { 7, 2, 5 },
                    { 8, 4, 4 },
                    { 8, 5, 1 },
                    { 9, 2, 2 },
                    { 9, 3, 5 },
                    { 10, 1, 3 },
                    { 10, 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "EnderecoEmpresa",
                columns: new[] { "idEmpresa", "bairro", "cep", "cidade", "complemento", "endereco", "logradouro", "numero", "uf" },
                values: new object[,]
                {
                    { 1, "Vila Ouro Verde", "19816070", "Assis", "2 Andar", "José Antônio Ferreira", "Rua", 970, "SP" },
                    { 2, "Aliança", "09403120", "Ribeirão Pires", null, "Alvorada", "Rua", 613, "SP" },
                    { 3, "Jardim Cerqueira Leite", "09390300", "Mauá", null, "João Gianoni", "Rua", 367, "SP" },
                    { 4, "Parque Residencial Nova Canaã", "13848632", "Mogi Guaçu", "3 andar", "Yumiko Matsuda Kurimoto", "Rua", 695, "SP" },
                    { 5, "Barreirinha", "82700250", "Curitiba", null, "Jean Jacques Rousseau", "Rua", 1132, "PR" },
                    { 6, "Alto de São Manoel", "59628150", "Mossoró", "1 Andar", "Nono Rosado", "Rua", 343, "RN" },
                    { 7, "Pajuçara", "59133080", "Natal", null, "da Agulha", "Rua", 864, "RN" },
                    { 8, "São Conrado", "49043040", "Aracaju", null, "General João Augusto dos Reis", "Rua", 185, "SE" },
                    { 9, "Base", "69900007", "Rio Branco", "2 Andar", "Feijó", "Travessa", 2382, "AC" },
                    { 10, "Centro", "39385971", "Vista Alegre", null, "Tiradentes", "Praça", 13, "MG" }
                });

            migrationBuilder.InsertData(
                table: "FormacaoAcademica",
                columns: new[] { "idCurriculo", "idFormacaoAcademica", "dfCurso", "diCurso", "idCursos" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2007, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 2, new DateTime(2029, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, 3, new DateTime(2013, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, 4, new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, 5, new DateTime(2019, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 6, 6, new DateTime(2020, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 7, 7, new DateTime(2024, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 8, 8, new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 9, 9, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 10, 10, new DateTime(2024, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 }
                });

            migrationBuilder.InsertData(
                table: "Vagas",
                columns: new[] { "idVagas", "cargaHoraria", "cargo", "descricao", "finalVigencia", "idEmpresa", "idEscolaridade", "idSituacaoVaga", "inicioVigencia", "localidade", "percAderencia", "salario", "tempoSemanal" },
                values: new object[,]
                {
                    { 1, (short)40, "Desenvolvedor Web", "Descrição da vaga 1", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cidade A", 75f, 5000f, "Segunda a Sexta - 9h às 18h" },
                    { 2, (short)35, "Analista de Marketing", "Descrição da vaga 2", new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 2, new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cidade B", 25f, 4500f, "Segunda a Sexta - 10h às 19h" },
                    { 3, (short)45, "Engenheiro Civil", "Descrição da vaga 3", new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, 1, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cidade C", 50f, 6000f, "Segunda a Sexta - 8h às 17h" },
                    { 4, (short)38, "Contador", "Descrição da vaga 4", new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, 3, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cidade D", 33f, 5500f, "Segunda a Sexta - 9h às 18h" },
                    { 5, (short)37, "Enfermeiro", "Descrição da vaga 5", new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5, 1, new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cidade E", 75f, 5200f, "Segunda a Sexta - 8h às 17h" },
                    { 6, (short)30, "Designer Gráfico", "Descrição da vaga 6", new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1, 2, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cidade F", 50f, 4800f, "Segunda a Sexta - 10h às 19h" },
                    { 7, (short)32, "Psicólogo", "Descrição da vaga 7", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2, 3, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cidade G", 25f, 5200f, "Segunda a Sexta - 9h às 18h" },
                    { 8, (short)42, "Advogado", "Descrição da vaga 8", new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3, 1, new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cidade H", 75f, 5800f, "Segunda a Sexta - 8h às 17h" },
                    { 9, (short)36, "Analista Financeiro", "Descrição da vaga 9", new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 4, 2, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cidade I", 25f, 5400f, "Segunda a Sexta - 9h às 18h" },
                    { 10, (short)44, "Médico", "Descrição da vaga 10", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 5, 3, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cidade J", 25f, 6200f, "Segunda a Sexta - 8h às 17h" },
                    { 11, (short)39, "Analista de Sistemas", "Descrição da vaga 11", new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1, new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cidade A", 33f, 5400f, "Segunda a Sexta - 9h às 18h" },
                    { 12, (short)31, "Recrutador", "Descrição da vaga 12", new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 2, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cidade B", 50f, 4800f, "Segunda a Sexta - 10h às 19h" },
                    { 13, (short)47, "Arquiteto", "Descrição da vaga 13", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, 1, new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cidade C", 75f, 6000f, "Segunda a Sexta - 8h às 17h" },
                    { 14, (short)40, "Analista Contábil", "Descrição da vaga 14", new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, 3, new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cidade D", 50f, 5500f, "Segunda a Sexta - 9h às 18h" },
                    { 15, (short)37, "Enfermeira Pediátrica", "Descrição da vaga 15", new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5, 1, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cidade E", 25f, 5200f, "Segunda a Sexta - 8h às 17h" }
                });

            migrationBuilder.InsertData(
                table: "BeneficioVagas",
                columns: new[] { "idBeneficio", "idVagas" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 7, 1 },
                    { 8, 2 },
                    { 9, 2 },
                    { 2, 3 },
                    { 10, 3 },
                    { 2, 4 },
                    { 5, 4 },
                    { 10, 5 },
                    { 15, 5 },
                    { 6, 6 },
                    { 12, 6 },
                    { 8, 7 },
                    { 15, 7 },
                    { 1, 8 },
                    { 3, 8 },
                    { 4, 9 },
                    { 9, 9 },
                    { 6, 10 },
                    { 11, 10 },
                    { 5, 11 },
                    { 11, 11 },
                    { 7, 12 },
                    { 12, 12 },
                    { 3, 13 },
                    { 4, 13 },
                    { 13, 14 },
                    { 14, 14 },
                    { 1, 15 },
                    { 13, 15 }
                });

            migrationBuilder.InsertData(
                table: "VagasConhecimentos",
                columns: new[] { "idConhecimentos", "idVagas", "idNivel" },
                values: new object[,]
                {
                    { 2, 1, 3 },
                    { 3, 1, 1 },
                    { 4, 2, 2 },
                    { 5, 2, 3 },
                    { 6, 3, 1 },
                    { 7, 3, 2 },
                    { 8, 4, 3 },
                    { 9, 4, 3 },
                    { 10, 5, 1 },
                    { 11, 5, 2 },
                    { 12, 6, 3 },
                    { 13, 6, 3 },
                    { 14, 7, 1 },
                    { 15, 7, 2 },
                    { 1, 8, 3 },
                    { 2, 8, 1 },
                    { 3, 9, 2 },
                    { 4, 9, 3 },
                    { 5, 10, 4 },
                    { 6, 10, 5 },
                    { 7, 11, 1 },
                    { 8, 11, 2 },
                    { 9, 12, 3 },
                    { 10, 12, 4 },
                    { 11, 13, 5 },
                    { 12, 13, 1 },
                    { 13, 14, 2 },
                    { 14, 14, 3 },
                    { 1, 15, 5 },
                    { 15, 15, 4 }
                });

            migrationBuilder.InsertData(
                table: "VagasIdiomas",
                columns: new[] { "idIdiomas", "idVagas", "idNivel" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 1, 3 },
                    { 3, 2, 1 },
                    { 4, 2, 2 },
                    { 5, 3, 3 },
                    { 6, 3, 1 },
                    { 7, 4, 2 },
                    { 8, 4, 3 },
                    { 9, 5, 1 },
                    { 10, 5, 2 },
                    { 11, 6, 3 },
                    { 12, 6, 1 },
                    { 13, 7, 2 },
                    { 14, 7, 3 },
                    { 1, 8, 4 },
                    { 15, 8, 1 },
                    { 2, 9, 5 },
                    { 3, 9, 1 },
                    { 4, 10, 2 },
                    { 5, 10, 3 },
                    { 6, 11, 4 },
                    { 7, 11, 5 },
                    { 8, 12, 1 },
                    { 9, 12, 2 },
                    { 10, 13, 3 },
                    { 11, 13, 4 },
                    { 12, 14, 5 },
                    { 13, 14, 1 },
                    { 14, 15, 2 },
                    { 15, 15, 3 }
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

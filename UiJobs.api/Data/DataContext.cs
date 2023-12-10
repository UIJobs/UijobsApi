using Microsoft.EntityFrameworkCore;
using UIJobsAPI.Models;

namespace UIJobsAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Escolaridade> Escolaridade { get; set; }
        public DbSet<Conhecimento> Conhecimentos { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<Nivel> Nivel { get; set; }
        public DbSet<Porte> Portes { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<EnderecoEmpresa> EnderecoEmpresa { get; set; }
        public DbSet<Beneficio> Beneficio { get; set; }
        public DbSet<SituacaoVaga> SituacaoVaga { get; set; }
        public DbSet<Vaga> Vagas { get; set; }
        public DbSet<BeneficioVaga> BeneficioVagas { get; set; }
        public DbSet<VagaConhecimento> VagasConhecimentos { get; set; }
        public DbSet<VagaIdioma> VagasIdiomas { get; set; }
        public DbSet<Candidato> Candidato { get; set; }
        public DbSet<Curriculo> Curriculo { get; set; }
        public DbSet<VagaCandidato> VagasCandidato { get; set; }
        public DbSet<CarreiraProfissional> CarreiraProfissional { get; set; }
        public DbSet<CurriculoConhecimento> CurriculoConhecimentos { get; set; }
        public DbSet<CurriculoIdioma> CurriculoIdiomas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<EnderecoCandidato> EnderecoCandidato { get; set; }
        public DbSet<FormacaoAcademica> FormacaoAcademica { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
---------------------------------------------------------------------------------------------------------------------------------------------------
                                    Insert de "Enuns"
---------------------------------------------------------------------------------------------------------------------------------------------------
*/

            modelBuilder.Entity<Escolaridade>().HasData
            (
                new Escolaridade() {idEscolaridade = 1, nomeEscolaridade = "Ensino Médio"},
                new Escolaridade() {idEscolaridade = 2, nomeEscolaridade = "Ensino Médio Prof"},
                new Escolaridade() {idEscolaridade = 3, nomeEscolaridade = "Técnico"},
                new Escolaridade() {idEscolaridade = 4, nomeEscolaridade = "Graduação Tecnológica"},
                new Escolaridade() {idEscolaridade = 5, nomeEscolaridade = "Graduação"},
                new Escolaridade() {idEscolaridade = 6, nomeEscolaridade = "Pós Graduação"},
                new Escolaridade() {idEscolaridade = 7, nomeEscolaridade = "Mestrado"},
                new Escolaridade() {idEscolaridade = 8, nomeEscolaridade = "Doutorado"}
            );

            modelBuilder.Entity<Conhecimento>().HasData
            (
                new Conhecimento() {idConhecimentos = 1, nomeConhecimento = "HTML"},
                new Conhecimento() {idConhecimentos = 2, nomeConhecimento = "CSS"},
                new Conhecimento() {idConhecimentos = 3, nomeConhecimento = "JavaScript"},
                new Conhecimento() {idConhecimentos = 4, nomeConhecimento = "Java"},
                new Conhecimento() {idConhecimentos = 5, nomeConhecimento = "C#"},
                new Conhecimento() {idConhecimentos = 6, nomeConhecimento = "PHP"},
                new Conhecimento() {idConhecimentos = 7, nomeConhecimento = "SQL"},
                new Conhecimento() {idConhecimentos = 8, nomeConhecimento = "React"},
                new Conhecimento() {idConhecimentos = 9, nomeConhecimento = "Angular"},
                new Conhecimento() {idConhecimentos = 10, nomeConhecimento = "Vue.js"},
                new Conhecimento() {idConhecimentos = 11, nomeConhecimento = "Node.js"},
                new Conhecimento() {idConhecimentos = 12, nomeConhecimento = "Ruby"},
                new Conhecimento() {idConhecimentos = 13, nomeConhecimento = "Swift"},
                new Conhecimento() {idConhecimentos = 14, nomeConhecimento = "C"},
                new Conhecimento() {idConhecimentos = 15, nomeConhecimento = "C++"},
                new Conhecimento() {idConhecimentos = 16, nomeConhecimento = "COBOL"}
            );

            modelBuilder.Entity<Idioma>().HasData
            (
                new Idioma() {idIdiomas = 1, nomeIdioma = "Inglês"},
                new Idioma() {idIdiomas = 2, nomeIdioma = "Espanhol"},
                new Idioma() {idIdiomas = 3, nomeIdioma = "Francês"},
                new Idioma() {idIdiomas = 4, nomeIdioma = "Alemão"},
                new Idioma() {idIdiomas = 5, nomeIdioma = "Italiano"},
                new Idioma() {idIdiomas = 6, nomeIdioma = "Português"},
                new Idioma() {idIdiomas = 7, nomeIdioma = "Japonês"},
                new Idioma() {idIdiomas = 8, nomeIdioma = "Chinês"},
                new Idioma() {idIdiomas = 9, nomeIdioma = "Russo"},
                new Idioma() {idIdiomas = 10, nomeIdioma = "Árabe"},
                new Idioma() {idIdiomas = 11, nomeIdioma = "Corenao"},
                new Idioma() {idIdiomas = 12, nomeIdioma = "Holandês"},
                new Idioma() {idIdiomas = 13, nomeIdioma = "Sueco"},
                new Idioma() {idIdiomas = 14, nomeIdioma = "Dinamarquês"},
                new Idioma() {idIdiomas = 15, nomeIdioma = "Finlandês"}
            );

            modelBuilder.Entity<Nivel>().HasData
            (
                new Nivel() {idNivel = 1, niveisDisponiveis = "Básico"},
                new Nivel() {idNivel = 2, niveisDisponiveis = "Intermediário"},
                new Nivel() {idNivel = 3, niveisDisponiveis = "Avançado"},
                new Nivel() {idNivel = 4, niveisDisponiveis = "Especialista"},
                new Nivel() {idNivel = 5, niveisDisponiveis = "Domínio"}
            );            

            modelBuilder.Entity<Porte>().HasData
            (
                new Porte() {idPortes = 1, tiposPortes = "MicroEmpresa"},
                new Porte() {idPortes = 2, tiposPortes = "Pequena"},
                new Porte() {idPortes = 3, tiposPortes = "Média"},
                new Porte() {idPortes = 4, tiposPortes = "Grande"}
            );

            modelBuilder.Entity<Beneficio>().HasData
            (
                new Beneficio() { idBeneficio = 1, nomeBeneficio = "Assistência Médica" },
                new Beneficio() { idBeneficio = 2, nomeBeneficio = "Assistência Odontológica" },
                new Beneficio() { idBeneficio = 3, nomeBeneficio = "Vale-Refeição" },
                new Beneficio() { idBeneficio = 4, nomeBeneficio = "Vale-Alimentação" },
                new Beneficio() { idBeneficio = 5, nomeBeneficio = "Vale-Transporte" },
                new Beneficio() { idBeneficio = 6, nomeBeneficio = "Auxílio Creche" },
                new Beneficio() { idBeneficio = 7, nomeBeneficio = "Home Office Flexível" },
                new Beneficio() { idBeneficio = 8, nomeBeneficio = "Programa de Desenvolvimento Profissional" },
                new Beneficio() { idBeneficio = 9, nomeBeneficio = "Horário Flexível" },
                new Beneficio() { idBeneficio = 10, nomeBeneficio = "Bônus Anual" },
                new Beneficio() { idBeneficio = 11, nomeBeneficio = "Participação nos Lucros e Resultados (PLR)" },
                new Beneficio() { idBeneficio = 12, nomeBeneficio = "Dias de Férias Adicionais" },
                new Beneficio() { idBeneficio = 13, nomeBeneficio = "Seguro de Vida" },
                new Beneficio() { idBeneficio = 14, nomeBeneficio = "Previdência Privada" },
                new Beneficio() { idBeneficio = 15, nomeBeneficio = "Ginástica Laboral" },
                new Beneficio() { idBeneficio = 16, nomeBeneficio = "Café da Manhã Grátis" },
                new Beneficio() { idBeneficio = 17, nomeBeneficio = "Auxílio-Educação" }
            );

            modelBuilder.Entity<SituacaoVaga>().HasData
            (
                new SituacaoVaga() { idSituacaoVaga = 1, situacaoAtual = "Inciada" },
                new SituacaoVaga() { idSituacaoVaga = 2, situacaoAtual = "Concluída" },
                new SituacaoVaga() { idSituacaoVaga = 3, situacaoAtual = "Suspensa" },
                new SituacaoVaga() { idSituacaoVaga = 4, situacaoAtual = "Cancelada" }
            );
/*
---------------------------------------------------------------------------------------------------------------------------------------------------
                                    Insert de Relacionamento com Candidato & Curriculo
---------------------------------------------------------------------------------------------------------------------------------------------------
*/
            modelBuilder.Entity<Candidato>().HasData
            (
                new Candidato() { idCandidato = 1, nome = "Hugo", email = "hungos0223@gmail.com", nomeMae = "Yasmin Fonseca da Silva", dataNascimento = new DateTime(1995, 3, 22) },
                new Candidato() { idCandidato = 2, nome = "Caio", email = "caio@gmail.com", nomeMae = "Rosana Caetano Romero", dataNascimento = new DateTime(1990, 7, 10) },
                new Candidato() { idCandidato = 3, nome = "Peddro", email = "peddro@gmail.com", nomeMae = "Mariestela Araujo da Silva", dataNascimento = new DateTime(1987, 5, 15) },
                new Candidato() { idCandidato = 4, nome = "Nicole", email = "nicole@gmail.com", nomeMae = "Giovanna Nascimento Gomes", dataNascimento = new DateTime(1992, 9, 8) },
                new Candidato() { idCandidato = 5, nome = "Geovanna", email = "geovanna@gmail.com", nomeMae = "Islayne Bragança Ervano", dataNascimento = new DateTime(1988, 11, 30) },
                new Candidato() { idCandidato = 6, nome = "Yago", email = "yago@gmail.com", nomeMae = "Agostinha Araujo Rezende", dataNascimento = new DateTime(1991, 4, 5) },
                new Candidato() { idCandidato = 7, nome = "Erika", email = "erika@gmail.com", nomeMae = "Marcy Vabo Silvino", dataNascimento = new DateTime(1985, 8, 17) },
                new Candidato() { idCandidato = 8, nome = "Tarcísio Felizardo Lopez", email = "tarsi@outlook.com", nomeMae = "Cristiane Vidal Felizardo", dataNascimento = new DateTime(1983, 12, 3) },
                new Candidato() { idCandidato = 9, nome = "Isaque Rios Sá", email = "rioslavanda2492@outlook.com", nomeMae = "Neiva Negris Rios", dataNascimento = new DateTime(1982, 6, 20) },
                new Candidato() { idCandidato = 10, nome = "Maycon Camara Leite", email = "maycontwo02@gmail.com", nomeMae = "Emanuelle Theodoro Camara", dataNascimento = new DateTime(1989, 1, 12) }
            );

            modelBuilder.Entity<EnderecoCandidato>().HasData
            (
                new EnderecoCandidato() { idCandidato = 1, cep = "77007116", logradouro = "Rua", endereco = "Alcantara", numero = 354, complemento = null, bairro = "Vila Guilherme", cidade = "São Paulo", uf = "SP" },
                new EnderecoCandidato() { idCandidato = 2, cep = "64601203", logradouro = "Rua", endereco = "Projetada", numero = 28, complemento = "Apt 13 Bloco A", bairro = "Aerolândia", cidade = "Picos", uf = "PI" },
                new EnderecoCandidato() { idCandidato = 3, cep = "49504462", logradouro = "Rua", endereco = "E", numero = 2242, complemento = null, bairro = "Marianga", cidade = "Salvador", uf = "BA" },
                new EnderecoCandidato() { idCandidato = 4, cep = "77020004", logradouro = "Avenida", endereco = "Itau", numero = 34, complemento = null, bairro = "Vila Lobos", cidade = "São Sebastião", uf = "MG" },
                new EnderecoCandidato() { idCandidato = 5, cep = "69911202", logradouro = "Rua", endereco = "Japão Liberdade", numero = 34, complemento = "2 Andar", bairro = "Liberdade", cidade = "São Paulo", uf = "SP" },
                new EnderecoCandidato() { idCandidato = 6, cep = "77804170", logradouro = "Avenida", endereco = "Roraima", numero = 4343, complemento = "5 Andar Bloco C", bairro = "São Joaquin", cidade = "Lima Campos", uf = "RJ" },
                new EnderecoCandidato() { idCandidato = 7, cep = "69908070", logradouro = "Rua", endereco = "José do Rio Preto", numero = 45, complemento = null, bairro = "Santo Antônio", cidade = "Aracaju", uf = "SE" },
                new EnderecoCandidato() { idCandidato = 8, cep = "65140970", logradouro = "Rua", endereco = "Claudio Batista 122", numero = 122, complemento = "5 Andar Bloco C", bairro = "Novo Paraíso", cidade = "Aracaju", uf = "SE" },
                new EnderecoCandidato() { idCandidato = 9, cep = "15047224", logradouro = "Rua", endereco = "Alberto Belintani", numero = 734, complemento = null, bairro = "São Joaquin", cidade = "Lima Campos", uf = "RJ" },
                new EnderecoCandidato() { idCandidato = 10, cep = "97578146", logradouro = "Rua", endereco = "João Flores da Cunha", numero = 666, complemento = null, bairro = "Wilson", cidade = "Santana do Livramento", uf = "RS" }
            );

            modelBuilder.Entity<Curriculo>().HasData
            (
                new Curriculo() { idCurriculo = 1, idEscolaridade = 2, idCandidato = 1, objetivo = "Meu Objetivo é ser o maior fullstack do Brasil e do mundo, estou entrando nessa empresa com conhecimentos técnicos para atingir meu objetivo", dcCurriculo = new DateTime(2022, 8, 25), duCurriculo = new DateTime(2023, 1, 14) },
                new Curriculo() { idCurriculo = 2, idEscolaridade = 2, idCandidato = 2, objetivo = "Estou em busca de um emprego para desenvolver minhas habilidades em JAVA", dcCurriculo = new DateTime(2022, 12, 27), duCurriculo = new DateTime(2023, 6, 27) },
                new Curriculo() { idCurriculo = 3, idEscolaridade = 2, idCandidato = 3, objetivo = "Só alcança quem começa", dcCurriculo = new DateTime(2014, 6, 22), duCurriculo = new DateTime(2023, 9, 12) },
                new Curriculo() { idCurriculo = 4, idEscolaridade = 2, idCandidato = 4, objetivo = "O dinheiro não é o problema, a falta de ideias criativas para ganhá-lo que é", dcCurriculo = new DateTime(2012, 2, 28), duCurriculo = new DateTime(2022, 11, 2) },
                new Curriculo() { idCurriculo = 5, idEscolaridade = 2, idCandidato = 5, objetivo = "Até agora, tenho estado a evitar a sua inevitabilidade.", dcCurriculo = new DateTime(2015, 5, 23), duCurriculo = new DateTime(2023, 8, 27) },
                new Curriculo() { idCurriculo = 6, idEscolaridade = 2, idCandidato = 6, objetivo = "É possível, mas achamos bastante duvidoso.", dcCurriculo = new DateTime(2020, 4, 17), duCurriculo = new DateTime(2022, 12, 22) },
                new Curriculo() { idCurriculo = 7, idEscolaridade = 2, idCandidato = 7, objetivo = "As pessoas devem olhar para mim para a consistência e perseverança.", dcCurriculo = new DateTime(2021, 10, 12), duCurriculo = new DateTime(2021, 10, 12) },
                new Curriculo() { idCurriculo = 8, idEscolaridade = 2, idCandidato = 10, objetivo = "As pessoas devem olhar para mim para a consistência e perseverança.", dcCurriculo = new DateTime(2021, 10, 12), duCurriculo = new DateTime(2021, 10, 12) },
                new Curriculo() { idCurriculo = 9, idEscolaridade = 2, idCandidato = 9, objetivo = "As pessoas devem olhar para mim para a consistência e perseverança.", dcCurriculo = new DateTime(2021, 10, 12), duCurriculo = new DateTime(2021, 10, 12) },
                new Curriculo() { idCurriculo = 10, idEscolaridade = 2, idCandidato = 8, objetivo = "O número de combinações possíveis e consequentes utilizações parece ilimitado.", dcCurriculo = new DateTime(2009, 7, 30), duCurriculo = new DateTime(2023, 6, 17) }
            );


            modelBuilder.Entity<FormacaoAcademica>().HasData
            (
                new FormacaoAcademica() { idFormacaoAcademica = 1, idCurriculo = 1, idCursos = 1, diCurso = new DateTime(2005, 8, 2), dfCurso = new DateTime(2007, 11, 28) },
                new FormacaoAcademica() { idFormacaoAcademica = 2, idCurriculo = 2, idCursos = 2, diCurso = new DateTime(2017, 5, 2), dfCurso = new DateTime(2029, 5, 8) },
                new FormacaoAcademica() { idFormacaoAcademica = 3, idCurriculo = 3, idCursos = 3, diCurso = new DateTime(2008, 2, 12), dfCurso = new DateTime(2013, 5, 23) },
                new FormacaoAcademica() { idFormacaoAcademica = 4, idCurriculo = 4, idCursos = 4, diCurso = new DateTime(2020, 1, 28), dfCurso = new DateTime(2022, 12, 2) },
                new FormacaoAcademica() { idFormacaoAcademica = 5, idCurriculo = 5, idCursos = 5, diCurso = new DateTime(2017, 6, 5), dfCurso = new DateTime(2019, 5, 24) },
                new FormacaoAcademica() { idFormacaoAcademica = 6, idCurriculo = 6, idCursos = 6, diCurso = new DateTime(2020, 3, 23), dfCurso = new DateTime(2020, 9, 12) },
                new FormacaoAcademica() { idFormacaoAcademica = 7, idCurriculo = 7, idCursos = 7, diCurso = new DateTime(2023, 6, 23), dfCurso = new DateTime(2024, 11, 22) },
                new FormacaoAcademica() { idFormacaoAcademica = 8, idCurriculo = 8, idCursos = 8, diCurso = new DateTime(2022, 2, 28), dfCurso = new DateTime(2023, 10, 20) },
                new FormacaoAcademica() { idFormacaoAcademica = 9, idCurriculo = 9, idCursos = 9, diCurso = new DateTime(2019, 7, 20), dfCurso = new DateTime(2021, 3, 17) },
                new FormacaoAcademica() { idFormacaoAcademica = 10, idCurriculo = 10, idCursos = 10, diCurso = new DateTime(2023, 3, 18), dfCurso = new DateTime(2024, 11, 22) }
            );

            modelBuilder.Entity<Curso>().HasData
            (
                new Curso() { idCursos = 1, nomeCurso = "Ciências da Computação", DiplomaCurso = "S" },
                new Curso() { idCursos = 2, nomeCurso = "Redes e Segurança", DiplomaCurso = "S" },
                new Curso() { idCursos = 3, nomeCurso = "Banco de Dados", DiplomaCurso = "S" },
                new Curso() { idCursos = 4, nomeCurso = "Excel", DiplomaCurso = "N" },
                new Curso() { idCursos = 5, nomeCurso = "Office", DiplomaCurso = "N" },
                new Curso() { idCursos = 6, nomeCurso = "Aprender Python", DiplomaCurso = "S" },
                new Curso() { idCursos = 7, nomeCurso = "Marketing Digital", DiplomaCurso = "N" },
                new Curso() { idCursos = 8, nomeCurso = "InfraEstrutura", DiplomaCurso = "S" },
                new Curso() { idCursos = 9, nomeCurso = "World", DiplomaCurso = "S" },
                new Curso() { idCursos = 10, nomeCurso = "PowerPoint", DiplomaCurso = "S" }
            );

            

            modelBuilder.Entity<CarreiraProfissional>().HasData
            (
                new CarreiraProfissional() { sqCarreiraProfissional = 1, idCurriculo = 1, nomeEmpresa = "Bradesco", tempoInicio = new DateTime(2017, 9, 2), tempoFim = new DateTime(2022, 5, 12), cargo = "Gerente" },
                new CarreiraProfissional() { sqCarreiraProfissional = 2, idCurriculo = 2, nomeEmpresa = "Ubisoft", tempoInicio = new DateTime(2018, 10, 15), tempoFim = new DateTime(2023, 6, 25), cargo = "Desenvolvedor" },
                new CarreiraProfissional() { sqCarreiraProfissional = 3, idCurriculo = 3, nomeEmpresa = "Oracle", tempoInicio = new DateTime(2016, 3, 10), tempoFim = new DateTime(2020, 12, 18), cargo = "Analista de Banco de Dados" },
                new CarreiraProfissional() { sqCarreiraProfissional = 4, idCurriculo = 4, nomeEmpresa = "Google", tempoInicio = new DateTime(2019, 7, 5), tempoFim = new DateTime(2021, 11, 30), cargo = "Engenheiro de Software" },
                new CarreiraProfissional() { sqCarreiraProfissional = 5, idCurriculo = 5, nomeEmpresa = "Amazon", tempoInicio = new DateTime(2015, 12, 1), tempoFim = new DateTime(2018, 9, 12), cargo = "Arquiteto de Soluções" },
                new CarreiraProfissional() { sqCarreiraProfissional = 6, idCurriculo = 6, nomeEmpresa = "Microsoft", tempoInicio = new DateTime(2020, 1, 15), tempoFim = new DateTime(2022, 7, 30), cargo = "Especialista em Cloud Computing" },
                new CarreiraProfissional() { sqCarreiraProfissional = 7, idCurriculo = 7, nomeEmpresa = "ChibiliKid", tempoInicio = new DateTime(2018, 6, 8), tempoFim = new DateTime(2021, 4, 5), cargo = "Designer de Jogos" },
                new CarreiraProfissional() { sqCarreiraProfissional = 8, idCurriculo = 8, nomeEmpresa = "Bradesco", tempoInicio = new DateTime(2017, 9, 2), tempoFim = new DateTime(2022, 5, 12), cargo = "Gerente de Projetos" },
                new CarreiraProfissional() { sqCarreiraProfissional = 9, idCurriculo = 9, nomeEmpresa = "Tech Innovations", tempoInicio = new DateTime(2019, 3, 20), tempoFim = new DateTime(2022, 11, 15), cargo = "Especialista em Inovação Tecnológica" },
                new CarreiraProfissional() { sqCarreiraProfissional = 10, idCurriculo = 10, nomeEmpresa = "FutureTech", tempoInicio = new DateTime(2016, 8, 10), tempoFim = new DateTime(2020, 6, 22), cargo = "Analista de Sistemas" }
            );

            modelBuilder.Entity<CurriculoIdioma>().HasData
            (
                new CurriculoIdioma() { idCurriculo = 1, idIdiomas = 1, idNivel = 2 },
                new CurriculoIdioma() { idCurriculo = 1, idIdiomas = 3, idNivel = 3 },
                new CurriculoIdioma() { idCurriculo = 2, idIdiomas = 2, idNivel = 1 },
                new CurriculoIdioma() { idCurriculo = 2, idIdiomas = 5, idNivel = 5 },
                new CurriculoIdioma() { idCurriculo = 3, idIdiomas = 4, idNivel = 2 },
                new CurriculoIdioma() { idCurriculo = 3, idIdiomas = 1, idNivel = 3 },
                new CurriculoIdioma() { idCurriculo = 4, idIdiomas = 3, idNivel = 1 },
                new CurriculoIdioma() { idCurriculo = 4, idIdiomas = 2, idNivel = 4 },
                new CurriculoIdioma() { idCurriculo = 5, idIdiomas = 1, idNivel = 4 },
                new CurriculoIdioma() { idCurriculo = 5, idIdiomas = 5, idNivel = 5 },
                new CurriculoIdioma() { idCurriculo = 6, idIdiomas = 4, idNivel = 1 },
                new CurriculoIdioma() { idCurriculo = 6, idIdiomas = 3, idNivel = 2 },
                new CurriculoIdioma() { idCurriculo = 7, idIdiomas = 2, idNivel = 5 },
                new CurriculoIdioma() { idCurriculo = 7, idIdiomas = 1, idNivel = 3 },
                new CurriculoIdioma() { idCurriculo = 8, idIdiomas = 5, idNivel = 1 },
                new CurriculoIdioma() { idCurriculo = 8, idIdiomas = 4, idNivel = 4 },
                new CurriculoIdioma() { idCurriculo = 9, idIdiomas = 3, idNivel = 5 },
                new CurriculoIdioma() { idCurriculo = 9, idIdiomas = 2, idNivel = 2 },
                new CurriculoIdioma() { idCurriculo = 10, idIdiomas = 1, idNivel = 3 },
                new CurriculoIdioma() { idCurriculo = 10, idIdiomas = 4, idNivel = 1 }
            );

            modelBuilder.Entity<CurriculoConhecimento>().HasData(
                new CurriculoConhecimento() { idCurriculo = 1, idConhecimentos = 1, idNivel = 2 },
                new CurriculoConhecimento() { idCurriculo = 1, idConhecimentos = 2, idNivel = 3 },
                new CurriculoConhecimento() { idCurriculo = 2, idConhecimentos = 3, idNivel = 1 },
                new CurriculoConhecimento() { idCurriculo = 2, idConhecimentos = 4, idNivel = 2 },
                new CurriculoConhecimento() { idCurriculo = 3, idConhecimentos = 5, idNivel = 3 },
                new CurriculoConhecimento() { idCurriculo = 3, idConhecimentos = 6, idNivel = 1 },
                new CurriculoConhecimento() { idCurriculo = 4, idConhecimentos = 7, idNivel = 2 },
                new CurriculoConhecimento() { idCurriculo = 4, idConhecimentos = 8, idNivel = 3 },
                new CurriculoConhecimento() { idCurriculo = 5, idConhecimentos = 9, idNivel = 3 },
                new CurriculoConhecimento() { idCurriculo = 5, idConhecimentos = 10, idNivel = 1 },
                new CurriculoConhecimento() { idCurriculo = 6, idConhecimentos = 11, idNivel = 2 },
                new CurriculoConhecimento() { idCurriculo = 6, idConhecimentos = 12, idNivel = 3 },
                new CurriculoConhecimento() { idCurriculo = 7, idConhecimentos = 13, idNivel = 3 },
                new CurriculoConhecimento() { idCurriculo = 7, idConhecimentos = 14, idNivel = 1 },
                new CurriculoConhecimento() { idCurriculo = 8, idConhecimentos = 15, idNivel = 2 },
                new CurriculoConhecimento() { idCurriculo = 8, idConhecimentos = 12, idNivel = 3 },
                new CurriculoConhecimento() { idCurriculo = 9, idConhecimentos = 13, idNivel = 3 },
                new CurriculoConhecimento() { idCurriculo = 9, idConhecimentos = 14, idNivel = 1 },
                new CurriculoConhecimento() { idCurriculo = 10, idConhecimentos = 15, idNivel = 2 },
                new CurriculoConhecimento() { idCurriculo = 10, idConhecimentos = 12, idNivel = 3 }
            );
/*
---------------------------------------------------------------------------------------------------------------------------------------------------
                                    Insert de Relacionamento com Empresa & Vagas
---------------------------------------------------------------------------------------------------------------------------------------------------
*/

            modelBuilder.Entity<Empresa>().HasData
            (
                new Empresa() { idEmpresa = 1, idPortes = 2, cnpj = "11.722.246/0001-93", email = "suportes@testes.com", razaoSocial = "Ficticios para Testes SA", nomeFantasia = "Teste" },
                new Empresa() { idEmpresa = 2, idPortes = 1, cnpj = "07.476.034/0001-04", email = "edson@marciolimpeza.com", razaoSocial = "Edson e Márcio Limpeza Ltda", nomeFantasia = "Edcios Limpezas" },
                new Empresa() { idEmpresa = 3, idPortes = 2, cnpj = "78.311.160/0001-49", email = "clara@otavioassessoria.com", razaoSocial = "Clara e Otávio Assessoria Jurídica ME", nomeFantasia = "Acessoria Jurídica do Salvador" },
                new Empresa() { idEmpresa = 4, idPortes = 3, cnpj = "66.267.347/0001-03", email = "daiane@pedrocontabil.com", razaoSocial = "Daiane e Pedro Contábil Ltda", nomeFantasia = "Remus Contabil" },
                new Empresa() { idEmpresa = 5, idPortes = 1, cnpj = "55.116.850/0001-41", email = "malu@renancasanoturna.com", razaoSocial = "Malu e Renan Casa Noturna Ltda", nomeFantasia = "The Noitada Malunan" },
                new Empresa() { idEmpresa = 6, idPortes = 3, cnpj = "87.356.417/0001-70", email = "elias@mateusinformatica.com", razaoSocial = "Elias e Mateus Informática Ltda", nomeFantasia = "Eltias Tech" },
                new Empresa() { idEmpresa = 7, idPortes = 3, cnpj = "07.139.029/0001-06", email = "lorenzo@rafaelafotografias.com", razaoSocial = "Lorenzo e Rafaela Fotografias Ltda", nomeFantasia = "Photorela" },
                new Empresa() { idEmpresa = 8, idPortes = 2, cnpj = "89.150.471/0001-90", email = "manoel@alanaautomoveis.com", razaoSocial = "Manoel e Alana Locações de Automóveis Ltda", nomeFantasia = "Manoel Automóveis" },
                new Empresa() { idEmpresa = 9, idPortes = 2, cnpj = "21.799.677/0001-01", email = "benjamin@isabelfinanceira.com", razaoSocial = "Benjamin e Isabel Consultoria Financeira ME", nomeFantasia = "Benj&Isa Finaceiros" },
                new Empresa() { idEmpresa = 10, idPortes = 4, cnpj = "53.034.779/0001-22", email = "emily@giovannaautomoveis.com", razaoSocial = "Emily e Giovanna Locações de Automóveis ME", nomeFantasia = "Metrono Auto" }
            );

            modelBuilder.Entity<EnderecoEmpresa>().HasData
            (
                new EnderecoEmpresa() { idEmpresa = 1, cep = "19816070", logradouro = "Rua", endereco = "José Antônio Ferreira", numero = 970, complemento = "2 Andar", bairro = "Vila Ouro Verde", cidade = "Assis", uf = "SP" },
                new EnderecoEmpresa() { idEmpresa = 2, cep = "09403120", logradouro = "Rua", endereco = "Alvorada", numero = 613, complemento = null, bairro = "Aliança", cidade = "Ribeirão Pires", uf = "SP" },
                new EnderecoEmpresa() { idEmpresa = 3, cep = "09390300", logradouro = "Rua", endereco = "João Gianoni", numero = 367, complemento = null, bairro = "Jardim Cerqueira Leite", cidade = "Mauá", uf = "SP" },
                new EnderecoEmpresa() { idEmpresa = 4, cep = "13848632", logradouro = "Rua", endereco = "Yumiko Matsuda Kurimoto", numero = 695, complemento = "3 andar", bairro = "Parque Residencial Nova Canaã", cidade = "Mogi Guaçu", uf = "SP" },
                new EnderecoEmpresa() { idEmpresa = 5, cep = "82700250", logradouro = "Rua", endereco = "Jean Jacques Rousseau", numero = 1132, complemento = null, bairro = "Barreirinha", cidade = "Curitiba", uf = "PR" },
                new EnderecoEmpresa() { idEmpresa = 6, cep = "59628150", logradouro = "Rua", endereco = "Nono Rosado", numero = 343, complemento = "1 Andar", bairro = "Alto de São Manoel", cidade = "Mossoró", uf = "RN" },
                new EnderecoEmpresa() { idEmpresa = 7, cep = "59133080", logradouro = "Rua", endereco = "da Agulha", numero = 864, complemento = null, bairro = "Pajuçara", cidade = "Natal", uf = "RN" },
                new EnderecoEmpresa() { idEmpresa = 8, cep = "49043040", logradouro = "Rua", endereco = "General João Augusto dos Reis", numero = 185, complemento = null, bairro = "São Conrado", cidade = "Aracaju", uf = "SE" },
                new EnderecoEmpresa() { idEmpresa = 9, cep = "69900007", logradouro = "Travessa", endereco = "Feijó", numero = 2382, complemento = "2 Andar", bairro = "Base", cidade = "Rio Branco", uf = "AC" },
                new EnderecoEmpresa() { idEmpresa = 10, cep = "39385971", logradouro = "Praça", endereco = "Tiradentes", numero = 13, complemento = null, bairro = "Centro", cidade = "Vista Alegre", uf = "MG" }
            );

            modelBuilder.Entity<Vaga>().HasData
            (
                new Vaga() { idVagas = 1, idEscolaridade = 1, idSituacaoVaga = 1, idEmpresa = 1, cargo = "Desenvolvedor Web", descricao = "Descrição da vaga 1", inicioVigencia = new DateTime(2023, 9, 5), finalVigencia = new DateTime(2023, 9, 10), salario = 5000, cargaHoraria = 40, localidade = "Cidade A", percAderencia = 75, tempoSemanal = "Segunda a Sexta - 9h às 18h" },
                new Vaga() { idVagas = 2, idEscolaridade = 2, idSituacaoVaga = 2, idEmpresa = 2, cargo = "Analista de Marketing", descricao = "Descrição da vaga 2", inicioVigencia = new DateTime(2023, 9, 6), finalVigencia = new DateTime(2023, 9, 11), salario = 4500, cargaHoraria = 35, localidade = "Cidade B", percAderencia = 25, tempoSemanal = "Segunda a Sexta - 10h às 19h" },
                new Vaga() { idVagas = 3, idEscolaridade = 3, idSituacaoVaga = 1, idEmpresa = 3, cargo = "Engenheiro Civil", descricao = "Descrição da vaga 3", inicioVigencia = new DateTime(2023, 9, 7), finalVigencia = new DateTime(2023, 9, 12), salario = 6000, cargaHoraria = 45, localidade = "Cidade C", percAderencia = 50, tempoSemanal = "Segunda a Sexta - 8h às 17h" },
                new Vaga() { idVagas = 4, idEscolaridade = 4, idSituacaoVaga = 3, idEmpresa = 4, cargo = "Contador", descricao = "Descrição da vaga 4", inicioVigencia = new DateTime(2023, 9, 8), finalVigencia = new DateTime(2023, 9, 13), salario = 5500, cargaHoraria = 38, localidade = "Cidade D", percAderencia = 33, tempoSemanal = "Segunda a Sexta - 9h às 18h" },
                new Vaga() { idVagas = 5, idEscolaridade = 5, idSituacaoVaga = 1, idEmpresa = 5, cargo = "Enfermeiro", descricao = "Descrição da vaga 5", inicioVigencia = new DateTime(2023, 9, 9), finalVigencia = new DateTime(2023, 9, 14), salario = 5200, cargaHoraria = 37, localidade = "Cidade E", percAderencia = 75, tempoSemanal = "Segunda a Sexta - 8h às 17h" },
                new Vaga() { idVagas = 6, idEscolaridade = 1, idSituacaoVaga = 2, idEmpresa = 6, cargo = "Designer Gráfico", descricao = "Descrição da vaga 6", inicioVigencia = new DateTime(2023, 9, 10), finalVigencia = new DateTime(2023, 9, 15), salario = 4800, cargaHoraria = 30, localidade = "Cidade F", percAderencia = 50, tempoSemanal = "Segunda a Sexta - 10h às 19h" },
                new Vaga() { idVagas = 7, idEscolaridade = 2, idSituacaoVaga = 3, idEmpresa = 7, cargo = "Psicólogo", descricao = "Descrição da vaga 7", inicioVigencia = new DateTime(2023, 9, 11), finalVigencia = new DateTime(2023, 9, 16), salario = 5200, cargaHoraria = 32, localidade = "Cidade G", percAderencia = 25, tempoSemanal = "Segunda a Sexta - 9h às 18h" },
                new Vaga() { idVagas = 8, idEscolaridade = 3, idSituacaoVaga = 1, idEmpresa = 8, cargo = "Advogado", descricao = "Descrição da vaga 8", inicioVigencia = new DateTime(2023, 9, 12), finalVigencia = new DateTime(2023, 9, 17), salario = 5800, cargaHoraria = 42, localidade = "Cidade H", percAderencia = 75, tempoSemanal = "Segunda a Sexta - 8h às 17h" },
                new Vaga() { idVagas = 9, idEscolaridade = 4, idSituacaoVaga = 2, idEmpresa = 9, cargo = "Analista Financeiro", descricao = "Descrição da vaga 9", inicioVigencia = new DateTime(2023, 9, 13), finalVigencia = new DateTime(2023, 9, 18), salario = 5400, cargaHoraria = 36, localidade = "Cidade I", percAderencia = 25, tempoSemanal = "Segunda a Sexta - 9h às 18h" },
                new Vaga() { idVagas = 10, idEscolaridade = 5, idSituacaoVaga = 3, idEmpresa = 10, cargo = "Médico", descricao = "Descrição da vaga 10", inicioVigencia = new DateTime(2023, 9, 14), finalVigencia = new DateTime(2023, 9, 19), salario = 6200, cargaHoraria = 44, localidade = "Cidade J", percAderencia = 25, tempoSemanal = "Segunda a Sexta - 8h às 17h" },
                new Vaga() { idVagas = 11, idEscolaridade = 1, idSituacaoVaga = 1, idEmpresa = 1, cargo = "Analista de Sistemas", descricao = "Descrição da vaga 11", inicioVigencia = new DateTime(2023, 9, 15), finalVigencia = new DateTime(2023, 9, 20), salario = 5400, cargaHoraria = 39, localidade = "Cidade A", percAderencia = 33, tempoSemanal = "Segunda a Sexta - 9h às 18h" },
                new Vaga() { idVagas = 12, idEscolaridade = 2, idSituacaoVaga = 2, idEmpresa = 2, cargo = "Recrutador", descricao = "Descrição da vaga 12", inicioVigencia = new DateTime(2023, 9, 16), finalVigencia = new DateTime(2023, 9, 21), salario = 4800, cargaHoraria = 31, localidade = "Cidade B", percAderencia = 50, tempoSemanal = "Segunda a Sexta - 10h às 19h" },
                new Vaga() { idVagas = 13, idEscolaridade = 3, idSituacaoVaga = 1, idEmpresa = 3, cargo = "Arquiteto", descricao = "Descrição da vaga 13", inicioVigencia = new DateTime(2023, 9, 17), finalVigencia = new DateTime(2023, 9, 22), salario = 6000, cargaHoraria = 47, localidade = "Cidade C", percAderencia = 75, tempoSemanal = "Segunda a Sexta - 8h às 17h" },
                new Vaga() { idVagas = 14, idEscolaridade = 4, idSituacaoVaga = 3, idEmpresa = 4, cargo = "Analista Contábil", descricao = "Descrição da vaga 14", inicioVigencia = new DateTime(2023, 9, 18), finalVigencia = new DateTime(2023, 9, 23), salario = 5500, cargaHoraria = 40, localidade = "Cidade D", percAderencia = 50, tempoSemanal = "Segunda a Sexta - 9h às 18h" },
                new Vaga() { idVagas = 15, idEscolaridade = 5, idSituacaoVaga = 1, idEmpresa = 5, cargo = "Enfermeira Pediátrica", descricao = "Descrição da vaga 15", inicioVigencia = new DateTime(2023, 9, 19), finalVigencia = new DateTime(2023, 9, 24), salario = 5200, cargaHoraria = 37, localidade = "Cidade E", percAderencia = 25, tempoSemanal = "Segunda a Sexta - 8h às 17h" }
            );

            modelBuilder.Entity<BeneficioVaga>().HasData
            (
                new BeneficioVaga() { idVagas = 1, idBeneficio = 3 },
                new BeneficioVaga() { idVagas = 1, idBeneficio = 7 },
                new BeneficioVaga() { idVagas = 2, idBeneficio = 8 },
                new BeneficioVaga() { idVagas = 2, idBeneficio = 9 },
                new BeneficioVaga() { idVagas = 3, idBeneficio = 2 },
                new BeneficioVaga() { idVagas = 3, idBeneficio = 10 },
                new BeneficioVaga() { idVagas = 4, idBeneficio = 5 },
                new BeneficioVaga() { idVagas = 4, idBeneficio = 2 },
                new BeneficioVaga() { idVagas = 5, idBeneficio = 10 },
                new BeneficioVaga() { idVagas = 5, idBeneficio = 15 },
                new BeneficioVaga() { idVagas = 6, idBeneficio = 12 },
                new BeneficioVaga() { idVagas = 6, idBeneficio = 6 },
                new BeneficioVaga() { idVagas = 7, idBeneficio = 15 },
                new BeneficioVaga() { idVagas = 7, idBeneficio = 8 },
                new BeneficioVaga() { idVagas = 8, idBeneficio = 3 },
                new BeneficioVaga() { idVagas = 8, idBeneficio = 1 },
                new BeneficioVaga() { idVagas = 9, idBeneficio = 9 },
                new BeneficioVaga() { idVagas = 9, idBeneficio = 4 },
                new BeneficioVaga() { idVagas = 10, idBeneficio = 6 },
                new BeneficioVaga() { idVagas = 10, idBeneficio = 11 },
                new BeneficioVaga() { idVagas = 11, idBeneficio = 11 },
                new BeneficioVaga() { idVagas = 11, idBeneficio = 5 },
                new BeneficioVaga() { idVagas = 12, idBeneficio = 7 },
                new BeneficioVaga() { idVagas = 12, idBeneficio = 12 },
                new BeneficioVaga() { idVagas = 13, idBeneficio = 4 },
                new BeneficioVaga() { idVagas = 13, idBeneficio = 3 },
                new BeneficioVaga() { idVagas = 14, idBeneficio = 13 },
                new BeneficioVaga() { idVagas = 14, idBeneficio = 14 },
                new BeneficioVaga() { idVagas = 15, idBeneficio = 1 },
                new BeneficioVaga() { idVagas = 15, idBeneficio = 13 }
            );

            modelBuilder.Entity<VagaConhecimento>().HasData
            (
                new VagaConhecimento() { idVagas = 1, idConhecimentos = 2, idNivel = 3 },
                new VagaConhecimento() { idVagas = 1, idConhecimentos = 3, idNivel = 1 },
                new VagaConhecimento() { idVagas = 2, idConhecimentos = 4, idNivel = 2 },
                new VagaConhecimento() { idVagas = 2, idConhecimentos = 5, idNivel = 3 },
                new VagaConhecimento() { idVagas = 3, idConhecimentos = 6, idNivel = 1 },
                new VagaConhecimento() { idVagas = 3, idConhecimentos = 7, idNivel = 2 },
                new VagaConhecimento() { idVagas = 4, idConhecimentos = 8, idNivel = 3 },
                new VagaConhecimento() { idVagas = 4, idConhecimentos = 9, idNivel = 3 },
                new VagaConhecimento() { idVagas = 5, idConhecimentos = 10, idNivel = 1 },
                new VagaConhecimento() { idVagas = 5, idConhecimentos = 11, idNivel = 2 },
                new VagaConhecimento() { idVagas = 6, idConhecimentos = 12, idNivel = 3 },
                new VagaConhecimento() { idVagas = 6, idConhecimentos = 13, idNivel = 3 },
                new VagaConhecimento() { idVagas = 7, idConhecimentos = 14, idNivel = 1 },
                new VagaConhecimento() { idVagas = 7, idConhecimentos = 15, idNivel = 2 },
                new VagaConhecimento() { idVagas = 8, idConhecimentos = 1, idNivel = 3 },
                new VagaConhecimento() { idVagas = 8, idConhecimentos = 2, idNivel = 1 },
                new VagaConhecimento() { idVagas = 9, idConhecimentos = 3, idNivel = 2 },
                new VagaConhecimento() { idVagas = 9, idConhecimentos = 4, idNivel = 3 },
                new VagaConhecimento() { idVagas = 10, idConhecimentos = 5, idNivel = 4 },
                new VagaConhecimento() { idVagas = 10, idConhecimentos = 6, idNivel = 5 },
                new VagaConhecimento() { idVagas = 11, idConhecimentos = 7, idNivel = 1 },
                new VagaConhecimento() { idVagas = 11, idConhecimentos = 8, idNivel = 2 },
                new VagaConhecimento() { idVagas = 12, idConhecimentos = 9, idNivel = 3 },
                new VagaConhecimento() { idVagas = 12, idConhecimentos = 10, idNivel = 4 },
                new VagaConhecimento() { idVagas = 13, idConhecimentos = 11, idNivel = 5 },
                new VagaConhecimento() { idVagas = 13, idConhecimentos = 12, idNivel = 1 },
                new VagaConhecimento() { idVagas = 14, idConhecimentos = 13, idNivel = 2 },
                new VagaConhecimento() { idVagas = 14, idConhecimentos = 14, idNivel = 3 },
                new VagaConhecimento() { idVagas = 15, idConhecimentos = 15, idNivel = 4 },
                new VagaConhecimento() { idVagas = 15, idConhecimentos = 1, idNivel = 5 }
            );

            modelBuilder.Entity<VagaIdioma>().HasData
            (
                new VagaIdioma() { idVagas = 1, idIdiomas = 1, idNivel = 2 },
                new VagaIdioma() { idVagas = 1, idIdiomas = 2, idNivel = 3 },
                new VagaIdioma() { idVagas = 2, idIdiomas = 3, idNivel = 1 },
                new VagaIdioma() { idVagas = 2, idIdiomas = 4, idNivel = 2 },
                new VagaIdioma() { idVagas = 3, idIdiomas = 5, idNivel = 3 },
                new VagaIdioma() { idVagas = 3, idIdiomas = 6, idNivel = 1 },
                new VagaIdioma() { idVagas = 4, idIdiomas = 7, idNivel = 2 },
                new VagaIdioma() { idVagas = 4, idIdiomas = 8, idNivel = 3 },
                new VagaIdioma() { idVagas = 5, idIdiomas = 9, idNivel = 1 },
                new VagaIdioma() { idVagas = 5, idIdiomas = 10, idNivel = 2 },
                new VagaIdioma() { idVagas = 6, idIdiomas = 11, idNivel = 3 },
                new VagaIdioma() { idVagas = 6, idIdiomas = 12, idNivel = 1 },
                new VagaIdioma() { idVagas = 7, idIdiomas = 13, idNivel = 2 },
                new VagaIdioma() { idVagas = 7, idIdiomas = 14, idNivel = 3 },
                new VagaIdioma() { idVagas = 8, idIdiomas = 15, idNivel = 1 },
                new VagaIdioma() { idVagas = 8, idIdiomas = 1, idNivel = 4 },
                new VagaIdioma() { idVagas = 9, idIdiomas = 2, idNivel = 5 },
                new VagaIdioma() { idVagas = 9, idIdiomas = 3, idNivel = 1 },
                new VagaIdioma() { idVagas = 10, idIdiomas = 4, idNivel = 2 },
                new VagaIdioma() { idVagas = 10, idIdiomas = 5, idNivel = 3 },
                new VagaIdioma() { idVagas = 11, idIdiomas = 6, idNivel = 4 },
                new VagaIdioma() { idVagas = 11, idIdiomas = 7, idNivel = 5 },
                new VagaIdioma() { idVagas = 12, idIdiomas = 8, idNivel = 1 },
                new VagaIdioma() { idVagas = 12, idIdiomas = 9, idNivel = 2 },
                new VagaIdioma() { idVagas = 13, idIdiomas = 10, idNivel = 3 },
                new VagaIdioma() { idVagas = 13, idIdiomas = 11, idNivel = 4 },
                new VagaIdioma() { idVagas = 14, idIdiomas = 12, idNivel = 5 },
                new VagaIdioma() { idVagas = 14, idIdiomas = 13, idNivel = 1 },
                new VagaIdioma() { idVagas = 15, idIdiomas = 14, idNivel = 2 },
                new VagaIdioma() { idVagas = 15, idIdiomas = 15, idNivel = 3 }
            );


/*
---------------------------------------------------------------------------------------------------------------------------------------------------
                                                    Mapeamento
---------------------------------------------------------------------------------------------------------------------------------------------------
*/

            //Mapeamento Escolaridade
            modelBuilder.Entity<Escolaridade>()
                 .HasKey(e => new { e.idEscolaridade });

            //Mapeamento Conhecimento
            modelBuilder.Entity<Conhecimento>()
                .HasKey(c => new { c.idConhecimentos });

            //Mapeamento Idioma
            modelBuilder.Entity<Idioma>()
                .HasKey(i => new { i.idIdiomas });

            //Mapeamento Nivel
            modelBuilder.Entity<Nivel>()
                .HasKey(n => new { n.idNivel });

            //Mapeamento Porte
            modelBuilder.Entity<Porte>()
                .HasKey(p => new { p.idPortes });

            // Mapeamento Empresa
            modelBuilder.Entity<Empresa>()
              .HasKey(e => new { e.idEmpresa });

            modelBuilder.Entity<Empresa>()
                .HasOne(e => e.Porte)
                .WithMany()
                .HasForeignKey(e => e.idPortes)
                .OnDelete(DeleteBehavior.Restrict);

            // Mapeamento EnderecoEmpresa
            modelBuilder.Entity<EnderecoEmpresa>()
               .HasKey(ee => new { ee.idEmpresa });

            modelBuilder.Entity<EnderecoEmpresa>()
                .HasOne(e => e.Empresa)
                .WithMany()
                .HasForeignKey(e => e.idEmpresa)
                .OnDelete(DeleteBehavior.Restrict);

            //Mapeamento Beneficio
            modelBuilder.Entity<Beneficio>()
              .HasKey(b => new { b.idBeneficio });

            //Mapeamento SituacaoVaga
            modelBuilder.Entity<SituacaoVaga>()
                .HasKey(sv => new { sv.idSituacaoVaga });

            // Mapeamento Vaga
            modelBuilder.Entity<Vaga>()
                .HasKey(v => new { v.idVagas });

            modelBuilder.Entity<Vaga>()
                .HasOne(ve => ve.Escolaridade)
                .WithMany()
                .HasForeignKey(e => e.idEscolaridade)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Vaga>()
                .HasOne(vs => vs.SituacaoVaga)
                .WithMany()
                .HasForeignKey(sv => sv.idSituacaoVaga)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Vaga>()
                .HasOne(e => e.Empresa)
                .WithMany()
                .HasForeignKey(e => e.idEmpresa)
                .OnDelete(DeleteBehavior.Restrict);

            // Mapeamento BeneficioVaga
            modelBuilder.Entity<BeneficioVaga>()
                .HasKey(bv => new { bv.idVagas, bv.idBeneficio });

            modelBuilder.Entity<BeneficioVaga>()
                .HasOne(bv => bv.Beneficio)
                .WithMany()
                .HasForeignKey(bv => bv.idBeneficio)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BeneficioVaga>()
                .HasOne(bv => bv.Vagas)
                .WithMany()
                .HasForeignKey(bv => bv.idVagas)
                .OnDelete(DeleteBehavior.Restrict);

            // Mapeamento VagaConhecimento
            modelBuilder.Entity<VagaConhecimento>()
                .HasKey(vc => new { vc.idVagas, vc.idConhecimentos });

            modelBuilder.Entity<VagaConhecimento>()
                .HasOne(e => e.Vagas)
                .WithMany()
                .HasForeignKey(v => v.idVagas)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VagaConhecimento>()
                .HasOne(v => v.Conhecimentos)
                .WithMany()
                .HasForeignKey(v => v.idConhecimentos)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VagaConhecimento>()
                .HasOne(v => v.Nivel)
                .WithMany()
                .HasForeignKey(v => v.idNivel)
                .OnDelete(DeleteBehavior.Restrict);


            // Mapeamento VagaIdioma
            modelBuilder.Entity<VagaIdioma>()
                .HasKey(vi => new { vi.idVagas, vi.idIdiomas });

            modelBuilder.Entity<VagaIdioma>()
                .HasOne(v => v.Vagas)
                .WithMany()
                .HasForeignKey(v => v.idVagas)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VagaIdioma>()
                .HasOne(v => v.Idioma)
                .WithMany()
                .HasForeignKey(v => v.idIdiomas)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VagaIdioma>()
                .HasOne(n => n.Nivel)
                .WithMany()
                .HasForeignKey(n => n.idNivel)
                .OnDelete(DeleteBehavior.Restrict);

            //Mapeamento Candidato
            modelBuilder.Entity<Candidato>()
                    .HasKey(c => new { c.idCandidato });


            // Mapeamento Curriculo
            modelBuilder.Entity<Curriculo>()
                 .HasKey(c => new { c.idCurriculo });

            modelBuilder.Entity<Curriculo>()
                .HasOne(c => c.Candidato)
                .WithMany()
                .HasForeignKey(c => c.idCandidato)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Curriculo>()
                .HasOne(c => c.Escolaridade)
                .WithMany()
                .HasForeignKey(c => c.idEscolaridade)
                .OnDelete(DeleteBehavior.Restrict);

            // Mapeamento VagaCandidato
            modelBuilder.Entity<VagaCandidato>()
                .HasKey(vc => new { vc.idCurriculo, vc.idVagas });

            modelBuilder.Entity<VagaCandidato>()
                .HasOne(c => c.Curriculo)
                .WithMany()
                .HasForeignKey(c => c.idCurriculo)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VagaCandidato>()
                .HasOne(v => v.Vagas)
                .WithMany()
                .HasForeignKey(e => e.idVagas)
                .OnDelete(DeleteBehavior.Restrict);

            // Mapeamento CarreiraProfissional
            modelBuilder.Entity<CarreiraProfissional>()
                .HasKey(sq => new { sq.sqCarreiraProfissional });

            modelBuilder.Entity<CarreiraProfissional>()
                .HasOne(cp => cp.Curriculo)
                .WithMany()
                .HasForeignKey(c => c.idCurriculo)
                .OnDelete(DeleteBehavior.Restrict);

            // Mapeamento CurriculoConhecimento
            modelBuilder.Entity<CurriculoConhecimento>()
                .HasKey(cc => new { cc.idCurriculo, cc.idConhecimentos });

            modelBuilder.Entity<CurriculoConhecimento>()
                .HasOne(c => c.Curriculo)
                .WithMany()
                .HasForeignKey(c => c.idCurriculo)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CurriculoConhecimento>()
                .HasOne(c => c.Conhecimentos)
                .WithMany()
                .HasForeignKey(c => c.idConhecimentos)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<CurriculoConhecimento>()
                .HasOne(n => n.Nivel)
                .WithMany()
                .HasForeignKey(n => n.idNivel)
                .OnDelete(DeleteBehavior.Restrict);

            // Mapeamento CurriculoIdioma
            modelBuilder.Entity<CurriculoIdioma>()
                .HasKey(ci => new { ci.idCurriculo, ci.idIdiomas });

            modelBuilder.Entity<CurriculoIdioma>()
                .HasOne(c => c.Curriculo)
                .WithMany()
                .HasForeignKey(c => c.idCurriculo)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CurriculoIdioma>()
                .HasOne(c => c.Idiomas)
                .WithMany()
                .HasForeignKey(c => c.idIdiomas)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CurriculoIdioma>()
                .HasOne(n => n.Nivel)
                .WithMany()
                .HasForeignKey(n => n.idNivel)
                .OnDelete(DeleteBehavior.Restrict);

            //Mapeamento Curso
            modelBuilder.Entity<Curso>()
                .HasKey(c => new { c.idCursos });

            // Mapeamento EnderecoCandidato
            modelBuilder.Entity<EnderecoCandidato>()
                .HasKey(ec => new { ec.idCandidato });

            modelBuilder.Entity<EnderecoCandidato>()
                .HasOne(e => e.Candidato)
                .WithMany()
                .HasForeignKey(e => e.idCandidato)
                .OnDelete(DeleteBehavior.Restrict);


            // Mapeamento FormacaoAcademica
            modelBuilder.Entity<FormacaoAcademica>()
                .HasKey(fa => new { fa.idFormacaoAcademica, fa.idCurriculo });

            modelBuilder.Entity<FormacaoAcademica>()
                .HasOne(f => f.Curriculo)
                .WithMany()
                .HasForeignKey(c => c.idCurriculo)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FormacaoAcademica>()
                .HasOne(f => f.Curso)
                .WithMany()
                .HasForeignKey(f => f.idCursos)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);

        }

    }
}

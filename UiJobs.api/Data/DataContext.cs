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
            //Insert de tabelas

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

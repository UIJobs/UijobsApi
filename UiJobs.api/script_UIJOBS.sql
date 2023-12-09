IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Beneficio] (
    [idBeneficio] int NOT NULL IDENTITY,
    [nomeBeneficio] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_Beneficio] PRIMARY KEY ([idBeneficio])
);
GO

CREATE TABLE [Candidato] (
    [idCandidato] int NOT NULL IDENTITY,
    [nome] nvarchar(60) NOT NULL,
    [email] nvarchar(100) NOT NULL,
    [nomeMae] nvarchar(60) NOT NULL,
    [dataNascimento] datetime2 NOT NULL,
    CONSTRAINT [PK_Candidato] PRIMARY KEY ([idCandidato])
);
GO

CREATE TABLE [Conhecimentos] (
    [idConhecimentos] int NOT NULL IDENTITY,
    [nomeConhecimento] nvarchar(30) NOT NULL,
    CONSTRAINT [PK_Conhecimentos] PRIMARY KEY ([idConhecimentos])
);
GO

CREATE TABLE [Cursos] (
    [idCursos] int NOT NULL IDENTITY,
    [nomeCurso] nvarchar(70) NOT NULL,
    [DiplomaCurso] nvarchar(1) NOT NULL,
    CONSTRAINT [PK_Cursos] PRIMARY KEY ([idCursos])
);
GO

CREATE TABLE [Escolaridade] (
    [idEscolaridade] int NOT NULL IDENTITY,
    [nomeEscolaridade] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_Escolaridade] PRIMARY KEY ([idEscolaridade])
);
GO

CREATE TABLE [Idiomas] (
    [idIdiomas] int NOT NULL IDENTITY,
    [nomeIdioma] nvarchar(15) NOT NULL,
    CONSTRAINT [PK_Idiomas] PRIMARY KEY ([idIdiomas])
);
GO

CREATE TABLE [Nivel] (
    [idNivel] int NOT NULL IDENTITY,
    [niveisDisponiveis] nvarchar(15) NOT NULL,
    CONSTRAINT [PK_Nivel] PRIMARY KEY ([idNivel])
);
GO

CREATE TABLE [Portes] (
    [idPortes] int NOT NULL IDENTITY,
    [tiposPortes] nvarchar(20) NOT NULL,
    CONSTRAINT [PK_Portes] PRIMARY KEY ([idPortes])
);
GO

CREATE TABLE [SituacaoVaga] (
    [idSituacaoVaga] int NOT NULL IDENTITY,
    [situacaoAtual] nvarchar(15) NOT NULL,
    CONSTRAINT [PK_SituacaoVaga] PRIMARY KEY ([idSituacaoVaga])
);
GO

CREATE TABLE [EnderecoCandidato] (
    [idCandidato] int NOT NULL,
    [cep] nvarchar(8) NOT NULL,
    [logradouro] nvarchar(15) NOT NULL,
    [endereco] nvarchar(50) NOT NULL,
    [numero] int NOT NULL,
    [complemento] nvarchar(15) NULL,
    [bairro] nvarchar(30) NOT NULL,
    [cidade] nvarchar(50) NOT NULL,
    [uf] nvarchar(2) NOT NULL,
    CONSTRAINT [PK_EnderecoCandidato] PRIMARY KEY ([idCandidato]),
    CONSTRAINT [FK_EnderecoCandidato_Candidato_idCandidato] FOREIGN KEY ([idCandidato]) REFERENCES [Candidato] ([idCandidato]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Curriculo] (
    [idCurriculo] int NOT NULL IDENTITY,
    [idEscolaridade] int NOT NULL,
    [idCandidato] int NOT NULL,
    [objetivo] nvarchar(200) NOT NULL,
    [dcCurriculo] datetime2 NOT NULL,
    [duCurriculo] datetime2 NOT NULL,
    CONSTRAINT [PK_Curriculo] PRIMARY KEY ([idCurriculo]),
    CONSTRAINT [FK_Curriculo_Candidato_idCandidato] FOREIGN KEY ([idCandidato]) REFERENCES [Candidato] ([idCandidato]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Curriculo_Escolaridade_idEscolaridade] FOREIGN KEY ([idEscolaridade]) REFERENCES [Escolaridade] ([idEscolaridade]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Empresa] (
    [idEmpresa] int NOT NULL IDENTITY,
    [idPortes] int NOT NULL,
    [cnpj] nvarchar(19) NOT NULL,
    [email] nvarchar(100) NOT NULL,
    [razaoSocial] nvarchar(50) NOT NULL,
    [nomeFantasia] nvarchar(30) NOT NULL,
    CONSTRAINT [PK_Empresa] PRIMARY KEY ([idEmpresa]),
    CONSTRAINT [FK_Empresa_Portes_idPortes] FOREIGN KEY ([idPortes]) REFERENCES [Portes] ([idPortes]) ON DELETE NO ACTION
);
GO

CREATE TABLE [CarreiraProfissional] (
    [sqCarreiraProfissional] int NOT NULL IDENTITY,
    [idCurriculo] int NOT NULL,
    [nomeEmpresa] nvarchar(150) NOT NULL,
    [tempoInicio] datetime2 NOT NULL,
    [tempoFim] datetime2 NOT NULL,
    [cargo] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_CarreiraProfissional] PRIMARY KEY ([sqCarreiraProfissional]),
    CONSTRAINT [FK_CarreiraProfissional_Curriculo_idCurriculo] FOREIGN KEY ([idCurriculo]) REFERENCES [Curriculo] ([idCurriculo]) ON DELETE NO ACTION
);
GO

CREATE TABLE [CurriculoConhecimentos] (
    [idCurriculo] int NOT NULL,
    [idConhecimentos] int NOT NULL,
    [idNivel] int NOT NULL,
    CONSTRAINT [PK_CurriculoConhecimentos] PRIMARY KEY ([idCurriculo], [idConhecimentos]),
    CONSTRAINT [FK_CurriculoConhecimentos_Conhecimentos_idConhecimentos] FOREIGN KEY ([idConhecimentos]) REFERENCES [Conhecimentos] ([idConhecimentos]) ON DELETE NO ACTION,
    CONSTRAINT [FK_CurriculoConhecimentos_Curriculo_idCurriculo] FOREIGN KEY ([idCurriculo]) REFERENCES [Curriculo] ([idCurriculo]) ON DELETE NO ACTION,
    CONSTRAINT [FK_CurriculoConhecimentos_Nivel_idNivel] FOREIGN KEY ([idNivel]) REFERENCES [Nivel] ([idNivel]) ON DELETE NO ACTION
);
GO

CREATE TABLE [CurriculoIdiomas] (
    [idCurriculo] int NOT NULL,
    [idIdiomas] int NOT NULL,
    [idNivel] int NOT NULL,
    CONSTRAINT [PK_CurriculoIdiomas] PRIMARY KEY ([idCurriculo], [idIdiomas]),
    CONSTRAINT [FK_CurriculoIdiomas_Curriculo_idCurriculo] FOREIGN KEY ([idCurriculo]) REFERENCES [Curriculo] ([idCurriculo]) ON DELETE NO ACTION,
    CONSTRAINT [FK_CurriculoIdiomas_Idiomas_idIdiomas] FOREIGN KEY ([idIdiomas]) REFERENCES [Idiomas] ([idIdiomas]) ON DELETE NO ACTION,
    CONSTRAINT [FK_CurriculoIdiomas_Nivel_idNivel] FOREIGN KEY ([idNivel]) REFERENCES [Nivel] ([idNivel]) ON DELETE NO ACTION
);
GO

CREATE TABLE [FormacaoAcademica] (
    [idFormacaoAcademica] int NOT NULL,
    [idCurriculo] int NOT NULL,
    [idCursos] int NOT NULL,
    [diCurso] datetime2 NOT NULL,
    [dfCurso] datetime2 NOT NULL,
    CONSTRAINT [PK_FormacaoAcademica] PRIMARY KEY ([idFormacaoAcademica], [idCurriculo]),
    CONSTRAINT [FK_FormacaoAcademica_Curriculo_idCurriculo] FOREIGN KEY ([idCurriculo]) REFERENCES [Curriculo] ([idCurriculo]) ON DELETE NO ACTION,
    CONSTRAINT [FK_FormacaoAcademica_Cursos_idCursos] FOREIGN KEY ([idCursos]) REFERENCES [Cursos] ([idCursos]) ON DELETE NO ACTION
);
GO

CREATE TABLE [EnderecoEmpresa] (
    [idEmpresa] int NOT NULL,
    [cep] nvarchar(8) NOT NULL,
    [logradouro] nvarchar(15) NOT NULL,
    [endereco] nvarchar(50) NOT NULL,
    [numero] int NOT NULL,
    [complemento] nvarchar(20) NULL,
    [bairro] nvarchar(30) NOT NULL,
    [cidade] nvarchar(50) NOT NULL,
    [uf] nvarchar(2) NOT NULL,
    CONSTRAINT [PK_EnderecoEmpresa] PRIMARY KEY ([idEmpresa]),
    CONSTRAINT [FK_EnderecoEmpresa_Empresa_idEmpresa] FOREIGN KEY ([idEmpresa]) REFERENCES [Empresa] ([idEmpresa]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Vagas] (
    [idVagas] int NOT NULL IDENTITY,
    [idEscolaridade] int NOT NULL,
    [idSituacaoVaga] int NOT NULL,
    [idEmpresa] int NOT NULL,
    [cargo] nvarchar(25) NOT NULL,
    [descricao] nvarchar(100) NOT NULL,
    [inicioVigencia] datetime2 NOT NULL,
    [finalVigencia] datetime2 NOT NULL,
    [salario] real NULL,
    [cargaHoraria] smallint NOT NULL,
    [localidade] nvarchar(50) NOT NULL,
    [percAderencia] real NOT NULL,
    [tempoSemanal] nvarchar(30) NOT NULL,
    CONSTRAINT [PK_Vagas] PRIMARY KEY ([idVagas]),
    CONSTRAINT [FK_Vagas_Empresa_idEmpresa] FOREIGN KEY ([idEmpresa]) REFERENCES [Empresa] ([idEmpresa]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Vagas_Escolaridade_idEscolaridade] FOREIGN KEY ([idEscolaridade]) REFERENCES [Escolaridade] ([idEscolaridade]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Vagas_SituacaoVaga_idSituacaoVaga] FOREIGN KEY ([idSituacaoVaga]) REFERENCES [SituacaoVaga] ([idSituacaoVaga]) ON DELETE NO ACTION
);
GO

CREATE TABLE [BeneficioVagas] (
    [idVagas] int NOT NULL,
    [idBeneficio] int NOT NULL,
    CONSTRAINT [PK_BeneficioVagas] PRIMARY KEY ([idVagas], [idBeneficio]),
    CONSTRAINT [FK_BeneficioVagas_Beneficio_idBeneficio] FOREIGN KEY ([idBeneficio]) REFERENCES [Beneficio] ([idBeneficio]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BeneficioVagas_Vagas_idVagas] FOREIGN KEY ([idVagas]) REFERENCES [Vagas] ([idVagas]) ON DELETE NO ACTION
);
GO

CREATE TABLE [VagasCandidato] (
    [idVagas] int NOT NULL,
    [idCurriculo] int NOT NULL,
    [dcCurriculo] datetime2 NOT NULL,
    [vtEmpresa] nvarchar(1) NOT NULL,
    [vtCandidato] nvarchar(1) NOT NULL,
    [percAderencia] real NOT NULL,
    CONSTRAINT [PK_VagasCandidato] PRIMARY KEY ([idCurriculo], [idVagas]),
    CONSTRAINT [FK_VagasCandidato_Curriculo_idCurriculo] FOREIGN KEY ([idCurriculo]) REFERENCES [Curriculo] ([idCurriculo]) ON DELETE NO ACTION,
    CONSTRAINT [FK_VagasCandidato_Vagas_idVagas] FOREIGN KEY ([idVagas]) REFERENCES [Vagas] ([idVagas]) ON DELETE NO ACTION
);
GO

CREATE TABLE [VagasConhecimentos] (
    [idVagas] int NOT NULL,
    [idConhecimentos] int NOT NULL,
    [idNivel] int NOT NULL,
    CONSTRAINT [PK_VagasConhecimentos] PRIMARY KEY ([idVagas], [idConhecimentos]),
    CONSTRAINT [FK_VagasConhecimentos_Conhecimentos_idConhecimentos] FOREIGN KEY ([idConhecimentos]) REFERENCES [Conhecimentos] ([idConhecimentos]) ON DELETE NO ACTION,
    CONSTRAINT [FK_VagasConhecimentos_Nivel_idNivel] FOREIGN KEY ([idNivel]) REFERENCES [Nivel] ([idNivel]) ON DELETE NO ACTION,
    CONSTRAINT [FK_VagasConhecimentos_Vagas_idVagas] FOREIGN KEY ([idVagas]) REFERENCES [Vagas] ([idVagas]) ON DELETE NO ACTION
);
GO

CREATE TABLE [VagasIdiomas] (
    [idVagas] int NOT NULL,
    [idIdiomas] int NOT NULL,
    [idNivel] int NOT NULL,
    CONSTRAINT [PK_VagasIdiomas] PRIMARY KEY ([idVagas], [idIdiomas]),
    CONSTRAINT [FK_VagasIdiomas_Idiomas_idIdiomas] FOREIGN KEY ([idIdiomas]) REFERENCES [Idiomas] ([idIdiomas]) ON DELETE NO ACTION,
    CONSTRAINT [FK_VagasIdiomas_Nivel_idNivel] FOREIGN KEY ([idNivel]) REFERENCES [Nivel] ([idNivel]) ON DELETE NO ACTION,
    CONSTRAINT [FK_VagasIdiomas_Vagas_idVagas] FOREIGN KEY ([idVagas]) REFERENCES [Vagas] ([idVagas]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_BeneficioVagas_idBeneficio] ON [BeneficioVagas] ([idBeneficio]);
GO

CREATE INDEX [IX_BeneficioVagas_idVagas_idBeneficio] ON [BeneficioVagas] ([idVagas], [idBeneficio]);
GO

CREATE INDEX [IX_Candidato_email] ON [Candidato] ([email]);
GO

CREATE INDEX [IX_CarreiraProfissional_idCurriculo] ON [CarreiraProfissional] ([idCurriculo]);
GO

CREATE INDEX [IX_Curriculo_idCandidato] ON [Curriculo] ([idCandidato]);
GO

CREATE INDEX [IX_Curriculo_idEscolaridade] ON [Curriculo] ([idEscolaridade]);
GO

CREATE INDEX [IX_CurriculoConhecimentos_idConhecimentos] ON [CurriculoConhecimentos] ([idConhecimentos]);
GO

CREATE INDEX [IX_CurriculoConhecimentos_idCurriculo_idConhecimentos] ON [CurriculoConhecimentos] ([idCurriculo], [idConhecimentos]);
GO

CREATE INDEX [IX_CurriculoConhecimentos_idNivel] ON [CurriculoConhecimentos] ([idNivel]);
GO

CREATE INDEX [IX_CurriculoIdiomas_idCurriculo_idIdiomas] ON [CurriculoIdiomas] ([idCurriculo], [idIdiomas]);
GO

CREATE INDEX [IX_CurriculoIdiomas_idIdiomas] ON [CurriculoIdiomas] ([idIdiomas]);
GO

CREATE INDEX [IX_CurriculoIdiomas_idNivel] ON [CurriculoIdiomas] ([idNivel]);
GO

CREATE INDEX [IX_Cursos_DiplomaCurso] ON [Cursos] ([DiplomaCurso]);
GO

CREATE INDEX [IX_Empresa_idPortes] ON [Empresa] ([idPortes]);
GO

CREATE INDEX [IX_EnderecoCandidato_idCandidato] ON [EnderecoCandidato] ([idCandidato]);
GO

CREATE INDEX [IX_EnderecoEmpresa_idEmpresa] ON [EnderecoEmpresa] ([idEmpresa]);
GO

CREATE INDEX [IX_FormacaoAcademica_idCurriculo] ON [FormacaoAcademica] ([idCurriculo]);
GO

CREATE INDEX [IX_FormacaoAcademica_idCursos] ON [FormacaoAcademica] ([idCursos]);
GO

CREATE INDEX [IX_Vagas_idEmpresa] ON [Vagas] ([idEmpresa]);
GO

CREATE INDEX [IX_Vagas_idEscolaridade] ON [Vagas] ([idEscolaridade]);
GO

CREATE INDEX [IX_Vagas_idSituacaoVaga] ON [Vagas] ([idSituacaoVaga]);
GO

CREATE INDEX [IX_VagasCandidato_idVagas] ON [VagasCandidato] ([idVagas]);
GO

CREATE INDEX [IX_VagasConhecimentos_idConhecimentos] ON [VagasConhecimentos] ([idConhecimentos]);
GO

CREATE INDEX [IX_VagasConhecimentos_idNivel] ON [VagasConhecimentos] ([idNivel]);
GO

CREATE INDEX [IX_VagasIdiomas_idIdiomas] ON [VagasIdiomas] ([idIdiomas]);
GO

CREATE INDEX [IX_VagasIdiomas_idNivel] ON [VagasIdiomas] ([idNivel]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231209181323_FinalMigration', N'7.0.11');
GO

COMMIT;
GO


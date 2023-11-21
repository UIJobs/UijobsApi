﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UIJobsAPI.Models
{
    public class FormacaoAcademica
    {
        [Key]
        public int idFormacaoAcademica { get; set; }

        [Required]
        public int idCurriculo { get; set; }

        [Required]
        public int idCursos { get; set; }

        public DateTime diCurso { get; set; }

        public DateTime dfCurso { get; set; }

        [ForeignKey("idCursos")]
        public Curso Curso { get; set; }

        [ForeignKey("idCurriculo")]
        public Curriculo Curriculo { get; set; }
    }
}
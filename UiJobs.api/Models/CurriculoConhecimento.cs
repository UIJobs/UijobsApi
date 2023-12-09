﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;


namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idCurriculo),nameof(idConhecimentos))]
    [Index(nameof(idCurriculo), nameof(idConhecimentos))]

    public class CurriculoConhecimento
    {
        [Key]
        [ForeignKey("idCurriculo")]
        public int idCurriculo { get; set; }
        
        [Key]
        [ForeignKey("idConhecimentos")]
        public int idConhecimentos { get; set; }

        [ForeignKey("idNivel")]
        public int idNivel { get; set; }


        [JsonIgnore]
        public Curriculo? Curriculo { get; set; }

        [JsonIgnore]
        public Conhecimento? Conhecimentos { get; set; }

        [JsonIgnore]
        public Nivel? Nivel { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idVagas), nameof(idConhecimentos))]
    public class VagaConhecimento
    {
        [Required]
        [ForeignKey("idVagas")]
        public int idVagas { get; set; }

        [Required]
        [ForeignKey("idConhecimentos")]
        public int idConhecimentos { get; set; }

        [Required]
        [ForeignKey("idNivel")]
        public int idNivel { get; set; }

        [JsonIgnore]
        public Nivel? Nivel { get; set; }

        [JsonIgnore]
        public Vaga? Vagas { get; set; }

        [JsonIgnore]
        public Conhecimento? Conhecimentos { get; set; }
    }
}

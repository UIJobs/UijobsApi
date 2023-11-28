using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idVagas), nameof(idCurriculo))]

    public class VagaCandidato
    {
        [Column(Order = 0)]
        [ForeignKey("idVagas")]
        public int idVagas { get; set; }

        [ForeignKey("idCurriculo")]
        [Column(Order = 1)]
        public int idCurriculo { get; set; }


        public DateTime dcCurriculo { get; set; }

        [MaxLength(1)]
        public string vtEmpresa { get; set; }

        [MaxLength(1)]
        public string vtCandidato { get; set; }

        public float percAderencia { get; set; }


        [JsonIgnore]
        public Vaga? Vagas { get; set; }

        [JsonIgnore]
        public Curriculo? Curriculo { get; set; }
    
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace UIJobsAPI.Models
{
    public class VagaCandidato
    {
        
        [Key]
        public int idVagas { get; set; }

        [Key]
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

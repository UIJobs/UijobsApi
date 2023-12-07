using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idVagas), nameof(idBeneficio))]
    [Index(nameof(idVagas), nameof(idBeneficio))]

    public class BeneficioVaga
    {
        
        [ForeignKey("idVagas")]
        public int idVagas { get; set; }

        [ForeignKey("idBeneficio")]
        public int idBeneficio { get; set; }

        [JsonIgnore]
        public Vaga? Vagas { get; set; }

        [JsonIgnore]
        public Beneficio? Beneficio { get; set; }
    }
}

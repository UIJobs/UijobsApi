using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace UIJobsAPI.Models
{
    public class BeneficioVaga
    {
        
        [Column(Order = 0)]
        [ForeignKey("idVagas")]
        public int idVagas { get; set; }

        [Column(Order = 1)]
        [ForeignKey("idBeneficio")]
        public int idBeneficio { get; set; }

        [JsonIgnore]
        public Vaga? Vagas { get; set; }

        [JsonIgnore]
        public Beneficio? Beneficio { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idVagas), nameof(idIdiomas))]
    public class VagaIdioma
    {
        [Required]
        [ForeignKey("idVagas")]
        public int idVagas { get; set; }
        
        [Required]
        [ForeignKey("idIdiomas")]
        public int idIdiomas { get; set; }

        [Required]
        [ForeignKey("idNivel")]
        public int idNivel { get; set; }

        [JsonIgnore]
        public Nivel? Nivel { get; set; }

        [JsonIgnore]
        public Vaga? Vagas { get; set; }

        [JsonIgnore]
        public Idioma? Idioma { get; set; }
    }
}

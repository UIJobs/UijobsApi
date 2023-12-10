using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idCurriculo), nameof(idIdiomas))]
    [Index(nameof(idCurriculo), nameof(idIdiomas))]

    public class CurriculoIdioma
    {
      
        [ForeignKey("idCurriculo")]
        public int idCurriculo { get; set; }

 
        [ForeignKey("idIdiomas")]
        public int idIdiomas { get; set; }

        [ForeignKey("idNivel")]
        public int idNivel { get; set; }


        [JsonIgnore]
        public Curriculo? Curriculo { get; set; }

        [JsonIgnore]
        public Idioma? Idiomas { get; set; }

        [JsonIgnore]
        public Nivel? Nivel{ get; set; }
    }
}

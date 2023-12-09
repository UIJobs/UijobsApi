using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(sqCarreiraProfissional))]
    [Index(nameof(idCurriculo))]

    public class CarreiraProfissional
    {
     
        public int sqCarreiraProfissional { get; set; }

        [Required]
        [ForeignKey("idCurriculo")]
        public int idCurriculo { get; set; }

        [Required]
        [MaxLength(150)]
        public string nomeEmpresa { get; set; }

        [Required]
        public DateTime tempoInicio { get; set; }

        [Required]
        public DateTime tempoFim { get; set; }

        [Required]
        [MaxLength(50)]
        public string cargo { get; set; }

        [JsonIgnore]
        public Curriculo? Curriculo { get; set; }
    }
}
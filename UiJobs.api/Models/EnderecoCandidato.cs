using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idCandidato))]
    [Index(nameof(idCandidato))]

    public class EnderecoCandidato
    {
        
        [ForeignKey("idCandidato")]
        public int idCandidato { get; set; }

        [Required]
        [MaxLength(8)]
        public string cep { get; set; }

        [Required]
        [MaxLength(15)]
        public string logradouro { get; set; }

        [Required]
        [MaxLength(50)]
        public string endereco { get; set; }

        [Required]
        public int numero { get; set; }

        [MaxLength(15)]
        public string? complemento { get; set; }

        [Required]
        [MaxLength(30)]
        public string bairro { get; set; }

        [Required]
        [MaxLength(50)]
        public string cidade { get; set; }

        [Required]
        [MaxLength(2)]
        public string uf { get; set; }

        [JsonIgnore]
        public Candidato? Candidato { get; set; }
    }
}

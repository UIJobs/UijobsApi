using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idEmpresa))]
    [Index(nameof(idPortes))]

    public class Empresa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int idEmpresa { get; set; }


        [Required]
        [ForeignKey("idPortes")]
        public int idPortes { get; set; }


        [Required]
        [MaxLength(19)]
        public string cnpj { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string email { get; set; }

        [Required]
        [MaxLength(50)]
        public string razaoSocial { get; set; }

        [Required]
        [MaxLength(30)]
        public string nomeFantasia { get; set; }

        [JsonIgnore]
        public Porte? Porte { get; set; }
    }
}

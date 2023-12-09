using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using UIJobsAPI.Models.Enuns;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idNivel))]

    public class Nivel
    {
        [JsonIgnore]
        public int idNivel { get; set; }

        [Required]
        [MaxLength(15)]
        public string niveisDisponiveis { get; set; }
    }
}

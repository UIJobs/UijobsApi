using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idEscolaridade))]

    public class Escolaridade
    {
        [JsonIgnore]
        public int idEscolaridade { get; set; }

        [Required]
        [MaxLength(50)]
        public string nomeEscolaridade { get; set; }
    }
}

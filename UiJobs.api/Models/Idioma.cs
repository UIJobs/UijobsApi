using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using UIJobsAPI.Models.Enuns;
using System.Text.Json.Serialization;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idIdiomas))]

    public class Idioma
    {
        [JsonIgnore]
        public int idIdiomas { get; set; }

        [Required]
        [MaxLength(15)]
        public string nomeIdioma { get; set; }
    }
}

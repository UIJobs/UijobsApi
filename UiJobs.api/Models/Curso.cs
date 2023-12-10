using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using UIJobsAPI.Models.Enuns;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idCursos))]
    [Index(nameof(DiplomaCurso))]

    public class Curso
    {

        [JsonIgnore]
        public int idCursos { get; set; }

        [Required]
        [MaxLength(70)]
        public string nomeCurso { get; set; }

        [Required]
        [MaxLength(1)]
        public string DiplomaCurso { get; set; }

    }
}

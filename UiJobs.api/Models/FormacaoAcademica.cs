using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idFormacaoAcademica))]
    [Index(nameof(idCursos))]

    public class FormacaoAcademica
    {
        
        public int idFormacaoAcademica { get; set; }

        [Required]
        [ForeignKey("idCurriculo")]
        public int idCurriculo { get; set; }

        [Required]
        [ForeignKey("idCursos")]
        public int idCursos { get; set; }

        public DateTime diCurso { get; set; }

        public DateTime dfCurso { get; set; }

        [JsonIgnore]
        public Curso? Curso { get; set; }

        [JsonIgnore]
        public Curriculo? Curriculo { get; set; }
    }
}

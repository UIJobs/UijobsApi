using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UIJobsAPI.Models.Enuns;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idNivel))]

    public class Nivel
    {
        public int idNivel { get; set; }

        [Required]
        [MaxLength(15)]
        public string niveisDisponiveis { get; set; }
    }
}

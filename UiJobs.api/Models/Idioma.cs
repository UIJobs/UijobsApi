using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using UIJobsAPI.Models.Enuns;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idIdiomas))]

    public class Idioma
    {
        
        public int idIdiomas { get; set; }

        [Required]
        [MaxLength(15)]
        public string nomeIdioma { get; set; }
    }
}

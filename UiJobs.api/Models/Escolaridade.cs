using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idEscolaridade))]

    public class Escolaridade
    {
        
        public int idEscolaridade { get; set; }

        [Required]
        [MaxLength(50)]
        public string nomeEscolaridade { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UIJobsAPI.Models
{
    public class Escolaridade
    {
        [Key]
        public int idEscolaridade { get; set; }

        [Required]
        [StringLength(50)]
        public string nomeEscolaridade { get; set; }
    }
}

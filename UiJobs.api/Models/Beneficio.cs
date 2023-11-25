using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UIJobsAPI.Models.Enuns;

namespace UIJobsAPI.Models
{
    public class Beneficio
    {
        [Key]
        [Column("idBeneficio")]
        public int idBeneficio { get; set; }

        [Required]
        [Column("nomeBeneficio ")]
        public String nomeBeneficio { get; set; }
    }
}

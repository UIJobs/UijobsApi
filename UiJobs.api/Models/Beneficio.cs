using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using UIJobsAPI.Models.Enuns;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idBeneficio))]
    
    public class Beneficio
    {
        [JsonIgnore]
        public int idBeneficio { get; set; }

        [Required]
        [MaxLength(50)]
        public string nomeBeneficio { get; set; }
    }
}

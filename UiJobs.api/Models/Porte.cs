using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using UIJobsAPI.Models.Enuns;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idPortes))]
    public class Porte
    {
        [Required]
        [JsonIgnore]
        public int idPortes { get; set; }
   
        [Required]
        [MaxLength(20)]
        public string tiposPortes { get; set; }
    }
}

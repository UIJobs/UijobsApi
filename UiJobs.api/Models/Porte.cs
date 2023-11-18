using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using UIJobsAPI.Models.Enuns;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idPortes))]
    public class Porte
    {
        [NotNull]
        [Required]
        public int idPortes { get; set; }
        [NotNull]
        [Required]
        public String tiposPortes { get; set; }
    }
}

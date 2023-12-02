using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idCandidato))]
    [Index(nameof(email))]

    public class Candidato
    {

        public int idCandidato { get; set; }

        [Required]
        [MaxLength(60)]
        public string nome { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string email { get; set; }

        [NotMapped]
        public byte[]? foto { get; set; }

        [Required]
        [MaxLength(60)]
        public string nomeMae { get; set; }

        public DateTime dataNascimento { get; set; }

    }
}

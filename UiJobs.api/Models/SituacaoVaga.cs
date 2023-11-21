using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UIJobsAPI.Models.Enuns;

namespace UIJobsAPI.Models
{
    public class SituacaoVaga
    {
        [Key]
        public int idSituacaoVaga { get; set; }

        [Required]
        public String situacaoAtual { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using UIJobsAPI.Models.Enuns;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idSituacaoVaga))]

    public class SituacaoVaga
    {
        [JsonIgnore]
        public int idSituacaoVaga { get; set; }

        [Required]
        [MaxLength(15)]
        public string situacaoAtual { get; set; }
    }
}

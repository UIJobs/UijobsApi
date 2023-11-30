using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idCurriculo))]

    public class Curriculo
    {

        public int idCurriculo { get; set; }
        
        //Novo
        [Required]
        [ForeignKey("idEscolaridade")]
        public int idEscolaridade { get; set; }

        //Novo
        [Required]
        [ForeignKey("idCandidato")]
        public int idCandidato { get; set; }

        [Required]
        [MaxLength(200)]
        public string objetivo { get; set; }

        //Novo
        //Data de Cadastro do Curriculo
        [Required]
        public DateTime dcCurriculo { get; set; }
        
        //Novo
        //Data de ??? do Curriculo (Algo haver com ultima atualização no currículo)
        [Required]
        public DateTime duCurriculo { get; set; }

        [JsonIgnore]
        public Escolaridade? Escolaridade { get; set; }

        [JsonIgnore]
        public Candidato? Candidato { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace UIJobsAPI.Models
{ 

    public class Vaga
    {
        [Key]
        public int idVagas { get; set; }

        public int idEscolaridade { get; set; }


        public int idSituacaoVaga { get; set; }

        public int idEmpresa { get; set; }

        [MaxLength(25)]
        public string cargo { get; set; }

        [MaxLength(100)]
        public string descricao { get; set; }

        public DateTime inicioVigencia { get; set; }

        public DateTime finalVigencia { get; set; }

        public float? salario { get; set; }

        public short cargaHoraria { get; set; }

        [MaxLength(50)]
        public string localidade { get; set; }

        public float percAderencia { get; set; }

        [MaxLength(30)]
        public string tempoSemanal { get; set; }

        [JsonIgnore]
        public Empresa? Empresa { get; set; }

        [JsonIgnore]
        public SituacaoVaga? SituacaoVaga { get; set; }

        [JsonIgnore]
        public Escolaridade? Escolaridade { get; set; }
    }
}

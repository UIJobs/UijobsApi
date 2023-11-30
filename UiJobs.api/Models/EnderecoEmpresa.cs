using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using UIJobsAPI.Models;

namespace UIJobsAPI.Models
{
    [PrimaryKey(nameof(idEmpresa))]
    [Index(nameof(idEmpresa))]

    public class EnderecoEmpresa
    {
        [Required]
        [ForeignKey("idEmpresa")]
        public int idEmpresa { get; set; }

        [Required]
        [StringLength(8)]
        public string cep { get; set; }

        [Required]
        [StringLength(15)]
        public string logradouro { get; set; }

        [Required]
        [StringLength(50)]
        public string endereco { get; set; }

        [Required]
        public int numero { get; set; }

        [StringLength(20)]
        public string? complemento { get; set; }

        [Required]
        [StringLength(30)]
        public string bairro { get; set; }

        [Required]
        [StringLength(50)]
        public string cidade { get; set; }

        [Required]
        [StringLength(2)]
        public string uf { get; set; }

        //Tá certo?

        [JsonIgnore]
        public Empresa? Empresa { get; set; }
    }
}
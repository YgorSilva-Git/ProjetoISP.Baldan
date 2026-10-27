using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoISP.Baldan.Models.PlanosAcao
{
    [Table("EvidenciaFotografica")]
    public class EvidenciaFotografica
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("PlanoAcao5W2H")]
        public int PlanoAcao5W2Hid { get; set; }
        public PlanoAcao5W2H PlanoAcao5W2H { get; set; }

        [Required]
        [StringLength(255)]
        public string CaminhoArquivo { get; set; }

        public DateTime DataUpload { get; set; } = DateTime.Now;
    }
}
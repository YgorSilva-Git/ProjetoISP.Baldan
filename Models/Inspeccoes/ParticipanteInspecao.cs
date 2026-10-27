using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoISP.Baldan.Models.Inspeccoes
{
    [Table("ParticipanteInspecao")]
    public class ParticipanteInspecao
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("InspecaoISP")]
        public int InspecaoISPid { get; set; }
        public InspecaoISP InspecaoISP { get; set; }

        [Required]
        [StringLength(150)]
        public string NomeParticipante { get; set; }

        [StringLength(255)]
        public string CaminhoFotoEquipe { get; set; }
    }
}
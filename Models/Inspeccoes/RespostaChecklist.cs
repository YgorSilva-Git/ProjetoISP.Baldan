using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetoISP.Baldan.Models.Checklist;

namespace ProjetoISP.Baldan.Models.Inspeccoes
{
    [Table("RespostaChecklist")]
    public class RespostaChecklist
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("InspecaoISP")]
        public int InspecaoISPid { get; set; }
        public InspecaoISP InspecaoISP { get; set; }

        [ForeignKey("PerguntaChecklist")]
        public int PerguntaChecklistid { get; set; }
        public PerguntaChecklist PerguntaChecklist { get; set; }

        [Required]
        [StringLength(50)]
        public string Resposta { get; set; } // Ex: Conforme, Não, N.A.
    }
}
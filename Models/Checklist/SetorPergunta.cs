using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetoISP.Baldan.Models.Setores;

namespace ProjetoISP.Baldan.Models.Checklist
{
    [Table("SetorPergunta")]
    public class SetorPergunta
    {
        [Key, Column(Order = 0)]
        [ForeignKey("SetorArea")]
        public int SetorAreaid { get; set; }
        public SetorArea SetorArea { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("PerguntaChecklist")]
        public int PerguntaChecklistid { get; set; }
        public PerguntaChecklist PerguntaChecklist { get; set; }
    }
}
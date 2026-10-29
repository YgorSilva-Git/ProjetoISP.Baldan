using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetoISP.Baldan.Models.Checklist;
using ProjetoISP.Baldan.Models.PlanosAcao;

namespace ProjetoISP.Baldan.Models.Inspeccoes
{
    [Table("RESULTADOS_INSPECAO")]
    public class ResultadoInspecao
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("resposta_coletada", TypeName = "varchar(100)")]
        public string RespostaColetada { get; set; }

        [Column("observacoes", TypeName = "text")]
        public string Observacoes { get; set; }

        [Column("url_foto_evidencia", TypeName = "varchar(255)")]
        public string UrlFotoEvidencia { get; set; }

        // Chaves Estrangeiras
        [Column("id_inspecao")]
        public int IdInspecao { get; set; }
        [ForeignKey("IdInspecao")]
        public InspecaoISP Inspecao { get; set; }

        [Column("id_item_checklist")]
        public int IdItemChecklist { get; set; }
        [ForeignKey("IdItemChecklist")]
        public ItemChecklist ItemChecklist { get; set; }

        public ICollection<PlanoAcao5W2H> PlanosAcao { get; set; }
    }
}
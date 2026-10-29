using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetoISP.Baldan.Models.Inspeccoes;

namespace ProjetoISP.Baldan.Models.Checklist
{
    [Table("ITENS_CHECKLIST")]
    public class ItemChecklist
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("descricao_pergunta", TypeName = "text")]
        public string DescricaoPergunta { get; set; }

        [Column("tipo_resposta", TypeName = "varchar(50)")]
        public string TipoResposta { get; set; }

        [Column("data", TypeName = "date")]
        public DateTime Data { get; set; }

        // Chave Estrangeira para ModeloChecklist
        [Column("id_checklist")]
        public int IdChecklist { get; set; }

        [ForeignKey("IdChecklist")]
        public ModeloChecklist ModeloChecklist { get; set; }

        public ICollection<ResultadoInspecao> ResultadosInspecoes { get; set; }
    }
}
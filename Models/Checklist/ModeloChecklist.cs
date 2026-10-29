using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetoISP.Baldan.Models.Inspeccoes;

namespace ProjetoISP.Baldan.Models.Checklist
{
    [Table("MODELOS_CHECKLIST")]
    public class ModeloChecklist
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("nome", TypeName = "varchar(150)")]
        public string Nome { get; set; }

        [Column("versao", TypeName = "varchar(20)")]
        public string Versao { get; set; }

        [Column("status", TypeName = "varchar(50)")]
        public string Status { get; set; }

        [Column("data", TypeName = "date")]
        public DateTime Data { get; set; }

        // Chave Estrangeira para Categoria
        [Column("id_categoria")]
        public int IdCategoria { get; set; }

        [ForeignKey("IdCategoria")]
        public Categoria Categoria { get; set; }

        public ICollection<ItemChecklist> ItensChecklist { get; set; }
        public ICollection<InspecaoISP> Inspecoes { get; set; }
    }
}


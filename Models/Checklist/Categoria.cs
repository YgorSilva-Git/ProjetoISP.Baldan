using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoISP.Baldan.Models.Checklist
{
    [Table("CATEGORIAS")]
    public class Categoria
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("nome", TypeName = "varchar(100)")]
        public string Nome { get; set; }

        public ICollection<ModeloChecklist> ModelosChecklist { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoISP.Baldan.Models.Checklist
{
    [Table("PerguntaChecklist")]
    public class PerguntaChecklist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TextoPergunta { get; set; }

        [ForeignKey("CategoriaPergunta")]
        public int CategoriaPerguntoId { get; set; }
        public CategoriaPergunta CategoriaPergunta { get; set; }

        public bool Ativo { get; set; } = true;
    }
}
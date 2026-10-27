using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoISP.Baldan.Models.Checklist
{
    [Table("CategoriaPergunta")]
    public class CategoriaPergunta
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Nome { get; set; }

        public ICollection<PerguntaChecklist> Perguntas { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetoISP.Baldan.Models.Acesso;

namespace ProjetoISP.Baldan.Models.Setores
{
    [Table("SetorArea")]
    public class SetorArea
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; } // Ex: Solda, Usinagem

        public ICollection<Usuario> Usuarios { get; set; }
    }
}
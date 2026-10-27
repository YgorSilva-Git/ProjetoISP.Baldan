using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoISP.Baldan.Models.Acesso
{
    [Table("PerfilAcesso")]
    public class PerfilAcesso
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; } // Ex: SSMA, Líder

        public ICollection<Usuario> Usuarios { get; set; }
    }
}

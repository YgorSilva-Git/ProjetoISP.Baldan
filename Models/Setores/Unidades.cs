using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetoISP.Baldan.Models.Acesso;

namespace ProjetoISP.Baldan.Models.Setores
{     
    [Table("Unidade")]
    public class Unidade
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; } // Ex: Unidade 1, Unidade 2

        [Required]
        [StringLength(100)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(100)]
        public string Estado { get; set; }

        public ICollection<SetorArea> Setores { get; set; }
    }
}   


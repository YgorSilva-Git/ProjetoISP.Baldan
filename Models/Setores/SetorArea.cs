using ProjetoISP.Baldan.Models.Acesso;
using ProjetoISP.Baldan.Models.Inspeccoes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoISP.Baldan.Models.Setores
{
    [Table("SetorArea")]
    public class SetorArea
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Nome { get; set; } // Ex: Solda, Usinagem

        [Required]
        [StringLength(255)]
        public string url_foto_equipe { get; set; }

        [Column("data", TypeName = "date")]
        public DateTime data { get; set; }

        [ForeignKey("Unidades")]
        public int Unidadeid { get; set; }
        public Unidade Unidades { get; set; }

        public ICollection<Usuario> Acesso { get; set; }
        public ICollection<InspecaoISP> Inspeccoes { get; set; }
    }
}
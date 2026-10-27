using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetoISP.Baldan.Models.Setores;

namespace ProjetoISP.Baldan.Models.Acesso
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string Senha { get; set; }

        [ForeignKey("PerfilAcesso")]
        public int PerfilAcessoid { get; set; }
        public PerfilAcesso PerfilAcesso { get; set; }

        [ForeignKey("SetorArea")]
        public int? SetorAreaid { get; set; }
        public SetorArea SetorArea { get; set; }
    }
}
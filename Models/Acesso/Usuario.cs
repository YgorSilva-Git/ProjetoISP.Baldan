using ProjetoISP.Baldan.Models.Inspeccoes;
using ProjetoISP.Baldan.Models.PlanosAcao;
using ProjetoISP.Baldan.Models.Setores;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string Cargo { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string Senha { get; set; }

        [Required]
        [StringLength(255)]
        public string PerfildeAcesso { get; set; }

        [ForeignKey("SetorArea")]
        public int? SetorAreaid { get; set; }
        public SetorArea SetorArea { get; set; }

        public ICollection<InspecaoISP> InspecoesRealizadas { get; set; }
        public ICollection<PlanoAcao5W2H> PlanosAcaoResponsavel { get; set; }
    }
}
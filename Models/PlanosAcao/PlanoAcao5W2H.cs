using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetoISP.Baldan.Models.Inspeccoes;
using ProjetoISP.Baldan.Models.Acesso;

namespace ProjetoISP.Baldan.Models.PlanosAcao
{
    [Table("PLANOS_ACAO")]
    public class PlanoAcao5W2H
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("descricao_desvio", TypeName = "varchar(255)")]
        public string DescricaoDesvio { get; set; }

        [Column("acao_corretiva", TypeName = "varchar(255)")]
        public string AcaoCorretiva { get; set; }

        [Column("prazo", TypeName = "date")]
        public DateTime Prazo { get; set; }

        [Column("status", TypeName = "varchar(50)")]
        public string Status { get; set; }

        // Chaves Estrangeiras
        [Column("id_resultado_inspecao")]
        public int IdResultadoInspecao { get; set; }
        [ForeignKey("IdResultadoInspecao")]
        public ResultadoInspecao ResultadoInspecao { get; set; }

        [Column("id_responsavel_usuario")]
        public int IdResponsavelUsuario { get; set; }
        [ForeignKey("IdResponsavelUsuario")]
        public Usuario Responsavel { get; set; }

        public ICollection<HistoricoPrazo5W2H> HistoricoPrazos { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoISP.Baldan.Models.PlanosAcao
{
    [Table("HISTORICO_PLANOS_ACAO")]
    public class HistoricoPrazo5W2H
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("Prazo_Anterior", TypeName = "date")]
        public DateTime PrazoAnterior { get; set; }

        [Column("Novo_Prazo", TypeName = "date")]
        public DateTime NovoPrazo { get; set; }

        [Column("Motivo_Alteracao", TypeName = "varchar(255)")]
        public string MotivoAlteracao { get; set; }

        
        [Column("Data_Alteracao", TypeName = "datetime")]
        public DateTime DataAlteracao { get; set; } = DateTime.Now;

        
        [Column("id_planos_acao")]
        public int IdPlanosAcao { get; set; }

        [ForeignKey("IdPlanosAcao")]
        public PlanoAcao5W2H PlanoAcao { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoISP.Baldan.Models.PlanosAcao
{
    [Table("HistoricoPrazo5W2H")]
    public class HistoricoPrazo5W2H
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("PlanoAcao5W2H")]
        public int PlanoAcao5W2Hid { get; set; }
        public PlanoAcao5W2H PlanoAcao5W2H { get; set; }

        public DateTime PrazoAnterior { get; set; }
        public DateTime NovoPrazo { get; set; }
        public string MotivoAlteracao { get; set; }
        public DateTime DataModificacao { get; set; } = DateTime.Now;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoISP.Baldan.Models.PlanosAcao
{
    [Table("PlanoAcao5W2H")]
    public class PlanoAcao5W2H
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("NaoConformidade")]
        public int NaoConformidadeid { get; set; }
        public NaoConformidade NaoConformidade { get; set; }

        public string OQueSeraFeito { get; set; }
        public string ComoSeraRealizada { get; set; }
        public string OndeSeraRealizada { get; set; }
        public DateTime PrazoLimite { get; set; }
        [StringLength(100)]
        public string Responsavel { get; set; }
        public decimal CustoEstimado { get; set; }
        [StringLength(50)]
        public string Status { get; set; } // Ex: Em Ajuste, Aprovado
        public string JustificativaRecusa { get; set; }

        public ICollection<EvidenciaFotografica> Evidencias { get; set; }
        public ICollection<HistoricoPrazo5W2H> HistoricosPrazo { get; set; }
    }
}
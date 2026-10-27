using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetoISP.Baldan.Models.Acesso;
using ProjetoISP.Baldan.Models.Setores;

namespace ProjetoISP.Baldan.Models.Inspeccoes
{
    [Table("InspecaoISP")]
    public class InspecaoISP
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("SetorArea")]
        public int SetorAreaid { get; set; }
        public SetorArea SetorArea { get; set; }

        [ForeignKey("Usuario")]
        public int Usuarioid { get; set; }
        public Usuario Usuario { get; set; }

        public DateTime DataInspecao { get; set; } = DateTime.Now;
        public bool EhRetroativo { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; } // Ex: Aberta, Finalizada

        public ICollection<ParticipanteInspecao> Participantes { get; set; }
        public ICollection<RespostaChecklist> Respostas { get; set; }
    }
}
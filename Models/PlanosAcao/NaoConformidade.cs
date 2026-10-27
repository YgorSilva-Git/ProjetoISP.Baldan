using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetoISP.Baldan.Models.Inspeccoes;

namespace ProjetoISP.Baldan.Models.PlanosAcao
{
    [Table("NaoConformidade")]
    public class NaoConformidade
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("RespostaChecklist")]
        public int RespostaChecklistid { get; set; }
        public RespostaChecklist RespostaChecklist { get; set; }

        [Required]
        public string DescricaoCausa { get; set; }

        public DateTime DataOcorrencia { get; set; } = DateTime.Now;
        public int ContadorReincidencia { get; set; }
    }
}
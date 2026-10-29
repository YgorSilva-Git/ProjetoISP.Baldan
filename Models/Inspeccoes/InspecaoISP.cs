using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetoISP.Baldan.Models.Acesso;
using ProjetoISP.Baldan.Models.Setores;
using ProjetoISP.Baldan.Models.Checklist;

namespace ProjetoISP.Baldan.Models.Inspeccoes
{
    [Table("INSPECOES")]
    public class InspecaoISP
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("data_hora_inicio", TypeName = "datetime")]
        public DateTime DataHoraInicio { get; set; }

        [Column("data_hora_fim", TypeName = "datetime")]
        public DateTime? DataHoraFim { get; set; }

        [Column("status", TypeName = "varchar(50)")]
        public string Status { get; set; }

        // Chaves Estrangeiras
        [Column("id_modelo_checklist")]
        public int IdModeloChecklist { get; set; }
        [ForeignKey("IdModeloChecklist")]
        public ModeloChecklist ModeloChecklist { get; set; }

        [Column("id_inspetor_usuario")]
        public int IdInspetorUsuario { get; set; }
        [ForeignKey("IdInspetorUsuario")]
        public Usuario Inspetor { get; set; }

        [Column("id_setor")]
        public int IdSetor { get; set; }
        [ForeignKey("IdSetor")]
        public SetorArea Setor { get; set; }

        public ICollection<ResultadoInspecao> Resultados { get; set; }
    }
}
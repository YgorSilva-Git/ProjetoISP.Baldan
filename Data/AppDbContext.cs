using Microsoft.EntityFrameworkCore;
using ProjetoISP.Baldan.Models.Acesso;
using ProjetoISP.Baldan.Models.Setores;
using ProjetoISP.Baldan.Models.Checklist;
using ProjetoISP.Baldan.Models.Inspeccoes;
using ProjetoISP.Baldan.Models.PlanosAcao;

namespace ProjetoISP.Baldan.Data
{
    public class AppDbContext : DbContext
    {
        // Construtor padrão utilizado pela aplicação ASP.NET Core
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Construtor sem parâmetros (necessário para o gerador de Migrations em tempo de design)
        public AppDbContext()
        {
        }

        // Configuração de fallback para quando as Migrations forem executadas via linha de comandos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=127.0.0.1;Port=3306;Database=BaldanISP_DB;Uid=root;Pwd=;";
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }

        // Tabela de Acesso
        public DbSet<PerfilAcesso> PerfisAcesso { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        // Tabela de Setores
        public DbSet<SetorArea> SetoresAreas { get; set; }

        // Tabelas de Checklist
        public DbSet<CategoriaPergunta> CategoriasPerguntas { get; set; }
        public DbSet<PerguntaChecklist> PerguntasChecklist { get; set; }
        public DbSet<SetorPergunta> SetoresPerguntas { get; set; }

        // Tabelas de Inspeções
        public DbSet<InspecaoISP> InspecoesISP { get; set; }
        public DbSet<ParticipanteInspecao> ParticipantesInspecao { get; set; }
        public DbSet<RespostaChecklist> RespostasChecklist { get; set; }

        // Tabelas de Não Conformidades e Planos de Ação
        public DbSet<NaoConformidade> NaoConformidades { get; set; }
        public DbSet<PlanoAcao5W2H> PlanosAcao5W2H { get; set; }
        public DbSet<EvidenciaFotografica> EvidenciasFotograficas { get; set; }
        public DbSet<HistoricoPrazo5W2H> HistoricosPrazos5W2H { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Chave primária composta da tabela associativa SetorPergunta
            modelBuilder.Entity<SetorPergunta>()
                .HasKey(sp => new { sp.SetorAreaid, sp.PerguntaChecklistid });
        }
    }
}
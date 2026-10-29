using Microsoft.EntityFrameworkCore;
using ProjetoISP.Baldan.Models;
using ProjetoISP.Baldan.Models.Setores;
using ProjetoISP.Baldan.Models.Acesso;
using ProjetoISP.Baldan.Models.Checklist;
using ProjetoISP.Baldan.Models.Inspeccoes;
using ProjetoISP.Baldan.Models.PlanosAcao;

namespace ProjetoISP.Baldan.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Unidade> Unidades { get; set; }
        public DbSet<SetorArea> Setores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ModeloChecklist> ModelosChecklist { get; set; }
        public DbSet<ItemChecklist> ItensChecklist { get; set; }
        public DbSet<InspecaoISP> Inspecoes { get; set; }
        public DbSet<ResultadoInspecao> ResultadosInspecoes { get; set; }
        public DbSet<PlanoAcao5W2H> PlanosAcao { get; set; }
        public DbSet<HistoricoPrazo5W2H> HistoricosPlanosAcao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=127.0.0.1;Port=3306;Database=BaldanISP_DB;Uid=root;Pwd=;";
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }
    }
}
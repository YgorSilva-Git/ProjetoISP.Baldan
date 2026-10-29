using Microsoft.EntityFrameworkCore;
using ProjetoISP.Baldan.Data;

var builder = WebApplication.CreateBuilder(args);

// Configuração do contexto do banco de dados MySQL
var connectionString = builder.Configuration.GetConnectionString("ConexaoMySQL");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Adiciona os serviços do padrão MVC (Controllers e Views)
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
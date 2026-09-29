using AppWebKamilly.Components;
using AppWebKamilly.Configs;
using AppWebKamilly.DAO;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorComponents()
 .AddInteractiveServerComponents();
// Configuração da Conexão com o Banco de Dados MySQL
builder.Services.AddScoped<Conexao>();
builder.Services.AddScoped<ProcessoDAO>();
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
 app.UseExceptionHandler("/Error", createScopeForErrors:
true);
}
app.UseStatusCodePagesWithReExecute("/not-found", createSco
peForStatusCodePages: true);
app.UseAntiforgery();
app.MapStaticAssets();
app.MapRazorComponents<App>()
 .AddInteractiveServerRenderMode();
app.Run();
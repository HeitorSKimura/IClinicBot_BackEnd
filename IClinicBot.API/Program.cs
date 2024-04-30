using IClinicBot.Infra.SqlServer;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryCadastroContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;
using IClinicBot.Infra.SqlServer.Repositories.RepositoryCadastroContext;
using IClinicBot.Infra.SqlServer.Repositories.RepositoryConsultaContext;

var builder = WebApplication.CreateBuilder(args);

// Injection Of Controll
// CadastroContext
builder.Services.AddScoped<IRepositoryMedico, RepositoryMedico>();
builder.Services.AddScoped<IRepositoryPaciente, RepositoryPaciente>();
// ConsultaContext
builder.Services.AddScoped<IRepositoryConsulta, RepositoryConsulta>();
builder.Services.AddScoped<IRepositoryConsultaChatBot, RepositoryConsultaChatBot>();
builder.Services.AddScoped<IRepositoryConsultaPresencial, RepositoryConsultaPresencial>();
builder.Services.AddScoped<IRepositoryEndereco, RepositoryEndereco>();
builder.Services.AddScoped<IRepositoryExame, RepositoryExame>();
builder.Services.AddScoped<IRepositoryMedicoConsulta, RepositoryMedicoConsulta>();
builder.Services.AddScoped<IRepositoryMedicoExame, RepositoryMedicoExame>();
// SqlContext
builder.Services.AddScoped<SqlServerContext, SqlServerContext>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuration Cors
app.UseCors("corsapp");
app.UseCors(c =>
{
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using IClinicBot.Application.API.Services;
using IClinicBot.Application.API.Services.ControllerCadastroContext;
using IClinicBot.Domain.Interfaces;
using IClinicBot.Domain.Interfaces.IServicesCadastroContext;
using IClinicBot.Infra.SqlServer;
using IClinicBot.Infra.SqlServer.Interfaces;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryCadastroContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;
using IClinicBot.Infra.SqlServer.Repositories;
using IClinicBot.Infra.SqlServer.Repositories.RepositoryCadastroContext;
using IClinicBot.Infra.SqlServer.Repositories.RepositoryConsultaContext;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


var key = Encoding.ASCII.GetBytes("12345678901234567890123456789012345678901234567890123456789012345678901234567890");
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

// Injection Of Controll
//Services
builder.Services.AddScoped<IServiceContato, ServiceContato>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ITokenService, TokenService>();

// CadastroContext
builder.Services.AddScoped<IRepositoryMedico, RepositoryMedico>();
builder.Services.AddScoped<IRepositoryPaciente, RepositoryPaciente>();
builder.Services.AddScoped<IRepositoryContato, RepositoryContato>();
builder.Services.AddScoped<IAuthRepository, AuthRepository>();

// ConsultaContext
builder.Services.AddScoped<IRepositoryConsulta, RepositoryConsulta>();
builder.Services.AddScoped<IRepositoryConsultaChatBot, RepositoryConsultaChatBot>();
builder.Services.AddScoped<IRepositoryConsultaPresencial, RepositoryConsultaPresencial>();
builder.Services.AddScoped<IRepositoryEndereco, RepositoryEndereco>();
builder.Services.AddScoped<IRepositoryExame, RepositoryExame>();
builder.Services.AddScoped<IRepositoryMedicoConsulta, RepositoryMedicoConsulta>();
builder.Services.AddScoped<IRepositoryMedicoExame, RepositoryMedicoExame>();
builder.Services.AddScoped<IRepositoryAgenda, RepositoryAgenda>();
builder.Services.AddScoped<IRepositoryAgendaChatBot, RepositoryAgendaChatBot>();
builder.Services.AddScoped<IRepositoryAgendaMedico, RepositoryAgendaMedico>();
// SqlContext
builder.Services.AddScoped<SqlServerContext, SqlServerContext>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "AdmMaster API",
        Version = $"v1",
        Description = "API para consumo de dados do Front em Vue"
    });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"Autenticação por token JWT. Entre com o valor no formato: Bearer SEU_TOKEN",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header,
            },
            new List<string>()
        }
    });
});

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



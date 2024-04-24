using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryCadastroContext;

var builder = WebApplication.CreateBuilder(args);

// Injection Of Controll

// CadastroContext
builder.Services.AddScoped<IRepositoryMedico>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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

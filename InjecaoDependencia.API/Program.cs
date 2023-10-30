using InjecaoDependencia.API.Models;
using InjecaoDependencia.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Singleton ele sempre � mantido o estado dele
//builder.Services.AddSingleton<ObjetoDI>();
//builder.Services.AddScoped<ObjetoDI>();

// Scoped nao altera o estado do objeto

builder.Services.AddTransient<ObjetoDI>();
builder.Services.AddTransient<TesteService>();


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

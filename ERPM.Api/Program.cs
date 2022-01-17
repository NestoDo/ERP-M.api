using ERPM.Api.Repository;
using ERPM.Api.Repository.Interfaces;
using ERPM.Api.Services;
using ERPM.Api.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddTransient<IUsuarioService, UsuarioService>()
    .AddTransient<IUsuarioRepository, UsuarioRepository>();

var app = builder.Build();

// Configuration

IConfiguration configuration = app.Configuration;

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

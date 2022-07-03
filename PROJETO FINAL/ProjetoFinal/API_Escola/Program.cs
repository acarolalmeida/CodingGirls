using Microsoft.EntityFrameworkCore;
using API_Escola.Context;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Contexto de desenvolvimento
//builder.Services.AddDbContext<API_EscolaContext>(opt => opt.UseInMemoryDatabase("API_Escola"));
builder.Services.AddDbContext<API_EscolaContext>(opt => opt.UseLazyLoadingProxies().UseSqlServer(@"Server = tcp:projetofinal-codinggirls.database.windows.net,1433; Initial Catalog = Escola; Persist Security Info = False; User ID = root_escola; Password = abc123456.; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"));
 
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

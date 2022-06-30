using Microsoft.EntityFrameworkCore;
using API_Escola.Context;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Contexto de desenvolvimento
//builder.Services.AddDbContext<API_EscolaContext>(opt => opt.UseInMemoryDatabase("API_Escola"));
builder.Services.AddDbContext<API_EscolaContext>(opt => opt.UseSqlServer(@"Data Source = (LocalDb)\MSSQLLocalDB; Initial Catalog = Escola; User ID = root; Password = 123456789"));

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

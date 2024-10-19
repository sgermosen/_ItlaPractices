using Microsoft.EntityFrameworkCore;
using Prestify.Domain;
using Prestify.Domain.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<PrestifyDbContext>(p =>
    p.UseSqlite(builder.Configuration.GetConnectionString("PrestifysqLitestr")));
//builder.Services.AddDbContext<PrestifyDbContext>(p =>
//    p.UseSqlServer(builder.Configuration.GetConnectionString("PrestifyStrConnection")));

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


using PaqJet.Domain;
using Microsoft.EntityFrameworkCore;
using PaqJet.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<PaqJetDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PaqJetStrDbConnection") ?? throw new InvalidOperationException("Connection string 'PaqJetDbContext' not found.")));

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

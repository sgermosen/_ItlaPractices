using ExpressTaste.Domain;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ExpressTasteDbContext>(p =>
    p.UseSqlServer(builder.Configuration.GetConnectionString("ExpressTasteStrConnectionSql")));

//builder.Services.AddDbContext<ExpressTasteDbContext>(p =>
//    p.UseSqlite(builder.Configuration.GetConnectionString("ExpressTasteStrConnectionSqLite")));

builder.Services.AddControllers();
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

using ExpressTaste.Infraestructure.Interfaces;
using ExpressTaste.Infraestructure.Repositories;
using ExpressTaste.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ExpressTasteDbContext>(p =>
    p.UseSqlServer(builder.Configuration.GetConnectionString("ExpressTasteStrConnectionSql")));

//builder.Services.AddDbContext<ExpressTasteDbContext>(p =>
//    p.UseSqlite(builder.Configuration.GetConnectionString("ExpressTasteStrConnectionSqLite")));
//builder.Services.AddTransient<CustomerRepository>();
builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowSpecificOrigins",
        policy =>
        {
            policy.WithOrigins("https://localhost:7167")
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("AllowSpecificOrigins");

app.MapControllers();

app.Run();

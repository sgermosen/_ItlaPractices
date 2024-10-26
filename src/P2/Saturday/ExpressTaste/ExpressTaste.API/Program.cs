using ExpressTaste.Domain;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ExpressTasteDbContext>(p =>
    p.UseSqlServer(builder.Configuration.GetConnectionString("ExpressTasteStrConnectionSql")));

//builder.Services.AddDbContext<ExpressTasteDbContext>(p =>
//    p.UseSqlite(builder.Configuration.GetConnectionString("ExpressTasteStrConnectionSqLite")));
 

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowSpecificOrigins",
        policy =>
        {
            policy.WithOrigins("https://localhost:7167")
            .AllowAnyMethod()
            .AllowAnyHeader();
            //.SetIsOriginAllowedToAllowWildcardSubdomains();
        });
});

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

app.UseCors("AllowSpecificOrigins");

app.MapControllers();

app.Run();

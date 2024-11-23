
using Microsoft.EntityFrameworkCore;
using Prestify.Infrastructure;
using Prestify.Infrastructure.Exceptions;
using Prestify.Infrastructure.Interfaces;
using Prestify.Infrastructure.Repositories;
using Prestify.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddDbContext<PrestifyDbContext>(p =>
//    p.UseSqlite(builder.Configuration.GetConnectionString("PrestifysqLitestr")));
builder.Services.AddDbContext<PrestifyDbContext>(p =>
    p.UseSqlServer(builder.Configuration.GetConnectionString("PrestifyStrConnection")));

builder.Services.AddTransient<IPersonRepository, PersonRepository>();
builder.Services.AddTransient<ILoanRepository, LoanRepository>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient(typeof(IRepository<>), typeof(GenericRepository<>));

//builder.Services.AddScoped<PersonRepository>();
//builder.Services.AddSingleton<PersonRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var MyAllowSpecificOrigins = "AllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("https://localhost:7218")
            .AllowAnyMethod()
            .AllowAnyHeader();
            //.SetIsOriginAllowedToAllowWildcardSubdomains();
        });
});

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowSpecificOrigins",
//        policy =>
//        {
//            policy.WithOrigins(appSettings.CorsSettings.AllowedOrigins)
//                  .WithMethods(appSettings.CorsSettings.AllowedMethods)
//                  .WithHeaders(appSettings.CorsSettings.AllowedHeaders);
//        });
//});


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

app.UseCors(MyAllowSpecificOrigins);

app.Run();


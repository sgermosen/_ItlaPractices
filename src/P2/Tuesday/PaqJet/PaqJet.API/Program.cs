using EmployeeJet.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using PaqJet.Infrastructure;
using PaqJet.Infrastructure.Interfaces;
using PaqJet.Persistence;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowOriginFrom",
        policy =>
        {
            policy.WithOrigins("https://localhost:7226", "")
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
});
// Add services to the container.
builder.Services.AddDbContext<PaqJetDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PaqJetStrDbConnection") ?? throw new InvalidOperationException("Connection string 'PaqJetDbContext' not found.")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//unit of works
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

//repositories
builder.Services.AddTransient<ICustomerRepository,CustomerRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient(typeof(IRepository<>), typeof(GenericRepository<>));

//builder.Services.AddTransient<IPaqRepository, PaqRepository>();
//services
//builder.Services.AddTransient<CustomerService>();
//builder.Services.AddTransient<ICustomerService, CustomerService>();
builder.Services.AddTransient<ICustomerService, CustomerService>();

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
app.UseCors("AllowOriginFrom");

app.Run();

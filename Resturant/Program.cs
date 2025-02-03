using Microsoft.EntityFrameworkCore;
using Resturant.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var constr = builder.Configuration.GetConnectionString("ConStr");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(constr));

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
app.MapControllers(); // تأكد من أنك قمت بتعيين الـ Controllers هنا

app.Run();

using CRUDWebAPI.Database;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PersonDetailsContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnect")));

builder.Services.AddCors((corsOptions) =>
{
    corsOptions.AddPolicy("Mypolicy", (policyoptions) =>
    {
        policyoptions.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Mypolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();

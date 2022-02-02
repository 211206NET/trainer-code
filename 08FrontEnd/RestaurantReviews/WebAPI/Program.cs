using DL;
using BL;
using DL.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.WithOrigins("*");
        });
});

// Add services to the container.
builder.Services.AddMemoryCache();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// builder.Services.AddDbContext<RRDBContext>(options => options.UseNpgsql(
    // builder.Configuration.GetConnectionString("PostgreRRDB")));
builder.Services.AddDbContext<RRDBContext>(options => options.UseNpgsql(
    builder.Configuration.GetConnectionString("PostgreRRDB")));
//Registering our deps here for dependency injection
//Different ways to add dependency
//Scoped, Singleton, Transient
builder.Services.AddScoped<IRepo, EFRepo>();
builder.Services.AddScoped<IBL, RRBL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

//insert CORS middleware here
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();

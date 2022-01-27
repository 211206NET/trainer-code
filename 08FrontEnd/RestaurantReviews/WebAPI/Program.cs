using DL;
using BL;
using DL.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMemoryCache();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// builder.Services.AddDbContext<RRDBContext>(options => options.UseNpgsql(
    // builder.Configuration.GetConnectionString("PostgreRRDB")));
builder.Services.AddDbContext<DL.Entities.RestaurantDBContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("RRDB")));
//Registering our deps here for dependency injection
//Different ways to add dependency
//Scoped, Singleton, Transient
builder.Services.AddScoped<IRepo, DBFirstRepo>();
builder.Services.AddScoped<IBL, RRBL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

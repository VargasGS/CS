using Microsoft.EntityFrameworkCore;
using Infrastructure;
using Domain.Entiti;
using Domain.Interfaces.Infrastructure;
using Infrastructure.Repositories;
using Domain.Interfaces.Application;
using Application.Sevices;
using AutoMapper;
using SGE.Catalogos.Services.Infrastructure.MappingProfiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<CoopesaludActivacionRecetaContext>(
    opciones =>
    {
        opciones.UseSqlServer(builder.Configuration.GetConnectionString("Coopesalud")); 
    });

builder.Services.AddScoped<IEstadoRecetaRepository, EstadoRecetaRepository>();
builder.Services.AddScoped<ILugarRetiroRepository, LugarRetiroRepository>();
builder.Services.AddScoped<ILugarAtencionRepository, LugarAtencionRepository>();

builder.Services.AddScoped<IEstadoRecetaService, EstadoRecetaService>();
builder.Services.AddScoped<ILugarRetiroService, LugarRetiroService>();
builder.Services.AddScoped<ILugarAtencionService, LugarAtencionService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(a=> a.AddPolicy("corspolicy", build =>
{
    build.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
}));

//Configurar el Maping del AutoMapper
var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new EstadoRecetaProfile());
    cfg.AddProfile(new LugarRetiroProfile());
    cfg.AddProfile(new LugarAtencionProfile());

    cfg.AllowNullCollections = false;
});
var mapper = config.CreateMapper(); builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(typeof(Program));
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());



var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("corspolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

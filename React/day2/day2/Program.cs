﻿using day2.Data;
using day2.Repository;
using day2.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DatabaseContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("Myconnection")));

var listHttp = builder.Configuration.GetSection("AllowOrigins").Get<string[]>();

builder.Services.AddScoped<IStudentRepo, StudentService>();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("MyCors", policy =>
    {
        policy.WithOrigins(listHttp).AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MyCors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

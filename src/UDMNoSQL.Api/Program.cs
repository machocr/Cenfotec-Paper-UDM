using System.Text.Json.Serialization;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using UDMNoSQL.Api.Data;
using UDMNoSQL.Api.Data.Interfaces;
using UDMNoSQL.Api.Models;
using UDMNoSQL.Api.Repositories;
using UDMNoSQL.Api.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped(typeof(IPartyContext<>), typeof(PartyContext<>));
builder.Services.AddScoped<IPartyRelationshipContext, PartyRelationshipContext>();
builder.Services.AddScoped(typeof(IPartyRepository<>), typeof(PartyRepository<>));
builder.Services.AddScoped(typeof(IPartyRelationshipRepository<>), typeof(PartyRelationshipRepository<>));

builder.Services.AddControllers()
    .AddJsonOptions(o => o.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHealthChecks()
                    .AddMongoDb(builder.Configuration["DatabaseSettings:ConnectionString"], "MongoDb Health", HealthStatus.Degraded);

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

app.Run();


using System.Runtime.CompilerServices;
using PortfolioBackend.Api.Dtos;
using PortfolioBackend.Apis.Dtos;
using PortfolioBackend.Apis.Endpoints;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
var app = builder.Build();

app.MapMusicEndpoints();
app.Run();


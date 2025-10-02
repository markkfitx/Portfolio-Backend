using System.Runtime.CompilerServices;
using PortfolioBackend.Api.Dtos;
using PortfolioBackend.Apis.Data;
using PortfolioBackend.Apis.Endpoints;


var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("MusicPlaylist");
builder.Services.AddSqlite<MusicPlaylistContext>(connString);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
var app = builder.Build();

app.MapMusicEndpoints();
// Update the Database on startup automatically
app.MigrateDB();
app.Run();


using PortfolioBackend.Api.Dtos;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
var app = builder.Build();

List<MusicDto> songs = [
    new (
        1,
        "Relationship",
        "Christian & Gospel",
        "Phil Wichkham"
    ),
    new (
        2,
        "Forever Again",
        "Country",
        "Matt Hansen"
    ),
    new (
        3,
        "Feel Something",
        "EDM",
        "Illenium"
    )
];

app.MapGet("/", () => );

app.Run();


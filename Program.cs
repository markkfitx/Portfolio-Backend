using System.Runtime.CompilerServices;
using PortfolioBackend.Api.Dtos;
using PortfolioBackend.Apis.Dtos;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
var app = builder.Build();
const string GetSongEndpoitName = "GetSong";
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

// GET /songs
app.MapGet("songs", () => songs);

// GET /songs/1
app.MapGet("songs/{id}", (int id) =>
{
    // Either recieve a song or null
    MusicDto? song = songs.Find(song => song.Id == id);
    return song is null ? Results.NotFound() : Results.Ok(song);
})
.WithName(GetSongEndpoitName);

// POST /songs/
app.MapPost("songs", (CreateSongDto newSong) =>
{
    MusicDto song = new(
        songs.Count + 1,
        newSong.Name,
        newSong.Genre,
        newSong.Artist
    );
    songs.Add(song);

    return Results.CreatedAtRoute(GetSongEndpoitName, new { id = song.Id }, song);
});

// PUT /songs/
app.MapPut("songs/{id}", (int id, UpdateSongsDto updateSong) =>
{
    var index = songs.FindIndex(song => song.Id == id);
    if (index == -1)
    {
        return Results.NotFound();
    }
    songs[index] = new MusicDto(
        id,
        updateSong.Name,
        updateSong.Genre,
        updateSong.Artist
    );

    return Results.NoContent();
});

// DELETE /songs/

app.MapDelete("songs/{id}", (int id) =>
{
    songs.RemoveAll(song => song.Id == id);
    return Results.NoContent();
});

app.Run();


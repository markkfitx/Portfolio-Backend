namespace PortfolioBackend.Api.Dtos;

public record class CreateSongDto(
    // Dont need the ID
    string Name,
    string Genre,
    string Artist
);
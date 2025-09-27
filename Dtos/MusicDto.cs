namespace PortfolioBackend.Api.Dtos;

public record class MusicDto(
    int Id,
    string Name,
    string Genre,
    string Artist
);
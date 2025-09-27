namespace PortfolioBackend.Apis.Dtos;

public record class UpdateSongsDto(
    // Dont need the ID
    string Name,
    string Genre,
    string Artist
);
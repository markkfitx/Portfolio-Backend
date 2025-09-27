using System.ComponentModel.DataAnnotations;

namespace PortfolioBackend.Apis.Dtos;

public record class UpdateSongsDto(
    // Dont need the ID
    [Required][StringLength(128)] string Name,
    [Required][StringLength(128)] string Genre,
    [Required][StringLength(128)] string Artist
);
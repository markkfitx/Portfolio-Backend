using System.ComponentModel.DataAnnotations;

namespace PortfolioBackend.Api.Dtos;

public record class CreateSongDto(
    // Dont need the ID
    [Required][StringLength(128)] string Name,
    [Required][StringLength(128)] string Genre,
    [Required][StringLength(128)] string Artist
);
namespace PortfolioBackend.Apis.Entities;

public class Song
{
    public int Id { get; set; }
    public required string Name { get; set; }

    //Genre
    public int GenreId { get; set; }
    public Genre? Genre { get; set; }

    public required string Artist { get; set; }
    
}
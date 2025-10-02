using Microsoft.EntityFrameworkCore;
using PortfolioBackend.Apis.Entities;

namespace PortfolioBackend.Apis.Data;

public class MusicPlaylistContext(DbContextOptions<MusicPlaylistContext> options) : DbContext(options)
{
    public DbSet<Song> Songs => Set<Song>();
    public DbSet<Genre> Genres => Set<Genre>();
}
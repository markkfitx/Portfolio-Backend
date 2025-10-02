using System;
using Microsoft.EntityFrameworkCore;

namespace PortfolioBackend.Apis.Data;

public static class DataExtensions
{
    public static void MigrateDB(this WebApplication app)
    {
        // get an instance of a scope
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<MusicPlaylistContext>();
        dbContext.Database.Migrate();
    }
}

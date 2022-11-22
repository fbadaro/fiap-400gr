using Fiap.FourGrams.Catalog.Data;
using Microsoft.EntityFrameworkCore;

namespace Fiap.FourGrams.Catalog.API.Config;

public static class AppMigrationHelper
{
    public static WebApplication MigrateDatabase(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
        {
            using var appContext = scope.ServiceProvider.GetRequiredService<FourGramsContext>();

            try
            {
                appContext.Database.Migrate();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        return app;
    }
}

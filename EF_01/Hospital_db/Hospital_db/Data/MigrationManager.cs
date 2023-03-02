using Microsoft.EntityFrameworkCore;

namespace Hospital_db.Data
{
    // Для створення початкової міграції відразу після запуску програми
    public static class MigrationManager
    {
        public static WebApplication MigrateDatabase(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                using (var appContext = scope.ServiceProvider.GetRequiredService<HospitalContext>())
                {
                    try
                    {
                        appContext.Database.Migrate();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception
                            (DateTime.Now + " -> " +
                            "Error in: [MigrationManager].[MigrateDatabase]\n" +
                            ex.Message);
                    }
                }
            }

            return app;
        }
    }
}

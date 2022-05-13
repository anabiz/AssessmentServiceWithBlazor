
using Infrastructure.Data.DatabaseContext;

using Microsoft.EntityFrameworkCore.Design;

namespace API.ContextFactory;

public class AppDbContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .AddJsonFile($"appsettings.Development.json", reloadOnChange: true, optional: true)
            .AddJsonFile($"appsettings.Production.json", reloadOnChange: true, optional: true)
            // .AddUserSecrets(Assembly.GetAssembly(typeof(Program)))
            .AddEnvironmentVariables()
            .Build();

        var builder = new DbContextOptionsBuilder<DataContext>()
            .UseSqlServer(config.GetConnectionString("DefaultConnection"), 
                b => b.MigrationsAssembly("BlazorApp1.Server"));

        return new DataContext(builder.Options);
    }
}
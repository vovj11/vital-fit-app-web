using Microsoft.EntityFrameworkCore;
using VitalFitAppWeb.Models;

namespace VitalFitAppWeb.Data;

public class VitalFitDbContext : DbContext
{
    public DbSet<Produto> Produto { get; set; }
    public DbSet<Marca> Marca { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var stringConn = config.GetConnectionString("StringConn");
        optionsBuilder.UseSqlServer(stringConn);
    }
}

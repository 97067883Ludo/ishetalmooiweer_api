using Microsoft.EntityFrameworkCore;

namespace ishetalmooiweer_api.Data;

public class DbContext : Microsoft.EntityFrameworkCore.DbContext
{

    private readonly IConfiguration _configuration;

    public DbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("default"));
    }
}
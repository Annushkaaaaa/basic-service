using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

//Use next command in Package Manager Console to update Dev env DB
//PM> $env:ASPNETCORE_ENVIRONMENT = 'IDE'; Update-Database
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public AppDbContext()
    {
    }

    public virtual DbSet<BasicEntity> Photos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
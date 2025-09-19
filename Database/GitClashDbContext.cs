using GitClash.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GitClash.Database;

public class GitClashDbContext : IdentityDbContext<User>
{
    public DbSet<User> Users => Set<User>();


    public GitClashDbContext(DbContextOptions<GitClashDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>(entity => { entity.HasIndex(u => u.GitHubId).IsUnique(); });
    }
}
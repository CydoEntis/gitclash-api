using GitClash.Domain;
using Microsoft.EntityFrameworkCore;

namespace GitClash.Infrastructure;

public class GitClashDbContext : DbContext
{
    public GitClashDbContext(DbContextOptions<GitClashDbContext> options) : base(options)
    {
    }


    public DbSet<User> User => Set<User>();
    public DbSet<Group> Group => Set<Group>();
    public DbSet<Activity> Activity => Set<Activity>();
}
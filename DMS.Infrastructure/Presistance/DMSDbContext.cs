using DMS.Domain;
using Microsoft.EntityFrameworkCore;

namespace DMS.Infrastructure;
public class DMSDbContext : DbContext
{
    public DMSDbContext(DbContextOptions<DMSDbContext> options) : base(options)
    {

    }
    public DbSet<User> Users { get; set; }
    public DbSet<Device> Devices { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(r => r.HasMany(r => r.Devices).WithOne(r => r.User).HasForeignKey(r => r.UserId));
    }
}


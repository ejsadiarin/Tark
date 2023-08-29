using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using TarkApi.Models;

namespace TarkApi.DAL;

public class TarkDbContext : DbContext
{
    public TarkDbContext(DbContextOptions<TarkDbContext> options) : base(options) { }
    
    public DbSet<Project> Projects => Set<Project>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Ticket> Tickets => Set<Ticket>();

    // create relationships here (1:1, 1:n, n:n)
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<User>()
        //                .HasOne<TodoUser>()
        //                .WithMany()
        //                .HasForeignKey(t => t.OwnerId)
        //                .HasPrincipalKey(u => u.UserName);
        
        base.OnModelCreating(modelBuilder);
    }
}
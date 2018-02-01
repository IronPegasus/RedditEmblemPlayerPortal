using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RedditEmblemPlayerPortal.Models.Users;

namespace RedditEmblemPlayerPortal.Data
{
  public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

      builder.Entity<xUserRole>()
        .HasKey(x => new { x.ID, x.RoleID });

      //Enforcing uniqueness on certain attributes
      builder.Entity<ApplicationUser>()
        .HasIndex(u => u.UserName)
        .IsUnique();

      builder.Entity<Role>()
        .HasIndex(r => r.Name)
        .IsUnique();
    }

    //public DbSet<ApplicationUser> Users { get; set; }
  }
}
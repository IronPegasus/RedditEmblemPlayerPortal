using Microsoft.EntityFrameworkCore;
using RedditEmblemPlayerPortal.Models;
using RedditEmblemPlayerPortal.Models.Teams;
using RedditEmblemPlayerPortal.Models.Users;

namespace RedditEmblemPlayerPortal.Data
{
  public class DatabaseContext : DbContext
  {
    public DatabaseContext(DbContextOptions options)
      : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      //Defining primary keys manually
      //Needed for many-to-many relationships - automation not yet supported by EFCore :(
      builder.Entity<xUserRole>()
        .HasKey(x => new { x.UserId, x.RoleId });

      builder.Entity<xTeamGM>()
        .HasKey(x => new { x.TeamId, x.UserId });

      builder.Entity<xTeamGMA>()
        .HasKey(x => new { x.TeamId, x.UserId });

      builder.Entity<xTeamReviewer>()
        .HasKey(x => new { x.TeamId, x.UserId });

      builder.Entity<CharacterStat>()
        .HasKey(x => new { x.CharacterId, x.TeamStatId });

      //Enforcing uniqueness on certain attributes
      builder.Entity<User>()
        .HasIndex(u => u.DiscordUserId)
        .IsUnique();

      builder.Entity<Role>()
        .HasIndex(r => r.Name)
        .IsUnique();
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Role> Roles { get; set; }

    public DbSet<Team> Teams { get; set; }
  }
}

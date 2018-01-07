using Microsoft.EntityFrameworkCore;
using RedditEmblemPlayerPortal.Models;
using RedditEmblemPlayerPortal.Models.Teams;
using RedditEmblemPlayerPortal.Models.Teams.System;
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

      builder.Entity<UnitStat>()
        .HasKey(x => new { x.CharacterId, x.TeamStatId });

      builder.Entity<xClassTag>()
        .HasKey(x => new { x.UnitClassId, x.TagId });

      builder.Entity<xTeamWeaponClass>()
        .HasKey(x => new { x.TeamId, x.WeaponClassId });

      builder.Entity<xUnitClassPromotion>()
        .HasKey(x => new { x.PromotesFrom, x.PromotesTo });

      //Enforcing uniqueness on certain attributes
      builder.Entity<User>()
        .HasIndex(u => u.DiscordUserId)
        .IsUnique();

      builder.Entity<Role>()
        .HasIndex(r => r.Name)
        .IsUnique();

      builder.Entity<WeaponClass>()
        .HasIndex(w => w.Name)
        .IsUnique();
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Role> Roles { get; set; }

    public DbSet<Team> Teams { get; set; }
  }
}

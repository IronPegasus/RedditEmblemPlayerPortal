using Microsoft.AspNetCore.Identity;
using RedditEmblemPlayerPortal.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedditEmblemPlayerPortal.Data
{
  public class ApplicationUser : IdentityUser
  {
    [Required]
    /// <summary>A DateTime the represents the last time a user logged into the app. Defaults to the current date.</summary>
    public DateTime LastLogin { get; set; } = DateTime.Now; //default date value

    [NotMapped]
    /// <summary>The user's *current* Discord username. Not saved in the database, but instead populated on login.</summary>
    public string DiscordUsername { get; set; }

    [NotMapped]
    /// <summary>The user's *current* Discord avatar. Not saved in the database, but instead populated on login.</summary>
    public string DiscordAvatar { get; set; }

    /// <summary>A list of Roles possessed by this user</summary>
    public virtual ICollection<xUserRole> Roles { get; set; }

    /// <summary>A list of Teams where the user is a GM</summary>
    //public virtual ICollection<xTeamGM> GMRoles { get; set; }

    /// <summary>A list of Teams where the user is a GMA</summary>
    //public virtual ICollection<xTeamGMA> GMARole { get; set; }

    /// <summary>A list of Teams where the user is a reviwer</summary>
    //public virtual ICollection<xTeamReviewer> ReviewerRoles { get; set; }
  }
}
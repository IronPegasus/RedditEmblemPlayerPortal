using RedditEmblemPlayerPortal.Models.Teams;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RedditEmblemPlayerPortal.Models.Users
{
  public class User
  {
    public int UserId { get; set; }

    [Required]
    /// <summary>The unique user id provided by the Discord API</summary>
    public string DiscordUserId { get; set; }

    [Required]
    /// <summary>A DateTime the represents the last time a user logged into the app. Defaults to the current date.</summary>
    public DateTime LastLogin { get; set; } = DateTime.Now; //default date value

    /// <summary>A list of Roles possessed by this user</summary>
    public virtual List<xUserRole> Roles { get; set; }

    /// <summary>A list of Teams where the user is a GM</summary>
    public virtual List<xTeamGM> GMRoles { get; set; }

    /// <summary>A list of Teams where the user is a GMA</summary>
    public virtual List<xTeamGMA> GMARole { get; set; }

    /// <summary>A list of Teams where the user is a reviwer</summary>
    public virtual List<xTeamReviewer> ReviewerRoles { get; set; }
  }
}

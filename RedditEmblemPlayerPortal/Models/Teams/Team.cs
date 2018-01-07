using RedditEmblemPlayerPortal.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedditEmblemPlayerPortal.Models.Teams
{
  public class Team
  {
    public int TeamId { get; set; }

    [Required, MinLength(1), MaxLength(3)]
    /// <summary>The most commonly used, official name for the team (ex. Team 'A')</summary>
    public string TeamName { get; set; }

    [MaxLength(32)]
    /// <summary>An alternative, longer name for the team (ex. Team 'Fairytale')</summary>
    public string TeamNickname { get; set; }

    [Required]
    /// <summary>The user that created the team</summary>
    public User CreatedBy { get; set; }

    [Required]
    /// <summary>The date and time on which the team instance was created</summary>
    public DateTime CreatedOn { get; set; }

    [Required]
    /// <summary>The user that currently owns the team</summary>
    public User OwnedBy { get; set; }

    [Required]
    public TeamStatus TeamStatus { get; set; }

    /// <summary>A list of GMs assigned to the team</summary>
    public virtual ICollection<xTeamGM> GMs { get; set; }

    /// <summary>A list of GMAs assigned to the team</summary>
    public virtual ICollection<xTeamGMA> GMAs { get; set; }

    /// <summary>A list of reviewers assigned to the team</summary>
    public virtual ICollection<xTeamReviewer> Reviewers { get; set; }

    /// <summary>A list of players assigned to this team</summary>
    public IEnumerable<TeamPlayer> Players { get; set; }

    /// <summary>A list of the stats for this team</summary>
    public IEnumerable<TeamStat> Stats { get; set; }
  }
}

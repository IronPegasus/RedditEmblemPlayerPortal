using RedditEmblemPlayerPortal.Data;
using RedditEmblemPlayerPortal.Models.Teams.System;
using RedditEmblemPlayerPortal.Models.Teams.System.Skills;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RedditEmblemPlayerPortal.Models.Teams
{
  public class Team
  {
    public int TeamId { get; set; }

    [Required, MinLength(1), MaxLength(3)]
    /// <summary>The most commonly used, official name for the team (ex. Team 'A')</summary>
    public string TeamName { get; set; }

    [Required, MinLength(1), MaxLength(32)]
    /// <summary>An alternative, longer name for the team (ex. Team 'Fairytale')</summary>
    public string TeamNickname { get; set; }

    [Required]
    /// <summary>The user that created the team</summary>
    public ApplicationUser CreatedBy { get; set; }

    [Required]
    /// <summary>The date and time on which the team instance was created</summary>
    public DateTime CreatedOn { get; set; }

    [Required]
    /// <summary>The user that currently owns the team</summary>
    public ApplicationUser OwnedBy { get; set; }

    [Required]
    public TeamStatus TeamStatus { get; set; }

    /// <summary>A list of GMs assigned to the team</summary>
    public virtual List<xTeamGM> GMs { get; set; }

    /// <summary>A list of GMAs assigned to the team</summary>
    public virtual List<xTeamGMA> GMAs { get; set; }

    /// <summary>A list of reviewers assigned to the team</summary>
    public virtual List<xTeamReviewer> Reviewers { get; set; }

    /// <summary>A list of players assigned to the team</summary>
    public List<TeamPlayer> Players { get; set; }

    /// <summary>A list of the classes available on the team</summary>
    public List<UnitClass> Classes { get; set; }

    public List<Skill> Skills { get; set; }

    /// <summary>A list of the stats for the team</summary>
    public List<TeamStat> Stats { get; set; }

    public virtual List<xTeamWeaponClass> WeaponClasses { get; set; }
  }
}

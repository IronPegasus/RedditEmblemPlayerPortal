import { Component, Input } from '@angular/core';

import { TeamCard } from '../../models/teams/team-card';

@Component({
  selector: 'team-card',
  templateUrl: './team-card.component.html',
  styleUrls: ['./team-card.component.css']
})
export class TeamCardComponent {
  @Input() teamInfo: TeamCard;
}

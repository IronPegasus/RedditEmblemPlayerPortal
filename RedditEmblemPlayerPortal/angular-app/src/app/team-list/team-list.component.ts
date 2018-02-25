import { Component, Input } from '@angular/core';
import { NgClass } from '@angular/common';

import { TeamCard } from '../../models/teams/team-card';

@Component({
  selector: 'team-list',
  templateUrl: './team-list.component.html',
  styles: []
})
export class TeamListComponent{
  @Input() listTitle: string;
  @Input() teams: TeamCard[];
  @Input() showAdd: boolean = false;

  isExpanded: boolean = true;

  toggleExpand(): void {
    this.isExpanded = !this.isExpanded;
  }
}

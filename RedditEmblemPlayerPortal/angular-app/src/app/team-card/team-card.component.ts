import { Component, Input } from '@angular/core';

@Component({
  selector: 'team-card',
  templateUrl: './team-card.component.html',
  styles: []
})
export class TeamCardComponent {
  @Input() teamLetter: string;
  @Input() teamGMs: string;
  @Input() currentActivity: string;
  @Input() appsOpen: boolean = false;
}

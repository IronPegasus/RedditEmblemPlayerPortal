import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'team-card',
  templateUrl: './team-card.component.html',
  styles: []
})
export class TeamCardComponent {
  @Input() teamLetter: string;
  @Input() teamGMs: string[];
}

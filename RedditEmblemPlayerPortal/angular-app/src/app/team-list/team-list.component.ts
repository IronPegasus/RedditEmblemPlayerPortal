import { Component, Input } from '@angular/core';
import { NgClass } from '@angular/common';

@Component({
  selector: 'team-list',
  templateUrl: './team-list.component.html',
  styles: []
})
export class TeamListComponent{
  @Input() listTitle: string;
  @Input() teams: any[];
  @Input() showAdd: boolean = false;
  isExpanded: boolean = true;

  toggleExpand(): void {
    this.isExpanded = !this.isExpanded;
  }
}

import { Component } from '@angular/core';
import { NgModel } from '@angular/forms';
import * as $ from 'jquery';

import { NewWorkshop } from '../../models/teams/new-workshop';
import { NewStatModalComponent } from '../new-stat-modal/new-stat-modal.component';
import { TeamStat } from '../../models/teams/system/teamstat';


@Component({
  selector: 'new-workshop-modal',
  templateUrl: './new-workshop-modal.component.html',
  styles: []
})
export class NewWorkshopModalComponent{
  workshop: NewWorkshop = new NewWorkshop();

  fromScratch(): void {
    $('#bodyStart').css("display", "none");
    $('#bodyFromScratch').css("display", "block");
  }

  catchTeamStatModalReturn(stat: TeamStat): void {
    this.workshop.addStat(stat);
  }

  removeGM(i: number): void {
    if (i > 0)
      this.workshop.removeGM(i);
  }

  removeStat(i: number): void { this.workshop.removeStat(i); }
}

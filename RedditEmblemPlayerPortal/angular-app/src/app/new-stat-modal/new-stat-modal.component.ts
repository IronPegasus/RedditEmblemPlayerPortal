import { Component, Output, EventEmitter } from '@angular/core';
import { NgModel } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { TeamStat } from '../../models/teams/system/teamstat';

@Component({
  selector: 'new-stat-modal',
  templateUrl: './new-stat-modal.component.html',
  styles: []
})
export class NewStatModalComponent{
  name: string;
  abbreviation: string;
  description: string;

  @Output() passData: EventEmitter<TeamStat> = new EventEmitter();

  onSubmit(): void {
    var stat = new TeamStat(this.name, this.abbreviation, this.description);
    this.passData.emit(stat);
    (<HTMLFormElement>$('#dataForm')[0]).reset();
    var ele = document.getElementById('newStatModal');
    (<any>$('#newStatModal')).modal('hide');
  }
}

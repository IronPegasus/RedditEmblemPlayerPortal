import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { AppComponent } from './app.component';
import { TeamCardComponent } from './team-card/team-card.component';
import { TeamListComponent } from './team-list/team-list.component';
import { NewWorkshopModalComponent } from './new-workshop-modal/new-workshop-modal.component';
import { NewStatModalComponent } from './new-stat-modal/new-stat-modal.component';

@NgModule({
  declarations: [
    AppComponent,
    TeamCardComponent,
    TeamListComponent,
    NewWorkshopModalComponent,
    NewStatModalComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    NgbModule.forRoot(),
  ],
  providers: [],
  entryComponents: [
    NewStatModalComponent
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

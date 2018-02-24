import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { TeamCardComponent } from './team-card/team-card.component';
import { TeamListComponent } from './team-list/team-list.component';


@NgModule({
  declarations: [
    AppComponent,
    TeamCardComponent,
    TeamListComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

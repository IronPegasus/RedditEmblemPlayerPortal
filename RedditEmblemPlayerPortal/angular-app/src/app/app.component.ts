import { Component } from '@angular/core';

import { TeamCard } from '../models/teams/team-card';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styles: []
})
export class AppComponent {
  myTeamTitle: string = "My Teams";
  myWorkshopTitle: string = "My Workshops";
  allTeamsTitle: string = "All Teams";

  true: boolean = true;
  false: boolean = false;

  myTeams: TeamCard[] = [
    new TeamCard('T', 'IronPegasus & Leo', 'Chapter 12', true),
    new TeamCard('A', 'Mappy & SkyWolf', 'Chapter 5', false),
    new TeamCard('G', 'Shiraho & Don Quixote', 'Chapter 5', false)
  ];
  myWorkshops: TeamCard[] = [
    new TeamCard('Bird', 'IronPegasus', '', false)
   ];
  allTeams: TeamCard[] = [
    new TeamCard('F', 'IYamAHobo', 'Homebase: Outer Reaches', false),
    new TeamCard('N', 'Nobody', 'Chapter 11', true)
   ];
}

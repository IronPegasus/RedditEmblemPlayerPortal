import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styles: []
})
export class AppComponent {
  myTeamTitle: string = "My Teams";
  myWorkshopTitle: string = "My Workshops";
  allTeamsTitle: string = "All Teams";

   myTeams: any[] = [
    {
      'teamLetter': 'T',
      'teamGMs' : ['IronPegasus', 'Leo']
    },
    {
      'teamLetter': 'A',
      'teamGMs': ['Mappy', 'Skywolf']
    },
    {
      'teamLetter': 'A',
      'teamGMs': ['Mappy', 'Skywolf']
    },
    {
      'teamLetter': 'A',
      'teamGMs': ['Mappy', 'Skywolf']
    },
    {
      'teamLetter': 'A',
      'teamGMs': ['Mappy', 'Skywolf']
    },
    {
      'teamLetter': 'A',
      'teamGMs': ['Mappy', 'Skywolf']
    }
  ];
   myWorkshops: any[] = [
     {
       'teamLetter': 'Fairytale',
       'teamGMs': ['IronPegasus'],
     }
   ];
   allTeams: any[] = [
     {
       'teamLetter': 'F',
       'teamGMs': ['IYamAHobo'],
     },
     {
       'teamLetter': 'L',
       'teamGMs': ['Nobody'],
     }
   ];
}

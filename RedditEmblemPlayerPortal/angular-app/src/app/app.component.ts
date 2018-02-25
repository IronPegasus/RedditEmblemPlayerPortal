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

  true: boolean = true;
  false: boolean = false;

   myTeams: any[] = [
    {
      'teamLetter': 'T',
      'teamGMs': 'IronPegasus & Leo',
      'currentActivity': 'Chapter 12',
      'appsOpen' : true
    },
    {
      'teamLetter': 'A',
      'teamGMs': 'Mappy & Skywolf',
      'currentActivity': 'Homebase: A Town',
      'appsOpen': false
    },
    {
      'teamLetter': 'A',
      'teamGMs': 'Mappy & Skywolf',
      'currentActivity': 'Homebase: A Town',
      'appsOpen': false
    },
    {
      'teamLetter': 'A',
      'teamGMs': 'Mappy & Skywolf',
      'currentActivity': 'Homebase: A Town',
      'appsOpen': true
    },
    {
      'teamLetter': 'A',
      'teamGMs': 'Mappy & Skywolf',
      'currentActivity': 'Homebase: A Town',
      'appsOpen': false
    },
    {
      'teamLetter': 'A',
      'teamGMs': 'Mappy & Skywolf',
      'currentActivity': 'Homebase: A Town',
      'appsOpen': false
    }
  ];
   myWorkshops: any[] = [
     {
       'teamLetter': 'Fairytale',
       'teamGMs': 'IronPegasus & LadyDeme',
       'currentActivity': '',
       'appsOpen': false
     }
   ];
   allTeams: any[] = [
     {
       'teamLetter': 'F',
       'teamGMs': 'IYamAHobo',
       'currentActivity': 'Homebase: Outer Reaches',
       'appsOpen': false
     },
     {
       'teamLetter': 'N',
       'teamGMs': 'Nobody',
       'currentActivity': 'Chapter 11',
       'appsOpen': true
     }
   ];
}

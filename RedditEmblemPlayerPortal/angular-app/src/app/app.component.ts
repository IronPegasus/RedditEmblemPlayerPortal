import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styles: []
})
export class AppComponent {
  teamCards: any[] = [
    {
      'teamLetter': 'T',
      'teamGMs' : ['IronPegasus', 'Leo']
    },
    {
      'teamLetter': 'A',
      'teamGMs': ['Mappy', 'Skywolf']
    },
    {
      'teamLetter': 'K',
      'teamGMs': ['LadyDeme']
    },
    {
      'teamLetter': 'G',
      'teamGMs': ['Shira', 'Don']
    },
    {
      'teamLetter': 'M',
      'teamGMs': ['GM #1', 'GM #2', 'GM #3']
    }
  ];
}

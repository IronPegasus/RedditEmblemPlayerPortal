export class TeamCard {
  readonly name: string = "";
  readonly gmNames: string = "";
  readonly currActivity: string = "";
  readonly appsOpen: boolean = false;

  constructor(teamName: string, gmNames: string, activity: string, appsOpen: boolean) {
    this.name = teamName;
    this.gmNames = gmNames;
    this.currActivity = activity;
    this.appsOpen = appsOpen;
  }
}
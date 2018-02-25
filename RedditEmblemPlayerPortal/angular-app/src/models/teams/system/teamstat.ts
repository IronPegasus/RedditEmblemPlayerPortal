export class TeamStat {
  readonly abbreviation: string = "";
  readonly name: string = "";
  readonly description: string = "";

  constructor(name: string, abbr: string, desc: string) {
    this.name = name;
    this.abbreviation = abbr;
    this.description = desc;
  }
}
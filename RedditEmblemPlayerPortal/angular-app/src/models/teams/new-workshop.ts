import { TeamStat } from "./system/teamstat";
import { BasicUser } from "../users/basic-user";

export class NewWorkshop {
  nickname: string = "";
  gms: BasicUser[] = [];
  stats: TeamStat[] = [];

  constructor() {
    this.gms = [
      new BasicUser('123', 'IronPegasus')
    ];
  }

  private getUserId(): string { return '123'; }
  private getUsername(): string { return 'IronPegasus'; }

  addStat(newStat: TeamStat): void { this.stats.push(newStat); }
  removeStat(index: number): void { this.stats.splice(index, 1); }

  addGM(newGM: BasicUser): void { this.gms.push(newGM); }
  removeGM(index: number): void { this.gms.splice(index, 1); }
}
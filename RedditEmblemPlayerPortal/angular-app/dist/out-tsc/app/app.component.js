"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var team_card_1 = require("../models/teams/team-card");
var AppComponent = /** @class */ (function () {
    function AppComponent() {
        this.myTeamTitle = "My Teams";
        this.myWorkshopTitle = "My Workshops";
        this.allTeamsTitle = "All Teams";
        this.true = true;
        this.false = false;
        this.myTeams = [
            new team_card_1.TeamCard('T', 'IronPegasus & Leo', 'Chapter 12', true),
            new team_card_1.TeamCard('A', 'Mappy & SkyWolf', 'Chapter 5', false),
            new team_card_1.TeamCard('G', 'Shiraho & Don Quixote', 'Chapter 5', false)
        ];
        this.myWorkshops = [
            new team_card_1.TeamCard('Bird', 'IronPegasus', '', false)
        ];
        this.allTeams = [
            new team_card_1.TeamCard('F', 'IYamAHobo', 'Homebase: Outer Reaches', false),
            new team_card_1.TeamCard('N', 'Nobody', 'Chapter 11', true)
        ];
    }
    AppComponent = __decorate([
        core_1.Component({
            selector: 'app-root',
            templateUrl: './app.component.html',
            styles: []
        })
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;
//# sourceMappingURL=app.component.js.map
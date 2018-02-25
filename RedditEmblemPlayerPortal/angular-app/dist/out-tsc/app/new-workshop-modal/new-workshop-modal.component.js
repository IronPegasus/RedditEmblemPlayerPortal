"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var $ = require("jquery");
var new_workshop_1 = require("../../models/teams/new-workshop");
var NewWorkshopModalComponent = /** @class */ (function () {
    function NewWorkshopModalComponent() {
        this.workshop = new new_workshop_1.NewWorkshop();
    }
    NewWorkshopModalComponent.prototype.fromScratch = function () {
        $('#bodyStart').css("display", "none");
        $('#bodyFromScratch').css("display", "block");
    };
    NewWorkshopModalComponent.prototype.catchTeamStatModalReturn = function (stat) {
        this.workshop.addStat(stat);
    };
    NewWorkshopModalComponent.prototype.removeGM = function (i) {
        if (i > 0)
            this.workshop.removeGM(i);
    };
    NewWorkshopModalComponent.prototype.removeStat = function (i) { this.workshop.removeStat(i); };
    NewWorkshopModalComponent = __decorate([
        core_1.Component({
            selector: 'new-workshop-modal',
            templateUrl: './new-workshop-modal.component.html',
            styles: []
        })
    ], NewWorkshopModalComponent);
    return NewWorkshopModalComponent;
}());
exports.NewWorkshopModalComponent = NewWorkshopModalComponent;
//# sourceMappingURL=new-workshop-modal.component.js.map
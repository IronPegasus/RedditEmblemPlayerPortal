"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var teamstat_1 = require("../../models/teams/system/teamstat");
var NewStatModalComponent = /** @class */ (function () {
    function NewStatModalComponent() {
        this.passData = new core_1.EventEmitter();
    }
    NewStatModalComponent.prototype.onSubmit = function () {
        var stat = new teamstat_1.TeamStat(this.name, this.abbreviation, this.description);
        this.passData.emit(stat);
        $('#dataForm')[0].reset();
        var ele = document.getElementById('newStatModal');
        $('#newStatModal').modal('hide');
    };
    __decorate([
        core_1.Output(),
        __metadata("design:type", core_1.EventEmitter)
    ], NewStatModalComponent.prototype, "passData", void 0);
    NewStatModalComponent = __decorate([
        core_1.Component({
            selector: 'new-stat-modal',
            templateUrl: './new-stat-modal.component.html',
            styles: []
        })
    ], NewStatModalComponent);
    return NewStatModalComponent;
}());
exports.NewStatModalComponent = NewStatModalComponent;
//# sourceMappingURL=new-stat-modal.component.js.map
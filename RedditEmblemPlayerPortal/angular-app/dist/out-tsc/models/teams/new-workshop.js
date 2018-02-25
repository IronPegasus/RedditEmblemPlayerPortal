"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var basic_user_1 = require("../users/basic-user");
var NewWorkshop = /** @class */ (function () {
    function NewWorkshop() {
        this.nickname = "";
        this.gms = [];
        this.stats = [];
        this.gms = [
            new basic_user_1.BasicUser('123', 'IronPegasus')
        ];
    }
    NewWorkshop.prototype.getUserId = function () { return '123'; };
    NewWorkshop.prototype.getUsername = function () { return 'IronPegasus'; };
    NewWorkshop.prototype.addStat = function (newStat) { this.stats.push(newStat); };
    NewWorkshop.prototype.removeStat = function (index) { this.stats.splice(index, 1); };
    NewWorkshop.prototype.addGM = function (newGM) { this.gms.push(newGM); };
    NewWorkshop.prototype.removeGM = function (index) { this.gms.splice(index, 1); };
    return NewWorkshop;
}());
exports.NewWorkshop = NewWorkshop;
//# sourceMappingURL=new-workshop.js.map
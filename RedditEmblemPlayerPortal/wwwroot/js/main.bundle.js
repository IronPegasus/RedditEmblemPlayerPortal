webpackJsonp(["main"],{

/***/ "./src/$$_lazy_route_resource lazy recursive":
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncatched exception popping up in devtools
	return Promise.resolve().then(function() {
		throw new Error("Cannot find module '" + req + "'.");
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./src/$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./src/app/app.component.html":
/***/ (function(module, exports) {

module.exports = "<team-list [listTitle]=\"myTeamTitle\" [teams]=\"myTeams\" [showAdd]=\"false\"></team-list>\r\n<team-list [listTitle]=\"myWorkshopTitle\" [teams]=\"myWorkshops\" [showAdd]=\"true\"></team-list>\r\n<team-list [listTitle]=\"allTeamsTitle\" [teams]=\"allTeams\"[showAdd]=\"false\"></team-list>\r\n<new-workshop-modal></new-workshop-modal>"

/***/ }),

/***/ "./src/app/app.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AppComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("./node_modules/@angular/core/esm5/core.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__models_teams_team_card__ = __webpack_require__("./src/models/teams/team-card.ts");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};


var AppComponent = /** @class */ (function () {
    function AppComponent() {
        this.myTeamTitle = "My Teams";
        this.myWorkshopTitle = "My Workshops";
        this.allTeamsTitle = "All Teams";
        this.true = true;
        this.false = false;
        this.myTeams = [
            new __WEBPACK_IMPORTED_MODULE_1__models_teams_team_card__["a" /* TeamCard */]('T', 'IronPegasus & Leo', 'Chapter 12', true),
            new __WEBPACK_IMPORTED_MODULE_1__models_teams_team_card__["a" /* TeamCard */]('A', 'Mappy & SkyWolf', 'Chapter 5', false),
            new __WEBPACK_IMPORTED_MODULE_1__models_teams_team_card__["a" /* TeamCard */]('G', 'Shiraho & Don Quixote', 'Chapter 5', false)
        ];
        this.myWorkshops = [
            new __WEBPACK_IMPORTED_MODULE_1__models_teams_team_card__["a" /* TeamCard */]('Bird', 'IronPegasus', '', false)
        ];
        this.allTeams = [
            new __WEBPACK_IMPORTED_MODULE_1__models_teams_team_card__["a" /* TeamCard */]('F', 'IYamAHobo', 'Homebase: Outer Reaches', false),
            new __WEBPACK_IMPORTED_MODULE_1__models_teams_team_card__["a" /* TeamCard */]('N', 'Nobody', 'Chapter 11', true)
        ];
    }
    AppComponent = __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["m" /* Component */])({
            selector: 'app-root',
            template: __webpack_require__("./src/app/app.component.html"),
            styles: []
        })
    ], AppComponent);
    return AppComponent;
}());



/***/ }),

/***/ "./src/app/app.module.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return AppModule; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_platform_browser__ = __webpack_require__("./node_modules/@angular/platform-browser/esm5/platform-browser.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_core__ = __webpack_require__("./node_modules/@angular/core/esm5/core.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__angular_forms__ = __webpack_require__("./node_modules/@angular/forms/esm5/forms.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__ng_bootstrap_ng_bootstrap__ = __webpack_require__("./node_modules/@ng-bootstrap/ng-bootstrap/index.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_4__app_component__ = __webpack_require__("./src/app/app.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_5__team_card_team_card_component__ = __webpack_require__("./src/app/team-card/team-card.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_6__team_list_team_list_component__ = __webpack_require__("./src/app/team-list/team-list.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_7__new_workshop_modal_new_workshop_modal_component__ = __webpack_require__("./src/app/new-workshop-modal/new-workshop-modal.component.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_8__new_stat_modal_new_stat_modal_component__ = __webpack_require__("./src/app/new-stat-modal/new-stat-modal.component.ts");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};









var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_1__angular_core__["G" /* NgModule */])({
            declarations: [
                __WEBPACK_IMPORTED_MODULE_4__app_component__["a" /* AppComponent */],
                __WEBPACK_IMPORTED_MODULE_5__team_card_team_card_component__["a" /* TeamCardComponent */],
                __WEBPACK_IMPORTED_MODULE_6__team_list_team_list_component__["a" /* TeamListComponent */],
                __WEBPACK_IMPORTED_MODULE_7__new_workshop_modal_new_workshop_modal_component__["a" /* NewWorkshopModalComponent */],
                __WEBPACK_IMPORTED_MODULE_8__new_stat_modal_new_stat_modal_component__["a" /* NewStatModalComponent */]
            ],
            imports: [
                __WEBPACK_IMPORTED_MODULE_0__angular_platform_browser__["a" /* BrowserModule */],
                __WEBPACK_IMPORTED_MODULE_2__angular_forms__["a" /* FormsModule */],
                __WEBPACK_IMPORTED_MODULE_3__ng_bootstrap_ng_bootstrap__["a" /* NgbModule */].forRoot(),
            ],
            providers: [],
            entryComponents: [
                __WEBPACK_IMPORTED_MODULE_8__new_stat_modal_new_stat_modal_component__["a" /* NewStatModalComponent */]
            ],
            bootstrap: [__WEBPACK_IMPORTED_MODULE_4__app_component__["a" /* AppComponent */]]
        })
    ], AppModule);
    return AppModule;
}());



/***/ }),

/***/ "./src/app/new-stat-modal/new-stat-modal.component.html":
/***/ (function(module, exports) {

module.exports = "<div id=\"newStatModal\" class=\"modal fade\" role=\"dialog\">\r\n  <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n    <div class=\"modal-content\">\r\n      <div class=\"modal-header\">\r\n        <h5 class=\"modal-title\">Add Stat</h5>\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n          <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n      </div>\r\n      <div class=\"modal-body\">\r\n        <form id=\"dataForm\">\r\n          <div class=\"form-row align-items-center\">\r\n            <div class=\"col-auto\">\r\n              <label for=\"txtName\">Name</label>\r\n              <input type=\"text\" class=\"form-control mb-2\" id=\"txtName\" minlength=\"1\" maxlength=\"16\" placeholder=\"Ex. Strength\" [(ngModel)]=\"name\" name=\"name\" />\r\n            </div>\r\n            <div class=\"col-auto\">\r\n              <label for=\"txtAbbreviation\">Abbreviation</label>\r\n              <input type=\"text\" class=\"form-control mb-2\" id=\"txtAbbreviation\" minlength=\"3\" maxlength=\"3\" placeholder=\"Ex. Str\" [(ngModel)]=\"abbreviation\" name=\"abbr\" />\r\n            </div>\r\n          </div>\r\n          <div class=\"form-group\">\r\n            <label for=\"txtDescription\">Description</label>\r\n            <input class=\"form-control\" id=\"txtDescription\" maxlength=\"64\" [(ngModel)]=\"description\" name=\"desc\" />\r\n          </div>\r\n        </form>\r\n      </div>\r\n      <div class=\"modal-footer\">\r\n        <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n        <button type=\"button\" class=\"btn btn-primary\" (click)=\"onSubmit()\">Save</button>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>"

/***/ }),

/***/ "./src/app/new-stat-modal/new-stat-modal.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return NewStatModalComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("./node_modules/@angular/core/esm5/core.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__models_teams_system_teamstat__ = __webpack_require__("./src/models/teams/system/teamstat.ts");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


var NewStatModalComponent = /** @class */ (function () {
    function NewStatModalComponent() {
        this.passData = new __WEBPACK_IMPORTED_MODULE_0__angular_core__["v" /* EventEmitter */]();
    }
    NewStatModalComponent.prototype.onSubmit = function () {
        var stat = new __WEBPACK_IMPORTED_MODULE_1__models_teams_system_teamstat__["a" /* TeamStat */](this.name, this.abbreviation, this.description);
        this.passData.emit(stat);
        $('#dataForm')[0].reset();
        var ele = document.getElementById('newStatModal');
        $('#newStatModal').modal('hide');
    };
    __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["M" /* Output */])(),
        __metadata("design:type", __WEBPACK_IMPORTED_MODULE_0__angular_core__["v" /* EventEmitter */])
    ], NewStatModalComponent.prototype, "passData", void 0);
    NewStatModalComponent = __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["m" /* Component */])({
            selector: 'new-stat-modal',
            template: __webpack_require__("./src/app/new-stat-modal/new-stat-modal.component.html"),
            styles: []
        })
    ], NewStatModalComponent);
    return NewStatModalComponent;
}());



/***/ }),

/***/ "./src/app/new-workshop-modal/new-workshop-modal.component.html":
/***/ (function(module, exports) {

module.exports = "<div id=\"newWorkshopModal\" class=\"modal fade\" role=\"dialog\">\r\n  <div class=\"modal-dialog modal-lg modal-dialog-centered\" role=\"document\">\r\n    <div class=\"modal-content\">\r\n      <div class=\"modal-header\">\r\n        <h5 class=\"modal-title\">Create a New Workshop</h5>\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n          <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n      </div>\r\n      <div id=\"bodyStart\" class=\"modal-body\">\r\n        <div class=\"container\" style=\"text-align: center;\">\r\n          <button id=\"btnFromScratch\" class=\"btn btn-primary\" (click)=\"fromScratch()\">Start from Scratch</button>\r\n          <div style=\"padding-top: 10px; padding-bottom: 10px;\">OR</div>\r\n          <button id=\"btnFromTemplate\" class=\"btn btn-primary\">Use a Template</button>\r\n        </div>\r\n      </div>\r\n      <div id=\"bodyFromScratch\" class=\"modal-body\" style=\"display: none;\">\r\n        <form>\r\n          <div class=\"form-group\">\r\n            <label for=\"txtNickname\">Team Nickname</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"txtNickname\" required minlength=\"1\" maxlength=\"32\" aria-describedby=\"nicknameHelp\" [(ngModel)]=\"workshop.nickname\" name=\"nickname\">\r\n            <small id=\"nicknameHelp\" class=\"form-text text-muted\">A short placeholder name that describes your team.</small>\r\n          </div>\r\n          <div class=\"form-group\">\r\n            <label>Game Masters</label>\r\n            <div style=\"font-size: 18px;\">\r\n              <span class=\"badge badge-pill badge-primary\" *ngFor=\"let gm of workshop.gms; let i = index\" (click)=\"removeGM(i)\" style=\"margin-right: 5px;\">\r\n                {{gm.username}} <span *ngIf=\"i > 0\"><i class=\"fas fa-times fa-sm\"></i></span>\r\n              </span>\r\n            </div>\r\n            <small class=\"form-text text-muted\">The GMs for this team. You must be included in this list.</small>\r\n          </div>\r\n          <div class=\"form-group\">\r\n            <label>Character Stats</label>\r\n            <button class=\"btn btn-primary\" style=\"float: right;\" data-toggle=\"modal\" data-target=\"#newStatModal\">\r\n              <i class=\"fas fa-plus fa-sm\"></i>\r\n            </button>\r\n            <div style=\"font-size: 18px;\">\r\n              <span class=\"badge badge-pill badge-primary\" *ngFor=\"let stat of workshop.stats; let i = index\" (click)=\"removeStat(i)\" style=\"margin-right: 5px;\">\r\n                {{stat.name}} <i class=\"fas fa-times fa-sm\"></i>\r\n              </span>\r\n            </div>\r\n            <small class=\"form-text text-muted\">The primary stats for units on your team, such as Str or Mag. Does not need to include Movement.</small>\r\n          </div>\r\n        </form>\r\n      </div>\r\n      <div class=\"modal-footer\">\r\n        <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n<new-stat-modal (passData)=\"catchTeamStatModalReturn($event)\"></new-stat-modal>"

/***/ }),

/***/ "./src/app/new-workshop-modal/new-workshop-modal.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return NewWorkshopModalComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("./node_modules/@angular/core/esm5/core.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1_jquery__ = __webpack_require__("./node_modules/jquery/dist/jquery.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1_jquery___default = __webpack_require__.n(__WEBPACK_IMPORTED_MODULE_1_jquery__);
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__models_teams_new_workshop__ = __webpack_require__("./src/models/teams/new-workshop.ts");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};



var NewWorkshopModalComponent = /** @class */ (function () {
    function NewWorkshopModalComponent() {
        this.workshop = new __WEBPACK_IMPORTED_MODULE_2__models_teams_new_workshop__["a" /* NewWorkshop */]();
    }
    NewWorkshopModalComponent.prototype.fromScratch = function () {
        __WEBPACK_IMPORTED_MODULE_1_jquery__('#bodyStart').css("display", "none");
        __WEBPACK_IMPORTED_MODULE_1_jquery__('#bodyFromScratch').css("display", "block");
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
        Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["m" /* Component */])({
            selector: 'new-workshop-modal',
            template: __webpack_require__("./src/app/new-workshop-modal/new-workshop-modal.component.html"),
            styles: []
        })
    ], NewWorkshopModalComponent);
    return NewWorkshopModalComponent;
}());



/***/ }),

/***/ "./src/app/team-card/team-card.component.css":
/***/ (function(module, exports) {

module.exports = ".team-card-hover:hover {\r\n  cursor: pointer;\r\n  -webkit-box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.15);\r\n          box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.15)\r\n}\r\n\r\nhr{\r\n  margin: 0px;\r\n}"

/***/ }),

/***/ "./src/app/team-card/team-card.component.html":
/***/ (function(module, exports) {

module.exports = "<div class=\"card team-card-hover\">\r\n  <div class=\"card-body\">\r\n    <h5 class=\"card-title\">Team {{teamInfo.name}}</h5>\r\n    <h6 class=\"card-subtitle mb-2 text-muted\">{{teamInfo.gmNames}}</h6>\r\n    <p class=\"card-text\">\r\n      <small>{{teamInfo.currActivity}}</small>\r\n    </p>\r\n    <p class=\"card-text\" *ngIf=\"teamInfo.appsOpen\">\r\n      <small><i class=\"fas fa-file-alt\"></i> Accepting Applications</small>\r\n    </p>\r\n  </div>\r\n</div>"

/***/ }),

/***/ "./src/app/team-card/team-card.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return TeamCardComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("./node_modules/@angular/core/esm5/core.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__models_teams_team_card__ = __webpack_require__("./src/models/teams/team-card.ts");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


var TeamCardComponent = /** @class */ (function () {
    function TeamCardComponent() {
    }
    __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["B" /* Input */])(),
        __metadata("design:type", __WEBPACK_IMPORTED_MODULE_1__models_teams_team_card__["a" /* TeamCard */])
    ], TeamCardComponent.prototype, "teamInfo", void 0);
    TeamCardComponent = __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["m" /* Component */])({
            selector: 'team-card',
            template: __webpack_require__("./src/app/team-card/team-card.component.html"),
            styles: [__webpack_require__("./src/app/team-card/team-card.component.css")]
        })
    ], TeamCardComponent);
    return TeamCardComponent;
}());



/***/ }),

/***/ "./src/app/team-list/team-list.component.html":
/***/ (function(module, exports) {

module.exports = "<div style=\"padding-right: 10px;\">\r\n  <button class=\"btn btn-link\" (click)=\"toggleExpand()\" style=\"width: 30px;\">\r\n    <span *ngIf=\"isExpanded\"><i class=\"fas fa-caret-down fa-lg\"></i></span>\r\n    <span *ngIf=\"isExpanded == false\"><i class=\"fas fa-caret-right fa-lg\"></i></span>\r\n  </button>\r\n  <h3 style=\"display: inline-block;\">{{listTitle}}</h3>\r\n  <button class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#newWorkshopModal\" *ngIf=\"showAdd\" style=\"float: right;\">\r\n    <i class=\"fas fa-plus fa-sm\"></i>\r\n  </button>\r\n  <div class=\"container-fluid content-row\">\r\n    <div class=\"row\" *ngIf=\"isExpanded\">\r\n      <team-card class=\"col-md-3\" *ngFor=\"let team of teams\" [teamInfo]=\"team\"></team-card>\r\n    </div>\r\n  </div>\r\n  <hr />\r\n</div>,"

/***/ }),

/***/ "./src/app/team-list/team-list.component.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return TeamListComponent; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("./node_modules/@angular/core/esm5/core.js");
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var TeamListComponent = /** @class */ (function () {
    function TeamListComponent() {
        this.showAdd = false;
        this.isExpanded = true;
    }
    TeamListComponent.prototype.toggleExpand = function () {
        this.isExpanded = !this.isExpanded;
    };
    __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["B" /* Input */])(),
        __metadata("design:type", String)
    ], TeamListComponent.prototype, "listTitle", void 0);
    __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["B" /* Input */])(),
        __metadata("design:type", Array)
    ], TeamListComponent.prototype, "teams", void 0);
    __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["B" /* Input */])(),
        __metadata("design:type", Boolean)
    ], TeamListComponent.prototype, "showAdd", void 0);
    TeamListComponent = __decorate([
        Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["m" /* Component */])({
            selector: 'team-list',
            template: __webpack_require__("./src/app/team-list/team-list.component.html"),
            styles: []
        })
    ], TeamListComponent);
    return TeamListComponent;
}());



/***/ }),

/***/ "./src/environments/environment.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return environment; });
// The file contents for the current environment will overwrite these during build.
// The build system defaults to the dev environment which uses `environment.ts`, but if you do
// `ng build --env=prod` then `environment.prod.ts` will be used instead.
// The list of which env maps to which file can be found in `.angular-cli.json`.
var environment = {
    production: false
};


/***/ }),

/***/ "./src/main.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
Object.defineProperty(__webpack_exports__, "__esModule", { value: true });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__angular_core__ = __webpack_require__("./node_modules/@angular/core/esm5/core.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_1__angular_platform_browser_dynamic__ = __webpack_require__("./node_modules/@angular/platform-browser-dynamic/esm5/platform-browser-dynamic.js");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_2__app_app_module__ = __webpack_require__("./src/app/app.module.ts");
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_3__environments_environment__ = __webpack_require__("./src/environments/environment.ts");




if (__WEBPACK_IMPORTED_MODULE_3__environments_environment__["a" /* environment */].production) {
    Object(__WEBPACK_IMPORTED_MODULE_0__angular_core__["_10" /* enableProdMode */])();
}
Object(__WEBPACK_IMPORTED_MODULE_1__angular_platform_browser_dynamic__["a" /* platformBrowserDynamic */])().bootstrapModule(__WEBPACK_IMPORTED_MODULE_2__app_app_module__["a" /* AppModule */])
    .catch(function (err) { return console.log(err); });


/***/ }),

/***/ "./src/models/teams/new-workshop.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return NewWorkshop; });
/* harmony import */ var __WEBPACK_IMPORTED_MODULE_0__users_basic_user__ = __webpack_require__("./src/models/users/basic-user.ts");

var NewWorkshop = /** @class */ (function () {
    function NewWorkshop() {
        this.nickname = "";
        this.gms = [];
        this.stats = [];
        this.gms = [
            new __WEBPACK_IMPORTED_MODULE_0__users_basic_user__["a" /* BasicUser */]('123', 'IronPegasus')
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



/***/ }),

/***/ "./src/models/teams/system/teamstat.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return TeamStat; });
var TeamStat = /** @class */ (function () {
    function TeamStat(name, abbr, desc) {
        this.abbreviation = "";
        this.name = "";
        this.description = "";
        this.name = name;
        this.abbreviation = abbr;
        this.description = desc;
    }
    return TeamStat;
}());



/***/ }),

/***/ "./src/models/teams/team-card.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return TeamCard; });
var TeamCard = /** @class */ (function () {
    function TeamCard(teamName, gmNames, activity, appsOpen) {
        this.name = "";
        this.gmNames = "";
        this.currActivity = "";
        this.appsOpen = false;
        this.name = teamName;
        this.gmNames = gmNames;
        this.currActivity = activity;
        this.appsOpen = appsOpen;
    }
    return TeamCard;
}());



/***/ }),

/***/ "./src/models/users/basic-user.ts":
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return BasicUser; });
var BasicUser = /** @class */ (function () {
    function BasicUser(id, username) {
        this.id = id;
        this.username = username;
    }
    return BasicUser;
}());



/***/ }),

/***/ 0:
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__("./src/main.ts");


/***/ })

},[0]);
//# sourceMappingURL=main.bundle.js.map
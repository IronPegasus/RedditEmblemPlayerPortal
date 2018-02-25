"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var platform_browser_1 = require("@angular/platform-browser");
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var ng_bootstrap_1 = require("@ng-bootstrap/ng-bootstrap");
var app_component_1 = require("./app.component");
var team_card_component_1 = require("./team-card/team-card.component");
var team_list_component_1 = require("./team-list/team-list.component");
var new_workshop_modal_component_1 = require("./new-workshop-modal/new-workshop-modal.component");
var new_stat_modal_component_1 = require("./new-stat-modal/new-stat-modal.component");
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            declarations: [
                app_component_1.AppComponent,
                team_card_component_1.TeamCardComponent,
                team_list_component_1.TeamListComponent,
                new_workshop_modal_component_1.NewWorkshopModalComponent,
                new_stat_modal_component_1.NewStatModalComponent
            ],
            imports: [
                platform_browser_1.BrowserModule,
                forms_1.FormsModule,
                ng_bootstrap_1.NgbModule.forRoot(),
            ],
            providers: [],
            entryComponents: [
                new_stat_modal_component_1.NewStatModalComponent
            ],
            bootstrap: [app_component_1.AppComponent]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map
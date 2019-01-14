(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["modules-dashboard-dashboard-module"],{

/***/ "./src/app/modules/dashboard/dashboard-routing.module.ts":
/*!***************************************************************!*\
  !*** ./src/app/modules/dashboard/dashboard-routing.module.ts ***!
  \***************************************************************/
/*! exports provided: DashboardRoutingModule, routedComponents */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DashboardRoutingModule", function() { return DashboardRoutingModule; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "routedComponents", function() { return routedComponents; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _dashboard_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./dashboard.component */ "./src/app/modules/dashboard/dashboard.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};



var routes = [
    {
        path: '',
        component: _dashboard_component__WEBPACK_IMPORTED_MODULE_2__["DashboardComponent"],
    }
];
var DashboardRoutingModule = /** @class */ (function () {
    function DashboardRoutingModule() {
    }
    DashboardRoutingModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"].forChild(routes)],
            exports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"]]
        })
    ], DashboardRoutingModule);
    return DashboardRoutingModule;
}());

var routedComponents = [
    _dashboard_component__WEBPACK_IMPORTED_MODULE_2__["DashboardComponent"]
];


/***/ }),

/***/ "./src/app/modules/dashboard/dashboard.component.html":
/*!************************************************************!*\
  !*** ./src/app/modules/dashboard/dashboard.component.html ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"card mb-3\" [hidden]=\"!hasOrders\">\r\n        <div class=\"card-header\">\r\n            <button class=\"btn btn-link\" (click)=\"toggleOrders()\">\r\n                <h4>\r\n                    <i class=\"fa fa-plus fa-fw fa-lg fa-rotate-0\" [ngClass]=\"{'fa-rotate-135': showOrders}\"></i>\r\n                    Reeds bestelde drankjes\r\n                </h4>\r\n            </button>\r\n        </div>\r\n        <div [hidden]=\"!showOrders\">\r\n            <div class=\"card-body\">\r\n                <app-overview (notify)=\"onNotifyOrders($event)\"></app-overview>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n<div class=\"card mb-3\" [hidden]=\"!hasFavorite\">\r\n    <div class=\"card-header\">\r\n        <button class=\"btn btn-link\" (click)=\"toggleFavorite()\">\r\n            <h4>\r\n                <i class=\"fa fa-plus fa-fw fa-lg fa-rotate-0\" [ngClass]=\"{'fa-rotate-135': showFavorite}\"></i>\r\n                Bestel uw favoriet\r\n            </h4>\r\n        </button>\r\n    </div>\r\n    <div [hidden]=\"!showFavorite\">\r\n        <div class=\"card-body\">\r\n            <app-favorite (notifyFavorite)=\"onNotifyFavorite($event)\" (notifyPlaced)=\"onNotifyPlaced()\"></app-favorite>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"card mb-3\">\r\n    <div class=\"card-header\">\r\n        <button class=\"btn btn-link\" (click)=\"toggleDrinks()\">\r\n            <h4>\r\n                <i class=\"fa fa-plus fa-fw fa-lg fa-rotate-0\" [ngClass]=\"{'fa-rotate-135': showAllDrinks}\"></i>\r\n                Kies een drank\r\n            </h4>\r\n        </button>\r\n    </div>\r\n    <div [hidden]=\"!showAllDrinks\">\r\n        <div class=\"card-body\">\r\n            <app-place></app-place>\r\n        </div>\r\n    </div>\r\n</div>"

/***/ }),

/***/ "./src/app/modules/dashboard/dashboard.component.scss":
/*!************************************************************!*\
  !*** ./src/app/modules/dashboard/dashboard.component.scss ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".pointer {\n  cursor: pointer; }\n\nh4 {\n  margin: 0; }\n\n.fa {\n  /* Safari */\n  transition: all .3s ease-out; }\n\n.fa-rotate-0 {\n  -webkit-transform: rotate(0deg);\n  transform: rotate(0deg); }\n\n.fa-rotate-135 {\n  -webkit-transform: rotate(135deg);\n  transform: rotate(135deg); }\n"

/***/ }),

/***/ "./src/app/modules/dashboard/dashboard.component.ts":
/*!**********************************************************!*\
  !*** ./src/app/modules/dashboard/dashboard.component.ts ***!
  \**********************************************************/
/*! exports provided: DashboardComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DashboardComponent", function() { return DashboardComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var src_app_core_services_auth_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! src/app/core/services/auth.service */ "./src/app/core/services/auth.service.ts");
/* harmony import */ var _order_overview_overview_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../order/overview/overview.component */ "./src/app/modules/order/overview/overview.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var DashboardComponent = /** @class */ (function () {
    function DashboardComponent(auth) {
        this.auth = auth;
        this.hasFavorite = false;
        this.hasOrders = false;
        this.hasOwnOrder = false;
        this.showOrders = false;
        this.showAllDrinks = true;
        this.showManagerPanel = false;
        this.showAdminPanel = false;
        this.showFavorite = false;
    }
    DashboardComponent.prototype.ngOnInit = function () {
    };
    DashboardComponent.prototype.toggleDrinks = function () {
        this.showAllDrinks = !this.showAllDrinks;
    };
    DashboardComponent.prototype.toggleManager = function () {
        this.showManagerPanel = !this.showManagerPanel;
    };
    DashboardComponent.prototype.toggleAdmin = function () {
        this.showAdminPanel = !this.showAdminPanel;
    };
    DashboardComponent.prototype.isManager = function () {
        return this.auth.hasRole('Manager');
    };
    DashboardComponent.prototype.isAdmin = function () {
        return this.auth.hasRole('Admin');
    };
    DashboardComponent.prototype.toggleFavorite = function () {
        this.showFavorite = !this.showFavorite;
    };
    DashboardComponent.prototype.toggleOrders = function () {
        this.showOrders = !this.showOrders;
    };
    DashboardComponent.prototype.onNotifyFavorite = function (drinkPreference) {
        this.hasFavorite = drinkPreference.drink != null;
        this.setState(true, null);
    };
    DashboardComponent.prototype.onNotifyOrders = function (orderLines) {
        var _this = this;
        this.hasOrders = orderLines.length > 0;
        this.hasOwnOrder = !!orderLines.find(function (orderLine) {
            return orderLine.customer.userId === _this.auth.getDecodedToken().nameid;
        });
        this.setState(null, true);
    };
    DashboardComponent.prototype.onNotifyPlaced = function () {
        this.overview.refreshOrders();
    };
    DashboardComponent.prototype.setState = function (favoriteReceived, ordersReceived) {
        this.favoriteReceived = this.favoriteReceived || favoriteReceived;
        this.ordersReceived = this.ordersReceived || ordersReceived;
        if (this.favoriteReceived && this.ordersReceived) {
            this.showOrders = this.hasOrders && this.hasOwnOrder;
            this.showFavorite = this.hasFavorite && !this.hasOwnOrder;
            this.showAllDrinks = !this.hasOwnOrder && !this.hasFavorite;
        }
    };
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ViewChild"])(_order_overview_overview_component__WEBPACK_IMPORTED_MODULE_2__["OverviewComponent"]),
        __metadata("design:type", _order_overview_overview_component__WEBPACK_IMPORTED_MODULE_2__["OverviewComponent"])
    ], DashboardComponent.prototype, "overview", void 0);
    DashboardComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-dashboard',
            template: __webpack_require__(/*! ./dashboard.component.html */ "./src/app/modules/dashboard/dashboard.component.html"),
            styles: [__webpack_require__(/*! ./dashboard.component.scss */ "./src/app/modules/dashboard/dashboard.component.scss")]
        }),
        __metadata("design:paramtypes", [src_app_core_services_auth_service__WEBPACK_IMPORTED_MODULE_1__["AuthService"]])
    ], DashboardComponent);
    return DashboardComponent;
}());



/***/ }),

/***/ "./src/app/modules/dashboard/dashboard.module.ts":
/*!*******************************************************!*\
  !*** ./src/app/modules/dashboard/dashboard.module.ts ***!
  \*******************************************************/
/*! exports provided: DashboardModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DashboardModule", function() { return DashboardModule; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _dashboard_routing_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./dashboard-routing.module */ "./src/app/modules/dashboard/dashboard-routing.module.ts");
/* harmony import */ var _order_order_module__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../order/order.module */ "./src/app/modules/order/order.module.ts");
/* harmony import */ var _user_user_module__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../user/user.module */ "./src/app/modules/user/user.module.ts");
/* harmony import */ var _reports_reports_module__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../reports/reports.module */ "./src/app/modules/reports/reports.module.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};






var DashboardModule = /** @class */ (function () {
    function DashboardModule() {
    }
    DashboardModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_1__["CommonModule"], _dashboard_routing_module__WEBPACK_IMPORTED_MODULE_2__["DashboardRoutingModule"], _order_order_module__WEBPACK_IMPORTED_MODULE_3__["OrderModule"], _user_user_module__WEBPACK_IMPORTED_MODULE_4__["UserModule"], _reports_reports_module__WEBPACK_IMPORTED_MODULE_5__["ReportsModule"]
            ],
            declarations: _dashboard_routing_module__WEBPACK_IMPORTED_MODULE_2__["routedComponents"].slice()
        })
    ], DashboardModule);
    return DashboardModule;
}());



/***/ })

}]);
//# sourceMappingURL=modules-dashboard-dashboard-module.js.map
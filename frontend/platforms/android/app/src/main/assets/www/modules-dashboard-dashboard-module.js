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

module.exports = "<div class=\"menu\">\r\n    <div class=\"menu-icon\" id=\"menu-favorit\" *ngIf=\"hasFavorite\" (click)=\"toggleFavorite()\">\r\n        <div>\r\n            <div>\r\n                <div class=\"menu-image\">\r\n                    <img src=\"./assets/Images/favorit.png\">\r\n                </div>\r\n                <div class=\"menu-label\">Favoriet</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"menu-icon\" id=\"menu-drinks\" (click)=\"toggleDrinks()\">\r\n        <div>\r\n            <div>\r\n                <div class=\"menu-image\">\r\n                    <img src=\"./assets/Images/coffee-icon.png\">\r\n                </div>\r\n                <div class=\"menu-label\">Bestellen</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"menu-icon\" id=\"menu-order\"  [hidden]=\"!hasOrders\" (click)=\"toggleOrders()\">\r\n        <div>\r\n            <div>\r\n                <div class=\"menu-image\">\r\n                    <img src=\"./assets/Images/getting.png\">\r\n                </div>\r\n                <div class=\"menu-label\">Halen</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"menu-icon\" id=\"menu-manager\" *ngIf=\"isManager();\" (click)=\"toggleManager()\">\r\n        <div>\r\n            <div>\r\n                <div class=\"menu-image\">\r\n                    <img src=\"./assets/Images/chart.png\">\r\n                </div>\r\n                <div class=\"menu-label\">Statistieken</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"menu-icon\" id=\"menu-group\"  (click)=\"toggleGroup()\">\r\n            <div>\r\n                <div>\r\n                    <div class=\"menu-image\">\r\n                        <img src=\"./assets/Images/group.png\">\r\n                    </div>\r\n                    <div class=\"menu-label\">Groep</div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    <div class=\"menu-icon\" id=\"menu-admin\" *ngIf=\"isAdmin();\" (click)=\"toggleAdmin()\">\r\n            <div>\r\n                <div>\r\n                    <div class=\"menu-image\">\r\n                        <img src=\"./assets/Images/admin.png\">\r\n                    </div>\r\n                    <div class=\"menu-label\">Admin</div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"menu-icon\" id=\"menu-logout\" (click)=\"logOut()\">\r\n                <div>\r\n                    <div>\r\n                        <div class=\"menu-image\">\r\n                            <img src=\"./assets/Images/logout.png\">\r\n                        </div>\r\n                        <div class=\"menu-label\">Uitloggen</div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n</div>\r\n<div class=\"card\" [hidden]=\"!hasOrders\">\r\n    <div [hidden]=\"!showOrders\">\r\n        <div class=\"card-body\">\r\n            <app-overview (notify)=\"onNotifyOrders($event)\"></app-overview>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"card-favorite\" class=\"card-favorite card\" [hidden]=\"!hasFavorite\">\r\n    \r\n    <div [hidden]=\"!showFavorite\">\r\n        <div class=\"card-body card-favorite\">\r\n            <app-favorite (notifyFavorite)=\"onNotifyFavorite($event)\" (notifyPlaced)=\"onNotifyPlaced()\" *ngIf=\"hasFavorite\"></app-favorite>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"card\">\r\n    \r\n    <div [hidden]=\"!showAllDrinks\">\r\n        <div class=\"card-body\">\r\n            <app-place></app-place>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"card\">\r\n    \r\n        <div [hidden]=\"!showGroup\">\r\n            <div class=\"card-body\">\r\n                <app-group></app-group>\r\n            </div>\r\n        </div>\r\n    </div>"

/***/ }),

/***/ "./src/app/modules/dashboard/dashboard.component.scss":
/*!************************************************************!*\
  !*** ./src/app/modules/dashboard/dashboard.component.scss ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".pointer {\n  cursor: pointer; }\n\nh4 {\n  margin: 0; }\n\n.fa {\n  /* Safari */\n  transition: all .3s ease-out; }\n\n.fa-rotate-0 {\n  -webkit-transform: rotate(0deg);\n  transform: rotate(0deg); }\n\n.fa-rotate-135 {\n  -webkit-transform: rotate(135deg);\n  transform: rotate(135deg); }\n\n.menu {\n  display: flex;\n  flex-direction: row;\n  flex-wrap: wrap;\n  max-width: 920px;\n  min-width: 110px;\n  margin-left: -5px;\n  margin-bottom: 1em; }\n\n.menu-icon {\n  background-color: #e6a756;\n  position: relative;\n  display: inline-block;\n  border-radius: 10px;\n  width: 120px;\n  height: 120px;\n  margin: 5px;\n  text-align: center; }\n\n.menu-icon > div {\n  background-color: white;\n  position: relative;\n  display: inline-block;\n  border-radius: 10px;\n  width: 114px;\n  height: 114px;\n  margin: 3px;\n  text-align: center; }\n\n.menu-icon > div > div {\n  background-color: white;\n  border: 3px #e6a756 solid;\n  position: relative;\n  display: inline-block;\n  border-radius: 10px;\n  width: 108px;\n  height: 108px;\n  margin: 3px;\n  text-align: center; }\n\n.menu-image img {\n  width: 75%;\n  margin: auto;\n  margin-top: 0.3em;\n  margin-bottom: 0.3em; }\n\n.menu-label {\n  font-size: 8pt;\n  text-transform: uppercase;\n  font-family: 'Raleway';\n  font-weight: bold; }\n\n.menu-icon > div:hover {\n  background: #e6a756; }\n\n.menu-icon-active > div {\n  background: #e6a756;\n  -webkit-animation: blinker 0.2s linear;\n          animation: blinker 0.2s linear; }\n\n@-webkit-keyframes blinker {\n  50% {\n    opacity: 0; } }\n\n@keyframes blinker {\n  50% {\n    opacity: 0; } }\n\n.card {\n  border: 0; }\n"

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
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
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
    function DashboardComponent(auth, router) {
        this.auth = auth;
        this.router = router;
        this.hasFavorite = true;
        this.hasOrders = false;
        this.hasOwnOrder = false;
        this.showOrders = false;
        this.showAllDrinks = true;
        this.showManagerPanel = false;
        this.showAdminPanel = false;
        this.showFavorite = false;
        this.showGroup = false;
    }
    DashboardComponent.prototype.ngOnInit = function () {
    };
    DashboardComponent.prototype.closeAll = function () {
        this.showAdminPanel = false;
        this.showAllDrinks = false;
        this.showFavorite = false;
        this.showManagerPanel = false;
        this.showOrders = false;
        this.showGroup = false;
        this.setAllInactive();
    };
    DashboardComponent.prototype.setAllInactive = function () {
        if (this.hasFavorite) {
            document.getElementById('menu-favorit').className = "menu-icon";
            document.getElementById('card-favorite').className = "card";
        }
        document.getElementById('menu-drinks').className = "menu-icon";
        if (this.hasOrders) {
            document.getElementById('menu-order').className = "menu-icon";
        }
        document.getElementById('menu-manager').className = "menu-icon";
        document.getElementById('menu-admin').className = "menu-icon";
        document.getElementById('menu-group').className = "menu-icon";
    };
    DashboardComponent.prototype.toggleDrinks = function () {
        var div = document.getElementById('menu-drinks');
        this.closeAll();
        this.showAllDrinks = !this.showAllDrinks;
        if (this.showAllDrinks === true) {
            div.className = "menu-icon menu-icon-active";
        }
        else {
            div.className = "menu-icon";
        }
    };
    DashboardComponent.prototype.toggleGroup = function () {
        var div = document.getElementById('menu-group');
        this.closeAll();
        this.showGroup = !this.showGroup;
        if (this.showGroup === true) {
            div.className = "menu-icon menu-icon-active";
        }
        else {
            div.className = "menu-icon";
        }
    };
    DashboardComponent.prototype.toggleManager = function () {
        var div = document.getElementById('menu-manager');
        this.closeAll();
        this.showManagerPanel = !this.showManagerPanel;
        if (this.showManagerPanel === true) {
            div.className = "menu-icon menu-icon-active";
        }
        else {
            div.className = "menu-icon";
        }
    };
    DashboardComponent.prototype.toggleAdmin = function () {
        var div = document.getElementById('menu-admin');
        this.closeAll();
        this.showAdminPanel = !this.showAdminPanel;
        if (this.showAdminPanel === true) {
            div.className = "menu-icon menu-icon-active";
        }
        else {
            div.className = "menu-icon";
        }
    };
    DashboardComponent.prototype.isManager = function () {
        return this.auth.hasRole('Manager');
    };
    DashboardComponent.prototype.isAdmin = function () {
        return this.auth.hasRole('Admin');
    };
    DashboardComponent.prototype.toggleFavorite = function () {
        this.closeAll();
        var div = document.getElementById('menu-favorit');
        this.showFavorite = !this.showFavorite;
        if (this.showFavorite === true) {
            var divCard = document.getElementById('card-favorite');
            divCard.className = "card-favorit";
            div.className = "menu-icon menu-icon-active";
        }
        else {
            divCard.className = "card";
            div.className = "menu-icon";
        }
    };
    DashboardComponent.prototype.toggleOrders = function () {
        this.closeAll();
        var div = document.getElementById('menu-order');
        this.showOrders = !this.showOrders;
        if (this.showOrders === true) {
            div.className = "menu-icon menu-icon-active";
        }
        else {
            div.className = "menu-icon";
        }
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
    DashboardComponent.prototype.logOut = function () {
        this.auth.logout();
        this.router.navigate(['/']);
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
        if (this.showOrders) {
            this.setAllInactive();
            document.getElementById('menu-order').className = "menu-icon menu-icon-active";
        }
        else if (this.showFavorite) {
            this.setAllInactive();
            document.getElementById('menu-favorit').className = "menu-icon menu-icon-active";
        }
        else if (this.showAllDrinks) {
            this.setAllInactive();
            document.getElementById('menu-drinks').className = "menu-icon menu-icon-active";
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
        __metadata("design:paramtypes", [src_app_core_services_auth_service__WEBPACK_IMPORTED_MODULE_1__["AuthService"],
            _angular_router__WEBPACK_IMPORTED_MODULE_3__["Router"]])
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
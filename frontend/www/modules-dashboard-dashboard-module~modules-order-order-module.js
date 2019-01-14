(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["modules-dashboard-dashboard-module~modules-order-order-module"],{

/***/ "./src/app/core/services/Available-coffee.service.ts":
/*!***********************************************************!*\
  !*** ./src/app/core/services/Available-coffee.service.ts ***!
  \***********************************************************/
/*! exports provided: AvailableCoffeeService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AvailableCoffeeService", function() { return AvailableCoffeeService; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _api_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./api.service */ "./src/app/core/services/api.service.ts");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm5/operators/index.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var AvailableCoffeeService = /** @class */ (function () {
    function AvailableCoffeeService(api) {
        this.api = api;
        this.response = { 'response': 'no response yet...' };
    }
    AvailableCoffeeService.prototype.getCoffee = function () {
        return this.api.get('/drinks?available=true').pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_2__["concatAll"])(), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_2__["map"])(function (obj) {
            var drink = {
                drinkId: obj['drinkId'],
                drinkName: obj['drinkName'],
                available: obj['available'],
                imageUrl: obj['imageUrl'],
                additions: obj['additions']
            };
            return drink;
        }));
    };
    AvailableCoffeeService.prototype.getSingleCoffee = function (id) {
        return this.api.get('/drinks/' + id).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_2__["map"])(function (obj) {
            var drink = {
                drinkId: obj['drinkId'],
                drinkName: obj['drinkName'],
                available: obj['available'],
                imageUrl: obj['imageUrl'],
                additions: obj['additions']
            };
            return drink;
        }));
    };
    AvailableCoffeeService = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Injectable"])({
            providedIn: 'root'
        }),
        __metadata("design:paramtypes", [_api_service__WEBPACK_IMPORTED_MODULE_1__["ApiService"]])
    ], AvailableCoffeeService);
    return AvailableCoffeeService;
}());



/***/ }),

/***/ "./src/app/core/services/order.service.ts":
/*!************************************************!*\
  !*** ./src/app/core/services/order.service.ts ***!
  \************************************************/
/*! exports provided: OrderService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "OrderService", function() { return OrderService; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var src_app_core_services_auth_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! src/app/core/services/auth.service */ "./src/app/core/services/auth.service.ts");
/* harmony import */ var _api_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./api.service */ "./src/app/core/services/api.service.ts");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm5/operators/index.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};




var OrderService = /** @class */ (function () {
    function OrderService(auth, api) {
        this.auth = auth;
        this.api = api;
    }
    OrderService.prototype.getOrders = function () {
        return this.api.get('/orderlines?orderstatus=ordered').pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_3__["concatAll"])(), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_3__["map"])(function (obj) {
            var orderline = {
                orderLineId: obj['orderLineId'],
                drink: obj['drink'],
                count: obj['count'],
                customer: obj['customer'],
                milk: obj['milk'],
                sugar: obj['sugar'],
                orderStatus: obj['orderStatus']
            };
            return orderline;
        }));
    };
    OrderService.prototype.getStatussen = function () {
        return this.api.get('/orderstatus').pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_3__["concatAll"])(), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_3__["map"])(function (obj) {
            var orderstatus = {
                orderStatusId: obj['orderStatusId'],
                statusName: obj['statusName']
            };
            return orderstatus;
        }));
    };
    OrderService.prototype.postOrderline = function (orderline) {
        return this.api.post('/OrderLines', {
            'Customer': {
                userId: this.auth.getDecodedToken().nameid
            },
            'Drink': orderline.drink,
            'Count': orderline.count,
            'Sugar': orderline.sugar,
            'Milk': orderline.milk,
            'OrderTime': new Date()
        });
    };
    OrderService.prototype.putOrderline = function (orderline) {
        return this.api.put('/OrderLines/' + orderline.orderLineId, {
            'OrderLineId': orderline.orderLineId,
            'Customer': {
                'userId': orderline.customer.userId
            },
            'Server': {
                'userId': orderline.server.userId
            },
            'Drink': {
                'drinkId': orderline.drink.drinkId,
                'drinkName': orderline.drink.drinkName
            },
            'Count': orderline.count,
            'Sugar': orderline.sugar,
            'Milk': orderline.milk,
            'GetTime': new Date(),
            'OrderStatus': {
                'orderStatusId': orderline.orderStatus.orderStatusId,
                'statusName': orderline.orderStatus.statusName
            }
        });
    };
    OrderService = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Injectable"])({
            providedIn: 'root'
        }),
        __metadata("design:paramtypes", [src_app_core_services_auth_service__WEBPACK_IMPORTED_MODULE_1__["AuthService"], _api_service__WEBPACK_IMPORTED_MODULE_2__["ApiService"]])
    ], OrderService);
    return OrderService;
}());



/***/ }),

/***/ "./src/app/core/services/preference.service.ts":
/*!*****************************************************!*\
  !*** ./src/app/core/services/preference.service.ts ***!
  \*****************************************************/
/*! exports provided: PreferenceService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PreferenceService", function() { return PreferenceService; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _api_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./api.service */ "./src/app/core/services/api.service.ts");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm5/operators/index.js");
/* harmony import */ var _auth_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./auth.service */ "./src/app/core/services/auth.service.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};




var PreferenceService = /** @class */ (function () {
    function PreferenceService(api, auth) {
        this.api = api;
        this.auth = auth;
    }
    PreferenceService.prototype.putPreference = function (availableCoffee, milkcnt, sugarcnt) {
        return this.api.put('/drinkpreferences/byuserid/' + this.auth.getDecodedToken().nameid, {
            'User': {
                'userId': this.auth.getDecodedToken().nameid
            },
            'Drink': availableCoffee,
            'Milk': milkcnt,
            'Sugar': sugarcnt
        }).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_2__["map"])(function (obj) {
            var drinkpreference = {
                preferenceId: obj['preferenceId'],
                user: obj['user'],
                drink: obj['drink'],
                milk: obj['milk'],
                sugar: obj['sugar']
            };
            return drinkpreference;
        }));
    };
    PreferenceService.prototype.getPreference = function () {
        return this.api.get('/drinkpreferences/byuserid/' + this.auth.getDecodedToken().nameid).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_2__["map"])(function (obj) {
            var drinkpreference = {
                preferenceId: obj['preferenceId'],
                user: obj['user'],
                drink: obj['drink'],
                milk: obj['milk'],
                sugar: obj['sugar']
            };
            return drinkpreference;
        }));
    };
    PreferenceService = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Injectable"])({
            providedIn: 'root'
        }),
        __metadata("design:paramtypes", [_api_service__WEBPACK_IMPORTED_MODULE_1__["ApiService"], _auth_service__WEBPACK_IMPORTED_MODULE_3__["AuthService"]])
    ], PreferenceService);
    return PreferenceService;
}());



/***/ }),

/***/ "./src/app/modules/order/choice/choice.component.html":
/*!************************************************************!*\
  !*** ./src/app/modules/order/choice/choice.component.html ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row\">\r\n    <div class=\"col-sm-5 mx-auto\">\r\n        <div class=\"card\">\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-12\">\r\n                    <button type=\"button\" class=\"close close-star float-left\" (click)=\"submitPreference(availableCoffee, milkcnt, sugarcnt)\"\r\n                        *ngIf=\"userPreference.drink == null || userPreference.drink.drinkId != availableCoffee.drinkId\">\r\n                        <i class=\"fa fa-star-o fa-lg\" aria-hidden=\"true\"></i>\r\n                    </button>\r\n                    <button type=\"button\" class=\"close close-star float-left\" (click)=\"emptyPreference()\" *ngIf=\"userPreference.drink != null && userPreference.drink.drinkId == availableCoffee.drinkId\">\r\n                        <i class=\"fa fa-star fa-lg\" aria-hidden=\"true\"></i>\r\n                    </button>\r\n                    <button type=\"button\" class=\"close close-times\" aria-label=\"Close\" [routerLink]=\"['/dashboard']\">\r\n                        <i class=\"fa fa-times fa-lg\" aria-hidden=\"true\"></i>\r\n                    </button>\r\n                </div>\r\n            </div>\r\n\r\n            <img class=\"card-img-top mx-auto\" src=\"{{availableCoffee.imageUrl}}\" alt=\"Card image cap\" />\r\n\r\n            <div class=\"card-body\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-12 mb-3\">\r\n                        <h3 class=\"card-title text-center\">{{ availableCoffee.drinkName }}</h3>\r\n                        <div class=\"card-text text-center\">Een overheerlijk bakje {{ availableCoffee.drinkName }}!</div>\r\n                    </div>\r\n\r\n                    <div class=\"col-12\">\r\n                        <form>\r\n                            <div class=\"form-group row\">\r\n                                <label class=\"col-sm-3 col-form-label\">Aantal</label>\r\n                                <div class=\"col-sm-9 input-group\">\r\n                                    <div class=\"input-group-prepend\">\r\n                                        <button type=\"button\" class=\"btn btn-primary\" (click)=\"drinkCountDown()\">\r\n                                            -\r\n                                        </button>\r\n                                    </div>\r\n                                    <input type=\"number\" class=\"form-control text-center\" value=\"{{ newAantal }}\">\r\n                                    <div class=\"input-group-append\">\r\n                                        <button type=\"button\" class=\"btn btn-primary\" (click)=\"drinkCountUp()\">\r\n                                            +\r\n                                        </button>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group row\" *ngIf=\"availableCoffee.additions\">\r\n                                <label class=\"col-sm-3 col-form-label\">Melk</label>\r\n                                <div class=\"col-sm-9 input-group\">\r\n                                    <div class=\"input-group-prepend\">\r\n                                        <button type=\"button\" class=\"btn btn-primary\" (click)=\"milkCountDown()\">\r\n                                            -\r\n                                        </button>\r\n                                    </div>\r\n                                    <input type=\"number\" class=\"form-control text-center\" value=\"{{ milkcnt }}\">\r\n                                    <div class=\"input-group-append\">\r\n                                        <button type=\"button\" class=\"btn btn-primary\" (click)=\"milkCountUp()\">\r\n                                            +\r\n                                        </button>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group row\" *ngIf=\"availableCoffee.additions\">\r\n                                <label class=\"col-sm-3 col-form-label\">Suiker</label>\r\n                                <div class=\"col-sm-9 input-group\">\r\n                                    <div class=\"input-group-prepend\">\r\n                                        <button type=\"button\" class=\"btn btn-primary\" (click)=\"sugarCountDown()\">\r\n                                            -\r\n                                        </button>\r\n                                    </div>\r\n                                    <input type=\"number\" class=\"form-control text-center\" value=\"{{ sugarcnt }}\">\r\n                                    <div class=\"input-group-append\">\r\n                                        <button type=\"button\" class=\"btn btn-primary\" (click)=\"sugarCountUp()\">\r\n                                            +\r\n                                        </button>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group mb-0\">\r\n                                <button class=\"btn btn-success btn-lg btn-block btn-bestellen\" (click)=\"addToOrder(availableCoffee, newAantal, milkcnt, sugarcnt);\">\r\n                                    Bestellen!\r\n                                </button>\r\n                            </div>\r\n\r\n                        </form>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>"

/***/ }),

/***/ "./src/app/modules/order/choice/choice.component.scss":
/*!************************************************************!*\
  !*** ./src/app/modules/order/choice/choice.component.scss ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".card {\n  width: auto;\n  max-width: 50rem;\n  margin: auto;\n  border-color: black; }\n\nimg {\n  max-height: 15em;\n  max-width: 15em; }\n\n.fa-star-o,\n.fa-star {\n  color: #FFC107; }\n\n.fa-time {\n  color: #000;\n  text-decoration: none;\n  opacity: .75; }\n\n.close-star {\n  margin-left: 15px;\n  margin-top: 12px;\n  opacity: 1; }\n\n.close-times {\n  margin-right: 15px;\n  margin-top: 12px; }\n"

/***/ }),

/***/ "./src/app/modules/order/choice/choice.component.ts":
/*!**********************************************************!*\
  !*** ./src/app/modules/order/choice/choice.component.ts ***!
  \**********************************************************/
/*! exports provided: ChoiceComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ChoiceComponent", function() { return ChoiceComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _core_services_Available_coffee_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../../core/services/Available-coffee.service */ "./src/app/core/services/Available-coffee.service.ts");
/* harmony import */ var _core_services_order_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../core/services/order.service */ "./src/app/core/services/order.service.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _core_services_auth_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../../core/services/auth.service */ "./src/app/core/services/auth.service.ts");
/* harmony import */ var _core_services_preference_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../../../core/services/preference.service */ "./src/app/core/services/preference.service.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};






var ChoiceComponent = /** @class */ (function () {
    function ChoiceComponent(availableCoffeeService, preferenceService, orderService, activatedRoute, router, auth) {
        this.availableCoffeeService = availableCoffeeService;
        this.preferenceService = preferenceService;
        this.orderService = orderService;
        this.activatedRoute = activatedRoute;
        this.router = router;
        this.auth = auth;
        this.milkcnt = 0;
        this.sugarcnt = 0;
        this.newAantal = 1;
        this.availableCoffee = {
            drinkId: '',
            drinkName: '',
            available: null,
            additions: null,
            imageUrl: ''
        };
        this.id = '';
        this.userPreference = {
            preferenceId: '',
            drink: {
                drinkId: '',
                drinkName: '',
                available: null,
                additions: null,
                imageUrl: ''
            },
            user: null,
            milk: null,
            sugar: null
        };
    }
    ChoiceComponent.prototype.ngOnInit = function () {
        var _this = this;
        var id = this.activatedRoute.snapshot.params['coffeeId'];
        this.availableCoffeeService.getSingleCoffee(id).subscribe(function (drink) {
            _this.availableCoffee = drink;
        }, console.error);
        this.preferenceService.getPreference().subscribe(function (preference) {
            _this.userPreference = preference;
        }, console.error);
    };
    ChoiceComponent.prototype.addToOrder = function (drink, count, milk, sugar) {
        var _this = this;
        var orderline = {
            orderLineId: '',
            customer: {
                userId: this.auth.getDecodedToken().nameid,
                firstName: '',
                lastName: ''
            },
            drink: drink,
            count: count,
            milk: milk,
            sugar: sugar
        };
        this.orderService.postOrderline(orderline).subscribe(function (result) {
            _this.router.navigate(['/dashboard']);
        }, console.error);
    };
    ChoiceComponent.prototype.milkCountUp = function () {
        if (this.milkcnt < 3) {
            this.milkcnt++;
        }
    };
    ChoiceComponent.prototype.milkCountDown = function () {
        if (this.milkcnt >= 1) {
            this.milkcnt--;
        }
    };
    ChoiceComponent.prototype.sugarCountUp = function () {
        if (this.sugarcnt < 3) {
            this.sugarcnt++;
        }
    };
    ChoiceComponent.prototype.sugarCountDown = function () {
        if (this.sugarcnt >= 1) {
            this.sugarcnt--;
        }
    };
    ChoiceComponent.prototype.drinkCountUp = function () {
        this.newAantal++;
    };
    ChoiceComponent.prototype.drinkCountDown = function () {
        if (this.newAantal > 1) {
            this.newAantal--;
        }
    };
    ChoiceComponent.prototype.submitPreference = function (availableCoffee, milkcnt, sugarcnt) {
        var _this = this;
        this.preferenceService.putPreference(availableCoffee, milkcnt, sugarcnt).subscribe(function (preference) {
            _this.userPreference = preference;
        }, console.error);
    };
    ChoiceComponent.prototype.emptyPreference = function () {
        var _this = this;
        this.preferenceService.putPreference(null, null, null).subscribe(function (preference) {
            _this.userPreference = preference;
        }, console.error);
    };
    ChoiceComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-choice',
            template: __webpack_require__(/*! ./choice.component.html */ "./src/app/modules/order/choice/choice.component.html"),
            styles: [__webpack_require__(/*! ./choice.component.scss */ "./src/app/modules/order/choice/choice.component.scss")]
        }),
        __metadata("design:paramtypes", [_core_services_Available_coffee_service__WEBPACK_IMPORTED_MODULE_1__["AvailableCoffeeService"],
            _core_services_preference_service__WEBPACK_IMPORTED_MODULE_5__["PreferenceService"],
            _core_services_order_service__WEBPACK_IMPORTED_MODULE_2__["OrderService"],
            _angular_router__WEBPACK_IMPORTED_MODULE_3__["ActivatedRoute"],
            _angular_router__WEBPACK_IMPORTED_MODULE_3__["Router"],
            _core_services_auth_service__WEBPACK_IMPORTED_MODULE_4__["AuthService"]])
    ], ChoiceComponent);
    return ChoiceComponent;
}());



/***/ }),

/***/ "./src/app/modules/order/favorite/favorite.component.html":
/*!****************************************************************!*\
  !*** ./src/app/modules/order/favorite/favorite.component.html ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row\" *ngIf=\"userPreference.drink != null\">\r\n    <div class=\"col-12\">\r\n        <button type=\"button\" class=\"close\" (click)=\"emptyPreference()\">\r\n            <i class=\"fa fa-star fa-lg\"></i>\r\n        </button>\r\n    </div>\r\n    <div class=\"col-6\">\r\n        <img class=\"m-auto d-block\" src=\"{{ userPreference.drink.imageUrl }}\">\r\n    </div>\r\n    <div class=\"col-6\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <h4 class=\"text-center\">Uw favoriete drank!</h4>\r\n            </div>\r\n            <div class=\"col-12\">\r\n                <p class=\"text-center\">\r\n                    Bestel met één druk op de knop uw {{ userPreference.drink.drinkName }}!\r\n                </p>\r\n            </div>\r\n            <div class=\"col-12\">\r\n                <form>\r\n                    <div class=\"form-group row\" *ngIf=\"userPreference.drink.additions\">\r\n                        <label class=\"col-sm-3 col-form-label\">Melk</label>\r\n                        <div class=\"col-sm-9 input-group\">\r\n                            <div class=\"input-group-prepend\">\r\n                                <button type=\"button\" class=\"btn btn-primary\" (click)=\"milkCountDown()\">\r\n                                    -\r\n                                </button>\r\n                            </div>\r\n                            <input type=\"number\" class=\"form-control text-center\" value=\"{{ milkcnt }}\" min=\"0\" max=\"3\">\r\n                            <div class=\"input-group-append\">\r\n                                <button type=\"button\" class=\"btn btn-primary\" (click)=\"milkCountUp()\">\r\n                                    +\r\n                                </button>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group row\" *ngIf=\"userPreference.drink.additions\">\r\n                        <label class=\"col-sm-3 col-form-label\">Suiker</label>\r\n                        <div class=\"col-sm-9 input-group\">\r\n                            <div class=\"input-group-prepend\">\r\n                                <button type=\"button\" class=\"btn btn-primary\" (click)=\"sugarCountDown()\">\r\n                                    -\r\n                                </button>\r\n                            </div>\r\n                            <input type=\"number\" class=\"form-control text-center\" value=\"{{ sugarcnt }}\" min=\"0\" max=\"3\">\r\n                            <div class=\"input-group-append\">\r\n                                <button type=\"button\" class=\"btn btn-primary\" (click)=\"sugarCountUp()\">\r\n                                    +\r\n                                </button>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <button type=\"button\" class=\"btn btn-block btn-success btn-lg\" (click)=\"addToOrder(userPreference.drink, milkcnt, sugarcnt)\">\r\n                            Bestellen!\r\n                        </button>\r\n                    </div>\r\n                </form>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>"

/***/ }),

/***/ "./src/app/modules/order/favorite/favorite.component.scss":
/*!****************************************************************!*\
  !*** ./src/app/modules/order/favorite/favorite.component.scss ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".fa {\n  color: #FFC107; }\n\nimg {\n  max-height: 15em;\n  max-width: 15em; }\n\n.close {\n  position: absolute;\n  top: 0;\n  right: 15px;\n  z-index: 100;\n  opacity: 1; }\n"

/***/ }),

/***/ "./src/app/modules/order/favorite/favorite.component.ts":
/*!**************************************************************!*\
  !*** ./src/app/modules/order/favorite/favorite.component.ts ***!
  \**************************************************************/
/*! exports provided: FavoriteComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "FavoriteComponent", function() { return FavoriteComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var src_app_core_services_preference_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! src/app/core/services/preference.service */ "./src/app/core/services/preference.service.ts");
/* harmony import */ var src_app_core_services_order_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! src/app/core/services/order.service */ "./src/app/core/services/order.service.ts");
/* harmony import */ var src_app_core_services_auth_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! src/app/core/services/auth.service */ "./src/app/core/services/auth.service.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};




var FavoriteComponent = /** @class */ (function () {
    function FavoriteComponent(preferenceService, orderService, auth) {
        this.preferenceService = preferenceService;
        this.orderService = orderService;
        this.auth = auth;
        this.notifyFavorite = new _angular_core__WEBPACK_IMPORTED_MODULE_0__["EventEmitter"]();
        this.notifyPlaced = new _angular_core__WEBPACK_IMPORTED_MODULE_0__["EventEmitter"]();
        this.milkcnt = 0;
        this.sugarcnt = 0;
        this.userPreference = {
            preferenceId: '',
            drink: {
                drinkId: '',
                drinkName: '',
                available: null,
                additions: null,
                imageUrl: ''
            },
            user: null,
            milk: null,
            sugar: null
        };
    }
    FavoriteComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.preferenceService.getPreference().subscribe(function (userPreference) {
            _this.userPreference = userPreference;
            _this.milkcnt = userPreference.milk;
            _this.sugarcnt = userPreference.sugar;
        }, console.error, function () {
            _this.notifyFavorite.emit(_this.userPreference);
        });
    };
    FavoriteComponent.prototype.addToOrder = function (drink, milk, sugar) {
        var _this = this;
        var orderline = {
            orderLineId: '',
            customer: {
                userId: this.auth.getDecodedToken().nameid,
                firstName: '',
                lastName: ''
            },
            drink: drink,
            count: 1,
            milk: milk,
            sugar: sugar
        };
        this.orderService.postOrderline(orderline).subscribe(function () {
            _this.notifyPlaced.emit();
        }, console.error);
    };
    FavoriteComponent.prototype.milkCountUp = function () {
        if (this.milkcnt < 3) {
            this.milkcnt++;
            this.submitPreference();
        }
    };
    FavoriteComponent.prototype.milkCountDown = function () {
        if (this.milkcnt >= 1) {
            this.milkcnt--;
            this.submitPreference();
        }
    };
    FavoriteComponent.prototype.sugarCountUp = function () {
        if (this.sugarcnt < 3) {
            this.sugarcnt++;
            this.submitPreference();
        }
    };
    FavoriteComponent.prototype.sugarCountDown = function () {
        if (this.sugarcnt >= 1) {
            this.sugarcnt--;
            this.submitPreference();
        }
    };
    FavoriteComponent.prototype.submitPreference = function () {
        var _this = this;
        this.preferenceService.putPreference(this.userPreference.drink, this.milkcnt, this.sugarcnt).subscribe(function (preference) {
            _this.userPreference = preference;
        }, console.error);
    };
    FavoriteComponent.prototype.emptyPreference = function () {
        var _this = this;
        this.preferenceService.putPreference(null, null, null).subscribe(function (preference) {
            _this.userPreference = preference;
        }, console.error, function () {
            _this.notifyFavorite.emit(_this.userPreference);
        });
    };
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Output"])(),
        __metadata("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_0__["EventEmitter"])
    ], FavoriteComponent.prototype, "notifyFavorite", void 0);
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Output"])(),
        __metadata("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_0__["EventEmitter"])
    ], FavoriteComponent.prototype, "notifyPlaced", void 0);
    FavoriteComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-favorite',
            template: __webpack_require__(/*! ./favorite.component.html */ "./src/app/modules/order/favorite/favorite.component.html"),
            styles: [__webpack_require__(/*! ./favorite.component.scss */ "./src/app/modules/order/favorite/favorite.component.scss")]
        }),
        __metadata("design:paramtypes", [src_app_core_services_preference_service__WEBPACK_IMPORTED_MODULE_1__["PreferenceService"],
            src_app_core_services_order_service__WEBPACK_IMPORTED_MODULE_2__["OrderService"],
            src_app_core_services_auth_service__WEBPACK_IMPORTED_MODULE_3__["AuthService"]])
    ], FavoriteComponent);
    return FavoriteComponent;
}());



/***/ }),

/***/ "./src/app/modules/order/order-routing.module.ts":
/*!*******************************************************!*\
  !*** ./src/app/modules/order/order-routing.module.ts ***!
  \*******************************************************/
/*! exports provided: OrderRoutingModule, routedComponents */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "OrderRoutingModule", function() { return OrderRoutingModule; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "routedComponents", function() { return routedComponents; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _order_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./order.component */ "./src/app/modules/order/order.component.ts");
/* harmony import */ var _place_place_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./place/place.component */ "./src/app/modules/order/place/place.component.ts");
/* harmony import */ var _overview_overview_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./overview/overview.component */ "./src/app/modules/order/overview/overview.component.ts");
/* harmony import */ var _choice_choice_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./choice/choice.component */ "./src/app/modules/order/choice/choice.component.ts");
/* harmony import */ var _favorite_favorite_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./favorite/favorite.component */ "./src/app/modules/order/favorite/favorite.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};







var routes = [
    {
        path: '',
        component: _order_component__WEBPACK_IMPORTED_MODULE_2__["OrderComponent"],
        children: [
            { path: 'coffees/:coffeeId', component: _choice_choice_component__WEBPACK_IMPORTED_MODULE_5__["ChoiceComponent"] },
            { path: 'coffees', component: _place_place_component__WEBPACK_IMPORTED_MODULE_3__["PlaceComponent"] },
            { path: 'overview', component: _overview_overview_component__WEBPACK_IMPORTED_MODULE_4__["OverviewComponent"] },
            { path: 'favorite', component: _favorite_favorite_component__WEBPACK_IMPORTED_MODULE_6__["FavoriteComponent"] },
            { path: '', redirectTo: 'coffees', pathMatch: 'full' }
        ]
    }
];
var OrderRoutingModule = /** @class */ (function () {
    function OrderRoutingModule() {
    }
    OrderRoutingModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"].forChild(routes)],
            exports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"]]
        })
    ], OrderRoutingModule);
    return OrderRoutingModule;
}());

var routedComponents = [
    _order_component__WEBPACK_IMPORTED_MODULE_2__["OrderComponent"],
    _place_place_component__WEBPACK_IMPORTED_MODULE_3__["PlaceComponent"],
    _overview_overview_component__WEBPACK_IMPORTED_MODULE_4__["OverviewComponent"],
    _choice_choice_component__WEBPACK_IMPORTED_MODULE_5__["ChoiceComponent"],
    _favorite_favorite_component__WEBPACK_IMPORTED_MODULE_6__["FavoriteComponent"]
];


/***/ }),

/***/ "./src/app/modules/order/order.component.html":
/*!****************************************************!*\
  !*** ./src/app/modules/order/order.component.html ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<router-outlet></router-outlet>\r\n"

/***/ }),

/***/ "./src/app/modules/order/order.component.scss":
/*!****************************************************!*\
  !*** ./src/app/modules/order/order.component.scss ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/modules/order/order.component.ts":
/*!**************************************************!*\
  !*** ./src/app/modules/order/order.component.ts ***!
  \**************************************************/
/*! exports provided: OrderComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "OrderComponent", function() { return OrderComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};

var OrderComponent = /** @class */ (function () {
    function OrderComponent() {
    }
    OrderComponent.prototype.ngOnInit = function () { };
    OrderComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-order',
            template: __webpack_require__(/*! ./order.component.html */ "./src/app/modules/order/order.component.html"),
            styles: [__webpack_require__(/*! ./order.component.scss */ "./src/app/modules/order/order.component.scss")]
        }),
        __metadata("design:paramtypes", [])
    ], OrderComponent);
    return OrderComponent;
}());



/***/ }),

/***/ "./src/app/modules/order/order.module.ts":
/*!***********************************************!*\
  !*** ./src/app/modules/order/order.module.ts ***!
  \***********************************************/
/*! exports provided: OrderModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "OrderModule", function() { return OrderModule; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _order_routing_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! .//order-routing.module */ "./src/app/modules/order/order-routing.module.ts");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};




var OrderModule = /** @class */ (function () {
    function OrderModule() {
    }
    OrderModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [_angular_common__WEBPACK_IMPORTED_MODULE_1__["CommonModule"], _order_routing_module__WEBPACK_IMPORTED_MODULE_2__["OrderRoutingModule"], _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"]],
            declarations: _order_routing_module__WEBPACK_IMPORTED_MODULE_2__["routedComponents"].slice(),
            exports: _order_routing_module__WEBPACK_IMPORTED_MODULE_2__["routedComponents"].slice()
        })
    ], OrderModule);
    return OrderModule;
}());



/***/ }),

/***/ "./src/app/modules/order/overview/overview.component.html":
/*!****************************************************************!*\
  !*** ./src/app/modules/order/overview/overview.component.html ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row\">\r\n    <div class=\"col-12 mb-3\">\r\n        <ul class=\"list-group shadow bg-white rounded\">\r\n            <li class=\"list-group-item d-flex justify-content-between\" *ngFor=\"let order of orderlines\">\r\n                <div class=\"row d-inline-flex w-100\">\r\n                    <div class=\"col-12\">\r\n                        {{ order.count }} x {{ order.drink.drinkName }}\r\n                        <span class=\"float-right\">{{ order.customer.firstName }} {{ order.customer.lastName }}</span>\r\n                    </div>\r\n                    <div class=\"col-12\" *ngIf=\"order.server\">\r\n                        <small class=\"text-muted\">\r\n                            <span *ngIf=\"order.milk > 0\">Melk: {{ order.milk }}</span>\r\n                            <span *ngIf=\"order.milk > 0 && order.sugar > 0\"> & </span>\r\n                            <span *ngIf=\"order.sugar > 0\">Suiker: {{ order.sugar }}</span>\r\n                        </small>\r\n                    </div>\r\n                </div>\r\n            </li>\r\n        </ul>\r\n    </div>\r\n    <div class=\"col-12\" *ngIf=\"showButton\">\r\n        <button type=\"button\" class=\"btn btn-success btn-lg btn-block\" (click)=\"gaHalen()\">Ik ga deze bestelling halen!</button>\r\n    </div>\r\n</div>"

/***/ }),

/***/ "./src/app/modules/order/overview/overview.component.scss":
/*!****************************************************************!*\
  !*** ./src/app/modules/order/overview/overview.component.scss ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/modules/order/overview/overview.component.ts":
/*!**************************************************************!*\
  !*** ./src/app/modules/order/overview/overview.component.ts ***!
  \**************************************************************/
/*! exports provided: OverviewComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "OverviewComponent", function() { return OverviewComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _core_services_order_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../../core/services/order.service */ "./src/app/core/services/order.service.ts");
/* harmony import */ var _core_services_Available_coffee_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../core/services/Available-coffee.service */ "./src/app/core/services/Available-coffee.service.ts");
/* harmony import */ var src_app_core_services_auth_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! src/app/core/services/auth.service */ "./src/app/core/services/auth.service.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};




var OverviewComponent = /** @class */ (function () {
    function OverviewComponent(orderService, availableCoffeeService, auth) {
        this.orderService = orderService;
        this.availableCoffeeService = availableCoffeeService;
        this.auth = auth;
        this.notify = new _angular_core__WEBPACK_IMPORTED_MODULE_0__["EventEmitter"]();
        this.orderlines = [];
        this.availableCoffees = [];
        this.orderStatussen = [];
        this.orderSnapshot = [];
        this.showButton = false;
    }
    OverviewComponent.prototype.ngOnInit = function () {
        var _this = this;
        var getCoffee = this.availableCoffeeService.getCoffee();
        var getOrders = this.orderService.getOrders();
        var getStatus = this.orderService.getStatussen();
        getCoffee.subscribe(function (drink) {
            _this.availableCoffees.push(drink);
        }, console.error);
        getOrders.subscribe(function (orderline) {
            _this.orderlines.push(orderline);
            _this.showButton = true;
        }, console.error, function () {
            _this.notify.emit(_this.orderlines);
        });
        getStatus.subscribe(function (orderstatus) {
            _this.orderStatussen.push(orderstatus);
        }, console.error);
    };
    OverviewComponent.prototype.refreshOrders = function () {
        var _this = this;
        this.orderlines = [];
        var getOrders = this.orderService.getOrders();
        getOrders.subscribe(function (orderline) {
            _this.orderlines.push(orderline);
            _this.showButton = true;
        }, console.error, function () {
            _this.notify.emit(_this.orderlines);
        });
    };
    OverviewComponent.prototype.gaHalen = function () {
        for (var _i = 0, _a = this.orderlines; _i < _a.length; _i++) {
            var orderline = _a[_i];
            if (orderline.orderStatus.statusName.toLowerCase() === 'ordered') {
                orderline.halen = true;
                var me = {
                    userId: this.auth.getDecodedToken().nameid,
                    firstName: '',
                    lastName: ''
                };
                orderline.server = me;
                orderline.orderStatus = this.orderStatussen.find(function (status) { return status.statusName.toString().toLowerCase() === 'finished'; });
                this.orderService.putOrderline(orderline).subscribe(null, console.error);
            }
        }
        this.showButton = false;
    };
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Output"])(),
        __metadata("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_0__["EventEmitter"])
    ], OverviewComponent.prototype, "notify", void 0);
    OverviewComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-overview',
            template: __webpack_require__(/*! ./overview.component.html */ "./src/app/modules/order/overview/overview.component.html"),
            styles: [__webpack_require__(/*! ./overview.component.scss */ "./src/app/modules/order/overview/overview.component.scss")]
        }),
        __metadata("design:paramtypes", [_core_services_order_service__WEBPACK_IMPORTED_MODULE_1__["OrderService"],
            _core_services_Available_coffee_service__WEBPACK_IMPORTED_MODULE_2__["AvailableCoffeeService"],
            src_app_core_services_auth_service__WEBPACK_IMPORTED_MODULE_3__["AuthService"]])
    ], OverviewComponent);
    return OverviewComponent;
}());



/***/ }),

/***/ "./src/app/modules/order/place/place.component.html":
/*!**********************************************************!*\
  !*** ./src/app/modules/order/place/place.component.html ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row\">\r\n    <div class=\"col-sm-6 mb-4\" *ngFor=\"let availableCoffee of availableCoffees\">\r\n        <a [routerLink]=\"[ '/order/coffees/', availableCoffee.drinkId ]\">\r\n            <div class=\"card row-overzicht shadow bg-white rounded\">\r\n                <img class=\"card-img-top mx-auto\" src=\"{{ availableCoffee.imageUrl }}\">\r\n                <div class=\"card-body\">\r\n                    <h4 class=\"card-title text-center\">{{ availableCoffee.drinkName }}</h4>\r\n                </div>\r\n            </div>\r\n        </a>\r\n    </div>\r\n</div>"

/***/ }),

/***/ "./src/app/modules/order/place/place.component.scss":
/*!**********************************************************!*\
  !*** ./src/app/modules/order/place/place.component.scss ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "img {\n  max-height: 15em;\n  max-width: 15em; }\n\n.row {\n  margin-bottom: -24px; }\n"

/***/ }),

/***/ "./src/app/modules/order/place/place.component.ts":
/*!********************************************************!*\
  !*** ./src/app/modules/order/place/place.component.ts ***!
  \********************************************************/
/*! exports provided: PlaceComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PlaceComponent", function() { return PlaceComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _core_services_Available_coffee_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../../../core/services/Available-coffee.service */ "./src/app/core/services/Available-coffee.service.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


var PlaceComponent = /** @class */ (function () {
    function PlaceComponent(availableCoffeeService) {
        this.availableCoffeeService = availableCoffeeService;
        this.availableCoffees = [];
    }
    PlaceComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.availableCoffeeService.getCoffee().subscribe(function (drink) {
            _this.availableCoffees.push(drink);
        }, console.error, function () {
            _this.availableCoffees = _this.availableCoffees.sort(function (a, b) {
                if (a.drinkName.toLowerCase() > b.drinkName.toLowerCase()) {
                    return 1;
                }
                if (b.drinkName.toLowerCase() > a.drinkName.toLowerCase()) {
                    return -1;
                }
                return 0;
            });
        });
    };
    PlaceComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-place',
            template: __webpack_require__(/*! ./place.component.html */ "./src/app/modules/order/place/place.component.html"),
            styles: [__webpack_require__(/*! ./place.component.scss */ "./src/app/modules/order/place/place.component.scss")]
        }),
        __metadata("design:paramtypes", [_core_services_Available_coffee_service__WEBPACK_IMPORTED_MODULE_1__["AvailableCoffeeService"]])
    ], PlaceComponent);
    return PlaceComponent;
}());



/***/ })

}]);
//# sourceMappingURL=modules-dashboard-dashboard-module~modules-order-order-module.js.map
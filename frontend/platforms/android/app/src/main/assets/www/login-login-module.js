(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["login-login-module"],{

/***/ "./src/app/login/login-routing.module.ts":
/*!***********************************************!*\
  !*** ./src/app/login/login-routing.module.ts ***!
  \***********************************************/
/*! exports provided: LoginRoutingModule, routedComponents */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LoginRoutingModule", function() { return LoginRoutingModule; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "routedComponents", function() { return routedComponents; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _login_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./login.component */ "./src/app/login/login.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};



var routes = [
    {
        path: '',
        component: _login_component__WEBPACK_IMPORTED_MODULE_2__["LoginComponent"]
    },
];
var LoginRoutingModule = /** @class */ (function () {
    function LoginRoutingModule() {
    }
    LoginRoutingModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"].forChild(routes)],
            exports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"]]
        })
    ], LoginRoutingModule);
    return LoginRoutingModule;
}());

var routedComponents = [
    _login_component__WEBPACK_IMPORTED_MODULE_2__["LoginComponent"]
];


/***/ }),

/***/ "./src/app/login/login.component.html":
/*!********************************************!*\
  !*** ./src/app/login/login.component.html ***!
  \********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<h1 class=\"site-heading text-center text-white d-none d-lg-block\">\r\n    <span class=\"site-heading-upper text-primary mb-3\">de lekkerste koffie van nederland</span>\r\n    <span class=\"site-heading-lower\">business as unusual</span>\r\n</h1>\r\n\r\n<section class=\"page-section clearfix\">\r\n    <div class=\"container\">\r\n        <div class=\"intro\">\r\n            <img class=\"intro-img img-fluid mb-3 mb-lg-0 rounded\" src=\"/assets/Images/landing_intro.jpg\" alt=\"\">\r\n            <div class=\"intro-text left-0 text-center bg-faded p-5 rounded\">\r\n                <h2 class=\"section-heading mb-4\">\r\n                    <span class=\"section-heading-upper\">het drinken waard</span>\r\n                    <span class=\"section-heading-lower\">verse koffie</span>\r\n                </h2>\r\n                <div class=\"mb-2 mx-auto p-4\" *ngIf=\"!loggedIn()\">\r\n                    <div class=\"form-group\" (keydown.enter)=\"login()\">\r\n                        <input type=\"text\" class=\"form-control mb-1\" name=\"username\" (input)=\"username = $event.target.value\"\r\n                            autocomplete=\"username\" placeholder=\"Gebruikersnaam\">\r\n                        <div class=\"input-group\">\r\n                            <input type=\"{{ passType }}\" class=\"form-control input-password\" name=\"password\" (input)=\"password = $event.target.value\"\r\n                                autocomplete=\"current-password\" placeholder=\"Wachtwoord\" data-toggle=\"password\">\r\n                            <div class=\"input-group-addon\" id=\"show_hide_password\">\r\n                                <i (click)=\"togglePassword()\" class=\"fa fa-eye-slash btn-showpassword\" aria-hidden=\"true\"></i>\r\n                            </div>\r\n                        </div>\r\n                    \r\n                    <div *ngIf=\"authError\">\r\n                            <div class=\"alert alert-danger mx-auto mt-1\">\r\n                                 Gebruikersnaam of wachtwoord onjuist.\r\n                                </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"intro-button mx-auto\">\r\n                    <a class=\"btn btn-primary btn-xl\" (click)=\"login()\">Inloggen!</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<!-- <div class=\"container\">\r\n    <div class=\"row\" *ngIf=\"!loggedIn()\">\r\n        <div class=\"col-6\">\r\n            <div class=\"card mx-auto mt-4 back-yellow\">\r\n                <div class=\"card-header\">\r\n                    Login\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <form (keydown.enter)=\"login()\">\r\n                        <div class=\"form-group\">\r\n                            <label>Username</label>\r\n                            <input type=\"text\" class=\"form-control\" name=\"username\" (input)=\"username = $event.target.value\"\r\n                                autocomplete=\"username\">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label>Password</label>\r\n                            <input type=\"{{ passType }}\" class=\"form-control\" name=\"password\" (input)=\"password = $event.target.value\"\r\n                                autocomplete=\"current-password\">\r\n                        </div>\r\n                        <button type=\"button\" (click)=\"togglePassword()\" class=\"btn btn-block btn-outline-secondary\">Show\r\n                            Password</button>\r\n                        <hr>\r\n                        <button type=\"button\" (click)=\"login()\" class=\"btn btn-block btn-yellow\" [disabled]=\"awaitingResponse\">Login</button>\r\n                    </form>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-12\" *ngIf=\"authError\">\r\n            <div class=\"alert alert-danger mx-auto mt-4\">\r\n                <table>\r\n                    <tr>\r\n                        <td class=\"icon-cell\">\r\n                            <i class=\"fa fa-lg fa-fw fa-exclamation-circle\"></i>\r\n                        </td>\r\n                        <td>\r\n                            De gebruikersnaam of het wachtwoord is ongeldig.\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div> -->"

/***/ }),

/***/ "./src/app/login/login.component.scss":
/*!********************************************!*\
  !*** ./src/app/login/login.component.scss ***!
  \********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "p {\n  line-height: 1.75; }\n\n.text-faded {\n  color: rgba(255, 255, 255, 0.3); }\n\n.site-heading {\n  margin-top: 5rem;\n  margin-bottom: 5rem;\n  text-transform: uppercase;\n  line-height: 1;\n  font-family: 'Raleway'; }\n\n.site-heading .site-heading-upper {\n  display: block;\n  font-size: 2rem;\n  font-weight: 800; }\n\n.site-heading .site-heading-lower {\n  font-size: 5rem;\n  font-weight: 100;\n  line-height: 4rem; }\n\n.page-section {\n  margin-top: 5rem;\n  margin-bottom: 5rem; }\n\n.section-heading {\n  text-transform: uppercase; }\n\n.section-heading .section-heading-upper {\n  display: block;\n  font-size: 1rem;\n  font-weight: 800; }\n\n.section-heading .section-heading-lower {\n  display: block;\n  font-size: 3rem;\n  font-weight: 100; }\n\n.bg-faded {\n  background-color: rgba(255, 255, 255, 0.85); }\n\n.btn-xl {\n  color: white !important;\n  font-weight: 700;\n  font-size: 1.5rem;\n  padding-top: 1.5rem;\n  padding-bottom: 1.5rem;\n  padding-left: 6rem;\n  padding-right: 6rem; }\n\n.btn {\n  box-shadow: 0px 3px 3px 0px rgba(33, 37, 41, 0.1); }\n\n.btn-primary {\n  background-color: #e6a756;\n  border-color: #e6a756; }\n\n.btn-primary:hover,\n.btn-primary:focus,\n.btn-primary:active {\n  background-color: #df902a;\n  border-color: #df902a; }\n\n.intro {\n  position: relative; }\n\n@media (min-width: 992px) {\n  .intro .intro-img {\n    width: 75%;\n    float: right; }\n  .intro .intro-text {\n    left: 0;\n    width: 60%;\n    margin-top: 3rem;\n    position: absolute; }\n  .intro .intro-text .intro-button {\n    width: 100%;\n    left: 0;\n    position: absolute;\n    bottom: -2rem; } }\n\n@media (min-width: 1200px) {\n  .intro .intro-text {\n    width: 45%; } }\n\n.cta {\n  padding-top: 5rem;\n  padding-bottom: 5rem;\n  background-color: rgba(230, 167, 86, 0.9); }\n\n.cta .cta-inner {\n  position: relative;\n  padding: 3rem;\n  margin: 0.5rem;\n  background-color: rgba(255, 255, 255, 0.85); }\n\n.cta .cta-inner:before {\n  border-radius: 0.5rem;\n  content: '';\n  position: absolute;\n  top: -0.5rem;\n  bottom: -0.5rem;\n  left: -0.5rem;\n  right: -0.5rem;\n  border: 0.25rem solid rgba(255, 255, 255, 0.85); }\n\n.text-primary {\n  color: #e6a756 !important; }\n\n.bg-primary {\n  background-color: #e6a756 !important; }\n\n.btn {\n  box-shadow: 0px 3px 3px 0px rgba(33, 37, 41, 0.1); }\n\n.form-control {\n  height: 3em; }\n\n.btn-showpassword {\n  display: flex;\n  justify-content: center;\n  align-items: center;\n  background: white;\n  height: 3em;\n  width: 3em;\n  padding: auto;\n  border: 1px solid #ced4da;\n  border-left: 0;\n  border-radius: 0.25rem;\n  border-top-left-radius: 0;\n  border-bottom-left-radius: 0; }\n\n.input-password {\n  border-right: 0;\n  border-top-right-radius: 0;\n  border-bottom-right-radius: 0; }\n"

/***/ }),

/***/ "./src/app/login/login.component.ts":
/*!******************************************!*\
  !*** ./src/app/login/login.component.ts ***!
  \******************************************/
/*! exports provided: LoginComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LoginComponent", function() { return LoginComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _core_services_auth_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../core/services/auth.service */ "./src/app/core/services/auth.service.ts");
/* harmony import */ var _core_services_api_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../core/services/api.service */ "./src/app/core/services/api.service.ts");
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




var LoginComponent = /** @class */ (function () {
    function LoginComponent(route, router, api, auth) {
        this.route = route;
        this.router = router;
        this.api = api;
        this.auth = auth;
        this.passType = 'password';
        this.username = '';
        this.password = '';
        this.logout = this.auth.logout;
        this.awaitingResponse = false;
        this.authError = false;
    }
    LoginComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/dashboard';
        this.api.awaitingResponse.subscribe(function (state) { _this.awaitingResponse = state; });
    };
    LoginComponent.prototype.togglePassword = function () {
        if (this.passType === 'password') {
            this.passType = 'text';
        }
        else {
            this.passType = 'password';
        }
    };
    LoginComponent.prototype.login = function () {
        var _this = this;
        this.authError = false;
        this.auth.login(this.username, this.password).subscribe(function () {
            _this.router.navigateByUrl(_this.returnUrl);
        }, function () {
            _this.authError = true;
        });
    };
    LoginComponent.prototype.loggedIn = function () {
        return this.auth.isLoggedIn();
    };
    LoginComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-login',
            template: __webpack_require__(/*! ./login.component.html */ "./src/app/login/login.component.html"),
            styles: [__webpack_require__(/*! ./login.component.scss */ "./src/app/login/login.component.scss")]
        }),
        __metadata("design:paramtypes", [_angular_router__WEBPACK_IMPORTED_MODULE_3__["ActivatedRoute"],
            _angular_router__WEBPACK_IMPORTED_MODULE_3__["Router"],
            _core_services_api_service__WEBPACK_IMPORTED_MODULE_2__["ApiService"],
            _core_services_auth_service__WEBPACK_IMPORTED_MODULE_1__["AuthService"]])
    ], LoginComponent);
    return LoginComponent;
}());



/***/ }),

/***/ "./src/app/login/login.module.ts":
/*!***************************************!*\
  !*** ./src/app/login/login.module.ts ***!
  \***************************************/
/*! exports provided: LoginModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LoginModule", function() { return LoginModule; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _login_routing_module__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! .//login-routing.module */ "./src/app/login/login-routing.module.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};




var LoginModule = /** @class */ (function () {
    function LoginModule() {
    }
    LoginModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_1__["CommonModule"],
                _login_routing_module__WEBPACK_IMPORTED_MODULE_3__["LoginRoutingModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormsModule"]
            ],
            declarations: _login_routing_module__WEBPACK_IMPORTED_MODULE_3__["routedComponents"].slice()
        })
    ], LoginModule);
    return LoginModule;
}());



/***/ })

}]);
//# sourceMappingURL=login-login-module.js.map
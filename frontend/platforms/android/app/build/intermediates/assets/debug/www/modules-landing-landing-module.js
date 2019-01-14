(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["modules-landing-landing-module"],{

/***/ "./src/app/modules/landing/landing-routing.module.ts":
/*!***********************************************************!*\
  !*** ./src/app/modules/landing/landing-routing.module.ts ***!
  \***********************************************************/
/*! exports provided: LandingRoutingModule, routedComponents */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LandingRoutingModule", function() { return LandingRoutingModule; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "routedComponents", function() { return routedComponents; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _landing_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./landing.component */ "./src/app/modules/landing/landing.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};



var routes = [
    {
        path: '',
        component: _landing_component__WEBPACK_IMPORTED_MODULE_2__["LandingComponent"],
    }
];
var LandingRoutingModule = /** @class */ (function () {
    function LandingRoutingModule() {
    }
    LandingRoutingModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"].forChild(routes)],
            exports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"]]
        })
    ], LandingRoutingModule);
    return LandingRoutingModule;
}());

var routedComponents = [
    _landing_component__WEBPACK_IMPORTED_MODULE_2__["LandingComponent"]
];


/***/ }),

/***/ "./src/app/modules/landing/landing.component.html":
/*!********************************************************!*\
  !*** ./src/app/modules/landing/landing.component.html ***!
  \********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<!-- https://github.com/BlackrockDigital/startbootstrap-business-casual -->\r\n<h1 class=\"site-heading text-center text-white d-none d-lg-block\">\r\n    <span class=\"site-heading-upper text-primary mb-3\">de lekkerste koffie van nederland</span>\r\n    <span class=\"site-heading-lower\">business as unusual</span>\r\n</h1>\r\n\r\n<section class=\"page-section clearfix\">\r\n    <div class=\"container\">\r\n        <div class=\"intro\">\r\n            <img class=\"intro-img img-fluid mb-3 mb-lg-0 rounded\" src=\"/assets/Images/landing_intro.jpg\" alt=\"\">\r\n            <div class=\"intro-text left-0 text-center bg-faded p-5 rounded\">\r\n                <h2 class=\"section-heading mb-4\">\r\n                    <span class=\"section-heading-upper\">het drinken waard</span>\r\n                    <span class=\"section-heading-lower\">verse koffie</span>\r\n                </h2>\r\n                <p class=\"mb-3\">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi sit amet nibh\r\n                    tincidunt ex viverra aliquet eget sed metus. Maecenas ut risus vel nulla faucibus sollicitudin\r\n                    vel a ipsum. Quisque vestibulum finibus nisl, ac aliquam ipsum volutpat ac. Suspendisse vitae\r\n                    magna ut sapien commodo tristique vel ac massa. Fusce rhoncus suscipit nunc a interdum.\r\n                </p>\r\n                <div class=\"intro-button mx-auto\">\r\n                    <a class=\"btn btn-primary btn-xl\" (click)=\"toLogin()\">Log hier in!</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<section class=\"page-section cta rounded\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-xl-9 mx-auto\">\r\n                <div class=\"cta-inner text-center rounded\">\r\n                    <h2 class=\"section-heading mb-4\">\r\n                        <span class=\"section-heading-upper\">de lekkerste koffie</span>\r\n                        <span class=\"section-heading-lower\">speciaal voor jou</span>\r\n                    </h2>\r\n                    <p class=\"mb-0\">Suspendisse sed neque malesuada, dictum libero eu, lacinia metus. Duis posuere\r\n                        elementum rhoncus. Mauris velit dolor, dignissim quis laoreet eu, faucibus et libero. Fusce\r\n                        id sapien dignissim, ornare nulla nec, interdum turpis. Mauris eu arcu malesuada, tempor\r\n                        purus ac, tempor dolor. Donec sed mauris efficitur, ornare nisi nec, dapibus nisl. Quisque\r\n                        at libero molestie, hendrerit metus vel, elementum diam. In hac habitasse platea dictumst.</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>"

/***/ }),

/***/ "./src/app/modules/landing/landing.component.scss":
/*!********************************************************!*\
  !*** ./src/app/modules/landing/landing.component.scss ***!
  \********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "p {\n  line-height: 1.75; }\n\n.text-faded {\n  color: rgba(255, 255, 255, 0.3); }\n\n.site-heading {\n  margin-top: 5rem;\n  margin-bottom: 5rem;\n  text-transform: uppercase;\n  line-height: 1;\n  font-family: 'Raleway'; }\n\n.site-heading .site-heading-upper {\n  display: block;\n  font-size: 2rem;\n  font-weight: 800; }\n\n.site-heading .site-heading-lower {\n  font-size: 5rem;\n  font-weight: 100;\n  line-height: 4rem; }\n\n.page-section {\n  margin-top: 5rem;\n  margin-bottom: 5rem; }\n\n.section-heading {\n  text-transform: uppercase; }\n\n.section-heading .section-heading-upper {\n  display: block;\n  font-size: 1rem;\n  font-weight: 800; }\n\n.section-heading .section-heading-lower {\n  display: block;\n  font-size: 3rem;\n  font-weight: 100; }\n\n.bg-faded {\n  background-color: rgba(255, 255, 255, 0.85); }\n\n.btn-xl {\n  color: white !important;\n  font-weight: 700;\n  font-size: 1.5rem;\n  padding-top: 1.5rem;\n  padding-bottom: 1.5rem;\n  padding-left: 6rem;\n  padding-right: 6rem; }\n\n.btn {\n  box-shadow: 0px 3px 3px 0px rgba(33, 37, 41, 0.1); }\n\n.btn-primary {\n  background-color: #e6a756;\n  border-color: #e6a756; }\n\n.btn-primary:hover,\n.btn-primary:focus,\n.btn-primary:active {\n  background-color: #df902a;\n  border-color: #df902a; }\n\n.intro {\n  position: relative; }\n\n@media (min-width: 992px) {\n  .intro .intro-img {\n    width: 75%;\n    float: right; }\n  .intro .intro-text {\n    left: 0;\n    width: 60%;\n    margin-top: 3rem;\n    position: absolute; }\n  .intro .intro-text .intro-button {\n    width: 100%;\n    left: 0;\n    position: absolute;\n    bottom: -2rem; } }\n\n@media (min-width: 1200px) {\n  .intro .intro-text {\n    width: 45%; } }\n\n.cta {\n  padding-top: 5rem;\n  padding-bottom: 5rem;\n  background-color: rgba(230, 167, 86, 0.9); }\n\n.cta .cta-inner {\n  position: relative;\n  padding: 3rem;\n  margin: 0.5rem;\n  background-color: rgba(255, 255, 255, 0.85); }\n\n.cta .cta-inner:before {\n  border-radius: 0.5rem;\n  content: '';\n  position: absolute;\n  top: -0.5rem;\n  bottom: -0.5rem;\n  left: -0.5rem;\n  right: -0.5rem;\n  border: 0.25rem solid rgba(255, 255, 255, 0.85); }\n\n.text-primary {\n  color: #e6a756 !important; }\n\n.bg-primary {\n  background-color: #e6a756 !important; }\n\n.btn {\n  box-shadow: 0px 3px 3px 0px rgba(33, 37, 41, 0.1); }\n"

/***/ }),

/***/ "./src/app/modules/landing/landing.component.ts":
/*!******************************************************!*\
  !*** ./src/app/modules/landing/landing.component.ts ***!
  \******************************************************/
/*! exports provided: LandingComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LandingComponent", function() { return LandingComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var src_app_core_services_auth_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! src/app/core/services/auth.service */ "./src/app/core/services/auth.service.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var LandingComponent = /** @class */ (function () {
    function LandingComponent(auth, router) {
        this.auth = auth;
        this.router = router;
    }
    LandingComponent.prototype.ngOnInit = function () {
    };
    LandingComponent.prototype.toLogin = function () {
        if (this.auth.isLoggedIn()) {
            this.router.navigateByUrl('/dashboard');
        }
        else {
            this.router.navigateByUrl('/login');
        }
    };
    LandingComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-landing',
            template: __webpack_require__(/*! ./landing.component.html */ "./src/app/modules/landing/landing.component.html"),
            styles: [__webpack_require__(/*! ./landing.component.scss */ "./src/app/modules/landing/landing.component.scss")]
        }),
        __metadata("design:paramtypes", [src_app_core_services_auth_service__WEBPACK_IMPORTED_MODULE_1__["AuthService"],
            _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"]])
    ], LandingComponent);
    return LandingComponent;
}());



/***/ }),

/***/ "./src/app/modules/landing/landing.module.ts":
/*!***************************************************!*\
  !*** ./src/app/modules/landing/landing.module.ts ***!
  \***************************************************/
/*! exports provided: LandingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LandingModule", function() { return LandingModule; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _landing_routing_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./landing-routing.module */ "./src/app/modules/landing/landing-routing.module.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};



var LandingModule = /** @class */ (function () {
    function LandingModule() {
    }
    LandingModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_1__["CommonModule"], _landing_routing_module__WEBPACK_IMPORTED_MODULE_2__["LandingRoutingModule"]
            ],
            declarations: _landing_routing_module__WEBPACK_IMPORTED_MODULE_2__["routedComponents"].slice()
        })
    ], LandingModule);
    return LandingModule;
}());



/***/ })

}]);
//# sourceMappingURL=modules-landing-landing-module.js.map
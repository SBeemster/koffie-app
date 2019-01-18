(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["modules-dashboard-dashboard-module~modules-user-user-module"],{

/***/ "./src/app/core/services/user.service.ts":
/*!***********************************************!*\
  !*** ./src/app/core/services/user.service.ts ***!
  \***********************************************/
/*! exports provided: UserService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UserService", function() { return UserService; });
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



var UserService = /** @class */ (function () {
    function UserService(api) {
        this.api = api;
    }
    UserService.prototype.getAll = function () {
        return this.api.get('/users/').pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_2__["concatAll"])(), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_2__["map"])(function (obj) {
            var user = {
                userId: obj['userId'],
                firstName: obj['firstName'],
                lastName: obj['lastName'],
                active: obj['active']
            };
            return user;
        }));
    };
    UserService.prototype.getSingleUser = function (id) {
        return this.api.get('/users/' + id).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_2__["concatAll"])(), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_2__["map"])(function (obj) {
            var user = {
                userId: obj['userId'],
                firstName: obj['firstName'],
                lastName: obj['lastName'],
                userroles: obj['userRoles'],
                active: obj['active']
            };
            return user;
        }));
    };
    UserService.prototype.saveUser = function (userName, password, roles, firstName, lastName) {
        return this.api.post('/users', {
            'UserName': userName,
            'Password': password,
            'UserRoles': roles,
            'FirstName': firstName,
            'LastName': lastName
        });
    };
    UserService.prototype.editUser = function (user) {
        return this.api.put('/users/' + user.userId, {
            active: user['active'],
            firstName: user['firstName'],
            lastName: user['lastName'],
            userId: user['userId'],
            UserRoles: user.userroles,
        });
    };
    UserService = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Injectable"])({
            providedIn: 'root'
        }),
        __metadata("design:paramtypes", [_api_service__WEBPACK_IMPORTED_MODULE_1__["ApiService"]])
    ], UserService);
    return UserService;
}());



/***/ }),

/***/ "./src/app/modules/user/create/create.component.html":
/*!***********************************************************!*\
  !*** ./src/app/modules/user/create/create.component.html ***!
  \***********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row\">\r\n    <div class=\"card mx-auto mt-4\">\r\n        <div class=\"card-header\">\r\n            Nieuwe Gebruiker\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <form (keydown.enter)=\"createUser()\">\r\n                <div class=\"form-group\">\r\n                    <label>Gebruikersnaam</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"username\" [(ngModel)]=\"userName\" autocomplete=\"username\">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Wachtwoord</label>\r\n                    <input type=\"{{ passType }}\" class=\"form-control\" name=\"password\" [(ngModel)]=\"password\"\r\n                        autocomplete=\"current-password\">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                <button type=\"button\" (mousedown)=\"togglePassword()\" (mouseup)=\"togglePassword()\" tabindex=\"-1\" class=\"btn btn-block btn-outline-secondary\">Show\r\n                    Password</button>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Rol</label><br />\r\n                    \r\n                      <input type=\"checkbox\" name=\"rolAdmin\" [(ngModel)]=\"rolAdmin\">Admin<br />\r\n                      <input type=\"checkbox\" name=\"rolManager\" [(ngModel)]=\"rolManager\">Manager<br />\r\n                      <input type=\"checkbox\" name=\"rolUSer\" [(ngModel)]=\"rolUser\">User<br />\r\n                </div>\r\n                <hr>\r\n                <div class=\"form-group\">\r\n                    <label>Voornaam</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"firstName\" [(ngModel)]=\"firstName\" autocomplete=\"given-name\">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Achternaam</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"lastName\" [(ngModel)]=\"lastName\" autocomplete=\"family-name\">\r\n                </div>\r\n                <button type=\"button\" (click)=\"createUser()\" class=\"btn btn-block btn-success\">Toevoegen</button>\r\n            </form>\r\n        </div>\r\n    </div>\r\n</div>"

/***/ }),

/***/ "./src/app/modules/user/create/create.component.scss":
/*!***********************************************************!*\
  !*** ./src/app/modules/user/create/create.component.scss ***!
  \***********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".card {\n  width: 20rem; }\n"

/***/ }),

/***/ "./src/app/modules/user/create/create.component.ts":
/*!*********************************************************!*\
  !*** ./src/app/modules/user/create/create.component.ts ***!
  \*********************************************************/
/*! exports provided: CreateComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CreateComponent", function() { return CreateComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var src_app_core_services_user_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! src/app/core/services/user.service */ "./src/app/core/services/user.service.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var CreateComponent = /** @class */ (function () {
    function CreateComponent(userService, router) {
        this.userService = userService;
        this.router = router;
        this.passType = 'password';
        this.rol = 'User';
        this.rolAdmin = false;
        this.rolManager = false;
        this.rolUser = true;
    }
    CreateComponent.prototype.togglePassword = function () {
        if (this.passType === 'password') {
            this.passType = 'text';
        }
        else {
            this.passType = 'password';
        }
    };
    CreateComponent.prototype.createUser = function () {
        var _this = this;
        var roles = [];
        if (this.rolAdmin) {
            roles.push({ Role: {
                    roleName: 'Admin'
                }
            });
        }
        if (this.rolManager) {
            roles.push({ Role: {
                    roleName: 'Manager'
                }
            });
        }
        if (this.rolUser) {
            roles.push({ Role: {
                    roleName: 'User'
                }
            });
        }
        this.userService.saveUser(this.userName, this.password, roles, this.firstName, this.lastName).subscribe(function (result) {
            _this.router.navigateByUrl('/dashboard');
        }, console.error);
    };
    CreateComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-create',
            template: __webpack_require__(/*! ./create.component.html */ "./src/app/modules/user/create/create.component.html"),
            styles: [__webpack_require__(/*! ./create.component.scss */ "./src/app/modules/user/create/create.component.scss")]
        }),
        __metadata("design:paramtypes", [src_app_core_services_user_service__WEBPACK_IMPORTED_MODULE_2__["UserService"],
            _angular_router__WEBPACK_IMPORTED_MODULE_1__["Router"]])
    ], CreateComponent);
    return CreateComponent;
}());



/***/ }),

/***/ "./src/app/modules/user/edit/edit.component.html":
/*!*******************************************************!*\
  !*** ./src/app/modules/user/edit/edit.component.html ***!
  \*******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row\">\r\n    <div class=\"card mx-auto mt-4\" *ngIf=\"userLoaded\">\r\n        <div class=\"card-header\">\r\n            Nieuwe Gebruiker\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <form (keydown.enter)=\"saveUser()\">\r\n                <div class=\"form-group\">\r\n                    <label>Gebruikers ID</label>\r\n                    <p>{{ user.userId }}</p>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Voornaam</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"firstName\" [(ngModel)]=\"user.firstName\" autocomplete=\"given-name\">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Achternaam</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"lastName\" [(ngModel)]=\"user.lastName\" autocomplete=\"family-name\">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Rol</label><br />\r\n                    \r\n                      <input type=\"checkbox\" name=\"rolAdmin\" [(ngModel)]=\"rolAdmin\">Admin<br />\r\n                      <input type=\"checkbox\" name=\"rolManager\" [(ngModel)]=\"rolManager\">Manager<br />\r\n                      <input type=\"checkbox\" name=\"rolUser\" [(ngModel)]=\"rolUser\">User<br />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Actief</label>\r\n                    <input type=\"checkbox\" class=\"form-control\" name=\"active\" [(ngModel)]=\"user.active\">\r\n                </div>\r\n                <button type=\"button\" (click)=\"saveUser()\" class=\"btn btn-block btn-success\">Opslaan</button>\r\n                <button type=\"button\" [routerLink]=\"['/dashboard']\" class=\"btn btn-block btn-danger\">Cancel</button>\r\n            </form>\r\n        </div>\r\n    </div>\r\n</div>"

/***/ }),

/***/ "./src/app/modules/user/edit/edit.component.scss":
/*!*******************************************************!*\
  !*** ./src/app/modules/user/edit/edit.component.scss ***!
  \*******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/modules/user/edit/edit.component.ts":
/*!*****************************************************!*\
  !*** ./src/app/modules/user/edit/edit.component.ts ***!
  \*****************************************************/
/*! exports provided: EditComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "EditComponent", function() { return EditComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var src_app_core_services_user_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! src/app/core/services/user.service */ "./src/app/core/services/user.service.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var EditComponent = /** @class */ (function () {
    function EditComponent(userService, activatedRoute, router) {
        this.userService = userService;
        this.activatedRoute = activatedRoute;
        this.router = router;
        this.userLoaded = false;
    }
    EditComponent.prototype.ngOnInit = function () {
        var _this = this;
        var userId = this.activatedRoute.snapshot.params['userId'];
        if (userId) {
            this.userService.getSingleUser(userId).subscribe(function (user) {
                _this.user = user;
                _this.userLoaded = true;
            }, console.error, function () {
                if (_this.user.userroles.find(function (userrole) { return userrole.role.roleName.toString().toLowerCase() === 'admin'; })) {
                    _this.rolAdmin = true;
                }
                if (_this.user.userroles.find(function (userrole) { return userrole.role.roleName.toString().toLowerCase() === 'manager'; })) {
                    _this.rolManager = true;
                }
                if (_this.user.userroles.find(function (userrole) { return userrole.role.roleName.toString().toLowerCase() === 'user'; })) {
                    _this.rolUser = true;
                }
            });
        }
    };
    EditComponent.prototype.saveUser = function () {
        var _this = this;
        this.user.userroles = [];
        if (this.rolAdmin) {
            var rol = {
                roleName: 'Admin'
            };
            var userRole = {
                role: rol
            };
            this.user.userroles.push(userRole);
        }
        if (this.rolManager) {
            var rol = {
                roleName: 'Manager'
            };
            var userRole = {
                role: rol
            };
            this.user.userroles.push(userRole);
        }
        if (this.rolUser) {
            var rol = {
                roleName: 'User'
            };
            var userRole = {
                role: rol
            };
            this.user.userroles.push(userRole);
        }
        this.userService.editUser(this.user).subscribe(function (response) {
            _this.router.navigate(['dashboard']);
        }, console.error);
    };
    EditComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-edit',
            template: __webpack_require__(/*! ./edit.component.html */ "./src/app/modules/user/edit/edit.component.html"),
            styles: [__webpack_require__(/*! ./edit.component.scss */ "./src/app/modules/user/edit/edit.component.scss")]
        }),
        __metadata("design:paramtypes", [src_app_core_services_user_service__WEBPACK_IMPORTED_MODULE_2__["UserService"],
            _angular_router__WEBPACK_IMPORTED_MODULE_1__["ActivatedRoute"],
            _angular_router__WEBPACK_IMPORTED_MODULE_1__["Router"]])
    ], EditComponent);
    return EditComponent;
}());



/***/ }),

/***/ "./src/app/modules/user/group/group.component.html":
/*!*********************************************************!*\
  !*** ./src/app/modules/user/group/group.component.html ***!
  \*********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"card mt-3\" *ngIf=\"groupFound\">\r\n            <div class=\"card-header\" *ngIf=\"!isOwner\">\r\n                {{ group.groupName }}\r\n            </div>\r\n            <div class=\"card-header btn-header\" *ngIf=\"isOwner\">\r\n                <form>\r\n                    <div class=\"input-group\">\r\n                        <input type=\"text\" readonly class=\"form-control\" [ngModel]=\"group.groupName\" name=\"groupname\"\r\n                            *ngIf=\"!edit\">\r\n                        <input type=\"text\" class=\"form-control\" [(ngModel)]=\"newName\" name=\"groupname\" *ngIf=\"edit\">\r\n                        <div class=\"input-group-append\">\r\n                            <button class=\"btn btn-secondary\" (click)=\"edit = true\" *ngIf=\"!edit\">\r\n                                <i class=\"fa fa-fw fa-edit\"></i>\r\n                            </button>\r\n                            <button class=\"btn btn-success\" type=\"submit\" (click)=\"renameGroup()\" *ngIf=\"edit\">\r\n                                <i class=\"fa fa-fw fa-save\"></i>\r\n                            </button>\r\n                            <button class=\"btn btn-danger\" (click)=\"deleteGroup(group)\">\r\n                                <i class=\"fa fa-fw fa-trash\"></i>\r\n                            </button>\r\n                        </div>\r\n                    </div>\r\n                </form>\r\n            </div>\r\n            <div class=\"card-body\">\r\n\r\n                <div class=\"mb-3\">\r\n                    <h5>\r\n                        Groepsleden\r\n                    </h5>\r\n                    <ul class=\"list-group shadow bg-white rounded\">\r\n                        <li class=\"list-group-item\" *ngFor=\"let member of group.members\">\r\n                            {{ member.firstName }} {{ member.lastName }}\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n\r\n                <div *ngIf=\"!isOwner\">\r\n                    <form>\r\n                        <button class=\"btn btn-block btn-danger\" (click)=\"leaveGroup()\">\r\n                            Groep Verlaten\r\n                        </button>\r\n                    </form>\r\n                </div>\r\n\r\n                <div *ngIf=\"isOwner\">\r\n                    <form (ngSubmit)=\"addUser();\">\r\n                        <div class=\"input-group\">\r\n                            <input type=\"text\" class=\"form-control\" placeholder=\"Voeg een gebruiker toe (gebruikersnaam)\"\r\n                                [(ngModel)]=\"username\" name=\"username\">\r\n                            <div class=\"input-group-append\">\r\n                                <button class=\"btn btn-success\" type=\"submit\">\r\n                                    <i class=\"fa fa-fw fa-plus\"></i>\r\n                                </button>\r\n                            </div>\r\n                        </div>\r\n                    </form>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"card mt-3\" *ngIf=\"noGroup\">\r\n            <div class=\"card-header\">\r\n                <form (ngSubmit)=\"newGroup();\">\r\n                    <div class=\"input-group\">\r\n                        <input type=\"text\" class=\"form-control\" placeholder=\"Verzin een naam\" [(ngModel)]=\"newName\"\r\n                            name=\"groupname\">\r\n                        <div class=\"input-group-append\">\r\n                            <button class=\"btn btn-success\" type=\"submit\">\r\n                                <i class=\"fa fa-fw fa-save\"></i>\r\n                            </button>\r\n                        </div>\r\n                    </div>\r\n                </form>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                U bent nog geen lid van een koffie groep. <br> Verzin om te beginnen een naam voor uw koffie groep.\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n<!-- Bootstrap modal for messages -->\r\n<div #myModal class=\"modal fade\" role=\"dialog\">\r\n    <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n        <div class=\"modal-content\">\r\n            <div class=\"modal-header\">\r\n                <h5 class=\"modal-title\">{{ messageHeader }}</h5>\r\n                <button type=\"button\" class=\"close\" (click)=\"closeModal()\" aria-label=\"Close\">\r\n                    <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                <p>{{ messageBody }}</p>\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\" (click)=\"closeModal()\">\r\n                    Sluiten\r\n                </button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>"

/***/ }),

/***/ "./src/app/modules/user/group/group.component.scss":
/*!*********************************************************!*\
  !*** ./src/app/modules/user/group/group.component.scss ***!
  \*********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".show {\n  display: block; }\n\n.btn-header {\n  line-height: 38px; }\n\n.btn-header input {\n    line-height: 32px; }\n\n.clearfix::after {\n  display: block;\n  content: \"\";\n  clear: both; }\n"

/***/ }),

/***/ "./src/app/modules/user/group/group.component.ts":
/*!*******************************************************!*\
  !*** ./src/app/modules/user/group/group.component.ts ***!
  \*******************************************************/
/*! exports provided: GroupComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "GroupComponent", function() { return GroupComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var src_app_core_services_group_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! src/app/core/services/group.service */ "./src/app/core/services/group.service.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};



var GroupComponent = /** @class */ (function () {
    function GroupComponent(activatedRoute, groupService, router) {
        this.activatedRoute = activatedRoute;
        this.groupService = groupService;
        this.router = router;
        this.group = {
            groupId: '',
            groupName: ''
        };
        this.noGroup = false;
        this.groupFound = false;
        this.isOwner = false;
        this.edit = false;
        this.newName = '';
        this.username = '';
    }
    GroupComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.groupService.getMyGroup().subscribe(function (response) {
            if (response) {
                _this.group = response;
                _this.groupFound = true;
                _this.noGroup = false;
            }
            else {
                _this.groupFound = false;
                _this.noGroup = true;
            }
        }, console.error, function () {
            var groupId = _this.group.groupId;
            if (groupId) {
                _this.populatePage(groupId);
            }
            else {
                _this.noGroup = true;
            }
        });
    };
    GroupComponent.prototype.renameGroup = function () {
        var _this = this;
        if (this.newName.length < 3) {
            this.messageHeader = 'Groepsnaam te kort';
            this.messageBody = 'U heeft een groepsnaam opgeven die te kort is. Probeer een naam van minimaal 3 tekens.';
            this.openModal();
            return;
        }
        else {
            this.group.groupName = this.newName;
            this.edit = false;
            this.groupService.putGroup(this.group).subscribe(function () {
                _this.groupService.header.refreshGroup();
            }, console.error);
        }
    };
    GroupComponent.prototype.newGroup = function () {
        var _this = this;
        if (this.newName.length < 3) {
            this.messageHeader = 'Groepsnaam te kort';
            this.messageBody = 'U heeft een groepsnaam opgeven die te kort is. Probeer een naam van minimaal 3 tekens.';
            this.openModal();
            return;
        }
        else {
            this.groupService.postGroup(this.newName).subscribe(function (groupId) {
                _this.groupService.header.refreshGroup();
                _this.noGroup = false;
                _this.populatePage(groupId);
            }, console.error);
        }
    };
    GroupComponent.prototype.deleteGroup = function () {
        var _this = this;
        this.groupService.deleteGroup(this.group.groupId).subscribe(function () {
            _this.groupService.header.refreshGroup();
            _this.router.navigate(['/dashboard']);
        }, console.error, function () {
            _this.refreshGroup();
        });
    };
    GroupComponent.prototype.leaveGroup = function () {
        var _this = this;
        this.groupService.leaveGroup(this.group.groupId).subscribe(function () {
            _this.groupService.header.refreshGroup();
            _this.router.navigate(['/dashboard']);
        }, console.error, function () {
            _this.refreshGroup();
        });
    };
    GroupComponent.prototype.addUser = function () {
        var _this = this;
        this.groupService.addUser(this.group.groupId, this.username).subscribe(function () {
            _this.populatePage(_this.group.groupId);
        }, function (error) {
            if (error.status === 409) {
                _this.messageHeader = 'Conflict';
                _this.messageBody = 'De gebruiker die u geprobeerd heeft toe te voegen is waarschijnlijk al lid van een koffie groep.';
                _this.openModal();
                return;
            }
            if (error.status === 404) {
                _this.messageHeader = 'Niet Gevonden';
                _this.messageBody = 'De gebruiker die u geprobeerd heeft toe te voegen is niet gevonden.';
                _this.openModal();
                return;
            }
        });
    };
    GroupComponent.prototype.openModal = function () {
        this.myModal.nativeElement.className = 'modal fade show';
        var div = document.createElement('div');
        div.className = 'modal-backdrop fade show';
        document.body.appendChild(div);
    };
    GroupComponent.prototype.closeModal = function () {
        this.myModal.nativeElement.className = 'modal hide';
        var divList = document.body.getElementsByClassName('modal-backdrop');
        for (var i = 0; i < divList.length; i++) {
            var div = divList.item(i);
            div.remove();
        }
    };
    GroupComponent.prototype.refreshGroup = function () {
        var _this = this;
        this.groupService.getMyGroup().subscribe(function (response) {
            if (response) {
                _this.group = response;
                _this.groupFound = true;
                _this.noGroup = false;
            }
            else {
                _this.groupFound = false;
                _this.noGroup = true;
            }
        });
    };
    GroupComponent.prototype.populatePage = function (groupId) {
        var _this = this;
        this.edit = false;
        this.newName = '';
        this.username = '';
        this.groupService.getGroupById(groupId).subscribe(function (response) {
            _this.group = response;
            _this.groupFound = true;
            _this.completeObservable();
        }, console.error);
        this.groupService.getIsGroupOwner(groupId).subscribe(function (response) {
            _this.isOwner = response;
            _this.completeObservable();
        }, console.error);
    };
    GroupComponent.prototype.completeObservable = function () {
        if (this.groupFound && this.isOwner) {
            this.edit = false;
            this.newName = this.group.groupName;
        }
    };
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ViewChild"])('myModal'),
        __metadata("design:type", Object)
    ], GroupComponent.prototype, "myModal", void 0);
    GroupComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-group',
            template: __webpack_require__(/*! ./group.component.html */ "./src/app/modules/user/group/group.component.html"),
            styles: [__webpack_require__(/*! ./group.component.scss */ "./src/app/modules/user/group/group.component.scss")]
        }),
        __metadata("design:paramtypes", [_angular_router__WEBPACK_IMPORTED_MODULE_1__["ActivatedRoute"],
            src_app_core_services_group_service__WEBPACK_IMPORTED_MODULE_2__["GroupService"],
            _angular_router__WEBPACK_IMPORTED_MODULE_1__["Router"]])
    ], GroupComponent);
    return GroupComponent;
}());



/***/ }),

/***/ "./src/app/modules/user/select/select.component.html":
/*!***********************************************************!*\
  !*** ./src/app/modules/user/select/select.component.html ***!
  \***********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <ul class=\"list-group shadow bg-white rounded\">\r\n            <li class=\"list-group-item d-flex justify-content-between\" *ngFor=\"let user of users\">\r\n                <a [routerLink]=\"['/user/edit', user.userId]\">\r\n                    {{ user.firstName }} {{ user.lastName }}\r\n                </a>\r\n            </li>\r\n        </ul>\r\n    </div>\r\n</div>"

/***/ }),

/***/ "./src/app/modules/user/select/select.component.scss":
/*!***********************************************************!*\
  !*** ./src/app/modules/user/select/select.component.scss ***!
  \***********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/modules/user/select/select.component.ts":
/*!*********************************************************!*\
  !*** ./src/app/modules/user/select/select.component.ts ***!
  \*********************************************************/
/*! exports provided: SelectComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SelectComponent", function() { return SelectComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var src_app_core_services_user_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! src/app/core/services/user.service */ "./src/app/core/services/user.service.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};


var SelectComponent = /** @class */ (function () {
    function SelectComponent(userService) {
        this.userService = userService;
        this.users = [];
    }
    SelectComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.userService.getAll().subscribe(function (user) {
            _this.users.push(user);
        }, function (error) {
            console.error(error);
        });
    };
    SelectComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-select',
            template: __webpack_require__(/*! ./select.component.html */ "./src/app/modules/user/select/select.component.html"),
            styles: [__webpack_require__(/*! ./select.component.scss */ "./src/app/modules/user/select/select.component.scss")]
        }),
        __metadata("design:paramtypes", [src_app_core_services_user_service__WEBPACK_IMPORTED_MODULE_1__["UserService"]])
    ], SelectComponent);
    return SelectComponent;
}());



/***/ }),

/***/ "./src/app/modules/user/user-routing.module.ts":
/*!*****************************************************!*\
  !*** ./src/app/modules/user/user-routing.module.ts ***!
  \*****************************************************/
/*! exports provided: UserRoutingModule, routedComponents */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UserRoutingModule", function() { return UserRoutingModule; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "routedComponents", function() { return routedComponents; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _user_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./user.component */ "./src/app/modules/user/user.component.ts");
/* harmony import */ var _group_group_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./group/group.component */ "./src/app/modules/user/group/group.component.ts");
/* harmony import */ var _create_create_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./create/create.component */ "./src/app/modules/user/create/create.component.ts");
/* harmony import */ var _edit_edit_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./edit/edit.component */ "./src/app/modules/user/edit/edit.component.ts");
/* harmony import */ var _select_select_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./select/select.component */ "./src/app/modules/user/select/select.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};







var routes = [
    {
        path: '',
        component: _user_component__WEBPACK_IMPORTED_MODULE_2__["UserComponent"],
        children: [
            { path: 'group', component: _group_group_component__WEBPACK_IMPORTED_MODULE_3__["GroupComponent"] },
            { path: 'group/:groupId', component: _group_group_component__WEBPACK_IMPORTED_MODULE_3__["GroupComponent"] },
            { path: 'create', component: _create_create_component__WEBPACK_IMPORTED_MODULE_4__["CreateComponent"] },
            { path: 'select', component: _select_select_component__WEBPACK_IMPORTED_MODULE_6__["SelectComponent"] },
            { path: 'edit/:userId', component: _edit_edit_component__WEBPACK_IMPORTED_MODULE_5__["EditComponent"] },
            { path: '', redirectTo: 'group', pathMatch: 'full' }
        ]
    },
];
var UserRoutingModule = /** @class */ (function () {
    function UserRoutingModule() {
    }
    UserRoutingModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"].forChild(routes)],
            exports: [_angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"]]
        })
    ], UserRoutingModule);
    return UserRoutingModule;
}());

var routedComponents = [
    _user_component__WEBPACK_IMPORTED_MODULE_2__["UserComponent"],
    _group_group_component__WEBPACK_IMPORTED_MODULE_3__["GroupComponent"],
    _create_create_component__WEBPACK_IMPORTED_MODULE_4__["CreateComponent"],
    _edit_edit_component__WEBPACK_IMPORTED_MODULE_5__["EditComponent"],
    _select_select_component__WEBPACK_IMPORTED_MODULE_6__["SelectComponent"]
];


/***/ }),

/***/ "./src/app/modules/user/user.component.html":
/*!**************************************************!*\
  !*** ./src/app/modules/user/user.component.html ***!
  \**************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<router-outlet></router-outlet>\r\n"

/***/ }),

/***/ "./src/app/modules/user/user.component.scss":
/*!**************************************************!*\
  !*** ./src/app/modules/user/user.component.scss ***!
  \**************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/modules/user/user.component.ts":
/*!************************************************!*\
  !*** ./src/app/modules/user/user.component.ts ***!
  \************************************************/
/*! exports provided: UserComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UserComponent", function() { return UserComponent; });
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

var UserComponent = /** @class */ (function () {
    function UserComponent() {
    }
    UserComponent.prototype.ngOnInit = function () {
    };
    UserComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-user',
            template: __webpack_require__(/*! ./user.component.html */ "./src/app/modules/user/user.component.html"),
            styles: [__webpack_require__(/*! ./user.component.scss */ "./src/app/modules/user/user.component.scss")]
        }),
        __metadata("design:paramtypes", [])
    ], UserComponent);
    return UserComponent;
}());



/***/ }),

/***/ "./src/app/modules/user/user.module.ts":
/*!*********************************************!*\
  !*** ./src/app/modules/user/user.module.ts ***!
  \*********************************************/
/*! exports provided: UserModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UserModule", function() { return UserModule; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _user_routing_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! .//user-routing.module */ "./src/app/modules/user/user-routing.module.ts");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};




var UserModule = /** @class */ (function () {
    function UserModule() {
    }
    UserModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_1__["CommonModule"],
                _user_routing_module__WEBPACK_IMPORTED_MODULE_2__["UserRoutingModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"]
            ],
            declarations: _user_routing_module__WEBPACK_IMPORTED_MODULE_2__["routedComponents"].slice(),
            exports: _user_routing_module__WEBPACK_IMPORTED_MODULE_2__["routedComponents"].slice()
        })
    ], UserModule);
    return UserModule;
}());



/***/ })

}]);
//# sourceMappingURL=modules-dashboard-dashboard-module~modules-user-user-module.js.map
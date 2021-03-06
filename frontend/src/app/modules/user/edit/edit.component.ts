import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ApiService } from 'src/app/core/services/api.service';
import { UserService } from 'src/app/core/services/user.service';
import { User } from 'src/app/core/classes/user';
import { Role } from 'src/app/core/classes/role';
import { UserRoles } from 'src/app/core/classes/userroles';

@Component({
    selector: 'app-edit',
    templateUrl: './edit.component.html',
    styleUrls: ['./edit.component.scss']
})
export class EditComponent implements OnInit {

    userLoaded = false;
    user: User;
    rolAdmin: boolean;
    rolManager: boolean;
    rolUser: boolean;

    constructor(
        private userService: UserService,
        private activatedRoute: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit() {
        const userId = this.activatedRoute.snapshot.params['userId'];
        if (userId) {
            this.userService.getSingleUser(userId).subscribe(
                user => {
                    this.user = user;
                    this.userLoaded = true;
                },
                console.error,
                () => {
                    if (this.user.userroles.find(userrole => userrole.role.roleName.toString().toLowerCase() === 'admin')) {
                        this.rolAdmin = true;
                    }
                    if (this.user.userroles.find(userrole => userrole.role.roleName.toString().toLowerCase() === 'manager')) {
                        this.rolManager = true;
                    }
                    if (this.user.userroles.find(userrole => userrole.role.roleName.toString().toLowerCase() === 'user')) {
                        this.rolUser = true;
                    }
                }
            );
        }
    }


    saveUser() {
        this.user.userroles = [];
        if (this.rolAdmin) {
            const rol: Role = {
                roleName: 'Admin'
            };
            const userRole: UserRoles = {
                role: rol
            };
            this.user.userroles.push(userRole);
        }
        if (this.rolManager) {
            const rol: Role = {
                roleName: 'Manager'
            };
            const userRole: UserRoles = {
                role: rol
            };
            this.user.userroles.push(userRole);
        }
        if (this.rolUser) {
            const rol: Role = {
                roleName: 'User'
            };
            const userRole: UserRoles = {
                role: rol
            };
            this.user.userroles.push(userRole);
        }
        this.userService.editUser(this.user).subscribe(
            response => {
                this.router.navigate(['dashboard']);
            },
            console.error
        );
    }

}

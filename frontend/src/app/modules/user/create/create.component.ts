import { Component } from '@angular/core';
import { ApiService } from 'src/app/core/services/api.service';
import { Router } from '@angular/router';
import { UserService } from 'src/app/core/services/user.service';

@Component({
    selector: 'app-create',
    templateUrl: './create.component.html',
    styleUrls: ['./create.component.scss']
})
export class CreateComponent {

    passType = 'password';

    userName: string;
    password: string;
    rol: string ="User";

    rolAdmin: boolean = false;
    rolManager: boolean = false;
    rolUser: boolean = true;
    
    firstName: string;
    lastName: string;

    constructor(
        private userService: UserService,
        private router: Router
    ) { }

 

    togglePassword(): void {
        if (this.passType === 'password') {
            this.passType = 'text';
        } else {
            this.passType = 'password';
        }
    }

    createUser(): void {
        let roles = [];
        if(this.rolAdmin){
            roles.push({Role:
                            {
                                roleName: "Admin"
                            }
                        });
        }
        if(this.rolManager){
            roles.push({Role:
                {
                    roleName: "Manager"
                }
            });
        }
        if(this.rolUser){
            roles.push({Role:
                {
                    roleName: "User"
                }
            });
        }
        this.userService.saveUser(
            this.userName,
            this.password,
            roles,
            this.firstName,
            this.lastName
        ).subscribe(
            result => {
                this.router.navigateByUrl('/dashboard');
            },
            console.error
        );
    }
}

import { Component } from '@angular/core';
import { ApiService } from 'src/app/core/services/api.service';
import { Router } from '@angular/router';

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
        private api: ApiService,
        private router: Router
    ) { }

    awaitingResponse(): boolean {
        return this.api.awaitingResponse;
    }

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
            roles.push({rolName: "Admin"});
        }
        if(this.rolManager){
            roles.push({rolName: "Manager"});
        }
        if(this.rolUser){
            roles.push({rolName: "User"});
        }
        this.api.post('/users', {
            'UserName': this.userName,
            'Password': this.password,
            'UserRoles' : roles,
            'FirstName': this.firstName,
            'LastName': this.lastName
        }).subscribe(
            result => {
                this.router.navigateByUrl('/dashboard');
            },
            console.error
        );
    }
}

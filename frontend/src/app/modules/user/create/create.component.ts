import { Component } from '@angular/core';
import { ApiService } from 'src/app/core/services/api.service';

@Component({
    selector: 'app-create',
    templateUrl: './create.component.html',
    styleUrls: ['./create.component.scss']
})
export class CreateComponent {

    passType = 'password';

    userName: string;
    password: string;
    firstName: string;
    lastName: string;

    constructor(
        private api: ApiService
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
        this.api.post('/users', {
            'UserName': this.userName,
            'Password': this.password,
            'FirstName': this.firstName,
            'LastName': this.lastName
        }).subscribe(
            console.log,
            console.error
        );
    }
}

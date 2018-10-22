import { Component } from '@angular/core';
import { AuthService } from "./auth.service";
import { ApiService } from "../core/services/api.service";

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.scss']
})
export class LoginComponent {

    response: object = { "response": "no response yet..." };
    passType: string = "password"

    username: string = "jaap";
    password: string = "password";

    constructor(private api: ApiService, private auth: AuthService) { }

    togglePassword(): void {
        if (this.passType === "password") {
            this.passType = "text"
        } else {
            this.passType = "password"
        }
    }

    login(): void {
        this.auth.login(this.username, this.password);
    }

    removeToken(): void {
        this.auth.logout();
    }

    getRequest() {
        this.api.get("/users").subscribe(
            res => { this.response = res; }, //success
            res => { this.response = res; } //error
        )
    }
}

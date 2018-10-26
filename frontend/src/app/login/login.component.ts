import { Component, OnInit } from '@angular/core';
import { AuthService } from "./auth.service";
import { ApiService } from "../core/services/api.service";
import { ActivatedRoute, Router } from "@angular/router";

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

    response: object[] = [];
    passType: string = "password"

    username: string = "jaap";
    password: string = "password";

    returnUrl: string;

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private api: ApiService, 
        private auth: AuthService) { }

    ngOnInit() {
        this.returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/';
    }

    awaitingResponse(): boolean {
        return this.api.awaitingResponse;
    }

    togglePassword(): void {
        if (this.passType === "password") {
            this.passType = "text"
        } else {
            this.passType = "password"
        }
    }

    login(): void {
        this.auth.login(this.username, this.password).subscribe(
            res => { //success
                this.response.unshift(res);
                this.router.navigateByUrl(this.returnUrl);
            }, 
            res => { this.response.unshift(res); } //error
        )
    }

    logout(): void {
        this.auth.logout();
        this.response.unshift({ "idToken": null });
    }

    userPing() {
        this.api.get("/ping/user").subscribe(
            res => { this.response.unshift(res); }, //success
            res => { this.response.unshift(res); } //error
        )
    }

    managerPing() {
        this.api.get("/ping/manager").subscribe(
            res => { this.response.unshift(res); }, //success
            res => { this.response.unshift(res); } //error
        )
    }

    adminPing() {
        this.api.get("/ping/admin").subscribe(
            res => { this.response.unshift(res); }, //success
            res => { this.response.unshift(res); } //error
        )
    }
}

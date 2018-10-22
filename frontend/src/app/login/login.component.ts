import { Component } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

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

    constructor(private http: HttpClient) { }

    togglePassword(): void {
        if (this.passType === "password") {
            this.passType = "text"
        } else {
            this.passType = "password"
        }
    }

    login(): void {
        let requestUrl = "https://localhost:44399/api/login";

        let requestBody = {
            "UserName": this.username,
            "Password": this.password
        }

        let httpOptions = {
            headers: new HttpHeaders({
                'Content-Type': 'application/json'
            })
        };

        this.http.post(requestUrl, requestBody, httpOptions)
            .subscribe(
                res => { this.response = res; this.setToken(res); }, //success
                res => { this.response = res; }, //error
            )
    }

    setToken(authResponse: object) {
        localStorage.setItem("id_token", authResponse["idToken"]);
        console.log(localStorage.getItem("id_token"));
    }

    removeToken(): void {
        localStorage.removeItem("id_token");
        this.response = { "token": localStorage.getItem("id_token") };
    }

    getRequest(): void {
        let requestUrl = "https://localhost:44399/api/users";

        let httpOptions = {
            headers: new HttpHeaders({
                'Authorization': `Bearer ${localStorage.getItem("id_token")}`
            })
        };

        this.http.get(requestUrl, httpOptions)
            .subscribe(
                res => { this.response = res; }, //success
                res => { this.response = res; }, //error
            )
    }
}

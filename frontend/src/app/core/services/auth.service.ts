import { Injectable } from '@angular/core';
import { ApiService } from "./api.service";
import { JwtHelperService } from '@auth0/angular-jwt';
import { map } from "rxjs/operators";
import { Observable } from "rxjs";

@Injectable({
    providedIn: 'root'
})
export class AuthService {

    constructor(private api: ApiService) { }

    login(username: string, password: string): Observable<object> {
        return this.api.post('/login', { "UserName": username, "Password": password })
            .pipe(map((response) => {
                this.setSession(response)
                return response;
            }));
    }

    logout(): void {
        localStorage.removeItem("id_token");
    }

    isLoggedOut(): boolean {
        let helper = new JwtHelperService();
        return helper.isTokenExpired(localStorage.getItem("id_token"));
    }

    isLoggedIn(): boolean {
        return !this.isLoggedOut();
    }

    hasRole(role: string): boolean {
        if (this.isLoggedOut()) {
            return false;
        }

        let token = this.getDecodedToken();
        if (token.hasOwnProperty("role")) {
            return token["role"].indexOf(role) > -1;
        }

        return false;
    }

    getExpiration(): Date {
        if (!this.isLoggedOut()) {
            let helper = new JwtHelperService();
            return helper.getTokenExpirationDate(localStorage.getItem("id_token"));
        } else {
            return new Date();
        }
    }

    getDecodedToken(): object {
        let helper = new JwtHelperService();
        return helper.decodeToken(localStorage.getItem("id_token"));
    }

    private setSession(authResult): void {
        let helper = new JwtHelperService();
        localStorage.setItem("id_token", authResult.idToken);
        console.log(this.getDecodedToken());
    }
}

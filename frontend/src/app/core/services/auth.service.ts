import { Injectable } from '@angular/core';
import { ApiService } from "./api.service";
import { JwtHelperService } from '@auth0/angular-jwt';
import { map } from "rxjs/operators";
import { Observable } from "rxjs";
import { DecodedToken } from '../classes/decodedToken';

@Injectable({
    providedIn: 'root'
})
export class AuthService {

    decodedToken: DecodedToken;

    constructor(private api: ApiService) { }

    login(username: string, password: string): Observable<object> {
        return this.api.post('/login', { "UserName": username, "Password": password })
            .pipe(map((response) => {
                this.setSession(response)
                return response;
            }));
    }

    logout(): void {
        this.decodedToken = null;
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
        if (token.role) {
            return token.role.indexOf(role) > -1;
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

    getDecodedToken(): DecodedToken {
        if (!this.decodedToken) {
            let helper = new JwtHelperService();
            let token = helper.decodeToken(localStorage.getItem("id_token"));
            this.decodedToken = {
                exp: token["exp"],
                iat: token["iat"],
                iss: token["iss"],
                nameid: token["nameid"],
                nbf: token["nbf"],
                role: token["role"],
                uniqueName: token["unique_name"]
            }
        }
        return this.decodedToken;
    }

    private setSession(authResult): void {
        localStorage.setItem("id_token", authResult.idToken);
    }
}

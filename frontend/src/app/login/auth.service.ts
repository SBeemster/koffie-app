import { Injectable } from '@angular/core';
import { ApiService } from "../core/services/api.service";
import { JwtHelperService  } from '@auth0/angular-jwt';

@Injectable({
    providedIn: 'root'
})
export class AuthService {

    private helper = new JwtHelperService();
    
    constructor(private api: ApiService ) { }
    
    login(username: string, password: string) {
        console.log(`isLoggedIn ${this.isLoggedIn()}, isLoggedOut ${this.isLoggedOut()}, getExpiration ${this.getExpiration()}`)
        return this.api.post('/login', { "UserName": username, "Password": password })
            .subscribe(this.setSession);
    }

    logout() {
        localStorage.removeItem("id_token");
    }

    isLoggedOut(): boolean {
        return this.helper.isTokenExpired(localStorage.getItem("id_token"));
    }

    isLoggedIn(): boolean {
        return !this.isLoggedOut();
    }

    getExpiration(): Date {
        if (!this.isLoggedOut()) {
            return this.helper.getTokenExpirationDate(localStorage.getItem("id_token"));
        } else {
            return new Date();
        }
    }

    private setSession(authResult) {
        localStorage.setItem("id_token", authResult.idToken);
    }
}

import { Injectable } from '@angular/core';
import { ApiService } from "../core/services/api.service";

@Injectable({
    providedIn: 'root'
})
export class AuthService {

    constructor(private api: ApiService) { }

    // https://github.com/auth0/angular2-jwt

    login(username: string, password: string) {
        return this.api.post('/login', { "UserName": username, "Password": password })
            .subscribe(this.setSession);
    }

    logout() {
        localStorage.removeItem("id_token");
    }

    isLoggedIn() {
        
    }

    isLoggedOut() {
        
    }

    getExpiration() {
        
    }

    private setSession(authResult) {
        localStorage.setItem("id_token", authResult.idToken);
    }
}

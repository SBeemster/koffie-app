import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/core/services/auth.service';
import { ApiService } from 'src/app/core/services/api.service';
import { Router } from '@angular/router';

@Component({
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

    username: string = "";

    constructor(
        private api: ApiService,
        private auth: AuthService,
        private router: Router
    ) { }

    ngOnInit() {
        let username = this.auth.getDecodedToken()["unique_name"];
        if (username) {
            this.username = username;
        }
    }

    awaitingResponse(): boolean {
        return this.api.awaitingResponse;
    }

    loggedIn(): boolean {
        return this.auth.isLoggedIn();
    }

    logout(): void {
        this.auth.logout();
        this.router.navigate(["login"]);
    }
}

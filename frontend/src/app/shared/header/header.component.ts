import { Component } from '@angular/core';
import { AuthService } from 'src/app/core/services/auth.service';
import { ApiService } from 'src/app/core/services/api.service';
import { Router } from '@angular/router';

@Component({
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.scss']
})
export class HeaderComponent {

    constructor(
        private api: ApiService,
        private auth: AuthService,
        private router: Router
    ) { }

    username() {
        if (this.auth.isLoggedIn()) {
            return this.auth.getDecodedToken().uniqueName;
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
        this.router.navigate(['login']);
    }
}

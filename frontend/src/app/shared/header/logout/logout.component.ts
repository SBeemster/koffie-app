import { Component } from '@angular/core';
import { AuthService } from 'src/app/core/services/auth.service';
import { ApiService } from 'src/app/core/services/api.service';
import { Router } from '@angular/router';

@Component({
    selector: 'app-header-logout',
    templateUrl: './logout.component.html',
    styleUrls: ['./logout.component.scss']
})
export class LogoutComponent {

    awaitingResponse = this.api.awaitingResponse;

    constructor(
        private auth: AuthService,
        private api: ApiService,
        private router: Router
    ) { }

    username() {
        if (this.auth.isLoggedIn()) {
            return this.auth.getDecodedToken().uniqueName;
        }
    }

    logout(): void {
        this.auth.logout();
        this.router.navigate(['/']);
    }

}

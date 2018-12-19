import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/core/services/auth.service';
import { ApiService } from 'src/app/core/services/api.service';
import { Router } from '@angular/router';

@Component({
    selector: 'app-header-logout',
    templateUrl: './logout.component.html',
    styleUrls: ['./logout.component.scss']
})
export class LogoutComponent implements OnInit {

    awaitingResponse = false;

    constructor(
        private auth: AuthService,
        private api: ApiService,
        private router: Router
    ) { }

    ngOnInit() {
        this.api.awaitingResponse.subscribe(
            state => { this.awaitingResponse = state; }
        );
    }

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

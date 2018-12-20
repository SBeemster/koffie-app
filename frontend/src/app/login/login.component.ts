import { Component, OnInit } from '@angular/core';
import { AuthService } from '../core/services/auth.service';
import { ApiService } from '../core/services/api.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

    passType = 'password';

    username = '';
    password = '';

    logout = this.auth.logout;
    returnUrl: string;

    awaitingResponse = false;
    authError = false;

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private api: ApiService,
        private auth: AuthService) { }

    ngOnInit() {
        this.returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/dashboard';
        this.api.awaitingResponse.subscribe(
            state => { this.awaitingResponse = state; }
        );
    }

    togglePassword(): void {
        if (this.passType === 'password') {
            this.passType = 'text';
        } else {
            this.passType = 'password';
        }
    }

    login(): void {
        this.authError = false;
        this.auth.login(this.username, this.password).subscribe(
            () => {
                this.router.navigateByUrl(this.returnUrl);
            },
            () => {
                this.authError = true;
            }
        );
    }

    loggedIn(): boolean {
        return this.auth.isLoggedIn();
    }
}

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

    username = 'admin';
    password = 'admin';
    logout = this.auth.logout;
    returnUrl: string;

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private api: ApiService,
        private auth: AuthService) { }

    ngOnInit() {
        this.returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/dashboard';
    }

    awaitingResponse(): boolean {
        return this.api.awaitingResponse;
    }

    togglePassword(): void {
        if (this.passType === 'password') {
            this.passType = 'text';
        } else {
            this.passType = 'password';
        }
    }

    login(): void {
        this.auth.login(this.username, this.password).subscribe(
            () => { // success
                this.router.navigateByUrl(this.returnUrl);
            }
        );
    }
}

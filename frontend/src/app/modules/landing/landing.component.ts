import { Component, OnInit } from '@angular/core';
import { AuthService } from "src/app/core/services/auth.service";
import { Router } from "@angular/router";

@Component({
    selector: 'app-landing',
    templateUrl: './landing.component.html',
    styleUrls: ['./landing.component.scss']
})
export class LandingComponent implements OnInit {

    constructor(
        private auth: AuthService,
        private router: Router
    ) { }

    ngOnInit() {
    }

    toLogin() {
        if (this.auth.isLoggedIn()) {
            this.router.navigateByUrl('/dashboard');
        } else {
            this.router.navigateByUrl('/login');
        }
    }

}

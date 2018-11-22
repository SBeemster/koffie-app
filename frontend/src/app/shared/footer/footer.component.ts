import { Component, OnInit } from '@angular/core';
import { AuthService } from "src/app/core/services/auth.service";

@Component({
    selector: 'app-footer',
    templateUrl: './footer.component.html',
    styleUrls: ['./footer.component.scss']
})
export class FooterComponent implements OnInit {

    constructor(
        private auth: AuthService
    ) { }

    ngOnInit() {
    }

    loggedIn(): boolean {
        return this.auth.isLoggedIn();
    }

}

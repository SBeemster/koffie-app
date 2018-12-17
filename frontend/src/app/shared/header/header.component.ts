import { Component } from '@angular/core';
import { AuthService } from 'src/app/core/services/auth.service';

@Component({
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.scss']
})
export class HeaderComponent {

    constructor(
        private auth: AuthService
    ) { }

    loggedIn(): boolean {
        return this.auth.isLoggedIn();
    }
}

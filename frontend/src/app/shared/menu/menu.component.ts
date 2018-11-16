import { Component } from '@angular/core';
import { MENU_ITEMS } from './menu-items';
import { AuthService } from 'src/app/core/services/auth.service';

@Component({
    selector: 'app-menu',
    templateUrl: './menu.component.html',
    styleUrls: ['./menu.component.scss']
})
export class MenuComponent {
    menu = MENU_ITEMS;

    constructor(
        private auth: AuthService
    ) { }

    hasRole(role: string): boolean {
        if (role) {
            return this.auth.hasRole(role);
        }
        return true;
    }
}

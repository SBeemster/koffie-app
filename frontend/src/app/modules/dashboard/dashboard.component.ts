import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/core/services/auth.service';

@Component({
    selector: 'app-dashboard',
    templateUrl: './dashboard.component.html',
    styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

    showAllDrinks = false;
    showAdminPanel = false;

    constructor(
        private auth: AuthService
    ) { }

    ngOnInit() {
    }

    toggleDrinks(): void {
        this.showAllDrinks = !this.showAllDrinks;
    }

    toggleAdmin(): void {
        this.showAdminPanel = !this.showAdminPanel;
    }

    isAdmin(): boolean {
        return this.auth.hasRole('Admin');
    }

}

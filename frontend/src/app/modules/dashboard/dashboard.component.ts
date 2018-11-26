import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/core/services/auth.service';
import { DrinkPreference } from 'src/app/core/classes/drink-preference';

@Component({
    selector: 'app-dashboard',
    templateUrl: './dashboard.component.html',
    styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

    hasFavorite = false;
    showAllDrinks = true;
    showAdminPanel = false;
    showFavorite = false;

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

    toggleFavorite(): void {
        this.showFavorite = !this.showFavorite;
    }

    onNotifyFavorite(drinkPreference: DrinkPreference): void {
        this.hasFavorite = drinkPreference.drink != null;
        this.showFavorite = this.hasFavorite;
        this.showAllDrinks = !this.hasFavorite;
    }
}

import { Component, OnInit, Output, ViewChild, ElementRef } from '@angular/core';
import { AuthService } from 'src/app/core/services/auth.service';
import { DrinkPreference } from 'src/app/core/classes/drink-preference';
import { OrderLine } from 'src/app/core/classes/orderLine';
import { OverviewComponent } from '../order/overview/overview.component';
import * as Echarts from 'echarts';

@Component({
    selector: 'app-dashboard',
    templateUrl: './dashboard.component.html',
    styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
    @ViewChild(OverviewComponent) overview: OverviewComponent;

    hasFavorite = false;
    hasOrders = false;
    hasOwnOrder = false;
    showOrders = false;
    showAllDrinks = true;
    showManagerPanel = false;
    showAdminPanel = false;
    showFavorite = false;

    private favoriteReceived: boolean;
    private ordersReceived: boolean;

    constructor(
        private auth: AuthService
    ) { }

    ngOnInit() {
    }

    toggleDrinks(): void {
        this.showAllDrinks = !this.showAllDrinks;
    }
    toggleManager(): void {
        this.showManagerPanel = !this.showManagerPanel;
    }

    toggleAdmin(): void {
        this.showAdminPanel = !this.showAdminPanel;
    }
    isManager(): boolean {
        return this.auth.hasRole('Manager');
    }
    isAdmin(): boolean {
        return this.auth.hasRole('Admin');
    }

    toggleFavorite(): void {
        this.showFavorite = !this.showFavorite;
    }

    toggleOrders(): void {
        this.showOrders = !this.showOrders;
    }

    onNotifyFavorite(drinkPreference: DrinkPreference): void {
        this.hasFavorite = drinkPreference.drink != null;
        this.setState(true, null);
    }

    onNotifyOrders(orderLines: OrderLine[]): void {
        this.hasOrders = orderLines.length > 0;
        this.hasOwnOrder = !!orderLines.find(orderLine => {
            return orderLine.customer.userId === this.auth.getDecodedToken().nameid;
        });
        this.setState(null, true);
    }

    onNotifyPlaced(): void {
        this.overview.refreshOrders();
    }

    private setState(favoriteReceived: boolean, ordersReceived: boolean) {
        this.favoriteReceived = this.favoriteReceived || favoriteReceived;
        this.ordersReceived = this.ordersReceived || ordersReceived;

        if (this.favoriteReceived && this.ordersReceived) {
            this.showOrders = this.hasOrders && this.hasOwnOrder;
            this.showFavorite = this.hasFavorite && !this.hasOwnOrder;
            this.showAllDrinks = !this.hasOwnOrder && !this.hasFavorite;
        }
    }
}

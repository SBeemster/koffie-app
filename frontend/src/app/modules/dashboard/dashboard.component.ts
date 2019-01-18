import { Component, OnInit, Output, ViewChild, ElementRef } from '@angular/core';
import { AuthService } from 'src/app/core/services/auth.service';
import { DrinkPreference } from 'src/app/core/classes/drink-preference';
import { OrderLine } from 'src/app/core/classes/orderLine';
import { OverviewComponent } from '../order/overview/overview.component';
import { Router } from '@angular/router';
import * as Echarts from 'echarts';

@Component({
    selector: 'app-dashboard',
    templateUrl: './dashboard.component.html',
    styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
    @ViewChild(OverviewComponent) overview: OverviewComponent;

    hasFavorite = true;
    hasOrders = false;
    hasOwnOrder = false;
    showOrders = false;
    showAllDrinks = true;
    showManagerPanel = false;
    showAdminPanel = false;
    showFavorite = false;
    showGroup = false;

    private favoriteReceived: boolean;
    private ordersReceived: boolean;

    constructor(
        private auth: AuthService,
        private router: Router
    ) { }

    ngOnInit() {
    }
    closeAll(): void {
        this.showAdminPanel = false;
        this.showAllDrinks = false;
        this.showFavorite = false;
        this.showManagerPanel = false;
        this.showOrders = false;
        this.showGroup = false;
        this.setAllInactive();
    }
    setAllInactive(): void {
        if (this.hasFavorite) {
            document.getElementById('menu-favorit').className = "menu-icon";
            document.getElementById('card-favorite').className = "card";
        }
        document.getElementById('menu-drinks').className = "menu-icon";
        if (this.hasOrders) {
            document.getElementById('menu-order').className = "menu-icon";
        }
        document.getElementById('menu-group').className = "menu-icon";
    }
    toggleDrinks(): void {
        var div = document.getElementById('menu-drinks');
        this.closeAll();
        this.showAllDrinks = !this.showAllDrinks;
        if (this.showAllDrinks === true) {
            div.className = "menu-icon menu-icon-active";
        }
        else {
            div.className = "menu-icon";
        }
    }
    toggleGroup(): void {
        var div = document.getElementById('menu-group');
        this.closeAll();
        this.showGroup = !this.showGroup;
        if (this.showGroup === true) {
            div.className = "menu-icon menu-icon-active";
        }
        else {
            div.className = "menu-icon";
        }
    }
    toggleManager(): void {
        var div = document.getElementById('menu-manager');

        this.closeAll();
        this.showManagerPanel = !this.showManagerPanel;
        if (this.showManagerPanel === true) {
            div.className = "menu-icon menu-icon-active";
        }
        else {
            div.className = "menu-icon";
        }
    }

    toggleAdmin(): void {
        var div = document.getElementById('menu-admin');

        this.closeAll();
        this.showAdminPanel = !this.showAdminPanel;
        if (this.showAdminPanel === true) {
            div.className = "menu-icon menu-icon-active";
        }
        else {
            div.className = "menu-icon";
        }
    }
    isManager(): boolean {
        return this.auth.hasRole('Manager');
    }
    isAdmin(): boolean {
        return this.auth.hasRole('Admin');
    }

    toggleFavorite(): void {
        this.closeAll();
        var div = document.getElementById('menu-favorit');
        
        this.showFavorite = !this.showFavorite;
        if (this.showFavorite === true) {
            var divCard = document.getElementById('card-favorite');
            divCard.className = "card-favorit";
            div.className = "menu-icon menu-icon-active";
        }
        else {
            divCard.className = "card"
            div.className = "menu-icon";
        }
    }

    toggleOrders(): void {
        this.closeAll();
        var div = document.getElementById('menu-order');

        this.showOrders = !this.showOrders;
        if (this.showOrders === true) {
            div.className = "menu-icon menu-icon-active";
        }
        else {
            div.className = "menu-icon";
        }
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
    logOut(): void {
        this.auth.logout();
        this.router.navigate(['/']);
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
        if (this.showOrders) {
            this.setAllInactive();
            document.getElementById('menu-order').className = "menu-icon menu-icon-active";
        } else if (this.showFavorite) {
            this.setAllInactive();
            document.getElementById('menu-favorit').className = "menu-icon menu-icon-active";
        } else if (this.showAllDrinks) {
            this.setAllInactive();
            document.getElementById('menu-drinks').className = "menu-icon menu-icon-active";
        }
    }
}

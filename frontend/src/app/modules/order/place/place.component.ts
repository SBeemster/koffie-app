import { Component, OnInit } from "@angular/core";
import { AvailableCoffeeService } from "../../../core/services/available-coffee.service";
import { OrderService } from "../../../core/services/order.service";
import { PreferenceService } from "../../../core/services/preference.service";

@Component({
    selector: "app-place",
    templateUrl: "./place.component.html",
    styleUrls: ["./place.component.scss"]
})
export class PlaceComponent implements OnInit {
    orders = this.OrderService.orders;
    availableCoffees;
    melkcnt: number = 0;
    suikercnt: number = 0;
    constructor(
        private availableCoffeeService: AvailableCoffeeService,
        private OrderService: OrderService,
        private preferenceService: PreferenceService
    ) { }

    ngOnInit() {
        this.availableCoffees = this.availableCoffeeService.getCoffee();
        const drinkPreference = this.preferenceService.getPreference();
    }
    melkCountUp() {
        if (this.melkcnt < 3) this.melkcnt++;
    }
    melkCountDown() {
        if (this.melkcnt >= 1) this.melkcnt--;
    }
    suikerCountUp() {
        if (this.suikercnt < 3) this.suikercnt++;
    }
    suikerCountDown() {
        if (this.suikercnt >= 1) this.suikercnt--;
    }
    //addToOrder = this.OrderService.placeOrder;

    //deleteFromOrder = this.OrderService.deleteFromOrder;

    //clearCart = this.OrderService.clearCart;
}

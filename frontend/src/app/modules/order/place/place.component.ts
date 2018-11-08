import { Component, OnInit } from "@angular/core";
import { AvailableCoffeeService } from "../../../core/services/Available-coffee.service";
import { OrderService } from "../../../core/services/order.service";

@Component({
    selector: "app-place",
    templateUrl: "./place.component.html",
    styleUrls: ["./place.component.scss"]
})
export class PlaceComponent implements OnInit {
    orders = this.OrderService.orders;
    AvailableCoffees;
    constructor(
        private AvailableCoffeeService: AvailableCoffeeService,
        private OrderService: OrderService
    ) { }

    ngOnInit() {
        this.AvailableCoffees = this.AvailableCoffeeService.getCoffee();
    }

    //addToOrder = this.OrderService.placeOrder;

    //deleteFromOrder = this.OrderService.deleteFromOrder;

    //clearCart = this.OrderService.clearCart;
}

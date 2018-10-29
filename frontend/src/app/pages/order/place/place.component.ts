import { Component, OnInit } from "@angular/core";
import { AvailableCoffeeService } from "../../../core/services/available-coffee.service";
import { OrderService } from "../../../core/services/order.service";

@Component({
  selector: "app-place",
  templateUrl: "./place.component.html",
  styleUrls: ["./place.component.scss"]
})
export class PlaceComponent implements OnInit {
  orders = this.OrderService.orders;
  availableCoffees;
  constructor(
    private availableCoffeeService: AvailableCoffeeService,
    private OrderService: OrderService
  ) {}

  ngOnInit() {
    this.availableCoffees = this.availableCoffeeService.getCoffee().sort((a, b) => { 
      console.log(a.drinkName);
      if (a.drinkName.toLowerCase > b.drinkName.toLowerCase) {
          return 1;
      }
      if (b.drinkName.toLowerCase > a.drinkName.toLowerCase) {
          return -1;
      }
      return 0; 
  });
  console.log(this.availableCoffees);
  }

  //addToOrder = this.OrderService.placeOrder;

  //deleteFromOrder = this.OrderService.deleteFromOrder;

  //clearCart = this.OrderService.clearCart;
}

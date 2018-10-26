import { Component, OnInit } from "@angular/core";
import { OrderService } from "../../../core/services/order.service";
import { AvailableCoffeeService } from "../../../core/services/available-coffee.service";
import { OrderLine } from "../../../core/classes/orderLine";
import { Drink } from "src/app/core/classes/drink";

@Component({
  selector: "app-overview",
  templateUrl: "./overview.component.html",
  styleUrls: ["./overview.component.scss"]
})
export class OverviewComponent implements OnInit {
  orders: OrderLine[] = [];
  ordersGrouped = [];
  availableCoffees: Drink[] = [];
  ordersPerUser = [];
  constructor(
    private OrderService: OrderService,
    private availableCoffeeService: AvailableCoffeeService
  ) {}

  ngOnInit() {
    this.orders = this.OrderService.getNewOrders();
    this.availableCoffees = this.availableCoffeeService.getCoffee();
    this.getGroupedByCoffee();
    this.getOrdersPerUser();
    this.OrderService.setHalenFalse();
  }
  getGroupedByCoffee(): void {
    this.ordersGrouped = [];
    for (let i = 0; i < this.availableCoffees.length; i++) {
      this.ordersGrouped.push([
        this.availableCoffees[i].drinkName,
        this.orders.reduce(
          (acc, order) =>
            order.drink.drinkName === this.availableCoffees[i].drinkName && order.verwerkt === false && order.melk === order.melk
              ? acc + order.aantal
              : acc,
          0
        )
      ]);
    }
  }
 getOrdersPerUser(): void{
   console.log("fired");
    this.ordersPerUser = this.orders
    
    .sort(function(a, b) {
      var textA = a.verbruiker.toUpperCase();
      var textB = b.verbruiker.toUpperCase();
      return (textA < textB) ? -1 : (textA > textB) ? 1 : 0;
  });
  }
  gaHalen = this.OrderService.gaHalen;
}

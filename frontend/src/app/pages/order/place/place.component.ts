import { Component, OnInit } from "@angular/core";
import { AvailableCoffeeService } from "../../../core/services/available-coffee.service";
import { OrderService } from "../../../core/services/order.service";
import { Router, ActivatedRoute } from "@angular/router";

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
    private OrderService: OrderService,
    private router: Router,
    private activatedRoute: ActivatedRoute
  ) {}

  ngOnInit() {
    this.availableCoffees = this.availableCoffeeService.getCoffee();
  }

  addToOrder = this.OrderService.placeOrder;

  deleteFromOrder = this.OrderService.deleteFromOrder;

  clearCart = this.OrderService.clearCart;

  routeToChoice() {
    this.router.navigate(["../choice"], { relativeTo: this.activatedRoute });
  }
}

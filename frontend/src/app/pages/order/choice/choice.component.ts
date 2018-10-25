import { Component, OnInit } from "@angular/core";
import { AvailableCoffeeService } from "../../../core/services/available-coffee.service";
import { OrderService } from "../../../core/services/order.service";
import { ActivatedRoute } from "@angular/router";

@Component({
  selector: "app-choice",
  templateUrl: "./choice.component.html",
  styleUrls: ["./choice.component.scss"]
})
export class ChoiceComponent implements OnInit {
  melkcnt: number = 0;
  suikercnt: number = 0;
  orders = this.OrderService.orders;
  availableCoffee: String;
  constructor(
    private availableCoffeeService: AvailableCoffeeService,
    private OrderService: OrderService,
    private activatedRoute: ActivatedRoute
  ) {}

  ngOnInit() {
    const id = this.activatedRoute.snapshot.params["coffeeId"];
    this.availableCoffee = this.availableCoffeeService.getSingleCoffee(id);
  }

  addToOrder = this.OrderService.placeOrder;

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
}

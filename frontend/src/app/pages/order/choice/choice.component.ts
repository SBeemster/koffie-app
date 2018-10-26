import { Component, OnInit } from "@angular/core";
import { AvailableCoffeeService } from "../../../core/services/available-coffee.service";
import { OrderService } from "../../../core/services/order.service";
import { ActivatedRoute } from "@angular/router";
import { Drink } from "../../../core/classes/drink";

@Component({
  selector: "app-choice",
  templateUrl: "./choice.component.html",
  styleUrls: ["./choice.component.scss"]
})
export class ChoiceComponent implements OnInit {
  melkcnt: number = 0;
  suikercnt: number = 0;
  newAantal: number = 1;
  orders = this.OrderService.orders;
  availableCoffee: Drink;
  constructor(
    private availableCoffeeService: AvailableCoffeeService,
    private OrderService: OrderService,
    private activatedRoute: ActivatedRoute
  ) {}

  ngOnInit() {
    const id = this.activatedRoute.snapshot.params["coffeeId"];
    console.log(id);
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
  drinkCountUp() {
    this.suikercnt++;
  }
  drinkCountDown() {
    if (this.suikercnt >= 1) this.suikercnt--;
  }
}

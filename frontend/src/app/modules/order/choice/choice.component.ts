import { Component, OnInit } from "@angular/core";
import { AvailableCoffeeService } from "../../../core/services/available-coffee.service";
import { OrderService } from "../../../core/services/order.service";
import { ActivatedRoute, Router } from "@angular/router";
import { Drink } from "../../../core/classes/drink";
import { ApiService } from "src/app/core/services/api.service";
import { PreferenceService } from "../../../core/services/preference.service";

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
  Preference: boolean = false;

  constructor(
    private availableCoffeeService: AvailableCoffeeService,
    private preferenceService: PreferenceService,
    private OrderService: OrderService,
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private api: ApiService
  ) { }

  ngOnInit() {
    const id = this.activatedRoute.snapshot.params["coffeeId"];
    this.availableCoffee = this.availableCoffeeService.getSingleCoffee(id);
  }

  addToOrder(
    product: Drink,
    aantal: number,
    verbruiker: string,
    melk: number,
    suiker: number
  ) {
    this.OrderService.placeOrder(product, aantal, verbruiker, melk, suiker);
    this.router.navigate(["order"]);
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
  drinkCountUp() {
    this.newAantal++;
  }
  drinkCountDown() {
    if (this.newAantal > 1) this.newAantal--;
  }
  submitPreference(availableCoffee, melkcnt, suikercnt) {
    this.preferenceService.postPreference(availableCoffee, melkcnt, suikercnt);
  }
}

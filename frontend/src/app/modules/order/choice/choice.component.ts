import { Component, OnInit } from "@angular/core";
import { AvailableCoffeeService } from "../../../core/services/Available-coffee.service";
import { OrderService } from "../../../core/services/order.service";
import { ActivatedRoute, Router } from "@angular/router";
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
  availableCoffee;
  orderStatus= [];
  constructor(
    private availableCoffeeService: AvailableCoffeeService,
    private OrderService: OrderService,
    private activatedRoute: ActivatedRoute,
    private router: Router
  ) {}

  ngOnInit() {
    const id = this.activatedRoute.snapshot.params["coffeeId"];
    this.availableCoffeeService.getSingleCoffee(id).subscribe(
      drink => {
          this.availableCoffee = drink;
      },
      console.error,
      () => {
          console.log("complete");
      }
  );
  this.OrderService.getStatussen().subscribe(
    orderstatus => {
        this.orderStatus.push(orderstatus);
    },
    console.error,
    () => {
        console.log("complete");
    }
);
  }

  addToOrder(
    product: Drink,
    aantal: number,
    melk: number,
    suiker: number
  ){
    this.OrderService.placeOrder(product,aantal,melk,suiker, this.orderStatus.find(status => { return status.statusName.toString().toLowerCase() == "ordered" }));
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
}

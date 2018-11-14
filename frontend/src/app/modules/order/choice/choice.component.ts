import { Component, OnInit } from "@angular/core";
import { AvailableCoffeeService } from "../../../core/services/Available-coffee.service";
import { OrderService } from "../../../core/services/order.service";
import { ActivatedRoute, Router } from "@angular/router";
import { Drink } from "../../../core/classes/drink";
import { User } from "../../../core/classes/user";
import { ApiService } from "../../../core/services/api.service";
import { AuthService } from "../../../core/services/auth.service";
import { OrderStatus } from "src/app/core/classes/order-status";
import { OrderLine } from "src/app/core/classes/orderLine";

@Component({
  selector: "app-choice",
  templateUrl: "./choice.component.html",
  styleUrls: ["./choice.component.scss"]
})
export class ChoiceComponent implements OnInit {
  melkcnt: number = 0;
  suikercnt: number = 0;
  newAantal: number = 1;
  orderlines = [];
  availableCoffee;
  orderStatus = [];
  id: string = "";
  constructor(
    private availableCoffeeService: AvailableCoffeeService,
    private OrderService: OrderService,
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private auth: AuthService,
    private api: ApiService
  ) { }

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
    this.OrderService.getOrders().subscribe(
      orderline => {
        this.orderlines.push(orderline);
      },
      console.error,
      () => {
        console.log("GetOrders complete");
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
    drink: Drink,
    count: number,
    milk: number,
    sugar: number
  ) {

    const orderstatus: OrderStatus = this.orderStatus.find(status => { return status.statusName.toString().toLowerCase() == "ordered" })

    for (const s of this.orderlines) {

      if (
        s.drink.drinkName === drink.drinkName &&
        s.customer.userId === this.auth.getDecodedToken().nameid &&
        s.orderStatus.orderStatusId === orderstatus.orderStatusId &&
        s.milk === milk &&
        s.sugar === sugar
      ) {
        s.count++;
        this.api.put("/OrderLines/" + s.orderLineId, {
          "OrderLineId": s.orderLineId,
          "Customer": {
            "userId": s.customer.userId
          },
          "Server": "",
          "Drink": {
            "drinkId": s.drink.drinkId,
            "drinkName": s.drink.drinkName
          },
          "Count": s.count,
          "Sugar": s.sugar,
          "Milk": s.milk,
          "OrderStatus": s.orderStatus
        }).subscribe(
          console.log,
          console.error
        )
        this.router.navigate(["order"]);
        return;
      }
    }


    this.api.post("/OrderLines", {
      "Customer": {
        userId: this.auth.getDecodedToken().nameid
      },
      "Server": "",
      "Drink": drink,
      "Count": count,
      "Sugar": sugar,
      "Milk": milk,
      "OrderTime": new Date(),
      "OrderStatus": orderstatus
    }).subscribe(
      res => { this.id = res.toString() },
      console.error
    )
    const user: User = {
      userId: this.auth.getDecodedToken().nameid,
      firstName: "",
      lastName: ""
    }
    const newOrderline: OrderLine = {
      orderLineId: this.id,
      drink: drink,
      count: count,
      customer: user,
      milk: milk,
      sugar: sugar,
      orderStatus: orderstatus
    };
    this.orderlines.push(newOrderline);
    //console.log(newProduct);

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

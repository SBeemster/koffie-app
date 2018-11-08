import { Injectable } from "@angular/core";
import { OrderLine } from "../classes/orderLine";
import { Drink } from "../classes/drink";
import { AuthService } from 'src/app/core/services/auth.service';
import { ApiService } from "./api.service";

@Injectable({
  providedIn: "root"
})
export class OrderService {
  orders = [];
  mergedOrders = [];
  userId() {
    if (this.auth.isLoggedIn()) {
      return this.auth.getDecodedToken().nameid;
    }
  }
  refreshOrderLines(){
    this.orders = [];
    this.api.get("/orderlines?orderstatus=ordered").subscribe(
      res => {
          for (let i in res) {
              let orderline = new OrderLine(
                res[i].orderLineId,
                 res[i].drink, 
                 res[i].count,
                 res[i].customer.userId,
                 res[i].milk,
                 res[i].sugar
                );

              this.orders.push(orderline);
              console.log(orderline);
              console.log(orderline.drink.drinkName);
          }
          
      }, //success
      res => { console.log(res); } //error

  )
  }
  getOrders(): Array<OrderLine> {
    this.refreshOrderLines();
    return this.orders;
  }
  getNewOrders(): Array<OrderLine> {
    this.refreshOrderLines();
    return this.orders
      .filter(order => order.verwerkt === false)
  }
  gaHalen(): void {
    for (let s of this.orders) {
      if (!s.verwerkt) {
        s.verwerkt = true;
        s.halen = true;
      }
    }
  }
  placeOrder(
    product: Drink,
    aantal: number,
    melk: number,
    suiker: number
  ): void {
    for (const s of this.orders) {
      if (
        s.drink.drinkName === product.drinkName &&
        s.verbruiker === this.userId() &&
        s.verwerkt === false &&
        s.melk === melk &&
        s.suiker === suiker
      ) {
        s.aantal++;
        s.id
        this.api.put("/OrderLines/" + s.orderLineId, {
          "OrderLineId" : s.orderLineId,
          "Customer": {
            "UserId": s.verbruiker
          },
          "Server": "",
          "Drink": s.drink,
          "Count": s.aantal,
          "Sugar": s.suiker,
          "Milk": s.melk,
          "OrderStatus": ""
        }).subscribe(
          console.log,
          console.error
        )
        return;
      }
    }
    const newProduct = new OrderLine(
      "",
      product = product,
      aantal ? aantal : 1,
      this.userId(),
      melk ? melk : 0,
      suiker ? suiker : 0
    );

    this.api.post("/OrderLines", {
      "Customer": {
        "UserId": this.userId()
      },
      "Server": "",
      "Drink": product,
      "Count": aantal,
      "Sugar": suiker,
      "Milk": melk,
      "OrderStatus": "",
      "OrderTime" : new Date()
    }).subscribe(
      res => {
          newProduct.orderLineId = res.toString();
      },
      console.log,
      console.error
    )
    this.orders.push(newProduct);
    console.log(newProduct);
  }
  deleteFromOrder(order: OrderLine) {
    this.orders.splice(this.orders.indexOf(order), 1);
  }
  setHalenFalse(): void {
    for (let s of this.orders) {
      s.halen = false;
    }
  }
  clearCart(verbruiker: string): void {
    for (let i = 0; i < this.orders.length; i++) {
      if (
        this.orders[i].verwerkt === false &&
        this.orders[i].verbruiker === verbruiker
      ) {
        var orderToDelete = this.orders[i];
        this.api.delete("/OrderLines/" + orderToDelete.orderLineId);
        this.orders.splice(i, 1);
        i--;
      }
    }
  }
  constructor(private auth: AuthService, private api: ApiService) { }
}

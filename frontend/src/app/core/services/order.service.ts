import { Injectable } from "@angular/core";
import { OrderLine } from "../classes/orderLine";
import { Drink } from "../classes/drink";

@Injectable({
  providedIn: "root"
})
export class OrderService {
  orders = [];
  mergedOrders = [];
  getOrders(): Array<OrderLine> {
    return this.orders;
  }
  getNewOrders(): Array<OrderLine> {
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
    verbruiker: string,
    melk: number,
    suiker: number
  ): void {
    var i = Math.round(Math.random());
    verbruiker = verbruiker + i;
    for (const s of this.orders) {
      if (
        s.drink.drinkName === product.drinkName &&
        s.verbruiker === verbruiker &&
        s.verwerkt === false &&
        s.melk === melk &&
        s.suiker === suiker
      ) {
        s.aantal++;
        return;
      }
    }
    const newProduct = new OrderLine(
      product = product,
      aantal ? aantal : 1,
      verbruiker ? verbruiker : "",
      melk ? melk : 0,
      suiker ? suiker : 0
    );
    this.orders.push(newProduct);
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
        this.orders.splice(i, 1);
        i--;
      }
    }
  }
  constructor() {}
}

import { Injectable } from "@angular/core";
import { OrderLine } from "../classes/orderLine";

@Injectable({
  providedIn: "root"
})
export class OrderService {
  orders = [];
  getOrders(): Array<OrderLine> {
    return this.orders;
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
    product: string,
    aantal: number,
    verbruiker: string,
    melk: number,
    suiker: number
  ): void {
    for (const s of this.orders) {
      if (
        s.name === product &&
        s.verbruiker === verbruiker &&
        s.verwerkt === false
      ) {
        s.aantal++;
        return;
      }
    }
    const newProduct = new OrderLine(
      product ? product : "Koffie",
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

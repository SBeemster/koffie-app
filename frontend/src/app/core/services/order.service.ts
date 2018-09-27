import { Injectable } from '@angular/core';
import { OrderLine } from '../classes/orderLine';

@Injectable({
  providedIn: 'root'
})
export class OrderService {
  orders =[];

  placeOrder(product: string, aantal: number, verbruiker: string): void{
    for (const s of this.orders) {
      if (s.name === product && s.verbruiker === verbruiker) {
        s.aantal++;
        return;
      }
    }
    const newProduct = new OrderLine(product ? product : 'Koffie', aantal ? aantal : 1, verbruiker ? verbruiker : '');
    this.orders.push(newProduct);
  }
  deleteFromOrder(order: OrderLine) {
    this.orders.splice(this.orders.indexOf(order), 1);
  }
  clearCart(): void {
    this.orders = [];
  }
  constructor() { }
}

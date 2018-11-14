import { Injectable } from "@angular/core";
import { OrderLine } from "../classes/orderLine";
import { AuthService } from 'src/app/core/services/auth.service';
import { ApiService } from "./api.service";
import { OrderStatus } from "../classes/order-status";
import { Observable } from "rxjs";
import { map, concatAll } from "rxjs/operators";

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
  
  getOrders(): Observable<OrderLine> {
    return this.api.get('/orderlines?orderstatus=ordered').pipe(
        concatAll(),
        map(obj => {
            const orderline: OrderLine = {
              orderLineId: obj['orderLineId'],
                drink: obj['drink'],
                count: obj['count'],
                customer: obj['customer'],
                milk: obj['milk'],
                sugar: obj['sugar'],
                orderStatus: obj['orderStatus']
            };
            return orderline;
            
        })
    );
  }
  getStatussen() : Observable<OrderStatus> {
    return this.api.get('/orderstatus').pipe(
      concatAll(),
      map(obj => {
          const orderstatus: OrderStatus = {
            orderStatusId: obj['orderStatusId'],
            statusName: obj['statusName']
          };
          return orderstatus;
      })
  );
  }
/*   deleteFromOrder(order: OrderLine) {
    this.orders.splice(this.orders.indexOf(order), 1);
  } */
 
/*   clearCart(verbruiker: string): void {
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
  } */
  

  constructor(private auth: AuthService, private api: ApiService) { 
  }
}

import { Injectable } from "@angular/core";
import { OrderLine } from "../classes/orderLine";
import { Drink } from "../classes/drink";
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




 /*  gaHalen(): void {
    
    for (let s of this.orders) {
      if (!s.verwerkt) {
        s.verwerkt = true;
        s.halen = true;
       //s.orderStatus = orderstatus;
        console.log(s);
       this.api.put("/OrderLines/" + s.orderLineId, {
          "OrderLineId": s.orderLineId,
          "Customer": {
            "UserId": s.verbruiker
          },
          "Server": "",
          "Drink": {
            "drinkId":s.drink.drinkId,
            "drinkName": s.drink.drinkName
          },
          "Count": s.aantal,
          "Sugar": s.suiker,
          "Milk": s.melk,
          "OrderStatus": {
            "orderStatusId" :s.orderStatus.orderStatusId,
            "statusName" : s.orderStatus.statusName
          }
        }).subscribe(
          console.log,
          console.error
        )
       
      }
    }
  } */
  placeOrder(
    product: Drink,
    aantal: number,
    melk: number,
    suiker: number,
    orderstatus: OrderStatus
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
          "OrderLineId": s.orderLineId,
          "Customer": {
            "UserId": s.verbruiker
          },
          "Server": "",
          "Drink": s.drink,
          "Count": s.aantal,
          "Sugar": s.suiker,
          "Milk": s.melk,
          "OrderStatus": s.orderStatus
        }).subscribe(
          console.log,
          console.error
        )
        return;
      }
    }

    this.api.post("/OrderLines", {
      "Customer": {
        "UserId": this.userId()
      },
      "Server": "",
      "Drink": product,
      "Count": aantal,
      "Sugar": suiker,
      "Milk": melk,
      "OrderTime": new Date(),
      "OrderStatus": orderstatus
    }).subscribe(
      
      console.log,
      console.error
    )
    //this.orders.push(newProduct);
    //console.log(newProduct);
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
  constructor(private auth: AuthService, private api: ApiService) { 
  }
}

import { Injectable } from '@angular/core';
import { OrderLine } from '../classes/orderLine';
import { AuthService } from 'src/app/core/services/auth.service';
import { ApiService } from './api.service';
import { OrderStatus } from '../classes/order-status';
import { Observable } from 'rxjs';
import { map, concatAll } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
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
  getStatussen(): Observable<OrderStatus> {
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
  postOrderline(orderline): Observable<Object> {
   return this.api.post('/OrderLines', {
      'Customer': {
        userId: this.auth.getDecodedToken().nameid
      },
      'Drink': orderline.drink,
      'Count': orderline.count,
      'Sugar': orderline.sugar,
      'Milk': orderline.milk,
      'OrderTime': new Date()
    });
  }
  putOrderline(orderline): Observable<Object> {
  return this.api.put('/OrderLines/' + orderline.orderLineId, {
    'OrderLineId': orderline.orderLineId,
    'Customer': {
      'userId': orderline.customer.userId
    },
    'Server': {
      'userId': orderline.server.userId
    },
    'Drink': {
      'drinkId': orderline.drink.drinkId,
      'drinkName': orderline.drink.drinkName
    },
    'Count': orderline.count,
    'Sugar': orderline.sugar,
    'Milk': orderline.milk,
    'GetTime': new Date(),
    'OrderStatus': {
      'orderStatusId': orderline.orderStatus.orderStatusId,
      'statusName': orderline.orderStatus.statusName
    }
  });
  }

  constructor(private auth: AuthService, private api: ApiService) {
  }
}

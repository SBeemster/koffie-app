import { Component, OnInit } from '@angular/core';
import { OrderService } from '../../../core/services/order.service';
import { AvailableCoffeeService } from '../../../core/services/Available-coffee.service';
import { ApiService } from '../../../core/services/api.service';
import { OrderLine } from '../../../core/classes/orderLine';
import { Drink } from 'src/app/core/classes/drink';
import { User } from '../../../core/classes/user';
import { AuthService } from 'src/app/core/services/auth.service';

@Component({
  selector: 'app-overview',
  templateUrl: './overview.component.html',
  styleUrls: ['./overview.component.scss']
})
export class OverviewComponent implements OnInit {
  orderlines = [];
  ordersGrouped = [];
  availableCoffees = [];
  ordersPerUser = [];
  orderStatussen = [];
  constructor(
    private orderService: OrderService,
    private api: ApiService,
    private availableCoffeeService: AvailableCoffeeService,
    private auth: AuthService
  ) { }

  ngOnInit() {
    this.availableCoffeeService.getCoffee().subscribe(
      drink => {
        this.availableCoffees.push(drink);
      },
      console.error,
      () => {
        console.log('GetCoffee complete');
        this.orderService.getOrders().subscribe(
          orderline => {
            this.orderlines.push(orderline);
          },
          console.error,
          () => {
            console.log('GetOrders complete');
            for (let i = 0; i < this.availableCoffees.length; i++) {
              this.ordersGrouped.push([
                this.availableCoffees[i].drinkName,
                this.orderlines.reduce(
                  (acc, orderline) =>
                    orderline.drink.drinkName === this.availableCoffees[i].drinkName
                    && orderline.orderStatus.statusName.toLowerCase() === 'ordered'
                      ? acc + orderline.count
                      : acc,
                  0
                )
              ]);
            }
          }
        );
        this.orderService.getStatussen().subscribe(
          orderstatus => {
            this.orderStatussen.push(orderstatus);
          },
          console.error,
          () => {
            console.log('GetStatussen Complete complete');
          }
        );
      }
    );
  }

  gaHalen(): void {
    for (const orderline of this.orderlines) {
      if (orderline.orderStatus.statusName.toLowerCase() === 'ordered') {
        orderline.halen = true;
        const me: User = {
          userId: this.auth.getDecodedToken().nameid,
          firstName: '',
          lastName: ''
        };
        orderline.server = me;
        orderline.orderStatus = this.orderStatussen.find(status => status.statusName.toString().toLowerCase() === 'finished');
        
        this.orderService.putOrderline(orderline).subscribe(
          console.log,
          console.error
        );
        this.ordersPerUser.push(orderline);
      }
    }
    this.ordersPerUser
      .sort(function (a, b) {
        const textA = a.customer.firstName.toUpperCase();
        const textB = b.customer.firstName.toUpperCase();
        return (textA < textB) ? -1 : (textA > textB) ? 1 : 0;
      });
  }
}

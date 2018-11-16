import { Component, OnInit } from '@angular/core';
import { AvailableCoffeeService } from '../../../core/services/Available-coffee.service';
import { OrderService } from '../../../core/services/order.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Drink } from '../../../core/classes/drink';
import { User } from '../../../core/classes/user';
import { ApiService } from '../../../core/services/api.service';
import { AuthService } from '../../../core/services/auth.service';
import { OrderStatus } from 'src/app/core/classes/order-status';
import { OrderLine } from 'src/app/core/classes/orderLine';
import { PreferenceService } from '../../../core/services/preference.service';
import { DrinkPreference } from 'src/app/core/classes/drink-preference';

@Component({
  selector: 'app-choice',
  templateUrl: './choice.component.html',
  styleUrls: ['./choice.component.scss']
})
export class ChoiceComponent implements OnInit {
  milkcnt = 0;
  sugarcnt = 0;
  newAantal = 1;
  orderlines = [];
  availableCoffee = {};
  id = '';
  preferenceId: string;

  constructor(
    private availableCoffeeService: AvailableCoffeeService,
    private preferenceService: PreferenceService,
    private orderService: OrderService,
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private auth: AuthService,
    private api: ApiService
  ) { }

  ngOnInit() {
    const id = this.activatedRoute.snapshot.params['coffeeId'];
    this.availableCoffeeService.getSingleCoffee(id).subscribe(
      drink => {
        this.availableCoffee = drink;
      },
      console.error,
      () => {
        console.log('complete');
      }
    );
    this.orderService.getOrders().subscribe(
      orderline => {
        this.orderlines.push(orderline);
      },
      console.error,
      () => {
        console.log('GetOrders complete');
      }
    );
  }

  addToOrder(
    drink: Drink,
    count: number,
    milk: number,
    sugar: number
  ) {

    const orderline : OrderLine = {
      orderLineId : "",
      customer : {
        userId : this.auth.getDecodedToken().nameid,
        firstName : "",
        lastName : ""
      },
      drink : drink,
      count : count,
      milk : milk,
      sugar : sugar
    }
    this.orderService.postOrderline(orderline).subscribe(
      console.log,
      console.error
    );
    this.orderlines.push(orderline);
    this.router.navigate(['order']);

  }
  milkCountUp() {
    if (this.milkcnt < 3) { this.milkcnt++; }
  }
  milkCountDown() {
    if (this.milkcnt >= 1) { this.milkcnt--; }
  }
  sugarCountUp() {
    if (this.sugarcnt < 3) { this.sugarcnt++; }
  }
  sugarCountDown() {
    if (this.sugarcnt >= 1) { this.sugarcnt--; }
  }
  drinkCountUp() {
    this.newAantal++;
  }
  drinkCountDown() {
    if (this.newAantal > 1) { this.newAantal--; }
  }
  submitPreference(availableCoffee, milkcnt, sugarcnt) {
    this.preferenceService.postPreference(availableCoffee, milkcnt, sugarcnt).subscribe(
      console.log,
      console.error,
      () => {
      console.log('Set preference complete');
      }
    );
  }
}

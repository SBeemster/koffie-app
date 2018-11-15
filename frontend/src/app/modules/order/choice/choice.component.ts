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
  melkcnt = 0;
  suikercnt = 0;
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


    this.api.post('/OrderLines', {
      'Customer': {
        userId: this.auth.getDecodedToken().nameid
      },
      'Drink': drink,
      'Count': count,
      'Sugar': sugar,
      'Milk': milk,
      'OrderTime': new Date()
    }).subscribe(
      res => { this.id = res.toString(); },
      console.error
    );
    const user: User = {
      userId: this.auth.getDecodedToken().nameid,
      firstName: '',
      lastName: ''
    };
    const newOrderline: OrderLine = {
      orderLineId: this.id,
      drink: drink,
      count: count,
      customer: user,
      milk: milk,
      sugar: sugar
    };
    this.orderlines.push(newOrderline);
    // console.log(newProduct);

    this.router.navigate(['order']);

  }
  melkCountUp() {
    if (this.melkcnt < 3) { this.melkcnt++; }
  }
  melkCountDown() {
    if (this.melkcnt >= 1) { this.melkcnt--; }
  }
  suikerCountUp() {
    if (this.suikercnt < 3) { this.suikercnt++; }
  }
  suikerCountDown() {
    if (this.suikercnt >= 1) { this.suikercnt--; }
  }
  drinkCountUp() {
    this.newAantal++;
  }
  drinkCountDown() {
    if (this.newAantal > 1) { this.newAantal--; }
  }
  submitPreference(availableCoffee, melkcnt, suikercnt) {
    this.preferenceService.postPreference(availableCoffee, melkcnt, suikercnt).subscribe(
      console.log,
      console.error,
      () => {
      console.log('Set preference complete');
      }
    );
  }
}

import { Component, OnInit } from '@angular/core';
import { AvailableCoffeeService } from '../../../core/services/Available-coffee.service';
import { OrderService } from '../../../core/services/order.service';
import { PreferenceService } from '../../../core/services/preference.service';
import { Drink } from '../../../core/classes/drink';
import { OrderLine } from 'src/app/core/classes/orderLine';
import { AuthService } from '../../../core/services/auth.service';
import { DrinkPreference } from 'src/app/core/classes/drink-preference';

@Component({
    selector: 'app-place',
    templateUrl: './place.component.html',
    styleUrls: ['./place.component.scss']
})
export class PlaceComponent implements OnInit {
    availableCoffees = [];
    milkcnt = 0;
    sugarcnt = 0;
    userPreference: DrinkPreference = {
        preferenceId : '',
        drink : {
          drinkId : '',
          drinkName : '',
          available : null,
          additions : null,
          imageUrl : ''
        },
        user : null,
        milk : null,
        sugar : null
      };
    constructor(
        private availableCoffeeService: AvailableCoffeeService,
        private preferenceService: PreferenceService,
        private orderService: OrderService,
        private auth: AuthService
    ) { }

    ngOnInit() {
        const drinkPreference = this.preferenceService.getPreference();
        this.availableCoffeeService.getCoffee().subscribe(
            drink => {
                this.availableCoffees.push(drink);
            },
            console.error,
            () => {
                this.availableCoffees = this.availableCoffees.sort((a, b) => {
                    if (a.drinkName.toLowerCase() > b.drinkName.toLowerCase()) {
                        return 1;
                    }
                    if (b.drinkName.toLowerCase() > a.drinkName.toLowerCase()) {
                        return -1;
                    }
                    return 0;
                });
            }
        );
        this.preferenceService.getPreference().subscribe(
            userPreference => {
                this.userPreference = userPreference;
                this.milkcnt = userPreference.milk;
                this.sugarcnt = userPreference.sugar;
                console.log(userPreference);
            },
            console.error,
        );
    }
    addToOrder(
        drink: Drink,
        milk: number,
        sugar: number
      ) {
        const orderline: OrderLine = {
            orderLineId : '',
            customer : {
              userId : this.auth.getDecodedToken().nameid,
              firstName : '',
              lastName : ''
            },
            drink : drink,
            count : 1,
            milk : milk,
            sugar : sugar
          };
          console.log(orderline);
          this.orderService.postOrderline(orderline).subscribe(
            console.log,
            console.error
          );
      }
    milkCountUp() {
        if (this.milkcnt < 3) {
            this.milkcnt++;
            this.submitPreference();
            }
    }
    milkCountDown() {
        if (this.milkcnt >= 1) {
            this.milkcnt--;
            this.submitPreference();
        }
    }
    sugarCountUp() {
        if (this.sugarcnt < 3) {
            this.sugarcnt++;
            this.submitPreference();
        }
    }
    sugarCountDown() {
        if (this.sugarcnt >= 1) {
            this.sugarcnt--;
            this.submitPreference();
        }
    }
    submitPreference() {
        this.preferenceService.putPreference(this.userPreference.drink, this.milkcnt, this.sugarcnt).subscribe(
          preference => {
            this.userPreference = preference;
          },
          console.error,
          () => {
          console.log('Set preference complete');
          }
        );
      }
    emptyPreference() {
        this.preferenceService.putPreference(null, null, null).subscribe(
          preference => {
            this.userPreference = preference;
          },
          console.error,
          () => {
          console.log('Set preference complete');
          }
        );
      }
}

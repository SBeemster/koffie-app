import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { DrinkPreference } from 'src/app/core/classes/drink-preference';
import { PreferenceService } from 'src/app/core/services/preference.service';
import { Drink } from 'src/app/core/classes/drink';
import { OrderLine } from 'src/app/core/classes/orderLine';
import { OrderService } from 'src/app/core/services/order.service';
import { AuthService } from 'src/app/core/services/auth.service';

@Component({
    selector: 'app-favorite',
    templateUrl: './favorite.component.html',
    styleUrls: ['./favorite.component.scss']
})
export class FavoriteComponent implements OnInit {
    @Output() notify: EventEmitter<DrinkPreference> = new EventEmitter<DrinkPreference>();

    milkcnt = 0;
    sugarcnt = 0;
    userPreference: DrinkPreference = {
        preferenceId: '',
        drink: {
            drinkId: '',
            drinkName: '',
            available: null,
            additions: null,
            imageUrl: ''
        },
        user: null,
        milk: null,
        sugar: null
    };

    constructor(
        private preferenceService: PreferenceService,
        private orderService: OrderService,
        private auth: AuthService
    ) { }

    ngOnInit() {
        this.preferenceService.getPreference().subscribe(
            userPreference => {
                this.userPreference = userPreference;
                this.milkcnt = userPreference.milk;
                this.sugarcnt = userPreference.sugar;
                console.log(userPreference);
            },
            console.error,
            () => {
                this.notify.emit(this.userPreference);
            }
        );
    }

    addToOrder(drink: Drink, milk: number, sugar: number) {
        const orderline: OrderLine = {
            orderLineId: '',
            customer: {
                userId: this.auth.getDecodedToken().nameid,
                firstName: '',
                lastName: ''
            },
            drink: drink,
            count: 1,
            milk: milk,
            sugar: sugar
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
                this.notify.emit(this.userPreference);
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
                this.notify.emit(this.userPreference);
            }
        );
    }

}

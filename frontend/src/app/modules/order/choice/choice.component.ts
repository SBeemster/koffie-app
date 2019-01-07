import { Component, OnInit } from '@angular/core';
import { AvailableCoffeeService } from '../../../core/services/Available-coffee.service';
import { OrderService } from '../../../core/services/order.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Drink } from '../../../core/classes/drink';
import { AuthService } from '../../../core/services/auth.service';
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
    availableCoffee: Drink = {
        drinkId: '',
        drinkName: '',
        available: null,
        additions: null,
        imageUrl: ''
    };
    id = '';
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
        private availableCoffeeService: AvailableCoffeeService,
        private preferenceService: PreferenceService,
        private orderService: OrderService,
        private activatedRoute: ActivatedRoute,
        private router: Router,
        private auth: AuthService,
    ) { }

    ngOnInit() {
        const id = this.activatedRoute.snapshot.params['coffeeId'];
        this.availableCoffeeService.getSingleCoffee(id).subscribe(
            drink => {
                this.availableCoffee = drink;
            },
            console.error
        );
        this.preferenceService.getPreference().subscribe(
            preference => {
                this.userPreference = preference;
            },
            console.error
        );
    }

    addToOrder(
        drink: Drink,
        count: number,
        milk: number,
        sugar: number
    ) {

        const orderline: OrderLine = {
            orderLineId: '',
            customer: {
                userId: this.auth.getDecodedToken().nameid,
                firstName: '',
                lastName: ''
            },
            drink: drink,
            count: count,
            milk: milk,
            sugar: sugar
        };
        this.orderService.postOrderline(orderline).subscribe(
            result => {
                this.router.navigate(['/dashboard']);
            },
            console.error
        );

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
        this.preferenceService.putPreference(availableCoffee, milkcnt, sugarcnt).subscribe(
            preference => {
                this.userPreference = preference;
            },
            console.error
        );
    }
    emptyPreference() {
        this.preferenceService.putPreference(null, null, null).subscribe(
            preference => {
                this.userPreference = preference;
            },
            console.error
        );
    }
}

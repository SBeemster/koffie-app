import { Component, OnInit } from '@angular/core';
import { AvailableCoffeeService } from '../../../core/services/Available-coffee.service';
import { OrderService } from '../../../core/services/order.service';
import { PreferenceService } from '../../../core/services/preference.service';

@Component({
    selector: 'app-place',
    templateUrl: './place.component.html',
    styleUrls: ['./place.component.scss']
})
export class PlaceComponent implements OnInit {
    availableCoffees = [];
    milkcnt = 0;
    sugarcnt = 0;
    userPreference;
    constructor(
        private availableCoffeeService: AvailableCoffeeService,
        private preferenceService: PreferenceService
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
                console.log(userPreference)
            },
            console.error,
        )
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
}

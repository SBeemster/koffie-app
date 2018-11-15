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
    melkcnt = 0;
    suikercnt = 0;
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
}

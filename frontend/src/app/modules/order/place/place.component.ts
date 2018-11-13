import { Component, OnInit } from "@angular/core";
import { AvailableCoffeeService } from "../../../core/services/Available-coffee.service";
import { OrderService } from "../../../core/services/order.service";

@Component({
    selector: "app-place",
    templateUrl: "./place.component.html",
    styleUrls: ["./place.component.scss"]
})
export class PlaceComponent implements OnInit {
    availableCoffees =[];
    constructor(
        private availableCoffeeService: AvailableCoffeeService
    ) { }

    ngOnInit() {
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
                })
            }
        );
    }
}

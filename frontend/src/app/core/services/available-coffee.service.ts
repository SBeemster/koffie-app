import { Injectable } from '@angular/core';
import { ApiService } from "./api.service";
import { forEach } from '@angular/router/src/utils/collection';
import { Drink } from '../classes/drink';

@Injectable({
    providedIn: "root"
})
export class AvailableCoffeeService {
    availableCoffee: Drink[] = [];
    response: object = { "response": "no response yet..." };
    getCoffee(): Array<Drink> {
        return this.availableCoffee;
    }
    constructor(private api: ApiService) {
        this.api.get("/drinks?available=true").subscribe(
            res => {
                for (let i in res) {
                    let drank = new Drink(res[i].drinkId, res[i].drinkName, res[i].available, res[i].imageUrl, res[i].additions);
                    this.availableCoffee.push(drank);
                }
                this.availableCoffee = this.availableCoffee.sort((a, b) => {
                    if (a.drinkName.toLowerCase() > b.drinkName.toLowerCase()) {
                        return 1;
                    }
                    if (b.drinkName.toLowerCase() > a.drinkName.toLowerCase()) {
                        return -1;
                    }
                    return 0;
                })
            }, //success
            res => { this.response = res; } //error

        )

    }

    getSingleCoffee(id: string): Drink {
        return this.availableCoffee.find(result => id === result.DrinkId);
    }
}

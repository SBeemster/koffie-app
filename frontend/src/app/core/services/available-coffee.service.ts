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
                this.response = res;
                    let i = 0;
                    for (var s in this.response) {
                        var drank = new Drink (this.response[i].drinkId, this.response[i].drinkName, this.response[i].available, this.response[i].imageUrl);
                        this.availableCoffee.push(drank);
                        i++;
                    }                         
            }, //success
            res => { this.response = res; } //error

        )

    }

    getSingleCoffee(id: string): Drink {
        return this.availableCoffee.find(result => id === result.drinkId);
    }
}

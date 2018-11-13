import { Injectable } from '@angular/core';
import { ApiService } from "./api.service";
import { Drink } from '../classes/drink';
import { Observable } from "rxjs";
import { map, concatAll } from "rxjs/operators";

@Injectable({
    providedIn: "root"
})
export class AvailableCoffeeService {
    response: object = { "response": "no response yet..." };
    getCoffee(): Observable<Drink> {
        return this.api.get('/drinks?available=true').pipe(
            concatAll(),
            map(obj => {
                const drink: Drink = {
                    drinkId: obj['drinkId'],
                    drinkName: obj['drinkName'],
                    available: obj['available'],
                    imageUrl: obj['imageUrl'],
                    additions: obj['additions']
                };
                return drink;
            })
        );
    }


    getSingleCoffee(id: string): Observable<Drink> {
        return this.api.get('/drinks/' + id).pipe(
            
            map(obj => {
                const drink: Drink = {
                    drinkId: obj['drinkId'],
                    drinkName: obj['drinkName'],
                    available: obj['available'],
                    imageUrl: obj['imageUrl'],
                    additions: obj['additions']
                };
                return drink;
            })
        );
    }
    constructor(private api: ApiService) {
    }

}

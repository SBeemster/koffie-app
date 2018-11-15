import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ApiService } from "./api.service";
import { concatAll, map } from "rxjs/operators";
import { DrinkPreference } from "../classes/drink-preference";


@Injectable({
  providedIn: "root"
})
export class PreferenceService {

  postPreference(availableCoffee, melkcnt, suikercnt): void {
    this.api.post('/DrinkPreferences', { "User": 'test', "Drink": availableCoffee, "Milk": melkcnt, "Sugar": suikercnt }).subscribe(console.log, console.error)
  }

  getPreference(): Observable<DrinkPreference> {
    return this.api.get('').pipe(concatAll<any>(), map(obj => {
      const drinkpreference: DrinkPreference = {
        User: obj['User'],
        Drink: obj['Drink'],
        Milk: obj['Milk'],
        Sugar: obj['Sugar']
      };
      return drinkpreference;
    }))
  }
  constructor(private api: ApiService) { }
}

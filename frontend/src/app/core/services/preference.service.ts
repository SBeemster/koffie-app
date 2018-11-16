import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiService } from './api.service';
import { concatAll, map } from 'rxjs/operators';
import { DrinkPreference } from '../classes/drink-preference';
import { AuthService } from './auth.service';


@Injectable({
  providedIn: 'root'
})
export class PreferenceService {

  putPreference(availableCoffee, milkcnt, sugarcnt): Observable<DrinkPreference> {
    return this.api.put('/drinkpreferences/byuserid/' + this.auth.getDecodedToken().nameid , {
      'User': {
        'userId' : this.auth.getDecodedToken().nameid
      },
      'Drink': availableCoffee,
      'Milk': milkcnt,
      'Sugar': sugarcnt }).pipe(map(obj => {
        const drinkpreference: DrinkPreference = {
          preferenceId: obj['preferenceId'],
          user: obj['user'],
          drink: obj['drink'],
          milk: obj['milk'],
          sugar: obj['sugar']
        };
        return drinkpreference;
      }));
}

  getPreference(): Observable<DrinkPreference> {
    return this.api.get('/drinkpreferences/byuserid/' + this.auth.getDecodedToken().nameid).pipe(map(obj => {
      const drinkpreference: DrinkPreference = {
        preferenceId: obj['preferenceId'],
        user: obj['user'],
        drink: obj['drink'],
        milk: obj['milk'],
        sugar: obj['sugar']
      };
      return drinkpreference;
    }));
  }
  constructor(private api: ApiService, private auth: AuthService) { }
}

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

  postPreference(availableCoffee, melkcnt, suikercnt): Observable<Object> {
    return this.api.post('/DrinkPreferences', {
      'User': {
        'userId' : this.auth.getDecodedToken().nameid
      },
      'Drink': availableCoffee,
      'Milk': melkcnt,
      'Sugar': suikercnt }).pipe(map(obj => {
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
    return this.api.get('').pipe(concatAll<any>(), map(obj => {
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

import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AvailableCoffeeService {
  availableCoffee: String[] = [
    'Koffie',
    'Cappucino',
    'Latte Macchiato',
    'Thee'
  ];
  getCoffee(): Array<String> {
    return this.availableCoffee;
  }
  constructor() { }
}

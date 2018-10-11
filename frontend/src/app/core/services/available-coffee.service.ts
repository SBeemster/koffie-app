import { Injectable } from "@angular/core";

@Injectable({
  providedIn: "root"
})
export class AvailableCoffeeService {
  availableCoffee: String[] = [
    "Koffie",
    "Koffie met melk",
    "Koffie met suiker",
    "Koffie compleet",
    "Cappucino",
    "Latte Macchiato",
    "Thee"
  ];
  getCoffee(): Array<String> {
    return this.availableCoffee;
  }
  constructor() {}
}

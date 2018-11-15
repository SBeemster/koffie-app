import { Drink } from "./drink";

export class DrinkPreference {
    User: string;
    Drink: Drink;
    Milk: string;
    Sugar: string;

    constructor(
        User: string,
        Drink: Drink,
        Milk: string,
        Sugar: string) {
        this.User = 'verbruiker1';
        this.Drink = Drink;
        this.Milk = Milk;
        this.Sugar = Sugar;
    }

}

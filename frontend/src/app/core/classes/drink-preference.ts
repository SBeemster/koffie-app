import { Drink } from './drink';
import { User } from './user';

export class DrinkPreference {
    preferenceId: string;
    user: User;
    drink: Drink;
    milk: number;
    sugar: number;
}

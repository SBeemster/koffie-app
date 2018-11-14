import { Drink } from "./drink";
import {OrderStatus} from "./order-status";
import {User} from "./user";

export class OrderLine {
  orderLineId: string;
  drink: Drink;
  count: number;
  customer: User;
  server?: User;
  halen? : boolean;
  milk: number;
  sugar: number;
  orderStatus: OrderStatus;

}

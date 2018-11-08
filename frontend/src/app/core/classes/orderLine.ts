import { Drink } from "./drink";

export class OrderLine {
  orderLineId: string;
  drink: Drink;
  aantal: number;
  verbruiker: string;
  verwerkt: boolean;
  halen: boolean;
  melk: number;
  suiker: number;

  constructor(
    orderLineId: string = "",
    drink: Drink,
    aantal: number,
    verbruiker: string,
    melk: number,
    suiker: number
  ) {
    this.orderLineId = orderLineId
    this.drink = drink;
    this.aantal = aantal;
    this.verbruiker = verbruiker;
    this.verwerkt = false;
    this.halen = false;
    this.melk = melk;
    this.suiker = suiker;
  }
}

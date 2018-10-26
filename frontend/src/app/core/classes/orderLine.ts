import { Drink } from "./drink";

export class OrderLine {
  drink: Drink;
  aantal: number;
  verbruiker: string;
  verwerkt: boolean;
  halen: boolean;
  melk: number;
  suiker: number;

  constructor(
    drink: Drink,
    aantal: number,
    verbruiker: string,
    melk: number,
    suiker: number
  ) {
    this.drink = drink;
    this.aantal = aantal;
    this.verbruiker = verbruiker;
    this.verwerkt = false;
    this.halen = false;
    this.melk = melk;
    this.suiker = suiker;
  }
}

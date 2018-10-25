export class OrderLine {
  name: string;
  aantal: number;
  verbruiker: string;
  verwerkt: boolean;
  halen: boolean;
  melk: number;
  suiker: number;

  constructor(
    newName: string,
    aantal: number,
    verbruiker: string,
    melk: number,
    suiker: number
  ) {
    this.name = newName;
    this.aantal = aantal;
    this.verbruiker = verbruiker;
    this.verwerkt = false;
    this.halen = false;
    this.melk = melk;
    this.suiker = suiker;
  }
}

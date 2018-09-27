export class OrderLine {
    name: string;
    aantal: number;
    verbruiker: string;
    verwerkt: boolean;
    constructor(newName: string, aantal: number, verbruiker: string) {
        this.name = newName;
        this.aantal = aantal;
        this.verbruiker = verbruiker;
        this.verwerkt = false;
    }
}

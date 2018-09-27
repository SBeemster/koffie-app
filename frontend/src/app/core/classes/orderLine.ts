export class OrderLine {
    name: string;
    aantal: number;
    verbruiker: string;
    constructor(newName: string, aantal: number, verbruiker: string) {
        this.name = newName;
        this.aantal = aantal;
        this.verbruiker = verbruiker;
    }
}

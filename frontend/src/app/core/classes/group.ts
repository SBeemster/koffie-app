export class Group {
    name: string;
    newName: string;
    leden;
    edit: boolean;
    constructor(newName: string) {
        this.name = newName;
        this.newName = newName;
        this.edit = false;
    }
    setName(newName: string): void {
        this.name = newName;
        this.newName = newName;
    }
}

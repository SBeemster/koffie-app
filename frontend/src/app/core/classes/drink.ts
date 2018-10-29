export class Drink {
    drinkId: string;
    drinkName: string;
    available: boolean;
    imageUrl: string;
    additions: boolean;

    constructor(drinkId: string, drinkName: string, available: boolean = true, imageUrl: string = "/assets/Images/Latte Macchiato.jpg", additions: boolean = true) {
        this.drinkId = drinkId;
        this.drinkName = drinkName;
        this.available = available;
        if (imageUrl != null && imageUrl != "") {
            this.imageUrl = imageUrl;
        } else {
            this.imageUrl = "/assets/Images/Latte Macchiato.jpg";
        }
        this.additions = additions;
    }
}

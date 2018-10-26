export class Drink {
    drinkID: string;
    drinkName: string;
    available: boolean;
    imageUrl: string;

    constructor(drinkID: string, drinkName: string, available: boolean = true, imageUrl: string = "/assets/Images/Latte Macchiato.jpg") {
        this.drinkID = drinkID;
        this.drinkName = drinkName;
        this.available = available;
        if (imageUrl != null && imageUrl != "") {
            this.imageUrl = imageUrl;
        } else {
            this.imageUrl = "/assets/Images/Latte Macchiato.jpg";
        }
    }
}

export class Drink {
    DrinkId: string;
    drinkName: string;
    Available: boolean;
    ImageUrl: string;
    Additions: boolean;

    constructor(DrinkId: string, drinkName: string, Available: boolean = true, ImageUrl: string = "/assets/Images/Latte Macchiato.jpg", Additions: boolean = true) {
        this.DrinkId = DrinkId;
        this.drinkName = drinkName;
        this.Available = Available;
        if (ImageUrl != null && ImageUrl != "") {
            this.ImageUrl = ImageUrl;
        } else {
            this.ImageUrl = "/assets/Images/Latte Macchiato.jpg";
        }
        this.Additions = Additions;
    }
}

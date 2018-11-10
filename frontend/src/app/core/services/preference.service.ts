import { Injectable } from "@angular/core";
import { AuthService } from "./auth.service";
import { ApiService } from "./api.service";

@Injectable({
  providedIn: "root"
})
export class PreferenceService {
  userid() {
    if (this.auth.isLoggedIn()) {
      return this.auth.getDecodedToken().nameid;
    }
  }

  //submitPreference() {
    //this.api
      //.post("/DrinkPreferences", {
        ////User: this.verbruiker,
        //Drink: this.availableCoffee,
        //Milk: this.melkcnt,
        //Sugar: this.suikercnt
      //})
      //.subscribe(console.log, console.error);
  //}

  constructor(private auth: AuthService, private api: ApiService) {}
}

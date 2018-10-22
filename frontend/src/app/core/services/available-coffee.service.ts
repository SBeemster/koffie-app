import { Injectable } from '@angular/core';
import { ApiService } from "./api.service";
import { forEach } from '@angular/router/src/utils/collection';

@Injectable({
  providedIn: 'root'
})
export class AvailableCoffeeService {
  availableCoffee: String[] = [];
  response: object = { "response": "no response yet..." };
  getCoffee(): Array<String> {
    
    return this.availableCoffee;
    
  }
  constructor(private api: ApiService) { 
    this.api.get("/drinks?available=true").subscribe(
          res => { this.response = res; 
            let i = 0;
              for(var s in this.response){
                this.availableCoffee.push(this.response[i].drinkName);
                i++;
              }
            console.log(res[0].drinkName)}, //success
          res => { this.response = res; } //error
          
      )
      
      //for(let s of this.response.Drink)
      //{
        //this.availableCoffee.push(s.drinkName);
      //}
  }
}

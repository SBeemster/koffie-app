import { Component, OnInit } from "@angular/core";
import { OrderService } from "../../../core/services/order.service";
import { AvailableCoffeeService } from "../../../core/services/Available-coffee.service";
import { ApiService } from "../../../core/services/api.service";
import { OrderLine } from "../../../core/classes/orderLine";
import { Drink } from "src/app/core/classes/drink";

@Component({
  selector: "app-overview",
  templateUrl: "./overview.component.html",
  styleUrls: ["./overview.component.scss"]
})
export class OverviewComponent implements OnInit {
  orderlines= [];
  ordersGrouped = [];
  availableCoffees = [];
  ordersPerUser = [];
  constructor(
    private OrderService: OrderService,
    private api: ApiService,
    private availableCoffeeService: AvailableCoffeeService
  ) {}

  ngOnInit() {
    this.availableCoffeeService.getCoffee().subscribe(
      drink => {
          this.availableCoffees.push(drink);
      },
      console.error,
      () => {
        console.log("GetCoffee complete");
        
    }
  );

    this.OrderService.getOrders().subscribe(
      orderline => {
        this.orderlines.push(orderline);
    },
    console.error,
    () => {
        console.log("GetOrders complete");
        for (let i = 0; i < this.availableCoffees.length; i++) {
          this.ordersGrouped.push([
            this.availableCoffees[i].drinkName,
            this.orderlines.reduce(
              (acc, orderline) =>
                orderline.drink.drinkName === this.availableCoffees[i].drinkName && orderline.orderStatus.statusName.toLowerCase() === "ordered"
                  ? acc + orderline.count
                  : acc,
              0
            )
          ]);
         
      }
      this.getOrdersPerUser();
    }

    );
    

    
    this.OrderService.setHalenFalse();
  }
  
 getOrdersPerUser(): void{
    this.ordersPerUser = this.orderlines
    
    .sort(function(a, b) {
      var textA = a.verbruiker.toUpperCase();
      var textB = b.verbruiker.toUpperCase();
      return (textA < textB) ? -1 : (textA > textB) ? 1 : 0;
  });
  }
  gaHalen():void {
   
    for (let orderline of this.orderlines) {
      if (orderline.orderStatus.statusName.toLowerCase() === "ordered") {
        orderline.halen = true;
       //s.orderStatus = orderstatus;
        console.log(orderline);
       this.api.put("/OrderLines/" + orderline.orderLineId, {
        "OrderLineId": orderline.orderLineId,
          "Customer": {
            "UserId": orderline.customer.userId
          },
          "Server": "",
          "Drink": {
            "drinkId":orderline.drink.drinkId,
            "drinkName": orderline.drink.drinkName
          },
          "Count": orderline.aantal,
          "Sugar": orderline.suiker,
          "Milk": orderline.melk,
          "OrderStatus": {
            "orderStatusId" :orderline.orderStatus.orderStatusId,
            "statusName" : orderline.orderStatus.statusName
        }).subscribe(
          console.log,
          console.error
        )
       
      }
    
   //this.OrderService.gaHalen();
   this.orderlines = this.OrderService.orders;
   this.getOrdersPerUser();
  } 
}
}

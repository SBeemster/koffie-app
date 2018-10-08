import { Component, OnInit } from '@angular/core';
import { OrderService } from '../../../core/services/order.service';
import { AvailableCoffeeService } from '../../../core/services/available-coffee.service';
import { OrderLine } from '../../../core/classes/orderLine';

@Component({
  selector: 'app-overview',
  templateUrl: './overview.component.html',
  styleUrls: ['./overview.component.scss']
})
export class OverviewComponent implements OnInit {

  orders=[];
  ordersGrouped=[];
  availableCoffees=[];
  ordersPerUserAndType=[];
  constructor(private OrderService: OrderService, private availableCoffeeService: AvailableCoffeeService) { }

  ngOnInit() {
    this.orders = this.OrderService.getOrders();
    this.availableCoffees = this.availableCoffeeService.getCoffee();
    this.getGroupedByCoffee();
    this.OrderService.setHalenFalse();
  }
  getGroupedByCoffee():void{
    this.ordersGrouped = [];
    for (let i = 0; i < this.availableCoffees.length; i++){
      this.ordersGrouped.push ([this.availableCoffees[i],this.orders.reduce((acc, order) => order.name === this.availableCoffees[i] && order.verwerkt === false ? acc + order.aantal : acc, 0)]);
    } 
  }
  getUserOrderType(drink: string):void{
    this.ordersPerUserAndType=[];
    this.ordersPerUserAndType=this.orders.filter(order => order.name === drink && order.halen === true);
  }
  gaHalen = this.OrderService.gaHalen;
  
}

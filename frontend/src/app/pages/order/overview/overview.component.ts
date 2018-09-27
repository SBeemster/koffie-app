import { Component, OnInit } from '@angular/core';
import { OrderService } from '../../../core/services/order.service';
import { OrderLine } from '../../../core/classes/orderLine';
@Component({
  selector: 'app-overview',
  templateUrl: './overview.component.html',
  styleUrls: ['./overview.component.scss']
})
export class OverviewComponent implements OnInit {

  orders=[];
  constructor(private OrderService: OrderService) { }

  ngOnInit() {
    this.orders = this.OrderService.getOrders();
  }

  gaHalen = this.OrderService.gaHalen;
  
}

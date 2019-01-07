import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { OrderService } from '../../../core/services/order.service';
import { AvailableCoffeeService } from '../../../core/services/Available-coffee.service';
import { User } from '../../../core/classes/user';
import { AuthService } from 'src/app/core/services/auth.service';
import { OrderLine } from 'src/app/core/classes/orderLine';
import { Drink } from 'src/app/core/classes/drink';
import { OrderStatus } from 'src/app/core/classes/order-status';

@Component({
    selector: 'app-overview',
    templateUrl: './overview.component.html',
    styleUrls: ['./overview.component.scss']
})
export class OverviewComponent implements OnInit {
    @Output() notify: EventEmitter<OrderLine[]> = new EventEmitter<OrderLine[]>();

    orderlines: OrderLine[] = [];
    availableCoffees: Drink[] = [];
    orderStatussen: OrderStatus[] = [];
    orderSnapshot: OrderLine[] = [];

    showButton = false;

    constructor(
        private orderService: OrderService,
        private availableCoffeeService: AvailableCoffeeService,
        private auth: AuthService
    ) { }

    ngOnInit() {
        const getCoffee = this.availableCoffeeService.getCoffee();
        const getOrders = this.orderService.getOrders();
        const getStatus = this.orderService.getStatussen();

        getCoffee.subscribe(drink => {
            this.availableCoffees.push(drink);
        }, console.error);

        getOrders.subscribe(orderline => {
            this.orderlines.push(orderline);
            this.showButton = true;
        }, console.error, () => {
            this.notify.emit(this.orderlines);
        });

        getStatus.subscribe(orderstatus => {
            this.orderStatussen.push(orderstatus);
        }, console.error);
    }

    refreshOrders(): void {
        this.orderlines = [];
        const getOrders = this.orderService.getOrders();
        getOrders.subscribe(orderline => {
            this.orderlines.push(orderline);
            this.showButton = true;
        }, console.error, () => {
            this.notify.emit(this.orderlines);
        });
    }

    gaHalen(): void {
        for (const orderline of this.orderlines) {
            if (orderline.orderStatus.statusName.toLowerCase() === 'ordered') {
                orderline.halen = true;
                const me: User = {
                    userId: this.auth.getDecodedToken().nameid,
                    firstName: '',
                    lastName: ''
                };
                orderline.server = me;
                orderline.orderStatus = this.orderStatussen.find(status => status.statusName.toString().toLowerCase() === 'finished');

                this.orderService.putOrderline(orderline).subscribe(
                    null,
                    console.error
                );
            }
        }
        this.showButton = false;
    }
}

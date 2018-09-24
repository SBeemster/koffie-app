import { Component, OnInit } from '@angular/core';
import { Product } from '../../../core/classes/product';
import { AvailableCoffeeService } from '../../../core/services/available-coffee.service';


@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.scss']
})
export class OrderComponent implements OnInit {

  bestellingen = [];
  availableCoffees;
  constructor(private availableCoffeeService: AvailableCoffeeService) { }

  ngOnInit() {
    this.availableCoffees = this.availableCoffeeService.getCoffee();
  }

  addToOrder(product: string, aantal: number): void {
    for (const s of this.bestellingen) {
      if (s.name === product) {
        s.aantal++;
        return;
      }
    }
    const newProduct = new Product(product ? product : 'Koffie', aantal ? aantal : 1);
    this.bestellingen.push(newProduct);
  }

  deleteFromOrder(bestelling: Product) {
    this.bestellingen.splice(this.bestellingen.indexOf(bestelling), 1);
  }

  clearCart(): void {
    this.bestellingen = [];
  }
}

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { OrderComponent } from './order/order.component';
import { OverviewComponent } from './overview/overview.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [OrderComponent, OverviewComponent]
})
export class OrderModule { }

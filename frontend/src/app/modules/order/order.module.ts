import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { OrderRoutingModule, routedComponents } from './/order-routing.module';
import { FormsModule } from '@angular/forms';

@NgModule({
  imports: [CommonModule, OrderRoutingModule, FormsModule],
  declarations: [...routedComponents]
})
export class OrderModule {}

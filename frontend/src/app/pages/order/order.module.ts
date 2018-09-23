import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { OrderRoutingModule, routedComponents } from './/order-routing.module';

@NgModule({
    imports: [
        CommonModule,
        OrderRoutingModule
    ],
    declarations: [...routedComponents]
})
export class OrderModule { }

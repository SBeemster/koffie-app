import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { routedComponents, DashboardRoutingModule } from "./dashboard-routing.module";
import { OrderModule } from "../order/order.module";

@NgModule({
    imports: [
        CommonModule, DashboardRoutingModule, OrderModule
    ],
    declarations: [...routedComponents]
})
export class DashboardModule { }

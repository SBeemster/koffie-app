import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { routedComponents, DashboardRoutingModule } from './dashboard-routing.module';
import { OrderModule } from '../order/order.module';
import { UserModule } from '../user/user.module';
import { ReportsModule } from '../reports/reports.module';

@NgModule({
    imports: [
        CommonModule, DashboardRoutingModule, OrderModule, UserModule, ReportsModule
    ],
    declarations: [...routedComponents]
})
export class DashboardModule { }

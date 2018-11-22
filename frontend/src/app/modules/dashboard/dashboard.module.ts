import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { routedComponents, DashboardRoutingModule } from "./dashboard-routing.module";

@NgModule({
    imports: [
        CommonModule, DashboardRoutingModule
    ],
    declarations: [...routedComponents]
})
export class DashboardModule { }

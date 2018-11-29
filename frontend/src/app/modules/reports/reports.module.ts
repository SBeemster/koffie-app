import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReportsRoutingModule, routedComponents } from './/reports-routing.module';

@NgModule({
  imports: [
    CommonModule,
    ReportsRoutingModule
  ],
  declarations: [...routedComponents],
})
export class ReportsModule { }


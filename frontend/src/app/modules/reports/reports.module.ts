import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReportsRoutingModule, routedComponents } from './/reports-routing.module';
import { ReportsComponent } from './reports.component';

@NgModule({
  imports: [
    CommonModule,
    ReportsRoutingModule
  ],
  declarations: [...routedComponents, ReportsComponent],
  exports: [...routedComponents]
})
export class ReportsModule { }


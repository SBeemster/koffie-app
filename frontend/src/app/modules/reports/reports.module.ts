import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReportsRoutingModule, routedComponents } from './/reports-routing.module';
import { ReportsComponent } from './reports.component';
import { MostDrinkedComponent } from './most-drinked/most-drinked.component';

@NgModule({
  imports: [
    CommonModule,
    ReportsRoutingModule
  ],
  declarations: [...routedComponents, ReportsComponent, MostDrinkedComponent],
  exports: [...routedComponents]
})
export class ReportsModule { }


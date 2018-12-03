import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReportsRoutingModule, routedComponents } from './/reports-routing.module';
import { TimeTillServedComponent } from './time-till-served/time-till-served/time-till-served.component';
import { TopDrinkerComponent } from './top-drinker/top-drinker.component';

@NgModule({
  imports: [
    CommonModule,
    ReportsRoutingModule
  ],
  declarations: [...routedComponents, TimeTillServedComponent, TopDrinkerComponent],
})
export class ReportsModule { }


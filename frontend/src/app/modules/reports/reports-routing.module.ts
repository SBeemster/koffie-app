import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TopServerComponent } from './top-server/top-server.component';
import { Routes, RouterModule } from '@angular/router';
import { TopDrinkerComponent } from './top-drinker/top-drinker.component';
import { TimeTillServedComponent } from './time-till-served/time-till-served.component';
import { ReportsComponent } from './reports.component';
import { MostDrinkedComponent } from './most-drinked/most-drinked.component';


const routes: Routes = [
  {
      path: '',
      component: ReportsComponent,
      children: [
          { path: 'top-server', component: TopServerComponent },
          { path: 'top-drinker', component: TopDrinkerComponent },
          { path: 'timetillserved', component: TimeTillServedComponent },
          { path: 'most-drinked', component: MostDrinkedComponent }
      ]
  },
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ReportsRoutingModule { }

export const routedComponents = [
  ReportsComponent, TopServerComponent, TopDrinkerComponent, TimeTillServedComponent, MostDrinkedComponent
];

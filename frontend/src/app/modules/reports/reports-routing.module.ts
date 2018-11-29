import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TopServerComponent } from './top-server/top-server.component';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
      path: '',
      component: TopServerComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ReportsRoutingModule { }

export const routedComponents = [
  TopServerComponent
];
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from "@angular/router";
import { LandingComponent } from "./landing.component";

const routes: Routes = [
    {
      path: '',
      component: LandingComponent,
    }
  ];

  @NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
export class LandingRoutingModule { }

export const routedComponents = [
    LandingComponent
  ];
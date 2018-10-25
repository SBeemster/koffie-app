import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";

import { OrderComponent } from "./order.component";
import { PlaceComponent } from "./place/place.component";
import { OverviewComponent } from "./overview/overview.component";
import { ChoiceComponent } from "./choice/choice.component";
const routes: Routes = [
  {
    path: "",
    component: OrderComponent,
    children: [
      { path: "place", component: PlaceComponent },
      { path: "overview", component: OverviewComponent },
      { path: "choice/:coffeeId", component: ChoiceComponent },
      { path: "", redirectTo: "place", pathMatch: "full" }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class OrderRoutingModule {}

export const routedComponents = [
  OrderComponent,
  PlaceComponent,
  OverviewComponent,
  ChoiceComponent
];

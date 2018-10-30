import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AuthGuard } from "./core/classes/auth-guard";
import { NotFoundComponent } from "./pages/not-found/not-found.component";

const routes: Routes = [
  {
    path: "order",
    canActivate: [AuthGuard],
    loadChildren: "./pages/order/order.module#OrderModule"
  },
  {
    path: "user",
    canActivate: [AuthGuard],
    loadChildren: "./pages/user/user.module#UserModule"
  },
  { path: "login", loadChildren: "./login/login.module#LoginModule" },
  { path: "", redirectTo: "order", pathMatch: "full" },
  { path: "**", component: NotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { enableTracing: false })],
  exports: [RouterModule]
})
export class AppRoutingModule {}

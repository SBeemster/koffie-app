import { NgModule } from '@angular/core';
import { NativeScriptRouterModule } from 'nativescript-angular/router';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './core/classes/auth-guard';
import { NotFoundComponent } from './modules/not-found/not-found.component';


export const routes: Routes = [
  {
    path: 'order',
    canActivate: [AuthGuard],
    loadChildren: './modules/order/order.module#OrderModule'
  },
    {
        path: 'user',
        canActivate: [AuthGuard],
        loadChildren: './modules/user/user.module#UserModule'
    },
    {
        path: 'dashboard',
        canActivate: [AuthGuard],
        loadChildren: './modules/dashboard/dashboard.module#DashboardModule'
    },
    {
        path: 'login',
        loadChildren: './login/login.module#LoginModule'
    },
    {
      path: '',
      loadChildren: './modules/landing/landing.module#LandingModule'
    },
    {
        path: '**',
        component: NotFoundComponent
  }
];

@NgModule({
  imports: [NativeScriptRouterModule.forRoot(routes)],
  exports: [NativeScriptRouterModule]
})
export class AppRoutingModule { }

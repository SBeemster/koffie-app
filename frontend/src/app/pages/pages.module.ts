import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PagesRouterModule } from './pages-router.module';
import { OrderModule } from './order/order.module';
import { UserModule } from './user/user.module';

@NgModule({
  imports: [
    CommonModule,
    PagesRouterModule,
    OrderModule,
    UserModule,
  ],
  declarations: []
})
export class PagesModule { }

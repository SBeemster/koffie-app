import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserRoutingModule, routedComponents } from './/user-routing.module';

@NgModule({
    imports: [
        CommonModule,
        UserRoutingModule
    ],
    declarations: [...routedComponents]
})
export class UserModule { }

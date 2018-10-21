import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LoginRoutingModule, routedComponents } from './/login-routing.module';

@NgModule({
    imports: [
        CommonModule,
        LoginRoutingModule
    ],
    declarations: [...routedComponents]
})
export class LoginModule { }

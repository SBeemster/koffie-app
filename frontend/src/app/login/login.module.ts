import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http'; //temp

import { LoginRoutingModule, routedComponents } from './/login-routing.module';

@NgModule({
    imports: [
        CommonModule,
        LoginRoutingModule,
        FormsModule,
        HttpClientModule //temp
    ],
    declarations: [...routedComponents]
})
export class LoginModule { }

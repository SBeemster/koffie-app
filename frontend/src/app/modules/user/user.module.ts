import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserRoutingModule, routedComponents } from './/user-routing.module';
import { FormsModule } from '@angular/forms';

@NgModule({
    imports: [
        CommonModule,
        UserRoutingModule,
        FormsModule
    ],
    declarations: [...routedComponents]
})
export class UserModule { }

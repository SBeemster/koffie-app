import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PagesRoutingModule, routedComponents } from './/pages-routing.module';

import { SharedModule } from '../shared/shared.module';

@NgModule({
    imports: [
        CommonModule,
        PagesRoutingModule,
        SharedModule
    ],
    declarations: [...routedComponents]
})
export class PagesModule { }

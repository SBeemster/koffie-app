import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PagesRoutingModule, routedComponents } from './/pages-routing.module';

@NgModule({
    imports: [
        CommonModule,
        PagesRoutingModule,
    ],
    declarations: [...routedComponents]
})
export class PagesModule { }

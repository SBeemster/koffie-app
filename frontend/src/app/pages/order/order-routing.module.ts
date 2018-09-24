import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { OrderComponent } from './order.component';
import { PlaceComponent } from './place/place.component';
import { OverviewComponent } from './overview/overview.component';

const routes: Routes = [
    {
        path: '',
        component: OrderComponent,
        children: [
            { path: 'place', component: PlaceComponent },
            { path: 'overview', component: OverviewComponent },
        ]
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})

export class OrderRoutingModule { }

export const routedComponents = [
    OrderComponent,
    PlaceComponent,
    OverviewComponent
];

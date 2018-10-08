import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { PagesComponent } from './pages.component';
import { NotFoundComponent } from './not-found/not-found.component';

const routes: Routes = [
    { 
        path: '', 
        component: PagesComponent,
        children: [
            { path: 'order', loadChildren: './order/order.module#OrderModule' },
            { path: 'user', loadChildren: './user/user.module#UserModule' },
            { path: '', redirectTo: 'order', pathMatch: 'full' },
            { path: '**', component: NotFoundComponent }
        ]
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})

export class PagesRoutingModule { }

export const routedComponents = [
    PagesComponent,
    NotFoundComponent
]
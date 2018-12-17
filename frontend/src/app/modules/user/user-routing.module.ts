import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { UserComponent } from './user.component';
import { GroupComponent } from './group/group.component';
import { CreateComponent } from './create/create.component';
import { EditComponent } from './edit/edit.component';
import { SelectComponent } from './select/select.component';

const routes: Routes = [
    {
        path: '',
        component: UserComponent,
        children: [
            { path: 'group/:groupId', component: GroupComponent },
            { path: 'create', component: CreateComponent },
            { path: 'select', component: SelectComponent },
            { path: 'edit/:userId', component: EditComponent },
            { path: '', redirectTo: 'group', pathMatch: 'full' }
        ]
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})

export class UserRoutingModule { }

export const routedComponents = [
    UserComponent,
    GroupComponent,
    CreateComponent,
    EditComponent,
    SelectComponent
];

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { routedComponents, LandingRoutingModule } from './landing-routing.module';

@NgModule({
    imports: [
        CommonModule, LandingRoutingModule
    ],
    declarations: [...routedComponents]
})
export class LandingModule { }

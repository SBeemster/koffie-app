import { Component, OnInit } from '@angular/core';
import { MENU_ITEMS } from './menu-items';

@Component({
    selector: 'app-menu',
    templateUrl: './menu.component.html',
    styleUrls: ['./menu.component.scss']
})
export class MenuComponent implements OnInit {
    menu = MENU_ITEMS;

    constructor() { }

    ngOnInit() {
    }
}

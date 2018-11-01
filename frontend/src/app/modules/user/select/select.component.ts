import { Component, OnInit } from '@angular/core';
import { ApiService } from "src/app/core/services/api.service";

@Component({
    selector: 'app-select',
    templateUrl: './select.component.html',
    styleUrls: ['./select.component.scss']
})
export class SelectComponent implements OnInit {

    users: object[] = [];

    constructor(
        private api: ApiService
    ) { }

    ngOnInit() {
        this.api.get("/users").subscribe(
            (res: Array<object>) => {
                this.users = res;
            },
            error => {
                console.error(error);
            }
        )
    }

}

import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/core/services/user.service';

@Component({
    selector: 'app-select',
    templateUrl: './select.component.html',
    styleUrls: ['./select.component.scss']
})
export class SelectComponent implements OnInit {

    users: object[] = [];

    constructor(
        private userService: UserService
    ) { }

    ngOnInit() {
        this.userService.getAll().subscribe(
            user => {
                this.users.push(user);
            },
            error => {
                console.error(error);
            }
        );
    }

}

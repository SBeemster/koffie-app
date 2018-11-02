import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from "@angular/router";
import { ApiService } from "src/app/core/services/api.service";

@Component({
    selector: 'app-edit',
    templateUrl: './edit.component.html',
    styleUrls: ['./edit.component.scss']
})
export class EditComponent implements OnInit {

    userLoaded: boolean = false;
    user: object = {};

    constructor(
        private api: ApiService,
        private activatedRoute: ActivatedRoute,
        private router: Router
    ) { }

    ngOnInit() {
        const userId = this.activatedRoute.snapshot.params["userId"];
        if (userId) {
            this.api.get(`/users/${userId}`).subscribe(
                response => {
                    this.user = response;
                    this.userLoaded = true;
                },
                console.error
            );
        }
    }

    awaitingResponse(): boolean {
        return this.api.awaitingResponse;
    }

    saveUser() {
        this.api.put(`/users/${this.user["userId"]}`, {
            active: this.user["active"],
            firstName: this.user["firstName"],
            lastName: this.user["lastName"],
            userId: this.user["userId"]
        }).subscribe(
            response => {
                this.router.navigate(["pages/user/select"]);
            },
            console.error
        );
    }

}
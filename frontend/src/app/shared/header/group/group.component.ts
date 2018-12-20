import { Component, OnInit } from '@angular/core';
import { GroupService } from 'src/app/core/services/group.service';
import { Group } from 'src/app/core/classes/group';
import { ApiService } from 'src/app/core/services/api.service';

@Component({
    selector: 'app-header-group',
    templateUrl: './group.component.html',
    styleUrls: ['./group.component.scss']
})
export class GroupComponent implements OnInit {

    memberGroup: Group = {
        groupId: '',
        groupName: ''
    };

    groupFound = false;
    noGroup = false;

    awaitingResponse = false;

    constructor(
        private api: ApiService,
        private groupService: GroupService
    ) { }

    ngOnInit() {
        this.groupService.header = this;
        this.refreshGroup();
        this.api.awaitingResponse.subscribe(
            state => { this.awaitingResponse = state; }
        );
    }

    refreshGroup() {
        this.groupService.getMemberGroup().subscribe(
            response => {
                if (response) {
                    this.memberGroup = response;
                    this.groupFound = true;
                    this.noGroup = false;
                } else {
                    this.groupFound = false;
                    this.noGroup = true;
                }
            }
        );
    }
}

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
        groupId: "",
        groupName: ""
    }

    groupFound = false;

    awaitingResponse = this.api.awaitingResponse;

    constructor(
        private api: ApiService,
        private groupService: GroupService
    ) { }

    ngOnInit() {
        this.groupService.getMemberGroup().subscribe(
            response => {
                if (response) {
                    this.memberGroup = response;
                    this.groupFound = true;
                }
            }
        )
    }
}

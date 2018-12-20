import { Component, OnInit, ViewChild } from '@angular/core';
import { Group } from '../../../core/classes/group';
import { ActivatedRoute, Router } from '@angular/router';
import { GroupService } from 'src/app/core/services/group.service';
import { merge } from 'rxjs';

@Component({
    selector: 'app-group',
    templateUrl: './group.component.html',
    styleUrls: ['./group.component.scss']
})
export class GroupComponent implements OnInit {
    @ViewChild('myModal') myModal;

    messageHeader: string;
    message: string;

    group: Group = {
        groupId: '',
        groupName: ''
    };

    noGroup = false;
    groupFound = false;
    isOwner = false;
    edit = false;
    newName = '';

    constructor(
        private activatedRoute: ActivatedRoute,
        private groupService: GroupService,
        private router: Router
    ) { }

    ngOnInit() {
        const groupId = this.activatedRoute.snapshot.params['groupId'];
        if (groupId) {
            this.groupService.getGroupById(groupId).subscribe(
                response => {
                    this.group = response;
                    this.groupFound = true;
                    this.completeObservable();
                },
                console.error
            );

            this.groupService.getIsGroupOwner(groupId).subscribe(
                response => {
                    this.isOwner = response;
                    this.completeObservable();
                },
                console.error
            );
        } else {
            this.noGroup = true;
        }
    }

    renameGroup() {
        if (this.newName.length < 3) {
            this.messageHeader = 'Groepsnaam te kort';
            this.message = 'U heeft een groepsnaam opgeven die te kort is. Probeer een naam van minimaal 3 tekens.';
            this.openModal();
            return;
        } else {
            this.group.groupName = this.newName;
            this.edit = false;
            this.groupService.putGroup(this.group).subscribe(
                () => {
                    this.groupService.header.refreshGroup();
                },
                console.error
            );
        }
    }

    newGroup() {
        if (this.newName.length < 3) {
            this.messageHeader = 'Groepsnaam te kort';
            this.message = 'U heeft een groepsnaam opgeven die te kort is. Probeer een naam van minimaal 3 tekens.';
            this.openModal();
            return;
        } else {
            this.groupService.postGroup(this.newName).subscribe(
                () => {
                    this.groupService.header.refreshGroup();
                    this.router.navigate(['/dashboard']);
                },
                console.error
            );
        }
    }

    deleteGroup() {
        this.groupService.deleteGroup(this.group.groupId).subscribe(
            () => {
                this.groupService.header.refreshGroup();
                this.router.navigate(['/dashboard']);
            },
            console.error
        );
    }

    leaveGroup() {

    }

    addUser(userName: string) {

    }

    openModal() {
        this.myModal.nativeElement.className = 'modal fade show';
    }

    closeModal() {
        this.myModal.nativeElement.className = 'modal hide';
    }

    private completeObservable() {
        if (this.groupFound && this.isOwner) {
            this.edit = false;
            this.newName = this.group.groupName;
        }
    }
}

import { Component, OnInit, ViewChild } from '@angular/core';
import { Group } from '../../../core/classes/group';
import { ActivatedRoute, Router } from '@angular/router';
import { GroupService } from 'src/app/core/services/group.service';
import { merge } from 'rxjs';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
    selector: 'app-group',
    templateUrl: './group.component.html',
    styleUrls: ['./group.component.scss']
})
export class GroupComponent implements OnInit {
    @ViewChild('myModal') myModal;

    messageHeader: string;
    messageBody: string;

    group: Group = {
        groupId: '',
        groupName: ''
    };

    noGroup = false;
    groupFound = false;
    isOwner = false;
    edit = false;
    newName = '';
    username = '';

    constructor(
        private activatedRoute: ActivatedRoute,
        private groupService: GroupService,
        private router: Router
    ) { }

    ngOnInit() {
        const groupId = this.activatedRoute.snapshot.params['groupId'];
        if (groupId) {
            this.populatePage(groupId);
        } else {
            this.noGroup = true;
        }
    }

    renameGroup() {
        if (this.newName.length < 3) {
            this.messageHeader = 'Groepsnaam te kort';
            this.messageBody = 'U heeft een groepsnaam opgeven die te kort is. Probeer een naam van minimaal 3 tekens.';
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
            this.messageBody = 'U heeft een groepsnaam opgeven die te kort is. Probeer een naam van minimaal 3 tekens.';
            this.openModal();
            return;
        } else {
            this.groupService.postGroup(this.newName).subscribe(
                (groupId: string) => {
                    this.groupService.header.refreshGroup();
                    this.noGroup = false;
                    this.populatePage(groupId);
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
        this.groupService.leaveGroup(this.group.groupId).subscribe(
            () => {
                this.groupService.header.refreshGroup();
                this.router.navigate(['/dashboard']);
            },
            console.error
        );
    }

    addUser() {
        this.groupService.addUser(this.group.groupId, this.username).subscribe(
            () => {
                this.populatePage(this.group.groupId);
            },
            (error: HttpErrorResponse) => {
                if (error.status === 409) {
                    this.messageHeader = 'Conflict';
                    this.messageBody = 'De gebruiker die u geprobeerd heeft toe te voegen is waarschijnlijk al lid van een koffie groep.';
                    this.openModal();
                    return;
                }
                if (error.status === 404) {
                    this.messageHeader = 'Niet Gevonden';
                    this.messageBody = 'De gebruiker die u geprobeerd heeft toe te voegen is niet gevonden.';
                    this.openModal();
                    return;
                }
            }
        );
    }

    openModal() {
        this.myModal.nativeElement.className = 'modal fade show';
        const div = document.createElement('div');
        div.className = 'modal-backdrop fade show';
        document.body.appendChild(div);
    }

    closeModal() {
        this.myModal.nativeElement.className = 'modal hide';
        const divList = document.body.getElementsByClassName('modal-backdrop');
        for (let i = 0; i < divList.length; i++) {
            const div = divList.item(i);
            div.remove();
        }
    }

    private populatePage(groupId: string) {
        this.edit = false;
        this.newName = '';
        this.username = '';

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
    }

    private completeObservable() {
        if (this.groupFound && this.isOwner) {
            this.edit = false;
            this.newName = this.group.groupName;
        }
    }
}

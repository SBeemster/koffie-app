import { Component, OnInit, ViewChild } from '@angular/core';
import { AvailableGroupsService } from '../../../core/services/Available-groups.service';
import { ApiService } from '../../../core/services/api.service';
import { Group } from '../../../core/classes/group';
import { ActivatedRoute } from '@angular/router';
import { GroupService } from 'src/app/core/services/group.service';

@Component({
    selector: 'app-group',
    templateUrl: './group.component.html',
    styleUrls: ['./group.component.scss']
})
export class GroupComponent implements OnInit {
    @ViewChild('myModal') myModal;

    availableGroups = [];
    messageHeader;
    message;
    newName;
    id;

    memberGroup: Group = {
        groupId: "",
        groupName: ""
    }

    groupFound = false;

    constructor(
        private activatedRoute: ActivatedRoute,
        private groupService: GroupService
    ) { }

    ngOnInit() {
        const groupId = this.activatedRoute.snapshot.params['groupId'];
        this.groupService.getGroupById(groupId).subscribe(
            response => {
                if (response) {
                    console.log(response);
                    this.memberGroup = response;
                    this.groupFound = true;
                }
            },
            console.error
        )
        // this.availableGroupsService.getGroups().subscribe(
        //     group => {
        //         this.availableGroups.push(group);
        //     },
        //     console.error
        // );
    }

    // newGroup(newName: string) {
    //     for (let i = 0; i < this.availableGroups.length; i++) {
    //         if (this.availableGroups[i].groupName === newName) {
    //             this.messageHeader = 'Groep bestaat reeds';
    //             this.message = 'Er bestaat reeds een groep met deze naam. De groep is niet aangemaakt';
    //             this.openModal();
    //             return;
    //         }
    //     }
    //     this.availableGroupsService.postGroup(newName).subscribe(
    //         res => { this.id = res.toString(); },
    //         console.error
    //     );

    //     const group: Group = {
    //         groupId: this.id,
    //         groupName: newName
    //     };
    //     this.availableGroups.push(group);
    // }


    // deleteGroup(group: Group) {

    //     for (let i = 0; i < this.availableGroups.length; i++) {
    //         if (this.availableGroups[i].groupId === group.groupId) {
    //             this.availableGroupsService.deleteGroup(group).subscribe(
    //                 null,
    //                 console.error
    //             );
    //             this.availableGroups.splice(i, 1);
    //             return;
    //         }
    //     }
    //     this.messageHeader = 'Groep niet gevonden';
    //     this.message = 'Er bestaat geen groep met deze naam. De groep is niet verwijderd. Neem contact op met uw beheerder.';
    //     this.openModal();
    // }


    // editGroup(group: Group) {
    //     if (group.newName === '' || group.newName == null) {
    //         this.messageHeader = 'Groepsnaam leeg';
    //         this.message = 'U heeft geen groepsnaam opgeven. Probeer het opnieuw.';
    //         this.openModal();
    //         group.edit = false;
    //         return;
    //     }
    //     for (let i = 0; i < this.availableGroups.length; i++) {
    //         if (this.availableGroups[i].groupName === group.newName && this.availableGroups[i] !== group) {
    //             group.newName = group.groupName;
    //             this.messageHeader = 'Groep bestaat reeds';
    //             this.message = 'Er bestaat al een groep met deze naam. De groepsnaam is niet aangepast.';
    //             this.openModal();
    //             group.edit = false;
    //             return;
    //         }
    //     }
    //     for (let i = 0; i < this.availableGroups.length; i++) {
    //         if (this.availableGroups[i] === group) {
    //             this.availableGroups[i].groupName = group.newName;
    //             this.availableGroupsService.putGroup(group).subscribe(
    //                 null,
    //                 console.error
    //             );
    //             group.edit = false;
    //             return;
    //         }
    //     }


    // }
    // openModal() {
    //     this.myModal.nativeElement.className = 'modal fade show';
    // }
    // closeModal() {
    //     this.myModal.nativeElement.className = 'modal hide';
    // }
}

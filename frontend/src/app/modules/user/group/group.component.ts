import { Component, OnInit, ViewChild } from '@angular/core';
import { AvailableGroupsService } from '../../../core/services/Available-groups.service';

import { Group } from '../../../core/classes/group';

@Component({
  selector: 'app-group',
  templateUrl: './group.component.html',
  styleUrls: ['./group.component.scss']
})
export class GroupComponent implements OnInit {
  @ViewChild('myModal') myModal;
  AvailableGroups;
  messageHeader;
  message;
  newName;
  constructor(private AvailableGroupsService: AvailableGroupsService) { }

  ngOnInit() {
    this.AvailableGroups = this.AvailableGroupsService.getGroups();
  }

  newGroup(newName: string) {
    if (!this.AvailableGroupsService.createGroup(newName)) {
      this.messageHeader = 'Groep bestaat reeds';
      this.message = 'Er bestaat reeds een groep met deze naam. De groep is niet aangemaakt';
      this.openModal();
    }
  }
  deleteGroup(group: Group) {
    if (!this.AvailableGroupsService.deleteGroup(group)) {
      this.messageHeader = 'Groep niet gevonden';
      this.message = 'Er bestaat geen groep met deze naam. De groep is niet verwijderd. Neem contact op met uw beheerder.';
      this.openModal();
    }
  }
  editGroup(group: Group) {
    if (!this.AvailableGroupsService.editGroup(group)) {
      this.messageHeader = 'Groep bestaat reeds';
      this.message = 'Er bestaat al een groep met deze naam. De groepsnaam is niet aangepast.';
      this.openModal();
    }
    group.edit = false;
  }
  openModal() {
    this.myModal.nativeElement.className = 'modal fade show';
  }
  closeModal() {
     this.myModal.nativeElement.className = 'modal hide';
  }
}

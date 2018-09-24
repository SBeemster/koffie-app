import { Injectable } from '@angular/core';
import { Group } from '../classes/group';

@Injectable({
  providedIn: 'root'
})
export class AvailableGroupsService {
  availableGroups: Group[] = [
    new Group('The addicts'),
    new Group('The most drinkers'),
    new Group('Frequently need coffee'),
    new Group('Thee pussy\'s')
  ];
  getGroups(): Array<Group> {
    return this.availableGroups;
  }
  createGroup(group: string): boolean {
    for (let i = 0; i < this.availableGroups.length; i++) {
      if (this.availableGroups[i].name === group) {
        return false;
      }
    }
    this.availableGroups.push(new Group(group));
      return true;
  }
  deleteGroup(group: Group): boolean {
    for (let i = 0; i < this.availableGroups.length; i++) {
      if (this.availableGroups[i] === group) {
        this.availableGroups.splice(i, 1);
        return true;
      }
    }
      return false;
  }
  editGroup(group: Group): boolean {
    if (group.newName === '') {
      return false;
    }
    for (let i = 0; i < this.availableGroups.length; i++) {
      if (this.availableGroups[i].name === group.newName && this.availableGroups[i] !== group) {
        group.newName = group.name;
        return false;
      }
    }
    for (let i = 0; i < this.availableGroups.length; i++) {
      if (this.availableGroups[i] === group) {
        this.availableGroups[i].name = group.newName;
        return true;
      }
    }
    return true;
  }
  constructor() { }
}

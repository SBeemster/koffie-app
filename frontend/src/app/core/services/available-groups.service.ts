import { Injectable } from '@angular/core';
import { Group } from '../classes/group';

@Injectable({
  providedIn: 'root'
})
export class AvailableGroupsService {
  AvailableGroups: Group[] = [
    new Group('The addicts'),
    new Group('The most drinkers'),
    new Group('Frequently need coffee'),
    new Group('Thee pussy\'s')
  ];
  getGroups(): Array<Group> {
    return this.AvailableGroups;
  }
  createGroup(group: string): boolean {
    for (let i = 0; i < this.AvailableGroups.length; i++) {
      if (this.AvailableGroups[i].name === group) {
        return false;
      }
    }
    this.AvailableGroups.push(new Group(group));
      return true;
  }
  deleteGroup(group: Group): boolean {
    for (let i = 0; i < this.AvailableGroups.length; i++) {
      if (this.AvailableGroups[i] === group) {
        this.AvailableGroups.splice(i, 1);
        return true;
      }
    }
      return false;
  }
  editGroup(group: Group): boolean {
    if (group.newName === '') {
      return false;
    }
    for (let i = 0; i < this.AvailableGroups.length; i++) {
      if (this.AvailableGroups[i].name === group.newName && this.AvailableGroups[i] !== group) {
        group.newName = group.name;
        return false;
      }
    }
    for (let i = 0; i < this.AvailableGroups.length; i++) {
      if (this.AvailableGroups[i] === group) {
        this.AvailableGroups[i].name = group.newName;
        return true;
      }
    }
    return true;
  }
  constructor() { }
}

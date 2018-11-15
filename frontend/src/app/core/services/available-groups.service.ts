import { Injectable } from '@angular/core';
import { Group } from '../classes/group';
import { ApiService } from "./api.service";
import { Observable } from "rxjs";
import { map, concatAll } from "rxjs/operators";

@Injectable({
  providedIn: 'root'
})
export class AvailableGroupsService {
  
  getGroups(): Observable<Group> {
    return this.api.get('/groups').pipe(
        concatAll(),
        map(obj => {
            const group: Group = {
                groupId: obj['groupId'],
                groupName: obj['groupName']
            };
            return group;
        })
    );
}
  constructor(private api: ApiService) { }
}

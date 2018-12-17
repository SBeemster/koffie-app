import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Group } from '../classes/group';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class GroupService {

    constructor(
        private api: ApiService
    ) { }

    getMemberGroup(): Observable<Group> {
        return this.api.get('/groups/member-group')
        .pipe(map(obj => {
            if (obj) {
                const group: Group = {
                    groupId: obj['groupId'],
                    groupName: obj['groupName'],
                    members: obj['members']
                }
                return group;
            } else {
                return null;
            }
        }))
    }

    getOwnedGroup(): Observable<Group> {
        return this.api.get('/groups/my-group')
        .pipe(map(obj => {
            if (obj) {
                const group: Group = {
                    groupId: obj['groupId'],
                    groupName: obj['groupName'],
                    members: obj['members']
                }
                return group;
            } else {
                return null;
            }
        }))
    }

    getGroupById(groupId): Observable<Group> {
        return this.api.get(`/groups/${groupId}`)
        .pipe(map(obj => {
            if (obj) {
                const group: Group = {
                    groupId: obj['groupId'],
                    groupName: obj['groupName'],
                    members: obj['members']
                }
                return group;
            } else {
                return null;
            }
        }))
    }
}

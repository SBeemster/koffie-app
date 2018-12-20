import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Group } from '../classes/group';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { GroupComponent } from 'src/app/shared/header/group/group.component';

@Injectable({
    providedIn: 'root'
})
export class GroupService {

    header: GroupComponent;

    constructor(
        private api: ApiService
    ) { }

    refreshHeader() {
        if (this.header) {
            this.header.refreshGroup();
        }
    }

    getMemberGroup(): Observable<Group> {
        return this.api.get('/Groups/member-group')
            .pipe(map(obj => {
                if (obj) {
                    const group: Group = {
                        groupId: obj['groupId'],
                        groupName: obj['groupName'],
                        members: obj['members']
                    };
                    return group;
                } else {
                    return null;
                }
            }));
    }

    getOwnedGroup(): Observable<Group> {
        return this.api.get('/Groups/my-group')
            .pipe(map(obj => {
                if (obj) {
                    const group: Group = {
                        groupId: obj['groupId'],
                        groupName: obj['groupName'],
                        members: obj['members']
                    };
                    return group;
                } else {
                    return null;
                }
            }));
    }

    getIsGroupOwner(groupId: string): Observable<boolean> {
        return this.api.get(`/Groups/is-owner/${groupId}`)
            .pipe(map(obj => {
                return obj['isOwner'];
            }));
    }

    getGroupById(groupId: string): Observable<Group> {
        return this.api.get(`/Groups/${groupId}`)
            .pipe(map(obj => {
                if (obj) {
                    const group: Group = {
                        groupId: obj['groupId'],
                        groupName: obj['groupName'],
                        members: obj['members']
                    };
                    return group;
                } else {
                    return null;
                }
            }));
    }

    putGroup(group: Group): Observable<Object> {
        return this.api.put(`/Groups/${group.groupId}`, {
            'groupId': group.groupId,
            'groupName': group.groupName,
            'members': group.members ? group.members : null
        });
    }

    postGroup(newName: string): Observable<Object> {
        return this.api.post('/Groups', {
            'groupName': newName
        });
    }

    deleteGroup(groupId: string): Observable<Object> {
        return this.api.delete(`/Groups/${groupId}`);
    }
}

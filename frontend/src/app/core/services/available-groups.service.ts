import { Injectable } from '@angular/core';
import { Group } from '../classes/group';
import { ApiService } from './api.service';
import { Observable } from 'rxjs';
import { map, concatAll } from 'rxjs/operators';

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
postGroup(newName): Observable<Object> {
    return this.api.post('/Groups', {
        'groupName': newName
      });
}
putGroup(group): Observable<Object> {
    return this.api.put('/Groups/' + group.groupId, {
        'groupId': group.groupId,
        'groupName':  group.groupName
      });
}
deleteGroup(group): Observable<Object> {
    return this.api.delete('/Groups/' + group.groupId);
}
  constructor(private api: ApiService) { }
}

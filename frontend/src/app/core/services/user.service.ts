import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Observable } from 'rxjs';
import { map, concatAll } from 'rxjs/operators';
import { User } from '../classes/user';
import { Role } from '../classes/role';


@Injectable({
  providedIn: 'root'
})
export class UserService {
  getAll(): Observable<User> {
    return this.api.get('/users/').pipe(
      concatAll(),
      map(obj => {
        const user: User = {
          userId: obj['userId'],
          firstName: obj['firstName'],
          lastName: obj['lastName'],
          active: obj['active']
        };
        return user;
      })
    );
  }
  getSingleUser(id): Observable<User> {
    return this.api.get('/users/' + id).pipe(
      concatAll(),
      map(obj => {
        const user: User = {
          userId: obj['userId'],
          firstName: obj['firstName'],
          lastName: obj['lastName'],
          userroles: obj['userRoles'],
          active: obj['active']
        };
        return user;
      })
    );
  }
  saveUser(userName, password, roles, firstName, lastName): Observable<Object> {
    return this.api.post('/users', {
      'UserName': userName,
      'Password': password,
      'UserRoles': roles,
      'FirstName': firstName,
      'LastName': lastName
    });
  }
  editUser(user): Observable<Object> {
    return this.api.put('/users/' + user.userId, {
      active: user['active'],
      firstName: user['firstName'],
      lastName: user['lastName'],
      userId: user['userId'],
      UserRoles: user.userroles,
    });
  }
  constructor(private api: ApiService) { }
}

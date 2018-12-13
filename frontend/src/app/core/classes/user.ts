import { UserRoles } from 'src/app/core/classes/userroles';
export class User {
    userId: string;
    firstName: string;
    lastName: string;
    active?: boolean;
    userroles?: Array<UserRoles>;
}

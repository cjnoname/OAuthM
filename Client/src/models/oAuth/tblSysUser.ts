import { Record } from 'immutable';

interface Interface {
  userId: number,
  domain: string,
  userName: string,
  firstName: string,
  lastName: string,
  mailingAddress: string,
  homeAddress: string,
  phone: string,
  emailAddress: string,
  location: string,
  isLocked: boolean,
  createdBy: number,
  createdDate: Date,
  modifiedBy?: string,
  modifiedDate?: Date
}

const initialValue = Record<Interface>({
  userId: 0,
  domain: '',
  userName: '',
  firstName: '',
  lastName: '',
  mailingAddress: '',
  homeAddress: '',
  phone: '',
  emailAddress: '',
  location: '',
  isLocked: false,
  createdBy: 0,
  createdDate: new Date(),
  modifiedBy: undefined,
  modifiedDate: undefined
});

export class TblSysUser extends initialValue { }

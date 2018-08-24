import { Record } from 'immutable';

interface Interface {
  clientResourceAccessId: number,
  resourceId: string,
  access: string
}

const initialValue = Record<Interface>({
  clientResourceAccessId: 0,
  resourceId: '',
  access: ''
});

export class ClientResourceAccess extends initialValue { }

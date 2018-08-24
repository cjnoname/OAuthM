import { Record } from 'immutable';

interface Interface {
  clientImpersonationId: number,
  clientId: string,
  impersonateClientId: string,
  scope: string
}

const initialValue = Record<Interface>({
  clientImpersonationId: 0,
  clientId: '',
  impersonateClientId: '',
  scope: ''
});

export class ClientImpersonation extends initialValue { }

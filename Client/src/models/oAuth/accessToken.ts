import { Record } from 'immutable';

interface Interface {
    token: string,
    expires: Date,
    scope: string
}

const initialValue = Record<Interface>({
    token: '',
    expires: new Date(),
    scope: ''
});

export class AccessToken extends initialValue { }

import { Record } from 'immutable';

export interface ISearchDetailsRequest {
  clientId: string,
  token: string
}

const initialValue = Record<ISearchDetailsRequest>({
  clientId: '',
  token: ''
});

export class SearchDetailsRequest extends initialValue { }

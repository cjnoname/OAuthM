import { Record } from 'immutable';
import { Client, SearchDetailsRequest } from 'models/oAuth';

interface Interface {
  isLoading: boolean,
  client?: Client,
  searchDetailsRequest?: SearchDetailsRequest
}

const initialValue = Record<Interface>({
  isLoading: false,
  client: undefined,
  searchDetailsRequest: undefined
});

export class ViewDetailsState extends initialValue { }

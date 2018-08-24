import { Record } from 'immutable';

interface Interface {
  place: string,
  promoter: string,
  canSell: boolean,
  canReport: boolean
}

const initialValue = Record<Interface>({
  place: '',
  promoter: '',
  canSell: false,
  canReport: false
});

export class OriginPromoter extends initialValue { }

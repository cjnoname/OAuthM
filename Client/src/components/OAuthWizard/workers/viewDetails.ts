import { AppThunkAction } from 'store';
import { KnownAction, ActionTypes, GetOAuthSucceeded } from '../actions';
import * as Api from '../apis';
import { Client, ISearchDetailsRequest } from 'models/oAuth';
import { ViewDetailsState } from 'models/reducers';

export const getOAuthAction = (request: ISearchDetailsRequest): AppThunkAction<KnownAction> => async (dispatch, getState) => {
  try {
    dispatch({ type: ActionTypes.GET_OAUTH_STARTED });
    const client = await Api.getOAuth<Client>(request);
    dispatch({ type: ActionTypes.GET_OAUTH_SUCCEEDED, client });
  } catch (e) {
    dispatch({ type: ActionTypes.GET_OAUTH_FAILED });
  }
};

export const getOAuthStarted = (state: ViewDetailsState) => state.set('isLoading', true);

export const getOAuthSucceeded = (state: ViewDetailsState, action: GetOAuthSucceeded) => {
  return state
    .set('client', action.client ? new Client(action.client) : new Client())
    .set('isLoading', false);
};

export const getOAuthFailed = (state: ViewDetailsState) => state.set('isLoading', false);

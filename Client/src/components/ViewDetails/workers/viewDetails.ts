import { AppThunkAction } from 'store';
import { AnyAction } from 'redux';
import { stringify } from 'query-string';
import { push } from 'react-router-redux';
import { KnownAction, ActionTypes, GetOAuthSucceeded } from '../actions';
import { IException, isNoContent } from 'utils/error';
import * as Api from '../apis';
import { Client, ISearchDetailsRequest, SearchDetailsRequest } from 'models/oAuth';
import { ViewDetailsState } from 'models/reducers';

export const getOAuthAction = (request: ISearchDetailsRequest): AppThunkAction<AnyAction> => async (dispatch, getState) => {
  try {
    dispatch({ type: ActionTypes.GET_OAUTH_STARTED });
    const client = await Api.getOAuth<Client>(request);
    dispatch(push(`/viewDetails?${stringify(request)}`));
    dispatch({ type: ActionTypes.GET_OAUTH_SUCCEEDED, client, request });
  } catch (e) {
    dispatch({ type: ActionTypes.GET_OAUTH_FAILED });
  }
};

export const getOAuthStarted = (state: ViewDetailsState) => state.set('isLoading', true);

export const getOAuthSucceeded = (state: ViewDetailsState, action: GetOAuthSucceeded) =>
  state
    .set('client', action.client ? new Client(action.client) : undefined)
    .set('searchDetailsRequest', action.request ? new SearchDetailsRequest(action.request) : undefined)
    .set('isLoading', false);

export const getOAuthFailed = (state: ViewDetailsState) => state.set('isLoading', false);

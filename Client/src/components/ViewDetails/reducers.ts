import { Action, Reducer, ActionCreator } from 'redux';
import { KnownAction, ActionTypes } from './actions';
import { getOAuthStarted, getOAuthSucceeded, getOAuthFailed } from './workers/viewDetails';
import { ViewDetailsState } from 'models/reducers';

export const OAuthViewReducer: Reducer<ViewDetailsState> = (state: ViewDetailsState | undefined, action: KnownAction) => {
  switch (action.type) {
    case ActionTypes.GET_OAUTH_STARTED: { return getOAuthStarted(state!); }
    case ActionTypes.GET_OAUTH_SUCCEEDED: { return getOAuthSucceeded(state!, action); }
    case ActionTypes.GET_OAUTH_FAILED: { return getOAuthFailed(state!); }
  }
  return state || new ViewDetailsState();
};

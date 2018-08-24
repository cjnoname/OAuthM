import { Reducer } from 'redux';
import { KnownAction, ActionTypes } from './actions';
import { OAuthState } from 'models/reducers';
import { saveOAuthStarted, saveOAuthSucceeded, saveOAuthFailed } from './workers/saveOAuth';

export const OAuthReducer: Reducer<OAuthState> = (state: OAuthState | undefined, action: KnownAction) => {
  switch (action.type) {
    case ActionTypes.SAVE_OAUTH_STARTED: { return saveOAuthStarted(state!, action); }
    case ActionTypes.SAVE_OAUTH_SUCCEEDED: { return saveOAuthSucceeded(state!); }
    case ActionTypes.SAVE_OAUTH_FAILED: { return saveOAuthFailed(state!); }
  }
  return state || new OAuthState();
};

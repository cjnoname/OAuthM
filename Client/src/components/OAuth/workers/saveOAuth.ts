import { AppThunkAction } from 'store';
import * as Api from '../apis';
import { OAuthRequest } from 'models/oAuth';
import { OAuthState } from 'models/reducers';
import { KnownAction, ActionTypes, SaveOAuthStarted } from '../actions';
import { IException, isBadRequest } from 'utils/error';

export const saveOAuth = (data: OAuthRequest): AppThunkAction<KnownAction> => async dispatch => {
  try {
    const response = await Api.saveOAuth(data);
    dispatch({ type: ActionTypes.SAVE_OAUTH_STARTED, data });
  } catch (e) {
    dispatch({ type: ActionTypes.SAVE_OAUTH_FAILED });
  }
};

export const saveOAuthStarted = (state: OAuthState, action: SaveOAuthStarted) => {
  return state;
};

export const saveOAuthSucceeded = (state: OAuthState) => state;

export const saveOAuthFailed = (state: OAuthState) => state;

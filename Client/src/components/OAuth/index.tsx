import * as React from 'react';
import { Link, RouteComponentProps } from 'react-router-dom';
import { connect } from 'react-redux';
import { Field, reduxForm } from 'redux-form';
import { ApplicationState } from 'store';
import { OAuthRequest } from 'models/oAuth';
import { OAuthState } from 'models/reducers';
import { actionCreators } from './actions';
import OAuthForm from './views/OAuthForm';

// At runtime, Redux will merge together...
type OAuthProps =
  OAuthState        // ... state we've requested from the Redux store
  & typeof actionCreators      // ... plus action creators we've requested
  & RouteComponentProps<{}>; // ... plus incoming routing parameters

class OAuth extends React.Component<OAuthProps, {}> {
  public render() {
    return (
      <OAuthForm onSubmit={this.submit} />
    );
  }

  private submit = (values: OAuthRequest) => {
    this.props.saveOAuth(values);
  }
}

export default connect(
  (state: ApplicationState) => state.oAuth.toObject(), // Selects which state properties are merged into the component's props
  actionCreators                 // Selects which action creators are merged into the component's props
)(OAuth as any) as any;

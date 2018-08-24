import * as React from 'react';
import { connect } from 'react-redux';
import { ApplicationState } from 'store';
import { MuiThemeProvider, createMuiTheme } from '@material-ui/core/styles';
import { getTheme } from 'shared/theme';

const Component = React.PureComponent;

function withRoot(Component: any) {
  function WithRoot(props: any) {
    return (
      <MuiThemeProvider theme={getTheme(props.theme)}>
        <Component {...props} />
      </MuiThemeProvider>
    );
  }
  return WithRoot;
}

export { withRoot };

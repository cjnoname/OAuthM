import * as React from 'react';
import { MuiThemeProvider, createMuiTheme } from 'material-ui/styles';
import { theme } from '../shared/theme';

// A theme with custom primary and secondary color.
// It's optional.
const Component = React.Component;
const muiTheme = createMuiTheme(theme);

function withRoot(Component: any) {
  function WithRoot(props: any) {
    return (
      <MuiThemeProvider theme={muiTheme}>
        <Component {...props} />
      </MuiThemeProvider>
    );
  }

  return WithRoot;
}

export { withRoot };

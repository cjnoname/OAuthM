import purple from 'material-ui/colors/purple';
import green from 'material-ui/colors/green';
import { ThemeOptions } from 'material-ui/styles/createMuiTheme';

export const theme: ThemeOptions = {
  palette: {
    primary: {
      light: purple[300],
      main: purple[500],
      dark: purple[700],
    },
    secondary: {
      light: green[300],
      main: green[500],
      dark: green[700],
    },
  },
};

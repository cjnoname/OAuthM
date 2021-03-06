import { blue, green, purple, yellow } from '@material-ui/core/colors';
import { createMuiTheme } from '@material-ui/core/styles';
import { Theme } from '@material-ui/core/styles/createMuiTheme';

export const theme1: Theme = createMuiTheme({
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
});

export const theme2: Theme = createMuiTheme({
  palette: {
    primary: {
      light: yellow[300],
      main: yellow[500],
      dark: yellow[700],
    },
    secondary: {
      light: blue[300],
      main: blue[500],
      dark: blue[700],
    },
  },
});

export const getTheme = ((theme: string) => {
  switch (theme) {
    case 'main':
      return theme1;
    case 'sub':
      return theme2;
    default:
      return theme1;
  }
});

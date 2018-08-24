import * as React from 'react';
import { NavLink } from 'react-router-dom';
import { Route } from 'react-router-dom';
import Typography from '@material-ui/core/Typography';
import List from '@material-ui/core/List';
import ListItem from '@material-ui/core/ListItem';
import ListItemIcon from '@material-ui/core/ListItemIcon';
import ListItemText from '@material-ui/core/ListItemText';
import InboxIcon from '@material-ui/icons/MoveToInbox';
import StarIcon from '@material-ui/icons/Star';
import LockIcon from '@material-ui/icons/Lock';
import CloudIcon from '@material-ui/icons/Cloud';

export const titles = (
  <>
    <Route
      path="/home"
      render={props => <Typography variant="title" color="inherit" noWrap>Home</Typography>}
    />
    <Route
      path="/viewDetails"
      render={props => <Typography variant="title" color="inherit" noWrap>View Details</Typography>}
    />
    <Route
      path="/oauthWizard"
      render={props => <Typography variant="title" color="inherit" noWrap>OAuth Wizard</Typography>}
    />
  </>
);

interface Props {
  handleDrawerClose: () => void
}

export const Menus = (props: Props) => {
  const { handleDrawerClose } = props;
  return (
    <List>
      <ListItem onClick={props.handleDrawerClose} component={(props: any) => <NavLink to="/home" {...props} />} button>
        <ListItemIcon>
          <InboxIcon />
        </ListItemIcon>
        <ListItemText primary="Home" />
      </ListItem>
      <ListItem onClick={props.handleDrawerClose} component={(props: any) => <NavLink to="/viewDetails" {...props} />} button>
        <ListItemIcon>
          <StarIcon />
        </ListItemIcon>
        <ListItemText primary="OAuth Lookup" />
      </ListItem>
      {/* <ListItem onClick={props.handleDrawerClose} component={(props: any) => <NavLink to="/oauthWizard" {...props} />} button>
        <ListItemIcon>
          <LockIcon />
        </ListItemIcon>
        <ListItemText primary="OAuthWizard" />
      </ListItem> */}
    </List>
  );
};

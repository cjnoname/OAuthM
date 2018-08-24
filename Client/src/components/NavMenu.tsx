import * as React from 'react';
import { NavLink } from 'react-router-dom';
import { Route } from 'react-router-dom';
import Typography from 'material-ui/Typography';
import List, { ListItem, ListItemIcon, ListItemText } from 'material-ui/List';
import InboxIcon from 'material-ui-icons/MoveToInbox';
import StarIcon from 'material-ui-icons/Star';

export const titles = (
  <div>
    <Route path="/home"
      render={props => <Typography variant="title" color="inherit" noWrap>Home</Typography>}
    />
    <Route path="/viewDetails"
      render={props => <Typography variant="title" color="inherit" noWrap>View Details</Typography>}
    />
  </div>
)

interface Props {
  handleDrawerClose: () => void
}

export const Menus = (props: Props) => {
  const { handleDrawerClose } = props;
  return (
    <List>
      <ListItem onClick={props.handleDrawerClose} component={props => <NavLink to="/home" {...props} />} button>
        <ListItemIcon>
          <InboxIcon />
        </ListItemIcon>
        <ListItemText primary="Home" />
      </ListItem>
      <ListItem onClick={props.handleDrawerClose} component={props => <NavLink to="/viewDetails" {...props} />} button>
        <ListItemIcon>
          <StarIcon />
        </ListItemIcon>
        <ListItemText primary="OAuth" />
      </ListItem>
    </List>
  );
}

import * as React from 'react';
import { withStyles, WithStyles } from 'material-ui/styles';
import AppBar from 'material-ui/AppBar';
import Toolbar from 'material-ui/Toolbar';
import Drawer from 'material-ui/Drawer';
import IconButton from 'material-ui/IconButton';
import Hidden from 'material-ui/Hidden';
import Divider from 'material-ui/Divider';
import MenuIcon from 'material-ui-icons/Menu';
import { titles, Menus } from './NavMenu';
import { withRoot } from '../utils/withRoot';

const drawerWidth = 240;
const decorate = withStyles(({ breakpoints, mixins, palette, spacing }) => ({
  root: {
    flexGrow: 1,
    height: '100%',
    zIndex: 1,
    overflow: 'hidden' as 'hidden',
    position: 'relative' as 'relative',
    display: 'flex',
    width: '100%'
  },
  appBar: {
    position: 'absolute' as 'absolute',
    marginLeft: drawerWidth,
    [breakpoints.up('md')]: {
      width: `calc(100% - ${drawerWidth}px)`,
    },
  },
  navIconHide: {
    [breakpoints.up('md')]: {
      display: 'none',
    },
  },
  toolbar: mixins.toolbar,
  drawerPaper: {
    width: drawerWidth,
    [breakpoints.up('md')]: {
      position: 'relative',
    },
  },
  content: {
    flexGrow: 1,
    backgroundColor: palette.background.default,
    padding: spacing.unit * 3,
  }
}));

const MyLayout = decorate(
  class extends React.Component<WithStyles<'root' | 'appBar' | 'navIconHide' | 'toolbar' | 'drawerPaper' | 'content'>, {}> {
    state = {
      mobileOpen: false,
    };

    handleDrawerToggle = () => {
      this.setState({ mobileOpen: !this.state.mobileOpen });
    };

    handleDrawerClose = (e: Event) => {
      if (this.state.mobileOpen) {
        this.setState({ mobileOpen: false });
      }
    }

    public render() {
      const { classes } = this.props;

      const drawer = (
        <div>
          <div className={classes.toolbar} />
          <Divider />
          <Menus handleDrawerClose={this.handleDrawerClose.bind(this)} />
        </div>
      );

      return (
        <div className={classes.root}>
          <AppBar className={classes.appBar}>
            <Toolbar>
              <IconButton
                color="inherit"
                aria-label="open drawer"
                onClick={this.handleDrawerToggle}
                className={classes.navIconHide}
              >
                <MenuIcon />
              </IconButton>
              {titles}
            </Toolbar>
          </AppBar>
          <Hidden mdUp>
            <Drawer
              variant="temporary"
              anchor="left"
              open={this.state.mobileOpen}
              onClose={this.handleDrawerToggle}
              classes={{
                paper: classes.drawerPaper,
              }}
              ModalProps={{
                keepMounted: true, // Better open performance on mobile.
              }}
            >
              {drawer}
            </Drawer>
          </Hidden>
          <Hidden smDown implementation="css">
            <Drawer
              variant="permanent"
              open
              classes={{
                paper: classes.drawerPaper,
              }}
            >
              {drawer}
            </Drawer>
          </Hidden>
          <div className={classes.content}>
            <div className={classes.toolbar} />
            {this.props.children}
          </div>
        </div>
      );
    }
  }
);

export const Layout = withRoot(MyLayout);

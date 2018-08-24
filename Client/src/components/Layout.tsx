import * as React from 'react';
import { titles, Menus } from './NavMenu';
import { withRoot } from 'shared/HOC/withRoot';
import { withStyles, WithStyles } from '@material-ui/core/styles';
import AppBar from '@material-ui/core/AppBar';
import Toolbar from '@material-ui/core/Toolbar';
import Drawer from '@material-ui/core/Drawer';
import IconButton from '@material-ui/core/IconButton';
import Hidden from '@material-ui/core/Hidden';
import Divider from '@material-ui/core/Divider';
import MenuIcon from '@material-ui/icons/Menu';

const drawerWidth = 240;
const decorate = withStyles(({ breakpoints, mixins, palette, spacing }) => ({
  root: {
    flexGrow: 1,
    height: '100%',
    zIndex: 1,
    overflow: 'hidden' as 'hidden',
    position: 'relative' as 'relative',
    display: 'flex' as 'flex',
    width: '100%',
    minHeight: '100vh'
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
      display: 'none' as 'none',
    },
  },
  toolbar: mixins.toolbar,
  drawerPaper: {
    width: drawerWidth,
    height: '100%',
    [breakpoints.up('md')]: {
      position: 'relative' as 'relative',
    },
  },
  drawerDocked: {
    height: '100%'
  },
  content: {
    flexGrow: 1,
    padding: spacing.unit * 3,
  }
}));

const MyLayout = decorate(
  class extends React.Component<WithStyles<'root' | 'appBar' | 'navIconHide' | 'toolbar' | 'drawerPaper' | 'content' | 'drawerDocked'>, {}> {
    public state = {
      mobileOpen: false,
    };

    public render() {
      const { classes } = this.props;

      const drawer = (
        <>
          <div className={classes.toolbar} />
          <Divider />
          <Menus handleDrawerClose={this.handleDrawerClose.bind(this)} />
        </>
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
                docked: classes.drawerDocked,
                paper: classes.drawerPaper
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

    private handleDrawerToggle = () => {
      this.setState({ mobileOpen: !this.state.mobileOpen });
    }

    private handleDrawerClose = (e: Event) => {
      if (this.state.mobileOpen) {
        this.setState({ mobileOpen: false });
      }
    }
  }
);

export const Layout = withRoot(MyLayout);

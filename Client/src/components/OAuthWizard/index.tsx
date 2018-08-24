import * as React from 'react';
import { Link, RouteComponentProps } from 'react-router-dom';
import { withStyles, WithStyles } from '@material-ui/core/styles';
import { connect } from 'react-redux';
import { SubmissionError } from 'redux-form';
import { ApplicationState } from 'store';
import ViewDetailsSearchBar from './views/viewDetailsSearchBar';
import ClientDetails from './views/clientDetails';
import { ISearchDetailsRequest } from 'models/oAuth';
import { ViewDetailsState } from 'models/reducers';
import { actionCreators } from './actions';
import Spinner from 'UI/Spinner';
import SimpleTable from 'UI/Table/simpleTable';
import { Tabs, Tab, Typography } from 'UI/Tabs';

function TabContainer(props: any) {
  return (
    <Typography component="div">
      {props.children}
    </Typography>
  );
}

const decorate = withStyles(({ }) => ({
  parent: {
    position: 'relative' as 'relative',
    height: '100%',
    width: '100%'
  }
}));

type Props =
  ApplicationState
  & typeof actionCreators
  & RouteComponentProps<{}>;

const ViewDetails = decorate(
  class extends React.Component<Props & WithStyles<'parent'>, {}> {
    public state = {
      value: 1
    };

    public render() {
      const { classes, viewDetails: { client, isLoading } } = this.props;
      const { value } = this.state;
      return (
        <div className={classes.parent}>
          <Spinner loading={isLoading} />
          <ViewDetailsSearchBar onSubmit={this.submit} />
        </div>
      );
    }

    private handleChange = (event: any, value: number) => {
      this.setState({ value });
    }

    private submit = (values: ISearchDetailsRequest) => {
      if (!(values.clientId || values.token)) {
        throw new SubmissionError({ _error: 'You should type in at least one search condition' });
      }
      this.props.getOAuthAction(values);
    }
  }
);

export default connect(
  (state: ApplicationState) => state,
  actionCreators
)(ViewDetails as any) as any;

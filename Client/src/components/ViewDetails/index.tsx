import * as React from 'react';
import { Link, RouteComponentProps } from 'react-router-dom';
import { withStyles, WithStyles } from 'material-ui/styles';
import { connect } from 'react-redux';
import { SubmissionError } from 'redux-form';
import { ApplicationState } from '../../store';
import { Tabs, Tab, Typography } from '../../shared/UI/Tabs';
import ViewDetailsSearchBar from './views/viewDetailsSearchBar';
import ClientDetails from './views/clientDetails';
import ClientResourceAccessDetails from './views/clientResourceAccessDetails';
import ClientAccessParameterDetails from './views/clientAccessParameterDetails';
import ClientImpersonationDetails from './views/clientImpersonationDetails';
import { ViewDetailsState, ISearchDetailsRequest } from './models';
import { actionCreators } from './actions';
import Spinner from '../../shared/UI/Spinner';

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
    state = {
      value: 1
    }

    handleChange = (event: any, value: number) => {
      this.setState({ value });
    };

    submit = (values: ISearchDetailsRequest) => {
      if (!(values.clientId || values.token)) {
        throw new SubmissionError({ _error: 'You should type in at least one search condition' })
      }
      this.props.getOAuthAction(values);
    }

    public render() {
      const { classes, viewDetails: { client, isLoading } } = this.props;
      const { value } = this.state;
      return <div className={classes.parent}>
        <Spinner loading={isLoading} />
        <ViewDetailsSearchBar onSubmit={this.submit} />
        {client &&
          <div>
            <Tabs value={value} onChange={this.handleChange}>
              <Tab label="Client" />
              <Tab label="Resource Access" />
              <Tab label="Access Parameter" />
              <Tab label="Client Impersonation" />
            </Tabs>
            {value === 0 && <ClientDetails client={client} />}
            {value === 1 && <TabContainer>                            {client.clientResourceAccess &&
              <ClientResourceAccessDetails clientResourceAccess={client.clientResourceAccess!} />
            }</TabContainer>}
            {value === 2 && <TabContainer>{client.clientAccessParameter &&
              <ClientAccessParameterDetails clientAccessParameter={client.clientAccessParameter!} />
            }</TabContainer>}
            {value === 3 && <TabContainer>                            {client.clientAccessParameter &&
              <ClientImpersonationDetails clientImpersonationClient={client.clientImpersonationClient!} />
            }</TabContainer>}
          </div>
        }
      </div>;
    }
  }
);

export default connect(
  (state: ApplicationState) => state,
  actionCreators
)(ViewDetails as any) as any;

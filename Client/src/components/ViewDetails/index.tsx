import * as React from 'react';
import { Link, RouteComponentProps } from 'react-router-dom';
import { parse } from 'query-string';
import { withStyles, WithStyles } from '@material-ui/core/styles';
import { connect } from 'react-redux';
import { SubmissionError } from 'redux-form';
import { ApplicationState } from 'store';
import SearchBar from './views/searchBar';
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
      value: 0
    };

    public componentDidMount() {
      const request = parse(location.search) as ISearchDetailsRequest;
      if (request && (request.clientId || request.token)) {
        this.props.getOAuthAction(request);
      }
    }

    public render() {
      const { classes, viewDetails: { client, isLoading } } = this.props;
      const { value } = this.state;
      return (
        <div className={classes.parent}>
          <Spinner loading={isLoading} />
          <SearchBar onSubmit={this.submit} />
          {client &&
            <>
              <Tabs value={value} onChange={this.handleChange}>
                <Tab label="Client" />
                <Tab label="Origin Promoter" />
                <Tab label="Tbl Sys Users" />
                <Tab label="Resource Access" />
                <Tab label="Access Parameter" />
                <Tab label="Impersonations 1" />
                <Tab label="Impersonations 2" />
              </Tabs>
              {value === 0 && <TabContainer>
                <ClientDetails client={client} />
              </TabContainer>}
              {value === 1 && <TabContainer>
                <SimpleTable name="originPromoters" headers={['Place', 'Promoter', 'Can Sell', 'Can Report']} list={client.originPromoters} />
              </TabContainer>}
              {value === 2 && <TabContainer>
                <SimpleTable name="tblSysUsers" headers={['User ID', 'Domain']} list={client.tblSysUsers} />
              </TabContainer>}
              {value === 3 && <TabContainer>
                <SimpleTable name="clientResourceAccess" headers={['Resource ID', 'Access']} list={client.clientResourceAccesses} />
              </TabContainer>}
              {value === 4 && <TabContainer>
                <SimpleTable name="clientAccessParameter" headers={['Resource ID', 'Key', 'Value']} list={client.clientAccessParameters} />
              </TabContainer>}
              {value === 5 && <TabContainer>
                <SimpleTable name="clientImpersonations1" headers={['Impersonate ClientId', 'Scope']} list={client.clientImpersonations1} />
              </TabContainer>}
              {value === 6 && <TabContainer>
                <SimpleTable name="clientImpersonations2" headers={['Impersonate ClientId', 'Scope']} list={client.clientImpersonations2} />
              </TabContainer>}
            </>
          }
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

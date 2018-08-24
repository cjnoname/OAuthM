import * as React from 'react';
import { Route } from 'react-router-dom';
import { hot } from 'react-hot-loader';
import { Layout } from './components/Layout';
import Home from './components/Home';
import OAuth from './components/OAuth';
import ViewDetails from './components/ViewDetails';
import OAuthWizard from './components/OAuthWizard';

const Routes = () => (
  <Layout>
    <Route exact path="(/|/home)" component={Home} />
    <Route path="/viewDetails" component={ViewDetails} />
    <Route path="/oauth" component={OAuth} />
    <Route path="/oauthWizard" component={OAuthWizard} />
  </Layout>
);

export default hot(module)(Routes);

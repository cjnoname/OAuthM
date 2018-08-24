import * as React from 'react';
import { reduxForm } from 'redux-form';
import { connect } from 'react-redux';
import { reset } from 'redux-form';
import TextField from 'UI/Form/TextField';
import { Button } from 'UI/Button';
import { ApplicationState } from 'store';

interface Props {
  dispatch: any,
  handleSubmit: any,
  error: any
}

let SearchBar = (props: Props) => {
  const resetForm = () => {
    props.dispatch(reset('oAuthSearchBar'));
  };

  const { handleSubmit, error } = props;
  return (
    <>
      <form onSubmit={handleSubmit}>
        <TextField name="clientId" onChange={resetForm} label="Client ID" required={false} />
        <TextField name="token" onChange={resetForm} label="Token" required={false} />
        <Button label="SEARCH" type="submit" />
        <div>
          {error && <strong>{error}</strong>}
        </div>
      </form>
    </>
  );
};

SearchBar = reduxForm({
  form: 'oAuthSearchBar',
  enableReinitialize: true
})(SearchBar as any) as any;

export default connect(
  (state: ApplicationState) => ({
    initialValues: state.viewDetails.searchDetailsRequest
  })
)(SearchBar as any) as any;

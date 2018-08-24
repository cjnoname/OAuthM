import * as React from 'react';
import { reduxForm, SubmissionError } from 'redux-form';
import { reset } from 'redux-form';
import TextField from 'UI/Form/TextField';
import { Button } from 'UI/Button';

interface Props {
  dispatch: any,
  handleSubmit: any,
  error: any
}

const ViewDetailsSearchBar = (props: Props) => {
  const resetForm = () => {
    props.dispatch(reset('oAuthSearchBar'));
  };

  const { handleSubmit, error } = props;
  return (
    <>
      <form onSubmit={handleSubmit}>
        <TextField name="clientId" onChange={resetForm} label="Client ID" required={false} />
        <Button label="SEARCH" type="submit" />
        <div>
          {error && <strong>{error}</strong>}
        </div>
      </form>
    </>
  );
};

export default reduxForm({
  form: 'oAuthSearchBar',
})(ViewDetailsSearchBar as any) as any;

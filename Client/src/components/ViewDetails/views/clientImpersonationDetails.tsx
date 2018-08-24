import * as React from 'react';
import { List } from 'immutable';
import { ClientImpersonationClient } from '../models';
import {
  Table,
  TableHead,
  TableBody,
  TableRow,
  TableCell
} from '../../../shared/UI/Table';

interface Props {
  clientImpersonationClient: List<ClientImpersonationClient>
}

const ClientImpersonationDetails = (props: Props) => {
  const clientImpersonationClient = props.clientImpersonationClient;
  return (
    <Table>
      <TableHead>
        <TableRow>
          <TableCell>Impersonate ClientId</TableCell>
          <TableCell>Scope</TableCell>
        </TableRow>
      </TableHead>
      <TableBody>
        {clientImpersonationClient.map(val => {
          const { impersonateClientId, scope } = val;
          return (
            <TableRow key={`clientImpersonationClient${clientImpersonationClient.indexOf(val)}`}>
              <TableCell>{impersonateClientId}</TableCell>
              <TableCell>{scope}</TableCell>
            </TableRow>
          );
        })}
      </TableBody>
    </Table>
  );
}

export default ClientImpersonationDetails;
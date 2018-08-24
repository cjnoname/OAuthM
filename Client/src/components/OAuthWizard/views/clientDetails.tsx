import * as React from 'react';
import { List } from 'immutable';
import {
  Table,
  TableHead,
  TableBody,
  TableRow,
  TableCell
} from 'UI/Table';
import { Client } from 'models/oAuth';

interface Props {
  client: Client
}

const ClientDetails = (props: Props) => {
  const { client } = props;
  return (
    <Table>
      <TableHead>
        <TableRow>
          <TableCell>Client ID</TableCell>
          <TableCell>Secret</TableCell>
          <TableCell>Salt</TableCell>
          <TableCell>Name</TableCell>
        </TableRow>
      </TableHead>
      <TableBody>
        <TableRow>
          <TableCell>{client.clientId}</TableCell>
          <TableCell>{client.secret}</TableCell>
          <TableCell>{client.salt}</TableCell>
          <TableCell>{client.name}</TableCell>
        </TableRow>
      </TableBody>
    </Table>
  );
};

export default ClientDetails;

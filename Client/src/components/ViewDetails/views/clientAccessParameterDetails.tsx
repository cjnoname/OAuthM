import * as React from 'react';
import { List } from 'immutable';
import { ClientAccessParameter } from '../models';
import {
  Table,
  TableHead,
  TableBody,
  TableRow,
  TableCell
} from '../../../shared/UI/Table';

interface Props {
  clientAccessParameter: List<ClientAccessParameter>
}

const ClientAccessParameterDetails = (props: Props) => {
  const { clientAccessParameter } = props;
  return (
    <Table>
      <TableHead>
        <TableRow>
          <TableCell>Resource ID</TableCell>
          <TableCell>Key</TableCell>
          <TableCell>Value</TableCell>
        </TableRow>
      </TableHead>
      <TableBody>
        {clientAccessParameter.map(val => {
          const { resourceId, key, value } = val;
          return (
            <TableRow key={`clientAccessParameter${clientAccessParameter.indexOf(val)}`}>
              <TableCell>{resourceId}</TableCell>
              <TableCell>{key}</TableCell>
              <TableCell>{value}</TableCell>
            </TableRow>
          );
        })}
      </TableBody>
    </Table>
  );
}

export default ClientAccessParameterDetails;
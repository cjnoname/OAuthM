import * as React from 'react';
import { List } from 'immutable';
import { ClientResourceAccess } from '../models';
import {
  Table,
  TableHead,
  TableBody,
  TableRow,
  TableCell
} from '../../../shared/UI/Table';

interface Props {
  clientResourceAccess: List<ClientResourceAccess>
}

const ClientResourceAccessDetails = (props: Props) => {
  const clientResourceAccesses = props.clientResourceAccess;
  return (
    <Table>
      <TableHead>
        <TableRow>
          <TableCell>Resource ID</TableCell>
          <TableCell>Access</TableCell>
        </TableRow>
      </TableHead>
      <TableBody>
        {clientResourceAccesses.map(val => {
          const { access, resourceId } = val;
          return (
            <TableRow key={`clientResourceAccesses${clientResourceAccesses.indexOf(val)}`}>
              <TableCell>{resourceId}</TableCell>
              <TableCell>{access}</TableCell>
            </TableRow>
          );
        })}
      </TableBody>
    </Table>
  );
}

export default ClientResourceAccessDetails;
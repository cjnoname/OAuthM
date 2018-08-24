import * as React from 'react';
import { List, Record } from 'immutable';
import {
  Table,
  TableHead,
  TableBody,
  TableRow,
  TableCell,
  TableFooter,
  TablePagination
} from './index';

interface Props<T> {
  name: string,
  headers: string[],
  list: List<Record<T>>
}

class SimpleTable<T> extends React.Component<Props<T>, {}> {
  public state = {
    page: 0,
    rowsPerPage: 10
  };

  public render() {
    const { name, headers, list } = this.props;
    const { page, rowsPerPage } = this.state;
    return (
      list && list.count() > 0 ?
        (
          <Table>
            <TableHead>
              <TableRow>
                {headers.map(header => <TableCell key={`${header}`}>{header}</TableCell>)}
              </TableRow>
            </TableHead>
            <TableBody>
              {list.slice(page * rowsPerPage, page * rowsPerPage + rowsPerPage).map((item, key) => {
                const values = item.toSeq().valueSeq();
                return (
                  <TableRow key={`${name}${key}`}>
                    {values.map((value: any, valueKey: number) => {
                      return (<TableCell key={`${name}${list.indexOf(item)}${valueKey}`}>{GetStringFromValue(value)}</TableCell>);
                    })}
                  </TableRow>
                );
              })}
            </TableBody>
            <TableFooter>
              <TableRow>
                <TablePagination
                  colSpan={3}
                  count={list.count()}
                  rowsPerPage={rowsPerPage}
                  page={page}
                  onChangePage={this.handleChangePage}
                  onChangeRowsPerPage={this.handleChangeRowsPerPage}
                />
              </TableRow>
            </TableFooter>
          </Table>
        )
        :
        (
          <>
            No Record
        </>
        )
    );
  }

  private handleChangePage = (event: any, page: number) => {
    this.setState({ page });
  }

  private handleChangeRowsPerPage = (event: any) => {
    this.setState({ rowsPerPage: event.target.value });
  }
}

const GetStringFromValue = (value: any): string => {
  if (typeof value === 'boolean') {
    return value.toString();
  }
  return value;
};

export default SimpleTable;

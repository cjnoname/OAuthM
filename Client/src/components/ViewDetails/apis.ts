import server from 'utils/server';

export const getOAuth = <T>(data: any) => server.get<T>('ViewDetails/GetDetails', data);

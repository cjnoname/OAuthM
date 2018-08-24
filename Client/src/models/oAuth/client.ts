import { Record, List } from 'immutable';
import { toImmutable } from 'utils/immutable';
import { ClientResourceAccess } from './clientResourceAccess';
import { ClientAccessParameter } from './clientAccessParameter';
import { ClientImpersonation } from './clientImpersonationClient';
import { TblSysUser } from './tblSysUser';
import { OriginPromoter } from './originPromoter';

interface Interface {
  clientId: string,
  secret: string,
  salt: string,
  name: string,
  clientResourceAccesses: List<ClientResourceAccess>,
  clientAccessParameters: List<ClientAccessParameter>,
  clientImpersonations1: List<ClientImpersonation>,
  clientImpersonations2: List<ClientImpersonation>,
  tblSysUsers: List<TblSysUser>,
  originPromoters: List<OriginPromoter>
}

const initialValue = Record<Interface>({
  clientId: '',
  secret: '',
  salt: '',
  name: '',
  clientResourceAccesses: List<ClientResourceAccess>(),
  clientAccessParameters: List<ClientAccessParameter>(),
  clientImpersonations1: List<ClientImpersonation>(),
  clientImpersonations2: List<ClientImpersonation>(),
  tblSysUsers: List<TblSysUser>(),
  originPromoters: List<OriginPromoter>()
});

export class Client extends initialValue {
  constructor(args: any = {}) {
    super({
      ...args,
      clientResourceAccesses: toImmutable(args.clientResourceAccesses, ClientResourceAccess, true),
      clientAccessParameters: toImmutable(args.clientAccessParameters, ClientAccessParameter, true),
      clientImpersonations1: toImmutable(args.clientImpersonations1, ClientImpersonation, true),
      clientImpersonations2: toImmutable(args.clientImpersonations2, ClientImpersonation, true),
      tblSysUsers: toImmutable(args.tblSysUsers, TblSysUser, true),
      originPromoters: toImmutable(args.originPromoters, OriginPromoter, true)
    });
  }
}

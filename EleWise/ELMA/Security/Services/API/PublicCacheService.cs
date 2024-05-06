// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.API.PublicCacheService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.API;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Services.API
{
  [Service(Type = ComponentType.Server)]
  internal class PublicCacheService : IPublicCacheService
  {
    private readonly IPublicClientService clientService;
    private readonly PublicClientCacheTokenManager cacheTokenManager;
    private readonly PublicClientSessionManager clientSessionManager;
    private static readonly ConcurrentDictionary<string, Guid> TokenCache;
    private static PublicCacheService oSrPkXVy3wtenOX8aYG;

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:System.Object" />.
    /// </summary>
    public PublicCacheService(
      IPublicClientService clientService,
      PublicClientCacheTokenManager cacheTokenManager,
      PublicClientSessionManager clientSessionManager)
    {
      PublicCacheService.O1wr9hVfxJx2Ioxsnft();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.clientService = clientService;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 == 0 ? 0 : 3;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.cacheTokenManager = cacheTokenManager;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 == 0 ? 0 : 0;
            continue;
          default:
            this.clientSessionManager = clientSessionManager;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    internal static Guid GenerateTokenKey(Guid authToken, string tokenValue)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (PublicCacheService.WjyI7sV4Rc5VkcUhnU3((object) tokenValue))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return PublicCacheService.TokenCache.GetOrAdd(tokenValue, PublicCacheService.K9hcoWVcAGKCtqIgtFd((object) tokenValue));
label_3:
      return Guid.Empty;
    }

    public string GetTokenValue(Guid typeUid, string eqlQuery) => typeUid.ToString((string) PublicCacheService.pfL776VP1DHvXy26Axn(631805505 ^ 631810483)) + (string) PublicCacheService.pfL776VP1DHvXy26Axn(-201065280 ^ -201095372) + eqlQuery;

    public bool IsCacheValid(
      Guid authToken,
      string tokenValue,
      out EleWise.ELMA.API.Models.IPublicClientCacheToken cacheToken)
    {
      int num1 = 10;
      EleWise.ELMA.Security.Models.API.IPublicClientCacheToken clientCacheToken;
      while (true)
      {
        int num2 = num1;
        EleWise.ELMA.API.Models.IPublicClientSession session;
        Guid tokenKey;
        EleWise.ELMA.Security.Models.API.IPublicClientSession publicClientSession;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              if (!PublicCacheService.WjyI7sV4Rc5VkcUhnU3((object) tokenValue))
              {
                num2 = 6;
                continue;
              }
              goto label_9;
            case 3:
              tokenKey = PublicCacheService.pabSYXVd1O2g0qlafty(authToken, (object) tokenValue);
              num2 = 12;
              continue;
            case 4:
              publicClientSession = (EleWise.ELMA.Security.Models.API.IPublicClientSession) PublicCacheService.hNWeYBV5jtP3lfCdQi2((object) this.clientSessionManager, (object) session.SessionToken);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b != 0 ? 3 : 0;
              continue;
            case 5:
              cacheToken = (EleWise.ELMA.API.Models.IPublicClientCacheToken) clientCacheToken;
              num2 = 11;
              continue;
            case 6:
              session = (EleWise.ELMA.API.Models.IPublicClientSession) PublicCacheService.PoLQ5IV8rvKxyxCUPCo((object) this.clientService, authToken);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0 ? 1 : 1;
              continue;
            case 8:
              if (this.clientService.IsSessionValid(session.SessionToken, out session))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 != 0 ? 4 : 0;
                continue;
              }
              goto label_17;
            case 9:
              if (PublicCacheService.M10KteVQIElW456ldxP(authToken, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 == 0 ? 7 : 7;
                continue;
              }
              goto case 2;
            case 10:
              cacheToken = (EleWise.ELMA.API.Models.IPublicClientCacheToken) null;
              num2 = 9;
              continue;
            case 11:
              goto label_19;
            case 12:
              clientCacheToken = (EleWise.ELMA.Security.Models.API.IPublicClientCacheToken) PublicCacheService.VJYrjgVE1BDo60SeEKw((object) this.cacheTokenManager, tokenKey, (object) publicClientSession);
              num2 = 14;
              continue;
            case 13:
              goto label_17;
            case 14:
              goto label_14;
            default:
              goto label_9;
          }
        }
label_5:
        if (session != null)
        {
          num1 = 8;
          continue;
        }
        goto label_17;
label_14:
        if (clientCacheToken != null)
          num1 = 5;
        else
          goto label_19;
      }
label_9:
      return false;
label_17:
      return false;
label_19:
      return clientCacheToken != null;
    }

    public long RemoveExpired(TimeSpan expireInterval)
    {
      int num = 1;
      DateTime expireDateTime;
      while (true)
      {
        switch (num)
        {
          case 1:
            expireDateTime = PublicCacheService.SI6ObLVXaH3dDW5WsMd(PublicCacheService.jSke1qVGxNlukPEpgIb(), expireInterval);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return PublicCacheService.rt8i5eV9QnWYUPrGyCX((object) this.cacheTokenManager, expireDateTime);
    }

    public EleWise.ELMA.API.Models.IPublicClientCacheToken CreateCacheToken(
      Guid authToken,
      string tokenValue)
    {
      int num = 12;
      EleWise.ELMA.API.Models.IPublicClientSession session;
      EleWise.ELMA.Security.Models.API.IPublicClientCacheToken cacheToken1;
      EleWise.ELMA.API.Models.IPublicClientCacheToken cacheToken2;
      while (true)
      {
        switch (num)
        {
          case 1:
            cacheToken1.Session = (EleWise.ELMA.Security.Models.API.IPublicClientSession) PublicCacheService.hNWeYBV5jtP3lfCdQi2((object) this.clientSessionManager, PublicCacheService.W0DdX3V1rXCnUWsMLpI((object) session));
            num = 3;
            continue;
          case 2:
            PublicCacheService.H6YZ59Vh13lQoIOH89i((object) cacheToken1, PublicCacheService.jSke1qVGxNlukPEpgIb());
            num = 13;
            continue;
          case 3:
            PublicCacheService.QBaKmbVMZejRarTwuVa((object) cacheToken1, (object) tokenValue);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 13 : 14;
            continue;
          case 4:
            if (this.clientService.IsSessionValid((string) PublicCacheService.W0DdX3V1rXCnUWsMLpI((object) session), out session))
            {
              num = 7;
              continue;
            }
            goto label_5;
          case 5:
            session = (EleWise.ELMA.API.Models.IPublicClientSession) PublicCacheService.PoLQ5IV8rvKxyxCUPCo((object) this.clientService, authToken);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 == 0 ? 0 : 8;
            continue;
          case 6:
            goto label_21;
          case 7:
            cacheToken1 = this.cacheTokenManager.Create();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 == 0 ? 1 : 1;
            continue;
          case 8:
            if (session != null)
            {
              num = 4;
              continue;
            }
            goto label_5;
          case 9:
            goto label_10;
          case 10:
            goto label_4;
          case 11:
            if (!PublicCacheService.WjyI7sV4Rc5VkcUhnU3((object) tokenValue))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 == 0 ? 0 : 0;
              continue;
            }
            goto label_10;
          case 12:
            if (!(authToken == Guid.Empty))
            {
              num = 11;
              continue;
            }
            goto label_10;
          case 13:
            this.cacheTokenManager.Save(cacheToken1);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e != 0 ? 5 : 10;
            continue;
          case 14:
            cacheToken1.TokenKey = PublicCacheService.GenerateTokenKey(authToken, tokenValue);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 == 0 ? 2 : 0;
            continue;
          default:
            if (!this.IsCacheValid(authToken, tokenValue, out cacheToken2))
            {
              num = 5;
              continue;
            }
            goto label_21;
        }
      }
label_4:
      return (EleWise.ELMA.API.Models.IPublicClientCacheToken) cacheToken1;
label_5:
      return (EleWise.ELMA.API.Models.IPublicClientCacheToken) null;
label_10:
      return (EleWise.ELMA.API.Models.IPublicClientCacheToken) null;
label_21:
      return cacheToken2;
    }

    public Guid GetTokenKey(Guid authToken, string tokenValue)
    {
      int num = 2;
      EleWise.ELMA.API.Models.IPublicClientSession session;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!PublicCacheService.WjyI7sV4Rc5VkcUhnU3((object) tokenValue))
            {
              num = 8;
              continue;
            }
            goto label_4;
          case 2:
            if (!(authToken == Guid.Empty))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc == 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          case 3:
          case 5:
            goto label_9;
          case 4:
            if (!this.clientService.IsSessionValid((string) PublicCacheService.W0DdX3V1rXCnUWsMLpI((object) session), out session))
            {
              num = 3;
              continue;
            }
            goto label_8;
          case 6:
            if (session == null)
            {
              num = 5;
              continue;
            }
            goto case 4;
          case 7:
            goto label_8;
          case 8:
            session = (EleWise.ELMA.API.Models.IPublicClientSession) PublicCacheService.PoLQ5IV8rvKxyxCUPCo((object) this.clientService, authToken);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e == 0 ? 2 : 6;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return Guid.Empty;
label_8:
      return PublicCacheService.GenerateTokenKey(authToken, tokenValue);
label_9:
      return Guid.Empty;
    }

    public bool PromoteCacheToken(Guid authToken, string tokenValue)
    {
      int num = 1;
      EleWise.ELMA.API.Models.IPublicClientSession session;
      EleWise.ELMA.Security.Models.API.IPublicClientSession byToken;
      Guid tokenKey;
      while (true)
      {
        switch (num)
        {
          case 1:
            session = (EleWise.ELMA.API.Models.IPublicClientSession) PublicCacheService.PoLQ5IV8rvKxyxCUPCo((object) this.clientService, authToken);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 == 0 ? 0 : 0;
            continue;
          case 2:
            if (this.clientService.IsSessionValid((string) PublicCacheService.W0DdX3V1rXCnUWsMLpI((object) session), out session))
            {
              num = 6;
              continue;
            }
            goto label_6;
          case 3:
            goto label_6;
          case 4:
            goto label_9;
          case 5:
            tokenKey = PublicCacheService.pabSYXVd1O2g0qlafty(authToken, (object) tokenValue);
            num = 4;
            continue;
          case 6:
            byToken = this.clientSessionManager.FindByToken(session.SessionToken);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 1 : 5;
            continue;
          default:
            if (session != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 == 0 ? 1 : 2;
              continue;
            }
            goto label_6;
        }
      }
label_6:
      return false;
label_9:
      return this.cacheTokenManager.Promote(tokenKey, byToken);
    }

    public bool SyncCache(
      Guid authToken,
      Guid typeUid,
      DateTime? fromDate,
      long[] data,
      string eqlQuery)
    {
      if (authToken == Guid.Empty || typeUid == Guid.Empty || data == null)
        return false;
      string tokenValue = this.GetTokenValue(typeUid, eqlQuery);
      EleWise.ELMA.API.Models.IPublicClientSession session = this.clientService.GetSession(authToken);
      if (session != null && this.clientService.IsSessionValid(session.SessionToken, out session))
      {
        EleWise.ELMA.API.Models.IPublicClientCacheToken cacheToken = this.CreateCacheToken(authToken, tokenValue);
        if (cacheToken != null)
          return this.cacheTokenManager.SetData(cacheToken.Id, data);
      }
      return false;
    }

    public bool UpdateCache(
      Guid authToken,
      Guid typeUid,
      DateTime? fromDate,
      long[] updated,
      long[] deleted,
      string eqlQuery)
    {
      if (authToken == Guid.Empty || typeUid == Guid.Empty || updated == null && deleted == null)
        return false;
      string tokenValue = this.GetTokenValue(typeUid, eqlQuery);
      EleWise.ELMA.API.Models.IPublicClientSession session = this.clientService.GetSession(authToken);
      if (session != null && this.clientService.IsSessionValid(session.SessionToken, out session))
      {
        EleWise.ELMA.API.Models.IPublicClientCacheToken cacheToken = this.CreateCacheToken(authToken, tokenValue);
        if (cacheToken != null)
          return this.cacheTokenManager.UpdateData(cacheToken.Id, updated, deleted);
      }
      return false;
    }

    static PublicCacheService()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PublicCacheService.O1wr9hVfxJx2Ioxsnft();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            PublicCacheService.TokenCache = new ConcurrentDictionary<string, Guid>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void O1wr9hVfxJx2Ioxsnft() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool PZMT3CVVInSCVDBaTLE() => PublicCacheService.oSrPkXVy3wtenOX8aYG == null;

    internal static PublicCacheService dISdi0VlfqfrDbWybib() => PublicCacheService.oSrPkXVy3wtenOX8aYG;

    internal static bool WjyI7sV4Rc5VkcUhnU3([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static Guid K9hcoWVcAGKCtqIgtFd([In] object obj0) => ((string) obj0).GetDeterministicGuid();

    internal static object pfL776VP1DHvXy26Axn(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool M10KteVQIElW456ldxP([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object PoLQ5IV8rvKxyxCUPCo([In] object obj0, [In] Guid obj1) => (object) ((IPublicClientService) obj0).GetSession(obj1);

    internal static object hNWeYBV5jtP3lfCdQi2([In] object obj0, [In] object obj1) => (object) ((PublicClientSessionManager) obj0).FindByToken((string) obj1);

    internal static Guid pabSYXVd1O2g0qlafty(Guid authToken, [In] object obj1) => PublicCacheService.GenerateTokenKey(authToken, (string) obj1);

    internal static object VJYrjgVE1BDo60SeEKw([In] object obj0, Guid tokenKey, [In] object obj2) => (object) ((PublicClientCacheTokenManager) obj0).FindByTokenSession(tokenKey, (EleWise.ELMA.Security.Models.API.IPublicClientSession) obj2);

    internal static DateTime jSke1qVGxNlukPEpgIb() => DateTime.Now;

    internal static DateTime SI6ObLVXaH3dDW5WsMd([In] DateTime obj0, [In] TimeSpan obj1) => obj0 - obj1;

    internal static long rt8i5eV9QnWYUPrGyCX([In] object obj0, DateTime expireDateTime) => ((PublicClientCacheTokenManager) obj0).DeleteExpired(expireDateTime);

    internal static object W0DdX3V1rXCnUWsMLpI([In] object obj0) => (object) ((EleWise.ELMA.API.Models.IPublicClientSession) obj0).SessionToken;

    internal static void QBaKmbVMZejRarTwuVa([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Security.Models.API.IPublicClientCacheToken) obj0).TokenValue = (string) obj1;

    internal static void H6YZ59Vh13lQoIOH89i([In] object obj0, DateTime value) => ((EleWise.ELMA.Security.Models.API.IPublicClientCacheToken) obj0).LastAccess = value;
  }
}

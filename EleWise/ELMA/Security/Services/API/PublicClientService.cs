// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.API.PublicClientService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.API;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security.Cryptography;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Text;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace EleWise.ELMA.Security.Services.API
{
  [Service(EnableInterceptors = false, InjectProperties = false, Type = ComponentType.Server)]
  internal sealed class PublicClientService : IPublicClientService
  {
    internal const int TokenLength = 128;
    private readonly PublicClientSessionManager clientSessionManager;
    private readonly IEntityManager<EleWise.ELMA.Security.Models.API.IPublicApplication, long> applicationManager;
    private readonly PublicApplicationTokenManager applicationTokenManager;
    private readonly IPublicApplicationService applicationService;
    private readonly ILockManager lockManager;
    private readonly IPublicSignatureService publicSignatureService;
    private readonly SessionCache cache;
    private ConcurrentDictionary<long, bool> promotedSessions;
    private ReaderWriterLock _updateSessionsLock;
    private DateTime? _lastUpdateTime;
    internal static PublicClientService KKlGdEVBONOPQdg8BOM;

    /// <summary>Ctor</summary>
    /// <param name="applicationService">Сервис для обеспечения работы внешних приложений</param>
    /// <param name="clientSessionManager">Менеджер клиентских сессий</param>
    /// <param name="applicationManager">Менеджер внешних приложений</param>
    /// <param name="applicationTokenManager">Менеджер токенов доступа публичных приложений</param>
    /// <param name="lockManager">Менеджер блокировок</param>
    /// <param name="publicSignatureService">Сервис для работы с подписью запросов Public API</param>
    /// <param name="cacheService">Сервис кэширования</param>
    public PublicClientService(
      IPublicApplicationService applicationService,
      PublicClientSessionManager clientSessionManager,
      IEntityManager<EleWise.ELMA.Security.Models.API.IPublicApplication, long> applicationManager,
      PublicApplicationTokenManager applicationTokenManager,
      ILockManager lockManager,
      IPublicSignatureService publicSignatureService,
      ICacheService cacheService)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      this.promotedSessions = new ConcurrentDictionary<long, bool>();
      this._updateSessionsLock = new ReaderWriterLock();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.clientSessionManager = clientSessionManager;
      this.applicationService = applicationService;
      this.applicationManager = applicationManager;
      this.applicationTokenManager = applicationTokenManager;
      this.lockManager = lockManager;
      this.publicSignatureService = publicSignatureService;
      this.cache = new SessionCache(clientSessionManager, cacheService);
    }

    private EleWise.ELMA.Security.Models.API.IPublicClientSession GetSessionInternal(
      string sessionToken)
    {
      int num = 2;
      PublicClientService publicClientService;
      string sessionToken1;
      while (true)
      {
        switch (num)
        {
          case 1:
            publicClientService = this;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc != 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            sessionToken1 = sessionToken;
            num = 3;
            continue;
        }
      }
label_3:
      // ISSUE: reference to a compiler-generated method
      return this.cache.GetOrAdd(sessionToken1, (Func<EleWise.ELMA.Security.Models.API.IPublicClientSession>) (() => (EleWise.ELMA.Security.Models.API.IPublicClientSession) PublicClientService.\u003C\u003Ec__DisplayClass9_0.TsqGGiw09D2Vq7g7Y9G3((object) publicClientService.clientSessionManager, (object) sessionToken1)));
    }

    private EleWise.ELMA.Security.Models.API.IPublicClientSession GetSessionInternal(
      Guid authToken)
    {
      int num = 3;
      PublicClientService publicClientService;
      Guid authToken1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            publicClientService = this;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0 ? 0 : 0;
            continue;
          case 3:
            num = 2;
            continue;
          default:
            authToken1 = authToken;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 1 : 1;
            continue;
        }
      }
label_2:
      // ISSUE: reference to a compiler-generated method
      return this.cache.GetOrAdd(authToken1, (Func<EleWise.ELMA.Security.Models.API.IPublicClientSession>) (() => (EleWise.ELMA.Security.Models.API.IPublicClientSession) PublicClientService.\u003C\u003Ec__DisplayClass10_0.fwbZeMw0BdmjfEuJepXf((object) publicClientService.clientSessionManager, authToken1)));
    }

    internal static string GenerateSessionToken(Guid authToken, string applicationToken) => (string) PublicClientService.MU8t8EVFAYQfB90cAQ4((object) (applicationToken + authToken.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-550634672 ^ -550648670)) + (object) PublicClientService.ikoctcVTWnHxV34TirZ().Ticks));

    internal static string Generate128ByteToken(string tokenKey)
    {
      int num1 = 2;
      SHA512 shA512;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            shA512 = (SHA512) PublicClientService.lW5dJyVvE7fpDdFlKyq();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 != 0 ? 1 : 1;
            continue;
          default:
            goto label_12;
        }
      }
label_2:
      string str;
      try
      {
        Encoding encoding = (Encoding) PublicClientService.TkG5RRVqNkLJa8TJe8K();
        int num2 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e == 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              str = ((string) PublicClientService.uMmdMXVI5HP66oZrFck(PublicClientService.vUfDCgVJOQ7bBTPk6dv((object) shA512, PublicClientService.Cr9sPsVgC3Eoh6OKK0h((object) encoding, (object) tokenKey)))).Replace((string) PublicClientService.WvjGK1VeoxLCVwXSmWY(-1324692970 << 3 ^ -2007606122), "");
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 0 : 0;
              continue;
            default:
              goto label_12;
          }
        }
      }
      finally
      {
        int num3;
        if (shA512 == null)
          num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 1 : 1;
        else
          goto label_9;
label_8:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_9:
        PublicClientService.E8chddVnt57UISmKvOU((object) shA512);
        num3 = 2;
        goto label_8;
      }
label_12:
      return str;
    }

    public IEnumerable<EleWise.ELMA.API.Models.IPublicClientSession> Sessions => (IEnumerable<EleWise.ELMA.API.Models.IPublicClientSession>) this.clientSessionManager.FindAll();

    public EleWise.ELMA.API.Models.IPublicClientSession CreateSession(
      Guid authToken,
      string applicationToken)
    {
      int num = 2;
      byte[] secret;
      while (true)
      {
        IEcdhKey ecdhKey;
        object obj;
        switch (num)
        {
          case 1:
            if (ecdhKey != null)
            {
              num = 3;
              continue;
            }
            goto default;
          case 2:
            ecdhKey = (IEcdhKey) PublicClientService.I9e7chVL2MEHKYJ9AJs((object) this.publicSignatureService);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 == 0 ? 1 : 1;
            continue;
          case 3:
            obj = PublicClientService.F4QSpoV2s6vpUb1kkL7((object) ecdhKey);
            break;
          case 4:
            goto label_5;
          default:
            obj = (object) null;
            break;
        }
        secret = (byte[]) obj;
        num = 4;
      }
label_5:
      return this.CreateSession(authToken, applicationToken, secret);
    }

    private EleWise.ELMA.API.Models.IPublicClientSession CreateSession(
      Guid authToken,
      string applicationToken,
      byte[] secret)
    {
      int num1 = 2;
      EleWise.ELMA.Security.Models.API.IPublicClientSession session1;
      EleWise.ELMA.API.Models.IPublicClientSession session2;
      while (true)
      {
        int num2 = num1;
        EleWise.ELMA.Security.IUser user;
        EleWise.ELMA.API.Models.IPublicApplicationToken token;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (applicationToken != null)
              {
                num2 = 3;
                continue;
              }
              goto label_3;
            case 2:
              if (!PublicClientService.llvvNBVH0krBuE14Rvm(authToken, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 1 : 1;
                continue;
              }
              goto label_3;
            case 3:
              if (PublicClientService.zuPPFeVzNqPn6l78sN4((object) applicationToken) == 128)
              {
                user = (EleWise.ELMA.Security.IUser) PublicClientService.gX5LOalu6csJVxNrURg((object) Locator.GetServiceNotNull<IAuthenticationTokenService>(), authToken);
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 11 : 8;
                continue;
              }
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 == 0 ? 0 : 6;
              continue;
            case 4:
              this.cache.Add(session1);
              num2 = 24;
              continue;
            case 5:
              goto label_15;
            case 6:
              goto label_3;
            case 7:
              PublicClientService.Kx42HBlUMin8DA4lRXS((object) session1, authToken);
              num2 = 21;
              continue;
            case 8:
              PublicClientService.NptkNalm6lyOJ6mT9ZK((object) session1, (object) (EleWise.ELMA.Security.Models.IUser) user);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e == 0 ? 13 : 23;
              continue;
            case 9:
              if (this.applicationService.IsTokenValid(applicationToken, out token))
              {
                num2 = 16;
                continue;
              }
              goto label_20;
            case 10:
              goto label_14;
            case 11:
              if (user != null)
              {
                num2 = 17;
                continue;
              }
              goto label_6;
            case 12:
              if (session2 == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af == 0 ? 9 : 8;
                continue;
              }
              goto default;
            case 13:
              PublicClientService.kyFUCZlkTo9EElwbv3H((object) session1, (object) secret);
              num2 = 19;
              continue;
            case 14:
              goto label_6;
            case 15:
              goto label_20;
            case 16:
              if (token == null)
              {
                num2 = 15;
                continue;
              }
              goto case 20;
            case 17:
              session2 = this.GetSession(authToken);
              num2 = 12;
              continue;
            case 18:
              if (PublicClientService.SL7OQmlKglI6SusjGmi(PublicClientService.tLbOk3lb7c1gQeT7EY6(PublicClientService.xdpQV9lwuEi03bKQcjY((object) session2)), (object) applicationToken))
              {
                num2 = 10;
                continue;
              }
              goto label_15;
            case 19:
              session1.LastAccess = DateTime.Now;
              num2 = 22;
              continue;
            case 20:
              session1 = this.clientSessionManager.Create();
              num2 = 7;
              continue;
            case 21:
              session1.Application = this.applicationManager.Load(((EleWise.ELMA.API.Models.IPublicApplication) PublicClientService.MW71kAlRqeHmb4Ms9OL((object) token)).Uid);
              num2 = 25;
              continue;
            case 22:
              this.clientSessionManager.Save(session1);
              num2 = 4;
              continue;
            case 23:
              session1.SessionToken = (string) PublicClientService.hK3pr2l62E6vMaQ5R3L(authToken, (object) applicationToken);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 == 0 ? 13 : 5;
              continue;
            case 24:
              goto label_19;
            case 25:
              PublicClientService.sy77PqltVYddhXYSHCv((object) session1, PublicClientService.Dk95GyloeUBYaHJAHTU((object) this.applicationTokenManager, (object) applicationToken));
              num2 = 8;
              continue;
            default:
              if (PublicClientService.xdpQV9lwuEi03bKQcjY((object) session2) != null)
                goto case 18;
              else
                goto label_13;
          }
        }
label_13:
        num1 = 5;
      }
label_3:
      return (EleWise.ELMA.API.Models.IPublicClientSession) null;
label_6:
      return (EleWise.ELMA.API.Models.IPublicClientSession) null;
label_14:
      return session2;
label_15:
      return (EleWise.ELMA.API.Models.IPublicClientSession) null;
label_19:
      return (EleWise.ELMA.API.Models.IPublicClientSession) session1;
label_20:
      return (EleWise.ELMA.API.Models.IPublicClientSession) null;
    }

    public bool UpdateAuthToken(string sessionToken, Guid newToken)
    {
      int num = 4;
      EleWise.ELMA.Security.Models.API.IPublicClientSession sessionInternal;
      while (true)
      {
        switch (num)
        {
          case 1:
            PublicClientService.Kx42HBlUMin8DA4lRXS((object) sessionInternal, newToken);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af == 0 ? 1 : 7;
            continue;
          case 2:
            goto label_3;
          case 3:
            if (PublicClientService.zuPPFeVzNqPn6l78sN4((object) sessionToken) == 128)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b == 0 ? 8 : 8;
              continue;
            }
            goto label_18;
          case 4:
            if (sessionToken != null)
            {
              num = 3;
              continue;
            }
            goto label_18;
          case 5:
            goto label_5;
          case 6:
            this.cache.Add(sessionInternal);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 == 0 ? 0 : 0;
            continue;
          case 7:
            this.clientSessionManager.Save(sessionInternal);
            num = 6;
            continue;
          case 8:
            if (PublicClientService.llvvNBVH0krBuE14Rvm(newToken, Guid.Empty))
            {
              num = 10;
              continue;
            }
            if (this.GetSession(newToken) == null)
            {
              sessionInternal = this.GetSessionInternal(sessionToken);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 3 : 9;
              continue;
            }
            num = 5;
            continue;
          case 9:
            if (sessionInternal != null)
            {
              PublicClientService.uQq4iVlaXf5qkgLDhCx((object) this.cache, PublicClientService.ahoX20lD4JGs5scuRhm((object) sessionInternal));
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e == 0 ? 0 : 1;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 == 0 ? 2 : 0;
            continue;
          case 10:
            goto label_18;
          default:
            goto label_7;
        }
      }
label_3:
      return false;
label_5:
      return false;
label_7:
      return true;
label_18:
      return false;
    }

    public bool IsSessionValid(string sessionToken, out EleWise.ELMA.API.Models.IPublicClientSession session)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          EleWise.ELMA.Security.Models.API.IPublicClientSession sessionInternal;
          switch (num2)
          {
            case 1:
              if (PublicClientService.bBIDPAlxmJdNrBIaPdc((object) sessionInternal) == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 0 : 0;
                continue;
              }
              goto case 11;
            case 2:
              session = (EleWise.ELMA.API.Models.IPublicClientSession) sessionInternal;
              num2 = 9;
              continue;
            case 3:
            case 4:
              goto label_13;
            case 5:
              if (sessionToken == null)
              {
                num2 = 8;
                continue;
              }
              goto case 10;
            case 6:
              session = (EleWise.ELMA.API.Models.IPublicClientSession) null;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e != 0 ? 5 : 0;
              continue;
            case 7:
              if (sessionInternal != null)
                goto case 1;
              else
                goto label_12;
            case 8:
            case 12:
              goto label_4;
            case 9:
              goto label_18;
            case 10:
              if (PublicClientService.zuPPFeVzNqPn6l78sN4((object) sessionToken) == 128)
              {
                sessionInternal = this.GetSessionInternal(sessionToken);
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 7 : 1;
                continue;
              }
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 != 0 ? 8 : 12;
              continue;
            case 11:
              if (this.applicationService.IsTokenValid(sessionInternal.ClientToken.Token, out EleWise.ELMA.API.Models.IPublicApplicationToken _))
              {
                num2 = 2;
                continue;
              }
              break;
          }
          this.RemoveSession(sessionToken);
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0 ? 3 : 0;
        }
label_12:
        num1 = 4;
      }
label_4:
      return false;
label_13:
      return false;
label_18:
      return true;
    }

    public bool PromoteSession(string sessionToken)
    {
      int num1 = 6;
      DateTime dateTime;
      EleWise.ELMA.Security.Models.API.IPublicClientSession sessionInternal;
      while (true)
      {
        switch (num1)
        {
          case 1:
            sessionInternal = this.GetSessionInternal(sessionToken);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_21;
          case 3:
            if (PublicClientService.WWaR2AlC5JmpW6pewJp(sessionInternal.LastAccess, dateTime.AddMinutes(-1.0)))
            {
              num1 = 2;
              continue;
            }
            PublicClientService.LvTKCdlidGnfTJQvQXO((object) this._updateSessionsLock, 10);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab == 0 ? 3 : 7;
            continue;
          case 4:
            goto label_6;
          case 5:
            if (sessionToken.Length == 128)
            {
              dateTime = PublicClientService.ikoctcVTWnHxV34TirZ();
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 == 0 ? 1 : 0;
              continue;
            }
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 != 0 ? 8 : 7;
            continue;
          case 6:
            if (sessionToken != null)
            {
              num1 = 5;
              continue;
            }
            goto label_2;
          case 7:
            goto label_9;
          case 8:
            goto label_2;
          default:
            if (sessionInternal != null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 == 0 ? 3 : 1;
              continue;
            }
            goto label_21;
        }
      }
label_2:
      return false;
label_6:
      return true;
label_9:
      try
      {
        this.promotedSessions.AddOrUpdate(sessionInternal.Id, false, (Func<long, bool, bool>) ((l, b) => false));
        int num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_6;
        }
      }
      finally
      {
        this._updateSessionsLock.ReleaseReaderLock();
        int num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_21:
      return false;
    }

    public bool RemoveSession(string sessionToken)
    {
      int num = 2;
      EleWise.ELMA.Security.Models.API.IPublicClientSession publicClientSession;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 7:
            goto label_6;
          case 2:
            if (sessionToken == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c == 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            if (PublicClientService.zuPPFeVzNqPn6l78sN4((object) sessionToken) == 128)
            {
              PublicClientService.bIN5Pul3EMZ7Ecnf8n4((object) this.cache, (object) sessionToken);
              num = 6;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 == 0 ? 3 : 7;
            continue;
          case 4:
            goto label_8;
          case 5:
            goto label_10;
          case 6:
            publicClientSession = (EleWise.ELMA.Security.Models.API.IPublicClientSession) PublicClientService.BjsdggljO5ocAoPIE0f((object) this.clientSessionManager, (object) sessionToken);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 == 0 ? 8 : 8;
            continue;
          case 8:
            if (publicClientSession != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0 ? 0 : 0;
              continue;
            }
            goto label_10;
          default:
            this.clientSessionManager.Delete(publicClientSession);
            num = 4;
            continue;
        }
      }
label_6:
      return false;
label_8:
      return true;
label_10:
      return false;
    }

    public EleWise.ELMA.API.Models.IPublicClientSession GetSession(
      Guid authToken)
    {
      return (EleWise.ELMA.API.Models.IPublicClientSession) this.GetSessionInternal(authToken);
    }

    public bool UpdateLastChangesPackage(Guid authToken, string changesPackage)
    {
      int num1 = 3;
      EleWise.ELMA.Security.Models.API.IPublicClientSession sessionInternal;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_16;
          case 2:
            if (sessionInternal == null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab == 0 ? 1 : 4;
              continue;
            }
            PublicClientService.LvTKCdlidGnfTJQvQXO((object) this._updateSessionsLock, 10);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0 ? 0 : 0;
            continue;
          case 3:
            sessionInternal = this.GetSessionInternal(authToken);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 == 0 ? 1 : 2;
            continue;
          case 4:
            goto label_5;
          default:
            goto label_7;
        }
      }
label_5:
      return false;
label_7:
      try
      {
        PublicClientService.HBmCS4l0WB6jWyGafvw((object) sessionInternal, PublicClientService.WKAtVHlNYBietO6QoE6((object) changesPackage) ? (object) new byte[0] : PublicClientService.Cr9sPsVgC3Eoh6OKK0h((object) EncodingCache.UTF8WithoutEmitIdentifier, (object) changesPackage));
        int num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_16;
            default:
              this.clientSessionManager.Save(sessionInternal);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 1 : 0;
              continue;
          }
        }
      }
      finally
      {
        this._updateSessionsLock.ReleaseReaderLock();
        int num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_16:
      return true;
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
            expireDateTime = PublicClientService.NhPJVKlZIBWm0j7ygv0(PublicClientService.ikoctcVTWnHxV34TirZ(), expireInterval);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this.clientSessionManager.DeleteExpired(expireDateTime);
    }

    protected void FlushUpdatedSessions()
    {
      int num1 = 9;
      // ISSUE: variable of a compiler-generated type
      PublicClientService.\u003C\u003Ec__DisplayClass28_0 cDisplayClass280;
      CallContextSessionOwner contextSessionOwner;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 4:
              // ISSUE: reference to a compiler-generated field
              this._lastUpdateTime = new DateTime?(cDisplayClass280.now);
              num2 = 7;
              continue;
            case 2:
              if (this._lastUpdateTime.HasValue)
                goto case 6;
              else
                goto label_41;
            case 3:
              goto label_37;
            case 5:
              goto label_6;
            case 6:
              // ISSUE: reference to a compiler-generated field
              if (PublicClientService.lq3gWQlAvd6Ds409JlV(cDisplayClass280.now, this._lastUpdateTime.Value) >= PublicClientService.bjlKbilsoj8lUbuQM5H(5.0))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef != 0 ? 0 : 1;
                continue;
              }
              goto label_32;
            case 7:
              contextSessionOwner = (CallContextSessionOwner) PublicClientService.pMQQVwl7VpCYmlJu05T();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d != 0 ? 5 : 4;
              continue;
            case 8:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass280.\u003C\u003E4__this = this;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 0 : 0;
              continue;
            case 9:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass280 = new PublicClientService.\u003C\u003Ec__DisplayClass28_0();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0 ? 8 : 7;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass280.now = PublicClientService.ikoctcVTWnHxV34TirZ();
              num2 = 2;
              continue;
          }
        }
label_41:
        num1 = 4;
      }
label_37:
      return;
label_6:
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        PublicClientService.\u003C\u003Ec__DisplayClass28_1 cDisplayClass281 = new PublicClientService.\u003C\u003Ec__DisplayClass28_1();
        int num3 = 2;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0)
          num3 = 2;
        while (true)
        {
          switch (num3)
          {
            case 1:
            case 8:
              // ISSUE: reference to a compiler-generated method
              this.ExecuteWithLock(new Action(cDisplayClass281.\u003CFlushUpdatedSessions\u003Eb__0));
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af != 0 ? 0 : 3;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass281.CS\u0024\u003C\u003E8__locals1 = cDisplayClass280;
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b == 0 ? 0 : 0;
              continue;
            case 3:
              goto label_27;
            case 4:
label_10:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass281.sessionsToUpdate != null)
              {
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0 ? 0 : 1;
                continue;
              }
              goto label_25;
            case 5:
              goto label_19;
            case 6:
              try
              {
                int num4;
                if (PublicClientService.A98nMJlr7ppI6b8ov3m((object) this.promotedSessions.Keys) == 0)
                  num4 = 3;
                else
                  goto label_17;
label_16:
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_10;
                    case 2:
                      this.promotedSessions.Clear();
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 == 0 ? 1 : 1;
                      continue;
                    case 3:
                      goto label_23;
                    default:
                      goto label_17;
                  }
                }
label_23:
                return;
label_17:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass281.sessionsToUpdate = new List<long>((IEnumerable<long>) this.promotedSessions.Keys);
                num4 = 2;
                goto label_16;
              }
              finally
              {
                this._updateSessionsLock.ReleaseWriterLock();
                int num5 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 == 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                }
              }
            case 7:
              PublicClientService.xxcwNOlWDVhKR6BK9t2((object) this._updateSessionsLock, 100);
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 == 0 ? 6 : 6;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass281.sessionsToUpdate = (List<long>) null;
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 != 0 ? 1 : 7;
              continue;
          }
        }
label_27:
        return;
label_19:
        return;
label_25:
        return;
      }
      finally
      {
        if (contextSessionOwner != null)
        {
          int num6 = 1;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 == 0)
            num6 = 1;
          while (true)
          {
            switch (num6)
            {
              case 1:
                PublicClientService.E8chddVnt57UISmKvOU((object) contextSessionOwner);
                num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc == 0 ? 0 : 0;
                continue;
              default:
                goto label_34;
            }
          }
        }
label_34:;
      }
label_32:;
    }

    private void ExecuteWithLock(Action action)
    {
      int num1 = 2;
      bool lockTaken;
      PublicClientService publicClientService;
      IUnitOfWorkManager serviceNotNull;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            if (action != null)
            {
              serviceNotNull = Locator.GetServiceNotNull<IUnitOfWorkManager>();
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 0 : 0;
              continue;
            }
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_8;
          case 4:
            goto label_55;
          case 5:
            lockTaken = false;
            num1 = 3;
            continue;
          default:
            publicClientService = this;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e == 0 ? 1 : 5;
            continue;
        }
      }
label_55:
      return;
label_4:
      throw new ArgumentNullException((string) PublicClientService.WvjGK1VeoxLCVwXSmWY(1053060681 ^ 1053064769));
label_8:
      try
      {
        Monitor.Enter((object) publicClientService, ref lockTaken);
        int num2 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0)
          num2 = 1;
        IUnitOfWork unitOfWork;
        while (true)
        {
          switch (num2)
          {
            case 1:
              unitOfWork = (IUnitOfWork) PublicClientService.jcwa7tlSWZEmbmH9lrH((object) serviceNotNull, (object) string.Empty, true, IsolationLevel.Unspecified);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 == 0 ? 0 : 0;
              continue;
            default:
              goto label_12;
          }
        }
label_12:
        try
        {
          bool flag = false;
          int num3 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 == 0)
            num3 = 0;
          switch (num3)
          {
            default:
              try
              {
                IDisposable disposable = (IDisposable) PublicClientService.lbm5bClYtVkAgf6nX1m((object) this.lockManager, PublicClientService.WvjGK1VeoxLCVwXSmWY(~-272519830 ^ 272509295));
                int num4 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0)
                  num4 = 0;
                switch (num4)
                {
                  case 1:
                    return;
                  default:
                    try
                    {
                      PublicClientService.HB0nH3lySQNxTSuNgjk((object) action);
                      int num5 = 0;
                      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0)
                        num5 = 0;
                      switch (num5)
                      {
                        case 0:
                          return;
                        default:
                          return;
                      }
                    }
                    finally
                    {
                      if (disposable != null)
                      {
                        int num6 = 1;
                        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0)
                          num6 = 0;
                        while (true)
                        {
                          switch (num6)
                          {
                            case 1:
                              PublicClientService.E8chddVnt57UISmKvOU((object) disposable);
                              num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 == 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_29;
                          }
                        }
                      }
label_29:;
                    }
                }
              }
              catch (Exception ex)
              {
                int num7 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d != 0)
                  num7 = 0;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      unitOfWork.Rollback();
                      num7 = 2;
                      continue;
                    case 2:
                      goto label_35;
                    default:
                      flag = true;
                      num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 == 0 ? 1 : 1;
                      continue;
                  }
                }
label_35:
                break;
              }
              finally
              {
                if (!flag)
                {
                  int num8 = 1;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d == 0)
                    num8 = 0;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 1:
                        unitOfWork.Commit();
                        num8 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_42;
                    }
                  }
                }
label_42:;
              }
          }
        }
        finally
        {
          int num9;
          if (unitOfWork == null)
            num9 = 2;
          else
            goto label_48;
label_45:
          switch (num9)
          {
            case 1:
            case 2:
          }
label_48:
          unitOfWork.Dispose();
          num9 = 1;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af == 0)
          {
            num9 = 1;
            goto label_45;
          }
          else
            goto label_45;
        }
      }
      finally
      {
        if (lockTaken)
        {
          int num10 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 != 0)
            num10 = 0;
          while (true)
          {
            switch (num10)
            {
              case 1:
                goto label_57;
              default:
                PublicClientService.L1GMLslVNaRL7gtVBXb((object) publicClientService);
                num10 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_57:;
      }
    }

    internal static bool t0rD9gVp1ImFeYadxrX() => PublicClientService.KKlGdEVBONOPQdg8BOM == null;

    internal static PublicClientService OWZUpGVOANsaUdkJaZX() => PublicClientService.KKlGdEVBONOPQdg8BOM;

    internal static DateTime ikoctcVTWnHxV34TirZ() => DateTime.Now;

    internal static object MU8t8EVFAYQfB90cAQ4([In] object obj0) => (object) PublicClientService.Generate128ByteToken((string) obj0);

    internal static object lW5dJyVvE7fpDdFlKyq() => (object) SHA512.Create();

    internal static object TkG5RRVqNkLJa8TJe8K() => (object) Encoding.UTF8;

    internal static object Cr9sPsVgC3Eoh6OKK0h([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetBytes((string) obj1);

    internal static object vUfDCgVJOQ7bBTPk6dv([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((byte[]) obj1);

    internal static object uMmdMXVI5HP66oZrFck([In] object obj0) => (object) BitConverter.ToString((byte[]) obj0);

    internal static object WvjGK1VeoxLCVwXSmWY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void E8chddVnt57UISmKvOU([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object I9e7chVL2MEHKYJ9AJs([In] object obj0) => (object) ((IPublicSignatureService) obj0).ProcessAuthInfo();

    internal static object F4QSpoV2s6vpUb1kkL7([In] object obj0) => (object) ((IEcdhKey) obj0).SharedSecret;

    internal static bool llvvNBVH0krBuE14Rvm([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static int zuPPFeVzNqPn6l78sN4([In] object obj0) => ((string) obj0).Length;

    internal static object gX5LOalu6csJVxNrURg([In] object obj0, [In] Guid obj1) => (object) ((IAuthenticationTokenService) obj0).GetUser(obj1);

    internal static object xdpQV9lwuEi03bKQcjY([In] object obj0) => (object) ((EleWise.ELMA.API.Models.IPublicClientSession) obj0).ClientToken;

    internal static object tLbOk3lb7c1gQeT7EY6([In] object obj0) => (object) ((EleWise.ELMA.API.Models.IPublicApplicationToken) obj0).Token;

    internal static bool SL7OQmlKglI6SusjGmi([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static void Kx42HBlUMin8DA4lRXS([In] object obj0, Guid value) => ((EleWise.ELMA.Security.Models.API.IPublicClientSession) obj0).AuthToken = value;

    internal static object MW71kAlRqeHmb4Ms9OL([In] object obj0) => (object) ((EleWise.ELMA.API.Models.IPublicApplicationToken) obj0).Application;

    internal static object Dk95GyloeUBYaHJAHTU([In] object obj0, [In] object obj1) => (object) ((PublicApplicationTokenManager) obj0).FindByToken((string) obj1);

    internal static void sy77PqltVYddhXYSHCv([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Security.Models.API.IPublicClientSession) obj0).ClientToken = (EleWise.ELMA.Security.Models.API.IPublicApplicationToken) obj1;

    internal static void NptkNalm6lyOJ6mT9ZK([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Security.Models.API.IPublicClientSession) obj0).AuthUser = (EleWise.ELMA.Security.Models.IUser) obj1;

    internal static object hK3pr2l62E6vMaQ5R3L(Guid authToken, [In] object obj1) => (object) PublicClientService.GenerateSessionToken(authToken, (string) obj1);

    internal static void kyFUCZlkTo9EElwbv3H([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Security.Models.API.IPublicClientSession) obj0).Secret = (byte[]) obj1;

    internal static Guid ahoX20lD4JGs5scuRhm([In] object obj0) => ((EleWise.ELMA.Security.Models.API.IPublicClientSession) obj0).AuthToken;

    internal static bool uQq4iVlaXf5qkgLDhCx([In] object obj0, Guid authToken) => ((SessionCache) obj0).Remove(authToken);

    internal static object bBIDPAlxmJdNrBIaPdc([In] object obj0) => (object) ((EleWise.ELMA.Security.Models.API.IPublicClientSession) obj0).ClientToken;

    internal static bool WWaR2AlC5JmpW6pewJp([In] DateTime obj0, [In] DateTime obj1) => obj0 > obj1;

    internal static void LvTKCdlidGnfTJQvQXO([In] object obj0, [In] int obj1) => ((ReaderWriterLock) obj0).AcquireReaderLock(obj1);

    internal static bool bIN5Pul3EMZ7Ecnf8n4([In] object obj0, [In] object obj1) => ((SessionCache) obj0).Remove((string) obj1);

    internal static object BjsdggljO5ocAoPIE0f([In] object obj0, [In] object obj1) => (object) ((PublicClientSessionManager) obj0).FindByToken((string) obj1);

    internal static bool WKAtVHlNYBietO6QoE6([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static void HBmCS4l0WB6jWyGafvw([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Security.Models.API.IPublicClientSession) obj0).LastChangesPackage = (byte[]) obj1;

    internal static DateTime NhPJVKlZIBWm0j7ygv0([In] DateTime obj0, [In] TimeSpan obj1) => obj0 - obj1;

    internal static TimeSpan lq3gWQlAvd6Ds409JlV([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static TimeSpan bjlKbilsoj8lUbuQM5H([In] double obj0) => TimeSpan.FromMinutes(obj0);

    internal static object pMQQVwl7VpCYmlJu05T() => (object) CallContextSessionOwner.Create();

    internal static void xxcwNOlWDVhKR6BK9t2([In] object obj0, [In] int obj1) => ((ReaderWriterLock) obj0).AcquireWriterLock(obj1);

    internal static int A98nMJlr7ppI6b8ov3m([In] object obj0) => ((ICollection<long>) obj0).Count;

    internal static object jcwa7tlSWZEmbmH9lrH(
      [In] object obj0,
      [In] object obj1,
      [In] bool obj2,
      [In] IsolationLevel obj3)
    {
      return (object) ((IUnitOfWorkManager) obj0).Create((string) obj1, obj2, obj3);
    }

    internal static object lbm5bClYtVkAgf6nX1m([In] object obj0, [In] object obj1) => (object) ((ILockManager) obj0).Lock((string) obj1);

    internal static void HB0nH3lySQNxTSuNgjk([In] object obj0) => ((Action) obj0)();

    internal static void L1GMLslVNaRL7gtVBXb([In] object obj0) => Monitor.Exit(obj0);

    [Component(EnableInterceptiors = false, Type = ComponentType.WebServer)]
    private class PublicClientSessionSweepHandler : ISweepHandler, IThreadPoolContainer
    {
      private readonly object _sweepPool;
      private static object fjroTNw0cgNgREqgfgJR;

      public PublicClientSessionSweepHandler()
      {
        PublicClientService.PublicClientSessionSweepHandler.TcGUAow08JJLSftaBRM7();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this._sweepPool = (object) new ThreadSubPool(1);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 == 0 ? 1 : 1;
              continue;
          }
        }
label_3:;
      }

      IThreadPool IThreadPoolContainer.Pool => (IThreadPool) this._sweepPool;

      void ISweepHandler.Execute() => PublicClientService.PublicClientSessionSweepHandler.lcDxinw056La5tkxFv9s((object) Locator.GetServiceNotNull<PublicClientService>());

      internal static void TcGUAow08JJLSftaBRM7() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

      internal static bool FEtCAdw0PBwKA2GolEC5() => PublicClientService.PublicClientSessionSweepHandler.fjroTNw0cgNgREqgfgJR == null;

      internal static PublicClientService.PublicClientSessionSweepHandler Y8prLpw0QPLor9tg8rNt() => (PublicClientService.PublicClientSessionSweepHandler) PublicClientService.PublicClientSessionSweepHandler.fjroTNw0cgNgREqgfgJR;

      internal static void lcDxinw056La5tkxFv9s([In] object obj0) => ((PublicClientService) obj0).FlushUpdatedSessions();
    }
  }
}

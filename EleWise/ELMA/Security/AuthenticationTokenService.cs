// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.AuthenticationTokenService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Security
{
  /// <summary>
  /// Реализация сервиса, позволяющего создавать токены для авторизованных пользователей
  /// </summary>
  [Service(InjectProperties = true, Scope = ServiceScope.Application, Type = ComponentType.WebServer)]
  internal class AuthenticationTokenService : IAuthenticationTokenService
  {
    private readonly IAuthenticationServiceEventHandler authenticationServiceEventHandler;
    private readonly UserManager userManager;
    private volatile ICacheService cacheService;
    private readonly ISessionProvider sessionProvider;
    internal static AuthenticationTokenService BERQPxUimneX6sjJBD6;

    /// <summary>Ctor</summary>
    /// <param name="userManager">Менеджер пользователей</param>
    /// <param name="sessionProvider"></param>
    /// <param name="authenticationServiceEventHandler">Обработчик событий авторизации в системе</param>
    public AuthenticationTokenService(
      [NotNull] UserManager userManager,
      ISessionProvider sessionProvider,
      IAuthenticationServiceEventHandler authenticationServiceEventHandler)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.sessionProvider = sessionProvider;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 0 : 2;
            continue;
          case 2:
            this.authenticationServiceEventHandler = authenticationServiceEventHandler;
            num = 3;
            continue;
          case 3:
            goto label_3;
          case 4:
            this.userManager = userManager;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 == 0 ? 1 : 1;
            continue;
          default:
            AuthenticationTokenService.mL0gBtU0qlckiJo6uxu((object) userManager, AuthenticationTokenService.XugLqEUNi1sobu6Fjif(2110885667 - -1624984630 ^ -559088837));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a == 0 ? 4 : 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Создать токен</summary>
    /// <param name="user">Пользователь</param>
    /// <returns>Токен</returns>
    [Transaction]
    public virtual Guid CreateToken(IUser user)
    {
      int num = 5;
      AuthToken authToken1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Session.Save((object) authToken1);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0 ? 0 : 0;
            continue;
          case 2:
            this.TokenToCache(authToken1, this.TokenDuration);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_7;
          case 4:
            AuthToken authToken2 = new AuthToken();
            AuthenticationTokenService.NSOfcCUZWyuLqVNxCle((object) authToken2, new Guid());
            authToken2.UserId = (long) AuthenticationTokenService.RA46kyUAoFfyeIhnJSH((object) user);
            AuthenticationTokenService.m06Y7LU775U6CjdVUqE((object) authToken2, AuthenticationTokenService.pderwcUsmiSynPRmYy5().Add(this.TokenDuration));
            authToken1 = authToken2;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 == 0 ? 1 : 2;
            continue;
          case 5:
            Contract.ArgumentNotNull((object) user, (string) AuthenticationTokenService.XugLqEUNi1sobu6Fjif(928696104 ^ 928700240));
            num = 4;
            continue;
          default:
            AuthenticationTokenService.s0fqTJUWwwlSMHjEKgm((object) this.authenticationServiceEventHandler, (object) user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b != 0 ? 3 : 0;
            continue;
        }
      }
label_7:
      return AuthenticationTokenService.LFho36UrTy0UYuAeY7F((object) authToken1);
    }

    /// <summary>Получить пользователя по токену</summary>
    /// <param name="token">Токен</param>
    /// <returns>Пользователь</returns>
    [Transaction]
    public virtual IUser GetUser(Guid token)
    {
      int num = 2;
      string key;
      AuthToken authToken;
      long? nullable;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.CacheService.TryGetValue<long?>(key, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1702973981 - 773209001 ^ 1818776134), out nullable))
            {
              authToken = this.Session.Get<AuthToken>((object) token);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 != 0 ? 4 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 9 : 7;
            continue;
          case 2:
            key = (string) AuthenticationTokenService.TkDErtUSZU54hxnQAq7(token);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_7;
          case 4:
            if (authToken != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 != 0 ? 6 : 1;
              continue;
            }
            goto label_11;
          case 5:
            goto label_5;
          case 6:
            if (!(AuthenticationTokenService.PklgPQUY1H7L1iga65n((object) authToken) < DateTime.Now))
            {
              num = 11;
              continue;
            }
            goto case 8;
          case 7:
            goto label_4;
          case 8:
            this.RemoveToken(authToken);
            num = 3;
            continue;
          case 9:
            if (nullable.HasValue)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 == 0 ? 5 : 1;
              continue;
            }
            goto label_4;
          case 10:
            goto label_11;
          case 11:
            this.TokenToCache(authToken);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (IUser) this.userManager.LoadOrNull(AuthenticationTokenService.xJ2eUkUy9kF1uxqKa6l((object) authToken));
label_4:
      return (IUser) null;
label_5:
      return (IUser) this.userManager.LoadOrNull(nullable.Value);
label_7:
      return (IUser) null;
label_11:
      return (IUser) null;
    }

    /// <summary>Удалить токен</summary>
    /// <param name="token">Токен</param>
    [Transaction]
    public virtual void RemoveToken(Guid token)
    {
      int num = 3;
      AuthToken authToken;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (authToken != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            authToken = this.Session.Load<AuthToken>((object) token);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 != 0 ? 2 : 2;
            continue;
          case 4:
            goto label_5;
          default:
            this.RemoveToken(authToken);
            num = 4;
            continue;
        }
      }
label_6:
      return;
label_5:
      return;
label_2:;
    }

    private void RemoveToken(AuthToken authToken)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          EleWise.ELMA.Security.Models.IUser user;
          string str;
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              goto label_10;
            case 3:
              AuthenticationTokenService.BR0NT9UfrRqZeB0gMwg((object) this.CacheService, (object) str, AuthenticationTokenService.XugLqEUNi1sobu6Fjif(1744916777 - 891549337 ^ 853375724));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 0 : 1;
              continue;
            case 4:
              this.authenticationServiceEventHandler.SignedOut((IUser) user);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 != 0 ? 0 : 0;
              continue;
            case 5:
              this.Session.CreateQuery(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1489118656 ^ 643054122 ^ -2123775806)).SetParameter<DateTime>((string) AuthenticationTokenService.XugLqEUNi1sobu6Fjif(-29763048 >> 5 ^ -921610), DateTime.Now.AddHours(-1.0)).SetParameter<Guid>((string) AuthenticationTokenService.XugLqEUNi1sobu6Fjif(617026523 ^ 617034487), AuthenticationTokenService.LFho36UrTy0UYuAeY7F((object) authToken)).ExecuteUpdate(false);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa == 0 ? 0 : 3;
              continue;
            case 6:
              if (user != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 4 : 2;
                continue;
              }
              break;
            case 7:
              user = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) AuthenticationTokenService.nPMKqJUVZIqDnq2fuoG()).LoadOrNull(AuthenticationTokenService.xJ2eUkUy9kF1uxqKa6l((object) authToken));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e != 0 ? 0 : 6;
              continue;
          }
          str = (string) AuthenticationTokenService.TkDErtUSZU54hxnQAq7(AuthenticationTokenService.LFho36UrTy0UYuAeY7F((object) authToken));
          num2 = 2;
        }
label_10:
        AuthenticationTokenService.X35kFpUlTDKBxRTZbkF((object) this.Session, (object) authToken);
        num1 = 5;
      }
label_3:;
    }

    private void TokenToCache(AuthToken authToken)
    {
      int num = 4;
      TimeSpan duration;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.TokenToCache(authToken, duration);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 == 0 ? 1 : 1;
            continue;
          case 3:
            duration = AuthenticationTokenService.PklgPQUY1H7L1iga65n((object) authToken) - AuthenticationTokenService.pderwcUsmiSynPRmYy5();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 0 : 0;
            continue;
          case 4:
            AuthenticationTokenService.Hk6PF8U47uKOOXDvJ5L((object) authToken, AuthenticationTokenService.XugLqEUNi1sobu6Fjif(84189367 + 1997579375 ^ 2081776656));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 == 0 ? 3 : 0;
            continue;
          default:
            if (AuthenticationTokenService.CVG7LTUcxCVJSF9jwvG(duration, TimeSpan.Zero))
            {
              num = 2;
              continue;
            }
            goto label_8;
        }
      }
label_2:
      return;
label_8:;
    }

    private void TokenToCache(AuthToken authToken, TimeSpan duration)
    {
      int num = 2;
      string key;
      while (true)
      {
        switch (num)
        {
          case 1:
            key = (string) AuthenticationTokenService.TkDErtUSZU54hxnQAq7(AuthenticationTokenService.LFho36UrTy0UYuAeY7F((object) authToken));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 0 : 0;
            continue;
          case 2:
            AuthenticationTokenService.Hk6PF8U47uKOOXDvJ5L((object) authToken, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2008710664 - -232311158 ^ -1776391592));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            this.CacheService.Insert<long>(key, authToken.UserId, (string) AuthenticationTokenService.XugLqEUNi1sobu6Fjif(-1807813747 ^ -1807821839), duration);
            num = 3;
            continue;
        }
      }
label_2:;
    }

    private TimeSpan TokenDuration => AuthenticationTokenService.CHhO2BUPDjCyLOuPTpI(EleWise.ELMA.SR.GetSetting<double>((string) AuthenticationTokenService.XugLqEUNi1sobu6Fjif(-757186336 ^ -757177940), 60.0));

    private ICacheService CacheService
    {
      get
      {
        int num1 = 5;
        AuthenticationTokenService authenticationTokenService;
        bool lockTaken;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_2;
            case 2:
              goto label_19;
            case 3:
              lockTaken = false;
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 == 0 ? 1 : 1;
              continue;
            case 4:
              authenticationTokenService = this;
              num1 = 3;
              continue;
            case 5:
              if (this.cacheService == null)
              {
                num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 == 0 ? 4 : 4;
                continue;
              }
              goto label_14;
            default:
              goto label_14;
          }
        }
label_2:
        ICacheService cacheService;
        try
        {
          Monitor.Enter((object) authenticationTokenService, ref lockTaken);
          int num2 = 2;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0)
            num2 = 2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_19;
              case 2:
                if (this.cacheService == null)
                {
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 != 0 ? 0 : 0;
                  continue;
                }
                goto case 3;
              case 3:
                cacheService = this.cacheService;
                num2 = 4;
                continue;
              case 4:
                goto label_20;
              default:
                this.cacheService = Locator.GetServiceNotNull<ICacheService>();
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e == 0 ? 1 : 1;
                continue;
            }
          }
        }
        finally
        {
          int num3;
          if (!lockTaken)
            num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 0 : 0;
          else
            goto label_12;
label_11:
          switch (num3)
          {
            case 1:
              break;
            default:
          }
label_12:
          AuthenticationTokenService.yBfJ4SUQFu7tVKurDfA((object) authenticationTokenService);
          num3 = 2;
          goto label_11;
        }
label_20:
        return cacheService;
label_14:
        return this.cacheService;
label_19:
        return this.cacheService;
      }
    }

    private ISession Session => this.sessionProvider.GetSession(string.Empty);

    private static string GetTokenCacheKey(Guid token) => AuthenticationTokenService.XugLqEUNi1sobu6Fjif(--1403802000 ^ 1403810020).ToString() + (object) token;

    internal static object XugLqEUNi1sobu6Fjif(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void mL0gBtU0qlckiJo6uxu([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool ksa6bSU3g6eR4dZvKcb() => AuthenticationTokenService.BERQPxUimneX6sjJBD6 == null;

    internal static AuthenticationTokenService gnPtRWUjqus3pdsxkaD() => AuthenticationTokenService.BERQPxUimneX6sjJBD6;

    internal static void NSOfcCUZWyuLqVNxCle([In] object obj0, Guid value) => ((AuthToken) obj0).Uid = value;

    internal static object RA46kyUAoFfyeIhnJSH([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static DateTime pderwcUsmiSynPRmYy5() => DateTime.Now;

    internal static void m06Y7LU775U6CjdVUqE([In] object obj0, DateTime value) => ((AuthToken) obj0).ExpireDate = value;

    internal static void s0fqTJUWwwlSMHjEKgm([In] object obj0, [In] object obj1) => ((IAuthenticationServiceEventHandler) obj0).SignedIn((IUser) obj1);

    internal static Guid LFho36UrTy0UYuAeY7F([In] object obj0) => ((AuthToken) obj0).Uid;

    internal static object TkDErtUSZU54hxnQAq7(Guid token) => (object) AuthenticationTokenService.GetTokenCacheKey(token);

    internal static DateTime PklgPQUY1H7L1iga65n([In] object obj0) => ((AuthToken) obj0).ExpireDate;

    internal static long xJ2eUkUy9kF1uxqKa6l([In] object obj0) => ((AuthToken) obj0).UserId;

    internal static object nPMKqJUVZIqDnq2fuoG() => (object) UserManager.Instance;

    internal static void X35kFpUlTDKBxRTZbkF([In] object obj0, [In] object obj1) => ((ISession) obj0).Delete(obj1);

    internal static void BR0NT9UfrRqZeB0gMwg([In] object obj0, [In] object obj1, [In] object obj2) => ((ICacheService) obj0).Remove((string) obj1, (string) obj2);

    internal static void Hk6PF8U47uKOOXDvJ5L([In] object obj0, [In] object obj1) => Contract.NotNull(obj0, (string) obj1);

    internal static bool CVG7LTUcxCVJSF9jwvG([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 > obj1;

    internal static TimeSpan CHhO2BUPDjCyLOuPTpI([In] double obj0) => TimeSpan.FromMinutes(obj0);

    internal static void yBfJ4SUQFu7tVKurDfA([In] object obj0) => Monitor.Exit(obj0);
  }
}

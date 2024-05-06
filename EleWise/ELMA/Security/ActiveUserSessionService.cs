// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.ActiveUserSessionService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Models.ActiveUserSession;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Transform;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Web;

namespace EleWise.ELMA.Security
{
  /// <summary>Сервис для работы с активными сессиями пользователей</summary>
  [Service(EnableInterceptors = false, InjectProperties = true, Scope = ServiceScope.Application, Type = EleWise.ELMA.ComponentModel.ComponentType.WebServer)]
  public sealed class ActiveUserSessionService : IInitHandler, IActiveUserSessionService
  {
    private readonly ILogger logger;
    private ITransformationProvider _transform;
    private ILockManager _lockManager;
    private ICacheService _cacheService;
    private readonly ReaderWriterLock _updateSessionsLock;
    private IContextBoundVariableService _contextService;
    private List<IAuthenticationServiceEventHandler> _authenticationServiceEventHandlers;
    private List<IAuthenticatedSessionEventHandler> _authenticatedSessionEventHandlers;
    private ISessionProvider sessionProvider;
    private UserManager userManager;
    private IUnitOfWorkManager unitOfWorkManager;
    private long _privilegeGroupId;
    private DateTime? _startTime;
    private DateTime? _lastUpdateTime;
    private static int? savingActivityTimeoutTime;
    private static TimeSpan _freezeTime;
    private static TimeSpan _removeOnPingTimeoutTime;
    private static TimeSpan? _removeOnActionTimeoutTime;
    private static TimeSpan? _removePrivilegedUsersTimeoutTime;
    private static readonly string CacheKey;
    private ConcurrentDictionary<Guid, AuthenticatedSessionInfo> sessionsToUpdate;
    private bool isPrivilegedLicense;
    private IInternalSecurityService internalSecurityService;
    private static ActiveUserSessionService geZmMpHvL7eFXbUSgv;

    /// <summary>Получить список сессий</summary>
    /// <param name="filter">Фильтр</param>
    /// <returns></returns>
    public IEnumerable<AuthenticatedSessionInfo> GetSessions(
      AuthenticatedSessionFilter filter)
    {
      using (new ActiveUserSessionService.SetTimeout(this))
      {
        List<AuthenticatedSessionInfo> sessions = new List<AuthenticatedSessionInfo>();
        string str = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2143851882 - 923330995 ^ 1227784761), (object) this._transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1212789817 - 1827404527 ^ 1254773688)), (object) this._transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.TicketUid), (object) this._transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.Status), (object) this._transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.Expiration), (object) this._transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.SessionId), (object) this._transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.UserId), (object) this._transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.RemoteAddress), (object) this._transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.CreationDate), (object) this._transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.LastActionDate), (object) this._transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.LastPingDate), (object) this._transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.LastActionInfo));
        Dictionary<string, object> paramValues = new Dictionary<string, object>();
        string sql;
        if (filter != null && filter.UserId != null)
        {
          sql = str + string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2110885667 - -1624984630 ^ -559097633), (object) this._transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.UserId), (object) this._transform.ParameterSeparator);
          paramValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-347045778 ^ -347045182)] = filter.UserId;
        }
        else
          sql = str + string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-404268492 ^ -404268666), (object) this._transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.UserId));
        if (filter != null && filter.OnlyActive)
        {
          sql += string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-169284490 ^ -169283692), (object) this._transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.Status), (object) this._transform.ParameterSeparator);
          paramValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1440374117 ^ -1440373061)] = (object) 0;
        }
        if (filter != null && !string.IsNullOrWhiteSpace(filter.SessionId))
        {
          sql += string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1940240517 ^ 974551502 ^ 1236518157), (object) this._transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.SessionId), (object) this._transform.ParameterSeparator);
          paramValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1254421137 >> 4 ^ -78400350)] = (object) filter.SessionId;
        }
        List<long> list = this.GetPrivilegeUserIds().ToList<long>();
        using (IDataReader r = this._transform.ExecuteQuery(sql, paramValues))
        {
          while (r.Read())
          {
            AuthenticatedSessionInfo authenticatedSessionInfo = this.ReadSessionInfo(r);
            if (filter == null || !filter.OnlyConcurrentUsers || !list.Contains((long) authenticatedSessionInfo.UserId))
              sessions.Add(authenticatedSessionInfo);
          }
        }
        return (IEnumerable<AuthenticatedSessionInfo>) sessions;
      }
    }

    /// <summary>
    /// Получить список идентификаторов привилегированных пользователей
    /// </summary>
    /// <returns></returns>
    public IEnumerable<long> GetPrivilegeUserIds() => this.GetPrivilegeUserIds(true);

    /// <summary>
    /// Получить список идентификаторов привилегированных пользователей
    /// </summary>
    /// <param name="includeAdmin">Включать ли Администратора ELMA в результат</param>
    /// <returns></returns>
    public IEnumerable<long> GetPrivilegeUserIds(bool includeAdmin)
    {
      using (new ActiveUserSessionService.SetTimeout(this))
      {
        List<long> privilegeUserIds = new List<long>();
        string sql = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1711335411 ^ -1711334265), (object) this._transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2008710664 - -232311158 ^ -1776399934)), (object) this._transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-206147790 ^ -206148932)), (object) this._transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(908197830 ^ 908196464)), (object) this._transform.ParameterSeparator, (object) this._transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-517128429 ^ -517129509)), (object) this._transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1076316568 ^ 1076317260)), (object) this._transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1743015995 ^ -1743017447)));
        Dictionary<string, object> paramValues = new Dictionary<string, object>()
        {
          {
            z2jc63fLkugS1X8Q9N.tE1kD1vbB(266768307 ^ 266766943),
            (object) this._privilegeGroupId
          },
          {
            z2jc63fLkugS1X8Q9N.tE1kD1vbB(789532496 ^ 1575286436 ^ 1928052706),
            (object) 0
          }
        };
        if (!includeAdmin)
        {
          sql += string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1331070742 ^ -1331069232), (object) this._transform.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1893095749 ^ -1893096423)), (object) this._transform.ParameterSeparator);
          paramValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-979995965 << 4 ^ 1499933252)] = (object) SecurityConstants.AdminUserUid;
        }
        using (IDataReader dataReader = this._transform.ExecuteQuery(sql, paramValues))
        {
          while (dataReader.Read())
            privilegeUserIds.Add(Convert.ToInt64(dataReader[0]));
        }
        return (IEnumerable<long>) privilegeUserIds;
      }
    }

    /// <summary>Получить сессию по идентификатору тиккета</summary>
    /// <param name="ticketId"></param>
    /// <returns></returns>
    public AuthenticatedSessionInfo Get(Guid ticketId)
    {
      int num1 = 3;
      ActiveUserSessionService.SetTimeout setTimeout;
      ActiveUserSessionService userSessionService;
      Guid ticketId1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            setTimeout = new ActiveUserSessionService.SetTimeout(this);
            num1 = 4;
            continue;
          case 2:
            userSessionService = this;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0 ? 0 : 0;
            continue;
          case 3:
            num1 = 2;
            continue;
          case 4:
            goto label_4;
          case 5:
            goto label_17;
          default:
            ticketId1 = ticketId;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff == 0 ? 1 : 1;
            continue;
        }
      }
label_4:
      AuthenticatedSessionInfo authenticatedSessionInfo1;
      try
      {
        string name = (string) ActiveUserSessionService.Pw6XTpww8IoFEtVtiVM((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(789532496 ^ 1575286436 ^ 1928052580), (object) ticketId1);
        int num2 = 2;
        while (true)
        {
          AuthenticatedSessionInfo authenticatedSessionInfo2;
          switch (num2)
          {
            case 1:
              goto label_17;
            case 2:
              if (this._contextService == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 != 0 ? 0 : 0;
                continue;
              }
              authenticatedSessionInfo2 = this._contextService.GetOrAdd<AuthenticatedSessionInfo>(name, (Func<AuthenticatedSessionInfo>) (() => userSessionService.LoadSessionInfo(ticketId1)));
              break;
            default:
              authenticatedSessionInfo2 = (AuthenticatedSessionInfo) null;
              break;
          }
          authenticatedSessionInfo1 = authenticatedSessionInfo2;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 1 : 1;
        }
      }
      finally
      {
        int num3;
        if (setTimeout == null)
          num3 = 2;
        else
          goto label_14;
label_13:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_14:
        ActiveUserSessionService.ii6MSDwb3so3xELcdh5((object) setTimeout);
        num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 == 0)
        {
          num3 = 0;
          goto label_13;
        }
        else
          goto label_13;
      }
label_17:
      return authenticatedSessionInfo1;
    }

    /// <summary>Найти сессию по идентификатору сессии</summary>
    /// <param name="sessionId"></param>
    /// <returns></returns>
    public AuthenticatedSessionInfo FindBySessionId(string sessionId)
    {
      int num1 = 2;
      ActiveUserSessionService.SetTimeout setTimeout;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            setTimeout = new ActiveUserSessionService.SetTimeout(this);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 1 : 0;
            continue;
          default:
            goto label_17;
        }
      }
label_2:
      AuthenticatedSessionInfo bySessionId;
      try
      {
        int num2;
        if (ActiveUserSessionService.y9KKDOwKn34GBOIJQMD((object) sessionId))
          num2 = 2;
        else
          goto label_6;
label_4:
        AuthenticatedSessionInfo authenticatedSessionInfo;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 5:
              goto label_17;
            case 2:
              bySessionId = (AuthenticatedSessionInfo) null;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 5 : 4;
              continue;
            case 3:
              goto label_6;
            case 4:
              bySessionId = authenticatedSessionInfo;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d != 0 ? 1 : 1;
              continue;
            default:
              ActiveUserSessionService.oUcgtPwaiyCWwxhJLA5((object) this.logger, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1100789287 - 1555711667 ^ -454924074), (object) new object[2]
              {
                (object) sessionId,
                authenticatedSessionInfo != null ? ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-801309555 ^ -801309861) : ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(1690209562 ^ 116876444 ^ 1649012320)
              });
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 != 0 ? 4 : 1;
              continue;
          }
        }
label_6:
        authenticatedSessionInfo = ((IQuery) ActiveUserSessionService.dE0Ns3wDy0fZhM3XCui(ActiveUserSessionService.TbyNpmwkvXxaV4xD07x(ActiveUserSessionService.Ve4bNsw6nTsFNlXlMos(ActiveUserSessionService.AmtOZnwmMnJgxDHeDr4(ActiveUserSessionService.UNertTwtBis37tHXuBE((object) this.SessionProvider.GetSession(string.Empty), (object) string.Format((string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-1640694811 << 2 ^ 2027153746), (object) ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1687460816 ^ 1687460016)), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc((object) this._transform.Dialect, (object) AuthenticatedSessionInfo.Db.Fields.SessionId), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.TicketUid), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc((object) this._transform.Dialect, (object) AuthenticatedSessionInfo.Db.Fields.Status), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.Expiration), (object) ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.UserId), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.RemoteAddress), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.CreationDate), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.LastActionDate), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.LastPingDate), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc((object) this._transform.Dialect, (object) AuthenticatedSessionInfo.Db.Fields.LastActionInfo))), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(1100789287 - 1555711667 ^ -454924042), (object) sessionId), (object) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(typeof (AuthenticatedSessionInfo))), 1), false)).UniqueResult<AuthenticatedSessionInfo>();
        num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c == 0)
        {
          num2 = 0;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        if (setTimeout != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                ActiveUserSessionService.ii6MSDwb3so3xELcdh5((object) setTimeout);
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 0 : 0;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
label_17:
      return bySessionId;
    }

    /// <summary>Попытаться добавить новую сессию</summary>
    /// <param name="sessionInfo">Информация о текущей сессии</param>
    /// <param name="user">Пользователь</param>
    public void Insert(AuthenticatedSessionInfo sessionInfo, EleWise.ELMA.Security.Models.IUser user)
    {
      int num1 = 4;
      ActiveUserSessionService.SetTimeout setTimeout;
      EleWise.ELMA.Security.Models.IUser user1;
      AuthenticatedSessionInfo sessionInfo1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_6;
          case 2:
            setTimeout = new ActiveUserSessionService.SetTimeout(this);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 != 0 ? 1 : 0;
            continue;
          case 3:
            user1 = user;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 != 0 ? 0 : 0;
            continue;
          case 4:
            num1 = 3;
            continue;
          case 5:
            goto label_43;
          default:
            sessionInfo1 = sessionInfo;
            num1 = 2;
            continue;
        }
      }
label_43:
      return;
label_6:
      try
      {
        int num2 = 17;
        while (true)
        {
          int num3 = num2;
          ActivePrivilegeUsersInfo privilegeUsersInfo;
          ActiveUsersSessionInfo otherUsersCount;
          int? nullable;
          int loginCount;
          bool isAdmin;
          int totalPrivelegeCount;
          int currentPrivelegeCount;
          int othersCount;
          while (true)
          {
            switch (num3)
            {
              case 1:
                currentPrivelegeCount = 0;
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 == 0 ? 8 : 0;
                continue;
              case 2:
                this.AuthenticationServiceEventHandlers.ForEach((Action<IAuthenticationServiceEventHandler>) (h =>
                {
                  int num4 = 1;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        ActiveUserSessionService.\u003C\u003Ec__DisplayClass5_0.iwvlfrwUxFWrXq7rxMja((object) h, (object) user1);
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_2:
                  return;
label_4:;
                }));
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 != 0 ? 16 : 22;
                continue;
              case 3:
                goto label_16;
              case 4:
                // ISSUE: reference to a compiler-generated method
                this.InternalSecurityService.CheckUserToAuthenticate(user1, (Func<bool>) (() => loginCount > 0), (Func<int, bool>) (maxPrivilegeCount =>
                {
                  int num5 = 2;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        goto label_7;
                      case 2:
                        if (isAdmin)
                        {
                          num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af == 0 ? 1 : 1;
                          continue;
                        }
                        break;
                      case 3:
                        goto label_6;
                    }
                    if (totalPrivelegeCount > maxPrivilegeCount)
                      num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff != 0 ? 3 : 1;
                    else
                      goto label_7;
                  }
label_6:
                  throw new LicenseException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(266768307 ^ 266838827)));
label_7:
                  return currentPrivelegeCount > 0;
                }), (Func<int>) (() => ActiveUserSessionService.\u003C\u003Ec__DisplayClass5_1.Wq6P8SwUNhTJSoyembgT(0, othersCount - currentPrivelegeCount)));
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a == 0 ? 11 : 2;
                continue;
              case 5:
                if (!isAdmin)
                {
                  num3 = 18;
                  continue;
                }
                goto case 25;
              case 6:
                nullable = privilegeUsersInfo.TotalPrivelegedCount;
                totalPrivelegeCount = nullable ?? totalPrivelegeCount;
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 24 : 13;
                continue;
              case 7:
                goto label_36;
              case 8:
                goto label_21;
              case 9:
                nullable = otherUsersCount.TotalLoginCount;
                othersCount = (!nullable.HasValue ? othersCount : nullable.GetValueOrDefault()) - loginCount;
                num3 = 4;
                continue;
              case 10:
                isAdmin = ActiveUserSessionService.EGfKj2wxFwZoIQW9ELx((object) user1) == SecurityConstants.AdminUserUid;
                num3 = 5;
                continue;
              case 11:
                ActiveUserSessionService.n1a10HwiH2l5veLw8h3((object) sessionInfo1, AuthenticatedSessionStatus.Active);
                num3 = 23;
                continue;
              case 12:
                this.UpsertSessionInfo(sessionInfo1);
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef != 0 ? 0 : 0;
                continue;
              case 13:
                ActiveUserSessionService.kFQvPkwN7Uu8H9HrtLp((object) this._contextService, ActiveUserSessionService.Pw6XTpww8IoFEtVtiVM(ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(554338340 ^ 554340020), (object) ActiveUserSessionService.IkLMlVwj9hQfjwEqGUd((object) sessionInfo1)), (object) sessionInfo1);
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 == 0 ? 3 : 3;
                continue;
              case 14:
                if (privilegeUsersInfo != null)
                {
                  num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af == 0 ? 4 : 6;
                  continue;
                }
                goto case 10;
              case 15:
                totalPrivelegeCount = 0;
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0 ? 1 : 0;
                continue;
              case 16:
              case 18:
                otherUsersCount = this.GetOtherUsersCount(sessionInfo1);
                num3 = 21;
                continue;
              case 17:
                if (sessionInfo1 != null)
                {
                  loginCount = 0;
                  num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc == 0 ? 15 : 10;
                  continue;
                }
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 != 0 ? 19 : 10;
                continue;
              case 19:
                goto label_26;
              case 20:
                privilegeUsersInfo = this.IsCurrentPrivilege(sessionInfo1, user1);
                num3 = 14;
                continue;
              case 21:
                if (otherUsersCount == null)
                  goto case 4;
                else
                  goto label_24;
              case 22:
                goto label_38;
              case 23:
                ActiveUserSessionService.YcJ8wuw3sL9X8RGWHnG((object) sessionInfo1, true);
                num3 = 12;
                continue;
              case 24:
                nullable = privilegeUsersInfo.CurrentPrivelegedCount;
                currentPrivelegeCount = nullable ?? currentPrivelegeCount;
                num3 = 10;
                continue;
              case 25:
                currentPrivelegeCount = ActiveUserSessionService.qxVC4gwC7fZI6PnA7Sb(1, currentPrivelegeCount);
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 16 : 9;
                continue;
              default:
                ActiveUserSessionService.YcJ8wuw3sL9X8RGWHnG((object) sessionInfo1, false);
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d == 0 ? 13 : 10;
                continue;
            }
          }
label_16:
          this.AuthenticatedSessionEventHandlers.ForEach((Action<IAuthenticatedSessionEventHandler>) (h =>
          {
            int num6 = 1;
            while (true)
            {
              switch (num6)
              {
                case 0:
                  goto label_2;
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  ActiveUserSessionService.\u003C\u003Ec__DisplayClass5_0.IIxuocwUabprXu5dpsCp((object) h, (object) user1, (object) sessionInfo1);
                  num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_4;
              }
            }
label_2:
            return;
label_4:;
          }));
          num2 = 2;
          continue;
label_21:
          othersCount = 0;
          num2 = 20;
          continue;
label_24:
          num2 = 7;
          continue;
label_36:
          nullable = otherUsersCount.LoginCount;
          loginCount = !nullable.HasValue ? loginCount : nullable.GetValueOrDefault();
          num2 = 9;
        }
label_38:
        return;
label_26:
        throw new ArgumentNullException((string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-1277802350 ^ -1277800596));
      }
      finally
      {
        if (setTimeout != null)
        {
          int num7 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0)
            num7 = 1;
          while (true)
          {
            switch (num7)
            {
              case 1:
                ActiveUserSessionService.ii6MSDwb3so3xELcdh5((object) setTimeout);
                num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec != 0 ? 0 : 0;
                continue;
              default:
                goto label_45;
            }
          }
        }
label_45:;
      }
    }

    /// <summary>Обновить параметры в информации о сессии</summary>
    /// <param name="sessionInfo"></param>
    /// <param name="httpContext"></param>
    public void SetUpdated(AuthenticatedSessionInfo sessionInfo, HttpContextBase httpContext)
    {
      int num1 = 2;
      ActiveUserSessionService.SetTimeout setTimeout;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_35;
          case 1:
            goto label_2;
          case 2:
            setTimeout = new ActiveUserSessionService.SetTimeout(this);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 != 0 ? 1 : 1;
            continue;
          default:
            goto label_29;
        }
      }
label_35:
      return;
label_29:
      return;
label_2:
      try
      {
        ActiveUserSessionService.ujmU4jw0gnr7s7xdZ4S((object) this._updateSessionsLock, 100);
        int num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              ActiveUserSessionService.TMF1xqwAyA279o6Z6i4((object) this.logger, ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(1212037053 ^ -1727812018 ^ -784494101), (object) new object[2]
              {
                (object) ActiveUserSessionService.IkLMlVwj9hQfjwEqGUd((object) sessionInfo),
                ActiveUserSessionService.jdA3Z5wZB0lRhahE33M((object) sessionInfo)
              });
              int num3 = 13;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 == 0)
                num3 = 3;
              while (true)
              {
                int num4;
                AuthenticatedSessionInfo authenticatedSessionInfo;
                string str;
                switch (num3)
                {
                  case 1:
                    this._contextService.Set((string) ActiveUserSessionService.Pw6XTpww8IoFEtVtiVM(ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(617710536 ^ 617710936), (object) ActiveUserSessionService.IkLMlVwj9hQfjwEqGUd((object) sessionInfo)), (object) sessionInfo);
                    num4 = 12;
                    break;
                  case 2:
                    Guid guid1 = ActiveUserSessionService.IkLMlVwj9hQfjwEqGUd((object) sessionInfo);
                    str = (string) ActiveUserSessionService.jdA3Z5wZB0lRhahE33M((object) sessionInfo);
                    ActiveUserSessionService.n4Mn9fwYsivxEuOKp8x((object) sessionInfo, (object) httpContext);
                    Guid guid2 = ActiveUserSessionService.IkLMlVwj9hQfjwEqGUd((object) sessionInfo);
                    if (!(guid1 == guid2))
                    {
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0 ? 8 : 0;
                      continue;
                    }
                    goto case 11;
                  case 3:
                    ActiveUserSessionService.oamNf1wSMq38hJNBOtM((object) sessionInfo, ActiveUserSessionService.vav07GwrAx4a5FZjMXP((object) authenticatedSessionInfo));
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0 ? 1 : 2;
                    continue;
                  case 4:
                  case 10:
                    this.sessionsToUpdate[ActiveUserSessionService.IkLMlVwj9hQfjwEqGUd((object) sessionInfo)] = sessionInfo;
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 1 : 1;
                    continue;
                  case 5:
                  case 8:
                    ActiveUserSessionService.oUcgtPwaiyCWwxhJLA5((object) this.logger, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-617657301 ^ -617659341), (object) new object[2]
                    {
                      (object) ActiveUserSessionService.IkLMlVwj9hQfjwEqGUd((object) sessionInfo),
                      ActiveUserSessionService.jdA3Z5wZB0lRhahE33M((object) sessionInfo)
                    });
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af == 0 ? 4 : 3;
                    continue;
                  case 6:
                    ActiveUserSessionService.xmg0T6wWAjxcYHquHXK((object) sessionInfo, ActiveUserSessionService.q9iJZ1wsQtsRjJg6IKf((object) authenticatedSessionInfo));
                    num4 = 3;
                    break;
                  case 7:
                    ActiveUserSessionService.TMF1xqwAyA279o6Z6i4((object) this.logger, ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(928696104 ^ 928698182), (object) new object[3]
                    {
                      (object) ActiveUserSessionService.IkLMlVwj9hQfjwEqGUd((object) sessionInfo),
                      (object) str,
                      ActiveUserSessionService.jdA3Z5wZB0lRhahE33M((object) sessionInfo)
                    });
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 == 0 ? 0 : 0;
                    continue;
                  case 9:
                    if (ActiveUserSessionService.IaDA7Fw7lLSdsLwDPxK(ActiveUserSessionService.q9iJZ1wsQtsRjJg6IKf((object) authenticatedSessionInfo), ActiveUserSessionService.q9iJZ1wsQtsRjJg6IKf((object) sessionInfo)))
                    {
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0 ? 0 : 6;
                      continue;
                    }
                    goto case 2;
                  case 11:
                    if (str != sessionInfo.SessionId)
                    {
                      num3 = 7;
                      continue;
                    }
                    goto case 5;
                  case 12:
                    goto label_25;
                  case 13:
                    if (this.sessionsToUpdate.TryGetValue(ActiveUserSessionService.IkLMlVwj9hQfjwEqGUd((object) sessionInfo), out authenticatedSessionInfo))
                    {
                      num3 = 9;
                      continue;
                    }
                    goto case 2;
                  default:
                    this.UpsertSessionInfo(sessionInfo);
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 != 0 ? 10 : 8;
                    continue;
                }
                num3 = num4;
              }
label_25:
              break;
            }
            finally
            {
              ActiveUserSessionService.xHdOIewypW0aLuuXIbq((object) this._updateSessionsLock);
              int num5 = 0;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 != 0)
                num5 = 0;
              switch (num5)
              {
                default:
              }
            }
        }
      }
      finally
      {
        if (setTimeout != null)
        {
          int num6 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0)
            num6 = 1;
          while (true)
          {
            switch (num6)
            {
              case 1:
                ActiveUserSessionService.ii6MSDwb3so3xELcdh5((object) setTimeout);
                num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 == 0 ? 0 : 0;
                continue;
              default:
                goto label_37;
            }
          }
        }
label_37:;
      }
    }

    /// <summary>Удалить авторизованную сессию</summary>
    /// <param name="ticketId"></param>
    public void RemoveSession(Guid ticketId)
    {
      int num1 = 1;
      ActiveUserSessionService.SetTimeout setTimeout;
      while (true)
      {
        switch (num1)
        {
          case 1:
            setTimeout = new ActiveUserSessionService.SetTimeout(this);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_20;
          default:
            goto label_3;
        }
      }
label_20:
      return;
label_3:
      try
      {
        int num2 = 3;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 != 0)
          num2 = 3;
        EleWise.ELMA.Security.Models.IUser user;
        AuthenticatedSessionInfo session;
        while (true)
        {
          switch (num2)
          {
            case 1:
              user = this.UserManager.Load(ActiveUserSessionService.imP64EwP8A1T2kdJqsw(ActiveUserSessionService.o3uVt6wcsBlrPpYFqLA((object) session)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0 ? 0 : 6;
              continue;
            case 2:
              ActiveUserSessionService.TMF1xqwAyA279o6Z6i4((object) this.logger, ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-1424960806 ^ -1424958968), (object) new object[2]
              {
                (object) ticketId,
                ActiveUserSessionService.jdA3Z5wZB0lRhahE33M((object) session)
              });
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 0 : 0;
              continue;
            case 3:
              session = this.Get(ticketId);
              num2 = 4;
              continue;
            case 4:
              if (session == null)
              {
                num2 = 5;
                continue;
              }
              goto case 2;
            case 5:
              goto label_18;
            case 6:
              this.AuthenticatedSessionEventHandlers.ForEach((Action<IAuthenticatedSessionEventHandler>) (h =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      ActiveUserSessionService.\u003C\u003Ec__DisplayClass7_0.gpm11OwU7nZumkjO4h8m((object) h, (object) user, (object) session);
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0 ? 6 : 7;
              continue;
            case 7:
              goto label_14;
            default:
              ActiveUserSessionService.mA3YrJw46rjpZqFZqX3(ActiveUserSessionService.V9YNOUwf40i39sYOvTM(ActiveUserSessionService.UNertTwtBis37tHXuBE(ActiveUserSessionService.Ug9nuawVUwJQqpurqpM((object) this.SessionProvider, (object) string.Empty), ActiveUserSessionService.qPCCi3wlWxv0frL7jom((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-624171910 - 757669187 ^ -1381839335), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(447286529 ^ 447286881)), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.TicketUid))), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(44166125 ^ 44163689), ticketId), false);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa == 0 ? 1 : 1;
              continue;
          }
        }
label_18:
        return;
label_14:;
      }
      finally
      {
        int num4;
        if (setTimeout == null)
          num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 != 0 ? 0 : 0;
        else
          goto label_19;
label_17:
        switch (num4)
        {
          case 1:
            break;
          default:
        }
label_19:
        setTimeout.Dispose();
        num4 = 2;
        goto label_17;
      }
    }

    /// <summary>
    /// Удалить все авторизованные сессии указанного пользователя
    /// </summary>
    /// <param name="userId">Идентификатор пользователя</param>
    public void RemoveAllUserSessions(object userId)
    {
      int num1 = 1;
      ActiveUserSessionService.SetTimeout setTimeout;
      while (true)
      {
        switch (num1)
        {
          case 1:
            setTimeout = new ActiveUserSessionService.SetTimeout(this);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_31;
          default:
            goto label_3;
        }
      }
label_31:
      return;
label_3:
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ActiveUserSessionService.\u003C\u003Ec__DisplayClass8_0 cDisplayClass80 = new ActiveUserSessionService.\u003C\u003Ec__DisplayClass8_0();
        int num2 = 4;
        IEnumerable<AuthenticatedSessionInfo> sessions;
        IEnumerator<AuthenticatedSessionInfo> enumerator;
        long int64;
        while (true)
        {
          switch (num2)
          {
            case 1:
              AuthenticatedSessionFilter filter = new AuthenticatedSessionFilter();
              ActiveUserSessionService.A2u8NxwQnxHZ1dWDWX4((object) filter, (object) int64);
              sessions = this.GetSessions(filter);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0 ? 6 : 4;
              continue;
            case 2:
              try
              {
label_10:
                if (ActiveUserSessionService.VfBIbCw89lSNOkea4MV((object) enumerator))
                  goto label_13;
                else
                  goto label_11;
label_9:
                // ISSUE: variable of a compiler-generated type
                ActiveUserSessionService.\u003C\u003Ec__DisplayClass8_1 cDisplayClass81;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_13;
                    case 2:
                      goto label_10;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      this.AuthenticatedSessionEventHandlers.ForEach(new Action<IAuthenticatedSessionEventHandler>(cDisplayClass81.\u003CRemoveAllUserSessions\u003Eb__0));
                      num3 = 2;
                      continue;
                    case 4:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass81.CS\u0024\u003C\u003E8__locals1 = cDisplayClass80;
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0 ? 0 : 0;
                      continue;
                    case 5:
                      goto label_23;
                    default:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass81.sessionInfo = enumerator.Current;
                      num3 = 3;
                      continue;
                  }
                }
label_11:
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0 ? 3 : 5;
                goto label_9;
label_13:
                // ISSUE: object of a compiler-generated type is created
                cDisplayClass81 = new ActiveUserSessionService.\u003C\u003Ec__DisplayClass8_1();
                num3 = 4;
                goto label_9;
              }
              finally
              {
                int num4;
                if (enumerator == null)
                  num4 = 2;
                else
                  goto label_19;
label_18:
                switch (num4)
                {
                  case 1:
                    break;
                  default:
                }
label_19:
                ActiveUserSessionService.ii6MSDwb3so3xELcdh5((object) enumerator);
                num4 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 == 0)
                {
                  num4 = 0;
                  goto label_18;
                }
                else
                  goto label_18;
              }
            case 3:
label_23:
              ActiveUserSessionService.mA3YrJw46rjpZqFZqX3(ActiveUserSessionService.sFbB71w5uPGl9ZRh1B6(ActiveUserSessionService.UNertTwtBis37tHXuBE(ActiveUserSessionService.Ug9nuawVUwJQqpurqpM((object) this.SessionProvider, (object) string.Empty), ActiveUserSessionService.qPCCi3wlWxv0frL7jom(ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(868767899 ^ 868766067), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-1257514304 ^ -1257514592)), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.UserId))), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1324692970 << 3 ^ -2007606646), int64), false);
              num2 = 5;
              continue;
            case 4:
              int64 = Convert.ToInt64(userId);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d != 0 ? 7 : 5;
              continue;
            case 5:
              goto label_26;
            case 6:
              ActiveUserSessionService.TMF1xqwAyA279o6Z6i4((object) this.logger, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1254421137 >> 4 ^ -78399116), (object) new object[1]
              {
                (object) int64
              });
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 != 0 ? 0 : 0;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass80.user = this.UserManager.Load(int64);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 == 0 ? 1 : 1;
              continue;
            default:
              enumerator = sessions.GetEnumerator();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc == 0 ? 2 : 0;
              continue;
          }
        }
label_26:;
      }
      finally
      {
        if (setTimeout != null)
        {
          int num5 = 1;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0)
            num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                ActiveUserSessionService.ii6MSDwb3so3xELcdh5((object) setTimeout);
                num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 == 0 ? 0 : 0;
                continue;
              default:
                goto label_33;
            }
          }
        }
label_33:;
      }
    }

    private AuthenticatedSessionInfo LoadSessionInfo(Guid ticketId) => ((IQuery) ActiveUserSessionService.dE0Ns3wDy0fZhM3XCui((object) ((IQuery) ActiveUserSessionService.V9YNOUwf40i39sYOvTM(ActiveUserSessionService.UNertTwtBis37tHXuBE((object) this.SessionProvider.GetSession(string.Empty), ActiveUserSessionService.MKCVWywdpZTsSgDvVSW(ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(1124861159 ^ 1124863667), (object) new object[11]
    {
      ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(~-192923496 ^ 192922631)),
      ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.TicketUid),
      (object) ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.Status),
      ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.Expiration),
      ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.SessionId),
      (object) this._transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.UserId),
      ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.RemoteAddress),
      ActiveUserSessionService.DL6FohwoU3jt7yGd7kc((object) this._transform.Dialect, (object) AuthenticatedSessionInfo.Db.Fields.CreationDate),
      ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.LastActionDate),
      (object) ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.LastPingDate),
      (object) ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.LastActionInfo)
    })), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-29763048 >> 5 ^ -932012), ticketId)).SetMaxResults(1), false)).SetResultTransformer((IResultTransformer) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(ActiveUserSessionService.vGacnDwEg9p0hK1cGsl(__typeref (AuthenticatedSessionInfo)))).UniqueResult<AuthenticatedSessionInfo>();

    private AuthenticatedSessionInfo ReadSessionInfo(IDataReader r)
    {
      AuthenticatedSessionInfo authenticatedSessionInfo = new AuthenticatedSessionInfo();
      ActiveUserSessionService.koru7DwXXuBZd1nOJCU((object) authenticatedSessionInfo, ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).GetGuid(ActiveUserSessionService.noybgMwGtU36hsLejJJ((object) r, (object) AuthenticatedSessionInfo.Db.Fields.TicketUid)));
      ActiveUserSessionService.n1a10HwiH2l5veLw8h3((object) authenticatedSessionInfo, r[AuthenticatedSessionInfo.Db.Fields.Status] is DBNull ? AuthenticatedSessionStatus.Active : (AuthenticatedSessionStatus) Convert.ToInt32(ActiveUserSessionService.noybgMwGtU36hsLejJJ((object) r, (object) AuthenticatedSessionInfo.Db.Fields.Status)));
      authenticatedSessionInfo.Expiration = !(ActiveUserSessionService.noybgMwGtU36hsLejJJ((object) r, (object) AuthenticatedSessionInfo.Db.Fields.Expiration) is DBNull) ? (DateTime?) ActiveUserSessionService.noybgMwGtU36hsLejJJ((object) r, (object) AuthenticatedSessionInfo.Db.Fields.Expiration) : new DateTime?();
      ActiveUserSessionService.qBvWgiw9NENxbgMZ3We((object) authenticatedSessionInfo, r[AuthenticatedSessionInfo.Db.Fields.SessionId] is DBNull ? (object) (string) null : (object) (string) r[AuthenticatedSessionInfo.Db.Fields.SessionId]);
      authenticatedSessionInfo.UserId = (object) (ActiveUserSessionService.noybgMwGtU36hsLejJJ((object) r, (object) AuthenticatedSessionInfo.Db.Fields.UserId) is DBNull ? 0L : Convert.ToInt64(ActiveUserSessionService.noybgMwGtU36hsLejJJ((object) r, (object) AuthenticatedSessionInfo.Db.Fields.UserId)));
      ActiveUserSessionService.TwWLsPw1HxyN8oDGXuw((object) authenticatedSessionInfo, ActiveUserSessionService.noybgMwGtU36hsLejJJ((object) r, (object) AuthenticatedSessionInfo.Db.Fields.RemoteAddress) is DBNull ? (object) (string) null : (object) (string) ActiveUserSessionService.noybgMwGtU36hsLejJJ((object) r, (object) AuthenticatedSessionInfo.Db.Fields.RemoteAddress));
      ActiveUserSessionService.qQuUdNwMadhKuVx0Urp((object) authenticatedSessionInfo, (DateTime) ActiveUserSessionService.noybgMwGtU36hsLejJJ((object) r, (object) AuthenticatedSessionInfo.Db.Fields.CreationDate));
      ActiveUserSessionService.xmg0T6wWAjxcYHquHXK((object) authenticatedSessionInfo, r[AuthenticatedSessionInfo.Db.Fields.LastActionDate] is DBNull ? ActiveUserSessionService.pCw5CUwhn0VyWpd4KlF(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)) : (DateTime) r[AuthenticatedSessionInfo.Db.Fields.LastActionDate]);
      ActiveUserSessionService.bWdOMOwB55QsbM9GSHZ((object) authenticatedSessionInfo, (DateTime) ActiveUserSessionService.noybgMwGtU36hsLejJJ((object) r, (object) AuthenticatedSessionInfo.Db.Fields.LastPingDate));
      ActiveUserSessionService.oamNf1wSMq38hJNBOtM((object) authenticatedSessionInfo, ActiveUserSessionService.noybgMwGtU36hsLejJJ((object) r, (object) AuthenticatedSessionInfo.Db.Fields.LastActionInfo) is DBNull ? (object) (string) null : (object) (string) r[AuthenticatedSessionInfo.Db.Fields.LastActionInfo]);
      return authenticatedSessionInfo;
    }

    private void UpdateSessionInfo(AuthenticatedSessionInfo sessionInfo)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (sessionInfo != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          case 3:
            goto label_6;
          default:
            this._transform.Update((string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-1331070742 ^ -1331070070), new string[7]
            {
              AuthenticatedSessionInfo.Db.Fields.Expiration,
              AuthenticatedSessionInfo.Db.Fields.LastActionDate,
              AuthenticatedSessionInfo.Db.Fields.LastActionInfo,
              AuthenticatedSessionInfo.Db.Fields.LastPingDate,
              AuthenticatedSessionInfo.Db.Fields.RemoteAddress,
              AuthenticatedSessionInfo.Db.Fields.SessionId,
              AuthenticatedSessionInfo.Db.Fields.UserId
            }, new object[7]
            {
              (object) new ParameterValue(sessionInfo.Expiration, false),
              !ActiveUserSessionService.z2eaTtwpREKlA1SkLSq((object) sessionInfo) ? (object) new ParameterValue(new DateTime?(sessionInfo.LastActionDate), false) : (object) new SqlExpressionParameter((string) ActiveUserSessionService.epThfCwOk6A54f8Ttt4(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform))),
              ActiveUserSessionService.vav07GwrAx4a5FZjMXP((object) sessionInfo),
              !sessionInfo.LastPingIsCurrent ? (object) new ParameterValue(new DateTime?(sessionInfo.LastPingDate), false) : (object) new SqlExpressionParameter((string) ActiveUserSessionService.epThfCwOk6A54f8Ttt4(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform))),
              (object) sessionInfo.RemoteAddress,
              ActiveUserSessionService.jdA3Z5wZB0lRhahE33M((object) sessionInfo),
              ActiveUserSessionService.o3uVt6wcsBlrPpYFqLA((object) sessionInfo)
            }, (string) ActiveUserSessionService.qPCCi3wlWxv0frL7jom(ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(1687460816 ^ 1687458014), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.TicketUid), ActiveUserSessionService.qPTm2ZwTjYxOQY8q2U5((object) this._transform)), new Dictionary<string, object>()
            {
              {
                (string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(2110885667 - -1624984630 ^ -559099171),
                (object) ActiveUserSessionService.IkLMlVwj9hQfjwEqGUd((object) sessionInfo)
              }
            });
            num = 3;
            continue;
        }
      }
label_6:
      return;
label_4:
      throw new ArgumentNullException((string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-1893095749 ^ -1893097147));
    }

    private void FlushUpdatedSessions()
    {
      int num1 = 1;
      ActiveUserSessionService.SetTimeout setTimeout;
      while (true)
      {
        switch (num1)
        {
          case 1:
            setTimeout = new ActiveUserSessionService.SetTimeout(this);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_143;
          default:
            goto label_2;
        }
      }
label_143:
      return;
label_2:
      try
      {
        DateTime dateTime1 = ActiveUserSessionService.ag1GJXwFPogtWHwQTGr();
        int num2 = 23;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0)
          num2 = 56;
        while (true)
        {
          int num3;
          DateTime? nullable1;
          DateTime dateTime2;
          string str1;
          string str2;
          string str3;
          TimeSpan timeSpan1;
          TimeSpan timeSpan2;
          string str4;
          IEnumerator<AuthenticatedSessionInfo> enumerator1;
          TimeSpan? nullable2;
          IList<AuthenticatedSessionInfo> collection;
          DateTime? nullable3;
          TimeSpan? nullable4;
          int num4;
          TimeSpan? nullable5;
          IList<AuthenticatedSessionInfo> removeSessionsInfo;
          ConcurrentDictionary<long, List<AuthenticatedSessionInfo>> sessionClosedUsersIds;
          Dictionary<long, EleWise.ELMA.Security.Models.IUser> users;
          ConcurrentDictionary<Guid, AuthenticatedSessionInfo> sessionInfos;
          ActiveUserSessionService userSessionService;
          switch (num2)
          {
            case 1:
              num2 = 35;
              continue;
            case 2:
              try
              {
label_66:
                if (enumerator1.MoveNext())
                  goto label_68;
                else
                  goto label_67;
label_61:
                int num5;
                AuthenticatedSessionInfo sessionInfo;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      sessionInfo = enumerator1.Current;
                      num5 = 3;
                      continue;
                    case 2:
                      goto label_66;
                    case 3:
                      this.logger.DebugFormat((string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(1658561670 << 4 ^ 767182262), (object) ActiveUserSessionService.IkLMlVwj9hQfjwEqGUd((object) sessionInfo), ActiveUserSessionService.jdA3Z5wZB0lRhahE33M((object) sessionInfo));
                      num5 = 4;
                      continue;
                    case 4:
                      ActiveUserSessionService.mA3YrJw46rjpZqFZqX3(ActiveUserSessionService.V9YNOUwf40i39sYOvTM(ActiveUserSessionService.TTcgiWwzB7fL9Rkxc8j((object) this.sessionProvider.GetSession(string.Empty).CreateSQLQuery((string) ActiveUserSessionService.zrsUa9bw43cHSicrngl((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(84189367 + 1997579375 ^ 2081770354), (object) this._transform.Dialect.QuoteIfNeeded((string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(1200636245 >> 6 ^ 18760293)), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.Status), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc((object) this._transform.Dialect, (object) AuthenticatedSessionInfo.Db.Fields.TicketUid))), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(334323849 << 5 ^ 2108431516), 1), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(2016571091 >> 5 ^ 63020452), sessionInfo.TicketUid), false);
                      num5 = 5;
                      continue;
                    case 5:
                      sessionClosedUsersIds.AddOrUpdate(ActiveUserSessionService.imP64EwP8A1T2kdJqsw(ActiveUserSessionService.o3uVt6wcsBlrPpYFqLA((object) sessionInfo)), (Func<long, List<AuthenticatedSessionInfo>>) (v => new List<AuthenticatedSessionInfo>()
                      {
                        sessionInfo
                      }), (Func<long, List<AuthenticatedSessionInfo>, List<AuthenticatedSessionInfo>>) ((v, list) =>
                      {
                        list.Add(sessionInfo);
                        return list;
                      }));
                      num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 2 : 2;
                      continue;
                    case 6:
                      goto label_86;
                    default:
                      goto label_68;
                  }
                }
label_67:
                num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0 ? 0 : 6;
                goto label_61;
label_68:
                num5 = 1;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 == 0)
                {
                  num5 = 1;
                  goto label_61;
                }
                else
                  goto label_61;
              }
              finally
              {
                int num6;
                if (enumerator1 == null)
                  num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e == 0 ? 1 : 1;
                else
                  goto label_73;
label_72:
                switch (num6)
                {
                  case 1:
                  case 2:
                }
label_73:
                ActiveUserSessionService.ii6MSDwb3so3xELcdh5((object) enumerator1);
                num6 = 2;
                goto label_72;
              }
            case 3:
              collection.RemoveAll<AuthenticatedSessionInfo>((Func<AuthenticatedSessionInfo, bool>) (sessionInfo =>
              {
                int num7 = 1;
                AuthenticatedSessionInfo sessionInfo1;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_3;
                    default:
                      sessionInfo1 = sessionInfo;
                      num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0 ? 0 : 2;
                      continue;
                  }
                }
label_3:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return removeSessionsInfo.FirstOrDefault<AuthenticatedSessionInfo>((Func<AuthenticatedSessionInfo, bool>) (info => ActiveUserSessionService.\u003C\u003Ec__DisplayClass12_2.u14h3VwUORXPsjK5g8Ko(ActiveUserSessionService.\u003C\u003Ec__DisplayClass12_2.YUbdGlwUpsKrRWETolof((object) info), ActiveUserSessionService.\u003C\u003Ec__DisplayClass12_2.YUbdGlwUpsKrRWETolof((object) sessionInfo1)))) != null;
              }));
              num3 = 17;
              break;
            case 4:
              str1 = (string) ActiveUserSessionService.MKCVWywdpZTsSgDvVSW(ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-296013529 ^ -296011235), (object) new object[13]
              {
                ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(1458233619 ^ 1458233971)),
                (object) ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.LastPingDate),
                ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.Expiration),
                ActiveUserSessionService.epThfCwOk6A54f8Ttt4((object) this._transform.Dialect),
                ActiveUserSessionService.ueeEJqw21EuL5syHIWc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).ConfigurationInfoCurrentTimestamp, ActiveUserSessionService.Pw6XTpww8IoFEtVtiVM((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1859356887 ^ -1859355889), (object) ActiveUserSessionService._removeOnPingTimeoutTime.TotalSeconds)),
                ActiveUserSessionService.DL6FohwoU3jt7yGd7kc((object) this._transform.Dialect, (object) AuthenticatedSessionInfo.Db.Fields.TicketUid),
                ActiveUserSessionService.DL6FohwoU3jt7yGd7kc((object) this._transform.Dialect, (object) AuthenticatedSessionInfo.Db.Fields.Status),
                ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.SessionId),
                (object) ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.UserId),
                (object) ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.RemoteAddress),
                ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.CreationDate),
                ActiveUserSessionService.DL6FohwoU3jt7yGd7kc((object) this._transform.Dialect, (object) AuthenticatedSessionInfo.Db.Fields.LastActionDate),
                ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.LastActionInfo)
              });
              num2 = 42;
              continue;
            case 5:
              dateTime2 = dateTime1;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0 ? 28 : 3;
              continue;
            case 6:
              nullable2 = new TimeSpan?();
              num3 = 34;
              break;
            case 7:
              if (!ActiveUserSessionService.txLXuAwnpi4RVTBEVpy(timeSpan1, ActiveUserSessionService._freezeTime))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 != 0 ? 42 : 47;
                continue;
              }
              goto case 46;
            case 8:
label_86:
              enumerator1 = removeSessionsInfo.GetEnumerator();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 == 0 ? 28 : 44;
              continue;
            case 9:
              this.AuthenticatedSessionEventHandlers.ForEach((Action<IAuthenticatedSessionEventHandler>) (handler =>
              {
                int num8 = 4;
                IEnumerator<KeyValuePair<long, List<AuthenticatedSessionInfo>>> enumerator2;
                // ISSUE: variable of a compiler-generated type
                ActiveUserSessionService.\u003C\u003Ec__DisplayClass12_6 cDisplayClass126;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      enumerator2 = sessionClosedUsersIds.GetEnumerator();
                      num8 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_20;
                    case 3:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass126.handler = handler;
                      num8 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 == 0 ? 1 : 1;
                      continue;
                    case 4:
                      // ISSUE: object of a compiler-generated type is created
                      cDisplayClass126 = new ActiveUserSessionService.\u003C\u003Ec__DisplayClass12_6();
                      num8 = 3;
                      continue;
                    default:
                      goto label_2;
                  }
                }
label_20:
                return;
label_2:
                try
                {
label_13:
                  // ISSUE: reference to a compiler-generated method
                  if (ActiveUserSessionService.\u003C\u003Ec__DisplayClass12_3.BebscswUgCNosYO6i8xp((object) enumerator2))
                    goto label_6;
                  else
                    goto label_14;
label_4:
                  // ISSUE: variable of a compiler-generated type
                  ActiveUserSessionService.\u003C\u003Ec__DisplayClass12_7 cDisplayClass127;
                  KeyValuePair<long, List<AuthenticatedSessionInfo>> current;
                  int num9;
                  while (true)
                  {
                    switch (num9)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        current.Value.ForEach(new Action<AuthenticatedSessionInfo>(cDisplayClass127.\u003CFlushUpdatedSessions\u003Eb__11));
                        num9 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0 ? 0 : 0;
                        continue;
                      case 2:
                        // ISSUE: reference to a compiler-generated field
                        cDisplayClass127.user = (EleWise.ELMA.Security.Models.IUser) null;
                        num9 = 6;
                        continue;
                      case 3:
                        goto label_6;
                      case 4:
                        // ISSUE: reference to a compiler-generated field
                        cDisplayClass127.CS\u0024\u003C\u003E8__locals1 = cDisplayClass126;
                        num9 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 != 0 ? 0 : 2;
                        continue;
                      case 5:
                        goto label_15;
                      case 6:
                        // ISSUE: reference to a compiler-generated field
                        if (users.TryGetValue(current.Key, out cDisplayClass127.user))
                        {
                          num9 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 != 0 ? 0 : 1;
                          continue;
                        }
                        goto label_13;
                      case 7:
                        // ISSUE: object of a compiler-generated type is created
                        cDisplayClass127 = new ActiveUserSessionService.\u003C\u003Ec__DisplayClass12_7();
                        num9 = 4;
                        continue;
                      default:
                        goto label_13;
                    }
                  }
label_15:
                  return;
label_6:
                  current = enumerator2.Current;
                  num9 = 3;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f == 0)
                  {
                    num9 = 7;
                    goto label_4;
                  }
                  else
                    goto label_4;
label_14:
                  num9 = 5;
                  goto label_4;
                }
                finally
                {
                  if (enumerator2 != null)
                  {
                    int num10 = 1;
                    if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 != 0)
                      num10 = 1;
                    while (true)
                    {
                      switch (num10)
                      {
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          ActiveUserSessionService.\u003C\u003Ec__DisplayClass12_3.rux8OXwUJIQeEQs0dmi1((object) enumerator2);
                          num10 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_22;
                      }
                    }
                  }
label_22:;
                }
              }));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 == 0 ? 3 : 10;
              continue;
            case 10:
              if (ActiveUserSessionService.TtWGjZbbTp2qlI0EWjK((object) users) > 0)
              {
                num2 = 68;
                continue;
              }
              goto label_123;
            case 11:
            case 16:
            case 62:
              if (ActiveUserSessionService._removePrivilegedUsersTimeoutTime.HasValue)
              {
                num2 = 32;
                continue;
              }
              goto case 40;
            case 12:
              this._startTime = new DateTime?(dateTime1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e != 0 ? 65 : 44;
              continue;
            case 13:
              if (timeSpan1 > ActiveUserSessionService._removeOnActionTimeoutTime.Value)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 != 0 ? 7 : 48;
                continue;
              }
              goto case 49;
            case 14:
              num4 = 0;
              goto label_132;
            case 15:
              if (!ActiveUserSessionService.v2kP7UwJxEiKWNGMnBV(ActiveUserSessionService.DCJLYCwvEw0Tvm764hV(dateTime1, this._lastUpdateTime.Value), ActiveUserSessionService.YqZAP7wgi9EF7hJJCe0((double) ActiveUserSessionService.n28jfewqLWH5KXNHhMV())))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 == 0 ? 44 : 57;
                continue;
              }
              goto default;
            case 17:
              if (ActiveUserSessionService.TvFypmbuehI9ndkTdKA((object) collection) <= 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 20 : 41;
                continue;
              }
              goto case 45;
            case 18:
            case 29:
              if (!this.isPrivilegedLicense)
              {
                num2 = 20;
                continue;
              }
              goto case 61;
            case 19:
            case 20:
              str1 = (string) ActiveUserSessionService.jp1YwLwHCH4yLbNcImp((object) str1, ActiveUserSessionService.qPCCi3wlWxv0frL7jom((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1880054609 ^ -1880053713), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.LastActionDate), (object) str4));
              num2 = 62;
              continue;
            case 21:
              userSessionService = this;
              num3 = 54;
              break;
            case 22:
              if (ActiveUserSessionService._removeOnActionTimeoutTime.HasValue)
              {
                num2 = 33;
                continue;
              }
              goto case 11;
            case 23:
              timeSpan2 = ActiveUserSessionService.sj85inwLEDEQv74Eijq(1.0);
              num2 = 64;
              continue;
            case 24:
              try
              {
                sessionInfos = this.sessionsToUpdate;
                int num11 = 1;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 == 0)
                  num11 = 1;
                while (true)
                {
                  switch (num11)
                  {
                    case 1:
                      this.sessionsToUpdate = new ConcurrentDictionary<Guid, AuthenticatedSessionInfo>();
                      num11 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_48;
                  }
                }
              }
              finally
              {
                ActiveUserSessionService.Msi3NWwe8alN7T8e9ei((object) this._updateSessionsLock);
                int num12 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af == 0)
                  num12 = 0;
                switch (num12)
                {
                  default:
                }
              }
            case 25:
              if (!nullable3.HasValue)
              {
                num2 = 6;
                continue;
              }
              nullable5 = new TimeSpan?(ActiveUserSessionService.DCJLYCwvEw0Tvm764hV(dateTime2, nullable3.GetValueOrDefault()));
              goto label_130;
            case 26:
              if (!this.isPrivilegedLicense)
              {
                num2 = 29;
                continue;
              }
              goto case 67;
            case 27:
            case 57:
              if (!this._startTime.HasValue)
              {
                num2 = 12;
                continue;
              }
              goto case 65;
            case 28:
              nullable3 = nullable1;
              num2 = 25;
              continue;
            case 30:
              if (ActiveUserSessionService._removeOnActionTimeoutTime.HasValue)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 5 : 13;
                continue;
              }
              goto case 49;
            case 31:
              str1 = (string) ActiveUserSessionService.jp1YwLwHCH4yLbNcImp((object) str1, ActiveUserSessionService.MKCVWywdpZTsSgDvVSW(ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(552500104 ^ 552499132), (object) new object[4]
              {
                ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.LastActionDate),
                ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.UserId),
                (object) str4,
                (object) str3
              }));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 == 0 ? 11 : 5;
              continue;
            case 32:
              if (!string.IsNullOrEmpty(str3))
              {
                num2 = 37;
                continue;
              }
              goto case 40;
            case 33:
              object obj1 = ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform);
              string currentTimestamp = ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).ConfigurationInfoCurrentTimestamp;
              string str5 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(--2002186503 ^ 2002189601);
              timeSpan2 = ActiveUserSessionService._removeOnActionTimeoutTime.Value;
              // ISSUE: variable of a boxed type
              __Boxed<double> totalSeconds1 = (System.ValueType) timeSpan2.TotalSeconds;
              object obj2 = ActiveUserSessionService.Pw6XTpww8IoFEtVtiVM((object) str5, (object) totalSeconds1);
              str4 = (string) ActiveUserSessionService.ueeEJqw21EuL5syHIWc(obj1, (object) currentTimestamp, obj2);
              num2 = 26;
              continue;
            case 34:
              nullable5 = nullable2;
              goto label_130;
            case 35:
              this._cacheService.Insert<DateTime>(ActiveUserSessionService.CacheKey, dateTime1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 4 : 2;
              continue;
            case 36:
              goto label_138;
            case 37:
              object obj3 = ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform);
              object obj4 = ActiveUserSessionService.epThfCwOk6A54f8Ttt4(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform));
              object obj5 = ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(1224834736 ^ 1224831638);
              timeSpan2 = ActiveUserSessionService._removePrivilegedUsersTimeoutTime.Value;
              // ISSUE: variable of a boxed type
              __Boxed<double> totalSeconds2 = (System.ValueType) timeSpan2.TotalSeconds;
              object second = ActiveUserSessionService.Pw6XTpww8IoFEtVtiVM(obj5, (object) totalSeconds2);
              str2 = ((Dialect) obj3).AddSecond((string) obj4, (string) second);
              num2 = 66;
              continue;
            case 38:
              goto label_111;
            case 39:
              if (ActiveUserSessionService._removePrivilegedUsersTimeoutTime.HasValue)
              {
                num2 = 59;
                continue;
              }
              goto label_135;
            case 40:
              // ISSUE: type reference
              removeSessionsInfo = ((IQuery) ActiveUserSessionService.dE0Ns3wDy0fZhM3XCui(ActiveUserSessionService.Ve4bNsw6nTsFNlXlMos(ActiveUserSessionService.UNertTwtBis37tHXuBE((object) this.sessionProvider.GetSession(string.Empty), (object) str1), (object) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(ActiveUserSessionService.vGacnDwEg9p0hK1cGsl(__typeref (AuthenticatedSessionInfo)))), false)).List<AuthenticatedSessionInfo>();
              num2 = 63;
              continue;
            case 41:
              if (ActiveUserSessionService.TvFypmbuehI9ndkTdKA((object) removeSessionsInfo) > 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 != 0 ? 45 : 11;
                continue;
              }
              goto label_114;
            case 42:
              str3 = string.Join<long>((string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-880091293 >> 4 ^ -55008806), (IEnumerable<long>) this.GetPrivilegeUserIds().ToArray<long>());
              num2 = 22;
              continue;
            case 43:
              if (nullable1.HasValue)
              {
                num2 = 5;
                continue;
              }
              goto case 1;
            case 44:
              try
              {
label_38:
                if (ActiveUserSessionService.VfBIbCw89lSNOkea4MV((object) enumerator1))
                  goto label_32;
                else
                  goto label_39;
label_31:
                int num13;
                AuthenticatedSessionInfo sessionInfo;
                while (true)
                {
                  switch (num13)
                  {
                    case 1:
                      sessionInfo = enumerator1.Current;
                      num13 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0 ? 6 : 2;
                      continue;
                    case 2:
                      goto label_32;
                    case 3:
                      ActiveUserSessionService.mA3YrJw46rjpZqFZqX3(ActiveUserSessionService.V9YNOUwf40i39sYOvTM(ActiveUserSessionService.UNertTwtBis37tHXuBE((object) this.sessionProvider.GetSession(string.Empty), ActiveUserSessionService.qPCCi3wlWxv0frL7jom(ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-1958977588 ^ -1958981444), (object) ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).QuoteIfNeeded((string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(384582979 ^ 384583203)), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.TicketUid))), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-696756495 ^ -696756189), ActiveUserSessionService.IkLMlVwj9hQfjwEqGUd((object) sessionInfo)), false);
                      num13 = 4;
                      continue;
                    case 4:
                      sessionClosedUsersIds.AddOrUpdate(Convert.ToInt64(ActiveUserSessionService.o3uVt6wcsBlrPpYFqLA((object) sessionInfo)), (Func<long, List<AuthenticatedSessionInfo>>) (v => new List<AuthenticatedSessionInfo>()
                      {
                        sessionInfo
                      }), (Func<long, List<AuthenticatedSessionInfo>, List<AuthenticatedSessionInfo>>) ((v, list) =>
                      {
                        list.Add(sessionInfo);
                        return list;
                      }));
                      num13 = 5;
                      continue;
                    case 5:
                      goto label_38;
                    case 6:
                      ActiveUserSessionService.oUcgtPwaiyCWwxhJLA5((object) this.logger, ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(--1207559533 ^ 1207561119), (object) new object[2]
                      {
                        (object) ActiveUserSessionService.IkLMlVwj9hQfjwEqGUd((object) sessionInfo),
                        ActiveUserSessionService.jdA3Z5wZB0lRhahE33M((object) sessionInfo)
                      });
                      num13 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c == 0 ? 2 : 3;
                      continue;
                    default:
                      goto label_134;
                  }
                }
label_32:
                num13 = 1;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 == 0)
                {
                  num13 = 1;
                  goto label_31;
                }
                else
                  goto label_31;
label_39:
                num13 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 0 : 0;
                goto label_31;
              }
              finally
              {
                int num14;
                if (enumerator1 == null)
                  num14 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 == 0 ? 0 : 0;
                else
                  goto label_43;
label_42:
                switch (num14)
                {
                  case 2:
                    break;
                  default:
                }
label_43:
                enumerator1.Dispose();
                num14 = 1;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 == 0)
                {
                  num14 = 0;
                  goto label_42;
                }
                else
                  goto label_42;
              }
            case 45:
              num2 = 53;
              continue;
            case 46:
            case 48:
            case 52:
              nullable1 = this._cacheService.Get<DateTime?>(ActiveUserSessionService.CacheKey);
              num2 = 43;
              continue;
            case 47:
              if (ActiveUserSessionService.txLXuAwnpi4RVTBEVpy(timeSpan1, ActiveUserSessionService._removeOnPingTimeoutTime))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 == 0 ? 18 : 46;
                continue;
              }
              goto case 30;
            case 49:
              if (ActiveUserSessionService._removeOnActionTimeoutTime.HasValue)
              {
                num2 = 39;
                continue;
              }
              goto label_120;
            case 51:
              enumerator1 = collection.GetEnumerator();
              num2 = 2;
              continue;
            case 53:
              sessionClosedUsersIds = new ConcurrentDictionary<long, List<AuthenticatedSessionInfo>>();
              num3 = 51;
              break;
            case 54:
              this._lastUpdateTime = new DateTime?(dateTime1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 != 0 ? 5 : 60;
              continue;
            case 55:
label_134:
              ICollection<EleWise.ELMA.Security.Models.IUser> byIdArray = this.UserManager.FindByIdArray(sessionClosedUsersIds.Keys.ToArray<long>());
              // ISSUE: reference to a compiler-generated field
              Func<EleWise.ELMA.Security.Models.IUser, EleWise.ELMA.Security.Models.IUser> func = ActiveUserSessionService.\u003C\u003Ec.\u003C\u003E9__12_4;
              Func<EleWise.ELMA.Security.Models.IUser, EleWise.ELMA.Security.Models.IUser> elementSelector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                ActiveUserSessionService.\u003C\u003Ec.\u003C\u003E9__12_4 = elementSelector = (Func<EleWise.ELMA.Security.Models.IUser, EleWise.ELMA.Security.Models.IUser>) (v => v);
              }
              else
                goto label_147;
label_137:
              users = byIdArray.ToDictionary<EleWise.ELMA.Security.Models.IUser, long, EleWise.ELMA.Security.Models.IUser>((Func<EleWise.ELMA.Security.Models.IUser, long>) (k => k.Id), elementSelector);
              num2 = 9;
              continue;
label_147:
              elementSelector = func;
              goto label_137;
            case 56:
              if (!this._lastUpdateTime.HasValue)
              {
                num2 = 50;
                continue;
              }
              goto case 15;
            case 58:
              num4 = ActiveUserSessionService.v2kP7UwJxEiKWNGMnBV(nullable4.GetValueOrDefault(), timeSpan2) ? 1 : 0;
              goto label_132;
            case 59:
              if (!ActiveUserSessionService.txLXuAwnpi4RVTBEVpy(timeSpan1, ActiveUserSessionService._removePrivilegedUsersTimeoutTime.Value))
              {
                num2 = 38;
                continue;
              }
              goto case 46;
            case 60:
              ActiveUserSessionService.sjj5T2wIYcdEI6gNA2l((object) this._updateSessionsLock, 100);
              num2 = 24;
              continue;
            case 61:
              if (!ActiveUserSessionService.y9KKDOwKn34GBOIJQMD((object) str3))
              {
                num2 = 16;
                continue;
              }
              goto case 19;
            case 63:
              // ISSUE: type reference
              collection = ((IQuery) ActiveUserSessionService.Ve4bNsw6nTsFNlXlMos(ActiveUserSessionService.dE0Ns3wDy0fZhM3XCui(ActiveUserSessionService.TTcgiWwzB7fL9Rkxc8j(ActiveUserSessionService.UNertTwtBis37tHXuBE(ActiveUserSessionService.Ug9nuawVUwJQqpurqpM((object) this.sessionProvider, (object) string.Empty), ActiveUserSessionService.MKCVWywdpZTsSgDvVSW((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-550634672 ^ -550635594), (object) new object[12]
              {
                ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(--2002186503 ^ 2002186855)),
                (object) this._transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.Status),
                (object) ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.LastPingDate),
                ActiveUserSessionService.ueeEJqw21EuL5syHIWc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) this._transform.Dialect.ConfigurationInfoCurrentTimestamp, ActiveUserSessionService.Pw6XTpww8IoFEtVtiVM(ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-468111058 ^ -468108024), (object) ActiveUserSessionService._freezeTime.TotalSeconds)),
                (object) ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.TicketUid),
                ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.Expiration),
                ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.SessionId),
                (object) ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.UserId),
                ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.RemoteAddress),
                ActiveUserSessionService.DL6FohwoU3jt7yGd7kc((object) this._transform.Dialect, (object) AuthenticatedSessionInfo.Db.Fields.CreationDate),
                ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.LastActionDate),
                ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.LastActionInfo)
              })), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(978908330 << 6 ^ -1774377156), 0), false), (object) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(ActiveUserSessionService.vGacnDwEg9p0hK1cGsl(__typeref (AuthenticatedSessionInfo))))).List<AuthenticatedSessionInfo>();
              num2 = 3;
              continue;
            case 64:
              if (nullable4.HasValue)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0 ? 58 : 55;
                continue;
              }
              goto case 14;
            case 65:
              timeSpan1 = ActiveUserSessionService.DCJLYCwvEw0Tvm764hV(dateTime1, this._startTime.Value);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 2 : 7;
              continue;
            case 66:
              str1 = (string) ActiveUserSessionService.jp1YwLwHCH4yLbNcImp((object) str1, ActiveUserSessionService.MKCVWywdpZTsSgDvVSW((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1958977588 ^ -1958980754), (object) new object[4]
              {
                ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.LastActionDate),
                ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) AuthenticatedSessionInfo.Db.Fields.UserId),
                (object) str2,
                (object) str3
              }));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 != 0 ? 40 : 40;
              continue;
            case 67:
              if (!ActiveUserSessionService.y9KKDOwKn34GBOIJQMD((object) str3))
              {
                num2 = 31;
                continue;
              }
              goto case 18;
            case 68:
              this.AuthenticationServiceEventHandlers.ForEach((Action<IAuthenticationServiceEventHandler>) (handler =>
              {
                int num15 = 3;
                // ISSUE: variable of a compiler-generated type
                ActiveUserSessionService.\u003C\u003Ec__DisplayClass12_8 cDisplayClass128;
                IEnumerator<KeyValuePair<long, List<AuthenticatedSessionInfo>>> enumerator3;
                while (true)
                {
                  switch (num15)
                  {
                    case 0:
                      goto label_23;
                    case 1:
                      enumerator3 = sessionClosedUsersIds.GetEnumerator();
                      num15 = 4;
                      continue;
                    case 2:
                      // ISSUE: reference to a compiler-generated field
                      cDisplayClass128.handler = handler;
                      num15 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 == 0 ? 1 : 0;
                      continue;
                    case 3:
                      // ISSUE: object of a compiler-generated type is created
                      cDisplayClass128 = new ActiveUserSessionService.\u003C\u003Ec__DisplayClass12_8();
                      num15 = 2;
                      continue;
                    case 4:
                      goto label_5;
                    default:
                      goto label_18;
                  }
                }
label_23:
                return;
label_18:
                return;
label_5:
                try
                {
label_8:
                  // ISSUE: reference to a compiler-generated method
                  if (ActiveUserSessionService.\u003C\u003Ec__DisplayClass12_3.BebscswUgCNosYO6i8xp((object) enumerator3))
                    goto label_15;
                  else
                    goto label_9;
label_6:
                  // ISSUE: variable of a compiler-generated type
                  ActiveUserSessionService.\u003C\u003Ec__DisplayClass12_9 cDisplayClass129;
                  KeyValuePair<long, List<AuthenticatedSessionInfo>> current;
                  int num16;
                  while (true)
                  {
                    switch (num16)
                    {
                      case 1:
                        // ISSUE: object of a compiler-generated type is created
                        cDisplayClass129 = new ActiveUserSessionService.\u003C\u003Ec__DisplayClass12_9();
                        num16 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 6 : 7;
                        continue;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        current.Value.ForEach(new Action<AuthenticatedSessionInfo>(cDisplayClass129.\u003CFlushUpdatedSessions\u003Eb__12));
                        num16 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 != 0 ? 2 : 5;
                        continue;
                      case 3:
                        // ISSUE: reference to a compiler-generated field
                        if (users.TryGetValue(current.Key, out cDisplayClass129.user))
                        {
                          num16 = 2;
                          continue;
                        }
                        goto label_8;
                      case 4:
                        goto label_15;
                      case 5:
                        goto label_8;
                      case 6:
                        goto label_7;
                      case 7:
                        // ISSUE: reference to a compiler-generated field
                        cDisplayClass129.CS\u0024\u003C\u003E8__locals2 = cDisplayClass128;
                        num16 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0 ? 0 : 0;
                        continue;
                      default:
                        // ISSUE: reference to a compiler-generated field
                        cDisplayClass129.user = (EleWise.ELMA.Security.Models.IUser) null;
                        num16 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba != 0 ? 2 : 3;
                        continue;
                    }
                  }
label_7:
                  return;
label_9:
                  num16 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 == 0 ? 6 : 6;
                  goto label_6;
label_15:
                  current = enumerator3.Current;
                  num16 = 1;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 == 0)
                  {
                    num16 = 1;
                    goto label_6;
                  }
                  else
                    goto label_6;
                }
                finally
                {
                  if (enumerator3 != null)
                  {
                    int num17 = 1;
                    if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 == 0)
                      num17 = 1;
                    while (true)
                    {
                      switch (num17)
                      {
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          ActiveUserSessionService.\u003C\u003Ec__DisplayClass12_3.rux8OXwUJIQeEQs0dmi1((object) enumerator3);
                          num17 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_25;
                      }
                    }
                  }
label_25:;
                }
              }));
              num2 = 36;
              continue;
            case 69:
label_48:
              this.ExecuteWithLock((Action) (() =>
              {
                int num18 = 1;
                IEnumerator<AuthenticatedSessionInfo> enumerator4;
                while (true)
                {
                  switch (num18)
                  {
                    case 1:
                      enumerator4 = sessionInfos.Values.GetEnumerator();
                      num18 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d == 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_17;
                    default:
                      goto label_2;
                  }
                }
label_17:
                return;
label_2:
                try
                {
label_6:
                  if (enumerator4.MoveNext())
                    goto label_8;
                  else
                    goto label_7;
label_4:
                  AuthenticatedSessionInfo current;
                  int num19;
                  while (true)
                  {
                    switch (num19)
                    {
                      case 0:
                        goto label_12;
                      case 1:
                        goto label_6;
                      case 2:
                        userSessionService.UpdateSessionInfo(current);
                        num19 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e == 0 ? 1 : 0;
                        continue;
                      case 3:
                        goto label_8;
                      case 4:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        ActiveUserSessionService.\u003C\u003Ec__DisplayClass12_0.GS5hrpwUEsHyfvm7CoOx((object) userSessionService.logger, ActiveUserSessionService.\u003C\u003Ec__DisplayClass12_0.J4FPdiwU8g0omYncggF3(1076316568 ^ 1076258046), (object) new object[2]
                        {
                          (object) ActiveUserSessionService.\u003C\u003Ec__DisplayClass12_0.lebwBjwU5tMwAZbVBtyF((object) current),
                          ActiveUserSessionService.\u003C\u003Ec__DisplayClass12_0.TpcTVmwUdt7DpKyp6TVv((object) current)
                        });
                        num19 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d != 0 ? 2 : 1;
                        continue;
                      default:
                        goto label_5;
                    }
                  }
label_12:
                  return;
label_5:
                  return;
label_7:
                  num19 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 0 : 0;
                  goto label_4;
label_8:
                  current = enumerator4.Current;
                  num19 = 0;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0)
                  {
                    num19 = 4;
                    goto label_4;
                  }
                  else
                    goto label_4;
                }
                finally
                {
                  if (enumerator4 != null)
                  {
                    int num20 = 0;
                    if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef == 0)
                      num20 = 0;
                    while (true)
                    {
                      switch (num20)
                      {
                        case 1:
                          goto label_19;
                        default:
                          enumerator4.Dispose();
                          num20 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 1 : 1;
                          continue;
                      }
                    }
                  }
label_19:;
                }
              }));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 != 0 ? 21 : 27;
              continue;
            default:
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed != 0 ? 0 : 21;
              continue;
          }
          num2 = num3;
          continue;
label_130:
          nullable4 = nullable5;
          num2 = 23;
          continue;
label_132:
          if (num4 != 0)
            num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab == 0 ? 0 : 1;
          else
            goto label_112;
        }
label_138:
        return;
label_111:
        return;
label_135:
        return;
label_123:
        return;
label_120:
        return;
label_114:
        return;
label_112:;
      }
      finally
      {
        if (setTimeout != null)
        {
          int num21 = 1;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0)
            num21 = 1;
          while (true)
          {
            switch (num21)
            {
              case 1:
                setTimeout.Dispose();
                num21 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 != 0 ? 0 : 0;
                continue;
              default:
                goto label_145;
            }
          }
        }
label_145:;
      }
    }

    /// <summary>
    /// Интервал времени (в секундах), через который происходит обновление информации о текущей активности пользователя
    /// </summary>
    internal static int SavingActivityTimeoutTime
    {
      get
      {
        int num1 = 1;
        while (true)
        {
          int num2 = num1;
          int num3;
          while (true)
          {
            switch (num2)
            {
              case 1:
                if (!ActiveUserSessionService.savingActivityTimeoutTime.HasValue)
                {
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 == 0 ? 0 : 0;
                  continue;
                }
                goto label_6;
              case 2:
                if (num3 <= 0)
                {
                  num2 = 5;
                  continue;
                }
                goto label_8;
              case 3:
                goto label_6;
              case 4:
                goto label_8;
              case 5:
                num3 = 60;
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d != 0 ? 4 : 0;
                continue;
              default:
                num3 = EleWise.ELMA.SR.GetSetting<int>((string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-1976147292 - 421656521 ^ 1897162001), 60);
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 2 : 2;
                continue;
            }
          }
label_8:
          ActiveUserSessionService.savingActivityTimeoutTime = new int?(num3);
          num1 = 3;
        }
label_6:
        return ActiveUserSessionService.savingActivityTimeoutTime.Value;
      }
    }

    private IInternalSecurityService InternalSecurityService
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.internalSecurityService == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            default:
              this.internalSecurityService = (IInternalSecurityService) ActiveUserSessionService.PvmAZhbRgbehmvPHk5q((object) (ILicensedModuleAssembly) ActiveUserSessionService.xdKqqcbU2xfUMOHlOJN(ActiveUserSessionService.DOGkdFbK1xWtX9X4xrA((object) ComponentManager.Current), __AssemblyInfo.UID));
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 == 0 ? 2 : 1;
              continue;
          }
        }
label_4:
        return this.internalSecurityService;
      }
    }

    private List<IAuthenticationServiceEventHandler> AuthenticationServiceEventHandlers => this._authenticationServiceEventHandlers ?? (this._authenticationServiceEventHandlers = ComponentManager.Current.GetExtensionPoints<IAuthenticationServiceEventHandler>().ToList<IAuthenticationServiceEventHandler>());

    private List<IAuthenticatedSessionEventHandler> AuthenticatedSessionEventHandlers => this._authenticatedSessionEventHandlers ?? (this._authenticatedSessionEventHandlers = ComponentManager.Current.GetExtensionPoints<IAuthenticatedSessionEventHandler>().ToList<IAuthenticatedSessionEventHandler>());

    /// <summary>Провайдер сессий NHibernate</summary>
    private ISessionProvider SessionProvider
    {
      get
      {
        int num = 1;
        ISessionProvider serviceNotNull;
        ISessionProvider sessionProvider;
        while (true)
        {
          switch (num)
          {
            case 1:
              sessionProvider = this.sessionProvider;
              if (sessionProvider == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.sessionProvider = serviceNotNull = Locator.GetServiceNotNull<ISessionProvider>();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a != 0 ? 1 : 2;
              continue;
          }
        }
label_2:
        return sessionProvider;
label_6:
        return serviceNotNull;
      }
    }

    /// <summary>Менеджер работы с пользователями</summary>
    private UserManager UserManager
    {
      get
      {
        int num = 2;
        UserManager userManager1;
        UserManager userManager2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.userManager = userManager1 = (UserManager) ActiveUserSessionService.QrCakwbo0JxKpcNhFdr();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 != 0 ? 0 : 0;
              continue;
            case 2:
              userManager2 = this.userManager;
              if (userManager2 == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a == 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return userManager2;
label_6:
        return userManager1;
      }
    }

    /// <summary>Менджер единиц работ</summary>
    private IUnitOfWorkManager UnitOfWorkManager
    {
      get
      {
        int num = 1;
        IUnitOfWorkManager serviceNotNull;
        IUnitOfWorkManager unitOfWorkManager;
        while (true)
        {
          switch (num)
          {
            case 1:
              unitOfWorkManager = this.unitOfWorkManager;
              if (unitOfWorkManager == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.unitOfWorkManager = serviceNotNull = Locator.GetServiceNotNull<IUnitOfWorkManager>();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 == 0 ? 2 : 2;
              continue;
          }
        }
label_2:
        return unitOfWorkManager;
label_6:
        return serviceNotNull;
      }
    }

    private void ExecuteWithLock(Action action)
    {
      int num1 = 2;
      ActiveUserSessionService userSessionService;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_38;
          case 1:
            userSessionService = this;
            num1 = 4;
            continue;
          case 2:
            if (action != null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 != 0 ? 1 : 0;
              continue;
            }
            goto label_36;
          case 3:
            goto label_36;
          case 4:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 3 : 5;
            continue;
          case 5:
            goto label_2;
          default:
            goto label_31;
        }
      }
label_38:
      return;
label_31:
      return;
label_2:
      try
      {
        Monitor.Enter((object) userSessionService, ref lockTaken);
        int num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 == 0)
          num2 = 0;
        IUnitOfWork unitOfWork;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            default:
              unitOfWork = (IUnitOfWork) ActiveUserSessionService.n53sjBbtnGLy5L430k3((object) this.UnitOfWorkManager, (object) string.Empty, true, IsolationLevel.Unspecified);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 == 0 ? 0 : 1;
              continue;
          }
        }
label_6:
        try
        {
          IDisposable disposable = (IDisposable) ActiveUserSessionService.rBBL6Gbmqbw6tKZKl66((object) this._lockManager, ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(554338340 ^ 554342460));
          int num3 = 2;
          while (true)
          {
            switch (num3)
            {
              case 0:
                goto label_28;
              case 1:
label_8:
                ActiveUserSessionService.mTOM0sb60hbMvll8nEO((object) unitOfWork);
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 0 : 0;
                continue;
              case 2:
                try
                {
                  action();
                  int num4 = 0;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 == 0)
                    num4 = 0;
                  switch (num4)
                  {
                    default:
                      goto label_8;
                  }
                }
                finally
                {
                  int num5;
                  if (disposable == null)
                    num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 2 : 2;
                  else
                    goto label_15;
label_14:
                  switch (num5)
                  {
                    case 1:
                    case 2:
                  }
label_15:
                  disposable.Dispose();
                  num5 = 1;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e == 0)
                  {
                    num5 = 0;
                    goto label_14;
                  }
                  else
                    goto label_14;
                }
              default:
                goto label_22;
            }
          }
label_28:
          return;
label_22:
          return;
        }
        finally
        {
          if (unitOfWork != null)
          {
            int num6 = 1;
            if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed == 0)
              num6 = 0;
            while (true)
            {
              switch (num6)
              {
                case 1:
                  ActiveUserSessionService.ii6MSDwb3so3xELcdh5((object) unitOfWork);
                  num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_24;
              }
            }
          }
label_24:;
        }
      }
      finally
      {
        int num7;
        if (!lockTaken)
          num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 == 0 ? 1 : 0;
        else
          goto label_29;
label_27:
        switch (num7)
        {
          case 2:
            break;
          default:
        }
label_29:
        Monitor.Exit((object) userSessionService);
        num7 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab == 0)
        {
          num7 = 0;
          goto label_27;
        }
        else
          goto label_27;
      }
label_36:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(44166125 ^ 44170213));
    }

    private ActivePrivilegeUsersInfo IsCurrentPrivilege(
      AuthenticatedSessionInfo sessionInfo,
      EleWise.ELMA.Security.Models.IUser user)
    {
      int num = 2;
      string queryString;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (sessionInfo == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba != 0 ? 1 : 1;
              continue;
            }
            if (user != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0 ? 1 : 4;
              continue;
            }
            goto label_8;
          case 3:
            goto label_7;
          case 4:
            queryString = (string) ActiveUserSessionService.MKCVWywdpZTsSgDvVSW((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-206147790 ^ -206143562), (object) new object[7]
            {
              ActiveUserSessionService.Gc6li5bkrAm6aL0etbM(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), ActiveUserSessionService.qPCCi3wlWxv0frL7jom(ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-1424960806 ^ -1424964756), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc((object) this._transform.Dialect, ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-817081027 ^ 243500131 ^ -1043344254)), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-1310136491 - -570921450 ^ -739214435))), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-94240706 ^ -94236126), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-1880054609 ^ -1880050035)),
              ActiveUserSessionService.Gc6li5bkrAm6aL0etbM(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(554338340 ^ 554342924), ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(1530848604 ^ 1530849264))), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(213026252 ^ 213030864), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-624171910 - 757669187 ^ -1381837547)),
              ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1055964645 ^ 1055963181)),
              ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(928696104 ^ 928694950)),
              (object) ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).QuoteIfNeeded((string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-340788466 ^ -340787494)),
              ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(~-1362653258 ^ 1362653925)),
              (object) ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).QuoteIfNeeded((string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-206147790 ^ -206148988))
            });
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 0 : 3;
            continue;
          default:
            goto label_8;
        }
      }
label_4:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1489118656 ^ 643054122 ^ -2123765868));
label_7:
      // ISSUE: type reference
      return ((IQuery) ActiveUserSessionService.iMxrl4bDbFs9Dm31SYj(ActiveUserSessionService.iMxrl4bDbFs9Dm31SYj((object) ((IQuery) ActiveUserSessionService.iMxrl4bDbFs9Dm31SYj(ActiveUserSessionService.dE0Ns3wDy0fZhM3XCui((object) this.SessionProvider.GetSession(string.Empty).CreateSQLQuery(queryString), false), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(2047763786 ^ 1536686658 ^ 563714334), (object) 0, (object) NHibernateUtil.Int32)).SetParameter(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~123928154 ^ -123923467), (object) SecurityConstants.AdminUserUid, (IType) NHibernateUtil.Guid), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(1013954274 ^ 1013955800), (object) ActiveUserSessionService.imP64EwP8A1T2kdJqsw(ActiveUserSessionService.o3uVt6wcsBlrPpYFqLA((object) sessionInfo)), (object) NHibernateUtil.Int64), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-909559362 ^ -398405015 ^ 562687547), (object) this._privilegeGroupId, (object) NHibernateUtil.Int64)).SetResultTransformer((IResultTransformer) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(ActiveUserSessionService.vGacnDwEg9p0hK1cGsl(__typeref (ActivePrivilegeUsersInfo)))).UniqueResult<ActivePrivilegeUsersInfo>();
label_8:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(44166125 ^ 44170133));
    }

    /// <summary>Получить информацию о пользователях и их сессий</summary>
    /// <param name="sessionInfo">Авторизованная сессия пользователя</param>
    /// <returns>Информация о пользователях и их активных сессий</returns>
    internal ActiveUsersSessionInfo GetOtherUsersCount(
      AuthenticatedSessionInfo sessionInfo)
    {
      int num = 1;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = (string) ActiveUserSessionService.MKCVWywdpZTsSgDvVSW(ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-979995965 << 4 ^ 1499938398), (object) new object[7]
            {
              (object) ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).InsertIf(string.Format((string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-816108091 ^ -816103443), (object) ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).QuoteIfNeeded((string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(1095474805 ^ 155418997 ^ 1208491436))), (string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-389167216 ^ -389163636), (string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-901653144 ^ -901656758)),
              ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-817081027 ^ 243500131 ^ -1043344398)),
              ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(--1403802000 ^ 1403803108)),
              (object) ((Dialect) ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform)).QuoteIfNeeded((string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(266768307 ^ 266767571)),
              ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-29763048 >> 5 ^ -931060)),
              (object) this._transform.Dialect.QuoteIfNeeded((string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-1310136491 - -570921450 ^ -739214159)),
              ActiveUserSessionService.DL6FohwoU3jt7yGd7kc(ActiveUserSessionService.XbSM9QwRah7kJwxIyQJ((object) this._transform), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(1433051380 + 1051547170 ^ -1810369888))
            });
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      // ISSUE: type reference
      return ((IQuery) ActiveUserSessionService.Ve4bNsw6nTsFNlXlMos(ActiveUserSessionService.iMxrl4bDbFs9Dm31SYj((object) ((IQuery) ActiveUserSessionService.iMxrl4bDbFs9Dm31SYj((object) ((IQuery) ActiveUserSessionService.dE0Ns3wDy0fZhM3XCui(ActiveUserSessionService.UNertTwtBis37tHXuBE(ActiveUserSessionService.Ug9nuawVUwJQqpurqpM((object) this.SessionProvider, (object) string.Empty), (object) str), false)).SetParameter((string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(839394233 ^ 839396869), (object) 0, (IType) NHibernateUtil.Int32), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(--1403802000 ^ 1403803154), ActiveUserSessionService.jdA3Z5wZB0lRhahE33M((object) sessionInfo), (object) NHibernateUtil.String)).SetParameter((string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-296013529 ^ -296010979), (object) ActiveUserSessionService.imP64EwP8A1T2kdJqsw(ActiveUserSessionService.o3uVt6wcsBlrPpYFqLA((object) sessionInfo)), (IType) NHibernateUtil.Int64), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(44166125 ^ 44166657), (object) this._privilegeGroupId, (object) NHibernateUtil.Int64), (object) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(ActiveUserSessionService.vGacnDwEg9p0hK1cGsl(__typeref (ActiveUsersSessionInfo))))).UniqueResult<ActiveUsersSessionInfo>();
    }

    /// <summary>Обновить данные в таблице по текущей авторизации</summary>
    /// <param name="sessionInfo">Информация об авторизации пользователя</param>
    private void UpsertSessionInfo(AuthenticatedSessionInfo sessionInfo)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ActiveUserSessionService.mA3YrJw46rjpZqFZqX3(ActiveUserSessionService.Q1gPiXbjs0VL4daGXyO(ActiveUserSessionService.Q1gPiXbjs0VL4daGXyO(ActiveUserSessionService.Q1gPiXbjs0VL4daGXyO(ActiveUserSessionService.AmtOZnwmMnJgxDHeDr4(ActiveUserSessionService.iMxrl4bDbFs9Dm31SYj(ActiveUserSessionService.iMxrl4bDbFs9Dm31SYj(ActiveUserSessionService.iMxrl4bDbFs9Dm31SYj(ActiveUserSessionService.AmtOZnwmMnJgxDHeDr4((object) ((IQuery) ActiveUserSessionService.iMxrl4bDbFs9Dm31SYj(ActiveUserSessionService.TTcgiWwzB7fL9Rkxc8j(ActiveUserSessionService.V9YNOUwf40i39sYOvTM(ActiveUserSessionService.M2EKUYbaG4yKb3IZHTK(ActiveUserSessionService.Ug9nuawVUwJQqpurqpM((object) this.SessionProvider, (object) string.Empty), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-1859356887 ^ -1859362287)), ActiveUserSessionService.jp1YwLwHCH4yLbNcImp((object) AuthenticatedSessionInfo.Db.Fields.TicketUid, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29763048 >> 5 ^ -926814)), ActiveUserSessionService.IkLMlVwj9hQfjwEqGUd((object) sessionInfo)), ActiveUserSessionService.jp1YwLwHCH4yLbNcImp((object) AuthenticatedSessionInfo.Db.Fields.Status, ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-1115268484 ^ -1115271410)), (int) ActiveUserSessionService.DDTESObxqlxDxF8Yc2x((object) sessionInfo)), ActiveUserSessionService.jp1YwLwHCH4yLbNcImp((object) AuthenticatedSessionInfo.Db.Fields.Expiration, ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(781628008 - 11982093 ^ 769640489)), (object) sessionInfo.Expiration, (object) NHibernateUtil.DateTime)).SetString((string) ActiveUserSessionService.jp1YwLwHCH4yLbNcImp((object) AuthenticatedSessionInfo.Db.Fields.SessionId, ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(908197830 ^ 908192436)), sessionInfo.SessionId).SetInt64((string) ActiveUserSessionService.jp1YwLwHCH4yLbNcImp((object) AuthenticatedSessionInfo.Db.Fields.UserId, ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(784628100 ^ 784624886)), (long) ActiveUserSessionService.o3uVt6wcsBlrPpYFqLA((object) sessionInfo)), ActiveUserSessionService.jp1YwLwHCH4yLbNcImp((object) AuthenticatedSessionInfo.Db.Fields.RemoteAddress, ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(447286529 ^ 447289459)), ActiveUserSessionService.MJ1FYBbCYUcSf26wGhw((object) sessionInfo)), (object) (AuthenticatedSessionInfo.Db.Fields.CreationDate + (string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(1290337431 ^ 1290332645)), (object) ActiveUserSessionService.wQUFUKbiUCDeAsn3sba((object) sessionInfo), (object) NHibernateUtil.DateTime), (object) (AuthenticatedSessionInfo.Db.Fields.LastActionDate + (string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(334323849 << 5 ^ 2108425298)), (object) sessionInfo.LastActionDate, (object) NHibernateUtil.DateTime), (object) (AuthenticatedSessionInfo.Db.Fields.LastPingDate + (string) ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-1424960806 ^ -1424963672)), (object) ActiveUserSessionService.NfsflQb3YxyjqUwqnDL((object) sessionInfo), (object) NHibernateUtil.DateTime), ActiveUserSessionService.jp1YwLwHCH4yLbNcImp((object) AuthenticatedSessionInfo.Db.Fields.LastActionInfo, ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(~-1362653258 ^ 1362650427)), ActiveUserSessionService.vav07GwrAx4a5FZjMXP((object) sessionInfo)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1940240517 ^ 974551502 ^ 1236522187), sessionInfo.CreationIsCurrent), ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-517128429 ^ -517133643), ActiveUserSessionService.z2eaTtwpREKlA1SkLSq((object) sessionInfo)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1691384762 ^ -1691381354), ActiveUserSessionService.Ge7bEnbNQ0DSHNwAJy7((object) sessionInfo)), false);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af != 0 ? 0 : 0;
            continue;
          case 2:
            ActiveUserSessionService.TMF1xqwAyA279o6Z6i4((object) this.logger, ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(--180540780 ^ 180535736), (object) new object[2]
            {
              (object) ActiveUserSessionService.IkLMlVwj9hQfjwEqGUd((object) sessionInfo),
              ActiveUserSessionService.jdA3Z5wZB0lRhahE33M((object) sessionInfo)
            });
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    private void ReloadSettings()
    {
      int num = 14;
      while (true)
      {
        SecuritySettingsModule service;
        TimeSpan? nullable1;
        TimeSpan? nullable2;
        TimeSpan? nullable3;
        switch (num)
        {
          case 1:
            ActiveUserSessionService._freezeTime = service.Settings.FreezeAuthenticationOnPingTimeoutTime;
            num = 10;
            continue;
          case 2:
            if (ActiveUserSessionService.MLTESxb7K4fPwj6WOBa((object) service.Settings))
            {
              num = 7;
              continue;
            }
            goto default;
          case 3:
            if (!this.isPrivilegedLicense)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 != 0 ? 0 : 5;
              continue;
            }
            goto case 2;
          case 4:
            if (service.Settings != null)
            {
              num = 16;
              continue;
            }
            goto label_14;
          case 6:
            goto label_10;
          case 7:
            nullable2 = new TimeSpan?(ActiveUserSessionService.Qtbmd8bWnymTJuaQjuq((object) service.Settings));
            goto label_27;
          case 8:
            nullable1 = new TimeSpan?();
            num = 12;
            continue;
          case 9:
            nullable2 = nullable1;
            goto label_27;
          case 10:
            ActiveUserSessionService._removeOnPingTimeoutTime = ActiveUserSessionService.S5q8CAbZrerN4db80H2((object) service.Settings);
            num = 15;
            continue;
          case 11:
            goto label_21;
          case 12:
            nullable3 = nullable1;
            break;
          case 13:
            if (service != null)
            {
              num = 4;
              continue;
            }
            goto label_12;
          case 14:
            service = Locator.GetService<SecuritySettingsModule>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 == 0 ? 13 : 8;
            continue;
          case 15:
            if (!ActiveUserSessionService.y3TxYXbAJFfN6By08tQ((object) service.Settings))
            {
              num = 8;
              continue;
            }
            nullable3 = new TimeSpan?(ActiveUserSessionService.g30qhwbs5lxlOIqN2sk((object) service.Settings));
            break;
          case 16:
            this.isPrivilegedLicense = ActiveUserSessionService.tjK6hEb0bdbSJ1LxeoF((object) service.Settings);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0 ? 0 : 1;
            continue;
          default:
            nullable1 = new TimeSpan?();
            num = 9;
            continue;
        }
        ActiveUserSessionService._removeOnActionTimeoutTime = nullable3;
        num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0 ? 3 : 0;
        continue;
label_27:
        ActiveUserSessionService._removePrivilegedUsersTimeoutTime = nullable2;
        num = 11;
      }
label_10:
      return;
label_21:
      return;
label_14:
      return;
label_12:;
    }

    void IInitHandler.Init()
    {
    }

    void IInitHandler.InitComplete()
    {
      int num = 5;
      IUserGroup userGroup;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this._cacheService = Locator.GetServiceNotNull<ICacheService>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a == 0 ? 6 : 3;
            continue;
          case 3:
            this._lockManager = Locator.GetServiceNotNull<ILockManager>();
            num = 2;
            continue;
          case 4:
            Locator.GetServiceNotNull<IUnitOfWorkManager>();
            num = 3;
            continue;
          case 5:
            this._transform = Locator.GetServiceNotNull<ITransformationProvider>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 2 : 4;
            continue;
          case 6:
            this._contextService = Locator.GetServiceNotNull<IContextBoundVariableService>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 0 : 0;
            continue;
          case 7:
            this._privilegeGroupId = userGroup.Id;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed == 0 ? 1 : 0;
            continue;
          default:
            userGroup = Locator.GetServiceNotNull<UserGroupManager>().Load(SecurityConstants.PrivilegeUsersGroupUid);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 != 0 ? 5 : 7;
            continue;
        }
      }
label_2:;
    }

    public ActiveUserSessionService()
    {
      ActiveUserSessionService.uQ8nhXbrsljs6AlwOwY();
      // ISSUE: type reference
      this.logger = (ILogger) ActiveUserSessionService.uNDnjDbSjgjlyYJYLZ1(ActiveUserSessionService.vGacnDwEg9p0hK1cGsl(__typeref (ActiveUserSessionService)));
      this._updateSessionsLock = new ReaderWriterLock();
      this.sessionsToUpdate = new ConcurrentDictionary<Guid, AuthenticatedSessionInfo>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ActiveUserSessionService()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: type reference
            ActiveUserSessionService.CacheKey = (string) ActiveUserSessionService.jp1YwLwHCH4yLbNcImp((object) ActiveUserSessionService.vGacnDwEg9p0hK1cGsl(__typeref (ActiveUserSessionService)).FullName, ActiveUserSessionService.Av0K42wU8Jh3aurWWK5(-1893095749 ^ -1893092531));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 6 : 5;
            continue;
          case 3:
            ActiveUserSessionService._removeOnPingTimeoutTime = TimeSpan.FromDays(1.0);
            num = 5;
            continue;
          case 4:
            ActiveUserSessionService._removePrivilegedUsersTimeoutTime = new TimeSpan?();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 1 : 2;
            continue;
          case 5:
            ActiveUserSessionService._removeOnActionTimeoutTime = new TimeSpan?();
            num = 4;
            continue;
          case 6:
            goto label_2;
          default:
            ActiveUserSessionService._freezeTime = TimeSpan.FromMinutes(3.0);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 == 0 ? 3 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static object Pw6XTpww8IoFEtVtiVM([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static void ii6MSDwb3so3xELcdh5([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool RIOvIqzrZAHMXiOhKI() => ActiveUserSessionService.geZmMpHvL7eFXbUSgv == null;

    internal static ActiveUserSessionService IKiWgZwuej0IhPDOX1S() => ActiveUserSessionService.geZmMpHvL7eFXbUSgv;

    internal static bool y9KKDOwKn34GBOIJQMD([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object Av0K42wU8Jh3aurWWK5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object XbSM9QwRah7kJwxIyQJ([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object DL6FohwoU3jt7yGd7kc([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object UNertTwtBis37tHXuBE([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).CreateSQLQuery((string) obj1);

    internal static object AmtOZnwmMnJgxDHeDr4([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IQuery) obj0).SetString((string) obj1, (string) obj2);

    internal static object Ve4bNsw6nTsFNlXlMos([In] object obj0, [In] object obj1) => (object) ((IQuery) obj0).SetResultTransformer((IResultTransformer) obj1);

    internal static object TbyNpmwkvXxaV4xD07x([In] object obj0, [In] int obj1) => (object) ((IQuery) obj0).SetMaxResults(obj1);

    internal static object dE0Ns3wDy0fZhM3XCui([In] object obj0, [In] bool obj1) => (object) ((IQuery) obj0).CleanUpCache(obj1);

    internal static void oUcgtPwaiyCWwxhJLA5([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).DebugFormat((string) obj1, (object[]) obj2);

    internal static Guid EGfKj2wxFwZoIQW9ELx([In] object obj0) => ((EleWise.ELMA.Security.Models.IUser) obj0).Uid;

    internal static int qxVC4gwC7fZI6PnA7Sb([In] int obj0, [In] int obj1) => Math.Max(obj0, obj1);

    internal static void n1a10HwiH2l5veLw8h3([In] object obj0, [In] AuthenticatedSessionStatus obj1) => ((AuthenticatedSessionInfo) obj0).Status = obj1;

    internal static void YcJ8wuw3sL9X8RGWHnG([In] object obj0, [In] bool obj1) => ((AuthenticatedSessionInfo) obj0).CreationIsCurrent = obj1;

    internal static Guid IkLMlVwj9hQfjwEqGUd([In] object obj0) => ((AuthenticatedSessionInfo) obj0).TicketUid;

    internal static void kFQvPkwN7Uu8H9HrtLp([In] object obj0, [In] object obj1, [In] object obj2) => ((IAbstractBoundVariableService) obj0).Set((string) obj1, obj2);

    internal static void ujmU4jw0gnr7s7xdZ4S([In] object obj0, [In] int obj1) => ((ReaderWriterLock) obj0).AcquireReaderLock(obj1);

    internal static object jdA3Z5wZB0lRhahE33M([In] object obj0) => (object) ((AuthenticatedSessionInfo) obj0).SessionId;

    internal static void TMF1xqwAyA279o6Z6i4([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).InfoFormat((string) obj1, (object[]) obj2);

    internal static DateTime q9iJZ1wsQtsRjJg6IKf([In] object obj0) => ((AuthenticatedSessionInfo) obj0).LastActionDate;

    internal static bool IaDA7Fw7lLSdsLwDPxK([In] DateTime obj0, [In] DateTime obj1) => obj0 > obj1;

    internal static void xmg0T6wWAjxcYHquHXK([In] object obj0, [In] DateTime obj1) => ((AuthenticatedSessionInfo) obj0).LastActionDate = obj1;

    internal static object vav07GwrAx4a5FZjMXP([In] object obj0) => (object) ((AuthenticatedSessionInfo) obj0).LastActionInfo;

    internal static void oamNf1wSMq38hJNBOtM([In] object obj0, [In] object obj1) => ((AuthenticatedSessionInfo) obj0).LastActionInfo = (string) obj1;

    internal static void n4Mn9fwYsivxEuOKp8x([In] object obj0, [In] object obj1) => ((AuthenticatedSessionInfo) obj0).UpdateFromHttpContext((HttpContextBase) obj1);

    internal static void xHdOIewypW0aLuuXIbq([In] object obj0) => ((ReaderWriterLock) obj0).ReleaseReaderLock();

    internal static object Ug9nuawVUwJQqpurqpM([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static object qPCCi3wlWxv0frL7jom([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object V9YNOUwf40i39sYOvTM([In] object obj0, [In] object obj1, [In] Guid obj2) => (object) ((IQuery) obj0).SetGuid((string) obj1, obj2);

    internal static int mA3YrJw46rjpZqFZqX3([In] object obj0, [In] bool obj1) => ((IQuery) obj0).ExecuteUpdate(obj1);

    internal static object o3uVt6wcsBlrPpYFqLA([In] object obj0) => ((AuthenticatedSessionInfo) obj0).UserId;

    internal static long imP64EwP8A1T2kdJqsw([In] object obj0) => Convert.ToInt64(obj0);

    internal static void A2u8NxwQnxHZ1dWDWX4([In] object obj0, [In] object obj1) => ((AuthenticatedSessionFilter) obj0).UserId = obj1;

    internal static bool VfBIbCw89lSNOkea4MV([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object sFbB71w5uPGl9ZRh1B6([In] object obj0, [In] object obj1, [In] long obj2) => (object) ((IQuery) obj0).SetInt64((string) obj1, obj2);

    internal static object MKCVWywdpZTsSgDvVSW([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static System.Type vGacnDwEg9p0hK1cGsl([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object noybgMwGtU36hsLejJJ([In] object obj0, [In] object obj1) => ((IDataRecord) obj0)[(string) obj1];

    internal static void koru7DwXXuBZd1nOJCU([In] object obj0, [In] Guid obj1) => ((AuthenticatedSessionInfo) obj0).TicketUid = obj1;

    internal static void qBvWgiw9NENxbgMZ3We([In] object obj0, [In] object obj1) => ((AuthenticatedSessionInfo) obj0).SessionId = (string) obj1;

    internal static void TwWLsPw1HxyN8oDGXuw([In] object obj0, [In] object obj1) => ((AuthenticatedSessionInfo) obj0).RemoteAddress = (string) obj1;

    internal static void qQuUdNwMadhKuVx0Urp([In] object obj0, [In] DateTime obj1) => ((AuthenticatedSessionInfo) obj0).CreationDate = obj1;

    internal static DateTime pCw5CUwhn0VyWpd4KlF([In] object obj0) => ((Dialect) obj0).MinDateTime;

    internal static void bWdOMOwB55QsbM9GSHZ([In] object obj0, [In] DateTime obj1) => ((AuthenticatedSessionInfo) obj0).LastPingDate = obj1;

    internal static bool z2eaTtwpREKlA1SkLSq([In] object obj0) => ((AuthenticatedSessionInfo) obj0).LastActionIsCurrent;

    internal static object epThfCwOk6A54f8Ttt4([In] object obj0) => (object) ((Dialect) obj0).ConfigurationInfoCurrentTimestamp;

    internal static object qPTm2ZwTjYxOQY8q2U5([In] object obj0) => (object) ((ITransformationProvider) obj0).ParameterSeparator;

    internal static DateTime ag1GJXwFPogtWHwQTGr() => DateTime.Now;

    internal static TimeSpan DCJLYCwvEw0Tvm764hV([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static int n28jfewqLWH5KXNHhMV() => ActiveUserSessionService.SavingActivityTimeoutTime;

    internal static TimeSpan YqZAP7wgi9EF7hJJCe0([In] double obj0) => TimeSpan.FromSeconds(obj0);

    internal static bool v2kP7UwJxEiKWNGMnBV([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 >= obj1;

    internal static void sjj5T2wIYcdEI6gNA2l([In] object obj0, [In] int obj1) => ((ReaderWriterLock) obj0).AcquireWriterLock(obj1);

    internal static void Msi3NWwe8alN7T8e9ei([In] object obj0) => ((ReaderWriterLock) obj0).ReleaseWriterLock();

    internal static bool txLXuAwnpi4RVTBEVpy([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 > obj1;

    internal static TimeSpan sj85inwLEDEQv74Eijq([In] double obj0) => TimeSpan.FromMinutes(obj0);

    internal static object ueeEJqw21EuL5syHIWc([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((Dialect) obj0).AddSecond((string) obj1, (string) obj2);

    internal static object jp1YwLwHCH4yLbNcImp([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object TTcgiWwzB7fL9Rkxc8j([In] object obj0, [In] object obj1, [In] int obj2) => (object) ((IQuery) obj0).SetInt32((string) obj1, obj2);

    internal static int TvFypmbuehI9ndkTdKA([In] object obj0) => ((ICollection<AuthenticatedSessionInfo>) obj0).Count;

    internal static object zrsUa9bw43cHSicrngl([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) string.Format((string) obj0, obj1, obj2, obj3);

    internal static int TtWGjZbbTp2qlI0EWjK([In] object obj0) => ((Dictionary<long, EleWise.ELMA.Security.Models.IUser>) obj0).Count;

    internal static object DOGkdFbK1xWtX9X4xrA([In] object obj0) => (object) ((ComponentManager) obj0).ModuleManager;

    internal static object xdKqqcbU2xfUMOHlOJN([In] object obj0, [In] Guid obj1) => (object) ((IModuleManager) obj0).FindUnitByUid(obj1);

    internal static object PvmAZhbRgbehmvPHk5q([In] object obj0) => (object) ((ILicensedModuleAssembly) obj0).LicenseUnit;

    internal static object QrCakwbo0JxKpcNhFdr() => (object) UserManager.Instance;

    internal static object n53sjBbtnGLy5L430k3(
      [In] object obj0,
      [In] object obj1,
      [In] bool obj2,
      [In] IsolationLevel obj3)
    {
      return (object) ((IUnitOfWorkManager) obj0).Create((string) obj1, obj2, obj3);
    }

    internal static object rBBL6Gbmqbw6tKZKl66([In] object obj0, [In] object obj1) => (object) ((ILockManager) obj0).Lock((string) obj1);

    internal static void mTOM0sb60hbMvll8nEO([In] object obj0) => ((IUnitOfWork) obj0).Commit();

    internal static object Gc6li5bkrAm6aL0etbM([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) ((Dialect) obj0).InsertIf((string) obj1, (string) obj2, (string) obj3);

    internal static object iMxrl4bDbFs9Dm31SYj([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) ((IQuery) obj0).SetParameter((string) obj1, obj2, (IType) obj3);

    internal static object M2EKUYbaG4yKb3IZHTK([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).GetNamedQuery((string) obj1);

    internal static AuthenticatedSessionStatus DDTESObxqlxDxF8Yc2x(
      [In] object obj0)
    {
      return ((AuthenticatedSessionInfo) obj0).Status;
    }

    internal static object MJ1FYBbCYUcSf26wGhw([In] object obj0) => (object) ((AuthenticatedSessionInfo) obj0).RemoteAddress;

    internal static DateTime wQUFUKbiUCDeAsn3sba([In] object obj0) => ((AuthenticatedSessionInfo) obj0).CreationDate;

    internal static DateTime NfsflQb3YxyjqUwqnDL([In] object obj0) => ((AuthenticatedSessionInfo) obj0).LastPingDate;

    internal static object Q1gPiXbjs0VL4daGXyO([In] object obj0, [In] object obj1, [In] bool obj2) => (object) ((IQuery) obj0).SetBoolean((string) obj1, obj2);

    internal static bool Ge7bEnbNQ0DSHNwAJy7([In] object obj0) => ((AuthenticatedSessionInfo) obj0).LastPingIsCurrent;

    internal static bool tjK6hEb0bdbSJ1LxeoF([In] object obj0) => ((SecuritySettings) obj0).IsPrivilegedLicense;

    internal static TimeSpan S5q8CAbZrerN4db80H2([In] object obj0) => ((SecuritySettings) obj0).SignOutOnPingTimeoutTime;

    internal static bool y3TxYXbAJFfN6By08tQ([In] object obj0) => ((SecuritySettings) obj0).SignOutOnActionTimeout;

    internal static TimeSpan g30qhwbs5lxlOIqN2sk([In] object obj0) => ((SecuritySettings) obj0).SignOutOnActionTimeoutTime;

    internal static bool MLTESxb7K4fPwj6WOBa([In] object obj0) => ((SecuritySettings) obj0).SignOutPrivilegedUsers;

    internal static TimeSpan Qtbmd8bWnymTJuaQjuq([In] object obj0) => ((SecuritySettings) obj0).SignOutPrivilegedUsersTimeoutTime;

    internal static void uQ8nhXbrsljs6AlwOwY() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static object uNDnjDbSjgjlyYJYLZ1([In] System.Type obj0) => (object) Logger.GetLogger(obj0);

    private class SetTimeout : IDisposable
    {
      private object _owner;
      private int? _lastTimeout;
      private object _callOwner;
      internal static object t9q5I0wKvNx72G5EhCX0;

      public SetTimeout(ActiveUserSessionService owner)
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        this.\u002Ector(owner, -1);
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      public SetTimeout(ActiveUserSessionService owner, int timeout)
      {
        ActiveUserSessionService.SetTimeout.jA85PAwKJF8Jbo1opVr7();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 6;
        while (true)
        {
          switch (num)
          {
            case 1:
            case 5:
              this._callOwner = (object) CallContextSessionOwner.Create();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 2 : 2;
              continue;
            case 2:
              goto label_10;
            case 3:
              this._lastTimeout = ((ActiveUserSessionService) this._owner)._transform.SetCurrentContextTimeout(new int?(timeout <= 0 ? 30 : timeout));
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 == 0 ? 1 : 0;
              continue;
            case 4:
              this._owner = (object) owner;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 0 : 0;
              continue;
            case 6:
              if (owner != null)
              {
                num = 4;
                continue;
              }
              goto label_5;
            case 7:
              goto label_5;
            default:
              if (((ActiveUserSessionService) this._owner)._transform == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a != 0 ? 5 : 0;
                continue;
              }
              goto case 3;
          }
        }
label_10:
        return;
label_5:
        throw new ArgumentNullException((string) ActiveUserSessionService.SetTimeout.CwpY5OwKIagYxcuf5v2g(839394233 ^ 839403501));
      }

      public void Dispose()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              ActiveUserSessionService.SetTimeout.p7TLJMwKeqemtG4AeFNu(this._callOwner);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              ((ActiveUserSessionService) this._owner)._transform.SetCurrentContextTimeout(this._lastTimeout);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 0 : 2;
              continue;
            case 4:
              goto label_2;
            default:
              if (((ActiveUserSessionService) this._owner)._transform == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 != 0 ? 4 : 3;
                continue;
              }
              goto case 3;
          }
        }
label_3:
        return;
label_2:;
      }

      internal static bool Qn0XJjwKqwYfAahlmbeW() => ActiveUserSessionService.SetTimeout.t9q5I0wKvNx72G5EhCX0 == null;

      internal static ActiveUserSessionService.SetTimeout NqxqW3wKgrIjLXci2oX3() => (ActiveUserSessionService.SetTimeout) ActiveUserSessionService.SetTimeout.t9q5I0wKvNx72G5EhCX0;

      internal static void jA85PAwKJF8Jbo1opVr7() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

      internal static object CwpY5OwKIagYxcuf5v2g(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static void p7TLJMwKeqemtG4AeFNu([In] object obj0) => ((CallContextSessionOwner) obj0).Dispose();
    }

    [Component(EnableInterceptiors = false, Type = EleWise.ELMA.ComponentModel.ComponentType.WebServer)]
    [UsedImplicitly]
    private class ActiveUserSessionSweepHandler : ISweepHandler, IThreadPoolContainer
    {
      private readonly object _sweepPool;
      internal static object ocoehHwKnTasls2CGVEM;

      public ActiveUserSessionSweepHandler()
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this._sweepPool = (object) new ThreadSubPool(1);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      IThreadPool IThreadPoolContainer.Pool => (IThreadPool) this._sweepPool;

      void ISweepHandler.Execute()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ActiveUserSessionService serviceNotNull = Locator.GetServiceNotNull<ActiveUserSessionService>();
              ActiveUserSessionService.ActiveUserSessionSweepHandler.tx6njZwKHghT6B3Ifoi2((object) serviceNotNull);
              ActiveUserSessionService.ActiveUserSessionSweepHandler.fRPvkiwKzfsmEpvnJY37((object) serviceNotNull);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      internal static bool ksqlupwKLyUun0XGnDpN() => ActiveUserSessionService.ActiveUserSessionSweepHandler.ocoehHwKnTasls2CGVEM == null;

      internal static ActiveUserSessionService.ActiveUserSessionSweepHandler qQwAnXwK26YNPyUxecBe() => (ActiveUserSessionService.ActiveUserSessionSweepHandler) ActiveUserSessionService.ActiveUserSessionSweepHandler.ocoehHwKnTasls2CGVEM;

      internal static void tx6njZwKHghT6B3Ifoi2([In] object obj0) => ((ActiveUserSessionService) obj0).ReloadSettings();

      internal static void fRPvkiwKzfsmEpvnJY37([In] object obj0) => ((ActiveUserSessionService) obj0).FlushUpdatedSessions();
    }

    [UsedImplicitly]
    [Component(Type = EleWise.ELMA.ComponentModel.ComponentType.WebServer)]
    private class ActiveUserSessionInitializer : IModuleContainerEvents
    {
      private static object LBNKk0wUu6lxypJac9Mp;

      public void Activated() => Locator.GetServiceNotNull<ActiveUserSessionService>().ReloadSettings();

      public void Terminating()
      {
      }

      public ActiveUserSessionInitializer()
      {
        ActiveUserSessionService.ActiveUserSessionInitializer.ntVLRqwUKSocHyAc2V1d();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void ntVLRqwUKSocHyAc2V1d() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

      internal static bool TyWsgfwUwYsIfcjMlsWB() => ActiveUserSessionService.ActiveUserSessionInitializer.LBNKk0wUu6lxypJac9Mp == null;

      internal static ActiveUserSessionService.ActiveUserSessionInitializer OKYFpdwUbLsxqESJpR7a() => (ActiveUserSessionService.ActiveUserSessionInitializer) ActiveUserSessionService.ActiveUserSessionInitializer.LBNKk0wUu6lxypJac9Mp;
    }
  }
}

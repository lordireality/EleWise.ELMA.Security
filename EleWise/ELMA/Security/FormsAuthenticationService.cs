// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.FormsAuthenticationService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace EleWise.ELMA.Security
{
  /// <summary>Сервис авторизации для веб-приложения</summary>
  [Service(EnableInterceptors = false, InjectProperties = true, Scope = ServiceScope.Application, Type = ComponentType.WebServer)]
  public class FormsAuthenticationService : IAuthenticationService
  {
    private readonly IHttpContextAccessor _httpContextAccessor;
    private IContextBoundVariableService _contextBoundVariables;
    [NotNull]
    private readonly IAuthenticationServiceEventHandler _authenticationServiceEventHandler;
    [NotNull]
    private readonly IAuthenticationServiceEventHandler2 _authenticationServiceEventHandler2;
    [NotNull]
    private readonly ActiveUserSessionService _activeUserSessionService;
    private ISessionProvider _sessionProvider;
    private static FormsAuthenticationService rwPbt2tw92kSrXCUMj8;

    private UserManager userManager => UserManager.Instance;

    private UserSecurityProfileManager userSecurityProfileManager => (UserSecurityProfileManager) FormsAuthenticationService.zW93WvtUZcgwHnBbaeh();

    public FormsAuthenticationService(
      IHttpContextAccessor httpContextAccessor,
      IContextObjects contextObjects,
      IAuthenticationServiceEventHandler authenticationServiceEventHandler,
      IAuthenticationServiceEventHandler2 authenticationServiceEventHandler2,
      ActiveUserSessionService activeUserSessionService)
    {
      FormsAuthenticationService.dE8ifWtRaeVkJmCJx26();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._httpContextAccessor = httpContextAccessor;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0 ? 2 : 2;
            continue;
          case 2:
            this.ContextObjects = contextObjects;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 == 0 ? 6 : 7;
            continue;
          case 3:
            this.Logger = (ILogger) FormsAuthenticationService.s2NeirtoM7SnEZc2iKJ();
            num = 5;
            continue;
          case 4:
            goto label_3;
          case 5:
            this.ExpirationTimeSpan = FormsAuthenticationService.r2vcnLtttqXivGtNMIB();
            num = 4;
            continue;
          case 6:
            this._activeUserSessionService = activeUserSessionService;
            num = 3;
            continue;
          case 7:
            this._authenticationServiceEventHandler = authenticationServiceEventHandler;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 == 0 ? 0 : 0;
            continue;
          default:
            this._authenticationServiceEventHandler2 = authenticationServiceEventHandler2;
            num = 6;
            continue;
        }
      }
label_3:;
    }

    public IContextObjects ContextObjects
    {
      get => this.\u003CContextObjects\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CContextObjects\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public TimeSpan ExpirationTimeSpan
    {
      get => this.\u003CExpirationTimeSpan\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CExpirationTimeSpan\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public ILogger Logger
    {
      get => this.\u003CLogger\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CLogger\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    private IContextBoundVariableService ContextBoundVariables
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this._contextBoundVariables == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_6;
            case 3:
              goto label_4;
            default:
              this._contextBoundVariables = Locator.GetService<IContextBoundVariableService>();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 != 0 ? 2 : 1;
              continue;
          }
        }
label_4:
        return this._contextBoundVariables;
label_6:
        return this._contextBoundVariables;
      }
    }

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
              sessionProvider = this._sessionProvider;
              if (sessionProvider == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this._sessionProvider = serviceNotNull = Locator.GetServiceNotNull<ISessionProvider>();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 != 0 ? 2 : 0;
              continue;
          }
        }
label_2:
        return sessionProvider;
label_6:
        return serviceNotNull;
      }
    }

    public IUser GetCurrentUser() => this.GetCurrentUser(true, false, out Guid _);

    /// <inheritdoc />
    public object GetCurrentUserId()
    {
      int num = 18;
      EleWise.ELMA.Security.Models.IUser contextUser;
      int result;
      UserHolder userHolder;
      while (true)
      {
        HttpContextBase httpContextBase;
        EleWise.ELMA.Security.Models.IUser user;
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (FormsAuthenticationService.WArL65taaWFVetBuARl((object) httpContextBase.User) is FormsIdentity)
            {
              if (int.TryParse((string) FormsAuthenticationService.N1opLZt3VL3XIIgk4C8((object) ((FormsAuthenticationTicket) FormsAuthenticationService.oCVIx8txBgHPcayM3T7((object) (FormsIdentity) FormsAuthenticationService.WArL65taaWFVetBuARl((object) httpContextBase.User))).UserData, FormsAuthenticationService.XQwE9RtinHVroOqPKNY(FormsAuthenticationService.xwIr6TtCbB3Pvq79FFY(789532496 ^ 1575286436 ^ 1928040562)))[0], out result))
              {
                num = 10;
                continue;
              }
              goto case 11;
            }
            else
            {
              num = 13;
              continue;
            }
          case 3:
            if (!contextUser.IsActive())
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 == 0 ? 1 : 7;
              continue;
            }
            goto label_3;
          case 4:
            httpContextBase = (HttpContextBase) FormsAuthenticationService.GXDSa0t61raUn5wODnr((object) this._httpContextAccessor);
            num = 5;
            continue;
          case 5:
            if (httpContextBase != null)
            {
              num = 6;
              continue;
            }
            goto label_22;
          case 6:
            if (FormsAuthenticationService.tTsXbvtDmitOYAY3fAf(FormsAuthenticationService.c4RWMCtkkva5MrxumWB((object) httpContextBase)))
            {
              num = 2;
              continue;
            }
            goto label_22;
          case 7:
          case 15:
            if (this.ContextBoundVariables != null)
            {
              num = 9;
              continue;
            }
            goto case 4;
          case 8:
            user = userHolder.Object;
            break;
          case 9:
            if (this.ContextBoundVariables.TryGetValue<UserHolder>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1567399832 << 6 ^ 1529335548), out userHolder))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 10:
            goto label_10;
          case 11:
            FormsAuthenticationService.cR4xmdtjH0yPSZklVxx((object) this.Logger, FormsAuthenticationService.xwIr6TtCbB3Pvq79FFY(150349507 - 521039768 ^ -370696537));
            num = 12;
            continue;
          case 12:
            goto label_9;
          case 13:
            goto label_22;
          case 14:
            user = (EleWise.ELMA.Security.Models.IUser) null;
            break;
          case 16:
            goto label_27;
          case 17:
            if (contextUser == null)
            {
              num = 15;
              continue;
            }
            goto case 3;
          case 18:
            contextUser = this.GetContextUser(false, out Guid _);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 != 0 ? 17 : 10;
            continue;
          default:
            if (userHolder != null)
            {
              num = 8;
              continue;
            }
            goto case 14;
        }
        if (user == null)
          num = 4;
        else
          goto label_27;
      }
label_3:
      return FormsAuthenticationService.RxZiZOtmlayOTZ31xlv((object) contextUser);
label_9:
      return (object) null;
label_10:
      return (object) result;
label_22:
      return (object) null;
label_27:
      return FormsAuthenticationService.RxZiZOtmlayOTZ31xlv((object) userHolder.Object);
    }

    public IUser GetCurrentUserInactive() => this.GetCurrentUser(true, true, out Guid _);

    private IUser GetCurrentUser(bool tryReSignIn, bool getInactiove, out Guid ticketId)
    {
      int num1 = 9;
      string str;
      UserHolder userHolder;
      EleWise.ELMA.Security.Models.IUser contextUser;
      IUser currentUserNonCached;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ticketId = userHolder.TicketId;
              num2 = 11;
              continue;
            case 2:
            case 4:
              if (this.ContextBoundVariables == null)
              {
                num2 = 10;
                continue;
              }
              goto default;
            case 3:
            case 10:
              currentUserNonCached = this.GetCurrentUserNonCached(tryReSignIn, out ticketId);
              num2 = 12;
              continue;
            case 5:
              goto label_23;
            case 6:
              if (contextUser.IsActive())
              {
                num2 = 18;
                continue;
              }
              goto label_29;
            case 7:
              if (!getInactiove)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 == 0 ? 6 : 1;
                continue;
              }
              goto label_28;
            case 8:
              if (contextUser != null)
              {
                num2 = 7;
                continue;
              }
              if (this.ContextBoundVariables == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0 ? 0 : 2;
                continue;
              }
              goto case 16;
            case 9:
              contextUser = this.GetContextUser(tryReSignIn, out ticketId);
              num2 = 8;
              continue;
            case 11:
              goto label_9;
            case 12:
              if (this.ContextBoundVariables != null)
              {
                num2 = 14;
                continue;
              }
              goto label_23;
            case 13:
              if (FormsAuthenticationService.kC7hHRtN6OnLHnn0Css((object) str))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 2 : 3;
                continue;
              }
              goto label_14;
            case 14:
              goto label_22;
            case 15:
              if (userHolder == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0 ? 4 : 1;
                continue;
              }
              goto case 1;
            case 16:
              if (this.ContextBoundVariables.TryGetValue<UserHolder>((string) FormsAuthenticationService.xwIr6TtCbB3Pvq79FFY(631805505 ^ 631815869), out userHolder))
              {
                num2 = 15;
                continue;
              }
              goto case 2;
            case 17:
              goto label_14;
            case 18:
              goto label_28;
            default:
              if (this.ContextBoundVariables.TryGetValue<string>((string) FormsAuthenticationService.xwIr6TtCbB3Pvq79FFY(1458233619 ^ 1458227423), out str))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 != 0 ? 13 : 0;
                continue;
              }
              goto case 3;
          }
        }
label_22:
        FormsAuthenticationService.EaPxC8tZHQDcICH6COd((object) this.ContextBoundVariables, FormsAuthenticationService.xwIr6TtCbB3Pvq79FFY(--353012470 ^ 353018378), (object) new UserHolder((EleWise.ELMA.Security.Models.IUser) currentUserNonCached, ticketId));
        num1 = 5;
      }
label_9:
      return (IUser) userHolder.Object;
label_14:
      return (IUser) this.userManager.LoadOrNull((long) FormsAuthenticationService.x6TEdht06pKOFGb9LIb((object) str));
label_23:
      return currentUserNonCached;
label_28:
      return (IUser) contextUser;
label_29:
      return (IUser) null;
    }

    private IUser GetCurrentUserNonCached(bool tryReSignIn, out Guid ticketId)
    {
      int num1 = 2;
      EleWise.ELMA.Security.Models.IUser user;
      IUser currentUserNonCached;
      while (true)
      {
        int num2 = num1;
        string str;
        string[] strArray;
        HttpContextBase httpContextBase;
        int result;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              ticketId = Guid.Empty;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 == 0 ? 1 : 1;
              continue;
            case 3:
              if (strArray.Length < 2)
              {
                num2 = 5;
                continue;
              }
              goto case 6;
            case 4:
            case 22:
              goto label_23;
            case 6:
              if (Guid.TryParse(strArray[1], out ticketId))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 != 0 ? 16 : 7;
                continue;
              }
              goto label_39;
            case 7:
              str = ((FormsAuthenticationTicket) FormsAuthenticationService.oCVIx8txBgHPcayM3T7((object) (FormsIdentity) FormsAuthenticationService.WArL65taaWFVetBuARl(FormsAuthenticationService.cRZv6JtAmcCpv1urmDd((object) httpContextBase)))).UserData;
              num2 = 20;
              continue;
            case 8:
            case 11:
              if (((IPrincipal) FormsAuthenticationService.cRZv6JtAmcCpv1urmDd((object) httpContextBase)).Identity is WindowsIdentity)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 != 0 ? 12 : 12;
                continue;
              }
              goto label_3;
            case 9:
              goto label_8;
            case 10:
              FormsAuthenticationService.cR4xmdtjH0yPSZklVxx((object) this.Logger, FormsAuthenticationService.xwIr6TtCbB3Pvq79FFY(1055964645 ^ 1055954025));
              num2 = 25;
              continue;
            case 12:
              if (((IEnumerable<string>) FormsAuthenticationService.zrGyIAt7HsFjinhLkiK(FormsAuthenticationService.soBrDRtsx1QhRru8Etx((object) httpContextBase.Request))).Contains<string>((string) FormsAuthenticationService.ROke5GtWcgvO71b5q1B()))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 1 : 15;
                continue;
              }
              goto label_3;
            case 13:
              goto label_3;
            case 14:
              goto label_11;
            case 15:
              try
              {
                str = (string) FormsAuthenticationService.k3MmomtS9KjxrYb0GlI((object) FormsAuthentication.Decrypt(((HttpCookie) FormsAuthenticationService.taMVVVtr8LY5rDOcI4p(FormsAuthenticationService.soBrDRtsx1QhRru8Etx(FormsAuthenticationService.c4RWMCtkkva5MrxumWB((object) httpContextBase)), FormsAuthenticationService.ROke5GtWcgvO71b5q1B())).Value));
                int num3 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed == 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_4;
                }
              }
              catch (Exception ex)
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 == 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_13;
                    default:
                      currentUserNonCached = (IUser) null;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b == 0 ? 1 : 0;
                      continue;
                  }
                }
              }
            case 16:
              user = this.userManager.LoadOrNull((long) result);
              num2 = 24;
              continue;
            case 17:
              goto label_12;
            case 18:
              if (httpContextBase == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af != 0 ? 22 : 22;
                continue;
              }
              goto case 26;
            case 19:
              if (int.TryParse(strArray[0], out result))
              {
                num2 = 3;
                continue;
              }
              goto case 10;
            case 20:
label_4:
              strArray = (string[]) FormsAuthenticationService.N1opLZt3VL3XIIgk4C8((object) str, (object) ((string) FormsAuthenticationService.xwIr6TtCbB3Pvq79FFY(1055964645 ^ 1055954019)).ToCharArray());
              num2 = 19;
              continue;
            case 21:
              if (user.IsActive())
              {
                num2 = 23;
                continue;
              }
              goto label_8;
            case 23:
              if (this.GetAndCheckSession(ticketId, user, tryReSignIn) != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 == 0 ? 17 : 17;
                continue;
              }
              goto label_11;
            case 24:
              if (user != null)
              {
                num2 = 21;
                continue;
              }
              goto label_8;
            case 25:
              goto label_43;
            case 26:
              if (!FormsAuthenticationService.tTsXbvtDmitOYAY3fAf(FormsAuthenticationService.c4RWMCtkkva5MrxumWB((object) httpContextBase)))
              {
                num2 = 4;
                continue;
              }
              if (FormsAuthenticationService.WArL65taaWFVetBuARl(FormsAuthenticationService.cRZv6JtAmcCpv1urmDd((object) httpContextBase)) is FormsIdentity)
                goto case 7;
              else
                goto label_25;
            default:
              goto label_39;
          }
        }
label_7:
        httpContextBase = (HttpContextBase) FormsAuthenticationService.GXDSa0t61raUn5wODnr((object) this._httpContextAccessor);
        num1 = 18;
        continue;
label_25:
        num1 = 8;
      }
label_3:
      return (IUser) null;
label_8:
      return (IUser) null;
label_11:
      return (IUser) null;
label_12:
      return (IUser) user;
label_13:
      return currentUserNonCached;
label_23:
      return (IUser) null;
label_39:
      return (IUser) null;
label_43:
      return (IUser) null;
    }

    /// <summary>Получить текущего пользователя системы</summary>
    /// <typeparam name="T">Тип пользователя</typeparam>
    /// <returns>Текущий пользователь, либо <c>null</c></returns>
    public T GetCurrentUser<T>() where T : IUser
    {
      IUser currentUser = this.GetCurrentUser();
      return currentUser == null ? default (T) : (T) currentUser;
    }

    /// <summary>
    /// Получить текущего пользователя системы (в том числе если он не активный)
    /// </summary>
    /// <typeparam name="T">Тип пользователя</typeparam>
    /// <returns>Текущий пользователь, либо <c>null</c></returns>
    public T GetCurrentUserInactive<T>() where T : IUser
    {
      IUser currentUserInactive = this.GetCurrentUserInactive();
      return currentUserInactive == null ? default (T) : (T) currentUserInactive;
    }

    /// <summary>Авторизовать пользователя системы</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="rememberMeSet">Запомнить авторизацию для следующей сессии</param>
    /// <param name="checkRequireChangePassword">Проверять обязательную смену пароля</param>
    public void SignIn([NotNull] IUser user, bool rememberMeSet, bool checkRequireChangePassword)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.SignIn(user, (string) null, rememberMeSet, checkRequireChangePassword);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Авторизовать пользователя системы</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="rememberMeSet">Запомнить авторизацию для следующей сессии</param>
    public void SignIn([NotNull] IUser user, bool rememberMeSet = false)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.SignIn(user, (string) null, rememberMeSet);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Авторизовать пользователя системы</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="tiketAdditionalData"> </param>
    /// <param name="rememberMeSet">Запомнить авторизацию для следующей сессии</param>
    public void SignIn([NotNull] IUser user, string tiketAdditionalData, bool rememberMeSet = false)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.SignIn(user, tiketAdditionalData, rememberMeSet, false);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Авторизовать пользователя системы</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="tiketAdditionalData"> </param>
    /// <param name="rememberMeSet">Запомнить авторизацию для следующей сессии</param>
    /// <param name="checkRequireChangePassword">Проверять обязательную смену пароля</param>
    public void SignIn(
      [NotNull] IUser user,
      string tiketAdditionalData,
      bool rememberMeSet,
      bool checkRequireChangePassword = false)
    {
      switch (1)
      {
        case 1:
          try
          {
            if (user != null)
            {
              int num1 = 24;
              while (true)
              {
                int num2;
                AuthenticatedSessionInfo authenticatedSessionInfo;
                HttpContextBase httpContext;
                string str1;
                HttpCookie httpCookie1;
                EleWise.ELMA.Security.Models.IUser user1;
                long id;
                DateTime expiration;
                string str2;
                DateTime dateTime;
                DateTime localTime;
                string userData;
                object obj;
                switch (num1)
                {
                  case 1:
                  case 7:
                    if (FormsAuthenticationService.NVFflftOEpMRkRYS29v() != null)
                    {
                      num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 18 : 14;
                      continue;
                    }
                    goto case 37;
                  case 2:
                  case 39:
                    if (httpContext != null)
                    {
                      num1 = 34;
                      continue;
                    }
                    goto case 40;
                  case 3:
                    if (!FormsAuthenticationService.CEPQ2DtV2GCCReKqASa((object) this.userSecurityProfileManager.Load(user1)))
                    {
                      num1 = 11;
                      continue;
                    }
                    goto label_42;
                  case 4:
                    goto label_61;
                  case 5:
                    FormsAuthenticationService.yyxhiZtq2dWlBcIPhng((object) this._authenticationServiceEventHandler, (object) user);
                    num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 == 0 ? 4 : 1;
                    continue;
                  case 6:
                    if (FormsAuthenticationService.vwvlGxtYv6R3tlO4vQ6((object) user1) != UserStatus.Blocked)
                    {
                      if (FormsAuthenticationService.vwvlGxtYv6R3tlO4vQ6((object) user1) != UserStatus.System)
                      {
                        if (checkRequireChangePassword)
                        {
                          num1 = 3;
                          continue;
                        }
                        goto case 11;
                      }
                      else
                      {
                        num1 = 35;
                        continue;
                      }
                    }
                    else
                    {
                      num1 = 10;
                      continue;
                    }
                  case 8:
                    FormsAuthenticationService.YF2q0MtddJPU0ngtZ5m((object) this._activeUserSessionService, (object) authenticatedSessionInfo, (object) (EleWise.ELMA.Security.Models.IUser) user);
                    num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e != 0 ? 33 : 36;
                    continue;
                  case 9:
                    userData = (string) FormsAuthenticationService.IKKUSptG3QlMhAVFgpd((object) userData, FormsAuthenticationService.xwIr6TtCbB3Pvq79FFY(19590779 ^ 19580925), (object) tiketAdditionalData);
                    num1 = 25;
                    continue;
                  case 10:
                    goto label_27;
                  case 11:
                    httpContext = (HttpContextBase) FormsAuthenticationService.GXDSa0t61raUn5wODnr((object) this._httpContextAccessor);
                    num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0 ? 12 : 12;
                    continue;
                  case 12:
                    if (httpContext != null)
                    {
                      num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 == 0 ? 27 : 24;
                      continue;
                    }
                    goto case 23;
                  case 13:
                    if (!rememberMeSet)
                    {
                      num1 = 7;
                      continue;
                    }
                    goto case 19;
                  case 14:
                    FormsAuthenticationService.sXDPEPtvo5l9cKS3O6H(FormsAuthenticationService.hugfCHtFqD36QcXQ2Xe(FormsAuthenticationService.Y07OqntcSTZGPAx6QPF((object) httpContext)), (object) httpCookie1);
                    num1 = 20;
                    continue;
                  case 15:
                    goto label_52;
                  case 16:
                    if (FormsAuthenticationService.JliuOJtlrQUGkViEyCH((object) httpContext) != null)
                    {
                      num1 = 28;
                      continue;
                    }
                    goto case 2;
                  case 17:
                    goto label_42;
                  case 18:
                    FormsAuthenticationService.hD2miKtTuHMimWwmD9q((object) httpCookie1, FormsAuthenticationService.NVFflftOEpMRkRYS29v());
                    num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 == 0 ? 22 : 37;
                    continue;
                  case 19:
                    FormsAuthenticationService.w1uc2vtQyXsJ9oa0jBJ((object) httpCookie1, expiration);
                    num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 == 0 ? 0 : 1;
                    continue;
                  case 20:
                    this.SetContextUser(user1, FormsAuthenticationService.yD4TnPtEKki6p9wHSjZ((object) authenticatedSessionInfo), true);
                    num1 = 5;
                    continue;
                  case 21:
                    localTime = dateTime.ToLocalTime();
                    num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0 ? 38 : 32;
                    continue;
                  case 22:
                    authenticatedSessionInfo.Expiration = new DateTime?(expiration);
                    num1 = 8;
                    continue;
                  case 23:
                    obj = (object) null;
                    goto label_60;
                  case 24:
                    user1 = this.CheckUserModel(user);
                    num1 = 6;
                    continue;
                  case 25:
                    str1 = (string) FormsAuthenticationService.FfIwvpt1KTLawITHl4D((object) new FormsAuthenticationTicket(1, (string) FormsAuthenticationService.oZCvirtXGQsotxs5fci((object) user1), localTime, expiration, rememberMeSet, userData, (string) FormsAuthenticationService.cMhFxet9ANifIBcYxcc()));
                    num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0 ? 30 : 11;
                    continue;
                  case 26:
                    userData = (string) FormsAuthenticationService.IKKUSptG3QlMhAVFgpd((object) id.ToString(), FormsAuthenticationService.xwIr6TtCbB3Pvq79FFY(--1403802000 ^ 1403811862), (object) FormsAuthenticationService.yD4TnPtEKki6p9wHSjZ((object) authenticatedSessionInfo).ToString());
                    num1 = 29;
                    continue;
                  case 27:
                    if (FormsAuthenticationService.JliuOJtlrQUGkViEyCH((object) httpContext) == null)
                    {
                      num1 = 23;
                      continue;
                    }
                    obj = FormsAuthenticationService.ED0PgrtfOirEfkSQ1S6((object) httpContext.Session);
                    goto label_60;
                  case 28:
                    FormsAuthenticationService.j0kg4Zt4CkBYHRYulBV(FormsAuthenticationService.JliuOJtlrQUGkViEyCH((object) httpContext), FormsAuthenticationService.xwIr6TtCbB3Pvq79FFY(~248518394 ^ -248517263), (object) str2);
                    num1 = 2;
                    continue;
                  case 29:
                    if (!FormsAuthenticationService.kC7hHRtN6OnLHnn0Css((object) tiketAdditionalData))
                    {
                      num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0 ? 9 : 8;
                      continue;
                    }
                    goto case 25;
                  case 30:
                    HttpCookie httpCookie2 = new HttpCookie((string) FormsAuthenticationService.ROke5GtWcgvO71b5q1B(), str1);
                    FormsAuthenticationService.SWTJhstMRV2IJW02uZ8((object) httpCookie2, true);
                    FormsAuthenticationService.F4WSWmtB6bSWiJABbyT((object) httpCookie2, FormsAuthenticationService.WovIVythXTgOcCGKpV4());
                    FormsAuthenticationService.sGTWGvtpn4FVdnwWZxc((object) httpCookie2, FormsAuthenticationService.cMhFxet9ANifIBcYxcc());
                    httpCookie1 = httpCookie2;
                    num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b != 0 ? 13 : 1;
                    continue;
                  case 31:
                    if (rememberMeSet)
                    {
                      num2 = 22;
                      break;
                    }
                    goto case 8;
                  case 32:
                    if (httpContext == null)
                    {
                      num2 = 39;
                      break;
                    }
                    goto case 16;
                  case 33:
                    ((HttpCookieCollection) FormsAuthenticationService.hugfCHtFqD36QcXQ2Xe(FormsAuthenticationService.Y07OqntcSTZGPAx6QPF((object) httpContext))).Remove((string) FormsAuthenticationService.ROke5GtWcgvO71b5q1B());
                    num1 = 14;
                    continue;
                  case 34:
                    FormsAuthenticationService.w1uc2vtQyXsJ9oa0jBJ(FormsAuthenticationService.DN3TqhtP92ZB7rUvFyx((object) ((HttpResponseBase) FormsAuthenticationService.Y07OqntcSTZGPAx6QPF((object) httpContext)).Cookies, FormsAuthenticationService.xwIr6TtCbB3Pvq79FFY(1076316568 ^ 1076322954)), DateTime.MinValue);
                    num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 == 0 ? 40 : 24;
                    continue;
                  case 35:
                    goto label_13;
                  case 36:
                    id = user1.Id;
                    num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 24 : 26;
                    continue;
                  case 37:
                    if (httpContext != null)
                    {
                      num1 = 33;
                      continue;
                    }
                    goto case 20;
                  case 38:
                    expiration = localTime.Add(this.ExpirationTimeSpan);
                    num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef == 0 ? 0 : 0;
                    continue;
                  case 40:
                    dateTime = FormsAuthenticationService.vZfJrrt8sfoIYR3Od2a();
                    num2 = 21;
                    break;
                  default:
                    authenticatedSessionInfo = new AuthenticatedSessionInfo(FormsAuthenticationService.MBGW00t5j2OprhBGM2n(), (object) user1.Id, httpContext);
                    num1 = 31;
                    continue;
                }
                num1 = num2;
                continue;
label_60:
                str2 = (string) obj;
                num1 = 32;
              }
label_61:
              break;
label_13:
              throw new AuthenticationException((string) FormsAuthenticationService.H1Z6EWtyAHVuXnvZ5N0((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-94240706 ^ -94229774)));
label_27:
              throw new AuthenticationException((string) FormsAuthenticationService.H1Z6EWtyAHVuXnvZ5N0(FormsAuthenticationService.xwIr6TtCbB3Pvq79FFY(928696104 ^ 928705976)));
label_42:
              throw new RequireChangePasswordException(user);
            }
label_52:
            throw new ArgumentNullException((string) FormsAuthenticationService.xwIr6TtCbB3Pvq79FFY(--353012470 ^ 353016462));
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af != 0)
              num = 3;
            while (true)
            {
              switch (num)
              {
                case 1:
                  FormsAuthenticationService.Xl3K7btgmdW47ArGBc9((object) this._authenticationServiceEventHandler2, (object) user, (object) ex);
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c == 0 ? 0 : 0;
                  continue;
                case 3:
                  if (user == null)
                  {
                    num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d == 0 ? 1 : 2;
                    continue;
                  }
                  goto case 1;
                default:
                  goto label_70;
              }
            }
label_70:
            throw;
          }
      }
    }

    /// <inheritdoc />
    public void SetAuthenticatedUserIdForRequest(object userId)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FormsAuthenticationService.EaPxC8tZHQDcICH6COd((object) this.ContextBoundVariables, FormsAuthenticationService.xwIr6TtCbB3Pvq79FFY(-901653144 ^ -901647196), (object) userId.ToString());
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

    /// <summary>
    /// Получить информацию о текущей активной сессии контекста
    /// </summary>
    /// <returns>Сессия</returns>
    public AuthenticatedSessionInfo GetCurrentSession()
    {
      int num = 1;
      Guid ticketId;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.GetContextUser(false, out ticketId);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this._activeUserSessionService.Get(ticketId);
    }

    /// <summary>
    /// Получить информацию об активных авторизованных сессиях
    /// </summary>
    /// <returns></returns>
    public IEnumerable<AuthenticatedSessionInfo> GetActiveSessions() => this._activeUserSessionService.GetSessions(new AuthenticatedSessionFilter()
    {
      OnlyActive = true
    });

    /// <summary>Получить информацию об авторизованных сессиях</summary>
    /// <param name="filter">Фильтр</param>
    /// <returns></returns>
    public IEnumerable<AuthenticatedSessionInfo> GetSessions(
      AuthenticatedSessionFilter filter)
    {
      return this._activeUserSessionService.GetSessions(filter);
    }

    /// <summary>Удалить авторизованную сессию</summary>
    /// <param name="ticketId"></param>
    public void RemoveSession(Guid ticketId)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FormsAuthenticationService.oVeQFetJ0GqtQaHalDP((object) this._activeUserSessionService, ticketId);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Удалить все авторизованные сессии указанного пользователя
    /// </summary>
    /// <param name="userId">Идентификатор пользователя</param>
    public void RemoveAllUserSessions(object userId)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FormsAuthenticationService.YfHUUutItfj4bGoEaFP((object) this._activeUserSessionService, userId);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private EleWise.ELMA.Security.Models.IUser CheckUserModel(IUser user)
    {
      int num = 1;
      EleWise.ELMA.Security.Models.IUser user1;
      while (true)
      {
        switch (num)
        {
          case 1:
            user1 = user as EleWise.ELMA.Security.Models.IUser;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 3:
            goto label_5;
          default:
            if (user1 != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a == 0 ? 2 : 2;
              continue;
            }
            goto label_5;
        }
      }
label_5:
      // ISSUE: type reference
      throw new ArgumentException((string) FormsAuthenticationService.ETIN2ftnPr6ao6Y8R4C(FormsAuthenticationService.xwIr6TtCbB3Pvq79FFY(658384612 ^ 658378204), (object) new object[1]
      {
        (object) FormsAuthenticationService.rAWCwFte4yTvx8cvhyf(__typeref (EleWise.ELMA.Security.Models.IUser)).FullName
      }));
label_6:
      return user1;
    }

    private void ClearContextUser()
    {
      int num = 6;
      while (true)
      {
        UserHolder userHolder;
        switch (num)
        {
          case 1:
            if (FormsAuthenticationService.PaK8FitLmoYIuBSdhHA(userHolder.TicketId, Guid.Empty))
            {
              num = 7;
              continue;
            }
            break;
          case 2:
            goto label_7;
          case 3:
            if (userHolder != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0 ? 1 : 1;
              continue;
            }
            break;
          case 4:
            FormsAuthenticationService.EaPxC8tZHQDcICH6COd((object) this.ContextBoundVariables, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1100789287 - 1555711667 ^ -454933322), (object) null);
            num = 8;
            continue;
          case 5:
          case 8:
            userHolder = this.ContextObjects.Get<UserHolder>();
            num = 3;
            continue;
          case 6:
            if (this.ContextBoundVariables == null)
            {
              num = 5;
              continue;
            }
            goto case 4;
          case 7:
            this.RemoveSession(userHolder.TicketId);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 != 0 ? 0 : 0;
            continue;
        }
        this.ContextObjects.Set<UserHolder>((UserHolder) null);
        num = 2;
      }
label_7:;
    }

    private void SetContextUser(EleWise.ELMA.Security.Models.IUser user, Guid tickedId, bool inSession = false)
    {
      int num = 5;
      while (true)
      {
        UserHolder userHolder;
        switch (num)
        {
          case 1:
            this.ContextObjects.Set<UserHolder>(userHolder);
            num = 6;
            continue;
          case 2:
          case 3:
            if (inSession)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff != 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          case 4:
            if (this.ContextBoundVariables == null)
            {
              num = 3;
              continue;
            }
            break;
          case 5:
            userHolder = new UserHolder(user, tickedId);
            num = 4;
            continue;
          case 6:
            goto label_10;
        }
        FormsAuthenticationService.EaPxC8tZHQDcICH6COd((object) this.ContextBoundVariables, FormsAuthenticationService.xwIr6TtCbB3Pvq79FFY(2086891181 ^ 2086880623), (object) userHolder);
        num = 2;
      }
label_10:
      return;
label_2:;
    }

    private EleWise.ELMA.Security.Models.IUser GetContextUser(
      bool tryReSignIn,
      out Guid ticketId)
    {
      int num1 = 18;
      Action<Action> action;
      UserHolder ctx;
      FormsAuthenticationService authenticationService;
      while (true)
      {
        switch (num1)
        {
          case 1:
            ticketId = Guid.Empty;
            num1 = 8;
            continue;
          case 3:
            action((Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    FormsAuthenticationService.\u003C\u003Ec__DisplayClass50_0.aFhPOJwmZO2jaolOAquD((object) authenticationService.ContextBoundVariables, FormsAuthenticationService.\u003C\u003Ec__DisplayClass50_0.cjdDICwm0OxF7TG4DOVf(4869926 >> 3 ^ 614950), (object) ctx);
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 != 0 ? 13 : 5;
            continue;
          case 4:
          case 13:
            if (ctx != null)
            {
              num1 = 2;
              continue;
            }
            goto case 20;
          case 5:
            goto label_13;
          case 6:
            if (!this.ContextBoundVariables.TryGetValue<UserHolder>((string) FormsAuthenticationService.xwIr6TtCbB3Pvq79FFY(-296013529 ^ -296019227), out ctx))
            {
              num1 = 4;
              continue;
            }
            goto case 3;
          case 7:
            ctx = (UserHolder) null;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 != 0 ? 0 : 1;
            continue;
          case 8:
            action = (Action<Action>) (set =>
            {
              int num3 = 6;
              while (true)
              {
                int num4 = num3;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_6;
                    case 2:
                      goto label_14;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      FormsAuthenticationService.\u003C\u003Ec__DisplayClass50_0.wEm5U3wmNgdORfEQ4uor((object) set);
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af != 0 ? 1 : 0;
                      continue;
                    case 4:
                      goto label_5;
                    case 5:
                      if (ctx.Object != null)
                      {
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_3;
                    case 6:
                      if (ctx != null)
                      {
                        num4 = 5;
                        continue;
                      }
                      goto label_13;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (FormsAuthenticationService.\u003C\u003Ec__DisplayClass50_0.ptgiWJwmjfWUDvEgZtUX(FormsAuthenticationService.\u003C\u003Ec__DisplayClass50_0.MZvt6Owm3oeHIn9CvUpU((object) authenticationService.SessionProvider, (object) ""), (object) ctx.Object))
                      {
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0 ? 1 : 2;
                        continue;
                      }
                      goto label_5;
                  }
                }
label_5:
                ctx.Object = authenticationService.userManager.Load(ctx.Object.Id);
                num3 = 3;
              }
label_6:
              return;
label_14:
              return;
label_3:
              return;
label_13:;
            });
            num1 = 12;
            continue;
          case 9:
            if (ctx != null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0 ? 19 : 17;
              continue;
            }
            goto label_23;
          case 10:
            action((Action) (() =>
            {
              int num5 = 1;
              while (true)
              {
                switch (num5)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    authenticationService.ContextObjects.Set<UserHolder>(ctx);
                    num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 == 0 ? 0 : 0;
            continue;
          case 11:
            ticketId = FormsAuthenticationService.lb6OEkt2NvgmWZ10Thj((object) ctx);
            num1 = 14;
            continue;
          case 12:
            if (this.ContextBoundVariables != null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b != 0 ? 0 : 6;
              continue;
            }
            goto case 4;
          case 14:
            if (this.GetAndCheckSession(ticketId, ctx.Object, tryReSignIn) == null)
            {
              num1 = 5;
              continue;
            }
            goto case 9;
          case 15:
            if (!FormsAuthenticationService.PaK8FitLmoYIuBSdhHA(ctx.TicketId, Guid.Empty))
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af == 0 ? 9 : 4;
              continue;
            }
            goto case 11;
          case 16:
            goto label_23;
          case 17:
            authenticationService = this;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b == 0 ? 7 : 1;
            continue;
          case 18:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 == 0 ? 1 : 17;
            continue;
          case 19:
            goto label_24;
          case 20:
            ctx = this.ContextObjects.Get<UserHolder>();
            num1 = 10;
            continue;
          default:
            if (ctx != null)
            {
              num1 = 15;
              continue;
            }
            goto case 9;
        }
      }
label_13:
      return (EleWise.ELMA.Security.Models.IUser) null;
label_23:
      return (EleWise.ELMA.Security.Models.IUser) null;
label_24:
      return ctx.Object;
    }

    /// <summary>Убрать авторизацию пользователя</summary>
    public void SignOut()
    {
      int num = 6;
      HttpSessionState httpSessionState;
      EleWise.ELMA.Security.Models.IUser currentUser;
      Guid ticketId;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_20;
          case 2:
            FormsAuthenticationService.pI873gmw89Ni3LVDav1((object) httpSessionState);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 11 : 2;
            continue;
          case 3:
            if (FormsAuthenticationService.aoH1WHtHjv0k95cFX3x() != null)
            {
              num = 4;
              continue;
            }
            goto case 7;
          case 4:
            FormsAuthenticationService.BZmgABtzdS2X9JUbds4();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 0 : 0;
            continue;
          case 5:
            this.RemoveSession(ticketId);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0 ? 11 : 12;
            continue;
          case 6:
            currentUser = (EleWise.ELMA.Security.Models.IUser) this.GetCurrentUser(false, false, out ticketId);
            num = 5;
            continue;
          case 7:
          case 14:
            if (currentUser == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 == 0 ? 15 : 4;
              continue;
            }
            goto case 13;
          case 8:
            goto label_15;
          case 9:
            if (httpSessionState == null)
            {
              num = 7;
              continue;
            }
            goto case 2;
          case 10:
            this._authenticationServiceEventHandler.SignedOut((IUser) currentUser);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 6 : 8;
            continue;
          case 11:
            httpSessionState.Abandon();
            num = 14;
            continue;
          case 12:
            this.ClearContextUser();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 3 : 3;
            continue;
          case 13:
            if (!(FormsAuthenticationService.yy8jEImbkdxHHDt2jrP((object) currentUser) != SecurityConstants.SystemUserUid))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d == 0 ? 1 : 1;
              continue;
            }
            goto case 10;
          case 15:
            goto label_14;
          default:
            httpSessionState = (HttpSessionState) FormsAuthenticationService.iEy6GwmuK6k2kt01YwU(FormsAuthenticationService.aoH1WHtHjv0k95cFX3x());
            num = 9;
            continue;
        }
      }
label_20:
      return;
label_15:
      return;
label_14:;
    }

    /// <summary>Получить пользователя по SessionId</summary>
    /// <param name="sessionId"></param>
    /// <returns></returns>
    public IUser GetSessionUser(string sessionId)
    {
      int num1 = 4;
      AuthenticatedSessionInfo authenticatedSessionInfo;
      CallContextSessionOwner contextSessionOwner;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_12;
          case 2:
            goto label_13;
          case 3:
            if (authenticatedSessionInfo != null)
            {
              contextSessionOwner = CallContextSessionOwner.Create();
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0 ? 0 : 0;
              continue;
            }
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0 ? 1 : 2;
            continue;
          case 4:
            authenticatedSessionInfo = (AuthenticatedSessionInfo) FormsAuthenticationService.EBAkNUmK7W2ocIxk2wt((object) this._activeUserSessionService, (object) sessionId);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0 ? 3 : 3;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      IUser sessionUser;
      try
      {
        sessionUser = (IUser) UserManager.Instance.LoadOrNull((long) FormsAuthenticationService.uPqHaWmUe8tDSior1Co((object) authenticatedSessionInfo));
        int num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (contextSessionOwner == null)
          num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 != 0 ? 0 : 0;
        else
          goto label_9;
label_8:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_9:
        FormsAuthenticationService.Kv2MXxmRSIJZ2rimw4w((object) contextSessionOwner);
        num3 = 2;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0)
        {
          num3 = 1;
          goto label_8;
        }
        else
          goto label_8;
      }
label_12:
      return sessionUser;
label_13:
      return (IUser) null;
    }

    /// <summary>
    /// Установить авторизованного пользователя только в рамках этого запроса
    /// </summary>
    /// <param name="user">Пользователь</param>
    public void SetAuthenticatedUserForRequest(IUser user)
    {
      int num = 1;
      EleWise.ELMA.Security.Models.IUser user1;
      while (true)
      {
        switch (num)
        {
          case 1:
            user1 = this.CheckUserModel(user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.SetContextUser(user1, Guid.Empty);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    private AuthenticatedSessionInfo GetAndCheckSession(
      Guid ticketId,
      EleWise.ELMA.Security.Models.IUser user,
      bool tryReSignIn)
    {
      int num1 = 2;
      AuthenticatedSessionInfo sessionInfo;
      while (true)
      {
        int num2 = num1;
        HttpContextBase httpContextBase;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (sessionInfo != null)
              {
                if (FormsAuthenticationService.rIDJQ4moQ7EG87uqA45((object) sessionInfo) == AuthenticatedSessionStatus.Frozen)
                {
                  num2 = 7;
                  continue;
                }
                httpContextBase = this._httpContextAccessor.Current();
                num2 = 4;
                continue;
              }
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0 ? 0 : 0;
              continue;
            case 2:
              sessionInfo = this._activeUserSessionService.Get(ticketId);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 0 : 1;
              continue;
            case 3:
              goto label_15;
            case 4:
              FormsAuthenticationService.VYmRH6mtNAU4wcRi8op((object) this._activeUserSessionService, (object) sessionInfo, (object) httpContextBase);
              num2 = 5;
              continue;
            case 5:
              goto label_26;
            case 6:
              goto label_6;
            case 7:
              goto label_11;
            case 8:
              num2 = 3;
              continue;
            case 9:
              goto label_13;
            default:
              goto label_3;
          }
        }
label_11:
        if (tryReSignIn)
          num1 = 8;
        else
          goto label_6;
      }
label_3:
      return (AuthenticatedSessionInfo) null;
label_6:
      return (AuthenticatedSessionInfo) null;
label_13:
      return sessionInfo;
label_15:
      AuthenticatedSessionInfo andCheckSession;
      try
      {
        this._activeUserSessionService.Insert(sessionInfo, user);
        int num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_13;
        }
      }
      catch (SimultaneousSessionExceededException ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 == 0)
          num4 = 1;
        while (true)
        {
          switch (num4)
          {
            case 1:
              andCheckSession = (AuthenticatedSessionInfo) null;
              num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 0 : 0;
              continue;
            default:
              goto label_27;
          }
        }
      }
      catch (ConcurrentLicenseExceededException ex)
      {
        int num5 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 == 0)
          num5 = 0;
        while (true)
        {
          switch (num5)
          {
            case 1:
              andCheckSession = (AuthenticatedSessionInfo) null;
              num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 == 0 ? 0 : 0;
              continue;
            default:
              goto label_27;
          }
        }
      }
label_27:
      return andCheckSession;
label_26:
      return sessionInfo;
    }

    internal static object zW93WvtUZcgwHnBbaeh() => (object) UserSecurityProfileManager.Instance;

    internal static void dE8ifWtRaeVkJmCJx26() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static object s2NeirtoM7SnEZc2iKJ() => (object) NullLogger.Instance;

    internal static TimeSpan r2vcnLtttqXivGtNMIB() => FormsAuthentication.Timeout;

    internal static bool lpCt1htbrqZjYqWgeuK() => FormsAuthenticationService.rwPbt2tw92kSrXCUMj8 == null;

    internal static FormsAuthenticationService IbY1nZtKGaCHdj30Fag() => FormsAuthenticationService.rwPbt2tw92kSrXCUMj8;

    internal static object RxZiZOtmlayOTZ31xlv([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static object GXDSa0t61raUn5wODnr([In] object obj0) => (object) ((IHttpContextAccessor) obj0).Current();

    internal static object c4RWMCtkkva5MrxumWB([In] object obj0) => (object) ((HttpContextBase) obj0).Request;

    internal static bool tTsXbvtDmitOYAY3fAf([In] object obj0) => ((HttpRequestBase) obj0).IsAuthenticated;

    internal static object WArL65taaWFVetBuARl([In] object obj0) => (object) ((IPrincipal) obj0).Identity;

    internal static object oCVIx8txBgHPcayM3T7([In] object obj0) => (object) ((FormsIdentity) obj0).Ticket;

    internal static object xwIr6TtCbB3Pvq79FFY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object XQwE9RtinHVroOqPKNY([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static object N1opLZt3VL3XIIgk4C8([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);

    internal static void cR4xmdtjH0yPSZklVxx([In] object obj0, [In] object obj1) => ((ILogger) obj0).Fatal(obj1);

    internal static bool kC7hHRtN6OnLHnn0Css([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static int x6TEdht06pKOFGb9LIb([In] object obj0) => int.Parse((string) obj0);

    internal static void EaPxC8tZHQDcICH6COd([In] object obj0, [In] object obj1, [In] object obj2) => ((IAbstractBoundVariableService) obj0).Set((string) obj1, obj2);

    internal static object cRZv6JtAmcCpv1urmDd([In] object obj0) => (object) ((HttpContextBase) obj0).User;

    internal static object soBrDRtsx1QhRru8Etx([In] object obj0) => (object) ((HttpRequestBase) obj0).Cookies;

    internal static object zrGyIAt7HsFjinhLkiK([In] object obj0) => (object) ((HttpCookieCollection) obj0).AllKeys;

    internal static object ROke5GtWcgvO71b5q1B() => (object) FormsAuthentication.FormsCookieName;

    internal static object taMVVVtr8LY5rDOcI4p([In] object obj0, [In] object obj1) => (object) ((HttpCookieCollection) obj0)[(string) obj1];

    internal static object k3MmomtS9KjxrYb0GlI([In] object obj0) => (object) ((FormsAuthenticationTicket) obj0).UserData;

    internal static UserStatus vwvlGxtYv6R3tlO4vQ6([In] object obj0) => ((EleWise.ELMA.Security.Models.IUser) obj0).Status;

    internal static object H1Z6EWtyAHVuXnvZ5N0([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool CEPQ2DtV2GCCReKqASa([In] object obj0) => ((IUserSecurityProfile) obj0).ForcedChangePassword;

    internal static object JliuOJtlrQUGkViEyCH([In] object obj0) => (object) ((HttpContextBase) obj0).Session;

    internal static object ED0PgrtfOirEfkSQ1S6([In] object obj0) => (object) ((HttpSessionStateBase) obj0).SessionID;

    internal static void j0kg4Zt4CkBYHRYulBV([In] object obj0, [In] object obj1, [In] object obj2) => ((HttpSessionStateBase) obj0)[(string) obj1] = obj2;

    internal static object Y07OqntcSTZGPAx6QPF([In] object obj0) => (object) ((HttpContextBase) obj0).Response;

    internal static object DN3TqhtP92ZB7rUvFyx([In] object obj0, [In] object obj1) => (object) ((HttpCookieCollection) obj0).Get((string) obj1);

    internal static void w1uc2vtQyXsJ9oa0jBJ([In] object obj0, [In] DateTime obj1) => ((HttpCookie) obj0).Expires = obj1;

    internal static DateTime vZfJrrt8sfoIYR3Od2a() => DateTime.UtcNow;

    internal static Guid MBGW00t5j2OprhBGM2n() => Guid.NewGuid();

    internal static void YF2q0MtddJPU0ngtZ5m([In] object obj0, [In] object obj1, [In] object obj2) => ((ActiveUserSessionService) obj0).Insert((AuthenticatedSessionInfo) obj1, (EleWise.ELMA.Security.Models.IUser) obj2);

    internal static Guid yD4TnPtEKki6p9wHSjZ([In] object obj0) => ((AuthenticatedSessionInfo) obj0).TicketUid;

    internal static object IKKUSptG3QlMhAVFgpd([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object oZCvirtXGQsotxs5fci([In] object obj0) => (object) ((EleWise.ELMA.Security.Models.IUser) obj0).UserName;

    internal static object cMhFxet9ANifIBcYxcc() => (object) FormsAuthentication.FormsCookiePath;

    internal static object FfIwvpt1KTLawITHl4D([In] object obj0) => (object) FormsAuthentication.Encrypt((FormsAuthenticationTicket) obj0);

    internal static void SWTJhstMRV2IJW02uZ8([In] object obj0, [In] bool obj1) => ((HttpCookie) obj0).HttpOnly = obj1;

    internal static bool WovIVythXTgOcCGKpV4() => FormsAuthentication.RequireSSL;

    internal static void F4WSWmtB6bSWiJABbyT([In] object obj0, [In] bool obj1) => ((HttpCookie) obj0).Secure = obj1;

    internal static void sGTWGvtpn4FVdnwWZxc([In] object obj0, [In] object obj1) => ((HttpCookie) obj0).Path = (string) obj1;

    internal static object NVFflftOEpMRkRYS29v() => (object) FormsAuthentication.CookieDomain;

    internal static void hD2miKtTuHMimWwmD9q([In] object obj0, [In] object obj1) => ((HttpCookie) obj0).Domain = (string) obj1;

    internal static object hugfCHtFqD36QcXQ2Xe([In] object obj0) => (object) ((HttpResponseBase) obj0).Cookies;

    internal static void sXDPEPtvo5l9cKS3O6H([In] object obj0, [In] object obj1) => ((HttpCookieCollection) obj0).Add((HttpCookie) obj1);

    internal static void yyxhiZtq2dWlBcIPhng([In] object obj0, [In] object obj1) => ((IAuthenticationServiceEventHandler) obj0).SignedIn((IUser) obj1);

    internal static void Xl3K7btgmdW47ArGBc9([In] object obj0, [In] object obj1, [In] object obj2) => ((IAuthenticationServiceEventHandler2) obj0).SignInError((IUser) obj1, (Exception) obj2);

    internal static void oVeQFetJ0GqtQaHalDP([In] object obj0, Guid ticketId) => ((ActiveUserSessionService) obj0).RemoveSession(ticketId);

    internal static void YfHUUutItfj4bGoEaFP([In] object obj0, [In] object obj1) => ((ActiveUserSessionService) obj0).RemoveAllUserSessions(obj1);

    internal static Type rAWCwFte4yTvx8cvhyf([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object ETIN2ftnPr6ao6Y8R4C([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);

    internal static bool PaK8FitLmoYIuBSdhHA([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static Guid lb6OEkt2NvgmWZ10Thj([In] object obj0) => ((UserHolder) obj0).TicketId;

    internal static object aoH1WHtHjv0k95cFX3x() => (object) HttpContext.Current;

    internal static void BZmgABtzdS2X9JUbds4() => FormsAuthentication.SignOut();

    internal static object iEy6GwmuK6k2kt01YwU([In] object obj0) => (object) ((HttpContext) obj0).Session;

    internal static void pI873gmw89Ni3LVDav1([In] object obj0) => ((HttpSessionState) obj0).Clear();

    internal static Guid yy8jEImbkdxHHDt2jrP([In] object obj0) => ((EleWise.ELMA.Security.Models.IUser) obj0).Uid;

    internal static object EBAkNUmK7W2ocIxk2wt([In] object obj0, [In] object obj1) => (object) ((ActiveUserSessionService) obj0).FindBySessionId((string) obj1);

    internal static object uPqHaWmUe8tDSior1Co([In] object obj0) => ((AuthenticatedSessionInfo) obj0).UserId;

    internal static void Kv2MXxmRSIJZ2rimw4w([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static AuthenticatedSessionStatus rIDJQ4moQ7EG87uqA45(
      [In] object obj0)
    {
      return ((AuthenticatedSessionInfo) obj0).Status;
    }

    internal static void VYmRH6mtNAU4wcRi8op([In] object obj0, [In] object obj1, [In] object obj2) => ((ActiveUserSessionService) obj0).SetUpdated((AuthenticatedSessionInfo) obj1, (HttpContextBase) obj2);
  }
}

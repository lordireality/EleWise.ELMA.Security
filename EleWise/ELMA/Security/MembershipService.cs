// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.MembershipService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Security.Authentication;

namespace EleWise.ELMA.Security
{
  [Service(EnableInterceptors = false, Scope = ServiceScope.Shell)]
  internal class MembershipService : IMembershipService
  {
    [NotNull]
    private readonly UserManager _userManager;
    [NotNull]
    private readonly UserSecurityProfileManager _userSecurityProfileManager;
    [NotNull]
    private readonly IMembershipServiceEventHandler _membershipServiceEventHandler;
    [NotNull]
    private readonly IMembershipServiceEventHandler2 _membershipServiceEventHandler2;
    [NotNull]
    private readonly IAuthenticationService _authenticationService;
    internal static MembershipService FmhoVs6pZnHGOXW0b27;

    private bool TryUserError(UserValidationContext context)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            MembershipService.PBKmWM6JVFlrkZDFiC3((object) context, (object) new AuthenticationException((string) MembershipService.cnmfuE6gC1PAV1FV1es(MembershipService.rMsNmQ6qrjw64KEyiGj(19590779 ^ 19580139))));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 == 0 ? 3 : 3;
            continue;
          case 2:
            if (MembershipService.WaOm356v5H2ImLPu2Vd((object) (MembershipService.eTgJnj6F4jxJrR7supB((object) context) as EleWise.ELMA.Security.Models.IUser)) == UserStatus.Blocked)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 1 : 0;
              continue;
            }
            goto default;
          case 3:
          case 7:
            if (MembershipService.FTUWVy6I94YsvDwCMo4((object) context) != null)
            {
              num = 5;
              continue;
            }
            goto label_9;
          case 4:
            goto label_9;
          case 5:
            MembershipService.QYqIsW6eMnw9TjcFhTm((object) this._membershipServiceEventHandler2, (object) context);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b != 0 ? 3 : 4;
            continue;
          case 6:
            MembershipService.PBKmWM6JVFlrkZDFiC3((object) context, (object) new AuthenticationException((string) MembershipService.cnmfuE6gC1PAV1FV1es((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(868767899 ^ 868774487))));
            num = 7;
            continue;
          default:
            if (MembershipService.WaOm356v5H2ImLPu2Vd((object) (MembershipService.eTgJnj6F4jxJrR7supB((object) context) as EleWise.ELMA.Security.Models.IUser)) == UserStatus.System)
            {
              num = 6;
              continue;
            }
            goto case 3;
        }
      }
label_9:
      return MembershipService.FTUWVy6I94YsvDwCMo4((object) context) != null;
    }

    public static MembershipService Instance => Locator.GetServiceNotNull<MembershipService>();

    public MembershipService(
      UserManager userManager,
      UserSecurityProfileManager userSecurityProfileManager,
      IMembershipServiceEventHandler2 membershipServiceEventHandler2,
      IAuthenticationService authenticationService,
      IMembershipServiceEventHandler membershipServiceEventHandler)
    {
      MembershipService.vP56re6n5BN46HJ0Fe0();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 == 0)
        num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this._membershipServiceEventHandler = membershipServiceEventHandler;
            num = 3;
            continue;
          case 3:
            this._membershipServiceEventHandler2 = membershipServiceEventHandler2;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 != 0 ? 2 : 5;
            continue;
          case 4:
            this._userManager = userManager;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 != 0 ? 0 : 0;
            continue;
          case 5:
            this._authenticationService = authenticationService;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa == 0 ? 0 : 1;
            continue;
          default:
            this._userSecurityProfileManager = userSecurityProfileManager;
            num = 2;
            continue;
        }
      }
label_3:;
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
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0 ? 0 : 0;
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

    /// <summary>Получить настройки сервиса</summary>
    /// <returns>Настройки сервиса</returns>
    public MembershipSettings GetSettings() => new MembershipSettings();

    /// <summary>Получить настройки сервиса</summary>
    /// <returns>Настройки сервиса</returns>
    public MembershipSettings GetSettings(IUser user)
    {
      MembershipSettings settings = new MembershipSettings();
      MembershipService.yNvP0C6HKX9L8eXtNlH((object) settings, MembershipService.OtjlUt62cxfmHcA1tve(MembershipService.YKnwUu6LxFSF1tTKRHm((object) user), Guid.Empty));
      return settings;
    }

    /// <summary>Создать пользователя</summary>
    /// <param name="createUserParams">Параметры создания</param>
    /// <returns>Новый пользователь</returns>
    public IUser CreateUser(CreateUserParams createUserParams) => throw new NotImplementedException();

    /// <summary>Получить пользователя по имени</summary>
    /// <param name="username">Имя учетной записи</param>
    /// <returns>Пользователь, или <c>null</c></returns>
    public IUser GetUser(string username) => (IUser) MembershipService.DQnq7r6zS2xoob6dnKS((object) this._userManager, (object) username);

    /// <summary>Получить пользователя по идентификатору</summary>
    /// <param name="userId">Идентификатор пользователя</param>
    /// <returns>Пользователь, или <c>null</c></returns>
    public IUser GetUser(object userId)
    {
      int num = 1;
      long int64;
      while (true)
      {
        switch (num)
        {
          case 1:
            int64 = Convert.ToInt64(userId);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (IUser) this._userManager.LoadOrNull(int64);
    }

    /// <summary>Проверить авторизацию пользователя</summary>
    /// <param name="userNameOrEmail">Имя пользователя</param>
    /// <param name="password">Пароль</param>
    /// <returns><c>true</c>, если пользователь успешно авторизован</returns>
    public IUser ValidateUser([NotNull] string userNameOrEmail, string password)
    {
      int num1 = 2;
      EleWise.ELMA.Security.Models.IUser user1;
      UserValidationContext context1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              if (userNameOrEmail != null)
              {
                user1 = (EleWise.ELMA.Security.Models.IUser) MembershipService.DQnq7r6zS2xoob6dnKS((object) this._userManager, (object) userNameOrEmail);
                num2 = 5;
                continue;
              }
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_55;
            case 4:
              goto label_45;
            case 5:
              if (user1 == null)
                goto case 7;
              else
                goto label_44;
            case 6:
              goto label_49;
            case 7:
              IMembershipServiceEventHandler2 serviceEventHandler2 = this._membershipServiceEventHandler2;
              UserValidationContext context2 = new UserValidationContext();
              MembershipService.PBKmWM6JVFlrkZDFiC3((object) context2, (object) new Exception(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--534238571 ^ 534248175)), (object) userNameOrEmail)));
              serviceEventHandler2.ValidationError(context2);
              num2 = 4;
              continue;
            case 8:
              if (MembershipService.xpcxuckuSvHkSVDACLu((object) this._userSecurityProfileManager.Load(user1)))
              {
                num2 = 3;
                continue;
              }
              UserValidationContext validationContext = new UserValidationContext();
              MembershipService.B51oRgkwQ2igYxTsXOV((object) validationContext, false);
              MembershipService.Ce3m2Lkbvl600rsVIAA((object) validationContext, (object) user1);
              MembershipService.jSVfKxkK5y2QNDtEYat((object) validationContext, (object) password);
              context1 = validationContext;
              num2 = 9;
              continue;
            case 9:
              if (!this.TryUserError(context1))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 != 0 ? 0 : 0;
                continue;
              }
              num2 = 6;
              continue;
            default:
              goto label_6;
          }
        }
label_44:
        num1 = 8;
      }
label_3:
      throw new ArgumentNullException((string) MembershipService.rMsNmQ6qrjw64KEyiGj(-17837901 ^ -17825839));
label_6:
      IUser user2;
      try
      {
        MembershipService.GYb71ckU68CeANrhWYt((object) this._membershipServiceEventHandler, (object) context1);
        int num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 != 0)
          num3 = 6;
        while (true)
        {
          int num4;
          bool flag1;
          bool flag2;
          EleWise.ELMA.Security.Models.IUser user3;
          object obj;
          switch (num3)
          {
            case 1:
              if (flag2)
              {
                num4 = 8;
                break;
              }
              goto case 16;
            case 2:
              MembershipService.QYqIsW6eMnw9TjcFhTm((object) this._membershipServiceEventHandler2, (object) context1);
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 24 : 22;
              continue;
            case 3:
              flag2 = flag1;
              num3 = 15;
              continue;
            case 4:
              this._userSecurityProfileManager.ResetCountFailedLogon(user1);
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 23 : 21;
              continue;
            case 5:
              MembershipService.QYqIsW6eMnw9TjcFhTm((object) this._membershipServiceEventHandler2, (object) context1);
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 26 : 6;
              continue;
            case 6:
              flag2 = false;
              num4 = 10;
              break;
            case 7:
              if (!(user1.AuthProviderGuid == Guid.Empty))
              {
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 != 0 ? 12 : 12;
                continue;
              }
              goto case 17;
            case 8:
              obj = MembershipService.eTgJnj6F4jxJrR7supB((object) context1);
              goto label_38;
            case 9:
              goto label_46;
            case 10:
              if (MembershipService.FTUWVy6I94YsvDwCMo4((object) context1) != null)
              {
                num3 = 2;
                continue;
              }
              goto case 20;
            case 11:
              if (user3 != null)
              {
                num3 = 21;
                continue;
              }
              goto case 15;
            case 12:
            case 25:
              MembershipService.oCfTdPk6MV0VeOT5QfH((object) Locator.GetServiceNotNull<IExternalMembershipManager>(), (object) context1, MembershipService.Dxga6ekmnfyNttyO5LV((object) user1));
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 == 0 ? 20 : 27;
              continue;
            case 13:
              this.SetFailedLogon(user1);
              num3 = 18;
              continue;
            case 14:
            case 24:
            case 26:
              goto label_45;
            case 15:
            case 19:
              if (!flag2)
              {
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 == 0 ? 13 : 4;
                continue;
              }
              goto case 4;
            case 16:
              obj = (object) null;
              goto label_38;
            case 17:
              user3 = (EleWise.ELMA.Security.Models.IUser) MembershipService.CH4sMdktf2mYmRoMW9V((object) this._userManager, MembershipService.dUIZ6mkR1Gow3Pr6lFk(MembershipService.eTgJnj6F4jxJrR7supB((object) context1)), MembershipService.tYLx56koCHhhlvHIQH5((object) context1));
              num4 = 11;
              break;
            case 18:
            case 23:
              if (MembershipService.FTUWVy6I94YsvDwCMo4((object) context1) != null)
              {
                num3 = 5;
                continue;
              }
              goto case 22;
            case 20:
              MembershipService.B51oRgkwQ2igYxTsXOV((object) context1, false);
              num3 = 7;
              continue;
            case 21:
              context1.User = (IUser) user3;
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 0 : 0;
              continue;
            case 22:
              MembershipService.kLJlr3kDK4rt2D088X4((object) this._membershipServiceEventHandler, (object) context1);
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 == 0 ? 1 : 1;
              continue;
            case 27:
              flag2 = MembershipService.j617J5kkmPB6CIVBjv5((object) context1);
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 12 : 19;
              continue;
            default:
              MembershipService.B51oRgkwQ2igYxTsXOV((object) context1, flag1 = true);
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0 ? 1 : 3;
              continue;
          }
          num3 = num4;
          continue;
label_38:
          user2 = (IUser) obj;
          num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 != 0 ? 9 : 9;
        }
      }
      catch (Exception ex)
      {
        int num5 = 2;
        while (true)
        {
          switch (num5)
          {
            case 1:
              MembershipService.hPKtwlkx1pnwsXHfRNk((object) this.Logger, MembershipService.mlNmRFka05nxiMmR0t4((object) ex), (object) ex);
              num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 != 0 ? 0 : 0;
              continue;
            case 2:
              MembershipService.QYqIsW6eMnw9TjcFhTm((object) this._membershipServiceEventHandler2, (object) context1);
              num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 != 0 ? 1 : 1;
              continue;
            default:
              goto label_45;
          }
        }
      }
label_46:
      return user2;
label_45:
      return (IUser) null;
label_49:
      return (IUser) null;
label_55:
      return (IUser) null;
    }

    /// <summary>Установить новый пароль для пользователя</summary>
    /// <param name="user"></param>
    /// <param name="password"></param>
    public void SetPassword(IUser user, string password)
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_11;
          case 1:
            goto label_3;
          case 2:
            if (user != null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff != 0 ? 1 : 0;
              continue;
            }
            goto label_7;
          default:
            goto label_6;
        }
      }
label_11:
      return;
label_6:
      return;
label_3:
      try
      {
        MembershipService.n8QrO9kCTaIULQGVYDT((object) this._membershipServiceEventHandler, (object) user, (object) password);
        int num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab == 0)
          num2 = 0;
        switch (num2)
        {
          case 0:
            return;
          default:
            return;
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_13;
            default:
              MembershipService.hPKtwlkx1pnwsXHfRNk((object) this.Logger, MembershipService.mlNmRFka05nxiMmR0t4((object) ex), (object) ex);
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 != 0 ? 1 : 1;
              continue;
          }
        }
label_13:
        throw;
      }
label_7:;
    }

    /// <summary>Получить количество неудачных попыток входа</summary>
    /// <param name="userName">Логин пользователя</param>
    /// <returns>Количество неудачных попыток входа</returns>
    public long GetFailedLogon(string userName)
    {
      int num = 1;
      EleWise.ELMA.Security.Models.IUser user;
      while (true)
      {
        switch (num)
        {
          case 1:
            user = this.GetUser(userName) as EleWise.ELMA.Security.Models.IUser;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            if (user == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d == 0 ? 0 : 2;
              continue;
            }
            goto label_4;
        }
      }
label_3:
      return 0;
label_4:
      return MembershipService.hZ0lA3kikX9o05Obnvt((object) this._userSecurityProfileManager.Load(user));
    }

    /// <summary>Проверить обязательность смены пароля</summary>
    /// <param name="userId">Идентификатор пользователя</param>
    public void CheckRequireChangePassword(object userId)
    {
      int num = 4;
      EleWise.ELMA.Security.Models.IUser user;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if (!MembershipService.POdAD4k3Q922591Wchx((object) this._userSecurityProfileManager.Load(user)))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 == 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            goto label_7;
          case 3:
            if (user != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 == 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          case 4:
            user = this.GetUser(userId) as EleWise.ELMA.Security.Models.IUser;
            num = 3;
            continue;
          default:
            goto label_10;
        }
      }
label_2:
      return;
label_10:
      return;
label_6:
      return;
label_7:
      throw new RequireChangePasswordException((IUser) user);
    }

    private void SetFailedLogon(EleWise.ELMA.Security.Models.IUser user)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (MembershipService.GPUgwYkjr7aDoPUJnjQ((object) Locator.GetServiceNotNull<SecuritySettingsModule>().Settings) > 0)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            goto label_2;
          default:
            this._userSecurityProfileManager.FailedLogon(user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static object eTgJnj6F4jxJrR7supB([In] object obj0) => (object) ((UserValidationContext) obj0).User;

    internal static UserStatus WaOm356v5H2ImLPu2Vd([In] object obj0) => ((EleWise.ELMA.Security.Models.IUser) obj0).Status;

    internal static object rMsNmQ6qrjw64KEyiGj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object cnmfuE6gC1PAV1FV1es([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void PBKmWM6JVFlrkZDFiC3([In] object obj0, [In] object obj1) => ((UserValidationContext) obj0).Error = (Exception) obj1;

    internal static object FTUWVy6I94YsvDwCMo4([In] object obj0) => (object) ((UserValidationContext) obj0).Error;

    internal static void QYqIsW6eMnw9TjcFhTm([In] object obj0, [In] object obj1) => ((IMembershipServiceEventHandler2) obj0).ValidationError((UserValidationContext) obj1);

    internal static bool W8xvc76OSWxbUUHa2IP() => MembershipService.FmhoVs6pZnHGOXW0b27 == null;

    internal static MembershipService spWAIU6TaonE3KCppHu() => MembershipService.FmhoVs6pZnHGOXW0b27;

    internal static void vP56re6n5BN46HJ0Fe0() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static Guid YKnwUu6LxFSF1tTKRHm([In] object obj0) => ((IUser) obj0).AuthProviderGuid;

    internal static bool OtjlUt62cxfmHcA1tve([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static void yNvP0C6HKX9L8eXtNlH([In] object obj0, [In] bool obj1) => ((MembershipSettings) obj0).EnablePasswordReset = obj1;

    internal static object DQnq7r6zS2xoob6dnKS([In] object obj0, [In] object obj1) => (object) ((UserManager) obj0).LoadByLogin((string) obj1);

    internal static bool xpcxuckuSvHkSVDACLu([In] object obj0) => ((IUserSecurityProfile) obj0).DisallowLogon;

    internal static void B51oRgkwQ2igYxTsXOV([In] object obj0, [In] bool obj1) => ((UserValidationContext) obj0).Authorized = obj1;

    internal static void Ce3m2Lkbvl600rsVIAA([In] object obj0, [In] object obj1) => ((UserValidationContext) obj0).User = (IUser) obj1;

    internal static void jSVfKxkK5y2QNDtEYat([In] object obj0, [In] object obj1) => ((UserValidationContext) obj0).Password = (string) obj1;

    internal static void GYb71ckU68CeANrhWYt([In] object obj0, [In] object obj1) => ((IMembershipServiceEventHandler) obj0).Validating((UserValidationContext) obj1);

    internal static object dUIZ6mkR1Gow3Pr6lFk([In] object obj0) => (object) ((IUser) obj0).UserName;

    internal static object tYLx56koCHhhlvHIQH5([In] object obj0) => (object) ((UserValidationContext) obj0).Password;

    internal static object CH4sMdktf2mYmRoMW9V([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((UserManager) obj0).Login((string) obj1, (string) obj2);

    internal static Guid Dxga6ekmnfyNttyO5LV([In] object obj0) => ((EleWise.ELMA.Security.Models.IUser) obj0).AuthProviderGuid;

    internal static void oCfTdPk6MV0VeOT5QfH([In] object obj0, [In] object obj1, Guid authProviderGuid) => ((IExternalMembershipManager) obj0).ValidateUser((UserValidationContext) obj1, authProviderGuid);

    internal static bool j617J5kkmPB6CIVBjv5([In] object obj0) => ((UserValidationContext) obj0).Authorized;

    internal static void kLJlr3kDK4rt2D088X4([In] object obj0, [In] object obj1) => ((IMembershipServiceEventHandler) obj0).Validated((UserValidationContext) obj1);

    internal static object mlNmRFka05nxiMmR0t4([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void hPKtwlkx1pnwsXHfRNk([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void n8QrO9kCTaIULQGVYDT([In] object obj0, [In] object obj1, [In] object obj2) => ((IMembershipServiceEventHandler) obj0).SetPassword((IUser) obj1, (string) obj2);

    internal static long hZ0lA3kikX9o05Obnvt([In] object obj0) => ((IUserSecurityProfile) obj0).CountFailedLogon;

    internal static bool POdAD4k3Q922591Wchx([In] object obj0) => ((IUserSecurityProfile) obj0).ForcedChangePassword;

    internal static int GPUgwYkjr7aDoPUJnjQ([In] object obj0) => ((SecuritySettings) obj0).CountLogonAttempts;
  }
}

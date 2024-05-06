// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.UserPublicKeyTokenManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

namespace EleWise.ELMA.Security.Managers
{
  /// <summary>Менеджер токенов пользователя</summary>
  public class UserPublicKeyTokenManager : EntityManager<IUserPublicKeyToken, long>
  {
    private static UserPublicKeyTokenManager m76aHE14QWjtf81a72L;

    [NotNull]
    public static UserPublicKeyTokenManager Instance => Locator.GetServiceNotNull<UserPublicKeyTokenManager>();

    /// <summary>Зарегистрировать токен для пользователя</summary>
    /// <param name="user">Пользователь </param>
    /// <param name="name">Название устройства</param>
    /// <param name="deviceId">ID устройства</param>
    /// <param name="key">Открытый ключ токена</param>
    /// <returns></returns>
    public void RegisterToken(string name, string deviceId, string key, EleWise.ELMA.Security.Models.IUser user = null)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          EleWise.ELMA.Security.Models.IUser currentUser;
          ISecurityService serviceNotNull;
          IUserPublicKeyToken userPublicKeyToken1;
          // ISSUE: variable of a compiler-generated type
          UserPublicKeyTokenManager.\u003C\u003Ec__DisplayClass2_0 cDisplayClass20;
          switch (num2)
          {
            case 1:
              user = currentUser;
              num2 = 12;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass20.key = key;
              num2 = 4;
              continue;
            case 3:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass20 = new UserPublicKeyTokenManager.\u003C\u003Ec__DisplayClass2_0();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 != 0 ? 0 : 2;
              continue;
            case 4:
              currentUser = (EleWise.ELMA.Security.Models.IUser) Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
              num2 = 6;
              continue;
            case 5:
              goto label_14;
            case 6:
              if (user != null)
              {
                num2 = 11;
                continue;
              }
              goto case 1;
            case 7:
              IUserPublicKeyToken userPublicKeyToken2 = InterfaceActivator.Create<IUserPublicKeyToken>();
              UserPublicKeyTokenManager.YQoNxw1hZYqkSYXxYar((object) userPublicKeyToken2, (object) name);
              UserPublicKeyTokenManager.pg9IM21BOce34BIkMAk((object) userPublicKeyToken2, (object) user);
              // ISSUE: reference to a compiler-generated field
              UserPublicKeyTokenManager.npXBUU1pflxVM7lKjx9((object) userPublicKeyToken2, (object) cDisplayClass20.key);
              UserPublicKeyTokenManager.OnZbDs1OI1JGVIWDggg((object) userPublicKeyToken2, (object) deviceId);
              userPublicKeyToken2.Save();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0 ? 3 : 13;
              continue;
            case 8:
              if (!serviceNotNull.HasPermission((EleWise.ELMA.Security.IUser) currentUser, PermissionProvider.UserManagmentPermission))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 6 : 10;
                continue;
              }
              break;
            case 9:
              if (currentUser == user)
                break;
              goto label_4;
            case 10:
              goto label_24;
            case 11:
            case 12:
              serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d != 0 ? 1 : 9;
              continue;
            case 13:
              goto label_10;
            case 14:
              goto label_18;
            case 15:
              if (userPublicKeyToken1 == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 != 0 ? 7 : 7;
                continue;
              }
              goto default;
            default:
              if (UserPublicKeyTokenManager.YLo3gA1M7FlApSUXsRZ((object) userPublicKeyToken1) == user)
              {
                num2 = 14;
                continue;
              }
              goto label_19;
          }
          // ISSUE: reference to a compiler-generated field
          if (!string.IsNullOrEmpty(cDisplayClass20.key))
          {
            ParameterExpression parameterExpression;
            // ISSUE: method reference
            // ISSUE: type reference
            // ISSUE: field reference
            userPublicKeyToken1 = this.Find(Expression.Lambda<Func<IUserPublicKeyToken, bool>>((Expression) UserPublicKeyTokenManager.lwps2o11IDnDn20hWgj(UserPublicKeyTokenManager.rwOAZ61d0D95o47GWyp((object) parameterExpression, (object) (MethodInfo) UserPublicKeyTokenManager.ecby2P152uwV0XTxaTh(__methodref (IUserPublicKeyToken.get_PublicKey))), UserPublicKeyTokenManager.zEXdB219lymfECX7sNc(UserPublicKeyTokenManager.o4T5jW1GKBgnufYdJuD((object) cDisplayClass20, UserPublicKeyTokenManager.OV5gg71E2dmvWH4toNe(__typeref (UserPublicKeyTokenManager.\u003C\u003Ec__DisplayClass2_0))), UserPublicKeyTokenManager.SpkNok1XNEJ2ZSmf5Od(__fieldref (UserPublicKeyTokenManager.\u003C\u003Ec__DisplayClass2_0.key)))), parameterExpression)).FirstOrDefault<IUserPublicKeyToken>();
            num2 = 15;
          }
          else
            num2 = 5;
        }
label_4:
        num1 = 8;
      }
label_10:
      return;
label_14:
      throw new Exception((string) UserPublicKeyTokenManager.sqEpKU18GQIVHLqZ5yD(UserPublicKeyTokenManager.Xw8MdB1QkHfXMX7VdA8(-29763048 >> 5 ^ -979006)));
label_18:
      throw new Exception((string) UserPublicKeyTokenManager.sqEpKU18GQIVHLqZ5yD(UserPublicKeyTokenManager.Xw8MdB1QkHfXMX7VdA8(-1976147292 - 421656521 ^ 1897180139)));
label_19:
      throw new Exception((string) UserPublicKeyTokenManager.sqEpKU18GQIVHLqZ5yD(UserPublicKeyTokenManager.Xw8MdB1QkHfXMX7VdA8(581409346 ^ 581393350)));
label_24:
      throw new SecurityException((string) UserPublicKeyTokenManager.sqEpKU18GQIVHLqZ5yD(UserPublicKeyTokenManager.Xw8MdB1QkHfXMX7VdA8(-2143851882 - 923330995 ^ 1227756015)));
    }

    /// <summary>Отменить регистрацию токена для пользователя</summary>
    /// <param name="id"> </param>
    /// <param name="user"></param>
    public void UnRegisterToken(long id, EleWise.ELMA.Security.Models.IUser user = null)
    {
      int num1 = 14;
      while (true)
      {
        int num2 = num1;
        EleWise.ELMA.Security.Models.IUser user1;
        while (true)
        {
          TrustedDeviceService serviceNotNull1;
          IUserPublicKeyToken userPublicKeyToken;
          ISecurityService serviceNotNull2;
          switch (num2)
          {
            case 1:
              if (!serviceNotNull1.TrustedLogonEnabled((EleWise.ELMA.Security.IUser) user))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 == 0 ? 4 : 4;
                continue;
              }
              goto case 16;
            case 2:
            case 4:
            case 15:
              userPublicKeyToken = this.Load(id);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 != 0 ? 0 : 0;
              continue;
            case 3:
              if (((UserPublicKeyTokenManager) UserPublicKeyTokenManager.HTpMXF1qfmBaau0kEhh()).Count((EleWise.ELMA.Security.IUser) user) <= 1L)
                goto case 10;
              else
                goto label_22;
            case 5:
              UserPublicKeyTokenManager.w0uXaK1IhaLHJw7Nf31((object) userPublicKeyToken);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 == 0 ? 6 : 5;
              continue;
            case 6:
              goto label_20;
            case 7:
              goto label_9;
            case 8:
              serviceNotNull2 = Locator.GetServiceNotNull<ISecurityService>();
              num2 = 17;
              continue;
            case 9:
              goto label_12;
            case 10:
              if (!UserPublicKeyTokenManager.ss7UxU1J7hSmf3pnLqj(UserPublicKeyTokenManager.NjbwCh1gnrNyt7Rk6oA(), (object) user))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 9 : 8;
                continue;
              }
              goto case 2;
            case 11:
              if (UserPublicKeyTokenManager.gEFruN1FKew1RK8Fb2f((object) serviceNotNull2, (object) user1, (object) PermissionProvider.UserManagmentPermission))
                break;
              goto label_17;
            case 12:
              goto label_13;
            case 13:
              if (user == null)
              {
                num2 = 12;
                continue;
              }
              goto case 8;
            case 14:
              user1 = (EleWise.ELMA.Security.Models.IUser) UserPublicKeyTokenManager.dnE3v21ThirxCrhA4uY((object) Locator.GetServiceNotNull<IAuthenticationService>());
              num2 = 13;
              continue;
            case 16:
              if (UserPublicKeyTokenManager.D1e0Mh1vyRWIalsQX6d((object) serviceNotNull1.GetDevices((EleWise.ELMA.Security.IUser) user)) <= 0)
              {
                num2 = 3;
                continue;
              }
              goto case 2;
            case 17:
              if (user1 != user)
              {
                num2 = 11;
                continue;
              }
              break;
            default:
              if (userPublicKeyToken.User == user)
              {
                num2 = 5;
                continue;
              }
              goto label_11;
          }
          serviceNotNull1 = Locator.GetServiceNotNull<TrustedDeviceService>();
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 == 0 ? 1 : 1;
        }
label_13:
        user = user1;
        num1 = 8;
        continue;
label_17:
        num1 = 7;
        continue;
label_22:
        num1 = 2;
      }
label_20:
      return;
label_9:
      throw new SecurityException((string) UserPublicKeyTokenManager.sqEpKU18GQIVHLqZ5yD((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29763048 >> 5 ^ -958500)));
label_12:
      throw new Exception((string) UserPublicKeyTokenManager.sqEpKU18GQIVHLqZ5yD(UserPublicKeyTokenManager.Xw8MdB1QkHfXMX7VdA8(84189367 + 1997579375 ^ 2081785038)));
label_11:;
    }

    /// <summary>Получить токен пользователя</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    [Obsolete]
    public IUserPublicKeyToken GetToken(EleWise.ELMA.Security.IUser user)
    {
      int num = 1;
      // ISSUE: variable of a compiler-generated type
      UserPublicKeyTokenManager.\u003C\u003Ec__DisplayClass4_0 cDisplayClass40;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass40 = new UserPublicKeyTokenManager.\u003C\u003Ec__DisplayClass4_0();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass40.user = user;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a == 0 ? 2 : 0;
            continue;
        }
      }
label_2:
      // ISSUE: type reference
      ParameterExpression parameterExpression = (ParameterExpression) UserPublicKeyTokenManager.NFIcre1eXnKkpZshBAB(UserPublicKeyTokenManager.OV5gg71E2dmvWH4toNe(__typeref (IUserPublicKeyToken)), UserPublicKeyTokenManager.Xw8MdB1QkHfXMX7VdA8(868767899 ^ 868804307));
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: field reference
      return this.Find(Expression.Lambda<Func<IUserPublicKeyToken, bool>>((Expression) Expression.Equal((Expression) UserPublicKeyTokenManager.rwOAZ61d0D95o47GWyp((object) parameterExpression, (object) (MethodInfo) UserPublicKeyTokenManager.ecby2P152uwV0XTxaTh(__methodref (IUserPublicKeyToken.get_User))), (Expression) UserPublicKeyTokenManager.zEXdB219lymfECX7sNc(UserPublicKeyTokenManager.o4T5jW1GKBgnufYdJuD((object) cDisplayClass40, UserPublicKeyTokenManager.OV5gg71E2dmvWH4toNe(__typeref (UserPublicKeyTokenManager.\u003C\u003Ec__DisplayClass4_0))), UserPublicKeyTokenManager.SpkNok1XNEJ2ZSmf5Od(__fieldref (UserPublicKeyTokenManager.\u003C\u003Ec__DisplayClass4_0.user)))), parameterExpression)).FirstOrDefault<IUserPublicKeyToken>();
    }

    /// <summary>Получить токены пользователя</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public IEnumerable<IUserPublicKeyToken> GetTokens(EleWise.ELMA.Security.IUser user = null)
    {
      EleWise.ELMA.Security.IUser searchUser = user ?? Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
      return (IEnumerable<IUserPublicKeyToken>) this.Find((Expression<Func<IUserPublicKeyToken, bool>>) (userPublicKeyToken => userPublicKeyToken.User == searchUser));
    }

    /// <summary>Получить токен по откытому ключу</summary>
    /// <param name="user"></param>
    /// <param name="publicKey"></param>
    /// <returns></returns>
    public IUserPublicKeyToken GetTokenByPublicKey(EleWise.ELMA.Security.IUser user, string publicKey)
    {
      int num1 = 3;
      // ISSUE: variable of a compiler-generated type
      UserPublicKeyTokenManager.\u003C\u003Ec__DisplayClass6_0 cDisplayClass60;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass60.publicKey = publicKey;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0 ? 0 : 0;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass60.user = user;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_5;
            default:
              goto label_6;
          }
        }
label_5:
        // ISSUE: object of a compiler-generated type is created
        cDisplayClass60 = new UserPublicKeyTokenManager.\u003C\u003Ec__DisplayClass6_0();
        num1 = 2;
      }
label_6:
      // ISSUE: type reference
      ParameterExpression parameterExpression = (ParameterExpression) UserPublicKeyTokenManager.NFIcre1eXnKkpZshBAB(UserPublicKeyTokenManager.OV5gg71E2dmvWH4toNe(__typeref (IUserPublicKeyToken)), UserPublicKeyTokenManager.Xw8MdB1QkHfXMX7VdA8(928696104 ^ 928676192));
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: field reference
      return this.Find(Expression.Lambda<Func<IUserPublicKeyToken, bool>>((Expression) UserPublicKeyTokenManager.WfUAcK1n6np6311CTts(UserPublicKeyTokenManager.lwps2o11IDnDn20hWgj(UserPublicKeyTokenManager.rwOAZ61d0D95o47GWyp((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IUserPublicKeyToken.get_User))), UserPublicKeyTokenManager.zEXdB219lymfECX7sNc(UserPublicKeyTokenManager.o4T5jW1GKBgnufYdJuD((object) cDisplayClass60, UserPublicKeyTokenManager.OV5gg71E2dmvWH4toNe(__typeref (UserPublicKeyTokenManager.\u003C\u003Ec__DisplayClass6_0))), UserPublicKeyTokenManager.SpkNok1XNEJ2ZSmf5Od(__fieldref (UserPublicKeyTokenManager.\u003C\u003Ec__DisplayClass6_0.user)))), UserPublicKeyTokenManager.lwps2o11IDnDn20hWgj(UserPublicKeyTokenManager.rwOAZ61d0D95o47GWyp((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IUserPublicKeyToken.get_PublicKey))), UserPublicKeyTokenManager.zEXdB219lymfECX7sNc(UserPublicKeyTokenManager.o4T5jW1GKBgnufYdJuD((object) cDisplayClass60, UserPublicKeyTokenManager.OV5gg71E2dmvWH4toNe(__typeref (UserPublicKeyTokenManager.\u003C\u003Ec__DisplayClass6_0))), UserPublicKeyTokenManager.SpkNok1XNEJ2ZSmf5Od(__fieldref (UserPublicKeyTokenManager.\u003C\u003Ec__DisplayClass6_0.publicKey))))), parameterExpression)).FirstOrDefault<IUserPublicKeyToken>();
    }

    /// <summary>Получить количество токенов пользователя</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public long Count(EleWise.ELMA.Security.IUser user = null)
    {
      int num = 2;
      EleWise.ELMA.Security.Models.IUser user1;
      while (true)
      {
        EleWise.ELMA.Security.IUser user2;
        switch (num)
        {
          case 1:
            user2 = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
            break;
          case 2:
            EleWise.ELMA.Security.IUser user3 = user;
            if (user3 == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 == 0 ? 1 : 1;
              continue;
            }
            user2 = user3;
            break;
          default:
            goto label_4;
        }
        user1 = (EleWise.ELMA.Security.Models.IUser) user2;
        num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 != 0 ? 0 : 0;
      }
label_4:
      return this.Count((IEntityFilter) new InstanceOf<IUserPublicKeyTokenFilter>()
      {
        New = {
          User = user1
        }
      }.New);
    }

    /// <summary>Проверить наличие токенов пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <returns></returns>
    public bool Exists(EleWise.ELMA.Security.IUser user = null)
    {
      int num = 2;
      EleWise.ELMA.Security.Models.IUser user1;
      while (true)
      {
        object obj;
        switch (num)
        {
          case 1:
            obj = UserPublicKeyTokenManager.dnE3v21ThirxCrhA4uY((object) this.AuthenticationService);
            break;
          case 2:
            EleWise.ELMA.Security.IUser user2 = user;
            if (user2 == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 1 : 1;
              continue;
            }
            obj = (object) user2;
            break;
          default:
            goto label_2;
        }
        user1 = (EleWise.ELMA.Security.Models.IUser) obj;
        num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 0 : 0;
      }
label_2:
      InstanceOf<IUserPublicKeyTokenFilter> instanceOf = new InstanceOf<IUserPublicKeyTokenFilter>();
      UserPublicKeyTokenManager.XsYa5K1L6tmtP4edQiE((object) instanceOf.New, (object) user1);
      return UserPublicKeyTokenManager.zH9GHQ12AmioAbR9kdx((object) this, (object) instanceOf.New);
    }

    public UserPublicKeyTokenManager()
    {
      UserPublicKeyTokenManager.dGa30h1HeFLja8iTNZc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object Xw8MdB1QkHfXMX7VdA8(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object sqEpKU18GQIVHLqZ5yD([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object ecby2P152uwV0XTxaTh([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object rwOAZ61d0D95o47GWyp([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static Type OV5gg71E2dmvWH4toNe([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object o4T5jW1GKBgnufYdJuD([In] object obj0, [In] Type obj1) => (object) Expression.Constant(obj0, obj1);

    internal static object SpkNok1XNEJ2ZSmf5Od([In] RuntimeFieldHandle obj0) => (object) FieldInfo.GetFieldFromHandle(obj0);

    internal static object zEXdB219lymfECX7sNc([In] object obj0, [In] object obj1) => (object) Expression.Field((Expression) obj0, (FieldInfo) obj1);

    internal static object lwps2o11IDnDn20hWgj([In] object obj0, [In] object obj1) => (object) Expression.Equal((Expression) obj0, (Expression) obj1);

    internal static object YLo3gA1M7FlApSUXsRZ([In] object obj0) => (object) ((IUserPublicKeyToken) obj0).User;

    internal static void YQoNxw1hZYqkSYXxYar([In] object obj0, [In] object obj1) => ((IUserPublicKeyToken) obj0).Name = (string) obj1;

    internal static void pg9IM21BOce34BIkMAk([In] object obj0, [In] object obj1) => ((IUserPublicKeyToken) obj0).User = (EleWise.ELMA.Security.Models.IUser) obj1;

    internal static void npXBUU1pflxVM7lKjx9([In] object obj0, [In] object obj1) => ((IUserPublicKeyToken) obj0).PublicKey = (string) obj1;

    internal static void OnZbDs1OI1JGVIWDggg([In] object obj0, [In] object obj1) => ((IUserPublicKeyToken) obj0).DeviceId = (string) obj1;

    internal static bool UBIjj31cP9f1NNsY0dV() => UserPublicKeyTokenManager.m76aHE14QWjtf81a72L == null;

    internal static UserPublicKeyTokenManager Qjwnau1P3RcxRpKMurD() => UserPublicKeyTokenManager.m76aHE14QWjtf81a72L;

    internal static object dnE3v21ThirxCrhA4uY([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static bool gEFruN1FKew1RK8Fb2f([In] object obj0, [In] object obj1, [In] object obj2) => ((ISecurityService) obj0).HasPermission((EleWise.ELMA.Security.IUser) obj1, (Permission) obj2);

    internal static int D1e0Mh1vyRWIalsQX6d([In] object obj0) => ((List<DeviceToken>) obj0).Count;

    internal static object HTpMXF1qfmBaau0kEhh() => (object) UserPublicKeyTokenManager.Instance;

    internal static object NjbwCh1gnrNyt7Rk6oA() => (object) UserCertificateManager.Instance;

    internal static bool ss7UxU1J7hSmf3pnLqj([In] object obj0, [In] object obj1) => ((UserCertificateManager) obj0).Exists((EleWise.ELMA.Security.IUser) obj1);

    internal static void w0uXaK1IhaLHJw7Nf31([In] object obj0) => ((IEntity) obj0).Delete();

    internal static object NFIcre1eXnKkpZshBAB([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object WfUAcK1n6np6311CTts([In] object obj0, [In] object obj1) => (object) Expression.AndAlso((Expression) obj0, (Expression) obj1);

    internal static void XsYa5K1L6tmtP4edQiE([In] object obj0, [In] object obj1) => ((IUserPublicKeyTokenFilter) obj0).User = (EleWise.ELMA.Security.Models.IUser) obj1;

    internal static bool zH9GHQ12AmioAbR9kdx([In] object obj0, [In] object obj1) => __nonvirtual (((EntityManager<IUserPublicKeyToken, long>) obj0).Exists((IEntityFilter) obj1));

    internal static void dGa30h1HeFLja8iTNZc() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}

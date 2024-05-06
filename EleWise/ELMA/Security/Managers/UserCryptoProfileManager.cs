// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.UserCryptoProfileManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Managers
{
  /// <summary>Менеджер крипто профилей пользователя</summary>
  public class UserCryptoProfileManager : EntityManager<IUserCryptoProfile, long>
  {
    internal static UserCryptoProfileManager kmgqukXk3rHOZL4E3j3;

    /// <summary>Экземпляр</summary>
    [NotNull]
    public static UserCryptoProfileManager Instance => Locator.GetServiceNotNull<UserCryptoProfileManager>();

    /// <summary>Получить крипто профиль пользователя</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public IUserCryptoProfile GetUserCryptoProfile(EleWise.ELMA.Security.Models.IUser user)
    {
      int num = 2;
      // ISSUE: variable of a compiler-generated type
      UserCryptoProfileManager.\u003C\u003Ec__DisplayClass2_0 cDisplayClass20;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass20.user = user;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass20 = new UserCryptoProfileManager.\u003C\u003Ec__DisplayClass2_0();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 == 0 ? 1 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      ParameterExpression parameterExpression = (ParameterExpression) UserCryptoProfileManager.Mg505oXCTUU4ZWQG2fC(typeof (IUserCryptoProfile), UserCryptoProfileManager.ckDGJ0XxeuegmKYXQAu(-1212789817 - 1827404527 ^ 1254785004));
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: method reference
      return this.Find(Expression.Lambda<Func<IUserCryptoProfile, bool>>((Expression) Expression.Equal((Expression) UserCryptoProfileManager.g60iW8X3Q0iFR5dtYWf(UserCryptoProfileManager.g60iW8X3Q0iFR5dtYWf((object) parameterExpression, (object) (MethodInfo) UserCryptoProfileManager.TIBSaDXiRkdktOQX3rR(__methodref (IUserCryptoProfile.get_User))), (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EleWise.ELMA.Security.Models.IUser.get_Uid))), (Expression) UserCryptoProfileManager.g60iW8X3Q0iFR5dtYWf(UserCryptoProfileManager.tSXnm2X0U4TNHg2uVTU(UserCryptoProfileManager.boEZyXXNPlVJq2cDxAX((object) cDisplayClass20, UserCryptoProfileManager.NG4FvLXjBJMMsyGCaam(__typeref (UserCryptoProfileManager.\u003C\u003Ec__DisplayClass2_0))), (object) FieldInfo.GetFieldFromHandle(__fieldref (UserCryptoProfileManager.\u003C\u003Ec__DisplayClass2_0.user))), (object) (MethodInfo) UserCryptoProfileManager.TIBSaDXiRkdktOQX3rR(__methodref (EleWise.ELMA.Security.Models.IUser.get_Uid))), false, (MethodInfo) UserCryptoProfileManager.TIBSaDXiRkdktOQX3rR(__methodref (Guid.op_Equality))), parameterExpression)).FirstOrDefault<IUserCryptoProfile>();
    }

    /// <summary>
    /// Установить Uid криптопровайдера входа для текущего пользователя
    /// </summary>
    /// <param name="uid"></param>
    [Transaction]
    public virtual void SetCurrentUserAuthCryptoProviderUid(Guid uid)
    {
      int num = 2;
      EleWise.ELMA.Security.Models.IUser currentUser;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            UserCryptoProfileManager.EEc6MkXZTCji1fjNSDx((object) this, (object) currentUser, uid);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a == 0 ? 0 : 0;
            continue;
          case 2:
            currentUser = this.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>
    /// Установить Uid криптопровайдера входа для пользователя
    /// </summary>
    /// <param name="user"></param>
    /// <param name="uid"></param>
    [Transaction]
    public virtual void SetUserAuthCryptoProviderUid(EleWise.ELMA.Security.Models.IUser user, Guid uid)
    {
      int num1 = 1;
      Guid uid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.UpdateUserProfile(user, (Action<IUserCryptoProfile>) (p =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    p.AuthCryptoProviderGuid = new Guid?(uid1);
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 == 0 ? 2 : 2;
            continue;
          default:
            uid1 = uid;
            num1 = 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Получить Uid криптопровайдера входа для текущего пользователя
    /// </summary>
    /// <returns></returns>
    public Guid GetCurrentUserAuthCryptoProviderUid()
    {
      int num = 1;
      EleWise.ELMA.Security.Models.IUser currentUser;
      while (true)
      {
        switch (num)
        {
          case 1:
            currentUser = ((IAuthenticationService) UserCryptoProfileManager.HsBlPNXAVl1yrNIC45x((object) this)).GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this.GetUserAuthCryptoProviderUid(currentUser);
    }

    /// <summary>Получить Uid криптопровайдера входа для пользователя</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public Guid GetUserAuthCryptoProviderUid(EleWise.ELMA.Security.Models.IUser user)
    {
      int num = 2;
      IUserCryptoProfile userCryptoProfile;
      Guid? cryptoProviderGuid;
      while (true)
      {
        switch (num)
        {
          case 1:
            userCryptoProfile = this.GetUserCryptoProfile(user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 == 0 ? 7 : 3;
            continue;
          case 2:
            if (user != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 == 0 ? 1 : 0;
              continue;
            }
            goto label_8;
          case 3:
            goto label_8;
          case 4:
            goto label_2;
          case 5:
            cryptoProviderGuid = userCryptoProfile.AuthCryptoProviderGuid;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0 ? 6 : 1;
            continue;
          case 6:
            if (cryptoProviderGuid.HasValue)
            {
              cryptoProviderGuid = userCryptoProfile.AuthCryptoProviderGuid;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 0 : 0;
              continue;
            }
            num = 4;
            continue;
          case 7:
            if (userCryptoProfile != null)
            {
              num = 5;
              continue;
            }
            goto label_2;
          default:
            goto label_4;
        }
      }
label_2:
      return Guid.Empty;
label_4:
      return cryptoProviderGuid.Value;
label_8:
      return Guid.Empty;
    }

    /// <summary>
    /// Установить Uid типа электронной подписи для пользователя
    /// </summary>
    /// <param name="user"></param>
    /// <param name="uid"></param>
    [Transaction]
    public virtual void SetUserAuthDigitalSignatureTypeUid(EleWise.ELMA.Security.Models.IUser user, Guid uid)
    {
      int num1 = 3;
      Guid uid1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            this.UpdateUserProfile(user, (Action<IUserCryptoProfile>) (p =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    p.AuthDigitalSignatureTypeGuid = new Guid?(uid1);
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a != 0 ? 0 : 0;
            continue;
          case 2:
            uid1 = uid;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 == 0 ? 0 : 1;
            continue;
          case 3:
            num1 = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <summary>
    /// Получить Uid типа электронной подписи входа для пользователя
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public Guid GetUserAuthDigitalSignatureTypeUid(EleWise.ELMA.Security.Models.IUser user)
    {
      int num1 = 3;
      Guid? signatureTypeGuid;
      while (true)
      {
        int num2 = num1;
        IUserCryptoProfile userCryptoProfile;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (signatureTypeGuid.HasValue)
              {
                num2 = 7;
                continue;
              }
              goto label_6;
            case 2:
              userCryptoProfile = this.GetUserCryptoProfile(user);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_4;
            case 4:
            case 5:
              goto label_6;
            case 6:
              signatureTypeGuid = userCryptoProfile.AuthDigitalSignatureTypeGuid;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 1 : 0;
              continue;
            case 7:
              signatureTypeGuid = userCryptoProfile.AuthDigitalSignatureTypeGuid;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0 ? 0 : 8;
              continue;
            case 8:
              goto label_10;
            case 9:
              goto label_11;
            default:
              if (userCryptoProfile == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af != 0 ? 1 : 4;
                continue;
              }
              goto case 6;
          }
        }
label_4:
        if (user != null)
          num1 = 2;
        else
          goto label_11;
      }
label_6:
      return Guid.Empty;
label_10:
      return signatureTypeGuid.Value;
label_11:
      return Guid.Empty;
    }

    /// <summary>Обновить профиль</summary>
    /// <param name="user"></param>
    /// <param name="action"></param>
    [Transaction]
    public virtual void UpdateUserProfile(EleWise.ELMA.Security.Models.IUser user, Action<IUserCryptoProfile> action)
    {
      if (user == null)
        return;
      IUserCryptoProfile userCryptoProfile = this.GetUserCryptoProfile(user) ?? this.Create();
      userCryptoProfile.User = user;
      if (action != null)
        action(userCryptoProfile);
      userCryptoProfile.Save();
    }

    public UserCryptoProfileManager()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object ckDGJ0XxeuegmKYXQAu(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Mg505oXCTUU4ZWQG2fC([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object TIBSaDXiRkdktOQX3rR([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object g60iW8X3Q0iFR5dtYWf([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static Type NG4FvLXjBJMMsyGCaam([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object boEZyXXNPlVJq2cDxAX([In] object obj0, [In] Type obj1) => (object) Expression.Constant(obj0, obj1);

    internal static object tSXnm2X0U4TNHg2uVTU([In] object obj0, [In] object obj1) => (object) Expression.Field((Expression) obj0, (FieldInfo) obj1);

    internal static bool AebO4MXD3WmdADXkXol() => UserCryptoProfileManager.kmgqukXk3rHOZL4E3j3 == null;

    internal static UserCryptoProfileManager xZpmifXakbyaW50MZZN() => UserCryptoProfileManager.kmgqukXk3rHOZL4E3j3;

    internal static void EEc6MkXZTCji1fjNSDx([In] object obj0, [In] object obj1, Guid uid) => ((UserCryptoProfileManager) obj0).SetUserAuthCryptoProviderUid((EleWise.ELMA.Security.Models.IUser) obj1, uid);

    internal static object HsBlPNXAVl1yrNIC45x([In] object obj0) => (object) ((EntityManager<IUserCryptoProfile, long>) obj0).AuthenticationService;
  }
}

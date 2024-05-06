// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.UserModelMembershipEventHandler
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  [Component]
  internal class UserModelMembershipEventHandler : 
    IMembershipServiceEventHandler2,
    IMembershipServiceEventHandler,
    IEventHandler
  {
    private readonly UserManager userManager;
    private readonly UserSecurityProfileManager userSecurityProfileManager;
    internal static UserModelMembershipEventHandler aCF3566GW693EaUwytj;

    /// <summary>Ctor</summary>
    /// <param name="userManager">Менеджер пользователей</param>
    /// <param name="userSecurityProfileManager">Менеджер профилей безопасности пользователей</param>
    public UserModelMembershipEventHandler(
      UserManager userManager,
      UserSecurityProfileManager userSecurityProfileManager)
    {
      UserModelMembershipEventHandler.seVNkp61yLTr0wl7d36();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.userSecurityProfileManager = userSecurityProfileManager;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 0 : 0;
            continue;
          case 2:
            this.userManager = userManager;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 1 : 1;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Начало проверки авторизации</summary>
    /// <param name="context">Контекст проверки авторизации</param>
    public void Validating([NotNull] UserValidationContext context)
    {
    }

    /// <summary>Проверка авторизации завершена (возможно и неуспешно)</summary>
    /// <param name="context">Контекст проверки авторизации</param>
    public void Validated(UserValidationContext context)
    {
      int num = 6;
      EleWise.ELMA.Security.Models.IUser user;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_12;
          case 1:
            goto label_2;
          case 2:
            goto label_13;
          case 3:
            user = UserModelMembershipEventHandler.HMSnov6hHpNdG1ZZdYQ((object) context) as EleWise.ELMA.Security.Models.IUser;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 == 0 ? 0 : 7;
            continue;
          case 4:
            this.userSecurityProfileManager.ResetCountFailedLogon(user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0 ? 1 : 1;
            continue;
          case 5:
            if (context.Error != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 6:
            if (UserModelMembershipEventHandler.nphFFm6Mpc3PpmSruBY((object) context))
            {
              num = 5;
              continue;
            }
            goto label_3;
          case 7:
            if (user == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 == 0 ? 2 : 2;
              continue;
            }
            goto case 4;
          default:
            goto label_14;
        }
      }
label_12:
      return;
label_2:
      return;
label_13:
      return;
label_14:
      return;
label_3:;
    }

    /// <summary>Смена пароля пользователю</summary>
    /// <param name="user"></param>
    /// <param name="password"></param>
    public void SetPassword(IUser user, string password)
    {
      int num = 4;
      while (true)
      {
        EleWise.ELMA.Security.Models.IUser user1;
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            goto label_2;
          case 3:
            if (user1 == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 == 0 ? 0 : 1;
              continue;
            }
            break;
          case 4:
            user1 = user as EleWise.ELMA.Security.Models.IUser;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 == 0 ? 3 : 0;
            continue;
        }
        UserModelMembershipEventHandler.bvYSLI6BZs5lyJ76rrs((object) this.userManager, user1.Id, (object) password);
        num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 == 0 ? 2 : 2;
      }
label_5:
      return;
label_2:;
    }

    public void ValidationError(UserValidationContext context)
    {
    }

    internal static void seVNkp61yLTr0wl7d36() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool IBOp0M6XLY09D1AQyjx() => UserModelMembershipEventHandler.aCF3566GW693EaUwytj == null;

    internal static UserModelMembershipEventHandler mYEPs669euaYbDEjcrH() => UserModelMembershipEventHandler.aCF3566GW693EaUwytj;

    internal static bool nphFFm6Mpc3PpmSruBY([In] object obj0) => ((UserValidationContext) obj0).Authorized;

    internal static object HMSnov6hHpNdG1ZZdYQ([In] object obj0) => (object) ((UserValidationContext) obj0).User;

    internal static void bvYSLI6BZs5lyJ76rrs([In] object obj0, long userId, [In] object obj2) => ((UserManager) obj0).PasswordReset(userId, (string) obj2);
  }
}

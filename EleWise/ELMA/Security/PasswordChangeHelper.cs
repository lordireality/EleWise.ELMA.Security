// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.PasswordChangeHelper
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Text.RegularExpressions;

namespace EleWise.ELMA.Security
{
  public static class PasswordChangeHelper
  {
    private static Regex pattern;
    private static PasswordChangeHelper IGLAy3bH1g0SJsgdPgE;

    static PasswordChangeHelper()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PasswordChangeHelper.m4U2OtKwgr8jxXnhY2W();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            PasswordChangeHelper.pattern = new Regex((string) PasswordChangeHelper.XSe3rjKbvcxicux22tn(2086891181 ^ 2086893581));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Необходимо для текущего пользователя запрашивать текущий пароль при смене пароля указанного пользователя
    /// </summary>
    /// <param name="user">Пользователь, для которого меняется пароль</param>
    /// <param name="currentUser">Текущий пользователь</param>
    /// <returns></returns>
    public static bool NeedCurrentPassword(EleWise.ELMA.Security.Models.IUser user, EleWise.ELMA.Security.Models.IUser currentUser)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            if (currentUser == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            if (user.Id != currentUser.Id)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          default:
            goto label_6;
        }
      }
label_6:
      return !Locator.GetServiceNotNull<SecurityService>().HasPermission(PermissionProvider.UserManagmentPermission);
label_7:
      return true;
    }

    /// <summary>Проверка перед сменой пароля</summary>
    /// <param name="user">Пользователь, для которого меняется пароль</param>
    /// <param name="curPassword">Текущий пароль</param>
    /// <param name="newPassword">Новый пароль</param>
    /// <param name="confirmPassword">Повтор нового пароля</param>
    /// <returns></returns>
    public static Pair<bool, string> ValidatePassword(
      EleWise.ELMA.Security.Models.IUser user,
      string curPassword,
      string newPassword,
      string confirmPassword)
    {
      if (!user.IsActive())
        return new Pair<bool, string>(false, EleWise.ELMA.SR.NoTrueLogin);
      EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
      string error = string.Empty;
      bool isAllow = true;
      if (currentUser == null)
        Locator.GetServiceNotNull<ISecurityService>().RunByUser((IUser) user, (Action) (() =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                isAllow = user.AllowChangePassword(out error);
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
      else
        isAllow = user.AllowChangePassword(out error);
      if (!isAllow)
        return new Pair<bool, string>(false, error);
      IMembershipService service = Locator.GetService<IMembershipService>();
      bool flag = PasswordChangeHelper.NeedCurrentPassword(user, currentUser);
      if (flag && service.ValidateUser(user.UserName, curPassword) == null)
        return new Pair<bool, string>(false, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1880054609 ^ -1880050771)));
      if (flag && curPassword.Equals(newPassword))
        return new Pair<bool, string>(false, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-340788466 ^ -340792262)));
      if (!newPassword.Equals(confirmPassword))
        return new Pair<bool, string>(false, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(928696104 ^ 928698528)));
      SecuritySettings settings = Locator.GetServiceNotNull<SecuritySettingsModule>().Settings;
      int passwordMinLength = settings.PasswordMinLength;
      return newPassword.Length < passwordMinLength ? new Pair<bool, string>(false, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-340788466 ^ -340792130), (object) passwordMinLength)) : (settings.IsComplexPassword && !PasswordChangeHelper.pattern.IsMatch(newPassword) ? new Pair<bool, string>(false, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1095474805 ^ 155418997 ^ 1208485636))) : new Pair<bool, string>(true, ""));
    }

    /// <summary>Смена пароля</summary>
    /// <param name="user">Пользователь, для которого меняется пароль</param>
    /// <param name="curPassword">Текущий пароль</param>
    /// <param name="newPassword">Новый пароль</param>
    /// <param name="confirmPassword">Повтор нового пароля</param>
    /// <returns></returns>
    public static Pair<bool, string> ChangePassword(
      EleWise.ELMA.Security.Models.IUser user,
      string curPassword,
      string newPassword,
      string confirmPassword)
    {
      Pair<bool, string> pair = PasswordChangeHelper.ValidatePassword(user, curPassword, newPassword, confirmPassword);
      if (!pair.First)
        return new Pair<bool, string>(false, pair.Second);
      try
      {
        Locator.GetService<IMembershipService>().SetPassword((IUser) user, newPassword);
        EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
        if (currentUser == null || currentUser.Id == user.Id)
          UserSecurityProfileManager.Instance.ResetForcedChangePassword(user);
        return new Pair<bool, string>(true, "");
      }
      catch (Exception ex)
      {
        return new Pair<bool, string>(false, ex.Message);
      }
    }

    internal static void m4U2OtKwgr8jxXnhY2W() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static object XSe3rjKbvcxicux22tn(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool XOIvtObzFk3pxbOy5KR() => PasswordChangeHelper.IGLAy3bH1g0SJsgdPgE == null;

    internal static PasswordChangeHelper wF9YKaKu8JGhQkuATWh() => PasswordChangeHelper.IGLAy3bH1g0SJsgdPgE;
  }
}

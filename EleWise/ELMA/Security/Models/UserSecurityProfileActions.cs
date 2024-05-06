// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.UserSecurityProfileActions
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>
  /// Действия для объекта "Профиль безопасности пользователя"
  /// </summary>
  public class UserSecurityProfileActions : DefaultEntityActions
  {
    /// <summary>Заблокировать вход пользователя в систему</summary>
    [Uid("58e59b2b-fd5b-4f36-a2e2-d48ff5cdcaf7")]
    [DisplayName(typeof (__Resources_UserSecurityProfileActions), "P_DisallowLogon_DisplayName")]
    public const string DisallowLogon = "58e59b2b-fd5b-4f36-a2e2-d48ff5cdcaf7";
    private static Guid _disallowLogonGuid;
    /// <summary>Разблокировать вход пользователя в систему</summary>
    [Uid("2635ac67-8011-4f05-9d77-ee701271227a")]
    [DisplayName(typeof (__Resources_UserSecurityProfileActions), "P_AllowLogon_DisplayName")]
    public const string AllowLogon = "2635ac67-8011-4f05-9d77-ee701271227a";
    private static Guid _allowLogonGuid;
    /// <summary>Установить принудительную смену пароля</summary>
    [Uid("cc9044e1-4e2c-46a6-9ed7-6b42aa14daf7")]
    [DisplayName(typeof (__Resources_UserSecurityProfileActions), "P_SetForcedChangePassword_DisplayName")]
    public const string SetForcedChangePassword = "cc9044e1-4e2c-46a6-9ed7-6b42aa14daf7";
    private static Guid _setForcedChangePasswordGuid;
    /// <summary>Снять принудительную смену пароля</summary>
    [DisplayName(typeof (__Resources_UserSecurityProfileActions), "P_ResetForcedChangePassword_DisplayName")]
    [Uid("d1ef7b26-1d49-408d-a5c4-f204fca7c132")]
    public const string ResetForcedChangePassword = "d1ef7b26-1d49-408d-a5c4-f204fca7c132";
    private static Guid _resetForcedChangePasswordGuid;
    /// <summary>Сбросить количество неудачных попыток входа</summary>
    [DisplayName(typeof (__Resources_UserSecurityProfileActions), "P_ResetCountFailedLogon_DisplayName")]
    [Uid("9b776346-d67c-4e66-93e5-4de53e6846eb")]
    public const string ResetCountFailedLogon = "9b776346-d67c-4e66-93e5-4de53e6846eb";
    private static Guid _resetCountFailedLogonGuid;
    internal static UserSecurityProfileActions JS3Garf8A0OUU9GZ4PY;

    /// <summary>ctor</summary>
    protected UserSecurityProfileActions()
    {
      UserSecurityProfileActions.lDrIfffE1S0YJMrf5Ln();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Заблокировать вход пользователя в систему</summary>
    public static Guid DisallowLogonGuid => UserSecurityProfileActions._disallowLogonGuid;

    /// <summary>Разблокировать вход пользователя в систему</summary>
    public static Guid AllowLogonGuid => UserSecurityProfileActions._allowLogonGuid;

    /// <summary>Установить принудительную смену пароля</summary>
    public static Guid SetForcedChangePasswordGuid => UserSecurityProfileActions._setForcedChangePasswordGuid;

    /// <summary>Снять принудительную смену пароля</summary>
    public static Guid ResetForcedChangePasswordGuid => UserSecurityProfileActions._resetForcedChangePasswordGuid;

    /// <summary>Сбросить количество неудачных попыток входа</summary>
    public static Guid ResetCountFailedLogonGuid => UserSecurityProfileActions._resetCountFailedLogonGuid;

    static UserSecurityProfileActions()
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_3;
            case 1:
              UserSecurityProfileActions._resetForcedChangePasswordGuid = new Guid((string) UserSecurityProfileActions.FRYVPKfGOXD8Q7ALq34(--306199571 ^ 306201363));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 == 0 ? 6 : 0;
              continue;
            case 2:
              goto label_6;
            case 3:
              UserSecurityProfileActions.lDrIfffE1S0YJMrf5Ln();
              num2 = 2;
              continue;
            case 4:
              UserSecurityProfileActions._allowLogonGuid = new Guid((string) UserSecurityProfileActions.FRYVPKfGOXD8Q7ALq34(1677147940 ^ 1677148492));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 == 0 ? 1 : 5;
              continue;
            case 5:
              UserSecurityProfileActions._setForcedChangePasswordGuid = new Guid((string) UserSecurityProfileActions.FRYVPKfGOXD8Q7ALq34(44166125 ^ 44143961));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 1 : 1;
              continue;
            case 6:
              UserSecurityProfileActions._resetCountFailedLogonGuid = new Guid((string) UserSecurityProfileActions.FRYVPKfGOXD8Q7ALq34(-1807813747 ^ -1807840063));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f == 0 ? 0 : 0;
              continue;
            default:
              goto label_10;
          }
        }
label_6:
        UserSecurityProfileActions._disallowLogonGuid = new Guid((string) UserSecurityProfileActions.FRYVPKfGOXD8Q7ALq34(-278393783 ^ -278367659));
        num1 = 4;
      }
label_3:
      return;
label_10:;
    }

    internal static void lDrIfffE1S0YJMrf5Ln() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool wSAXF1f5oN5D7VRqIr9() => UserSecurityProfileActions.JS3Garf8A0OUU9GZ4PY == null;

    internal static UserSecurityProfileActions zEvem3fdOWu5qinYsiR() => UserSecurityProfileActions.JS3Garf8A0OUU9GZ4PY;

    internal static object FRYVPKfGOXD8Q7ALq34(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}

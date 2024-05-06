// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.SecurityConstants
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  /// <summary>Константы модуля Безопасность</summary>
  public static class SecurityConstants
  {
    /// <summary>Иднетификатор пользователя "Администратор"</summary>
    public static readonly Guid AdminUserUid;
    /// <summary>Иднетификатор пользователя "Система"</summary>
    public static readonly Guid SystemUserUid;
    /// <summary>Идентификатор группы "Администраторы"</summary>
    public static readonly Guid AdminGroupUid;
    /// <summary>Иднетификатор группы "Все пользователи"</summary>
    public static readonly Guid AllUsersGroupUid;
    /// <summary>Идентификатор группы "Конфигурирование ELMA"</summary>
    public static readonly Guid ConfiguringGroupUid;
    /// <summary>Идентификатор группы "Управление пользователями ELMA"</summary>
    public static readonly Guid UsersManagementGroupUid;
    /// <summary>
    /// Идентификатор группы "Привилегированный вход в систему ELMA"
    /// </summary>
    public static readonly Guid PrivilegeUsersGroupUid;
    /// <summary>Дескриптор для группы "Администраторы"</summary>
    public static readonly GroupDescriptor AdminGroupDescriptor;
    /// <summary>Дескриптор для группы "Все пользователи"</summary>
    public static readonly GroupDescriptor AllUsersGroupDescriptor;
    /// <summary>Дескриптор для группы "Конфигурирование ELMA"</summary>
    public static readonly GroupDescriptor ConfiguringGroupDescriptor;
    /// <summary>
    /// Дескриптор для группы "Управление пользователями ELMA"
    /// </summary>
    public static readonly GroupDescriptor UsersManagementGroupDescriptor;
    internal static SecurityConstants lmjpgPDUj31DEPOn7mG;

    static SecurityConstants()
    {
      int num1 = 11;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              SecurityConstants.UsersManagementGroupUid = new Guid((string) SecurityConstants.UlkoRQDmnXfMgTrxaXe(-909559362 ^ -398405015 ^ 562681699));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_11;
            case 3:
              SecurityConstants.UsersManagementGroupDescriptor = new GroupDescriptor(SecurityConstants.UsersManagementGroupUid, (string) SecurityConstants.RWfWfcD6g6Jv3C3BydY(SecurityConstants.UlkoRQDmnXfMgTrxaXe(-1310136491 - -570921450 ^ -739228101)), (string) SecurityConstants.RWfWfcD6g6Jv3C3BydY(SecurityConstants.UlkoRQDmnXfMgTrxaXe(1687460816 ^ 1687463060)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0 ? 7 : 1;
              continue;
            case 4:
              SecurityConstants.ConfiguringGroupUid = new Guid((string) SecurityConstants.UlkoRQDmnXfMgTrxaXe(-340788466 ^ -340801690));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0 ? 0 : 1;
              continue;
            case 5:
              SecurityConstants.AllUsersGroupUid = new Guid((string) SecurityConstants.UlkoRQDmnXfMgTrxaXe(1185105284 ^ 1185118616));
              num2 = 4;
              continue;
            case 6:
              goto label_5;
            case 7:
              goto label_3;
            case 8:
              SecurityConstants.SystemUserUid = new Guid((string) SecurityConstants.UlkoRQDmnXfMgTrxaXe(911364681 ^ 911370697));
              num2 = 9;
              continue;
            case 9:
              SecurityConstants.AdminGroupUid = new Guid((string) SecurityConstants.UlkoRQDmnXfMgTrxaXe(-169284490 ^ -169289818));
              num2 = 5;
              continue;
            case 10:
              SecurityConstants.AdminUserUid = new Guid((string) SecurityConstants.UlkoRQDmnXfMgTrxaXe(--180540780 ^ 180547160));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0 ? 8 : 4;
              continue;
            case 11:
              SecurityConstants.x7scUrDttTChEyKBnxl();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a == 0 ? 10 : 2;
              continue;
            case 12:
              SecurityConstants.AllUsersGroupDescriptor = new GroupDescriptor(SecurityConstants.AllUsersGroupUid, (string) SecurityConstants.RWfWfcD6g6Jv3C3BydY(SecurityConstants.UlkoRQDmnXfMgTrxaXe(-816108091 ^ -816116027)), (string) SecurityConstants.RWfWfcD6g6Jv3C3BydY(SecurityConstants.UlkoRQDmnXfMgTrxaXe(-1527733619 - 442652394 ^ -1970375041)));
              num2 = 2;
              continue;
            default:
              SecurityConstants.PrivilegeUsersGroupUid = new Guid((string) SecurityConstants.UlkoRQDmnXfMgTrxaXe(-296013529 ^ -296023001));
              num2 = 6;
              continue;
          }
        }
label_5:
        SecurityConstants.AdminGroupDescriptor = new GroupDescriptor(SecurityConstants.AdminGroupUid, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(386642440 ^ 386633540)), EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--180540780 ^ 180545536)));
        num1 = 12;
        continue;
label_11:
        SecurityConstants.ConfiguringGroupDescriptor = new GroupDescriptor(SecurityConstants.ConfiguringGroupUid, (string) SecurityConstants.RWfWfcD6g6Jv3C3BydY(SecurityConstants.UlkoRQDmnXfMgTrxaXe(1185105284 ^ 1185119190)), (string) SecurityConstants.RWfWfcD6g6Jv3C3BydY(SecurityConstants.UlkoRQDmnXfMgTrxaXe(-94240706 ^ -94224706)));
        num1 = 3;
      }
label_3:;
    }

    internal static void x7scUrDttTChEyKBnxl() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static object UlkoRQDmnXfMgTrxaXe(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object RWfWfcD6g6Jv3C3BydY([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool d1gPZbDRFgjXA09nwyM() => SecurityConstants.lmjpgPDUj31DEPOn7mG == null;

    internal static SecurityConstants rbP3ubDobd4ANvGCKkh() => SecurityConstants.lmjpgPDUj31DEPOn7mG;
  }
}

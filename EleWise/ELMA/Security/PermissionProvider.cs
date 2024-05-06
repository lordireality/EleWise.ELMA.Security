// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.PermissionProvider
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  /// <summary>Провайдер привилегий для модуля Безопасность</summary>
  [Component]
  public class PermissionProvider : IPermissionProvider
  {
    public const string Module = "EleWise.ELMA.Security";
    public const string APIAdminPermissionId = "A69D083E-F2E9-4E86-AF71-71A1E4BE91B0";
    /// <summary>Привилегия "Администрирование API"</summary>
    public static readonly Permission APIAdminPermission;
    public const string UserViewPermissionId = "DCD48F8C-BC6F-48BE-A9FF-25C4FAB101DC";
    /// <summary>Привилегия "Просмотр пользователей"</summary>
    public static readonly Permission UserViewPermission;
    public const string UserManagmentPermissionId = "2C44BA05-91A6-49E4-89C1-84AC5B371B7F";
    /// <summary>Привилегия "Администрирование пользователей"</summary>
    public static readonly Permission UserManagmentPermission;
    public const string AccessManagmentPermissionId = "0B298062-9DE5-46E5-8D1D-C46B3680809A";
    /// <summary>Привилегия "Администрирование настроек доступа"</summary>
    public static readonly Permission AccessManagmentPermission;
    public const string DenyEditPersonalDataPermissionId = "90A5014F-1DB1-4BF7-9DC3-AA059114BCB0";
    /// <summary>Привилегия "Запрет редактирования своего профиля"</summary>
    public static readonly Permission DenyEditPersonalDataPermission;
    public const string DenyPasswordResetPermissionId = "2CCAB1C7-B2A5-4C74-A4BB-E607FC939BDE";
    /// <summary>Привилегия "Запрет смены пароля пользователем"</summary>
    public static readonly Permission DenyPasswordResetPermission;
    /// <summary>Привилегия "Администрирование замещения"</summary>
    public const string ReplacementUsePermissionId = "08EE866C-5B8F-4D91-8BD7-0036B8DBAA0C";
    public static readonly Permission ReplacementUsePermission;
    /// <summary>
    /// Идентификтаор привилегии "Доступ к собственным замещениям"
    /// </summary>
    public const string ReplacementOwnPermissionId = "8AA2A0A4-2BD9-4F3B-8487-CAE95D6249D4";
    /// <summary>Привилегия "Доступ к собственным замещениям"</summary>
    public static readonly Permission ReplacementOwnPermission;
    /// <summary>Привилегия "Администрирование отсутствия"</summary>
    public const string AbsenceUsePermissionId = "22581049-E783-4F60-BF3F-FAC25C433E30";
    public static readonly Permission AbsenceUsePermission;
    /// <summary>
    /// Идентификатор привилегии "Доступ к собственным отсутствиям"
    /// </summary>
    public const string AbsenceOwnPermissionId = "C94736CF-EE73-4635-B1CB-C7E6BC315086";
    /// <summary>Привилегия "Доступ к собственным отсутствиям"</summary>
    public static readonly Permission AbsenceOwnPermission;
    public const string TrustedDevicesManagementPermissionId = "C34E0E87-C1FB-4407-9802-ABE6E9BC7B7D";
    /// <summary>Привилегия "Управление списком доверенных устройств"</summary>
    public static readonly Permission TrustedDevicesManagementPermission;
    public const string AbsenceViewPermissionId = "EC801EB0-3E6C-41F5-BAA0-A780431CCBEF";
    /// <summary>Привилегия "Просмотр пользователей"</summary>
    public static readonly Permission AbsenceViewPermission;
    private static PermissionProvider MHprTAklinlBMS8r8A2;

    public IEnumerable<Permission> GetPermissions() => (IEnumerable<Permission>) new Permission[12]
    {
      PermissionProvider.UserManagmentPermission,
      PermissionProvider.UserViewPermission,
      PermissionProvider.AccessManagmentPermission,
      PermissionProvider.APIAdminPermission,
      PermissionProvider.DenyEditPersonalDataPermission,
      PermissionProvider.DenyPasswordResetPermission,
      PermissionProvider.AbsenceUsePermission,
      PermissionProvider.AbsenceOwnPermission,
      PermissionProvider.ReplacementUsePermission,
      PermissionProvider.ReplacementOwnPermission,
      PermissionProvider.TrustedDevicesManagementPermission,
      PermissionProvider.AbsenceViewPermission
    };

    public IEnumerable<PermissionStereotype> GetPermissionStereotypes() => (IEnumerable<PermissionStereotype>) new PermissionStereotype[8]
    {
      new PermissionStereotype((IEnumerable<Permission>) new Permission[1]
      {
        CommonPermissions.DesignerAccessPermission
      }, SecurityConstants.ConfiguringGroupDescriptor),
      new PermissionStereotype((IEnumerable<Permission>) new Permission[1]
      {
        CommonPermissions.DesignerAccessPermission
      }, SecurityConstants.AdminGroupDescriptor),
      new PermissionStereotype((IEnumerable<Permission>) new Permission[7]
      {
        PermissionProvider.APIAdminPermission,
        PermissionProvider.UserManagmentPermission,
        PermissionProvider.UserViewPermission,
        PermissionProvider.AccessManagmentPermission,
        PermissionProvider.AbsenceUsePermission,
        PermissionProvider.ReplacementUsePermission,
        PermissionProvider.TrustedDevicesManagementPermission
      }, SecurityConstants.AdminGroupDescriptor),
      new PermissionStereotype((IEnumerable<Permission>) new Permission[1]
      {
        PermissionProvider.UserViewPermission
      }, SecurityConstants.ConfiguringGroupDescriptor),
      new PermissionStereotype((IEnumerable<Permission>) new Permission[2]
      {
        PermissionProvider.UserViewPermission,
        PermissionProvider.UserManagmentPermission
      }, SecurityConstants.UsersManagementGroupDescriptor),
      new PermissionStereotype((IEnumerable<Permission>) new Permission[1]
      {
        CommonPermissions.AdminPermission
      }, SecurityConstants.AdminGroupDescriptor),
      new PermissionStereotype((IEnumerable<Permission>) new Permission[1]
      {
        PermissionProvider.TrustedDevicesManagementPermission
      }, SecurityConstants.AllUsersGroupDescriptor),
      new PermissionStereotype((IEnumerable<Permission>) new Permission[1]
      {
        PermissionProvider.AbsenceViewPermission
      }, SecurityConstants.AdminGroupDescriptor)
    };

    public List<string> LocalizedItemsNames => (List<string>) null;

    public List<string> LocalizedItemsDescriptions => (List<string>) null;

    public List<string> LocalizedItemsCategories => (List<string>) null;

    /// <summary>
    /// Возвращает соответстие привилегия - имя привилегии(на английском)
    /// </summary>
    /// <returns></returns>
    public Dictionary<Permission, string> GetPermissionNames() => new Dictionary<Permission, string>()
    {
      {
        PermissionProvider.UserManagmentPermission,
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2143851882 - 923330995 ^ 1227796519)
      },
      {
        PermissionProvider.UserViewPermission,
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-278393783 ^ -278381377)
      },
      {
        PermissionProvider.AccessManagmentPermission,
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1536327508 ^ -1536314958)
      },
      {
        PermissionProvider.APIAdminPermission,
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(19590779 ^ 19586863)
      },
      {
        PermissionProvider.DenyEditPersonalDataPermission,
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-845204010 ^ 2052495102 ^ -1211526572)
      },
      {
        PermissionProvider.DenyPasswordResetPermission,
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(1567399832 << 6 ^ 1529337788)
      },
      {
        PermissionProvider.AbsenceUsePermission,
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1331070742 ^ -1331082980)
      },
      {
        PermissionProvider.ReplacementUsePermission,
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-979995965 << 4 ^ 1499930130)
      },
      {
        PermissionProvider.TrustedDevicesManagementPermission,
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(1245871191 - 2145700088 ^ -899841783)
      },
      {
        PermissionProvider.AbsenceViewPermission,
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(1762575989 ^ 1762587883)
      }
    };

    public PermissionProvider()
    {
      PermissionProvider.GQpdZikcrXcx0VIrNv8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PermissionProvider()
    {
      int num1 = 4;
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
              PermissionProvider.AbsenceViewPermission = (Permission) PermissionProvider.g3UGCckdFRVTAVmxkW3((object) Permission.Create(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-389167216 ^ -389153150), SR.M((string) PermissionProvider.NnYFUAkPec49kR8OFbO(-1257514304 ^ -1257512034)), "", (string) PermissionProvider.f3tNvjkQutg0OWdGdOo((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1976147292 - 421656521 ^ 1897159069))).ModuleUid((string) PermissionProvider.NnYFUAkPec49kR8OFbO(-1958977588 ^ -1958969352)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af != 0 ? 0 : 0;
              continue;
            case 2:
              PermissionProvider.ReplacementUsePermission = (Permission) PermissionProvider.g3UGCckdFRVTAVmxkW3(PermissionProvider.FvqCbOkEnW15naJ8Gxj(PermissionProvider.QJivtek5sO4RCtPecTN(PermissionProvider.KcxNHVk8RZcZchxcYhH(PermissionProvider.NnYFUAkPec49kR8OFbO(839394233 ^ 839390605), (object) SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(150349507 - 521039768 ^ -370703957)), (object) "", PermissionProvider.f3tNvjkQutg0OWdGdOo((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(711486506 ^ 711483244))), PermissionProvider.NnYFUAkPec49kR8OFbO(1095474805 ^ 155418997 ^ 1208500020)), (object) new Permission[1]
              {
                PermissionProvider.UserViewPermission
              }));
              num2 = 11;
              continue;
            case 3:
              PermissionProvider.APIAdminPermission = (Permission) PermissionProvider.g3UGCckdFRVTAVmxkW3(PermissionProvider.QJivtek5sO4RCtPecTN(PermissionProvider.KcxNHVk8RZcZchxcYhH(PermissionProvider.NnYFUAkPec49kR8OFbO(-347045778 ^ -347032926), PermissionProvider.f3tNvjkQutg0OWdGdOo((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1124861159 ^ 1124874239)), (object) "", PermissionProvider.f3tNvjkQutg0OWdGdOo(PermissionProvider.NnYFUAkPec49kR8OFbO(552500104 ^ 552487118))), PermissionProvider.NnYFUAkPec49kR8OFbO(-1489118656 ^ 643054122 ^ -2123775906)));
              num2 = 10;
              continue;
            case 4:
              PermissionProvider.GQpdZikcrXcx0VIrNv8();
              num2 = 3;
              continue;
            case 5:
              PermissionProvider.AbsenceOwnPermission = (Permission) PermissionProvider.g3UGCckdFRVTAVmxkW3((object) Permission.Create(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--534238571 ^ 534241979), (string) PermissionProvider.f3tNvjkQutg0OWdGdOo(PermissionProvider.NnYFUAkPec49kR8OFbO(~-192923496 ^ 192937851)), "", (string) PermissionProvider.f3tNvjkQutg0OWdGdOo(PermissionProvider.NnYFUAkPec49kR8OFbO(928696104 ^ 928707694))).ModuleUid((string) PermissionProvider.NnYFUAkPec49kR8OFbO(-29763048 >> 5 ^ -921884)));
              num2 = 7;
              continue;
            case 6:
              PermissionProvider.AccessManagmentPermission = (Permission) PermissionProvider.g3UGCckdFRVTAVmxkW3((object) ((PermissionBuilder) PermissionProvider.KcxNHVk8RZcZchxcYhH(PermissionProvider.NnYFUAkPec49kR8OFbO(1801131332 >> 4 ^ 112559394), PermissionProvider.f3tNvjkQutg0OWdGdOo((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2143851882 - 923330995 ^ 1227797537)), (object) "", PermissionProvider.f3tNvjkQutg0OWdGdOo((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1124861159 ^ 1124874145)))).ModuleUid((string) PermissionProvider.NnYFUAkPec49kR8OFbO(447286529 ^ 447294773)).Dependencies(PermissionProvider.UserViewPermission));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 10 : 13;
              continue;
            case 7:
              PermissionProvider.TrustedDevicesManagementPermission = (Permission) PermissionProvider.g3UGCckdFRVTAVmxkW3(PermissionProvider.QJivtek5sO4RCtPecTN((object) Permission.Create((string) PermissionProvider.NnYFUAkPec49kR8OFbO(-909559362 ^ -398405015 ^ 562680759), (string) PermissionProvider.f3tNvjkQutg0OWdGdOo(PermissionProvider.NnYFUAkPec49kR8OFbO(447286529 ^ 447296941)), "", SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(84189367 + 1997579375 ^ 2081781344))), PermissionProvider.NnYFUAkPec49kR8OFbO(-1702973981 - 773209001 ^ 1818776078)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 1 : 0;
              continue;
            case 8:
              PermissionProvider.UserManagmentPermission = (Permission) PermissionProvider.g3UGCckdFRVTAVmxkW3(PermissionProvider.FvqCbOkEnW15naJ8Gxj((object) ((PermissionBuilder) PermissionProvider.KcxNHVk8RZcZchxcYhH(PermissionProvider.NnYFUAkPec49kR8OFbO(-801309555 ^ -801321115), PermissionProvider.f3tNvjkQutg0OWdGdOo((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2143851882 - 923330995 ^ 1227797719)), (object) "", (object) SR.M((string) PermissionProvider.NnYFUAkPec49kR8OFbO(-901653144 ^ -901648850)))).ModuleUid((string) PermissionProvider.NnYFUAkPec49kR8OFbO(--1207559533 ^ 1207551321)), (object) new Permission[1]
              {
                PermissionProvider.UserViewPermission
              }));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb == 0 ? 6 : 6;
              continue;
            case 9:
              PermissionProvider.DenyPasswordResetPermission = (Permission) PermissionProvider.g3UGCckdFRVTAVmxkW3((object) ((PermissionBuilder) PermissionProvider.KcxNHVk8RZcZchxcYhH(PermissionProvider.NnYFUAkPec49kR8OFbO(-817081027 ^ 243500131 ^ -1043340036), PermissionProvider.f3tNvjkQutg0OWdGdOo(PermissionProvider.NnYFUAkPec49kR8OFbO(--306199571 ^ 306186749)), (object) "", (object) SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-347045778 ^ -347032792)))).ModuleUid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1687460816 ^ 1687469028)));
              num2 = 2;
              continue;
            case 10:
              PermissionProvider.UserViewPermission = (Permission) PermissionProvider.g3UGCckdFRVTAVmxkW3(PermissionProvider.QJivtek5sO4RCtPecTN(PermissionProvider.KcxNHVk8RZcZchxcYhH(PermissionProvider.NnYFUAkPec49kR8OFbO(-880091293 >> 4 ^ -55009638), PermissionProvider.f3tNvjkQutg0OWdGdOo((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1658561670 << 4 ^ 767196120)), (object) "", (object) SR.M((string) PermissionProvider.NnYFUAkPec49kR8OFbO(-296013529 ^ -296025503))), PermissionProvider.NnYFUAkPec49kR8OFbO(-816108091 ^ -816116239)));
              num2 = 8;
              continue;
            case 11:
              goto label_7;
            case 12:
              PermissionProvider.AbsenceUsePermission = (Permission) (PermissionBuilder) PermissionProvider.FvqCbOkEnW15naJ8Gxj(PermissionProvider.QJivtek5sO4RCtPecTN((object) Permission.Create(z2jc63fLkugS1X8Q9N.tE1kD1vbB(44166125 ^ 44162213), SR.M((string) PermissionProvider.NnYFUAkPec49kR8OFbO(--534238571 ^ 534242047)), "", SR.M((string) PermissionProvider.NnYFUAkPec49kR8OFbO(-1331070742 ^ -1331082324))), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~123928154 ^ -123919983)), (object) new Permission[1]
              {
                PermissionProvider.UserViewPermission
              });
              num2 = 5;
              continue;
            case 13:
              PermissionProvider.DenyEditPersonalDataPermission = (Permission) PermissionProvider.g3UGCckdFRVTAVmxkW3(PermissionProvider.QJivtek5sO4RCtPecTN(PermissionProvider.KcxNHVk8RZcZchxcYhH(PermissionProvider.NnYFUAkPec49kR8OFbO(1690209562 ^ 116876444 ^ 1649007756), PermissionProvider.f3tNvjkQutg0OWdGdOo(PermissionProvider.NnYFUAkPec49kR8OFbO(1744916777 - 891549337 ^ 853372870)), (object) "", (object) SR.M((string) PermissionProvider.NnYFUAkPec49kR8OFbO(~-192923496 ^ 192934945))), PermissionProvider.NnYFUAkPec49kR8OFbO(-1743015995 ^ -1743024143)));
              num2 = 9;
              continue;
            default:
              goto label_17;
          }
        }
label_7:
        PermissionProvider.ReplacementOwnPermission = (Permission) PermissionProvider.g3UGCckdFRVTAVmxkW3(PermissionProvider.QJivtek5sO4RCtPecTN((object) Permission.Create(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-757186336 ^ -757172646), (string) PermissionProvider.f3tNvjkQutg0OWdGdOo((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1433051380 + 1051547170 ^ -1810382832)), "", (string) PermissionProvider.f3tNvjkQutg0OWdGdOo(PermissionProvider.NnYFUAkPec49kR8OFbO(1690569372 >> 6 ^ 26420076))), PermissionProvider.NnYFUAkPec49kR8OFbO(1124861159 ^ 1124869331)));
        num1 = 12;
      }
label_3:
      return;
label_17:;
    }

    internal static void GQpdZikcrXcx0VIrNv8() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool pPk4WDkf4Wbn50mCgoT() => PermissionProvider.MHprTAklinlBMS8r8A2 == null;

    internal static PermissionProvider CvrXm4k4f5WnBU6hBU3() => PermissionProvider.MHprTAklinlBMS8r8A2;

    internal static object NnYFUAkPec49kR8OFbO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object f3tNvjkQutg0OWdGdOo([In] object obj0) => (object) SR.M((string) obj0);

    internal static object KcxNHVk8RZcZchxcYhH([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) Permission.Create((string) obj0, (string) obj1, (string) obj2, (string) obj3);

    internal static object QJivtek5sO4RCtPecTN([In] object obj0, [In] object obj1) => (object) ((PermissionBuilder) obj0).ModuleUid((string) obj1);

    internal static object g3UGCckdFRVTAVmxkW3([In] object obj0) => (object) (Permission) (PermissionBuilder) obj0;

    internal static object FvqCbOkEnW15naJ8Gxj([In] object obj0, [In] object obj1) => (object) ((PermissionBuilder) obj0).Dependencies((Permission[]) obj1);
  }
}

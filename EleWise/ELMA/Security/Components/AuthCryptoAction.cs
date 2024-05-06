// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.AuthCryptoAction
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Extensions;
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

namespace EleWise.ELMA.Security.Components
{
  /// <summary>Действие входа</summary>
  [Component]
  public class AuthCryptoAction : ICertificateCryptoAction, ICryptoAction
  {
    public const string UID_S = "AE3F60E4-2D0A-437D-AAE3-3E1F7F1E35D6";
    public static Guid UID;
    internal static AuthCryptoAction EOPmMY23lCRxic5H3X4;

    public IAuthenticationService AuthenticationService
    {
      get => this.\u003CAuthenticationService\u003Ek__BackingField;
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
              this.\u003CAuthenticationService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 0 : 0;
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

    public TrustedDeviceService TrustedDeviceService
    {
      get => this.\u003CTrustedDeviceService\u003Ek__BackingField;
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
              this.\u003CTrustedDeviceService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 == 0 ? 0 : 0;
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

    public UserPublicKeyTokenManager UserPublicKeyTokenManager
    {
      get => this.\u003CUserPublicKeyTokenManager\u003Ek__BackingField;
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
              this.\u003CUserPublicKeyTokenManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 != 0 ? 0 : 0;
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

    public UserCertificateManager UserCertificateManager
    {
      get => this.\u003CUserCertificateManager\u003Ek__BackingField;
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
              this.\u003CUserCertificateManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 != 0 ? 0 : 0;
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

    public AuthCryptoProviderService AuthCryptoProviderService
    {
      get => this.\u003CAuthCryptoProviderService\u003Ek__BackingField;
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
              this.\u003CAuthCryptoProviderService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 0 : 0;
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

    protected SecuritySettingsModule Module => Locator.GetServiceNotNull<SecuritySettingsModule>();

    protected ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

    /// <summary>Бзазовый крипто сервис действия</summary>
    public ICryptoProviderServiceBase CryptoService => (ICryptoProviderServiceBase) this.AuthCryptoProviderService;

    public bool SupportOnlyDefaultCertificate => AuthCryptoAction.RBu0Kg20ftdT5tQB33O((object) this.Module.Settings);

    public bool SupportOtherDevices => true;

    /// <summary>Uid действия</summary>
    public Guid ActionUid => AuthCryptoAction.UID;

    /// <summary>Описание</summary>
    public string Description => (string) AuthCryptoAction.cSRSL62AG4udjVDb2QN(AuthCryptoAction.DNCcu62ZAM7YMOwX3uR(-757186336 ^ -757115158));

    /// <summary>Есть права у пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <returns></returns>
    public bool HasPermission(EleWise.ELMA.Security.Models.IUser user)
    {
      int num = 1;
      string msg;
      while (true)
      {
        switch (num)
        {
          case 1:
            msg = (string) null;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this.HasPermission(user, out msg);
    }

    /// <summary>Есть права у пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="msg">Сообщение</param>
    /// <returns></returns>
    public bool HasPermission(EleWise.ELMA.Security.Models.IUser user, out string msg)
    {
      int num = 7;
      while (true)
      {
        EleWise.ELMA.Security.IUser user1;
        bool flag;
        switch (num)
        {
          case 1:
            msg = (string) AuthCryptoAction.cSRSL62AG4udjVDb2QN(AuthCryptoAction.DNCcu62ZAM7YMOwX3uR(-1257514304 ^ -1257550900));
            num = 12;
            continue;
          case 2:
            goto label_8;
          case 3:
            msg = (string) AuthCryptoAction.cSRSL62AG4udjVDb2QN(AuthCryptoAction.DNCcu62ZAM7YMOwX3uR(-169284490 ^ -169215392));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec == 0 ? 5 : 5;
            continue;
          case 4:
            if (user1 != user)
            {
              num = 11;
              continue;
            }
            break;
          case 5:
            goto label_12;
          case 6:
            flag = AuthCryptoAction.jlVkgM27alXy8K9Zwmn((object) this.SecurityService, (object) user1, (object) PermissionProvider.UserManagmentPermission);
            num = 4;
            continue;
          case 7:
            user1 = (EleWise.ELMA.Security.IUser) AuthCryptoAction.O7wC792suL2FFf3NmZv((object) this.AuthenticationService);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 != 0 ? 3 : 6;
            continue;
          case 8:
label_13:
            if (AuthCryptoAction.A4SB4B2r8gaAIZwZQro((object) this.SecurityService, (object) PermissionProvider.TrustedDevicesManagementPermission))
            {
              msg = (string) null;
              num = 2;
              continue;
            }
            num = 10;
            continue;
          case 9:
            if (!AuthCryptoAction.Y7RIbu2WmBsZRX78nbX((object) this.Module.Settings))
            {
              num = 8;
              continue;
            }
            goto case 3;
          case 10:
            msg = (string) AuthCryptoAction.cSRSL62AG4udjVDb2QN(AuthCryptoAction.DNCcu62ZAM7YMOwX3uR(1690209562 ^ 116876444 ^ 1648951240));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0 ? 0 : 0;
            continue;
          case 11:
            if (!flag)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0 ? 1 : 0;
              continue;
            }
            break;
          case 12:
            goto label_15;
          case 13:
            if (!flag)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0 ? 9 : 8;
              continue;
            }
            goto case 8;
          default:
            goto label_10;
        }
        if (user1 == user)
          num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 != 0 ? 13 : 13;
        else
          goto label_13;
      }
label_8:
      return true;
label_10:
      return false;
label_12:
      return false;
label_15:
      return false;
    }

    /// <summary>
    /// Возможно ли зарегистрировать сертифкат для этого действия
    /// </summary>
    /// <returns></returns>
    public bool CanRegisterCertificate(out string msg)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            msg = (string) AuthCryptoAction.cSRSL62AG4udjVDb2QN((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1324692970 << 3 ^ -2007546360));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 == 0 ? 0 : 2;
            continue;
          case 2:
            goto label_2;
          case 3:
            msg = (string) null;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0 ? 0 : 0;
            continue;
          case 4:
            if (AuthCryptoAction.dJDwOy2S7g4q5ftsIHd((object) this.Module.Settings))
            {
              num = 3;
              continue;
            }
            goto case 1;
          default:
            goto label_4;
        }
      }
label_2:
      return false;
label_4:
      return true;
    }

    /// <summary>Возможно ли отвязать сертификат от этого действия</summary>
    /// <returns></returns>
    public bool CanUnregisterCertificate(IUserCertificate cert, out string msg)
    {
      int num1 = 3;
      bool flag;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          int num3;
          switch (num2)
          {
            case 1:
              if (AuthCryptoAction.C1TiBo2ywWkVNhwx1OV((object) this.TrustedDeviceService.GetDevices((EleWise.ELMA.Security.IUser) AuthCryptoAction.EuUtha2Yd7BEpCocXad((object) cert))) > 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a == 0 ? 6 : 0;
                continue;
              }
              goto case 8;
            case 2:
              goto label_5;
            case 3:
              if (this.Module.Settings.AllowLoginByCertificate)
              {
                if (this.TrustedDeviceService.TrustedLogonEnabled())
                {
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e != 0 ? 1 : 0;
                  continue;
                }
                goto case 6;
              }
              else
              {
                num2 = 2;
                continue;
              }
            case 4:
              goto label_10;
            case 5:
              goto label_6;
            case 6:
              num3 = 1;
              break;
            case 7:
              num3 = AuthCryptoAction.KQc6lh2VO77Ry3Vhvaq((object) this.UserCertificateManager, (object) cert.User, this.ActionUid) > 1L ? 1 : 0;
              break;
            case 8:
              if (!this.UserPublicKeyTokenManager.Exists((EleWise.ELMA.Security.IUser) AuthCryptoAction.EuUtha2Yd7BEpCocXad((object) cert)))
              {
                num2 = 7;
                continue;
              }
              goto case 6;
            default:
              goto label_17;
          }
          flag = num3 != 0;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 == 0 ? 0 : 0;
        }
label_5:
        msg = EleWise.ELMA.SR.T((string) AuthCryptoAction.DNCcu62ZAM7YMOwX3uR(1212037053 ^ -1727812018 ^ -784560309));
        num1 = 5;
        continue;
label_17:
        msg = flag ? (string) (object) null : (string) AuthCryptoAction.cSRSL62AG4udjVDb2QN(AuthCryptoAction.DNCcu62ZAM7YMOwX3uR(-1331070742 ^ -1331054334));
        num1 = 4;
      }
label_6:
      return false;
label_10:
      return flag;
    }

    /// <summary>Вкл/выкл доверенные</summary>
    /// <param name="user"></param>
    /// <param name="enabled"></param>
    public void EnableTrusted(EleWise.ELMA.Security.Models.IUser user, bool enabled)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_13;
          case 1:
            if (!this.UserPublicKeyTokenManager.Exists((EleWise.ELMA.Security.IUser) user))
            {
              num = 6;
              continue;
            }
            goto case 2;
          case 2:
          case 4:
            AuthCryptoAction.ey0wQf2lBQL8902lDIw((object) this.TrustedDeviceService, (object) user, enabled);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0 ? 0 : 0;
            continue;
          case 3:
            if (!this.TrustedDeviceService.GetDevices((EleWise.ELMA.Security.IUser) user).Any<DeviceToken>())
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0 ? 1 : 1;
              continue;
            }
            goto case 2;
          case 5:
            if (!enabled)
            {
              num = 4;
              continue;
            }
            goto case 3;
          case 6:
            if (this.UserCertificateManager.Exists((EleWise.ELMA.Security.IUser) user, this.ActionUid))
            {
              num = 2;
              continue;
            }
            goto label_12;
          default:
            goto label_2;
        }
      }
label_13:
      return;
label_2:
      return;
label_12:
      throw new Exception((string) AuthCryptoAction.cSRSL62AG4udjVDb2QN(AuthCryptoAction.DNCcu62ZAM7YMOwX3uR(1841261835 ^ 1841200127)));
    }

    public AuthCryptoAction()
    {
      AuthCryptoAction.UYsZGp2fg16h9qL9VTl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static AuthCryptoAction()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            AuthCryptoAction.UYsZGp2fg16h9qL9VTl();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            AuthCryptoAction.UID = new Guid((string) AuthCryptoAction.DNCcu62ZAM7YMOwX3uR(-845204010 ^ 2052495102 ^ -1211583384));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool cj33V22jlEq2jJqJWTs() => AuthCryptoAction.EOPmMY23lCRxic5H3X4 == null;

    internal static AuthCryptoAction cj02622NEbWJUAc3mke() => AuthCryptoAction.EOPmMY23lCRxic5H3X4;

    internal static bool RBu0Kg20ftdT5tQB33O([In] object obj0) => ((SecuritySettings) obj0).AllowLoginOnlyByDefaultCertificate;

    internal static object DNCcu62ZAM7YMOwX3uR(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object cSRSL62AG4udjVDb2QN([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object O7wC792suL2FFf3NmZv([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static bool jlVkgM27alXy8K9Zwmn([In] object obj0, [In] object obj1, [In] object obj2) => ((ISecurityService) obj0).HasPermission((EleWise.ELMA.Security.IUser) obj1, (Permission) obj2);

    internal static bool Y7RIbu2WmBsZRX78nbX([In] object obj0) => ((SecuritySettings) obj0).DenyEditSecurityUserProfile;

    internal static bool A4SB4B2r8gaAIZwZQro([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).HasPermission((Permission) obj1);

    internal static bool dJDwOy2S7g4q5ftsIHd([In] object obj0) => ((SecuritySettings) obj0).AllowLoginByCertificate;

    internal static object EuUtha2Yd7BEpCocXad([In] object obj0) => (object) ((IUserCertificate) obj0).User;

    internal static int C1TiBo2ywWkVNhwx1OV([In] object obj0) => ((List<DeviceToken>) obj0).Count;

    internal static long KQc6lh2VO77Ry3Vhvaq([In] object obj0, [In] object obj1, Guid cryptoActionUid) => ((UserCertificateManager) obj0).Count((EleWise.ELMA.Security.IUser) obj1, cryptoActionUid);

    internal static void ey0wQf2lBQL8902lDIw([In] object obj0, [In] object obj1, bool enabled) => ((TrustedDeviceService) obj0).SetTrustedLogon((EleWise.ELMA.Security.IUser) obj1, enabled);

    internal static void UYsZGp2fg16h9qL9VTl() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}

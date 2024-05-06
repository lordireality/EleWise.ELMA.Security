// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.SecuritySettings
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Models.Crypto;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>Настройки безопасности</summary>
  public class SecuritySettings : GlobalSettingsBase
  {
    private int passwordMinLength;
    private int periodicityOfForcedChangePassword;
    private int countLogonAttempts;
    private int blockingPeriod;
    private int periodResetCountLogonAttempt;
    internal static SecuritySettings v5F5ApznQxAwVCp1ABe;

    /// <summary>Ctor</summary>
    public SecuritySettings()
    {
      SecuritySettings.IMpwDvzHKhmcQn7fUVL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.FreezeAuthenticationOnPingTimeoutTime = TimeSpan.FromMinutes(3.0);
            num = 6;
            continue;
          case 2:
            this.ExclusionGroup = ((AbstractNHEntityManager<IUserGroup, long>) SecuritySettings.wvlxyUwuwskuKUxE0Vkk()).Load(SecurityConstants.AdminGroupUid);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 != 0 ? 0 : 0;
            continue;
          case 3:
            this.DefaultAuthCryptoProviderSettings = new DefaultCryptoProviderSettings(new Guid((string) SecuritySettings.JGqnRfwuKJ5Siy5ukWKI(-1976147292 - 421656521 ^ 1897233057)), new Guid((string) SecuritySettings.JGqnRfwuKJ5Siy5ukWKI(-801309555 ^ -801248789)));
            num = 7;
            continue;
          case 4:
            this.SignOutOnActionTimeoutTime = SecuritySettings.OcyxyCwuuCfeUuqkKMV8(1.0);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 5 : 4;
            continue;
          case 5:
            this.SignOutPrivilegedUsersTimeoutTime = TimeSpan.FromDays(1.0);
            num = 2;
            continue;
          case 6:
            this.SignOutOnPingTimeoutTime = SecuritySettings.Af8x1uzzajREOksZDwD(1.0);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 != 0 ? 4 : 0;
            continue;
          case 7:
            goto label_3;
          default:
            this.NotifyUsers = new List<EleWise.ELMA.Security.Models.IUser>()
            {
              ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) SecuritySettings.Oek4cZwubmVM12OtLuni()).Load(SecurityConstants.AdminUserUid)
            };
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 3 : 3;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Настройки криптопровайдера по умолчанию</summary>
    [DisplayName(typeof (SecuritySettings_SR), "DefaultAuthCryptoProviderSettings")]
    [IgnoreDataMember]
    public DefaultCryptoProviderSettings DefaultAuthCryptoProviderSettings
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (SecuritySettings.zgRF0TwuUDgXRfnEqkZ6((object) this.SerializeDefaultAuthCryptoProviderSettings))
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0 ? 1 : 0;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return ClassSerializationHelper.DeserializeObjectByJson<DefaultCryptoProviderSettings>(this.SerializeDefaultAuthCryptoProviderSettings);
label_5:
        return new DefaultCryptoProviderSettings(new Guid((string) SecuritySettings.JGqnRfwuKJ5Siy5ukWKI(928696104 ^ 928765778)), new Guid((string) SecuritySettings.JGqnRfwuKJ5Siy5ukWKI(978908330 << 6 ^ -1774436378)));
      }
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
              this.SerializeDefaultAuthCryptoProviderSettings = (string) SecuritySettings.LJXmNowuRfBcmVrjF9hQ((object) value);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 0 : 0;
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

    /// <summary>Настройки текущего криптопровайдера</summary>
    public string SerializeDefaultAuthCryptoProviderSettings
    {
      get => this.\u003CSerializeDefaultAuthCryptoProviderSettings\u003Ek__BackingField;
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
              this.\u003CSerializeDefaultAuthCryptoProviderSettings\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 != 0 ? 0 : 0;
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

    /// <summary>Разрешить вход по сертификату</summary>
    [DisplayName(typeof (SecuritySettings_SR), "AllowLoginByCertificate")]
    public bool AllowLoginByCertificate
    {
      get => this.\u003CAllowLoginByCertificate\u003Ek__BackingField;
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
              this.\u003CAllowLoginByCertificate\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc != 0 ? 0 : 0;
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

    /// <summary>Разрешить вход по токену</summary>
    [DisplayName(typeof (SecuritySettings_SR), "AllowLoginByToken")]
    public bool AllowLoginByToken
    {
      get => this.\u003CAllowLoginByToken\u003Ek__BackingField;
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
              this.\u003CAllowLoginByToken\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 0 : 0;
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

    /// <summary>Разрешить вход только по сертификату по умолчанию</summary>
    [DisplayName(typeof (SecuritySettings_SR), "AllowLoginOnlyByDefaultCertificate")]
    public bool AllowLoginOnlyByDefaultCertificate
    {
      get => this.\u003CAllowLoginOnlyByDefaultCertificate\u003Ek__BackingField;
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
              this.\u003CAllowLoginOnlyByDefaultCertificate\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 == 0 ? 0 : 0;
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

    /// <summary>
    /// Приостанавливать сессию авторизации при отсутствии отклика в течение указанного времени
    /// </summary>
    public long FreezeAuthenticationOnPingTimeoutTicks
    {
      get => this.\u003CFreezeAuthenticationOnPingTimeoutTicks\u003Ek__BackingField;
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
              this.\u003CFreezeAuthenticationOnPingTimeoutTicks\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 0 : 0;
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

    /// <summary>
    /// Приостанавливать сессию авторизации при отсутствии отклика в течение указанного времени
    /// </summary>
    public TimeSpan FreezeAuthenticationOnPingTimeoutTime
    {
      get => new TimeSpan(this.FreezeAuthenticationOnPingTimeoutTicks);
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              this.FreezeAuthenticationOnPingTimeoutTicks = (!SecuritySettings.F9MvcNwutIVgIj8X3nuZ(value, SecuritySettings.kEhV5owuoF4EXKaXbyIH(3.0)) ? SecuritySettings.kEhV5owuoF4EXKaXbyIH(3.0) : value).Ticks;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }
    }

    /// <summary>
    /// Удалять сессию авторизации при отсутствии отклика в течение указанного времени
    /// </summary>
    public long SignOutOnPingTimeoutTicks
    {
      get => this.\u003CSignOutOnPingTimeoutTicks\u003Ek__BackingField;
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
              this.\u003CSignOutOnPingTimeoutTicks\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 0 : 0;
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

    /// <summary>
    /// Удалять сессию авторизации при отсутствии отклика в течение указанного времени
    /// </summary>
    public TimeSpan SignOutOnPingTimeoutTime
    {
      get => new TimeSpan(this.SignOutOnPingTimeoutTicks);
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              this.SignOutOnPingTimeoutTicks = (!SecuritySettings.F9MvcNwutIVgIj8X3nuZ(value, TimeSpan.FromMinutes(3.0)) ? SecuritySettings.kEhV5owuoF4EXKaXbyIH(3.0) : value).Ticks;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }
    }

    /// <summary>
    /// Удалять ли сессию авторизации при бездействии пользователя
    /// </summary>
    public bool SignOutOnActionTimeout
    {
      get => this.\u003CSignOutOnActionTimeout\u003Ek__BackingField;
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
              this.\u003CSignOutOnActionTimeout\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0 ? 0 : 0;
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

    /// <summary>
    /// Удалять сессию авторизации при бездействии пользователя
    /// </summary>
    public long SignOutOnActionTimeoutTicks
    {
      get => this.\u003CSignOutOnActionTimeoutTicks\u003Ek__BackingField;
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
              this.\u003CSignOutOnActionTimeoutTicks\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 0 : 0;
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

    /// <summary>
    /// Удалять сессию авторизации при отсутствии действий пользователя в течение указанного времени
    /// </summary>
    public TimeSpan SignOutOnActionTimeoutTime
    {
      get => new TimeSpan(this.SignOutOnActionTimeoutTicks);
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
              this.SignOutOnActionTimeoutTicks = (SecuritySettings.F9MvcNwutIVgIj8X3nuZ(value, SecuritySettings.kEhV5owuoF4EXKaXbyIH(3.0)) ? value : SecuritySettings.kEhV5owuoF4EXKaXbyIH(3.0)).Ticks;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0 ? 0 : 0;
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

    /// <summary>
    /// Удалять ли сессии авторизации привилегированных пользователей
    /// </summary>
    public bool SignOutPrivilegedUsers
    {
      get => this.\u003CSignOutPrivilegedUsers\u003Ek__BackingField;
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
              this.\u003CSignOutPrivilegedUsers\u003Ek__BackingField = value;
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
    }

    /// <summary>Используются ли привелигерованные лицензии</summary>
    public bool IsPrivilegedLicense
    {
      get
      {
        int num = 2;
        IConcurrentLicenseInfo concurrentLicenseInfo1;
        while (true)
        {
          ILicensedUnit mainLicensedUnit;
          IConcurrentLicenseInfo concurrentLicenseInfo2;
          switch (num)
          {
            case 1:
              if (mainLicensedUnit == null)
              {
                num = 4;
                continue;
              }
              concurrentLicenseInfo2 = mainLicensedUnit.GetLicenseInfo() as IConcurrentLicenseInfo;
              break;
            case 2:
              mainLicensedUnit = ((IModuleManager) SecuritySettings.YSStixwu6Tw2KWe1L86W(SecuritySettings.AFCU8dwumYSUKSBrxZxa())).MainLicensedUnit;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_7;
            case 4:
              concurrentLicenseInfo2 = (IConcurrentLicenseInfo) null;
              break;
            case 5:
              if (concurrentLicenseInfo1 == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 != 0 ? 3 : 0;
                continue;
              }
              goto label_6;
            default:
              goto label_6;
          }
          concurrentLicenseInfo1 = concurrentLicenseInfo2;
          num = 5;
        }
label_6:
        return SecuritySettings.zdQBb7wuk0vTwSf7B9OL((object) concurrentLicenseInfo1);
label_7:
        return false;
      }
    }

    /// <summary>
    /// Удалять сессию авторизации при бездействии пользователя
    /// </summary>
    public long SignOutPrivilegedUsersTimeoutTicks
    {
      get => this.\u003CSignOutPrivilegedUsersTimeoutTicks\u003Ek__BackingField;
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
              this.\u003CSignOutPrivilegedUsersTimeoutTicks\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 0 : 0;
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

    /// <summary>
    /// Удалять сессию авторизации при отсутствии действий пользователя для именных лицензий в течение указанного времени
    /// </summary>
    public TimeSpan SignOutPrivilegedUsersTimeoutTime
    {
      get => new TimeSpan(this.SignOutPrivilegedUsersTimeoutTicks);
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              this.SignOutPrivilegedUsersTimeoutTicks = (!(value > SecuritySettings.kEhV5owuoF4EXKaXbyIH(10.0)) ? SecuritySettings.kEhV5owuoF4EXKaXbyIH(10.0) : value).Ticks;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }
    }

    protected override bool SkipProperty(PropertyInfo property)
    {
      int num = 7;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (SecuritySettings.MZugdJwuxl2v6TN2JVlb(SecuritySettings.EujkZ0wuaAo1MlCoHy86((object) property), SecuritySettings.JGqnRfwuKJ5Siy5ukWKI(-206147790 ^ -206081534)))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 != 0 ? 0 : 2;
              continue;
            }
            goto label_8;
          case 3:
            goto label_8;
          case 4:
            if (!SecuritySettings.MZugdJwuxl2v6TN2JVlb(SecuritySettings.EujkZ0wuaAo1MlCoHy86((object) property), SecuritySettings.JGqnRfwuKJ5Siy5ukWKI(1530848604 ^ 1530919410)))
            {
              num = 5;
              continue;
            }
            goto label_9;
          case 5:
            if (SecuritySettings.MZugdJwuxl2v6TN2JVlb(SecuritySettings.EujkZ0wuaAo1MlCoHy86((object) property), SecuritySettings.JGqnRfwuKJ5Siy5ukWKI(-340788466 ^ -340858894)))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff != 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          case 7:
            if (SecuritySettings.Wu9ye9wuDwUUaCGfWfHq((object) this, (object) property))
            {
              num = 6;
              continue;
            }
            goto case 4;
          default:
            goto label_9;
        }
      }
label_8:
      return SecuritySettings.MZugdJwuxl2v6TN2JVlb(SecuritySettings.EujkZ0wuaAo1MlCoHy86((object) property), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1702973981 - 773209001 ^ 1818849106));
label_9:
      return true;
    }

    /// <summary>
    /// Запретить пользователю редактирование собственных настроек безопасности (только админ)
    /// </summary>
    [DisplayName(typeof (SecuritySettings_SR), "DenyEditSecurityUserProfile")]
    public bool DenyEditSecurityUserProfile
    {
      get => this.\u003CDenyEditSecurityUserProfile\u003Ek__BackingField;
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
              this.\u003CDenyEditSecurityUserProfile\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 == 0 ? 0 : 0;
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

    /// <summary>Лимит попыток неудачного входа</summary>
    [Description(typeof (SecuritySettings_SR), "CountLogonAttempts_Description")]
    [DisplayName(typeof (SecuritySettings_SR), "CountLogonAttempts")]
    public int CountLogonAttempts
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (this.countLogonAttempts > 0)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 1 : 0;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return 0;
label_5:
        return this.countLogonAttempts;
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (value <= 0)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 2:
              goto label_7;
            case 3:
              goto label_4;
            case 4:
              this.countLogonAttempts = 0;
              num = 3;
              continue;
            case 5:
              this.countLogonAttempts = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0 ? 1 : 2;
              continue;
            default:
              SecuritySettings.bbxLIywuCufZ0utyZhyY((object) UserSecurityProfileManager.Instance);
              num = 4;
              continue;
          }
        }
label_7:
        return;
label_4:;
      }
    }

    /// <summary>Продолжительность блокировки учетной записи (минуты)</summary>
    [Description(typeof (SecuritySettings_SR), "BlockingPeriod_Description")]
    [DisplayName(typeof (SecuritySettings_SR), "BlockingPeriod")]
    public int BlockingPeriod
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.blockingPeriod <= 0)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return 0;
label_5:
        return this.blockingPeriod;
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              this.blockingPeriod = value <= 0 ? 0 : value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }
    }

    /// <summary>Период сброса счетчика блокировки (минуты)</summary>
    [Description(typeof (SecuritySettings_SR), "ResetCountLoginAttempts_Description")]
    [DisplayName(typeof (SecuritySettings_SR), "ResetCountLoginAttempts")]
    public int PeriodResetCountLogonAttempts
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              if (this.periodResetCountLogonAttempt > 0)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 != 0 ? 1 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        return 0;
label_3:
        return this.periodResetCountLogonAttempt;
      }
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
              this.periodResetCountLogonAttempt = value > 0 ? value : 0;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 0 : 0;
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

    /// <summary>Оповещать о блокировке пользователя</summary>
    [DisplayName(typeof (SecuritySettings_SR), "NotifyBlocking")]
    [Description(typeof (SecuritySettings_SR), "NotifyBlocking_Description")]
    public bool NotifyBlocking
    {
      get => this.\u003CNotifyBlocking\u003Ek__BackingField;
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
              this.\u003CNotifyBlocking\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 != 0 ? 0 : 0;
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

    /// <summary>Идентификаторы оповещаемых пользователей</summary>
    public string NotifyUsersId
    {
      get => this.\u003CNotifyUsersId\u003Ek__BackingField;
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
              this.\u003CNotifyUsersId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 != 0 ? 0 : 0;
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

    /// <summary>Оповещаемые пользователи</summary>
    [Description(typeof (SecuritySettings_SR), "NotifyUsers_Description")]
    [IgnoreDataMember]
    [DisplayName(typeof (SecuritySettings_SR), "NotifyUsers")]
    public List<EleWise.ELMA.Security.Models.IUser> NotifyUsers
    {
      get
      {
        List<EleWise.ELMA.Security.Models.IUser> notifyUsers = new List<EleWise.ELMA.Security.Models.IUser>();
        if (!string.IsNullOrEmpty(this.NotifyUsersId))
        {
          string notifyUsersId = this.NotifyUsersId;
          char[] chArray = new char[1]{ ',' };
          foreach (string s in notifyUsersId.Split(chArray))
          {
            long result;
            if (long.TryParse(s, out result))
              notifyUsers.Add(UserManager.Instance.LoadOrNull(result));
          }
        }
        return notifyUsers;
      }
      set
      {
        string str = (string) null;
        if (value != null)
        {
          List<long> collection = new List<long>();
          foreach (EleWise.ELMA.Security.Models.IUser user in value)
            collection.Add(user.Id);
          str = collection.ToSeparatedString<long>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2110885667 - -1624984630 ^ -559102379));
        }
        this.NotifyUsersId = str;
      }
    }

    /// <summary>Минимальная длина пароля</summary>
    [DisplayName(typeof (SecuritySettings_SR), "PasswordMinLength")]
    public int PasswordMinLength
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              if (this.passwordMinLength > 0)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 != 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        return 0;
label_3:
        return this.passwordMinLength;
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              this.passwordMinLength = value <= 0 ? 0 : value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }
    }

    /// <summary>Использовать сложный пароль</summary>
    [DisplayName(typeof (SecuritySettings_SR), "IsComplexPassword")]
    [Description(typeof (SecuritySettings_SR), "IsComplexPassword_Description")]
    public bool IsComplexPassword
    {
      get => this.\u003CIsComplexPassword\u003Ek__BackingField;
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
              this.\u003CIsComplexPassword\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d == 0 ? 0 : 0;
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

    /// <summary>Периодичность принудительной смены пароля (дни)</summary>
    [Description(typeof (SecuritySettings_SR), "PeriodicityOfForcedChangePassword_Description")]
    [DisplayName(typeof (SecuritySettings_SR), "PeriodicityOfForcedChangePassword")]
    public int PeriodicityOfForcedChangePassword
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.periodicityOfForcedChangePassword <= 0)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return 0;
label_5:
        return this.periodicityOfForcedChangePassword;
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              this.periodicityOfForcedChangePassword = value <= 0 ? 0 : value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }
    }

    /// <summary>Принудительная смена пароля при первом входе</summary>
    [DisplayName(typeof (SecuritySettings_SR), "ForcedChangePasswordOnFirstLogon")]
    public bool ForcedChangePasswordOnFirstLogon
    {
      get => this.\u003CForcedChangePasswordOnFirstLogon\u003Ek__BackingField;
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
              this.\u003CForcedChangePasswordOnFirstLogon\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af != 0 ? 0 : 0;
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

    /// <summary>
    /// Идентификатор группы исключения принудительной смены пароля
    /// </summary>
    public long ExclusionGroupId
    {
      get => this.\u003CExclusionGroupId\u003Ek__BackingField;
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
              this.\u003CExclusionGroupId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0 ? 0 : 0;
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

    /// <summary>Группа исключения принудительной смены пароля</summary>
    [IgnoreDataMember]
    [Description(typeof (SecuritySettings_SR), "ExclusionGroup_Description")]
    [DisplayName(typeof (SecuritySettings_SR), "ExclusionGroup")]
    public IUserGroup ExclusionGroup
    {
      get => UserGroupManager.Instance.LoadOrNull(this.ExclusionGroupId);
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              this.ExclusionGroupId = value == null ? 0L : value.Id;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }
    }

    internal static void IMpwDvzHKhmcQn7fUVL() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static TimeSpan Af8x1uzzajREOksZDwD([In] double obj0) => TimeSpan.FromDays(obj0);

    internal static TimeSpan OcyxyCwuuCfeUuqkKMV8([In] double obj0) => TimeSpan.FromHours(obj0);

    internal static object wvlxyUwuwskuKUxE0Vkk() => (object) UserGroupManager.Instance;

    internal static object Oek4cZwubmVM12OtLuni() => (object) UserManager.Instance;

    internal static object JGqnRfwuKJ5Siy5ukWKI(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool jfcQp5zLmFBweAyQsrA() => SecuritySettings.v5F5ApznQxAwVCp1ABe == null;

    internal static SecuritySettings eA2lBEz2moCNxOOQGFA() => SecuritySettings.v5F5ApznQxAwVCp1ABe;

    internal static bool zgRF0TwuUDgXRfnEqkZ6([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object LJXmNowuRfBcmVrjF9hQ([In] object obj0) => (object) ClassSerializationHelper.SerializeObjectByJson(obj0);

    internal static TimeSpan kEhV5owuoF4EXKaXbyIH([In] double obj0) => TimeSpan.FromMinutes(obj0);

    internal static bool F9MvcNwutIVgIj8X3nuZ([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 > obj1;

    internal static object AFCU8dwumYSUKSBrxZxa() => (object) ComponentManager.Current;

    internal static object YSStixwu6Tw2KWe1L86W([In] object obj0) => (object) ((ComponentManager) obj0).ModuleManager;

    internal static bool zdQBb7wuk0vTwSf7B9OL([In] object obj0) => ((IConcurrentLicenseInfo) obj0).IsConcurrent;

    internal static bool Wu9ye9wuDwUUaCGfWfHq([In] object obj0, [In] object obj1) => __nonvirtual (((GlobalSettingsBase) obj0).SkipProperty((PropertyInfo) obj1));

    internal static object EujkZ0wuaAo1MlCoHy86([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static bool MZugdJwuxl2v6TN2JVlb([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static void bbxLIywuCufZ0utyZhyY([In] object obj0) => ((UserSecurityProfileManager) obj0).ResetCountFailedLogonAllUsers();
  }
}

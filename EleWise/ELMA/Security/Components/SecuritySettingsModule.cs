// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.SecuritySettingsModule
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models.Crypto;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>Настройки безопасности</summary>
  [Component]
  public class SecuritySettingsModule : GlobalSettingsModuleBase<SecuritySettings>
  {
    /// <summary>Уникальный идентификатор</summary>
    public const string UID_S = "488050EC-3057-41DC-A7A5-29B01590DA68";
    private static SecuritySettingsModule zFOTEgwuZaX2LKW3w0FH;

    /// <summary>Сервис криптопровайдеров входа в систему</summary>
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
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 == 0 ? 0 : 0;
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

    /// <inheritdoc />
    public override string ModuleNamespace => (string) SecuritySettingsModule.x5KBwPwu77wLXYUAiGBt(--2002186503 ^ 2002178355);

    /// <inheritdoc />
    public override Guid ModuleGuid => new Guid((string) SecuritySettingsModule.x5KBwPwu77wLXYUAiGBt(-629935560 ^ -1103494022 ^ 1682505090));

    /// <inheritdoc />
    public override string ModuleName => (string) SecuritySettingsModule.zsEqsEwuWVhYxVNT8bjg((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(84189367 + 1997579375 ^ 2081783568));

    /// <inheritdoc />
    public override void SaveSettings()
    {
      int num1 = 12;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          IEnumerable<IDigitalSignatureType> typesByProviderUid;
          Guid providerUid;
          Guid digitalSignatureTypeUid;
          switch (num2)
          {
            case 1:
              providerUid = SecuritySettingsModule.BhbG5pwuS0BtLag3O4sN(SecuritySettingsModule.SPnwK3wurwb4FLlfvPMB((object) this.Settings));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 2 : 4;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!typesByProviderUid.Any<IDigitalSignatureType>((Func<IDigitalSignatureType, bool>) (d => SecuritySettingsModule.\u003C\u003Ec__DisplayClass11_0.OEULbQwfoNlSXVqX5MNH(SecuritySettingsModule.\u003C\u003Ec__DisplayClass11_0.EPaTB5wfRIJKEMkCgeyi((object) d), digitalSignatureTypeUid))))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed == 0 ? 1 : 6;
                continue;
              }
              break;
            case 3:
              if (this.Settings == null)
              {
                num2 = 9;
                continue;
              }
              goto case 10;
            case 4:
              digitalSignatureTypeUid = SecuritySettingsModule.WuMeTdwuYmOMIqDLt1Nt((object) this.Settings.DefaultAuthCryptoProviderSettings);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b != 0 ? 0 : 0;
              continue;
            case 5:
              goto label_5;
            case 6:
              goto label_10;
            case 7:
              digitalSignatureTypeUid = Guid.Empty;
              num2 = 3;
              continue;
            case 8:
              if (SecuritySettingsModule.fMvKbnwuygZ05JdXvJeE(providerUid, Guid.Empty))
              {
                num2 = 2;
                continue;
              }
              break;
            case 10:
              if (SecuritySettingsModule.SPnwK3wurwb4FLlfvPMB((object) this.Settings) != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e != 0 ? 1 : 1;
                continue;
              }
              goto default;
            case 11:
              providerUid = Guid.Empty;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 == 0 ? 7 : 4;
              continue;
            case 12:
              goto label_6;
            default:
              typesByProviderUid = this.AuthCryptoProviderService.GetDigitalSignatureTypesByProviderUid(providerUid);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0 ? 6 : 8;
              continue;
          }
          SecuritySettingsModule.hxpAtwwuV25c2Fj5OuxS((object) this);
          num2 = 5;
        }
label_6:
        num1 = 11;
      }
label_5:
      return;
label_10:
      throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--353012470 ^ 353083420)));
    }

    public SecuritySettingsModule()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool kxQUdywuATH8u2SpQZkU() => SecuritySettingsModule.zFOTEgwuZaX2LKW3w0FH == null;

    internal static SecuritySettingsModule mQ6LcYwus5OgJree5aPA() => SecuritySettingsModule.zFOTEgwuZaX2LKW3w0FH;

    internal static object x5KBwPwu77wLXYUAiGBt(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object zsEqsEwuWVhYxVNT8bjg([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object SPnwK3wurwb4FLlfvPMB([In] object obj0) => (object) ((SecuritySettings) obj0).DefaultAuthCryptoProviderSettings;

    internal static Guid BhbG5pwuS0BtLag3O4sN([In] object obj0) => ((DefaultCryptoProviderSettings) obj0).CryptoProviderUid;

    internal static Guid WuMeTdwuYmOMIqDLt1Nt([In] object obj0) => ((DefaultCryptoProviderSettings) obj0).DigitalSignatureTypeUid;

    internal static bool fMvKbnwuygZ05JdXvJeE([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static void hxpAtwwuV25c2Fj5OuxS([In] object obj0) => __nonvirtual (((GlobalSettingsModuleBase<SecuritySettings>) obj0).SaveSettings());
  }
}

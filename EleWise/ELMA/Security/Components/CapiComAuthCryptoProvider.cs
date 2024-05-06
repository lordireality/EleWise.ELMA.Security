// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.CapiComAuthCryptoProvider
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>CAPICOM криптопровайдер для входа в систему</summary>
  [Component]
  public class CapiComAuthCryptoProvider : 
    CryptoProviderBase,
    IAuthCryptoProvider,
    ICryptoProviderBase
  {
    public const string UID_S = "4C91FED4-2FA6-4A49-B16C-32A5BA05E2D4";
    internal static CapiComAuthCryptoProvider BvxOpVHubVB1GYP20sS;

    /// <summary>Модуль настроек CAPICOM провайдера</summary>
    protected CapiComAuthSettingsModule Module => Locator.GetServiceNotNull<CapiComAuthSettingsModule>();

    /// <summary>Ctor</summary>
    public CapiComAuthCryptoProvider()
    {
      CapiComAuthCryptoProvider.t4DLe6HKYHWn6GZKuSg();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Impl = (ICryptoProviderBase) new CapiComCryptoProviderImpl(this.Module.Settings);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Uid провайдера</summary>
    public override Guid ProviderUid => new Guid((string) CapiComAuthCryptoProvider.LcU4daHUTtVLseACLIM(-1807813747 ^ -1807752201));

    internal static void t4DLe6HKYHWn6GZKuSg() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool y7fWRaHwwoyFZsSSeGh() => CapiComAuthCryptoProvider.BvxOpVHubVB1GYP20sS == null;

    internal static CapiComAuthCryptoProvider pihDYnHbOcabsXJlHfB() => CapiComAuthCryptoProvider.BvxOpVHubVB1GYP20sS;

    internal static object LcU4daHUTtVLseACLIM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}

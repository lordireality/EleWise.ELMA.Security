// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.Crypto.DefaultCryptoProviderSettings
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Security.Models.Crypto
{
  /// <summary>Настройки криптопровайдера по умолчанию</summary>
  [DisplayName(typeof (DefaultCryptoProviderSettingsSR), "DefaultCryptoProviderSettings")]
  public class DefaultCryptoProviderSettings
  {
    internal static DefaultCryptoProviderSettings XYckeIEbxgSIm3s2dLy;

    /// <summary>ctor</summary>
    public DefaultCryptoProviderSettings()
    {
      DefaultCryptoProviderSettings.OcaPA2ERlsJdecqCvUd();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>ctor</summary>
    /// <param name="providerUid">uid провайдера</param>
    public DefaultCryptoProviderSettings(Guid providerUid)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.CryptoProviderUid = providerUid;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>ctor</summary>
    /// <param name="providerUid">uid провайдера</param>
    /// <param name="signatureUid">Uid типа электронной подписи</param>
    public DefaultCryptoProviderSettings(Guid providerUid, Guid signatureUid)
    {
      DefaultCryptoProviderSettings.OcaPA2ERlsJdecqCvUd();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.CryptoProviderUid = providerUid;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.DigitalSignatureTypeUid = signatureUid;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e != 0 ? 1 : 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Uid криптопровайдера</summary>
    [DisplayName(typeof (DefaultCryptoProviderSettingsSR), "CryptoProviderUid")]
    public Guid CryptoProviderUid
    {
      get => this.\u003CCryptoProviderUid\u003Ek__BackingField;
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
              this.\u003CCryptoProviderUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af != 0 ? 0 : 0;
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

    /// <summary>Uid типа электронной подписи</summary>
    [DisplayName(typeof (DefaultCryptoProviderSettingsSR), "DigitalSignatureTypeUid")]
    public Guid DigitalSignatureTypeUid
    {
      get => this.\u003CDigitalSignatureTypeUid\u003Ek__BackingField;
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
              this.\u003CDigitalSignatureTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d != 0 ? 0 : 0;
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

    internal static void OcaPA2ERlsJdecqCvUd() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool dOD8bnEKJQ7QJvKarPY() => DefaultCryptoProviderSettings.XYckeIEbxgSIm3s2dLy == null;

    internal static DefaultCryptoProviderSettings nNKT4iEUre9je0gwGX6() => DefaultCryptoProviderSettings.XYckeIEbxgSIm3s2dLy;
  }
}

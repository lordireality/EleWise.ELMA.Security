// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.CryptoProviderSettingsBase
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>Базовые настойки криптопровайдера</summary>
  public class CryptoProviderSettingsBase : GlobalSettingsBase
  {
    private List<CertificationAuthorityInfo> _infos;
    internal static CryptoProviderSettingsBase UXL0O0H0tWKtQ9cUsZ7;

    /// <summary>Ctor</summary>
    public CryptoProviderSettingsBase()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._infos = new List<CertificationAuthorityInfo>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Информация об удостоверяющих центрах</summary>
    [IgnoreDataMember]
    public List<CertificationAuthorityInfo> Infos
    {
      get => this._infos;
      set => this._infos = value;
    }

    /// <summary>
    /// Проверять соответствие алгоритма подписи выбранному криптопровайдеру
    /// </summary>
    [DisplayName(typeof (CryptoProviderSettingsBase_SR), "CheckAlgorithm")]
    public bool CheckAlgorithm
    {
      get => this.\u003CCheckAlgorithm\u003Ek__BackingField;
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
              this.\u003CCheckAlgorithm\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a == 0 ? 0 : 0;
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

    /// <summary>Сериализованные данные</summary>
    [DisplayName(typeof (CryptoProviderSettingsBase_SR), "SerializedInfos")]
    public string SerializedInfos
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this._infos != null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            default:
              goto label_5;
          }
        }
label_4:
        return string.Empty;
label_5:
        return (string) CryptoProviderSettingsBase.bLXEpsHsUvDoSV0KbL1((object) this._infos);
      }
      set
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              goto label_3;
            case 2:
              this._infos = new List<CertificationAuthorityInfo>();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc == 0 ? 0 : 0;
              continue;
            case 3:
              if (!CryptoProviderSettingsBase.xjbchxH7WkjsZYfgepA((object) value))
              {
                this._infos = ClassSerializationHelper.DeserializeObjectByJson<List<CertificationAuthorityInfo>>(value);
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec != 0 ? 1 : 1;
                continue;
              }
              num = 2;
              continue;
            default:
              goto label_8;
          }
        }
label_2:
        return;
label_3:
        return;
label_8:;
      }
    }

    internal static bool e45FeiHZGVDZbpSvrxp() => CryptoProviderSettingsBase.UXL0O0H0tWKtQ9cUsZ7 == null;

    internal static CryptoProviderSettingsBase WJWyqIHAQo7ARZTPpP2() => CryptoProviderSettingsBase.UXL0O0H0tWKtQ9cUsZ7;

    internal static object bLXEpsHsUvDoSV0KbL1([In] object obj0) => (object) ClassSerializationHelper.SerializeObjectByJson(obj0);

    internal static bool xjbchxH7WkjsZYfgepA([In] object obj0) => string.IsNullOrEmpty((string) obj0);
  }
}

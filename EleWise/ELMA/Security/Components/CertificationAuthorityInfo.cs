// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.CertificationAuthorityInfo
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>Информация об удостоверяющем центре</summary>
  public class CertificationAuthorityInfo
  {
    private static CertificationAuthorityInfo LLYlVGHWgY2m0tf2Rrh;

    /// <summary>Адрес сервера</summary>
    [DisplayName(typeof (CertificationAuthorityInfo_SR), "ServerAddress")]
    public string ServerAddress
    {
      get => this.\u003CServerAddress\u003Ek__BackingField;
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
              this.\u003CServerAddress\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 != 0 ? 0 : 0;
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

    /// <summary>Отпечаток корневого сертификата</summary>
    [DisplayName(typeof (CertificationAuthorityInfo_SR), "Thumbprint")]
    public string Thumbprint
    {
      get => this.\u003CThumbprint\u003Ek__BackingField;
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
              this.\u003CThumbprint\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e != 0 ? 0 : 0;
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

    public CertificationAuthorityInfo()
    {
      CertificationAuthorityInfo.AxVM3kHYBM4UxwRIguO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool DNQlbCHrUAcF6ELeJEI() => CertificationAuthorityInfo.LLYlVGHWgY2m0tf2Rrh == null;

    internal static CertificationAuthorityInfo hRcdXpHSIFnmcT8hVab() => CertificationAuthorityInfo.LLYlVGHWgY2m0tf2Rrh;

    internal static void AxVM3kHYBM4UxwRIguO() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}

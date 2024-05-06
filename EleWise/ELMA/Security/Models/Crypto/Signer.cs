// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.Crypto.Signer
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace EleWise.ELMA.Security.Models.Crypto
{
  /// <summary>Подписывающий</summary>
  public class Signer : ISigner
  {
    private static Signer feK0RUEjM1LGBxdbGCJ;

    /// <summary>Информация о подписывающем на основе сертификата</summary>
    /// <param name="certificate"></param>
    public Signer(X509Certificate2 certificate)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 12;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 == 0)
        num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.RawData = certificate.RawData;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc == 0 ? 1 : 1;
            continue;
          case 3:
            this.Issuer = certificate.Issuer;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e != 0 ? 5 : 1;
            continue;
          case 4:
            this.ValidTill = new DateTime?();
            num = 9;
            continue;
          case 5:
            this.Thumbprint = (string) Signer.d9U867EAZWcqIAFWd0f((object) certificate);
            num = 13;
            continue;
          case 6:
            this.Name = (string) Signer.g0lWw9EZ0OSkOtd7puO((object) certificate, X509NameType.SimpleName, false);
            num = 3;
            continue;
          case 7:
            this.Issuer = (string) null;
            num = 8;
            continue;
          case 8:
            this.Thumbprint = (string) null;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 == 0 ? 9 : 10;
            continue;
          case 9:
            goto label_7;
          case 10:
            this.Algorithm = (string) null;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0 ? 0 : 0;
            continue;
          case 11:
            this.ValidTill = new DateTime?(certificate.NotAfter);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 14 : 14;
            continue;
          case 12:
            if (certificate == null)
            {
              this.Name = (string) null;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 7 : 6;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 == 0 ? 0 : 6;
            continue;
          case 13:
            this.ValidFrom = new DateTime?(Signer.L2M1qlEsHvmmENsgFOd((object) certificate));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0 ? 8 : 11;
            continue;
          case 14:
            this.Algorithm = !Signer.pTFqpgE7IOxWxsYddta((object) certificate.PublicKey.Oid.FriendlyName) ? (string) Signer.Ud0gYdEYqsfOFHUUPxU(Signer.pnMkhFESNx3OWaCcu1b(Signer.dyElUrEWngy8nmLNauO((object) certificate))) : (string) Signer.gYulVfErcfe5B5g5Lc3((object) ((PublicKey) Signer.dyElUrEWngy8nmLNauO((object) certificate)).Oid);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec != 0 ? 2 : 2;
            continue;
          default:
            this.ValidFrom = new DateTime?();
            num = 4;
            continue;
        }
      }
label_3:
      return;
label_7:;
    }

    /// <summary>Автор</summary>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0 ? 0 : 0;
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

    /// <summary>Кто выпустил серт.</summary>
    public string Issuer
    {
      get => this.\u003CIssuer\u003Ek__BackingField;
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
              this.\u003CIssuer\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a == 0 ? 0 : 0;
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

    /// <summary>Отпечаток серт.</summary>
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

    /// <summary>Алгоритм</summary>
    public string Algorithm
    {
      get => this.\u003CAlgorithm\u003Ek__BackingField;
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
              this.\u003CAlgorithm\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 == 0 ? 0 : 0;
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

    /// <summary>Действителен с</summary>
    public DateTime? ValidFrom { get; set; }

    /// <summary>Действителен по</summary>
    public DateTime? ValidTill { get; set; }

    /// <summary>"Сырые" данные о подписывающем</summary>
    public byte[] RawData
    {
      get => this.\u003CRawData\u003Ek__BackingField;
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
              this.\u003CRawData\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc == 0 ? 0 : 0;
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

    internal static object g0lWw9EZ0OSkOtd7puO([In] object obj0, [In] X509NameType obj1, [In] bool obj2) => (object) ((X509Certificate2) obj0).GetNameInfo(obj1, obj2);

    internal static object d9U867EAZWcqIAFWd0f([In] object obj0) => (object) ((X509Certificate2) obj0).Thumbprint;

    internal static DateTime L2M1qlEsHvmmENsgFOd([In] object obj0) => ((X509Certificate2) obj0).NotBefore;

    internal static bool pTFqpgE7IOxWxsYddta([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object dyElUrEWngy8nmLNauO([In] object obj0) => (object) ((X509Certificate2) obj0).PublicKey;

    internal static object gYulVfErcfe5B5g5Lc3([In] object obj0) => (object) ((Oid) obj0).Value;

    internal static object pnMkhFESNx3OWaCcu1b([In] object obj0) => (object) ((PublicKey) obj0).Oid;

    internal static object Ud0gYdEYqsfOFHUUPxU([In] object obj0) => (object) ((Oid) obj0).FriendlyName;

    internal static bool N74HZ9ENgNwlXwQ9Kdk() => Signer.feK0RUEjM1LGBxdbGCJ == null;

    internal static Signer CBFROFE0vyiu0xm0gEs() => Signer.feK0RUEjM1LGBxdbGCJ;
  }
}

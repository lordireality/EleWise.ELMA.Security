// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Extensions.CryptoProviderBaseExtensions
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Files;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Extensions
{
  /// <summary>
  /// Расширение для <see cref="T:EleWise.ELMA.Security.Extensions.ICryptoProviderBase" />
  /// </summary>
  public static class CryptoProviderBaseExtensions
  {
    internal static CryptoProviderBaseExtensions mcA6ITg6rLFgtqjeRdV;

    /// <summary>Получить хэш</summary>
    /// <param name="provider">Провайдер</param>
    /// <param name="file">Файл</param>
    /// <param name="algorithm">Алгоритм</param>
    /// <returns></returns>
    public static string GetFileHash(
      this ICryptoProviderBase provider,
      BinaryFile file,
      string algorithm)
    {
      int num = 1;
      ICryptoProviderBase2 cryptoProviderBase2;
      while (true)
      {
        switch (num)
        {
          case 1:
            CryptoProviderBaseExtensions.MkLqvNgxtiX79Ive6EO((object) provider, CryptoProviderBaseExtensions.IkZ7UZgaPYZKQLfEsb8(-1424960806 ^ -1425005690));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 3:
            if (cryptoProviderBase2 == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 2 : 2;
              continue;
            }
            goto label_7;
          default:
            cryptoProviderBase2 = provider as ICryptoProviderBase2;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 == 0 ? 1 : 3;
            continue;
        }
      }
label_6:
      return (string) CryptoProviderBaseExtensions.XobUU5gC11NUkH49jKw((object) provider, (object) file);
label_7:
      return cryptoProviderBase2.GetFileHash(file, algorithm);
    }

    /// <summary>
    /// Поддерживает ли провайдер указанный тип электронной подписи
    /// </summary>
    /// <param name="provider">Провайдер</param>
    /// <param name="digitalSignatureType">Тип электронной подписи</param>
    /// <returns></returns>
    public static bool IsSupportedDigitalSignatureType(
      this ICryptoProviderBase provider,
      IDigitalSignatureType digitalSignatureType)
    {
      return digitalSignatureType.Providers.Contains<Guid>(CryptoProviderBaseExtensions.OSELcAgixYUvP2riaqu((object) provider));
    }

    internal static object IkZ7UZgaPYZKQLfEsb8(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void MkLqvNgxtiX79Ive6EO([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object XobUU5gC11NUkH49jKw([In] object obj0, [In] object obj1) => (object) ((ICryptoProviderBase) obj0).GetFileHash((BinaryFile) obj1);

    internal static bool AsMTnUgk5gTvWOjDWpP() => CryptoProviderBaseExtensions.mcA6ITg6rLFgtqjeRdV == null;

    internal static CryptoProviderBaseExtensions YChYYIgDU7assgB8pnc() => CryptoProviderBaseExtensions.mcA6ITg6rLFgtqjeRdV;

    internal static Guid OSELcAgixYUvP2riaqu([In] object obj0) => ((ICryptoProviderBase) obj0).ProviderUid;
  }
}

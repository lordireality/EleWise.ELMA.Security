// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.Crypto.VerifyResult
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace EleWise.ELMA.Security.Models.Crypto
{
  /// <summary>Результат проверки подписи</summary>
  public class VerifyResult : IVerifyResult
  {
    private static VerifyResult fPwRFvEyXE0B0Z41mlO;

    /// <summary>Верификация прошла неудачно</summary>
    /// <param name="signerCertificate"> </param>
    /// <param name="text"></param>
    /// <returns></returns>
    public static VerifyResult Fail(X509Certificate2 signerCertificate, string text)
    {
      VerifyResult verifyResult = new VerifyResult();
      VerifyResult.x3ihN5EfYT5PwYAbAxt((object) verifyResult, false);
      VerifyResult.Nx0QdOE4MccFLpCmQSi((object) verifyResult, (object) text);
      VerifyResult.X8DCaWEcgpRnlaX2wcj((object) verifyResult, (object) new EleWise.ELMA.Security.Models.Crypto.Signer(signerCertificate));
      return verifyResult;
    }

    /// <summary>Верификация прошла неудачно</summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static VerifyResult Fail(string text)
    {
      VerifyResult verifyResult = new VerifyResult();
      VerifyResult.x3ihN5EfYT5PwYAbAxt((object) verifyResult, false);
      VerifyResult.Nx0QdOE4MccFLpCmQSi((object) verifyResult, (object) text);
      return verifyResult;
    }

    /// <summary>Успешная верификация</summary>
    /// <param name="signerCertificate"></param>
    /// <returns></returns>
    public static VerifyResult Success(X509Certificate2 signerCertificate) => new VerifyResult()
    {
      Verified = true,
      Signer = (ISigner) new EleWise.ELMA.Security.Models.Crypto.Signer(signerCertificate)
    };

    /// <summary>Успешная верификация, но с предупреждениями</summary>
    /// <param name="signerCertificate"></param>
    /// <param name="warning"></param>
    /// <returns></returns>
    public static VerifyResult Success(
      X509Certificate2 signerCertificate,
      string warning)
    {
      VerifyResult verifyResult = new VerifyResult();
      VerifyResult.x3ihN5EfYT5PwYAbAxt((object) verifyResult, true);
      VerifyResult.DwmSL3EPww0g2KeI3KK((object) verifyResult, (object) warning);
      VerifyResult.X8DCaWEcgpRnlaX2wcj((object) verifyResult, (object) new EleWise.ELMA.Security.Models.Crypto.Signer(signerCertificate));
      return verifyResult;
    }

    /// <summary>Выкинуть исключение</summary>
    public void ThrowIfNotVerified()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (!this.Verified)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0 ? 1 : 1;
              continue;
            }
            if (this.Signer == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_3;
        }
      }
label_3:
      throw new CryptographicException(SR.T((string) VerifyResult.FYlGTKE8NClkbkJMAcG(--534238571 ^ 534215411)));
label_6:
      throw new CryptographicException((string) VerifyResult.U4eU7FEQwViLSk4qsxr((object) this.Error));
label_2:;
    }

    /// <summary>Рез-т проверки</summary>
    public bool Verified
    {
      get => this.\u003CVerified\u003Ek__BackingField;
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
              this.\u003CVerified\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 0 : 0;
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

    /// <summary>Подписывающий</summary>
    public ISigner Signer
    {
      get => this.\u003CSigner\u003Ek__BackingField;
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
              this.\u003CSigner\u003Ek__BackingField = value;
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

    /// <summary>Текст ошибки</summary>
    public string Error
    {
      get => this.\u003CError\u003Ek__BackingField;
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
              this.\u003CError\u003Ek__BackingField = value;
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

    /// <summary>Текст предупреждения</summary>
    public string Warning
    {
      get => this.\u003CWarning\u003Ek__BackingField;
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
              this.\u003CWarning\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d != 0 ? 0 : 0;
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

    /// <summary>Имя провайдера</summary>
    public string ProviderName
    {
      get => this.\u003CProviderName\u003Ek__BackingField;
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
              this.\u003CProviderName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff != 0 ? 0 : 0;
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

    public VerifyResult()
    {
      VerifyResult.PdYiJyE5RmLUqTZGbyJ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void x3ihN5EfYT5PwYAbAxt([In] object obj0, bool value) => ((VerifyResult) obj0).Verified = value;

    internal static void Nx0QdOE4MccFLpCmQSi([In] object obj0, [In] object obj1) => ((VerifyResult) obj0).Error = (string) obj1;

    internal static void X8DCaWEcgpRnlaX2wcj([In] object obj0, [In] object obj1) => ((VerifyResult) obj0).Signer = (ISigner) obj1;

    internal static bool OUYAJTEVFO4arT95bIG() => VerifyResult.fPwRFvEyXE0B0Z41mlO == null;

    internal static VerifyResult p1cdKZElIIG0d64OC17() => VerifyResult.fPwRFvEyXE0B0Z41mlO;

    internal static void DwmSL3EPww0g2KeI3KK([In] object obj0, [In] object obj1) => ((VerifyResult) obj0).Warning = (string) obj1;

    internal static object U4eU7FEQwViLSk4qsxr([In] object obj0) => (object) SR.T((string) obj0);

    internal static object FYlGTKE8NClkbkJMAcG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void PdYiJyE5RmLUqTZGbyJ() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}

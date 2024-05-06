// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Components.CapiComCryptoProviderImpl
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Files;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models.Crypto;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EleWise.ELMA.Security.Components
{
  /// <summary>Имплементация CAPICOM провайдера</summary>
  public class CapiComCryptoProviderImpl : ICryptoProviderBase, ICryptoProviderBase2
  {
    private CryptoProviderSettingsBase settings;
    /// <summary>Строковое представление</summary>
    public const string UID_S = "1810E4FB-EE34-437A-AAFC-8D213CBD7B88";
    internal static CapiComCryptoProviderImpl aQ5Zim2dxJKq9v4UmiD;

    /// <summary>Ctor</summary>
    /// <param name="settings">Настройки</param>
    public CapiComCryptoProviderImpl(CryptoProviderSettingsBase settings)
    {
      CapiComCryptoProviderImpl.FbHKBQ2XWFHdbsEC9jR();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.settings = settings;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Uid провайдера</summary>
    public Guid ProviderUid => new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1534797734 ^ 1534734378));

    /// <summary>Отображаемое имя провайдера</summary>
    public string DisplayName => (string) CapiComCryptoProviderImpl.RShEuB21d3ED3FvsoTJ(CapiComCryptoProviderImpl.lgE0wV29hiQXfaeCX8w(-17837901 ^ -17905813));

    /// <summary>Настройки провайдера</summary>
    public CryptoProviderSettingsBase Settings => this.settings;

    /// <summary>Проверяет подпись</summary>
    /// <param name="originalData">Исходные данные</param>
    /// <param name="signedData">Подпись</param>
    /// <param name="verifySignatureOnly">Проверять только валидность подписи, без проверки сертификатов</param>
    /// <returns></returns>
    public IVerifyResult Verify(
      byte[] originalData,
      byte[] signedData,
      bool verifySignatureOnly)
    {
      return this.Verify(originalData, signedData, verifySignatureOnly, false);
    }

    /// <summary>Проверяет подпись</summary>
    /// <param name="originalData">Исходные данные</param>
    /// <param name="signedData">Подпись</param>
    /// <param name="verifySignatureOnly">Проверять только валидность подписи, без проверки сертификатов</param>
    /// <param name="disableWarnings">Выключить предупреждения</param>
    /// <returns></returns>
    public IVerifyResult Verify(
      byte[] originalData,
      byte[] signedData,
      bool verifySignatureOnly,
      bool disableWarnings)
    {
      int num1 = 1;
      X509Certificate2 signerCertificate;
      while (true)
      {
        switch (num1)
        {
          case 1:
            signerCertificate = (X509Certificate2) null;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_71;
          default:
            goto label_2;
        }
      }
label_2:
      IVerifyResult verifyResult;
      try
      {
        bool flag = false;
        int num2 = 10;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0)
          num2 = 10;
        while (true)
        {
          int num3;
          SignedCms signedCms;
          string warning;
          switch (num2)
          {
            case 1:
              signerCertificate = (X509Certificate2) CapiComCryptoProviderImpl.LsLCU32FZ2xwsWnuJoj(CapiComCryptoProviderImpl.OFyo9t2TyK3rYbVjFJW(CapiComCryptoProviderImpl.qC2swg2OT3xJNopwQaq((object) signedCms), 0));
              num2 = 20;
              continue;
            case 2:
              signedCms.Decode(signedData);
              num2 = 28;
              continue;
            case 3:
              try
              {
                if (this.Settings.Infos != null)
                {
                  int num4 = 2;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                      case 3:
                        goto label_36;
                      case 2:
                        List<CertificationAuthorityInfo> infos = this.Settings.Infos;
                        // ISSUE: reference to a compiler-generated field
                        Func<CertificationAuthorityInfo, bool> func = CapiComCryptoProviderImpl.\u003C\u003Ec.\u003C\u003E9__10_0;
                        Func<CertificationAuthorityInfo, bool> predicate;
                        if (func == null)
                        {
                          // ISSUE: reference to a compiler-generated field
                          CapiComCryptoProviderImpl.\u003C\u003Ec.\u003C\u003E9__10_0 = predicate = (Func<CertificationAuthorityInfo, bool>) (i =>
                          {
                            int num5 = 1;
                            while (true)
                            {
                              switch (num5)
                              {
                                case 1:
                                  if (i == null)
                                  {
                                    num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 == 0 ? 0 : 0;
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
                            // ISSUE: reference to a compiler-generated method
                            return !CapiComCryptoProviderImpl.\u003C\u003Ec.bUvMs5wlbJ5FZclRssSi((object) i.Thumbprint);
label_5:
                            return false;
                          });
                        }
                        else
                          goto label_72;
label_26:
                        if (!infos.Any<CertificationAuthorityInfo>(predicate))
                        {
                          num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 != 0 ? 1 : 1;
                          continue;
                        }
                        break;
label_72:
                        predicate = func;
                        goto label_26;
                    }
                    // ISSUE: reference to a compiler-generated method
                    CapiComCryptoProviderImpl.KaVdO72q4P1AWorUukj((object) signerCertificate, (object) this.Settings.Infos.Select<CertificationAuthorityInfo, string>((Func<CertificationAuthorityInfo, string>) (i => (string) CapiComCryptoProviderImpl.\u003C\u003Ec.SQwN8CwlKjYHsAv1w7oX((object) i))).ToArray<string>());
                    num4 = 3;
                  }
                }
                else
                  goto case 19;
              }
              catch (Exception ex)
              {
                int num6 = 2;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0)
                  num6 = 0;
                while (true)
                {
                  switch (num6)
                  {
                    case 2:
                      if (!verifySignatureOnly)
                      {
                        num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0 ? 1 : 1;
                        continue;
                      }
                      goto case 3;
                    case 3:
                      warning = warning + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1277472395 ^ -1277493089) + (string) CapiComCryptoProviderImpl.sQf0Ni2gINsPKO68WwE((object) ex);
                      num6 = 4;
                      continue;
                    case 4:
                      goto label_36;
                    default:
                      goto label_35;
                  }
                }
label_35:
                throw;
              }
            case 4:
              if (originalData != null)
              {
                num2 = 5;
                continue;
              }
              goto case 30;
            case 5:
              if (CapiComCryptoProviderImpl.JSs5VR2hAnqK942kWKy((object) signedCms.ContentInfo) == null)
              {
                num3 = 27;
                break;
              }
              goto case 34;
            case 6:
              goto label_57;
            case 7:
            case 27:
            case 36:
            case 37:
              verifyResult = (IVerifyResult) CapiComCryptoProviderImpl.o1mnhh2vUl7R9QT9IOW((object) signerCertificate, CapiComCryptoProviderImpl.RShEuB21d3ED3FvsoTJ(CapiComCryptoProviderImpl.lgE0wV29hiQXfaeCX8w(-629935560 ^ -1103494022 ^ 1682501282)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 != 0 ? 23 : 17;
              continue;
            case 8:
              verifyResult = (IVerifyResult) VerifyResult.Success(signerCertificate, warning);
              num2 = 31;
              continue;
            case 9:
              if (originalData == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 10:
              signedCms = new SignedCms();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0 ? 2 : 2;
              continue;
            case 11:
            case 14:
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b != 0 ? 3 : 2;
              continue;
            case 12:
              if (signedCms.ContentInfo.Content.Length != 0)
              {
                num3 = 7;
                break;
              }
              goto case 4;
            case 13:
            case 16:
              if (CapiComCryptoProviderImpl.aJRtub2pLis3yN4Je9P((object) signedCms.SignerInfos) == 0)
              {
                num2 = 38;
                continue;
              }
              if (CapiComCryptoProviderImpl.aJRtub2pLis3yN4Je9P((object) signedCms.SignerInfos) <= 1)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 != 0 ? 1 : 0;
                continue;
              }
              goto label_57;
            case 15:
              if (!verifySignatureOnly)
              {
                num2 = 14;
                continue;
              }
              goto case 19;
            case 17:
              if (((ContentInfo) CapiComCryptoProviderImpl.yy6Zsm2MJuowFRGZNO5((object) signedCms)).Content.Length == 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba == 0 ? 33 : 11;
                continue;
              }
              goto case 18;
            case 18:
              flag = true;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 7 : 13;
              continue;
            case 19:
label_36:
              CapiComCryptoProviderImpl.N5gkWW2J9h4u62lD6Cl((object) signedCms, verifySignatureOnly);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 == 0 ? 8 : 3;
              continue;
            case 20:
              if (signerCertificate != null)
              {
                num2 = 32;
                continue;
              }
              goto label_63;
            case 21:
            case 26:
            case 33:
              signedCms = new SignedCms(new ContentInfo(originalData), true);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0 ? 22 : 22;
              continue;
            case 22:
              CapiComCryptoProviderImpl.rHtv5f2Bf08gGBDwRWe((object) signedCms, (object) signedData);
              num2 = 16;
              continue;
            case 23:
            case 31:
              goto label_71;
            case 24:
              goto label_63;
            case 25:
              if (((IEnumerable<byte>) CapiComCryptoProviderImpl.JSs5VR2hAnqK942kWKy(CapiComCryptoProviderImpl.yy6Zsm2MJuowFRGZNO5((object) signedCms))).SequenceEqual<byte>((IEnumerable<byte>) originalData))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 16 : 30;
                continue;
              }
              goto case 7;
            case 28:
              if (CapiComCryptoProviderImpl.JSs5VR2hAnqK942kWKy(CapiComCryptoProviderImpl.yy6Zsm2MJuowFRGZNO5((object) signedCms)) == null)
              {
                num2 = 21;
                continue;
              }
              goto case 17;
            case 29:
              if (!disableWarnings)
              {
                num3 = 11;
                break;
              }
              goto case 15;
            case 30:
            case 35:
              warning = "";
              num2 = 29;
              continue;
            case 32:
              if (flag)
              {
                num2 = 9;
                continue;
              }
              goto case 30;
            case 34:
              if (CapiComCryptoProviderImpl.JSs5VR2hAnqK942kWKy(CapiComCryptoProviderImpl.yy6Zsm2MJuowFRGZNO5((object) signedCms)).Length == 0)
              {
                num2 = 37;
                continue;
              }
              goto case 25;
            case 38:
              goto label_48;
            default:
              if (CapiComCryptoProviderImpl.JSs5VR2hAnqK942kWKy((object) signedCms.ContentInfo) != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 == 0 ? 12 : 1;
                continue;
              }
              goto case 4;
          }
          num2 = num3;
        }
label_48:
        throw new CryptographicException((string) CapiComCryptoProviderImpl.RShEuB21d3ED3FvsoTJ(CapiComCryptoProviderImpl.lgE0wV29hiQXfaeCX8w(839394233 ^ 839464009)));
label_57:
        throw new CryptographicException(EleWise.ELMA.SR.T((string) CapiComCryptoProviderImpl.lgE0wV29hiQXfaeCX8w(84189367 + 1997579375 ^ 2081709364)));
label_63:
        throw new CryptographicException(EleWise.ELMA.SR.T((string) CapiComCryptoProviderImpl.lgE0wV29hiQXfaeCX8w(~-1362653258 ^ 1362716875)));
      }
      catch (Exception ex)
      {
        int num7 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0)
          num7 = 1;
        while (true)
        {
          switch (num7)
          {
            case 1:
              verifyResult = (IVerifyResult) CapiComCryptoProviderImpl.o1mnhh2vUl7R9QT9IOW((object) signerCertificate, CapiComCryptoProviderImpl.sQf0Ni2gINsPKO68WwE((object) ex));
              num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 == 0 ? 0 : 0;
              continue;
            default:
              goto label_71;
          }
        }
      }
label_71:
      return verifyResult;
    }

    /// <summary>Вычисление хеша для подписания файла</summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public string GetFileHash(BinaryFile file) => this.GetFileHash(file, (string) null);

    /// <inheritdoc />
    public string GetFileHash(BinaryFile file, string algorithm)
    {
      int num1 = 4;
      Stream stream;
      HashAlgorithm hashAlgorithm1;
      string str1;
      StringBuilder stringBuilder;
      while (true)
      {
        string str2;
        switch (num1)
        {
          case 1:
            stream = (Stream) CapiComCryptoProviderImpl.s7cfbJ2LuxmwakWkjcx((object) file, (object) GetContentOptions.NonSeekable);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_8;
          case 3:
            if (!CapiComCryptoProviderImpl.I438qZ2eB8XJ63I3g54((object) algorithm))
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 != 0 ? 3 : 7;
              continue;
            }
            str2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788054269 >> 5 ^ -55936260);
            break;
          case 4:
            CapiComCryptoProviderImpl.CkwG2m2IeZRVlKr7oCf((object) file, CapiComCryptoProviderImpl.lgE0wV29hiQXfaeCX8w(-1440374117 ^ -1440433197));
            num1 = 3;
            continue;
          case 5:
            goto label_5;
          case 6:
            hashAlgorithm1 = (HashAlgorithm) CapiComCryptoProviderImpl.iRrCCc2nHwTjw9mBWGW((object) str1);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 == 0 ? 8 : 0;
            continue;
          case 7:
            str2 = algorithm;
            break;
          case 8:
            if (hashAlgorithm1 == null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e == 0 ? 4 : 5;
              continue;
            }
            stringBuilder = new StringBuilder();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 0 : 1;
            continue;
          default:
            goto label_12;
        }
        str1 = str2;
        num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 2 : 6;
      }
label_5:
      throw new Exception(EleWise.ELMA.SR.T((string) CapiComCryptoProviderImpl.lgE0wV29hiQXfaeCX8w(-550634672 ^ -550706640), (object) str1));
label_8:
      string fileHash;
      return fileHash;
label_12:
      try
      {
        HashAlgorithm hashAlgorithm2 = hashAlgorithm1;
        int num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              byte[] numArray = (byte[]) CapiComCryptoProviderImpl.uq3Lvh22C3Pa8f2JkaJ((object) hashAlgorithm1, (object) stream);
              int num3 = 1;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0)
                num3 = 0;
              int index;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    index = 0;
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 == 0 ? 0 : 0;
                    continue;
                  case 2:
                    fileHash = stringBuilder.ToString();
                    num3 = 3;
                    continue;
                  case 3:
                    goto label_8;
                  case 4:
                    CapiComCryptoProviderImpl.lDi4MZ2HFuT4ibMpO1C((object) stringBuilder, (object) numArray[index].ToString((string) CapiComCryptoProviderImpl.lgE0wV29hiQXfaeCX8w(1200636245 >> 6 ^ 18831539)));
                    num3 = 5;
                    continue;
                  case 5:
                    ++index;
                    num3 = 6;
                    continue;
                  default:
                    if (index >= numArray.Length)
                    {
                      num3 = 2;
                      continue;
                    }
                    goto case 4;
                }
              }
            }
            finally
            {
              if (hashAlgorithm2 != null)
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0)
                  num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      CapiComCryptoProviderImpl.twhHy52zb6cs4ug6X1Q((object) hashAlgorithm2);
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_31;
                  }
                }
              }
label_31:;
            }
        }
      }
      finally
      {
        int num5;
        if (stream == null)
          num5 = 2;
        else
          goto label_35;
label_34:
        switch (num5)
        {
          case 1:
          case 2:
        }
label_35:
        CapiComCryptoProviderImpl.twhHy52zb6cs4ug6X1Q((object) stream);
        num5 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0)
        {
          num5 = 0;
          goto label_34;
        }
        else
          goto label_34;
      }
    }

    internal static void FbHKBQ2XWFHdbsEC9jR() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool ADlg2k2EIoqFiaGZR50() => CapiComCryptoProviderImpl.aQ5Zim2dxJKq9v4UmiD == null;

    internal static CapiComCryptoProviderImpl xT6LgD2GDAxqqvmWcNA() => CapiComCryptoProviderImpl.aQ5Zim2dxJKq9v4UmiD;

    internal static object lgE0wV29hiQXfaeCX8w(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object RShEuB21d3ED3FvsoTJ([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object yy6Zsm2MJuowFRGZNO5([In] object obj0) => (object) ((SignedCms) obj0).ContentInfo;

    internal static object JSs5VR2hAnqK942kWKy([In] object obj0) => (object) ((ContentInfo) obj0).Content;

    internal static void rHtv5f2Bf08gGBDwRWe([In] object obj0, [In] object obj1) => ((SignedCms) obj0).Decode((byte[]) obj1);

    internal static int aJRtub2pLis3yN4Je9P([In] object obj0) => ((SignerInfoCollection) obj0).Count;

    internal static object qC2swg2OT3xJNopwQaq([In] object obj0) => (object) ((SignedCms) obj0).SignerInfos;

    internal static object OFyo9t2TyK3rYbVjFJW([In] object obj0, [In] int obj1) => (object) ((SignerInfoCollection) obj0)[obj1];

    internal static object LsLCU32FZ2xwsWnuJoj([In] object obj0) => (object) ((SignerInfo) obj0).Certificate;

    internal static object o1mnhh2vUl7R9QT9IOW([In] object obj0, [In] object obj1) => (object) VerifyResult.Fail((X509Certificate2) obj0, (string) obj1);

    internal static void KaVdO72q4P1AWorUukj([In] object obj0, [In] object obj1) => ((X509Certificate2) obj0).CheckRoot((string[]) obj1);

    internal static object sQf0Ni2gINsPKO68WwE([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void N5gkWW2J9h4u62lD6Cl([In] object obj0, [In] bool obj1) => ((SignedCms) obj0).CheckSignature(obj1);

    internal static void CkwG2m2IeZRVlKr7oCf([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool I438qZ2eB8XJ63I3g54([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object iRrCCc2nHwTjw9mBWGW([In] object obj0) => (object) HashAlgorithm.Create((string) obj0);

    internal static object s7cfbJ2LuxmwakWkjcx([In] object obj0, [In] object obj1) => (object) ((BinaryFile) obj0).GetContent((GetContentOptions) obj1);

    internal static object uq3Lvh22C3Pa8f2JkaJ([In] object obj0, [In] object obj1) => (object) ((HashAlgorithm) obj0).ComputeHash((Stream) obj1);

    internal static object lDi4MZ2HFuT4ibMpO1C([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static void twhHy52zb6cs4ug6X1Q([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}

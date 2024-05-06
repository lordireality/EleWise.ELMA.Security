// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Extensions.X509Certificate2Extensions
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EleWise.ELMA.Security.Extensions
{
  /// <summary>Расширение для X509Certificate2</summary>
  public static class X509Certificate2Extensions
  {
    private static readonly Dictionary<X509ChainStatusFlags, string> localizedX509Statuses;
    private static X509Certificate2Extensions p5fATagy730ifRyvFxT;

    /// <summary>
    /// Проверить отпечаток корневого сертификата для указанного сертификата
    /// </summary>
    /// <param name="signerCertificate"></param>
    /// <param name="thumbprint"></param>
    public static void CheckRoot(this X509Certificate2 signerCertificate, string thumbprint)
    {
      int num1 = 18;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        X509Certificate2 x509Certificate2;
        X509Chain x509Chain;
        X509ChainElementEnumerator enumerator;
        X509ChainStatus x509ChainStatus;
        int index;
        X509ChainStatus[] x509ChainStatusArray;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
            case 19:
              if (index < x509ChainStatusArray.Length)
              {
                num2 = 20;
                continue;
              }
              goto case 26;
            case 3:
              goto label_21;
            case 4:
              if (X509Certificate2Extensions.UbFr1UgQhl3woIV6BT7((object) x509Chain, (object) signerCertificate))
              {
                num2 = 10;
                continue;
              }
              goto case 6;
            case 5:
              if (x509Certificate2 == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 == 0 ? 3 : 3;
                continue;
              }
              if (!X509Certificate2Extensions.NDWrlCgM4lX00R1l6Uc(X509Certificate2Extensions.zBwosxg1THrc5l3hXRN((object) x509Certificate2), (object) thumbprint))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 == 0 ? 7 : 3;
                continue;
              }
              goto case 8;
            case 6:
              stringBuilder = new StringBuilder();
              num2 = 21;
              continue;
            case 7:
              goto label_33;
            case 8:
              X509Certificate2Extensions.B32Ug7ghDoks8syCf0k(X509Certificate2Extensions.PRZBaigEk9VdjV5aGbj(), X509Certificate2Extensions.XTYneggdVbFeMRK9qci(X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(-617657301 ^ -617628031), (object) new object[2]
              {
                (object) thumbprint,
                (object) x509Certificate2.Thumbprint
              }));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 == 0 ? 24 : 14;
              continue;
            case 9:
            case 23:
              if (!X509Certificate2Extensions.LqBhdAg9ATTJrHQFVgB((object) enumerator))
              {
                num2 = 5;
                continue;
              }
              goto label_5;
            case 10:
              x509Certificate2 = (X509Certificate2) null;
              num2 = 14;
              continue;
            case 11:
              goto label_5;
            case 12:
              X509Certificate2Extensions.QMAnEeg5M6GM5rSGf48((object) stringBuilder, X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO(X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(-1115268484 ^ -1115247654)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 != 0 ? 0 : 0;
              continue;
            case 13:
              index = 0;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0 ? 19 : 19;
              continue;
            case 14:
              enumerator = ((X509ChainElementCollection) X509Certificate2Extensions.aQp0GZgGkJ4eljFqvYS((object) x509Chain)).GetEnumerator();
              num2 = 23;
              continue;
            case 15:
              goto label_17;
            case 16:
            case 20:
              x509ChainStatus = x509ChainStatusArray[index];
              num2 = 28;
              continue;
            case 17:
              thumbprint = ((string) X509Certificate2Extensions.jcalDugPfWx7loY2oWj((object) thumbprint, X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(150349507 - 521039768 ^ -370678079), (object) string.Empty)).ToUpper();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 != 0 ? 12 : 27;
              continue;
            case 18:
              if (!X509Certificate2Extensions.KpU3SOgfS0R4RDrpL57((object) thumbprint))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 17 : 12;
                continue;
              }
              goto label_17;
            case 21:
              if (((IEnumerable<X509ChainStatus>) X509Certificate2Extensions.rDxrMng8aJyZS7L4gi0((object) x509Chain)).Any<X509ChainStatus>())
              {
                num2 = 25;
                continue;
              }
              goto case 12;
            case 22:
              ++index;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 2 : 2;
              continue;
            case 24:
              goto label_30;
            case 26:
              ((ILogger) X509Certificate2Extensions.PRZBaigEk9VdjV5aGbj()).Error((object) stringBuilder.ToString());
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a != 0 ? 1 : 1;
              continue;
            case 27:
              x509Chain = new X509Chain();
              num2 = 4;
              continue;
            case 28:
              stringBuilder.AppendLine((string) X509Certificate2Extensions.XTYneggdVbFeMRK9qci(X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(-1859356887 ^ -1859335257), (object) new object[2]
              {
                (object) x509ChainStatus.Status.ToString(),
                (object) X509Certificate2Extensions.localizedX509Statuses[x509ChainStatus.Status]
              }));
              num2 = 22;
              continue;
            default:
              x509ChainStatusArray = (X509ChainStatus[]) X509Certificate2Extensions.rDxrMng8aJyZS7L4gi0((object) x509Chain);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 != 0 ? 13 : 10;
              continue;
          }
        }
label_5:
        x509Certificate2 = (X509Certificate2) X509Certificate2Extensions.CbsISGgXYpi3C2Zq2iv((object) enumerator.Current);
        num1 = 9;
      }
label_33:
      return;
label_10:
      throw new CryptographicException(stringBuilder.ToString());
label_17:
      throw new CryptographicException((string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO(X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(1687460816 ^ 1687448224)));
label_21:
      throw new CryptographicException((string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1893095749 ^ -1893116783)));
label_30:
      throw new CryptographicException((string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO(X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(1007654939 ^ 1007643467)));
    }

    /// <summary>
    /// Проверить отпечатки корневого сертификата для указанного сертификата. Должен совпать хотя бы один.
    /// </summary>
    /// <param name="signerCertificate"></param>
    /// <param name="thumbprints"></param>
    public static void CheckRoot(this X509Certificate2 signerCertificate, string[] thumbprints)
    {
      int num1 = 1;
      StringBuilder stringBuilder1;
      int index;
      bool flag;
      string[] strArray;
      string thumbprint;
      while (true)
      {
        switch (num1)
        {
          case 1:
            flag = false;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
          case 5:
            thumbprint = strArray[index];
            num1 = 8;
            continue;
          case 4:
            goto label_22;
          case 6:
            index = 0;
            num1 = 10;
            continue;
          case 7:
label_4:
            ++index;
            num1 = 12;
            continue;
          case 8:
            try
            {
              signerCertificate.CheckRoot(thumbprint);
              int num2 = 0;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0)
                num2 = 0;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_5;
                  default:
                    flag = true;
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 != 0 ? 1 : 1;
                    continue;
                }
              }
            }
            catch (Exception ex)
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 != 0)
                num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    StringBuilder stringBuilder2 = stringBuilder1;
                    object obj;
                    if (thumbprints.Length <= 1)
                      obj = X509Certificate2Extensions.OUhBJCgBICRbe5aJ5df((object) ex);
                    else
                      obj = X509Certificate2Extensions.XTYneggdVbFeMRK9qci((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629935560 ^ -1103494022 ^ 1682507254), (object) new object[2]
                      {
                        (object) thumbprint,
                        X509Certificate2Extensions.OUhBJCgBICRbe5aJ5df((object) ex)
                      });
                    X509Certificate2Extensions.FB1oUAgpENHFk7mgPB5((object) stringBuilder2, obj);
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
            }
          case 9:
label_5:
            if (flag)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b != 0 ? 4 : 4;
              continue;
            }
            goto label_2;
          case 10:
          case 12:
            if (index < strArray.Length)
            {
              num1 = 5;
              continue;
            }
            goto case 9;
          case 11:
            strArray = thumbprints;
            num1 = 6;
            continue;
          default:
            stringBuilder1 = new StringBuilder();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0 ? 11 : 2;
            continue;
        }
      }
label_22:
      return;
label_2:
      throw new CryptographicException(stringBuilder1.ToString());
    }

    static X509Certificate2Extensions()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            X509Certificate2Extensions.localizedX509Statuses = new Dictionary<X509ChainStatusFlags, string>()
            {
              {
                X509ChainStatusFlags.NoError,
                (string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-206147790 ^ -206136484))
              },
              {
                X509ChainStatusFlags.NotTimeValid,
                (string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO(X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(1245871191 - 2145700088 ^ -899856425))
              },
              {
                X509ChainStatusFlags.NotTimeNested,
                (string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO(X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(839394233 ^ 839439913))
              },
              {
                X509ChainStatusFlags.Revoked,
                (string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO(X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(384582979 ^ 384611077))
              },
              {
                X509ChainStatusFlags.NotSignatureValid,
                EleWise.ELMA.SR.T((string) X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(-801309555 ^ -801371403))
              },
              {
                X509ChainStatusFlags.NotValidForUsage,
                (string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO(X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(2047763786 ^ 1536686658 ^ 563702206))
              },
              {
                X509ChainStatusFlags.UntrustedRoot,
                (string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO(X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(-2143851882 - 923330995 ^ 1227781657))
              },
              {
                X509ChainStatusFlags.RevocationStatusUnknown,
                (string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--534238571 ^ 534192727))
              },
              {
                X509ChainStatusFlags.Cyclic,
                (string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(631805505 ^ 631792099))
              },
              {
                X509ChainStatusFlags.InvalidExtension,
                (string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO(X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(-1277802350 ^ -1277771918))
              },
              {
                X509ChainStatusFlags.InvalidPolicyConstraints,
                (string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO(X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(266768307 ^ 266762151))
              },
              {
                X509ChainStatusFlags.InvalidBasicConstraints,
                EleWise.ELMA.SR.T((string) X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(-1277472395 ^ -1277449937))
              },
              {
                X509ChainStatusFlags.InvalidNameConstraints,
                (string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO(X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(-17837901 ^ -17881069))
              },
              {
                X509ChainStatusFlags.HasNotSupportedNameConstraint,
                (string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2110195605 ^ 2110259061))
              },
              {
                X509ChainStatusFlags.HasNotDefinedNameConstraint,
                (string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO(X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(-94240706 ^ -94176886))
              },
              {
                X509ChainStatusFlags.HasNotPermittedNameConstraint,
                (string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO(X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(--2002186503 ^ 2002127645))
              },
              {
                X509ChainStatusFlags.HasExcludedNameConstraint,
                EleWise.ELMA.SR.T((string) X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(-1489118656 ^ 643054122 ^ -2123818474))
              },
              {
                X509ChainStatusFlags.PartialChain,
                (string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO(X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(1458233619 ^ 1458183129))
              },
              {
                X509ChainStatusFlags.CtlNotTimeValid,
                (string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO(X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(213026252 ^ 213024398))
              },
              {
                X509ChainStatusFlags.CtlNotSignatureValid,
                (string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO(X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(-1527733619 - 442652394 ^ -1970358363))
              },
              {
                X509ChainStatusFlags.CtlNotValidForUsage,
                EleWise.ELMA.SR.T((string) X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(-906676699 ^ -906638667))
              },
              {
                X509ChainStatusFlags.OfflineRevocation,
                (string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO(X509Certificate2Extensions.J8wbZMg4Nyxqb5TTaHd(-347045778 ^ -347046538))
              },
              {
                X509ChainStatusFlags.NoIssuanceChainPolicy,
                (string) X509Certificate2Extensions.iH4ktLgc5tcEqNWIYWO((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1807813747 ^ -1807872471))
              }
            };
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 0 : 0;
            continue;
          case 2:
            X509Certificate2Extensions.QT8ON9gOebS3bbfr5Bh();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool KpU3SOgfS0R4RDrpL57([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object J8wbZMg4Nyxqb5TTaHd(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object iH4ktLgc5tcEqNWIYWO([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object jcalDugPfWx7loY2oWj([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static bool UbFr1UgQhl3woIV6BT7([In] object obj0, [In] object obj1) => ((X509Chain) obj0).Build((X509Certificate2) obj1);

    internal static object rDxrMng8aJyZS7L4gi0([In] object obj0) => (object) ((X509Chain) obj0).ChainStatus;

    internal static object QMAnEeg5M6GM5rSGf48([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).AppendLine((string) obj1);

    internal static object XTYneggdVbFeMRK9qci([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);

    internal static object PRZBaigEk9VdjV5aGbj() => (object) Logger.Log;

    internal static object aQp0GZgGkJ4eljFqvYS([In] object obj0) => (object) ((X509Chain) obj0).ChainElements;

    internal static object CbsISGgXYpi3C2Zq2iv([In] object obj0) => (object) ((X509ChainElement) obj0).Certificate;

    internal static bool LqBhdAg9ATTJrHQFVgB([In] object obj0) => ((X509ChainElementEnumerator) obj0).MoveNext();

    internal static object zBwosxg1THrc5l3hXRN([In] object obj0) => (object) ((X509Certificate2) obj0).Thumbprint;

    internal static bool NDWrlCgM4lX00R1l6Uc([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static void B32Ug7ghDoks8syCf0k([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static bool uCraDZgVXZWT1wfPAo3() => X509Certificate2Extensions.p5fATagy730ifRyvFxT == null;

    internal static X509Certificate2Extensions U2Uh5AglTVqKLy5csUY() => X509Certificate2Extensions.p5fATagy730ifRyvFxT;

    internal static object OUhBJCgBICRbe5aJ5df([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static object FB1oUAgpENHFk7mgPB5([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static void QT8ON9gOebS3bbfr5Bh() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}

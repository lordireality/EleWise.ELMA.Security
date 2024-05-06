// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.LocalStorageManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EleWise.ELMA.Security.Managers
{
  /// <summary>Менеждер локального хранилища сертификатов</summary>
  public class LocalStorageManager
  {
    internal static LocalStorageManager uCHqXN9ZOoDxLmMb54c;

    /// <summary>Получить сертификаты из хранилища "Личные"</summary>
    /// <param name="findValue"></param>
    /// <param name="findType"></param>
    /// <param name="hasPrivateKey"></param>
    /// <returns></returns>
    public static IEnumerable<X509Certificate2> GetLocalCertificates(
      object findValue,
      X509FindType findType = X509FindType.FindBySubjectName,
      bool? hasPrivateKey = null)
    {
      X509Store x509Store = new X509Store(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1848373724 >> 1 ^ 924140760), StoreLocation.CurrentUser);
      x509Store.Open(OpenFlags.OpenExistingOnly);
      return x509Store.Certificates.Find(findType, findValue, false).Cast<X509Certificate2>().Where<X509Certificate2>((Func<X509Certificate2, bool>) (c =>
      {
        int num1 = 1;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (hasPrivateKey.HasValue)
              {
                num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        int num2 = LocalStorageManager.\u003C\u003Ec__DisplayClass0_0.HgDNytwsnNkDuX25Oisb((object) c) ? 1 : 0;
        bool? nullable = hasPrivateKey;
        int num3 = nullable.GetValueOrDefault() ? 1 : 0;
        return num2 == num3 & nullable.HasValue;
label_5:
        return true;
      }));
    }

    /// <summary>Получить сертификат по отпечатку</summary>
    /// <param name="thumbprint"></param>
    /// <returns></returns>
    public static X509Certificate2 GetLocalCertificateByThumbprint(string thumbprint)
    {
      int num1 = 1;
      List<X509Certificate2>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = LocalStorageManager.GetLocalCertificates((object) thumbprint, X509FindType.FindByThumbprint, new bool?(true)).ToList<X509Certificate2>().GetEnumerator();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_25;
          default:
            goto label_2;
        }
      }
label_2:
      X509Certificate2 certificateByThumbprint;
      try
      {
label_11:
        if (enumerator.MoveNext())
          goto label_9;
        else
          goto label_12;
label_4:
        X509Certificate2 current;
        int num2;
        while (true)
        {
          X509KeyUsageExtension keyUsageExtension;
          X509KeyUsageFlags x509KeyUsageFlags;
          int num3;
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
              if (x509KeyUsageFlags.HasFlag((Enum) X509KeyUsageFlags.DigitalSignature))
              {
                num2 = 4;
                continue;
              }
              goto label_11;
            case 3:
              if (keyUsageExtension == null)
              {
                num2 = 5;
                continue;
              }
              num3 = (int) LocalStorageManager.rkbcR19WbdGhnORsg98((object) keyUsageExtension);
              break;
            case 4:
              certificateByThumbprint = current;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 == 0 ? 5 : 7;
              continue;
            case 5:
              num3 = 0;
              break;
            case 6:
              goto label_25;
            case 7:
              goto label_26;
            case 8:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              IEnumerable<X509Extension> source = ((IEnumerable) LocalStorageManager.c0BGdM97CLpvehkvvjC((object) current)).Cast<X509Extension>().Where<X509Extension>((Func<X509Extension, bool>) (e => (string) LocalStorageManager.\u003C\u003Ec.YEZM6yw7wSuobx9HOL8R(LocalStorageManager.\u003C\u003Ec.eib73ow7uQH2w6QEyUkE((object) e)) == (string) LocalStorageManager.\u003C\u003Ec.TXWEYHw7bq97Q11ZD9oG(150349507 - 521039768 ^ -370769755)));
              // ISSUE: reference to a compiler-generated field
              Func<X509Extension, X509KeyUsageExtension> func = LocalStorageManager.\u003C\u003Ec.\u003C\u003E9__1_1;
              Func<X509Extension, X509KeyUsageExtension> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                LocalStorageManager.\u003C\u003Ec.\u003C\u003E9__1_1 = selector = (Func<X509Extension, X509KeyUsageExtension>) (e => (X509KeyUsageExtension) e);
              }
              else
                goto label_28;
label_18:
              keyUsageExtension = source.Select<X509Extension, X509KeyUsageExtension>(selector).FirstOrDefault<X509KeyUsageExtension>();
              num2 = 3;
              continue;
label_28:
              selector = func;
              goto label_18;
            case 9:
              goto label_11;
            default:
              if (LocalStorageManager.BBGfKc9r1DRsHlCukAo((object) current))
              {
                num2 = 2;
                continue;
              }
              goto label_11;
          }
          x509KeyUsageFlags = (X509KeyUsageFlags) num3;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 != 0 ? 0 : 0;
        }
label_9:
        current = enumerator.Current;
        num2 = 8;
        goto label_4;
label_12:
        num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 == 0 ? 2 : 6;
        goto label_4;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af != 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
label_26:
      return certificateByThumbprint;
label_25:
      return (X509Certificate2) null;
    }

    /// <summary>Проверка сертификата с построением цепочки</summary>
    /// <param name="certificate">Сертификат</param>
    /// <param name="rootThumbprint">Отпечаток корневого сертификата </param>
    /// <returns></returns>
    public static void VerifyCertificateChain(X509Certificate2 certificate, string rootThumbprint = null)
    {
      int num1 = 21;
      while (true)
      {
        int num2 = num1;
        int index;
        X509ChainStatus[] x509ChainStatusArray;
        X509ChainElement x509ChainElement1;
        X509ChainElement x509ChainElement2;
        X509Chain x509Chain;
        X509ChainElementEnumerator enumerator;
        StringBuilder stringBuilder;
        X509ChainStatus x509ChainStatus;
        while (true)
        {
          switch (num2)
          {
            case 1:
              LocalStorageManager.OTb5GH9QfDLJuc20dFI((object) Logger.Log, LocalStorageManager.jRVMCi9GOdNfPAI4yCS((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1640694811 << 2 ^ 2027115318), (object) new object[2]
              {
                LocalStorageManager.K0ullf9dSfOrLwNYKvK(LocalStorageManager.IgZjT495aDlCL7HMmaw((object) x509ChainElement1)),
                LocalStorageManager.voXaAp9EjZZlq0YnvYk((object) x509ChainElement1.Certificate)
              }));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_35;
            case 3:
              if (((X509Certificate2) LocalStorageManager.IgZjT495aDlCL7HMmaw((object) x509ChainElement2)).Thumbprint != rootThumbprint)
              {
                num2 = 22;
                continue;
              }
              goto label_38;
            case 4:
            case 17:
              if (index >= x509ChainStatusArray.Length)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 == 0 ? 10 : 27;
                continue;
              }
              goto case 25;
            case 5:
              x509ChainStatusArray = (X509ChainStatus[]) LocalStorageManager.WhI8qy9cADPXiGn0ADj((object) x509Chain);
              num2 = 29;
              continue;
            case 6:
              stringBuilder = new StringBuilder();
              num2 = 23;
              continue;
            case 7:
            case 18:
              x509ChainElement1 = (X509ChainElement) LocalStorageManager.BfMHpJ98dnW5lpXkRRV((object) enumerator);
              num2 = 11;
              continue;
            case 8:
              if (x509ChainElement2 != null)
              {
                num2 = 16;
                continue;
              }
              goto label_5;
            case 9:
            case 12:
              if (LocalStorageManager.z7kjMM9XonjgtsHdZ6C((object) enumerator))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 != 0 ? 1 : 18;
                continue;
              }
              goto case 8;
            case 10:
              LocalStorageManager.SHvO9e94X3eF4G7TO8v((object) stringBuilder, (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1324692970 << 3 ^ -2007569346), (object) x509ChainStatus.Status.ToString(), (object) x509ChainStatus.StatusInformation));
              num2 = 26;
              continue;
            case 11:
              if (LocalStorageManager.BBGfKc9r1DRsHlCukAo(LocalStorageManager.IgZjT495aDlCL7HMmaw((object) x509ChainElement1)))
              {
                x509ChainElement2 = x509ChainElement1;
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc != 0 ? 12 : 12;
                continue;
              }
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d != 0 ? 0 : 1;
              continue;
            case 13:
              LocalStorageManager.c8QadM9yJ0FiPdigWNp(LocalStorageManager.eK21eW9SbCgSoFbgWmy((object) x509Chain), X509RevocationFlag.EntireChain);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 30 : 11;
              continue;
            case 14:
              goto label_5;
            case 15:
              goto label_32;
            case 16:
              if (LocalStorageManager.I1XDQp99o2FmIZGpdrI((object) rootThumbprint))
              {
                num2 = 2;
                continue;
              }
              goto case 3;
            case 19:
              goto label_36;
            case 20:
              LocalStorageManager.jrncY39YHt8ffP3IvjF(LocalStorageManager.eK21eW9SbCgSoFbgWmy((object) x509Chain), X509RevocationMode.Online);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 != 0 ? 13 : 13;
              continue;
            case 21:
              x509Chain = new X509Chain();
              num2 = 20;
              continue;
            case 22:
              LocalStorageManager.OTb5GH9QfDLJuc20dFI(LocalStorageManager.B0C1ei9PlmW3DvkJAsV(), (object) EleWise.ELMA.SR.T((string) LocalStorageManager.rOGy5r9lj45uGJBO7B5(2086891181 ^ 2086917077), LocalStorageManager.voXaAp9EjZZlq0YnvYk((object) x509ChainElement2.Certificate), (object) rootThumbprint));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 == 0 ? 12 : 15;
              continue;
            case 23:
              LocalStorageManager.SHvO9e94X3eF4G7TO8v((object) stringBuilder, LocalStorageManager.Yn4Ipa9fx9144LPXT2L(LocalStorageManager.rOGy5r9lj45uGJBO7B5(-550634672 ^ -550680722)));
              num2 = 5;
              continue;
            case 24:
              goto label_20;
            case 25:
              x509ChainStatus = x509ChainStatusArray[index];
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 == 0 ? 10 : 8;
              continue;
            case 26:
              goto label_13;
            case 27:
              LocalStorageManager.OTb5GH9QfDLJuc20dFI(LocalStorageManager.B0C1ei9PlmW3DvkJAsV(), (object) stringBuilder.ToString());
              num2 = 19;
              continue;
            case 28:
              x509ChainElement2 = (X509ChainElement) null;
              num2 = 24;
              continue;
            case 29:
              index = 0;
              num2 = 4;
              continue;
            case 30:
              if (LocalStorageManager.LFtARj9VJnajLCDLsG9((object) x509Chain, (object) certificate))
              {
                num2 = 28;
                continue;
              }
              goto case 6;
            default:
              goto label_17;
          }
        }
label_13:
        ++index;
        num1 = 17;
        continue;
label_20:
        enumerator = x509Chain.ChainElements.GetEnumerator();
        num1 = 9;
      }
label_35:
      return;
label_5:
      throw new CryptographicException((string) LocalStorageManager.Yn4Ipa9fx9144LPXT2L(LocalStorageManager.rOGy5r9lj45uGJBO7B5(~248518394 ^ -248556481)));
label_38:
      return;
label_17:
      throw new CryptographicException(EleWise.ELMA.SR.T((string) LocalStorageManager.rOGy5r9lj45uGJBO7B5(--2002186503 ^ 2002144767)));
label_32:
      throw new CryptographicException((string) LocalStorageManager.Yn4Ipa9fx9144LPXT2L(LocalStorageManager.rOGy5r9lj45uGJBO7B5(868767899 ^ 868804247)));
label_36:
      throw new CryptographicException((string) LocalStorageManager.Yn4Ipa9fx9144LPXT2L((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-901653144 ^ -901684906)));
    }

    public LocalStorageManager()
    {
      LocalStorageManager.a0aC1Z91uuujVW3mSqJ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object c0BGdM97CLpvehkvvjC([In] object obj0) => (object) ((X509Certificate2) obj0).Extensions;

    internal static X509KeyUsageFlags rkbcR19WbdGhnORsg98([In] object obj0) => ((X509KeyUsageExtension) obj0).KeyUsages;

    internal static bool BBGfKc9r1DRsHlCukAo([In] object obj0) => ((X509Certificate2) obj0).Verify();

    internal static bool ycV4xC9A01uCP8NL4U6() => LocalStorageManager.uCHqXN9ZOoDxLmMb54c == null;

    internal static LocalStorageManager uqdSfm9stwSxIpWQtPF() => LocalStorageManager.uCHqXN9ZOoDxLmMb54c;

    internal static object eK21eW9SbCgSoFbgWmy([In] object obj0) => (object) ((X509Chain) obj0).ChainPolicy;

    internal static void jrncY39YHt8ffP3IvjF([In] object obj0, [In] X509RevocationMode obj1) => ((X509ChainPolicy) obj0).RevocationMode = obj1;

    internal static void c8QadM9yJ0FiPdigWNp([In] object obj0, [In] X509RevocationFlag obj1) => ((X509ChainPolicy) obj0).RevocationFlag = obj1;

    internal static bool LFtARj9VJnajLCDLsG9([In] object obj0, [In] object obj1) => ((X509Chain) obj0).Build((X509Certificate2) obj1);

    internal static object rOGy5r9lj45uGJBO7B5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Yn4Ipa9fx9144LPXT2L([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object SHvO9e94X3eF4G7TO8v([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).AppendLine((string) obj1);

    internal static object WhI8qy9cADPXiGn0ADj([In] object obj0) => (object) ((X509Chain) obj0).ChainStatus;

    internal static object B0C1ei9PlmW3DvkJAsV() => (object) Logger.Log;

    internal static void OTb5GH9QfDLJuc20dFI([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static object BfMHpJ98dnW5lpXkRRV([In] object obj0) => (object) ((X509ChainElementEnumerator) obj0).Current;

    internal static object IgZjT495aDlCL7HMmaw([In] object obj0) => (object) ((X509ChainElement) obj0).Certificate;

    internal static object K0ullf9dSfOrLwNYKvK([In] object obj0) => (object) ((X509Certificate) obj0).Subject;

    internal static object voXaAp9EjZZlq0YnvYk([In] object obj0) => (object) ((X509Certificate2) obj0).Thumbprint;

    internal static object jRVMCi9GOdNfPAI4yCS([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);

    internal static bool z7kjMM9XonjgtsHdZ6C([In] object obj0) => ((X509ChainElementEnumerator) obj0).MoveNext();

    internal static bool I1XDQp99o2FmIZGpdrI([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void a0aC1Z91uuujVW3mSqJ() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}

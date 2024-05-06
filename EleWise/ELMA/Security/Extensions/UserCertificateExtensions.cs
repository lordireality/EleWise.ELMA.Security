// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Extensions.UserCertificateExtensions
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Security.Models;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Security.Extensions
{
  /// <summary>Расширения сущности Сертификат пользователя</summary>
  public static class UserCertificateExtensions
  {
    internal static UserCertificateExtensions R4palEgICbCqhGhlPXk;

    /// <summary>
    /// Получить отпечаток сертификата, разделенный на парым (побайтово)
    /// </summary>
    /// <param name="cert"></param>
    /// <param name="splitter"></param>
    /// <returns></returns>
    public static string GetThumbprintByPairs(this IUserCertificate cert, string splitter = ":")
    {
      int num1 = 10;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 5:
            case 12:
              goto label_8;
            case 2:
            case 9:
              goto label_3;
            case 3:
            case 14:
              if (num3 >= UserCertificateExtensions.PWXuwPgzJbhCmghcDgW((object) cert.Thumbprint))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 11 : 5;
                continue;
              }
              goto case 7;
            case 4:
              ++num3;
              num2 = 14;
              continue;
            case 6:
              if (num3 <= 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 0 : 1;
                continue;
              }
              break;
            case 7:
              if (num3 % 2 == 0)
                goto case 6;
              else
                goto label_15;
            case 8:
              if (!string.IsNullOrEmpty((string) UserCertificateExtensions.qcLwWtgL4XyRNE9u8Fr((object) cert)))
              {
                stringBuilder = new StringBuilder();
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0 ? 13 : 13;
                continue;
              }
              num2 = 2;
              continue;
            case 10:
              if (cert == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0 ? 5 : 9;
                continue;
              }
              goto case 8;
            case 11:
              goto label_19;
            case 13:
              goto label_16;
          }
          UserCertificateExtensions.KqUpOGg23Ml7Jk60WMx((object) stringBuilder, (object) splitter);
          num2 = 5;
        }
label_8:
        stringBuilder.Append(UserCertificateExtensions.FITyErgH0R7WymlLena((object) cert.Thumbprint, num3));
        num1 = 4;
        continue;
label_15:
        num1 = 12;
        continue;
label_16:
        num3 = 0;
        num1 = 3;
      }
label_3:
      return (string) null;
label_19:
      return stringBuilder.ToString();
    }

    internal static object qcLwWtgL4XyRNE9u8Fr([In] object obj0) => (object) ((IUserCertificate) obj0).Thumbprint;

    internal static object KqUpOGg23Ml7Jk60WMx([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static char FITyErgH0R7WymlLena([In] object obj0, [In] int obj1) => ((string) obj0)[obj1];

    internal static int PWXuwPgzJbhCmghcDgW([In] object obj0) => ((string) obj0).Length;

    internal static bool Bq7nn4geLIQVWwqyfXj() => UserCertificateExtensions.R4palEgICbCqhGhlPXk == null;

    internal static UserCertificateExtensions rRDND6gnJ2lUkFGCnkZ() => UserCertificateExtensions.R4palEgICbCqhGhlPXk;
  }
}

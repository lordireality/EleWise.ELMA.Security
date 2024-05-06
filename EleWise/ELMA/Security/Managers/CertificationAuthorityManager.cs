// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.CertificationAuthorityManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using CERTADMINLib;
using CERTCLIENTLib;
using CERTENROLLLib;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CSharp.RuntimeBinder;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EleWise.ELMA.Security.Managers
{
  /// <summary>Менеджер работы с центром сертификации</summary>
  public class CertificationAuthorityManager
  {
    public const int CV_OUT_BASE64 = 1;
    public const int CV_OUT_BINARY = 2;
    public const int CV_OUT_HEX = 4;
    public const int CV_OUT_HEXASCII = 5;
    public const int PROPTYPE_LONG = 1;
    public const int PROPTYPE_DATE = 2;
    public const int PROPTYPE_BINARY = 3;
    public const int PROPTYPE_STRING = 4;
    public const int PROPTYPE_MASK = 255;
    internal static CertificationAuthorityManager cbhnrcXVNAQIiasETDc;

    public static string MakeRequest(string strDn, int providerType)
    {
      int num1 = 13;
      // ISSUE: variable of a compiler-generated type
      IX509CertificateRequestPkcs10 instance1;
      while (true)
      {
        int num2 = num1;
        // ISSUE: variable of a compiler-generated type
        CX500DistinguishedName distinguishedName;
        // ISSUE: variable of a compiler-generated type
        CObjectId pVal1;
        // ISSUE: variable of a compiler-generated type
        CX509PrivateKey pPrivateKey;
        // ISSUE: variable of a compiler-generated type
        CX509ExtensionKeyUsage instance2;
        // ISSUE: variable of a compiler-generated type
        CX509ExtensionEnhancedKeyUsage pVal2;
        // ISSUE: variable of a compiler-generated type
        CObjectIds pValue;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              pVal2 = (CX509ExtensionEnhancedKeyUsage) CertificationAuthorityManager.eIWfrTXc2ZLRegV9CJo(CertificationAuthorityManager.GYFVeZX47SMu3pZj9oy(new Guid((string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(1780597820 ^ 1780576892))));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 == 0 ? 15 : 15;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated method
              instance2.InitializeEncode(CERTENROLLLib.X509KeyUsageFlags.XCN_CERT_DIGITAL_SIGNATURE_KEY_USAGE | CERTENROLLLib.X509KeyUsageFlags.XCN_CERT_NON_REPUDIATION_KEY_USAGE | CERTENROLLLib.X509KeyUsageFlags.XCN_CERT_KEY_ENCIPHERMENT_KEY_USAGE | CERTENROLLLib.X509KeyUsageFlags.XCN_CERT_DATA_ENCIPHERMENT_KEY_USAGE);
              num2 = 4;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated method
              instance1.X509Extensions.Add((CX509Extension) instance2);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec != 0 ? 10 : 14;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated method
              pValue.Add(pVal1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b != 0 ? 1 : 2;
              continue;
            case 6:
              instance1.Subject = distinguishedName;
              num2 = 16;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated method
              pVal1.InitializeFromName(CERTENROLL_OBJECTID.XCN_OID_PKIX_KP_CLIENT_AUTH);
              num2 = 19;
              continue;
            case 8:
              pPrivateKey.KeySpec = X509KeySpec.XCN_AT_SIGNATURE;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 == 0 ? 0 : 0;
              continue;
            case 9:
              // ISSUE: reference to a compiler-generated method
              instance1.X509Extensions.Add((CX509Extension) pVal2);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 == 0 ? 6 : 17;
              continue;
            case 10:
              pPrivateKey.ProviderType = (X509ProviderType) providerType;
              num2 = 8;
              continue;
            case 11:
              // ISSUE: reference to a compiler-generated method
              distinguishedName.Encode(strDn);
              num2 = 6;
              continue;
            case 12:
              goto label_7;
            case 13:
              instance1 = (IX509CertificateRequestPkcs10) Activator.CreateInstance(CertificationAuthorityManager.GYFVeZX47SMu3pZj9oy(new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1848373724 >> 1 ^ 924142634))));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 == 0 ? 4 : 12;
              continue;
            case 14:
              goto label_21;
            case 15:
              // ISSUE: reference to a compiler-generated method
              pVal2.InitializeEncode(pValue);
              num2 = 9;
              continue;
            case 16:
              pVal1 = (CObjectId) CertificationAuthorityManager.eIWfrTXc2ZLRegV9CJo(CertificationAuthorityManager.GYFVeZX47SMu3pZj9oy(new Guid((string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(978908330 << 6 ^ -1774346456))));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c == 0 ? 4 : 7;
              continue;
            case 17:
              instance2 = (CX509ExtensionKeyUsage) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-347045778 ^ -347064606))));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 == 0 ? 3 : 3;
              continue;
            case 18:
              goto label_9;
            case 19:
              pValue = (CObjectIds) CertificationAuthorityManager.eIWfrTXc2ZLRegV9CJo(CertificationAuthorityManager.GYFVeZX47SMu3pZj9oy(new Guid((string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(-1536327508 ^ -1536346792))));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af == 0 ? 4 : 5;
              continue;
            default:
              // ISSUE: reference to a compiler-generated method
              instance1.InitializeFromPrivateKey(X509CertificateEnrollmentContext.ContextUser, pPrivateKey, (string) null);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 == 0 ? 1 : 0;
              continue;
          }
        }
label_3:
        distinguishedName = (CX500DistinguishedName) CertificationAuthorityManager.eIWfrTXc2ZLRegV9CJo(CertificationAuthorityManager.GYFVeZX47SMu3pZj9oy(new Guid((string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(-1743015995 ^ -1743054183))));
        num1 = 11;
        continue;
label_7:
        pPrivateKey = (CX509PrivateKey) CertificationAuthorityManager.eIWfrTXc2ZLRegV9CJo(Marshal.GetTypeFromCLSID(new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-817081027 ^ 243500131 ^ -1043372978))));
        num1 = 10;
        continue;
label_21:
        CertificationAuthorityManager.Q9xCLcXQTCqcVr4PMg2((object) instance1);
        num1 = 18;
      }
label_9:
      // ISSUE: variable of a compiler-generated type
      CX509Enrollment instance3 = (CX509Enrollment) Activator.CreateInstance(CertificationAuthorityManager.GYFVeZX47SMu3pZj9oy(new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751467293 ^ -1751512005))));
      // ISSUE: reference to a compiler-generated method
      instance3.InitializeFromRequest((IX509CertificateRequest) instance1);
      // ISSUE: reference to a compiler-generated method
      return instance3.CreateRequest();
    }

    /// <summary>Устанавливаем сертификат.</summary>
    /// <param name="certString"></param>
    public static void InstallResponse(string certString)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            // ISSUE: variable of a compiler-generated type
            CX509Enrollment cx509Enrollment = (CX509Enrollment) CertificationAuthorityManager.eIWfrTXc2ZLRegV9CJo(Marshal.GetTypeFromCLSID(new Guid((string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(-1212789817 - 1827404527 ^ 1254811136))));
            // ISSUE: reference to a compiler-generated method
            cx509Enrollment.Initialize(X509CertificateEnrollmentContext.ContextUser);
            // ISSUE: reference to a compiler-generated method
            cx509Enrollment.InstallResponse(InstallResponseRestrictionFlags.AllowUntrustedCertificate | InstallResponseRestrictionFlags.AllowUntrustedRoot, certString, EncodingType.XCN_CRYPT_STRING_BASE64, (string) null);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Получить корневой сертификат с центра сертификации</summary>
    /// <param name="address"></param>
    /// <returns></returns>
    public static X509Certificate2 GetRootCertificate(string address)
    {
      int num = 1;
      string caCertificate;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated method
            caCertificate = ((ICertRequest2) CertificationAuthorityManager.eIWfrTXc2ZLRegV9CJo(CertificationAuthorityManager.GYFVeZX47SMu3pZj9oy(new Guid((string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(1095474805 ^ 155418997 ^ 1208526884))))).GetCACertificate(0, address, 0);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return new X509Certificate2((byte[]) CertificationAuthorityManager.W6RI98X5GqvITypYpJG(CertificationAuthorityManager.ycHhEdX8rfNs0G9w9u8(), (object) caCertificate));
    }

    /// <summary>Получение и установка сертификата центра.</summary>
    /// <param name="address"></param>
    public static void InstallRootCert(string address)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            X509Store x509Store = new X509Store((string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(-1958138283 - -279956781 ^ -1678226190), StoreLocation.CurrentUser);
            x509Store.Open(OpenFlags.ReadWrite | OpenFlags.OpenExistingOnly);
            CertificationAuthorityManager.KFgB94XE8J0NMZCMoXg((object) x509Store, (object) (X509Certificate2) CertificationAuthorityManager.jawjLRXdpHdH7KFcvJM((object) address));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Отправка запроса и получение сертификата</summary>
    /// <param name="address"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    public static string SubmitRequest(string address, string request)
    {
      // ISSUE: variable of a compiler-generated type
      CCertRequest ccertRequest = (CCertRequest) CertificationAuthorityManager.eIWfrTXc2ZLRegV9CJo(Marshal.GetTypeFromCLSID(new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-550634672 ^ -550679436))));
      // ISSUE: reference to a compiler-generated method
      if (ccertRequest.Submit(257, request, (string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(1690209562 ^ 116876444 ^ 1648975610), address) != 3)
        throw new CryptographicException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1940240517 ^ 974551502 ^ 1236498721));
      // ISSUE: reference to a compiler-generated method
      return ccertRequest.GetCertificate(1);
    }

    /// <summary>Проверяет валидность сертификата по серийному номеру</summary>
    /// <param name="address">CompName\CAName</param>
    /// <param name="serial"></param>
    /// <returns></returns>
    public static bool CheckValid(string address, string serial)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (string.IsNullOrEmpty(serial))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return false;
label_5:
      // ISSUE: reference to a compiler-generated method
      return ((ICertAdmin2) CertificationAuthorityManager.eIWfrTXc2ZLRegV9CJo(CertificationAuthorityManager.GYFVeZX47SMu3pZj9oy(new Guid((string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(-906676699 ^ -906654017))))).IsValidCertificate(address, serial) == 3;
    }

    protected static void SetCertProp(
      CertificateInfo cert,
      string propName,
      IEnumCERTVIEWCOLUMN objCol)
    {
      switch (1)
      {
        case 1:
          try
          {
            uint num1 = CertificationAuthorityManager.NTAEAfXGPhW1LMLcSFZ((object) propName);
            int num2 = 95;
            while (true)
            {
              int num3;
              switch (num2)
              {
                case 1:
                  goto label_272;
                case 2:
                case 30:
                  CertificateInfo certificateInfo1 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__3 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (string)), CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager))));
                  }
                  // ISSUE: reference to a compiler-generated field
                  Func<CallSite, object, string> target1 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__3.Target;
                  // ISSUE: reference to a compiler-generated field
                  CallSite<Func<CallSite, object, string>> p3 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__3;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__2 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__2 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-389167216 ^ -389186360), (IEnumerable<Type>) null, typeof (CertificationAuthorityManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                    {
                      (CSharpArgumentInfo) CertificationAuthorityManager.usl8MjXh95fvMSN1eXl(CSharpArgumentInfoFlags.None, (object) null)
                    }));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  object obj1 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__2.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__2, objCol.GetValue(4));
                  string str1 = target1((CallSite) p3, obj1);
                  certificateInfo1.RequestDispMessage = str1;
                  num2 = 20;
                  continue;
                case 3:
                  if (num1 != 1214152085U)
                  {
                    num2 = 130;
                    continue;
                  }
                  goto default;
                case 4:
                  if (num1 != 1492200390U)
                  {
                    num2 = 17;
                    continue;
                  }
                  goto case 129;
                case 5:
                  goto label_261;
                case 6:
                  goto label_255;
                case 7:
                  goto label_251;
                case 8:
                  if (num1 != 3551955008U)
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 == 0 ? 93 : 29;
                    continue;
                  }
                  goto case 126;
                case 9:
                  goto label_242;
                case 10:
                  goto label_231;
                case 11:
                  if (num1 <= 617902505U)
                  {
                    num2 = 19;
                    continue;
                  }
                  goto case 124;
                case 12:
                case 128:
                  CertificateInfo certificateInfo2 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__17 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__17 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder) CertificationAuthorityManager.YYRvZyX1DSbG4kCflJ3(CSharpBinderFlags.None, typeof (string), typeof (CertificationAuthorityManager)));
                  }
                  // ISSUE: reference to a compiler-generated field
                  Func<CallSite, object, string> target2 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__17.Target;
                  // ISSUE: reference to a compiler-generated field
                  CallSite<Func<CallSite, object, string>> p17 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__17;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__16 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__16 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1880054609 ^ -1880088585), (IEnumerable<Type>) null, typeof (CertificationAuthorityManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                    {
                      (CSharpArgumentInfo) CertificationAuthorityManager.usl8MjXh95fvMSN1eXl(CSharpArgumentInfoFlags.None, (object) null)
                    }));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  object obj2 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__16.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__16, objCol.GetValue(4));
                  string str2 = target2((CallSite) p17, obj2);
                  CertificationAuthorityManager.FgjaiXXqPFExuW3HhxF((object) certificateInfo2, (object) str2);
                  num2 = 29;
                  continue;
                case 13:
                  goto label_214;
                case 14:
                  if (num1 != 282874604U)
                  {
                    num2 = 110;
                    continue;
                  }
                  goto case 48;
                case 15:
                  goto label_208;
                case 16:
                  CertificateInfo certificateInfo3 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__33 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__33 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder) CertificationAuthorityManager.YYRvZyX1DSbG4kCflJ3(CSharpBinderFlags.None, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (string)), CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager))));
                  }
                  // ISSUE: reference to a compiler-generated field
                  Func<CallSite, object, string> target3 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__33.Target;
                  // ISSUE: reference to a compiler-generated field
                  CallSite<Func<CallSite, object, string>> p33 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__33;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__32 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__32 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(~-1362653258 ^ 1362676497), (IEnumerable<Type>) null, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                    {
                      (CSharpArgumentInfo) CertificationAuthorityManager.usl8MjXh95fvMSN1eXl(CSharpArgumentInfoFlags.None, (object) null)
                    }));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  object obj3 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__32.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__32, objCol.GetValue(4));
                  string str3 = target3((CallSite) p33, obj3);
                  CertificationAuthorityManager.zOHLG6XnnfVoBelUMlX((object) certificateInfo3, (object) str3);
                  num2 = 5;
                  continue;
                case 17:
                  goto label_197;
                case 18:
                  if (!(propName == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29763048 >> 5 ^ -952874)))
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc == 0 ? 134 : 101;
                    continue;
                  }
                  goto case 83;
                case 19:
                  if (num1 <= 282874604U)
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 == 0 ? 8 : 49;
                    continue;
                  }
                  goto case 78;
                case 20:
                  goto label_186;
                case 21:
                  if (!CertificationAuthorityManager.VOj4l2XXNKe26hCcsOx((object) propName, CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(-819366706 ^ -819343808)))
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba != 0 ? 25 : 34;
                    continue;
                  }
                  goto case 52;
                case 22:
                  goto label_172;
                case 23:
                  if (CertificationAuthorityManager.VOj4l2XXNKe26hCcsOx((object) propName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1457346863 ^ -1457381833)))
                  {
                    num2 = 120;
                    continue;
                  }
                  goto label_227;
                case 24:
                  goto label_168;
                case 25:
                  goto label_164;
                case 26:
                  goto label_155;
                case 27:
                case 88:
                  if (num1 != 3353632950U)
                  {
                    num2 = 8;
                    continue;
                  }
                  goto case 105;
                case 28:
                case 81:
                  CertificateInfo certificateInfo4 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__19 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__19 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder) CertificationAuthorityManager.YYRvZyX1DSbG4kCflJ3(CSharpBinderFlags.None, typeof (string), CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager))));
                  }
                  // ISSUE: reference to a compiler-generated field
                  Func<CallSite, object, string> target4 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__19.Target;
                  // ISSUE: reference to a compiler-generated field
                  CallSite<Func<CallSite, object, string>> p19 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__19;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__18 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__18 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(447286529 ^ 447329881), (IEnumerable<Type>) null, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                    {
                      (CSharpArgumentInfo) CertificationAuthorityManager.usl8MjXh95fvMSN1eXl(CSharpArgumentInfoFlags.None, (object) null)
                    }));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  object obj4 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__18.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__18, objCol.GetValue(4));
                  string str4 = target4((CallSite) p19, obj4);
                  CertificationAuthorityManager.ilioGBXgx8bedLmwrZ3((object) certificateInfo4, (object) str4);
                  num2 = 59;
                  continue;
                case 29:
                  goto label_148;
                case 31:
                  goto label_143;
                case 32:
                  if (propName == (string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(--534238571 ^ 534212369))
                  {
                    num2 = 96;
                    continue;
                  }
                  goto label_132;
                case 33:
                  goto label_137;
                case 34:
                  goto label_136;
                case 35:
                  goto label_134;
                case 36:
                  if (CertificationAuthorityManager.VOj4l2XXNKe26hCcsOx((object) propName, CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(1124861159 ^ 1124908387)))
                  {
                    num2 = 123;
                    continue;
                  }
                  goto label_65;
                case 37:
                  goto label_133;
                case 38:
                case 67:
                  CertificateInfo certificateInfo5 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__21 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__21 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder) CertificationAuthorityManager.YYRvZyX1DSbG4kCflJ3(CSharpBinderFlags.None, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (string)), CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager))));
                  }
                  // ISSUE: reference to a compiler-generated field
                  Func<CallSite, object, string> target5 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__21.Target;
                  // ISSUE: reference to a compiler-generated field
                  CallSite<Func<CallSite, object, string>> p21 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__21;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__20 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__20 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-206147790 ^ -206121878), (IEnumerable<Type>) null, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                    {
                      (CSharpArgumentInfo) CertificationAuthorityManager.usl8MjXh95fvMSN1eXl(CSharpArgumentInfoFlags.None, (object) null)
                    }));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  object obj5 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__20.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__20, objCol.GetValue(4));
                  string str5 = target5((CallSite) p21, obj5);
                  certificateInfo5.DomainComponent = str5;
                  num2 = 61;
                  continue;
                case 39:
                  CertificateInfo certificateInfo6 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__13 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__13 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder) CertificationAuthorityManager.YYRvZyX1DSbG4kCflJ3(CSharpBinderFlags.None, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (string)), typeof (CertificationAuthorityManager)));
                  }
                  // ISSUE: reference to a compiler-generated field
                  Func<CallSite, object, string> target6 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__13.Target;
                  // ISSUE: reference to a compiler-generated field
                  CallSite<Func<CallSite, object, string>> p13 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__13;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__12 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__12 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(1534797734 ^ 1534827774), (IEnumerable<Type>) null, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                    {
                      (CSharpArgumentInfo) CertificationAuthorityManager.usl8MjXh95fvMSN1eXl(CSharpArgumentInfoFlags.None, (object) null)
                    }));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  object obj6 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__12.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__12, objCol.GetValue(4));
                  string str6 = target6((CallSite) p13, obj6);
                  CertificationAuthorityManager.ghGZKOXFihk5YXDyaga((object) certificateInfo6, (object) str6);
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 8 : 22;
                  continue;
                case 40:
                  goto label_129;
                case 41:
                  if (num1 != 3165258191U)
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff != 0 ? 54 : 8;
                    continue;
                  }
                  goto case 114;
                case 42:
                case 96:
                  CertificateInfo certificateInfo7 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__25 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__25 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder) CertificationAuthorityManager.YYRvZyX1DSbG4kCflJ3(CSharpBinderFlags.None, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (string)), CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager))));
                  }
                  // ISSUE: reference to a compiler-generated field
                  Func<CallSite, object, string> target7 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__25.Target;
                  // ISSUE: reference to a compiler-generated field
                  CallSite<Func<CallSite, object, string>> p25 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__25;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__24 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__24 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, z2jc63fLkugS1X8Q9N.tE1kD1vbB(784628100 ^ 784646876), (IEnumerable<Type>) null, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                    {
                      (CSharpArgumentInfo) CertificationAuthorityManager.usl8MjXh95fvMSN1eXl(CSharpArgumentInfoFlags.None, (object) null)
                    }));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  object obj7 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__24.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__24, objCol.GetValue(4));
                  string str7 = target7((CallSite) p25, obj7);
                  certificateInfo7.Initials = str7;
                  num3 = 31;
                  break;
                case 43:
                  if (num1 != 2565758308U)
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 != 0 ? 6 : 53;
                    continue;
                  }
                  goto case 131;
                case 44:
                case 63:
                  if (num1 != 1335638524U)
                  {
                    num2 = 113;
                    continue;
                  }
                  goto case 65;
                case 45:
                  goto label_126;
                case 46:
                  if (!CertificationAuthorityManager.VOj4l2XXNKe26hCcsOx((object) propName, CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(--306199571 ^ 306218271)))
                  {
                    num2 = 121;
                    continue;
                  }
                  goto case 75;
                case 47:
                  goto label_122;
                case 48:
                  if (CertificationAuthorityManager.VOj4l2XXNKe26hCcsOx((object) propName, CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(1100789287 - 1555711667 ^ -454896322)))
                  {
                    num2 = 38;
                    continue;
                  }
                  goto label_67;
                case 49:
                  if (num1 != 83164785U)
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a == 0 ? 11 : 14;
                    continue;
                  }
                  goto case 97;
                case 50:
                  goto label_121;
                case 51:
                  goto label_118;
                case 52:
                  CertificateInfo certificateInfo8 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__27 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__27 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder) CertificationAuthorityManager.YYRvZyX1DSbG4kCflJ3(CSharpBinderFlags.None, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (string)), CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager))));
                  }
                  // ISSUE: reference to a compiler-generated field
                  Func<CallSite, object, string> target8 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__27.Target;
                  // ISSUE: reference to a compiler-generated field
                  CallSite<Func<CallSite, object, string>> p27 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__27;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__26 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__26 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(1095474805 ^ 155418997 ^ 1208525912), (IEnumerable<Type>) null, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                    {
                      (CSharpArgumentInfo) CertificationAuthorityManager.usl8MjXh95fvMSN1eXl(CSharpArgumentInfoFlags.None, (object) null)
                    }));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  object obj8 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__26.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__26, objCol.GetValue(4));
                  string str8 = target8((CallSite) p27, obj8);
                  certificateInfo8.OrgUnit = str8;
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 46 : 50;
                  continue;
                case 53:
                  if (num1 != 3142863279U)
                  {
                    num2 = 26;
                    continue;
                  }
                  goto case 117;
                case 54:
                  if (num1 != 3188789611U)
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c == 0 ? 49 : 104;
                    continue;
                  }
                  goto case 46;
                case 55:
                case 86:
                  CertificateInfo certificateInfo9 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__7 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__7 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder) CertificationAuthorityManager.YYRvZyX1DSbG4kCflJ3(CSharpBinderFlags.None, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (string)), CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager))));
                  }
                  // ISSUE: reference to a compiler-generated field
                  Func<CallSite, object, string> target9 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__7.Target;
                  // ISSUE: reference to a compiler-generated field
                  CallSite<Func<CallSite, object, string>> p7 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__7;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__6 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__6 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(-296013529 ^ -295990657), (IEnumerable<Type>) null, typeof (CertificationAuthorityManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                    {
                      (CSharpArgumentInfo) CertificationAuthorityManager.usl8MjXh95fvMSN1eXl(CSharpArgumentInfoFlags.None, (object) null)
                    }));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  object obj9 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__6.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__6, objCol.GetValue(4));
                  string str9 = target9((CallSite) p7, obj9);
                  CertificationAuthorityManager.JBRbCUXpV0iwpANJisx((object) certificateInfo9, (object) str9);
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0 ? 7 : 1;
                  continue;
                case 56:
                  goto label_113;
                case 57:
                case 109:
                  CertificateInfo certificateInfo10 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__23 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__23 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder) CertificationAuthorityManager.YYRvZyX1DSbG4kCflJ3(CSharpBinderFlags.None, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (string)), typeof (CertificationAuthorityManager)));
                  }
                  // ISSUE: reference to a compiler-generated field
                  Func<CallSite, object, string> target10 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__23.Target;
                  // ISSUE: reference to a compiler-generated field
                  CallSite<Func<CallSite, object, string>> p23 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__23;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__22 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__22 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, z2jc63fLkugS1X8Q9N.tE1kD1vbB(789532496 ^ 1575286436 ^ 1928004268), (IEnumerable<Type>) null, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                    {
                      (CSharpArgumentInfo) CertificationAuthorityManager.usl8MjXh95fvMSN1eXl(CSharpArgumentInfoFlags.None, (object) null)
                    }));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  object obj10 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__22.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__22, objCol.GetValue(4));
                  string str10 = target10((CallSite) p23, obj10);
                  CertificationAuthorityManager.L2KvmVXJjpZoS6ZpUYu((object) certificateInfo10, (object) str10);
                  num2 = 6;
                  continue;
                case 58:
                  goto label_110;
                case 59:
                  goto label_109;
                case 60:
                  goto label_106;
                case 61:
                  goto label_105;
                case 62:
                  goto label_101;
                case 64:
                  if (CertificationAuthorityManager.VOj4l2XXNKe26hCcsOx((object) propName, CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(--1207559533 ^ 1207524355)))
                  {
                    num2 = 80;
                    continue;
                  }
                  goto label_149;
                case 65:
                  if (!CertificationAuthorityManager.VOj4l2XXNKe26hCcsOx((object) propName, CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(1124861159 ^ 1124908635)))
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 != 0 ? 56 : 100;
                    continue;
                  }
                  goto case 106;
                case 66:
                  goto label_100;
                case 68:
                  goto label_97;
                case 69:
                  goto label_96;
                case 70:
                  if (num1 > 2069686773U)
                  {
                    num2 = 108;
                    continue;
                  }
                  goto case 107;
                case 71:
                  goto label_95;
                case 72:
                case 87:
                  CertificateInfo certificateInfo11 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__9 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__9 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder) CertificationAuthorityManager.YYRvZyX1DSbG4kCflJ3(CSharpBinderFlags.None, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (string)), CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager))));
                  }
                  // ISSUE: reference to a compiler-generated field
                  Func<CallSite, object, string> target11 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__9.Target;
                  // ISSUE: reference to a compiler-generated field
                  CallSite<Func<CallSite, object, string>> p9 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__9;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__8 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__8 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(44166125 ^ 44126389), (IEnumerable<Type>) null, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                    {
                      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
                    }));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  object obj11 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__8.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__8, objCol.GetValue(4));
                  string str11 = target11((CallSite) p9, obj11);
                  CertificationAuthorityManager.V7txK1XObMSNFxk5xNq((object) certificateInfo11, (object) str11);
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 != 0 ? 115 : 61;
                  continue;
                case 73:
                  goto label_94;
                case 74:
                  goto label_92;
                case 75:
                  CertificateInfo certificateInfo12 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__1 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, int>>.Create((CallSiteBinder) CertificationAuthorityManager.YYRvZyX1DSbG4kCflJ3(CSharpBinderFlags.ConvertExplicit, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (int)), CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager))));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  int num4 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__1.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__1, objCol.GetValue(1));
                  CertificationAuthorityManager.K02TPqXM46rNsHU3awc((object) certificateInfo12, num4);
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 112 : 26;
                  continue;
                case 76:
                  goto label_91;
                case 77:
                case 120:
                  CertificateInfo certificateInfo13 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__0 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (int)), CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager))));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  int num5 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__0.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__0, objCol.GetValue(1));
                  certificateInfo13.RequestId = num5;
                  num2 = 51;
                  continue;
                case 78:
                  if (num1 != 328359283U)
                  {
                    num2 = 85;
                    continue;
                  }
                  goto case 21;
                case 79:
                  if (propName == (string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(908197830 ^ 908150186))
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff != 0 ? 109 : 42;
                    continue;
                  }
                  goto label_245;
                case 80:
                case 119:
                  CertificateInfo certificateInfo14 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__4 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__4 = CallSite<Func<CallSite, object, DateTime>>.Create((CallSiteBinder) CertificationAuthorityManager.YYRvZyX1DSbG4kCflJ3(CSharpBinderFlags.ConvertExplicit, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (DateTime)), CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager))));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  DateTime dateTime1 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__4.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__4, objCol.GetValue(2));
                  certificateInfo14.NotBefore = dateTime1;
                  num2 = 66;
                  continue;
                case 82:
                  if (CertificationAuthorityManager.VOj4l2XXNKe26hCcsOx((object) propName, CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(~248518394 ^ -248557517)))
                  {
                    num2 = 30;
                    continue;
                  }
                  goto label_135;
                case 83:
                  CertificateInfo certificateInfo15 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__35 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__35 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder) CertificationAuthorityManager.YYRvZyX1DSbG4kCflJ3(CSharpBinderFlags.None, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (string)), typeof (CertificationAuthorityManager)));
                  }
                  // ISSUE: reference to a compiler-generated field
                  Func<CallSite, object, string> target12 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__35.Target;
                  // ISSUE: reference to a compiler-generated field
                  CallSite<Func<CallSite, object, string>> p35 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__35;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__34 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__34 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(-1440374117 ^ -1440409149), (IEnumerable<Type>) null, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                    {
                      (CSharpArgumentInfo) CertificationAuthorityManager.usl8MjXh95fvMSN1eXl(CSharpArgumentInfoFlags.None, (object) null)
                    }));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  object obj12 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__34.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__34, objCol.GetValue(4));
                  string str12 = target12((CallSite) p35, obj12);
                  certificateInfo15.RawPublicKey = str12;
                  num2 = 76;
                  continue;
                case 84:
                  if (num1 != 824548944U)
                  {
                    num2 = 3;
                    continue;
                  }
                  goto case 36;
                case 85:
                  if (num1 != 426894090U)
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0 ? 132 : 45;
                    continue;
                  }
                  goto case 118;
                case 89:
                  if (num1 <= 3142863279U)
                  {
                    num2 = 70;
                    continue;
                  }
                  goto case 103;
                case 90:
                  CertificateInfo certificateInfo16 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__29 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__29 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder) CertificationAuthorityManager.YYRvZyX1DSbG4kCflJ3(CSharpBinderFlags.None, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (string)), CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager))));
                  }
                  // ISSUE: reference to a compiler-generated field
                  Func<CallSite, object, string> target13 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__29.Target;
                  // ISSUE: reference to a compiler-generated field
                  CallSite<Func<CallSite, object, string>> p29 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__29;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__28 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__28 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(44166125 ^ 44126389), (IEnumerable<Type>) null, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                    {
                      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
                    }));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  object obj13 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__28.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__28, objCol.GetValue(4));
                  string str13 = target13((CallSite) p29, obj13);
                  CertificationAuthorityManager.ACXxqoXIB5bwc9SoaB0((object) certificateInfo16, (object) str13);
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0 ? 25 : 9;
                  continue;
                case 91:
                  if (!CertificationAuthorityManager.VOj4l2XXNKe26hCcsOx((object) propName, CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(581409346 ^ 581378948)))
                  {
                    num3 = 47;
                    break;
                  }
                  goto case 125;
                case 92:
                case 108:
                  if (num1 != 2285031632U)
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 != 0 ? 43 : 24;
                    continue;
                  }
                  goto case 32;
                case 93:
                  if (num1 == 3565254712U)
                  {
                    num2 = 23;
                    continue;
                  }
                  goto label_269;
                case 94:
                  goto label_90;
                case 95:
                  if (num1 <= 1492200390U)
                  {
                    num2 = 11;
                    continue;
                  }
                  goto case 89;
                case 97:
                  if (CertificationAuthorityManager.VOj4l2XXNKe26hCcsOx((object) propName, CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(-1540570615 - 1746246777 ^ 1008181160)))
                  {
                    num3 = 28;
                    break;
                  }
                  goto label_104;
                case 98:
                  CertificateInfo certificateInfo17 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__39 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__39 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder) CertificationAuthorityManager.YYRvZyX1DSbG4kCflJ3(CSharpBinderFlags.None, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (string)), CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager))));
                  }
                  // ISSUE: reference to a compiler-generated field
                  Func<CallSite, object, string> target14 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__39.Target;
                  // ISSUE: reference to a compiler-generated field
                  CallSite<Func<CallSite, object, string>> p39 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__39;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__38 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__38 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(617710536 ^ 617691280), (IEnumerable<Type>) null, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                    {
                      (CSharpArgumentInfo) CertificationAuthorityManager.usl8MjXh95fvMSN1eXl(CSharpArgumentInfoFlags.None, (object) null)
                    }));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  object obj14 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__38.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__38, objCol.GetValue(4));
                  string str14 = target14((CallSite) p39, obj14);
                  CertificationAuthorityManager.ogsVApX22gs2hcTI5D8((object) certificateInfo17, (object) str14);
                  num2 = 13;
                  continue;
                case 99:
                  CertificateInfo certificateInfo18 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__37 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__37 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (string), CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager))));
                  }
                  // ISSUE: reference to a compiler-generated field
                  Func<CallSite, object, string> target15 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__37.Target;
                  // ISSUE: reference to a compiler-generated field
                  CallSite<Func<CallSite, object, string>> p37 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__37;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__36 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__36 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(213026252 ^ 213008020), (IEnumerable<Type>) null, typeof (CertificationAuthorityManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                    {
                      (CSharpArgumentInfo) CertificationAuthorityManager.usl8MjXh95fvMSN1eXl(CSharpArgumentInfoFlags.None, (object) null)
                    }));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  object obj15 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__36.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__36, objCol.GetValue(4));
                  string str15 = target15((CallSite) p37, obj15);
                  CertificationAuthorityManager.u9E2JBXLXg3UWvjOepF((object) certificateInfo18, (object) str15);
                  num2 = (int) sbyte.MaxValue;
                  continue;
                case 100:
                  goto label_89;
                case 101:
                  goto label_88;
                case 102:
                  goto label_87;
                case 103:
                  if (num1 > 3277942151U)
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 == 0 ? 31 : 88;
                    continue;
                  }
                  goto case 41;
                case 104:
                  if (num1 != 3277942151U)
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b == 0 ? 102 : 50;
                    continue;
                  }
                  goto case 79;
                case 105:
                  if (!CertificationAuthorityManager.VOj4l2XXNKe26hCcsOx((object) propName, CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(--1207559533 ^ 1207524953)))
                  {
                    num3 = 37;
                    break;
                  }
                  goto case 98;
                case 106:
                  CertificateInfo certificateInfo19 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__31 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__31 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (string)), CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager))));
                  }
                  // ISSUE: reference to a compiler-generated field
                  Func<CallSite, object, string> target16 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__31.Target;
                  // ISSUE: reference to a compiler-generated field
                  CallSite<Func<CallSite, object, string>> p31 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__31;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__30 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__30 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1124861159 ^ 1124908991), (IEnumerable<Type>) null, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                    {
                      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
                    }));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  object obj16 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__30.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__30, objCol.GetValue(4));
                  string str16 = target16((CallSite) p31, obj16);
                  CertificationAuthorityManager.fg2kEZXeLoZjtx3RKg0((object) certificateInfo19, (object) str16);
                  num3 = 56;
                  break;
                case 107:
                  if (num1 != 1782056091U)
                  {
                    num2 = 116;
                    continue;
                  }
                  goto case 18;
                case 110:
                  goto label_80;
                case 111:
                  CertificateInfo certificateInfo20 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__15 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__15 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (string)), CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager))));
                  }
                  // ISSUE: reference to a compiler-generated field
                  Func<CallSite, object, string> target17 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__15.Target;
                  // ISSUE: reference to a compiler-generated field
                  CallSite<Func<CallSite, object, string>> p15 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__15;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__14 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__14 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(-1788054269 >> 5 ^ -55846672), (IEnumerable<Type>) null, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                    {
                      (CSharpArgumentInfo) CertificationAuthorityManager.usl8MjXh95fvMSN1eXl(CSharpArgumentInfoFlags.None, (object) null)
                    }));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  object obj17 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__14.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__14, objCol.GetValue(4));
                  string str17 = target17((CallSite) p15, obj17);
                  CertificationAuthorityManager.CgvCLdXvOuVQgdFSerF((object) certificateInfo20, (object) str17);
                  num2 = 135;
                  continue;
                case 112:
                  goto label_79;
                case 113:
                  if (num1 != 1407976548U)
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 == 0 ? 4 : 4;
                    continue;
                  }
                  goto case 91;
                case 114:
                  if (!CertificationAuthorityManager.VOj4l2XXNKe26hCcsOx((object) propName, CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(1801131332 >> 4 ^ 112528304)))
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e == 0 ? 62 : 28;
                    continue;
                  }
                  goto case 16;
                case 115:
                  goto label_78;
                case 116:
                  if (num1 != 2069686773U)
                  {
                    num3 = 40;
                    break;
                  }
                  goto case 64;
                case 117:
                  if (CertificationAuthorityManager.VOj4l2XXNKe26hCcsOx((object) propName, CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(1124861159 ^ 1124908361)))
                  {
                    num2 = 87;
                    continue;
                  }
                  goto label_93;
                case 118:
                  if (!CertificationAuthorityManager.VOj4l2XXNKe26hCcsOx((object) propName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(631805505 ^ 631778529)))
                  {
                    num3 = 133;
                    break;
                  }
                  goto case 90;
                case 121:
                  goto label_77;
                case 122:
                  if (num1 != 634921714U)
                  {
                    num2 = 84;
                    continue;
                  }
                  goto case 82;
                case 123:
                case 136:
                  CertificateInfo certificateInfo21 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__5 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__5 = CallSite<Func<CallSite, object, DateTime>>.Create((CallSiteBinder) CertificationAuthorityManager.YYRvZyX1DSbG4kCflJ3(CSharpBinderFlags.ConvertExplicit, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (DateTime)), typeof (CertificationAuthorityManager)));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  DateTime dateTime2 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__5.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__5, objCol.GetValue(2));
                  CertificationAuthorityManager.v3BUNYXBdNj0IsqdidA((object) certificateInfo21, dateTime2);
                  num3 = 10;
                  break;
                case 124:
                  if (num1 > 1214152085U)
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 == 0 ? 63 : 37;
                    continue;
                  }
                  goto case 122;
                case 125:
                  CertificateInfo certificateInfo22 = cert;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__11 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__11 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (string)), CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager))));
                  }
                  // ISSUE: reference to a compiler-generated field
                  Func<CallSite, object, string> target18 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__11.Target;
                  // ISSUE: reference to a compiler-generated field
                  CallSite<Func<CallSite, object, string>> p11 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__11;
                  // ISSUE: reference to a compiler-generated field
                  if (CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__10 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: type reference
                    CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__10 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(-340788466 ^ -340836266), (IEnumerable<Type>) null, CertificationAuthorityManager.Lgcml2X9ChjFYMVv1fQ(__typeref (CertificationAuthorityManager)), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                    {
                      (CSharpArgumentInfo) CertificationAuthorityManager.usl8MjXh95fvMSN1eXl(CSharpArgumentInfoFlags.None, (object) null)
                    }));
                  }
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  object obj18 = CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__10.Target((CallSite) CertificationAuthorityManager.\u003C\u003Eo__18.\u003C\u003Ep__10, objCol.GetValue(4));
                  string str18 = target18((CallSite) p11, obj18);
                  CertificationAuthorityManager.oQJiycXTUo4HvDpbSO9((object) certificateInfo22, (object) str18);
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 4 : 15;
                  continue;
                case 126:
                  if (!CertificationAuthorityManager.VOj4l2XXNKe26hCcsOx((object) propName, CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(-1807813747 ^ -1807857275)))
                  {
                    num2 = 73;
                    continue;
                  }
                  goto case 111;
                case (int) sbyte.MaxValue:
                  goto label_76;
                case 129:
                  if (!(propName == (string) CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(-1331070742 ^ -1331051576)))
                  {
                    num2 = 24;
                    continue;
                  }
                  goto case 99;
                case 130:
                  goto label_66;
                case 131:
                  if (!CertificationAuthorityManager.VOj4l2XXNKe26hCcsOx((object) propName, CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(1245871191 - 2145700088 ^ -899872077)))
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a == 0 ? 45 : 3;
                    continue;
                  }
                  goto case 39;
                case 132:
                  if (num1 != 617902505U)
                  {
                    num3 = 35;
                    break;
                  }
                  goto case 137;
                case 133:
                  goto label_64;
                case 134:
                  goto label_61;
                case 135:
                  goto label_60;
                case 137:
                  if (CertificationAuthorityManager.VOj4l2XXNKe26hCcsOx((object) propName, CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(554338340 ^ 554316302)))
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff != 0 ? 128 : 0;
                    continue;
                  }
                  goto label_138;
                default:
                  if (CertificationAuthorityManager.VOj4l2XXNKe26hCcsOx((object) propName, CertificationAuthorityManager.s5Rv0IXPixRiPFWtMwk(-1958138283 - -279956781 ^ -1678228966)))
                  {
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 55 : 29;
                    continue;
                  }
                  goto label_123;
              }
              num2 = num3;
            }
label_272:
            break;
label_106:
            break;
label_105:
            break;
label_101:
            break;
label_97:
            break;
label_96:
            break;
label_95:
            break;
label_94:
            break;
label_92:
            break;
label_91:
            break;
label_90:
            break;
label_109:
            break;
label_89:
            break;
label_87:
            break;
label_80:
            break;
label_79:
            break;
label_78:
            break;
label_77:
            break;
label_76:
            break;
label_66:
            break;
label_64:
            break;
label_61:
            break;
label_60:
            break;
label_88:
            break;
label_110:
            break;
label_100:
            break;
label_118:
            break;
label_261:
            break;
label_255:
            break;
label_251:
            break;
label_242:
            break;
label_231:
            break;
label_214:
            break;
label_113:
            break;
label_197:
            break;
label_186:
            break;
label_172:
            break;
label_168:
            break;
label_164:
            break;
label_208:
            break;
label_148:
            break;
label_143:
            break;
label_137:
            break;
label_136:
            break;
label_134:
            break;
label_133:
            break;
label_155:
            break;
label_129:
            break;
label_126:
            break;
label_122:
            break;
label_121:
            break;
label_135:
            break;
label_227:
            break;
label_149:
            break;
label_245:
            break;
label_67:
            break;
label_104:
            break;
label_123:
            break;
label_65:
            break;
label_132:
            break;
label_138:
            break;
label_93:
            break;
label_269:
            break;
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0)
              num = 0;
            switch (num)
            {
              case 0:
                return;
              default:
                return;
            }
          }
      }
    }

    /// <summary>Получает сертификаты с сервера Certificate Authority</summary>
    /// <returns></returns>
    public static IEnumerable<CertificateInfo> GetCertificates() => (IEnumerable<CertificateInfo>) new CertificationAuthorityManager.\u003CGetCertificates\u003Ed__19(-2);

    /// <summary>Получает сертификат с сервера Certificate Authority</summary>
    /// <param name="thumbprint">Отпечаток сертификата</param>
    /// <returns></returns>
    public static CertificateInfo GetCertificateByThumbprint(string thumbprint)
    {
      int num1 = 2;
      string thumbprint1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            thumbprint1 = thumbprint;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0 ? 0 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 == 0 ? 0 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return CertificationAuthorityManager.GetCertificates().FirstOrDefault<CertificateInfo>((Func<CertificateInfo, bool>) (c =>
      {
        int num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              if (c.CertificateHash == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b != 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return CertificationAuthorityManager.\u003C\u003Ec__DisplayClass20_0.VeG3DUwsO5GbAd0c1BtL((object) ((string) CertificationAuthorityManager.\u003C\u003Ec__DisplayClass20_0.DqFec0wsB8PlZJWhvIO5(CertificationAuthorityManager.\u003C\u003Ec__DisplayClass20_0.SBEYFEwsM5qCDNdsSumi((object) c), CertificationAuthorityManager.\u003C\u003Ec__DisplayClass20_0.T9vSUlwshcxUwhfnnoKy(789532496 ^ 1575286436 ^ 1928063006), (object) "")).ToUpper(), CertificationAuthorityManager.\u003C\u003Ec__DisplayClass20_0.MFhZXZwspSItGEndlSZN((object) thumbprint1));
label_3:
        return false;
      }));
    }

    public CertificationAuthorityManager()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type GYFVeZX47SMu3pZj9oy([In] Guid obj0) => Marshal.GetTypeFromCLSID(obj0);

    internal static object eIWfrTXc2ZLRegV9CJo([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static object s5Rv0IXPixRiPFWtMwk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void Q9xCLcXQTCqcVr4PMg2([In] object obj0) => ((IX509CertificateRequestPkcs10) obj0).Encode();

    internal static bool jggxQvXle6vYe04oumZ() => CertificationAuthorityManager.cbhnrcXVNAQIiasETDc == null;

    internal static CertificationAuthorityManager amStMtXfO66K1jSmCYB() => CertificationAuthorityManager.cbhnrcXVNAQIiasETDc;

    internal static object ycHhEdX8rfNs0G9w9u8() => (object) Encoding.UTF8;

    internal static object W6RI98X5GqvITypYpJG([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetBytes((string) obj1);

    internal static object jawjLRXdpHdH7KFcvJM([In] object obj0) => (object) CertificationAuthorityManager.GetRootCertificate((string) obj0);

    internal static void KFgB94XE8J0NMZCMoXg([In] object obj0, [In] object obj1) => ((X509Store) obj0).Add((X509Certificate2) obj1);

    internal static uint NTAEAfXGPhW1LMLcSFZ([In] object obj0) => \u003CPrivateImplementationDetails\u003E.ComputeStringHash((string) obj0);

    internal static bool VOj4l2XXNKe26hCcsOx([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static Type Lgcml2X9ChjFYMVv1fQ([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object YYRvZyX1DSbG4kCflJ3([In] CSharpBinderFlags obj0, [In] Type obj1, [In] Type obj2) => (object) Binder.Convert(obj0, obj1, obj2);

    internal static void K02TPqXM46rNsHU3awc([In] object obj0, int value) => ((CertificateInfo) obj0).RequestDisp = value;

    internal static object usl8MjXh95fvMSN1eXl([In] CSharpArgumentInfoFlags obj0, [In] object obj1) => (object) CSharpArgumentInfo.Create(obj0, (string) obj1);

    internal static void v3BUNYXBdNj0IsqdidA([In] object obj0, DateTime value) => ((CertificateInfo) obj0).NotAfter = value;

    internal static void JBRbCUXpV0iwpANJisx([In] object obj0, [In] object obj1) => ((CertificateInfo) obj0).GivenName = (string) obj1;

    internal static void V7txK1XObMSNFxk5xNq([In] object obj0, [In] object obj1) => ((CertificateInfo) obj0).CommonName = (string) obj1;

    internal static void oQJiycXTUo4HvDpbSO9([In] object obj0, [In] object obj1) => ((CertificateInfo) obj0).DistinguishedName = (string) obj1;

    internal static void ghGZKOXFihk5YXDyaga([In] object obj0, [In] object obj1) => ((CertificateInfo) obj0).SerialNumber = (string) obj1;

    internal static void CgvCLdXvOuVQgdFSerF([In] object obj0, [In] object obj1) => ((CertificateInfo) obj0).CertificateHash = (string) obj1;

    internal static void FgjaiXXqPFExuW3HhxF([In] object obj0, [In] object obj1) => ((CertificateInfo) obj0).Title = (string) obj1;

    internal static void ilioGBXgx8bedLmwrZ3([In] object obj0, [In] object obj1) => ((CertificateInfo) obj0).Country = (string) obj1;

    internal static void L2KvmVXJjpZoS6ZpUYu([In] object obj0, [In] object obj1) => ((CertificateInfo) obj0).EMail = (string) obj1;

    internal static void ACXxqoXIB5bwc9SoaB0([In] object obj0, [In] object obj1) => ((CertificateInfo) obj0).Organization = (string) obj1;

    internal static void fg2kEZXeLoZjtx3RKg0([In] object obj0, [In] object obj1) => ((CertificateInfo) obj0).PublicKeyAlgorithm = (string) obj1;

    internal static void zOHLG6XnnfVoBelUMlX([In] object obj0, [In] object obj1) => ((CertificateInfo) obj0).PublicKeyLength = (string) obj1;

    internal static void u9E2JBXLXg3UWvjOepF([In] object obj0, [In] object obj1) => ((CertificateInfo) obj0).SurName = (string) obj1;

    internal static void ogsVApX22gs2hcTI5D8([In] object obj0, [In] object obj1) => ((CertificateInfo) obj0).UnstructuredName = (string) obj1;
  }
}

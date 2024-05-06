// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.UserCertificateManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Audit;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Events;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Models.Crypto;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace EleWise.ELMA.Security.Managers
{
  /// <summary>Менеджер сертификатов пользователя</summary>
  [DeveloperApi(DeveloperApiType.Manager)]
  public class UserCertificateManager : EntityManager<IUserCertificate, long>
  {
    private static UserCertificateManager nYBPkC9MQme2HZUISHh;

    public SecuritySettingsModule Module => Locator.GetServiceNotNull<SecuritySettingsModule>();

    public AuthCryptoProviderService AuthCryptoProviderService
    {
      get => this.\u003CAuthCryptoProviderService\u003Ek__BackingField;
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
              this.\u003CAuthCryptoProviderService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab == 0 ? 0 : 0;
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

    public IEnumerable<ICertificateCryptoAction> CryptoActions { get; set; }

    /// <summary>Обработчик события логина для модуля аудита</summary>
    public ILoginDigitalSignatureEventHandler DigitalSignatureEventHandler
    {
      get => this.\u003CDigitalSignatureEventHandler\u003Ek__BackingField;
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
              this.\u003CDigitalSignatureEventHandler\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed != 0 ? 0 : 0;
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

    [NotNull]
    public static UserCertificateManager Instance => Locator.GetServiceNotNull<UserCertificateManager>();

    /// <summary>Проверка подписи</summary>
    /// <param name="signature"></param>
    /// <param name="signedText"></param>
    /// <exception cref="T:System.Security.Cryptography.CryptographicException"></exception>
    [Obsolete("Устарел. Используйте EleWise.ELMA.Security.Services.AuthCryptoProviderService.CheckSignature")]
    public X509Certificate2 CheckSignature(string signature, string signedText)
    {
      IVerifyResult verifyResult = this.AuthCryptoProviderService.CheckSignature(signedText, signature, false);
      UserCertificateManager.ewEXDe9psTxRflshgbj((object) verifyResult);
      return new X509Certificate2(((ISigner) UserCertificateManager.qD048h9OwFMZQB9yUvt((object) verifyResult)).RawData);
    }

    /// <summary>Войти по сертификату</summary>
    /// <param name="signature"></param>
    /// <param name="signedText"></param>
    [Transaction]
    public virtual void SignInByCertificate(string signature, string signedText)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            UserCertificateManager.qimkk89FcP8ninddchF((object) this, (object) signature, (object) signedText, UserCertificateManager.PmVCQu9Te2cUjEtbMqW((object) this.AuthCryptoProviderService));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Войти по сертификату</summary>
    /// <param name="signature"></param>
    /// <param name="signedText"></param>
    /// <param name="providerUid"></param>
    [Transaction]
    public virtual void SignInByCertificate(string signature, string signedText, Guid providerUid)
    {
      int num1 = 27;
      string message;
      while (true)
      {
        int num2 = num1;
        // ISSUE: variable of a compiler-generated type
        UserCertificateManager.\u003C\u003Ec__DisplayClass18_0 cDisplayClass180;
        IUserCertificate userCertificate;
        bool? isDefault;
        LoginAuditContainer auditContainer;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_41;
            case 1:
              this.AuditCheckDigitalSignature(auditContainer);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 == 0 ? 9 : 7;
              continue;
            case 2:
              isDefault = userCertificate.IsDefault;
              num2 = 12;
              continue;
            case 3:
              // ISSUE: type reference
              ParameterExpression parameterExpression = (ParameterExpression) UserCertificateManager.xS5NlR9nRTyENs5tcWN(UserCertificateManager.hdw0C69IhuvYTwbyYYm(__typeref (IUserCertificate)), UserCertificateManager.ck2e9l9e0rKcrtUJcBP(781628008 - 11982093 ^ 769614611));
              // ISSUE: method reference
              // ISSUE: type reference
              // ISSUE: field reference
              // ISSUE: method reference
              // ISSUE: method reference
              // ISSUE: method reference
              // ISSUE: field reference
              // ISSUE: type reference
              // ISSUE: method reference
              userCertificate = this.Find(Expression.Lambda<Func<IUserCertificate, bool>>((Expression) UserCertificateManager.HG7jFP1UGp7PJjxix52(UserCertificateManager.oGBqHp1uxiX2IYol3Gm((object) Expression.Property((Expression) parameterExpression, (MethodInfo) UserCertificateManager.V3YrmV9L6QpmTRFr71E(__methodref (IUserCertificate.get_Thumbprint))), UserCertificateManager.OWJjmW9zPOkjiQ9ZQtG(UserCertificateManager.OWJjmW9zPOkjiQ9ZQtG(UserCertificateManager.GZg3Eg9H1T4KmdFFevA(UserCertificateManager.awalpO92M5o2t2BI7n2((object) cDisplayClass180, UserCertificateManager.hdw0C69IhuvYTwbyYYm(__typeref (UserCertificateManager.\u003C\u003Ec__DisplayClass18_0))), (object) FieldInfo.GetFieldFromHandle(__fieldref (UserCertificateManager.\u003C\u003Ec__DisplayClass18_0.result))), (object) (MethodInfo) UserCertificateManager.V3YrmV9L6QpmTRFr71E(__methodref (IVerifyResult.get_Signer))), (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ISigner.get_Thumbprint)))), UserCertificateManager.be8yqv1KSg31U7Iob7K((object) Expression.Property((Expression) parameterExpression, (MethodInfo) UserCertificateManager.V3YrmV9L6QpmTRFr71E(__methodref (IUserCertificate.get_CryptoActionGuid))), UserCertificateManager.PvEme31b800rseytGMr(UserCertificateManager.GZg3Eg9H1T4KmdFFevA((object) null, UserCertificateManager.sGwuu11wuVs3VUuMnbt(__fieldref (AuthCryptoAction.UID))), UserCertificateManager.hdw0C69IhuvYTwbyYYm(__typeref (Guid?))), false, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)))), parameterExpression), new FetchOptions(0, 1)).FirstOrDefault<IUserCertificate>();
              num2 = 24;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              if (!UserCertificateManager.dD6Q8p9JBNAT4VMXfbA((object) cDisplayClass180.result))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 5 : 0;
                continue;
              }
              goto case 3;
            case 5:
              this.AuditCheckDigitalSignature(auditContainer);
              num2 = 23;
              continue;
            case 6:
              isDefault = userCertificate.IsDefault;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b == 0 ? 12 : 17;
              continue;
            case 7:
            case 25:
            case 30:
              if (!(message != string.Empty))
              {
                Locator.GetServiceNotNull<FormsAuthenticationService>().SignIn((EleWise.ELMA.Security.IUser) UserCertificateManager.kCkXcy1txvMgH3DvBXY((object) userCertificate), (string) UserCertificateManager.EAEFPP1xX9TKcZtLR4C(UserCertificateManager.ck2e9l9e0rKcrtUJcBP(552500104 ^ 552518688), (object) 2, UserCertificateManager.pKcag71atoyJ8uM0Gpw((object) userCertificate)));
                num2 = 28;
                continue;
              }
              goto label_25;
            case 8:
              message = (string) UserCertificateManager.zi7ulO1ovywTa9UiVEN((object) message, UserCertificateManager.r10IRB1RnQFf4Q6SLOg(UserCertificateManager.ck2e9l9e0rKcrtUJcBP(-94240706 ^ -94191884)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 != 0 ? 16 : 5;
              continue;
            case 9:
              goto label_7;
            case 10:
              object obj = UserCertificateManager.EP6VF01DXjvvuBpRcPL((object) auditContainer);
              ((IVerifyResult) obj).Error = ((IVerifyResult) obj).Error + message;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b != 0 ? 1 : 1;
              continue;
            case 11:
              this.AuditCheckDigitalSignature(auditContainer);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 12 : 15;
              continue;
            case 12:
              if (isDefault.Value)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af != 0 ? 6 : 7;
                continue;
              }
              goto case 14;
            case 13:
              auditContainer.User = (EleWise.ELMA.Security.IUser) UserCertificateManager.kCkXcy1txvMgH3DvBXY((object) userCertificate);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 != 0 ? 14 : 19;
              continue;
            case 14:
              message = (string) UserCertificateManager.zi7ulO1ovywTa9UiVEN((object) message, UserCertificateManager.r10IRB1RnQFf4Q6SLOg(UserCertificateManager.ck2e9l9e0rKcrtUJcBP(1820204600 ^ 1820238202)));
              num2 = 30;
              continue;
            case 15:
              goto label_11;
            case 16:
              if (UserCertificateManager.qZtkuG1kLUu9yRPQ4Ii((object) this.Module.Settings))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0 ? 6 : 5;
                continue;
              }
              goto case 7;
            case 17:
              if (isDefault.HasValue)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0 ? 2 : 2;
                continue;
              }
              goto case 14;
            case 18:
              // ISSUE: reference to a compiler-generated field
              if (UserCertificateManager.qD048h9OwFMZQB9yUvt((object) cDisplayClass180.result) != null)
              {
                num2 = 4;
                continue;
              }
              goto case 5;
            case 19:
              if (UserCertificateManager.QCoelg16m7bwSylyLGa(UserCertificateManager.nombNu1mgTSIwdTsQs1((object) this.AuthCryptoProviderService, UserCertificateManager.kCkXcy1txvMgH3DvBXY((object) userCertificate)), providerUid))
              {
                num2 = 8;
                continue;
              }
              goto case 16;
            case 20:
              UserCertificateManager.ph9tUf1iuE7ss6btHXY((object) userCertificate);
              num2 = 11;
              continue;
            case 21:
              LoginAuditContainer loginAuditContainer = new LoginAuditContainer();
              // ISSUE: reference to a compiler-generated field
              UserCertificateManager.cbIF2M9quBf1DVwiDxw((object) loginAuditContainer, (object) cDisplayClass180.result);
              UserCertificateManager.R4MCum9gBNveC15ZvWX((object) loginAuditContainer, (object) null);
              auditContainer = loginAuditContainer;
              num2 = 18;
              continue;
            case 22:
              if (userCertificate == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 == 0 ? 8 : 29;
                continue;
              }
              goto case 13;
            case 23:
              // ISSUE: reference to a compiler-generated field
              UserCertificateManager.ewEXDe9psTxRflshgbj((object) cDisplayClass180.result);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 != 0 ? 0 : 0;
              continue;
            case 24:
              message = "";
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 17 : 22;
              continue;
            case 26:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass180.result = (IVerifyResult) UserCertificateManager.oXCiLN9vScOcNsPPCWy((object) this.AuthCryptoProviderService, (object) signedText, (object) signature, false, providerUid);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af != 0 ? 18 : 21;
              continue;
            case 27:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass180 = new UserCertificateManager.\u003C\u003Ec__DisplayClass18_0();
              num2 = 26;
              continue;
            case 28:
              userCertificate.LastTouchDate = new DateTime?(UserCertificateManager.LCTLCE1ChXr4SEy9jrC());
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 20 : 8;
              continue;
            case 29:
              message = (string) UserCertificateManager.zi7ulO1ovywTa9UiVEN((object) message, UserCertificateManager.r10IRB1RnQFf4Q6SLOg(UserCertificateManager.ck2e9l9e0rKcrtUJcBP(1212037053 ^ -1727812018 ^ -784521283)));
              num2 = 25;
              continue;
            default:
              goto label_30;
          }
        }
label_25:
        num1 = 10;
      }
label_41:
      return;
label_11:
      return;
label_30:
      return;
label_7:
      throw new AuthenticationException(message);
    }

    /// <summary>Зарегистрировать сертификат входа для пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="subject"> </param>
    /// <param name="thumbprint">Отпечаток сертификата</param>
    [Transaction]
    public virtual IUserCertificate RegisterCertificateByThumbprint(
      string subject,
      string thumbprint,
      EleWise.ELMA.Security.Models.IUser user = null)
    {
      return (IUserCertificate) UserCertificateManager.kSjhNq13YnCKCbwLRVl((object) this, (object) subject, (object) thumbprint, (object) user, AuthCryptoAction.UID);
    }

    /// <summary>Зарегистрировать сертификат для пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="subject"> </param>
    /// <param name="thumbprint">Отпечаток сертификата</param>
    /// <param name="cryptoActionUid">Uid крипто действия</param>
    [Transaction]
    public virtual IUserCertificate RegisterCertificateByThumbprint(
      string subject,
      string thumbprint,
      EleWise.ELMA.Security.Models.IUser user,
      Guid cryptoActionUid)
    {
      return this.RegisterCertificateByThumbprint(subject, thumbprint, user, new Guid?(cryptoActionUid), new Guid?(), false);
    }

    /// <summary>Зарегистрировать сертификат для пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="subject"> </param>
    /// <param name="thumbprint">Отпечаток сертификата</param>
    /// <param name="cryptoActionUid">Uid крипто действия</param>
    /// <param name="isDefault"></param>
    [Transaction]
    public virtual IUserCertificate RegisterCertificateByThumbprint(
      string subject,
      string thumbprint,
      EleWise.ELMA.Security.Models.IUser user,
      Guid cryptoActionUid,
      bool isDefault)
    {
      return this.RegisterCertificateByThumbprint(subject, thumbprint, user, new Guid?(cryptoActionUid), new Guid?(), isDefault);
    }

    /// <summary>Зарегистрировать сертификат для пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="subject"> </param>
    /// <param name="thumbprint">Отпечаток сертификата</param>
    /// <param name="cryptoActionUid">Uid крипто действия</param>
    /// <param name="cryptoProviderUid">Uid крипто провайдера</param>
    /// <param name="isDefault"></param>
    [Transaction]
    public virtual IUserCertificate RegisterCertificateByThumbprint(
      string subject,
      string thumbprint,
      EleWise.ELMA.Security.Models.IUser user,
      Guid? cryptoActionUid,
      Guid? cryptoProviderUid,
      bool isDefault)
    {
      EleWise.ELMA.Security.Models.IUser currentUser = (EleWise.ELMA.Security.Models.IUser) Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
      if (user == null)
        user = currentUser;
      ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
      if (currentUser != user && !serviceNotNull.HasPermission((EleWise.ELMA.Security.IUser) currentUser, PermissionProvider.UserManagmentPermission))
        throw new SecurityException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1608980123 ^ -1609009047)));
      if (string.IsNullOrEmpty(thumbprint))
        throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(908197830 ^ 908148860)));
      IUserCertificate userCertificate1 = this.Find((Expression<Func<IUserCertificate, bool>>) (userCertificate => userCertificate.Thumbprint == thumbprint && userCertificate.CryptoActionGuid == cryptoActionUid)).FirstOrDefault<IUserCertificate>();
      if (userCertificate1 != null)
      {
        if (userCertificate1.User == user)
          throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(841533798 << 6 ^ -1976375684)));
        throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-979995965 << 4 ^ 1499982954)));
      }
      ICertificateCryptoAction certificateCryptoAction = this.CryptoActions.FirstOrDefault<ICertificateCryptoAction>((Func<ICertificateCryptoAction, bool>) (a =>
      {
        int num = 2;
        Guid? nullable;
        Guid guid;
        while (true)
        {
          switch (num)
          {
            case 1:
              nullable = cryptoActionUid;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 3 : 0;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated method
              guid = UserCertificateManager.\u003C\u003Ec__DisplayClass22_0.oos97dw7DrIVJvHxjpoG((object) a);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 1 : 1;
              continue;
            case 3:
              if (!nullable.HasValue)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d == 0 ? 0 : 0;
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
        return UserCertificateManager.\u003C\u003Ec__DisplayClass22_0.MS7PNNw7aPLsXc4mCBKj(guid, nullable.GetValueOrDefault());
      }));
      if (certificateCryptoAction == null)
        throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1691384762 ^ -1691401074)));
      string msg = "";
      if (!certificateCryptoAction.CanRegisterCertificate(out msg))
        throw new Exception(msg);
      IUserCertificate userCertificate2 = InterfaceActivator.Create<IUserCertificate>();
      userCertificate2.Name = subject;
      userCertificate2.User = user;
      userCertificate2.Thumbprint = thumbprint;
      userCertificate2.CryptoActionGuid = new Guid?(certificateCryptoAction.ActionUid);
      userCertificate2.CryptoProviderGuid = cryptoProviderUid.HasValue ? cryptoProviderUid : (certificateCryptoAction.CryptoService != null ? new Guid?(certificateCryptoAction.CryptoService.GetUserProviderUid(user)) : cryptoProviderUid);
      userCertificate2.IsDefault = new bool?(isDefault);
      userCertificate2.Save();
      return userCertificate2;
    }

    /// <summary>
    /// Зарегистрировать сертификат входа для пользователя по сигнатуре
    /// </summary>
    /// <param name="signature"></param>
    /// <param name="signedText"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    [Transaction]
    public virtual IUserCertificate RegisterCertificateBySignature(
      string signature,
      string signedText,
      EleWise.ELMA.Security.Models.IUser user = null)
    {
      return (IUserCertificate) UserCertificateManager.qsq0kF1jWmw1hrOya01((object) this, (object) signature, (object) signedText, (object) user, AuthCryptoAction.UID, false);
    }

    /// <summary>
    /// Зарегистрировать сертификат входа для пользователя по сигнатуре
    /// </summary>
    /// <param name="signature"></param>
    /// <param name="signedText"></param>
    /// <param name="user"></param>
    /// <param name="isDefault"></param>
    /// <returns></returns>
    [Transaction]
    public virtual IUserCertificate RegisterCertificateBySignature(
      string signature,
      string signedText,
      EleWise.ELMA.Security.Models.IUser user,
      bool isDefault)
    {
      return (IUserCertificate) UserCertificateManager.qsq0kF1jWmw1hrOya01((object) this, (object) signature, (object) signedText, (object) user, AuthCryptoAction.UID, isDefault);
    }

    /// <summary>
    /// Зарегистрировать сертификат для пользователя по сигнатуре
    /// </summary>
    /// <param name="signature"></param>
    /// <param name="signedText"></param>
    /// <param name="user"></param>
    /// <param name="cryptoActionUid"></param>
    /// <param name="isDefault"></param>
    /// <returns></returns>
    [Transaction]
    public virtual IUserCertificate RegisterCertificateBySignature(
      string signature,
      string signedText,
      EleWise.ELMA.Security.Models.IUser user,
      Guid cryptoActionUid,
      bool isDefault)
    {
      int num = 1;
      IVerifyResult verifyResult;
      ICryptoProviderServiceBase providerServiceBase;
      Guid cryptoActionUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 == 0 ? 0 : 0;
            continue;
          case 2:
            verifyResult.ThrowIfNotVerified();
            num = 5;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated method
            ICertificateCryptoAction certificateCryptoAction = this.CryptoActions.FirstOrDefault<ICertificateCryptoAction>((Func<ICertificateCryptoAction, bool>) (a => UserCertificateManager.\u003C\u003Ec__DisplayClass25_0.VfIDjuw7j9H6dodnvTGG((object) a) == cryptoActionUid1));
            if (certificateCryptoAction != null)
            {
              providerServiceBase = (ICryptoProviderServiceBase) UserCertificateManager.Ioe9W41NRkZhlqZvinP((object) certificateCryptoAction);
              num = 4;
              continue;
            }
            goto label_8;
          case 4:
            verifyResult = (IVerifyResult) UserCertificateManager.t3DNIT1ZesK6A4untPN((object) providerServiceBase, (object) signedText, (object) signature, false, UserCertificateManager.YjXmyg10UwgdiLMmxyc((object) providerServiceBase, (object) user));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 == 0 ? 2 : 1;
            continue;
          case 5:
            goto label_4;
          default:
            cryptoActionUid1 = cryptoActionUid;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 == 0 ? 0 : 3;
            continue;
        }
      }
label_4:
      return (IUserCertificate) UserCertificateManager.MTT4GG1s4g7xxfKo3tl((object) this, (object) ((ISigner) UserCertificateManager.qD048h9OwFMZQB9yUvt((object) verifyResult)).Name, UserCertificateManager.c3jwvr1AQXOl24IIVs0(UserCertificateManager.qD048h9OwFMZQB9yUvt((object) verifyResult)), (object) user, cryptoActionUid1, isDefault);
label_8:
      throw new Exception(EleWise.ELMA.SR.T((string) UserCertificateManager.ck2e9l9e0rKcrtUJcBP(-1527733619 - 442652394 ^ -1970369685)));
    }

    /// <summary>
    /// Отменить регистрацию сертификата для текущего пользователя
    /// </summary>
    [Transaction]
    public virtual void UnRegisterCertificate(long id, EleWise.ELMA.Security.Models.IUser user)
    {
      int num1 = 1;
      string msg;
      while (true)
      {
        EleWise.ELMA.Security.Models.IUser currentUser;
        ISecurityService serviceNotNull;
        IUserCertificate cert;
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0 ? 0 : 0;
            continue;
          case 2:
          case 5:
            serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
            num1 = 9;
            continue;
          case 3:
            UserCertificateManager.U0lrEB17hoQUqu1ratY((object) cert);
            num1 = 7;
            continue;
          case 4:
            if (!serviceNotNull.HasPermission((EleWise.ELMA.Security.IUser) currentUser, PermissionProvider.UserManagmentPermission))
            {
              num1 = 12;
              continue;
            }
            break;
          case 6:
            if (user != null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 != 0 ? 2 : 2;
              continue;
            }
            goto case 8;
          case 7:
            goto label_12;
          case 8:
            user = currentUser;
            num1 = 5;
            continue;
          case 9:
            if (currentUser != user)
            {
              num1 = 4;
              continue;
            }
            break;
          case 10:
            ICertificateCryptoAction certificateCryptoAction = this.CryptoActions.FirstOrDefault<ICertificateCryptoAction>((Func<ICertificateCryptoAction, bool>) (a =>
            {
              int num2 = 2;
              Guid guid;
              Guid? cryptoActionGuid;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    cryptoActionGuid = cert.CryptoActionGuid;
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    guid = UserCertificateManager.\u003C\u003Ec__DisplayClass26_0.nGZwcDw7Aj8jP38PMSd3((object) a);
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 1 : 0;
                    continue;
                  case 3:
                    goto label_2;
                  case 4:
                    goto label_3;
                  default:
                    if (cryptoActionGuid.HasValue)
                    {
                      num2 = 4;
                      continue;
                    }
                    goto label_2;
                }
              }
label_2:
              return false;
label_3:
              return guid == cryptoActionGuid.GetValueOrDefault();
            }));
            if (certificateCryptoAction != null)
            {
              msg = "";
              if (certificateCryptoAction.CanUnregisterCertificate(cert, out msg))
              {
                if (UserCertificateManager.kCkXcy1txvMgH3DvBXY((object) cert) == user)
                {
                  num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0 ? 3 : 1;
                  continue;
                }
                goto label_2;
              }
              else
              {
                num1 = 11;
                continue;
              }
            }
            else
              goto label_21;
          case 11:
            goto label_17;
          case 12:
            goto label_3;
          default:
            currentUser = (EleWise.ELMA.Security.Models.IUser) Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
            num1 = 6;
            continue;
        }
        cert = this.Load(id);
        num1 = 10;
      }
label_12:
      return;
label_3:
      throw new SecurityException((string) UserCertificateManager.r10IRB1RnQFf4Q6SLOg(UserCertificateManager.ck2e9l9e0rKcrtUJcBP(552500104 ^ 552528516)));
label_17:
      throw new Exception(msg);
label_2:
      return;
label_21:
      throw new Exception((string) UserCertificateManager.r10IRB1RnQFf4Q6SLOg((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788783669 - 1293477238 ^ 1212722845)));
    }

    [Transaction]
    public virtual void SetDefaultCertificate(long id, EleWise.ELMA.Security.Models.IUser user, bool @default)
    {
      int num = 7;
      EleWise.ELMA.Security.Models.IUser user1;
      ISecurityService serviceNotNull;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
            serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_12;
          case 3:
            IUserCertificate userCertificate = this.Load(id);
            userCertificate.IsDefault = new bool?(@default);
            UserCertificateManager.ph9tUf1iuE7ss6btHXY((object) userCertificate);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 0 : 9;
            continue;
          case 5:
            user = user1;
            num = 4;
            continue;
          case 6:
            if (user != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 0 : 1;
              continue;
            }
            goto case 5;
          case 7:
            user1 = (EleWise.ELMA.Security.Models.IUser) UserCertificateManager.OvTngb1WOCCU62tjjV9((object) Locator.GetServiceNotNull<IAuthenticationService>());
            num = 6;
            continue;
          case 8:
            if (UserCertificateManager.r1XH071r0RmEtl2fUeK((object) serviceNotNull, (object) user1, (object) PermissionProvider.UserManagmentPermission))
            {
              num = 3;
              continue;
            }
            goto label_12;
          case 9:
            goto label_11;
          default:
            if (user1 != user)
            {
              num = 8;
              continue;
            }
            goto case 3;
        }
      }
label_11:
      return;
label_12:
      throw new SecurityException((string) UserCertificateManager.r10IRB1RnQFf4Q6SLOg(UserCertificateManager.ck2e9l9e0rKcrtUJcBP(-1257514304 ^ -1257550900)));
    }

    /// <summary>Получить отпечаток серт-та для входа по умолчанию</summary>
    /// <param name="user">Пользователь</param>
    /// <returns></returns>
    public string GetDefaultCertificateThumbpint(EleWise.ELMA.Security.IUser user) => this.GetDefaultCertificateThumbpint(user, AuthCryptoAction.UID);

    /// <summary>
    /// Получить отпечаток серт-та по умолчанию для текущего пользователя
    /// </summary>
    /// <param name="cryptoActionUid">Крипто действие</param>
    /// <returns></returns>
    public string GetCurrentUserDefaultCertificateThumbpint(Guid cryptoActionUid)
    {
      int num = 1;
      EleWise.ELMA.Security.Models.IUser user;
      IUserCertificate defaultCertificate;
      while (true)
      {
        switch (num)
        {
          case 1:
            user = (EleWise.ELMA.Security.Models.IUser) UserCertificateManager.OvTngb1WOCCU62tjjV9((object) Locator.GetServiceNotNull<IAuthenticationService>());
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            goto label_3;
          case 4:
            if (defaultCertificate != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 == 0 ? 0 : 2;
              continue;
            }
            goto label_3;
          default:
            defaultCertificate = this.GetDefaultCertificate((EleWise.ELMA.Security.IUser) user, cryptoActionUid);
            num = 4;
            continue;
        }
      }
label_3:
      return string.Empty;
label_4:
      return (string) UserCertificateManager.pKcag71atoyJ8uM0Gpw((object) defaultCertificate);
    }

    /// <summary>Получить отпечаток серт-та по умолчанию</summary>
    /// <param name="user"></param>
    /// <param name="cryptoActionUid">Крипто действие</param>
    /// <returns></returns>
    public string GetDefaultCertificateThumbpint(EleWise.ELMA.Security.IUser user, Guid cryptoActionUid)
    {
      int num = 1;
      IUserCertificate defaultCertificate;
      while (true)
      {
        switch (num)
        {
          case 1:
            defaultCertificate = this.GetDefaultCertificate(user, cryptoActionUid);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            if (defaultCertificate == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 == 0 ? 2 : 2;
              continue;
            }
            goto label_5;
        }
      }
label_4:
      return string.Empty;
label_5:
      return (string) UserCertificateManager.pKcag71atoyJ8uM0Gpw((object) defaultCertificate);
    }

    /// <summary>Получить серт-т по умолчанию</summary>
    /// <param name="user"></param>
    /// <param name="cryptoActionUid"></param>
    /// <returns></returns>
    public IUserCertificate GetDefaultCertificate(EleWise.ELMA.Security.IUser user, Guid cryptoActionUid)
    {
      int num = 2;
      // ISSUE: variable of a compiler-generated type
      UserCertificateManager.\u003C\u003Ec__DisplayClass31_0 cDisplayClass310;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass310.user = user;
            num = 3;
            continue;
          case 2:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass310 = new UserCertificateManager.\u003C\u003Ec__DisplayClass31_0();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 == 0 ? 1 : 0;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass310.cryptoActionUid = cryptoActionUid;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      // ISSUE: type reference
      ParameterExpression parameterExpression = Expression.Parameter(UserCertificateManager.hdw0C69IhuvYTwbyYYm(__typeref (IUserCertificate)), (string) UserCertificateManager.ck2e9l9e0rKcrtUJcBP(1290337431 ^ 1290289887));
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: type reference
      return this.Find(Expression.Lambda<Func<IUserCertificate, bool>>((Expression) UserCertificateManager.HG7jFP1UGp7PJjxix52(UserCertificateManager.HG7jFP1UGp7PJjxix52((object) Expression.AndAlso((Expression) UserCertificateManager.oGBqHp1uxiX2IYol3Gm(UserCertificateManager.OWJjmW9zPOkjiQ9ZQtG((object) parameterExpression, (object) (MethodInfo) UserCertificateManager.V3YrmV9L6QpmTRFr71E(__methodref (IUserCertificate.get_User))), UserCertificateManager.GZg3Eg9H1T4KmdFFevA(UserCertificateManager.awalpO92M5o2t2BI7n2((object) cDisplayClass310, UserCertificateManager.hdw0C69IhuvYTwbyYYm(__typeref (UserCertificateManager.\u003C\u003Ec__DisplayClass31_0))), UserCertificateManager.sGwuu11wuVs3VUuMnbt(__fieldref (UserCertificateManager.\u003C\u003Ec__DisplayClass31_0.user)))), (Expression) UserCertificateManager.be8yqv1KSg31U7Iob7K(UserCertificateManager.OWJjmW9zPOkjiQ9ZQtG((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IUserCertificate.get_CryptoActionGuid))), UserCertificateManager.PvEme31b800rseytGMr((object) Expression.Field((Expression) UserCertificateManager.awalpO92M5o2t2BI7n2((object) cDisplayClass310, typeof (UserCertificateManager.\u003C\u003Ec__DisplayClass31_0)), FieldInfo.GetFieldFromHandle(__fieldref (UserCertificateManager.\u003C\u003Ec__DisplayClass31_0.cryptoActionUid))), UserCertificateManager.hdw0C69IhuvYTwbyYYm(__typeref (Guid?))), false, (object) (MethodInfo) UserCertificateManager.V3YrmV9L6QpmTRFr71E(__methodref (Guid.op_Equality)))), UserCertificateManager.OWJjmW9zPOkjiQ9ZQtG(UserCertificateManager.OWJjmW9zPOkjiQ9ZQtG((object) parameterExpression, (object) (MethodInfo) UserCertificateManager.V3YrmV9L6QpmTRFr71E(__methodref (IUserCertificate.get_IsDefault))), (object) (MethodInfo) UserCertificateManager.Ip5fwM1S3YVJ3rKg6hf(__methodref (bool?.get_HasValue), __typeref (bool?)))), UserCertificateManager.OWJjmW9zPOkjiQ9ZQtG(UserCertificateManager.OWJjmW9zPOkjiQ9ZQtG((object) parameterExpression, (object) (MethodInfo) UserCertificateManager.V3YrmV9L6QpmTRFr71E(__methodref (IUserCertificate.get_IsDefault))), (object) (MethodInfo) UserCertificateManager.Ip5fwM1S3YVJ3rKg6hf(__methodref (bool?.get_Value), __typeref (bool?)))), parameterExpression)).FirstOrDefault<IUserCertificate>();
    }

    /// <summary>Получить сертификат пользователя для входа</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public IUserCertificate GetCertificate(EleWise.ELMA.Security.IUser user) => this.GetCertificates(user, AuthCryptoAction.UID).FirstOrDefault<IUserCertificate>();

    /// <summary>Получить сертификаты пользователя</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public IEnumerable<IUserCertificate> GetCertificates(EleWise.ELMA.Security.IUser user) => (IEnumerable<IUserCertificate>) this.Find((Expression<Func<IUserCertificate, bool>>) (userCertificate => userCertificate.User == user));

    /// <summary>
    /// Получить сертификаты пользователя для определенного действия
    /// </summary>
    /// <param name="user"></param>
    /// <param name="cryptoActionUid"></param>
    /// <returns></returns>
    public IEnumerable<IUserCertificate> GetCertificates(
      EleWise.ELMA.Security.IUser user,
      Guid cryptoActionUid)
    {
      return (IEnumerable<IUserCertificate>) this.Find((Expression<Func<IUserCertificate, bool>>) (userCertificate => userCertificate.User == user && userCertificate.CryptoActionGuid == (Guid?) cryptoActionUid));
    }

    /// <summary>Получить сертификаты пользователя по отпечатку</summary>
    /// <param name="user"></param>
    /// <param name="thumbprint"></param>
    /// <returns></returns>
    public IUserCertificate GetCertificateByThumbprint(
      EleWise.ELMA.Security.IUser user,
      string thumbprint)
    {
      return this.GetCertificateByThumbprintAndAction(user, thumbprint, AuthCryptoAction.UID);
    }

    /// <summary>
    /// Получить сертификат пользователя по отпечатку и действию
    /// </summary>
    /// <param name="user"></param>
    /// <param name="thumbprint"></param>
    /// <param name="cryptoActionUid"></param>
    /// <returns></returns>
    public IUserCertificate GetCertificateByThumbprintAndAction(
      EleWise.ELMA.Security.IUser user,
      string thumbprint,
      Guid cryptoActionUid)
    {
      int num = 4;
      // ISSUE: variable of a compiler-generated type
      UserCertificateManager.\u003C\u003Ec__DisplayClass36_0 cDisplayClass360;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass360.cryptoActionUid = cryptoActionUid;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass360.thumbprint = thumbprint;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 == 0 ? 1 : 0;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass360.user = user;
            num = 2;
            continue;
          case 4:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass360 = new UserCertificateManager.\u003C\u003Ec__DisplayClass36_0();
            num = 3;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      // ISSUE: type reference
      ParameterExpression parameterExpression = (ParameterExpression) UserCertificateManager.xS5NlR9nRTyENs5tcWN(UserCertificateManager.hdw0C69IhuvYTwbyYYm(__typeref (IUserCertificate)), UserCertificateManager.ck2e9l9e0rKcrtUJcBP(-817081027 ^ 243500131 ^ -1043370218));
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: type reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: method reference
      return this.Find(Expression.Lambda<Func<IUserCertificate, bool>>((Expression) Expression.AndAlso((Expression) UserCertificateManager.HG7jFP1UGp7PJjxix52(UserCertificateManager.oGBqHp1uxiX2IYol3Gm(UserCertificateManager.OWJjmW9zPOkjiQ9ZQtG((object) parameterExpression, (object) (MethodInfo) UserCertificateManager.V3YrmV9L6QpmTRFr71E(__methodref (IUserCertificate.get_User))), UserCertificateManager.GZg3Eg9H1T4KmdFFevA((object) Expression.Constant((object) cDisplayClass360, UserCertificateManager.hdw0C69IhuvYTwbyYYm(__typeref (UserCertificateManager.\u003C\u003Ec__DisplayClass36_0))), (object) FieldInfo.GetFieldFromHandle(__fieldref (UserCertificateManager.\u003C\u003Ec__DisplayClass36_0.user)))), UserCertificateManager.oGBqHp1uxiX2IYol3Gm((object) Expression.Property((Expression) parameterExpression, (MethodInfo) UserCertificateManager.V3YrmV9L6QpmTRFr71E(__methodref (IUserCertificate.get_Thumbprint))), UserCertificateManager.GZg3Eg9H1T4KmdFFevA(UserCertificateManager.awalpO92M5o2t2BI7n2((object) cDisplayClass360, UserCertificateManager.hdw0C69IhuvYTwbyYYm(__typeref (UserCertificateManager.\u003C\u003Ec__DisplayClass36_0))), UserCertificateManager.sGwuu11wuVs3VUuMnbt(__fieldref (UserCertificateManager.\u003C\u003Ec__DisplayClass36_0.thumbprint))))), (Expression) Expression.Equal((Expression) UserCertificateManager.OWJjmW9zPOkjiQ9ZQtG((object) parameterExpression, (object) (MethodInfo) UserCertificateManager.V3YrmV9L6QpmTRFr71E(__methodref (IUserCertificate.get_CryptoActionGuid))), (Expression) UserCertificateManager.PvEme31b800rseytGMr(UserCertificateManager.GZg3Eg9H1T4KmdFFevA(UserCertificateManager.awalpO92M5o2t2BI7n2((object) cDisplayClass360, typeof (UserCertificateManager.\u003C\u003Ec__DisplayClass36_0)), UserCertificateManager.sGwuu11wuVs3VUuMnbt(__fieldref (UserCertificateManager.\u003C\u003Ec__DisplayClass36_0.cryptoActionUid))), typeof (Guid?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)))), parameterExpression)).FirstOrDefault<IUserCertificate>();
    }

    /// <summary>
    /// Получить сертификаты пользователя по отпечатку и действию
    /// </summary>
    /// <param name="user"></param>
    /// <param name="thumbprint"></param>
    /// <param name="cryptoActionUid"></param>
    /// <returns></returns>
    public IEnumerable<IUserCertificate> GetCertificatesByThumbprintAndAction(
      EleWise.ELMA.Security.IUser user,
      string thumbprint,
      Guid cryptoActionUid)
    {
      return (IEnumerable<IUserCertificate>) this.Find((Expression<Func<IUserCertificate, bool>>) (userCertificate => userCertificate.User == user && userCertificate.Thumbprint == thumbprint && userCertificate.CryptoActionGuid == (Guid?) cryptoActionUid));
    }

    /// <summary>Получить количество сертификатов пользователя</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public long Count(EleWise.ELMA.Security.IUser user)
    {
      InstanceOf<IUserCertificateFilter> instanceOf = new InstanceOf<IUserCertificateFilter>();
      UserCertificateManager.d9DlVh1YtRHDcsdfl3L((object) instanceOf.New, (object) (EleWise.ELMA.Security.Models.IUser) user);
      return this.Count((IEntityFilter) instanceOf.New);
    }

    /// <summary>
    /// Получить количество сертификатов пользователя указанного действия
    /// </summary>
    /// <param name="user"></param>
    /// <param name="cryptoActionUid"></param>
    /// <returns></returns>
    public long Count(EleWise.ELMA.Security.IUser user, Guid cryptoActionUid) => UserCertificateManager.WNjD6g1yooaosJdoHiv((object) this, (object) new InstanceOf<IUserCertificateFilter>()
    {
      New = {
        User = ((EleWise.ELMA.Security.Models.IUser) user),
        CryptoActionGuid = new Guid?(cryptoActionUid)
      }
    }.New);

    /// <summary>Проверить наличие сертификатов пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <returns></returns>
    public bool Exists(EleWise.ELMA.Security.IUser user)
    {
      InstanceOf<IUserCertificateFilter> instanceOf = new InstanceOf<IUserCertificateFilter>();
      UserCertificateManager.d9DlVh1YtRHDcsdfl3L((object) instanceOf.New, (object) (EleWise.ELMA.Security.Models.IUser) user);
      return UserCertificateManager.qsIZ491V3qosvcRkmMi((object) this, (object) instanceOf.New);
    }

    /// <summary>
    /// Проверить наличие сертификатов пользователя указанного действия
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <param name="cryptoActionUid">Крипто-действие</param>
    /// <returns></returns>
    public bool Exists(EleWise.ELMA.Security.IUser user, Guid cryptoActionUid) => UserCertificateManager.qsIZ491V3qosvcRkmMi((object) this, (object) new InstanceOf<IUserCertificateFilter>()
    {
      New = {
        User = ((EleWise.ELMA.Security.Models.IUser) user),
        CryptoActionGuid = new Guid?(cryptoActionUid)
      }
    }.New);

    private void AuditCheckDigitalSignature(LoginAuditContainer auditContainer)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            UserCertificateManager.vEFtYG1lOUNuE7E616S((object) this.DigitalSignatureEventHandler, (object) auditContainer);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 0 : 0;
            continue;
          case 2:
            if (this.DigitalSignatureEventHandler != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef != 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:
      return;
label_6:;
    }

    public UserCertificateManager()
    {
      UserCertificateManager.JmB7l21fAa1Jo6RxGIw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool QCfoFb9h9mOWKeisbf5() => UserCertificateManager.nYBPkC9MQme2HZUISHh == null;

    internal static UserCertificateManager iaof3k9BnHddUyhwO3Q() => UserCertificateManager.nYBPkC9MQme2HZUISHh;

    internal static void ewEXDe9psTxRflshgbj([In] object obj0) => ((IVerifyResult) obj0).ThrowIfNotVerified();

    internal static object qD048h9OwFMZQB9yUvt([In] object obj0) => (object) ((IVerifyResult) obj0).Signer;

    internal static Guid PmVCQu9Te2cUjEtbMqW([In] object obj0) => ((CryptoProviderServiceBase<IAuthCryptoProvider>) obj0).GetCurrentUserProviderUid();

    internal static void qimkk89FcP8ninddchF(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      Guid providerUid)
    {
      ((UserCertificateManager) obj0).SignInByCertificate((string) obj1, (string) obj2, providerUid);
    }

    internal static object oXCiLN9vScOcNsPPCWy(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] bool obj3,
      [In] Guid obj4)
    {
      return (object) ((CryptoProviderServiceBase<IAuthCryptoProvider>) obj0).CheckSignature((string) obj1, (string) obj2, obj3, obj4);
    }

    internal static void cbIF2M9quBf1DVwiDxw([In] object obj0, [In] object obj1) => ((LoginAuditContainer) obj0).Result = (IVerifyResult) obj1;

    internal static void R4MCum9gBNveC15ZvWX([In] object obj0, [In] object obj1) => ((LoginAuditContainer) obj0).User = (EleWise.ELMA.Security.IUser) obj1;

    internal static bool dD6Q8p9JBNAT4VMXfbA([In] object obj0) => ((IVerifyResult) obj0).Verified;

    internal static Type hdw0C69IhuvYTwbyYYm([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object ck2e9l9e0rKcrtUJcBP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object xS5NlR9nRTyENs5tcWN([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object V3YrmV9L6QpmTRFr71E([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object awalpO92M5o2t2BI7n2([In] object obj0, [In] Type obj1) => (object) Expression.Constant(obj0, obj1);

    internal static object GZg3Eg9H1T4KmdFFevA([In] object obj0, [In] object obj1) => (object) Expression.Field((Expression) obj0, (FieldInfo) obj1);

    internal static object OWJjmW9zPOkjiQ9ZQtG([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object oGBqHp1uxiX2IYol3Gm([In] object obj0, [In] object obj1) => (object) Expression.Equal((Expression) obj0, (Expression) obj1);

    internal static object sGwuu11wuVs3VUuMnbt([In] RuntimeFieldHandle obj0) => (object) FieldInfo.GetFieldFromHandle(obj0);

    internal static object PvEme31b800rseytGMr([In] object obj0, [In] Type obj1) => (object) Expression.Convert((Expression) obj0, obj1);

    internal static object be8yqv1KSg31U7Iob7K([In] object obj0, [In] object obj1, [In] bool obj2, [In] object obj3) => (object) Expression.Equal((Expression) obj0, (Expression) obj1, obj2, (MethodInfo) obj3);

    internal static object HG7jFP1UGp7PJjxix52([In] object obj0, [In] object obj1) => (object) Expression.AndAlso((Expression) obj0, (Expression) obj1);

    internal static object r10IRB1RnQFf4Q6SLOg([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object zi7ulO1ovywTa9UiVEN([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object kCkXcy1txvMgH3DvBXY([In] object obj0) => (object) ((IUserCertificate) obj0).User;

    internal static Guid nombNu1mgTSIwdTsQs1([In] object obj0, [In] object obj1) => ((CryptoProviderServiceBase<IAuthCryptoProvider>) obj0).GetUserProviderUid((EleWise.ELMA.Security.Models.IUser) obj1);

    internal static bool QCoelg16m7bwSylyLGa([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool qZtkuG1kLUu9yRPQ4Ii([In] object obj0) => ((SecuritySettings) obj0).AllowLoginOnlyByDefaultCertificate;

    internal static object EP6VF01DXjvvuBpRcPL([In] object obj0) => (object) ((LoginAuditContainer) obj0).Result;

    internal static object pKcag71atoyJ8uM0Gpw([In] object obj0) => (object) ((IUserCertificate) obj0).Thumbprint;

    internal static object EAEFPP1xX9TKcZtLR4C([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static DateTime LCTLCE1ChXr4SEy9jrC() => DateTime.Now;

    internal static void ph9tUf1iuE7ss6btHXY([In] object obj0) => ((IEntity) obj0).Save();

    internal static object kSjhNq13YnCKCbwLRVl(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      Guid cryptoActionUid)
    {
      return (object) ((UserCertificateManager) obj0).RegisterCertificateByThumbprint((string) obj1, (string) obj2, (EleWise.ELMA.Security.Models.IUser) obj3, cryptoActionUid);
    }

    internal static object qsq0kF1jWmw1hrOya01(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      Guid cryptoActionUid,
      bool isDefault)
    {
      return (object) ((UserCertificateManager) obj0).RegisterCertificateBySignature((string) obj1, (string) obj2, (EleWise.ELMA.Security.Models.IUser) obj3, cryptoActionUid, isDefault);
    }

    internal static object Ioe9W41NRkZhlqZvinP([In] object obj0) => (object) ((ICryptoAction) obj0).CryptoService;

    internal static Guid YjXmyg10UwgdiLMmxyc([In] object obj0, [In] object obj1) => ((ICryptoProviderServiceBase) obj0).GetUserProviderUid((EleWise.ELMA.Security.Models.IUser) obj1);

    internal static object t3DNIT1ZesK6A4untPN(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      bool checkSignatureOnly,
      Guid providerUid)
    {
      return (object) ((ICryptoProviderServiceBase) obj0).CheckSignature((string) obj1, (string) obj2, checkSignatureOnly, providerUid);
    }

    internal static object c3jwvr1AQXOl24IIVs0([In] object obj0) => (object) ((ISigner) obj0).Thumbprint;

    internal static object MTT4GG1s4g7xxfKo3tl(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      Guid cryptoActionUid,
      bool isDefault)
    {
      return (object) ((UserCertificateManager) obj0).RegisterCertificateByThumbprint((string) obj1, (string) obj2, (EleWise.ELMA.Security.Models.IUser) obj3, cryptoActionUid, isDefault);
    }

    internal static void U0lrEB17hoQUqu1ratY([In] object obj0) => ((IEntity) obj0).Delete();

    internal static object OvTngb1WOCCU62tjjV9([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static bool r1XH071r0RmEtl2fUeK([In] object obj0, [In] object obj1, [In] object obj2) => ((ISecurityService) obj0).HasPermission((EleWise.ELMA.Security.IUser) obj1, (Permission) obj2);

    internal static object Ip5fwM1S3YVJ3rKg6hf([In] RuntimeMethodHandle obj0, [In] RuntimeTypeHandle obj1) => (object) MethodBase.GetMethodFromHandle(obj0, obj1);

    internal static void d9DlVh1YtRHDcsdfl3L([In] object obj0, [In] object obj1) => ((IUserCertificateFilter) obj0).User = (EleWise.ELMA.Security.Models.IUser) obj1;

    internal static long WNjD6g1yooaosJdoHiv([In] object obj0, [In] object obj1) => ((AbstractNHEntityManager<IUserCertificate, long>) obj0).Count((IEntityFilter) obj1);

    internal static bool qsIZ491V3qosvcRkmMi([In] object obj0, [In] object obj1) => __nonvirtual (((EntityManager<IUserCertificate, long>) obj0).Exists((IEntityFilter) obj1));

    internal static void vEFtYG1lOUNuE7E616S([In] object obj0, [In] object obj1) => ((ILoginDigitalSignatureEventHandler) obj0).CheckDigitalSignature((LoginAuditContainer) obj1);

    internal static void JmB7l21fAa1Jo6RxGIw() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}

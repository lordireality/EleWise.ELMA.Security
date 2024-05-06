// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.AuthCryptoProviderService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models.Crypto;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>Сервис криптопровайдеров входа в систему</summary>
  [Service]
  public class AuthCryptoProviderService : CryptoProviderServiceBase<IAuthCryptoProvider>
  {
    private static AuthCryptoProviderService EMKh137zQWWUfcFyeVk;

    /// <summary>Настройки безопасности</summary>
    public SecuritySettingsModule Module => Locator.GetServiceNotNull<SecuritySettingsModule>();

    /// <summary>Менеджер крипто профилей пользователя</summary>
    public UserCryptoProfileManager UserCryptoProfileManager
    {
      get => this.\u003CUserCryptoProfileManager\u003Ek__BackingField;
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
              this.\u003CUserCryptoProfileManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 0 : 0;
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

    /// <inheritdoc />
    public override IAuthCryptoProvider GetUserProvider(
      EleWise.ELMA.Security.Models.IUser user,
      bool onlyProfile)
    {
      int num = 3;
      Guid providerUid;
      IAuthCryptoProvider providerByUid;
      IAuthCryptoProvider userProvider;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_10;
          case 2:
            providerByUid = this.GetProviderByUid(providerUid);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af == 0 ? 4 : 0;
            continue;
          case 3:
            providerUid = AuthCryptoProviderService.Cs7cvSWbTTVLeMAtC81((object) this.UserCryptoProfileManager, (object) user);
            num = 2;
            continue;
          case 4:
            if (!onlyProfile)
            {
              num = 5;
              continue;
            }
            goto label_3;
          case 5:
            userProvider = providerByUid;
            if (userProvider == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0 ? 1 : 1;
              continue;
            }
            goto label_7;
          default:
            goto label_3;
        }
      }
label_3:
      return providerByUid;
label_7:
      return userProvider;
label_10:
      return this.DefaultProvider;
    }

    /// <inheritdoc />
    public override IAuthCryptoProvider DefaultProvider
    {
      get
      {
        int num = 4;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.Module.Settings.DefaultAuthCryptoProviderSettings == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 2:
              if (this.Module.Settings != null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b != 0 ? 1 : 0;
                continue;
              }
              goto label_4;
            case 4:
              if (this.Module == null)
              {
                num = 3;
                continue;
              }
              goto case 2;
            default:
              goto label_4;
          }
        }
label_4:
        return (IAuthCryptoProvider) null;
label_5:
        return this.GetProviderByUid(AuthCryptoProviderService.rcPGmmWUi5eZkf1BRw3(AuthCryptoProviderService.uQu0G1WKC14Xq0gkdfL((object) this.Module.Settings)));
      }
    }

    /// <inheritdoc />
    public override IDigitalSignatureType GetUserDigitalSignatureType(
      EleWise.ELMA.Security.Models.IUser user,
      bool onlyProfile)
    {
      int num = 2;
      IAuthCryptoProvider userProvider;
      Guid guid;
      IDigitalSignatureType digitalSignatureType1;
      IDigitalSignatureType digitalSignatureType2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (userProvider != null)
            {
              guid = AuthCryptoProviderService.dhpX0pWRfnWnrmdu8Sd((object) this.UserCryptoProfileManager, (object) user);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 5 : 2;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 0 : 0;
            continue;
          case 2:
            userProvider = this.GetUserProvider(user, false);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_11;
          case 4:
            digitalSignatureType2 = digitalSignatureType1;
            if (digitalSignatureType2 == null)
            {
              num = 7;
              continue;
            }
            goto label_6;
          case 5:
            digitalSignatureType1 = (IDigitalSignatureType) AuthCryptoProviderService.iVy7xVWtmtBKHZDYmKO((object) this, AuthCryptoProviderService.i2jDZmWo3xnPmrPsZmP((object) userProvider), guid);
            num = 6;
            continue;
          case 6:
            if (!onlyProfile)
            {
              num = 4;
              continue;
            }
            goto label_11;
          case 7:
            goto label_14;
          default:
            goto label_7;
        }
      }
label_7:
      return (IDigitalSignatureType) null;
label_11:
      return digitalSignatureType1;
label_6:
      return digitalSignatureType2;
label_14:
      return this.DefaultDigitalSignatureType;
    }

    /// <inheritdoc />
    public override IDigitalSignatureType DefaultDigitalSignatureType
    {
      get
      {
        int num1 = 4;
        DefaultCryptoProviderSettings providerSettings;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                providerSettings = (DefaultCryptoProviderSettings) AuthCryptoProviderService.uQu0G1WKC14Xq0gkdfL((object) this.Module.Settings);
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a == 0 ? 0 : 0;
                continue;
              case 2:
                if (AuthCryptoProviderService.uQu0G1WKC14Xq0gkdfL((object) this.Module.Settings) != null)
                {
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e == 0 ? 1 : 1;
                  continue;
                }
                goto label_10;
              case 3:
                goto label_6;
              case 4:
                if (this.Module != null)
                {
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 == 0 ? 3 : 3;
                  continue;
                }
                goto label_10;
              case 5:
                goto label_10;
              default:
                goto label_5;
            }
          }
label_6:
          if (this.Module.Settings != null)
            num1 = 2;
          else
            goto label_10;
        }
label_5:
        return (IDigitalSignatureType) AuthCryptoProviderService.iVy7xVWtmtBKHZDYmKO((object) this, providerSettings.CryptoProviderUid, AuthCryptoProviderService.DwVc7AWmPORDQDPD82F((object) providerSettings));
label_10:
        return (IDigitalSignatureType) null;
      }
    }

    public AuthCryptoProviderService()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool qNZU7mWuhhdTNx1UWZv() => AuthCryptoProviderService.EMKh137zQWWUfcFyeVk == null;

    internal static AuthCryptoProviderService SMdxIEWw5Ap7t7PhcNT() => AuthCryptoProviderService.EMKh137zQWWUfcFyeVk;

    internal static Guid Cs7cvSWbTTVLeMAtC81([In] object obj0, [In] object obj1) => ((UserCryptoProfileManager) obj0).GetUserAuthCryptoProviderUid((EleWise.ELMA.Security.Models.IUser) obj1);

    internal static object uQu0G1WKC14Xq0gkdfL([In] object obj0) => (object) ((SecuritySettings) obj0).DefaultAuthCryptoProviderSettings;

    internal static Guid rcPGmmWUi5eZkf1BRw3([In] object obj0) => ((DefaultCryptoProviderSettings) obj0).CryptoProviderUid;

    internal static Guid dhpX0pWRfnWnrmdu8Sd([In] object obj0, [In] object obj1) => ((UserCryptoProfileManager) obj0).GetUserAuthDigitalSignatureTypeUid((EleWise.ELMA.Security.Models.IUser) obj1);

    internal static Guid i2jDZmWo3xnPmrPsZmP([In] object obj0) => ((ICryptoProviderBase) obj0).ProviderUid;

    internal static object iVy7xVWtmtBKHZDYmKO([In] object obj0, [In] Guid obj1, [In] Guid obj2) => (object) ((CryptoProviderServiceBase<IAuthCryptoProvider>) obj0).GetDigitalSignatureType(obj1, obj2);

    internal static Guid DwVc7AWmPORDQDPD82F([In] object obj0) => ((DefaultCryptoProviderSettings) obj0).DigitalSignatureTypeUid;
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.CryptoProviderServiceBase`1
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models.Crypto;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>Базовый сервис управления криптопровайдерами</summary>
  /// <typeparam name="T"></typeparam>
  [Service]
  public abstract class CryptoProviderServiceBase<T> : ICryptoProviderServiceBase
    where T : ICryptoProviderBase
  {
    internal static object iKUi1NWacEoJjiViEBj;

    /// <summary>Логгер</summary>
    public ILogger Logger
    {
      get => this.\u003CLogger\u003Ek__BackingField;
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
              this.\u003CLogger\u003Ek__BackingField = value;
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
    }

    /// <summary>
    /// Сервис работы со значениями переменных в рамках контекста (например, веб-запроса)
    /// </summary>
    public IContextBoundVariableService ContextBoundVariableService
    {
      get => this.\u003CContextBoundVariableService\u003Ek__BackingField;
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
              this.\u003CContextBoundVariableService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 != 0 ? 0 : 0;
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

    /// <summary>Менеджер компонентов</summary>
    public IComponentManager ComponentManager
    {
      get => this.\u003CComponentManager\u003Ek__BackingField;
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
              this.\u003CComponentManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 != 0 ? 0 : 0;
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

    /// <summary>Служба аутентификации системы</summary>
    public IAuthenticationService AuthenticationService
    {
      get => this.\u003CAuthenticationService\u003Ek__BackingField;
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
              this.\u003CAuthenticationService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af != 0 ? 0 : 0;
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

    /// <summary>Типы электронной подписи</summary>
    public IEnumerable<IDigitalSignatureType> DigitalSignatureTypes { get; set; }

    /// <summary>Получить все провайдеры</summary>
    public virtual IEnumerable<T> Providers => this.ComponentManager.GetExtensionPoints<T>();

    /// <summary>Получить провайдер по uid'e</summary>
    /// <param name="providerUid"></param>
    /// <returns></returns>
    public virtual T GetProviderByUid(Guid providerUid)
    {
      if (this.CurrentProviderUid.HasValue)
        providerUid = this.CurrentProviderUid.Value;
      return this.ComponentManager.GetExtensionPoints<T>().FirstOrDefault<T>((Func<T, bool>) (p => p.ProviderUid.Equals(providerUid)));
    }

    /// <summary>Имя провайдер для пользователя</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public virtual string GetUserProviderName(EleWise.ELMA.Security.Models.IUser user)
    {
      int num = 1;
      T userProvider;
      while (true)
      {
        switch (num)
        {
          case 1:
            userProvider = this.GetUserProvider(user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            if ((object) userProvider == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 != 0 ? 2 : 0;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return string.Empty;
label_6:
      return userProvider.DisplayName;
    }

    /// <summary>Провайдер по умолчанию</summary>
    public abstract T DefaultProvider { get; }

    /// <summary>Типа электронной подписи по умолчанию</summary>
    public abstract IDigitalSignatureType DefaultDigitalSignatureType { get; }

    /// <summary>Uid провайдера по умолчанию</summary>
    public virtual Guid DefaultProviderUid
    {
      get
      {
        int num = 2;
        T defaultProvider;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if ((object) this.DefaultProvider == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0 ? 1 : 1;
                continue;
              }
              defaultProvider = this.DefaultProvider;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return defaultProvider.ProviderUid;
label_5:
        return Guid.Empty;
      }
    }

    /// <summary>Uid типа электронной подписи по умолчанию</summary>
    public virtual Guid DefaultDigitalSignatureTypeUid
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.DefaultDigitalSignatureType == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return Guid.Empty;
label_3:
        return this.DefaultDigitalSignatureType.Uid;
      }
    }

    /// <summary>Провайдер по умолчанию</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public virtual T GetUserProvider(EleWise.ELMA.Security.Models.IUser user) => this.GetUserProvider(user, false);

    /// <summary>Провайдер для пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="onlyProfile">Проверять только профиль</param>
    /// <returns>Провайдер</returns>
    public abstract T GetUserProvider(EleWise.ELMA.Security.Models.IUser user, bool onlyProfile);

    /// <summary>Провайдер для пользователя</summary>
    /// <returns></returns>
    public virtual T GetCurrentUserProvider() => this.GetCurrentUserProvider(false);

    /// <summary>Провайдер для пользователя</summary>
    /// <param name="onlyProfile">Только профиль</param>
    /// <returns></returns>
    public virtual T GetCurrentUserProvider(bool onlyProfile) => this.GetUserProvider((EleWise.ELMA.Security.Models.IUser) this.AuthenticationService.GetCurrentUser(), onlyProfile);

    /// <summary>Провайдер для пользователя</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public virtual Guid GetUserProviderUid(EleWise.ELMA.Security.Models.IUser user) => this.GetUserProviderUid(user, false);

    /// <summary>Uid провайдер для пользователя</summary>
    /// <param name="user"></param>
    /// <param name="onlyProfile">Только профиль</param>
    /// <returns></returns>
    public virtual Guid GetUserProviderUid(EleWise.ELMA.Security.Models.IUser user, bool onlyProfile)
    {
      int num = 1;
      T userProvider;
      while (true)
      {
        switch (num)
        {
          case 1:
            userProvider = this.GetUserProvider(user, onlyProfile);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a049204b7f594cf0a013e3e88ee73ae7 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            if ((object) userProvider == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0 ? 1 : 2;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return Guid.Empty;
label_3:
      return userProvider.ProviderUid;
    }

    /// <summary>Uid провайдер для текущего пользователя</summary>
    /// <returns></returns>
    public virtual Guid GetCurrentUserProviderUid() => this.GetCurrentUserProviderUid(false);

    /// <summary>Uid провайдер для текущего пользователя</summary>
    /// <param name="onlyProfile">Только профиль</param>
    /// <returns></returns>
    public virtual Guid GetCurrentUserProviderUid(bool onlyProfile) => this.GetUserProviderUid((EleWise.ELMA.Security.Models.IUser) this.AuthenticationService.GetCurrentUser(), onlyProfile);

    /// <summary>
    /// Получить типы электронной подписи для существующих провайдеров
    /// </summary>
    /// <returns></returns>
    public IEnumerable<IDigitalSignatureType> GetDigitalSignatureTypes()
    {
      IEnumerable<Guid> uids = this.Providers.Select<T, Guid>((Func<T, Guid>) (p => p.ProviderUid));
      return this.DigitalSignatureTypes.Where<IDigitalSignatureType>((Func<IDigitalSignatureType, bool>) (dst => dst.Providers.Intersect<Guid>(uids).Any<Guid>()));
    }

    /// <summary>Получить типы подписей для провайдера</summary>
    /// <param name="providerUid">Uid провайдера</param>
    /// <returns>Типы электронных подписей</returns>
    public virtual IEnumerable<IDigitalSignatureType> GetDigitalSignatureTypesByProviderUid(
      Guid providerUid)
    {
      return this.DigitalSignatureTypes.Where<IDigitalSignatureType>((Func<IDigitalSignatureType, bool>) (t => t.Providers.Contains<Guid>(providerUid)));
    }

    /// <summary>Получить тип электронной подписи для пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <returns></returns>
    public virtual Guid GetUserDigitalSignatureTypeUid(EleWise.ELMA.Security.Models.IUser user) => this.GetUserDigitalSignatureTypeUid(user, false);

    /// <summary>Получить тип электронной подписи для пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="onlyProfile">Только профиль</param>
    /// <returns></returns>
    public abstract IDigitalSignatureType GetUserDigitalSignatureType(
      EleWise.ELMA.Security.Models.IUser user,
      bool onlyProfile);

    /// <summary>Получить тип электронной подписи</summary>
    /// <param name="providerUid">Uid провайдера</param>
    /// <param name="digitalSignatureTypeUid">Uid типа электронной подписи</param>
    /// <returns>Тип электронной подписи</returns>
    public virtual IDigitalSignatureType GetDigitalSignatureType(
      Guid providerUid,
      Guid digitalSignatureTypeUid)
    {
      int num1 = 1;
      Guid providerUid1;
      Guid digitalSignatureTypeUid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            digitalSignatureTypeUid1 = digitalSignatureTypeUid;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 2 : 2;
            continue;
          default:
            providerUid1 = providerUid;
            num1 = 3;
            continue;
        }
      }
label_2:
      return this.DigitalSignatureTypes.Where<IDigitalSignatureType>((Func<IDigitalSignatureType, bool>) (i => i.Providers.Contains<Guid>(providerUid1))).FirstOrDefault<IDigitalSignatureType>((Func<IDigitalSignatureType, bool>) (p =>
      {
        int num2 = 1;
        Guid uid;
        while (true)
        {
          switch (num2)
          {
            case 1:
              uid = p.Uid;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return uid.Equals(digitalSignatureTypeUid1);
      }));
    }

    /// <summary>Получить имя типа электронной подписи</summary>
    /// <param name="providerUid">Uid провайдера</param>
    /// <param name="digitalSignatureTypeUid">Uid типа электронной подписи</param>
    /// <returns>Имя типа электронной подписи</returns>
    public virtual string GetDigitalSignatureTypeName(
      Guid? providerUid,
      Guid? digitalSignatureTypeUid)
    {
      if (!digitalSignatureTypeUid.HasValue || !providerUid.HasValue)
        return string.Empty;
      IDigitalSignatureType digitalSignatureType = this.GetDigitalSignatureType(providerUid.Value, digitalSignatureTypeUid.Value);
      return digitalSignatureType == null ? string.Empty : digitalSignatureType.DisplayName;
    }

    /// <summary>
    /// Получить тип электронной подписи для текущего пользователя
    /// </summary>
    /// <returns>Тип электронной подписи</returns>
    public virtual IDigitalSignatureType GetCurrentUserDigitalSignatureType()
    {
      int num = 2;
      Guid currentUserProviderUid;
      Guid signatureTypeUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            signatureTypeUid = this.GetCurrentUserDigitalSignatureTypeUid(false);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 0 : 0;
            continue;
          case 2:
            currentUserProviderUid = this.GetCurrentUserProviderUid(false);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 1 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this.GetDigitalSignatureType(currentUserProviderUid, signatureTypeUid);
    }

    /// <summary>
    /// Получить uid типа электронной подписи для текущего пользователя
    /// </summary>
    /// <returns>Uid типа электронной подписи</returns>
    public virtual Guid GetCurrentUserDigitalSignatureTypeUid() => this.GetCurrentUserDigitalSignatureTypeUid(false);

    /// <summary>
    /// Получить uid типа электронной подписи для текущего пользователя
    /// </summary>
    /// <param name="onlyProfile">Только профиль</param>
    /// <returns>Uid типа электронной подписи</returns>
    public virtual Guid GetCurrentUserDigitalSignatureTypeUid(bool onlyProfile) => this.GetUserDigitalSignatureTypeUid((EleWise.ELMA.Security.Models.IUser) this.AuthenticationService.GetCurrentUser(), onlyProfile);

    /// <summary>
    /// Получить uid типа электронной подписи для пользователя
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <param name="onlyProfile">Только профиль</param>
    /// <returns>Uid типа электронной подписи</returns>
    public virtual Guid GetUserDigitalSignatureTypeUid(EleWise.ELMA.Security.Models.IUser user, bool onlyProfile)
    {
      int num = 1;
      IDigitalSignatureType digitalSignatureType;
      while (true)
      {
        switch (num)
        {
          case 1:
            digitalSignatureType = this.GetUserDigitalSignatureType(user, onlyProfile);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            goto label_6;
          default:
            if (digitalSignatureType != null)
            {
              num = 3;
              continue;
            }
            goto label_5;
        }
      }
label_5:
      return Guid.Empty;
label_6:
      return digitalSignatureType.Uid;
    }

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для текущего пользователя)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      string text,
      string signature,
      bool checkSignatureOnly)
    {
      return this.CheckSignature(text, signature, checkSignatureOnly, this.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
    }

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для текущего пользователя)
    /// </summary>
    /// <param name="text">Исходные данные</param>
    /// <param name="signature">Сигнатура</param>
    /// <param name="checkSignatureOnly">Проверять только валидность подписи, без проверки сертификатов</param>
    /// <param name="encoding">Кодировка</param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      string text,
      string signature,
      bool checkSignatureOnly,
      out string encoding)
    {
      return this.CheckSignature(text, signature, checkSignatureOnly, this.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>(), out encoding);
    }

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для указанного провайдера)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="providerUid"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      string text,
      string signature,
      bool checkSignatureOnly,
      Guid providerUid)
    {
      int num = 1;
      string encoding;
      while (true)
      {
        switch (num)
        {
          case 1:
            encoding = "";
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this.CheckSignature(text, signature, checkSignatureOnly, providerUid, out encoding);
    }

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для указанного пользователя)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      string text,
      string signature,
      bool checkSignatureOnly,
      EleWise.ELMA.Security.Models.IUser user)
    {
      int num = 1;
      string encoding;
      while (true)
      {
        switch (num)
        {
          case 1:
            encoding = "";
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this.CheckSignature(text, signature, checkSignatureOnly, user, out encoding);
    }

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для указанного провайдера)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="providerUid"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      string text,
      string signature,
      bool checkSignatureOnly,
      Guid providerUid,
      out string encoding)
    {
      return this.CheckSignature(text, signature, checkSignatureOnly, (EleWise.ELMA.Security.Models.IUser) null, new Guid?(providerUid), out encoding);
    }

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для указанного пользователя)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="user"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      string text,
      string signature,
      bool checkSignatureOnly,
      EleWise.ELMA.Security.Models.IUser user,
      out string encoding)
    {
      return this.CheckSignature(text, signature, checkSignatureOnly, user, new Guid?(), out encoding);
    }

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для указанного пользователя или провайдера)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="user">Пользователь</param>
    /// <param name="providerUid">Uid провайдера, если не null, то в приоритете</param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      string text,
      string signature,
      bool checkSignatureOnly,
      EleWise.ELMA.Security.Models.IUser user,
      Guid? providerUid,
      out string encoding)
    {
      return this.CheckSignature(text, this.SignatureToBytes(signature), checkSignatureOnly, user, providerUid, out encoding);
    }

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для текущего пользователя)
    /// </summary>
    /// <param name="content"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      byte[] content,
      string signature,
      bool checkSignatureOnly)
    {
      return this.CheckSignature(content, signature, checkSignatureOnly, this.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
    }

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для указанного провайдера)
    /// </summary>
    /// <param name="content"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="providerUid"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      byte[] content,
      string signature,
      bool checkSignatureOnly,
      Guid providerUid)
    {
      return this.CheckSignature(content, this.SignatureToBytes(signature), checkSignatureOnly, providerUid);
    }

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для указанного пользователя)
    /// </summary>
    /// <param name="content"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      byte[] content,
      string signature,
      bool checkSignatureOnly,
      EleWise.ELMA.Security.Models.IUser user)
    {
      return this.CheckSignature(content, this.SignatureToBytes(signature), checkSignatureOnly, user);
    }

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для текущего пользователя)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      string text,
      byte[] signature,
      bool checkSignatureOnly,
      out string encoding)
    {
      return this.CheckSignature(text, signature, checkSignatureOnly, this.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>(), out encoding);
    }

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для указанного пользователя)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="user"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      string text,
      byte[] signature,
      bool checkSignatureOnly,
      EleWise.ELMA.Security.Models.IUser user,
      out string encoding)
    {
      return this.CheckSignature(text, signature, checkSignatureOnly, user, new Guid?(), out encoding);
    }

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для указанного провайдера)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="providerUid"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      string text,
      byte[] signature,
      bool checkSignatureOnly,
      Guid providerUid,
      out string encoding)
    {
      return this.CheckSignature(text, signature, checkSignatureOnly, (EleWise.ELMA.Security.Models.IUser) null, new Guid?(providerUid), out encoding);
    }

    /// <summary>
    /// Проверить сигнатуру подписанного текста с известной кодировкой (для указанного провайдера)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="providerUid"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      string text,
      byte[] signature,
      bool checkSignatureOnly,
      Guid providerUid,
      string encoding)
    {
      return this.CheckSignature(Encoding.GetEncoding(encoding).GetBytes(text), signature, checkSignatureOnly, (EleWise.ELMA.Security.Models.IUser) null, new Guid?(providerUid));
    }

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для пользователя или указанного провайдера)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="providerUid"></param>
    /// <param name="user"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      string text,
      byte[] signature,
      bool checkSignatureOnly,
      EleWise.ELMA.Security.Models.IUser user,
      Guid? providerUid,
      out string encoding)
    {
      encoding = (string) null;
      try
      {
        IVerifyResult verifyResult1 = this.CheckSignature(Encoding.UTF8.GetBytes(text), signature, checkSignatureOnly, user, providerUid);
        if (verifyResult1.Verified)
        {
          encoding = z2jc63fLkugS1X8Q9N.tE1kD1vbB(150349507 - 521039768 ^ -370676439);
          return verifyResult1;
        }
        string error1 = verifyResult1.Error;
        IVerifyResult verifyResult2 = this.CheckSignature(Encoding.Unicode.GetBytes(text), signature, checkSignatureOnly, user, providerUid);
        if (verifyResult2.Verified)
        {
          encoding = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-522456341 ^ -522475269);
          return verifyResult2;
        }
        string error2 = verifyResult2.Error;
        this.Logger.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1530848604 ^ 1530838908), (object) error1, (object) error2));
        verifyResult2.Error = error2;
        return verifyResult2;
      }
      catch (Exception ex)
      {
        this.Logger.Error((object) ex);
        return (IVerifyResult) VerifyResult.Fail(ex.Message);
      }
    }

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для текущего пользователя)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      string text,
      byte[] signature,
      bool checkSignatureOnly)
    {
      return this.CheckSignature(text, signature, checkSignatureOnly, this.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
    }

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для указанного провайдера)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="providerUid"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      string text,
      byte[] signature,
      bool checkSignatureOnly,
      Guid providerUid)
    {
      int num = 1;
      string encoding;
      while (true)
      {
        switch (num)
        {
          case 1:
            encoding = "";
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this.CheckSignature(text, signature, checkSignatureOnly, (EleWise.ELMA.Security.Models.IUser) null, new Guid?(providerUid), out encoding);
    }

    /// <summary>
    /// Проверить сигнатуру подписанного текста с неизвестной кодировкой (для указанного пользователя)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      string text,
      byte[] signature,
      bool checkSignatureOnly,
      EleWise.ELMA.Security.Models.IUser user)
    {
      int num = 1;
      string encoding;
      while (true)
      {
        switch (num)
        {
          case 1:
            encoding = "";
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this.CheckSignature(text, signature, checkSignatureOnly, user, new Guid?(), out encoding);
    }

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для текущего пользователя)
    /// </summary>
    /// <param name="content">Исходные данные</param>
    /// <param name="signature">Сигнатура</param>
    /// <param name="checkSignatureOnly">Проверять только валидность подписи, без проверки сертификатов</param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      byte[] content,
      byte[] signature,
      bool checkSignatureOnly)
    {
      return this.CheckSignature(content, signature, checkSignatureOnly, this.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
    }

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для текущего пользователя)
    /// </summary>
    /// <param name="file">Файл</param>
    /// <param name="signature">Сигнатура</param>
    /// <param name="checkSignatureOnly">Проверять только валидность подписи, без проверки сертификатов</param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      BinaryFile file,
      string signature,
      bool checkSignatureOnly)
    {
      return this.CheckSignature(this.BinaryFileBytes(file), signature, checkSignatureOnly);
    }

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для указанного провайдера)
    /// </summary>
    /// <param name="file">Файл</param>
    /// <param name="signature">Сигнатура</param>
    /// <param name="checkSignatureOnly">Проверять только валидность подписи, без проверки сертификатов</param>
    /// <param name="providerUid">Uid провайдера</param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      BinaryFile file,
      byte[] signature,
      bool checkSignatureOnly,
      Guid providerUid)
    {
      return this.CheckSignature(this.BinaryFileBytes(file), signature, checkSignatureOnly, providerUid);
    }

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для указанного пользователя)
    /// </summary>
    /// <param name="content"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      byte[] content,
      byte[] signature,
      bool checkSignatureOnly,
      EleWise.ELMA.Security.Models.IUser user)
    {
      return this.CheckSignature(content, signature, checkSignatureOnly, user, new Guid?());
    }

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для указанного провайдера)
    /// </summary>
    /// <param name="content"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="providerUid"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      byte[] content,
      byte[] signature,
      bool checkSignatureOnly,
      Guid providerUid)
    {
      return this.CheckSignature(content, signature, checkSignatureOnly, (EleWise.ELMA.Security.Models.IUser) null, new Guid?(providerUid));
    }

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для указанного провайдера)
    /// </summary>
    /// <param name="file">Файл</param>
    /// <param name="signature">Сигнатура</param>
    /// <param name="checkSignatureOnly">Проверять только валидность подписи, без проверки сертификатов</param>
    /// <param name="providerUid">Uid провайдера</param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      BinaryFile file,
      string signature,
      bool checkSignatureOnly,
      Guid providerUid)
    {
      return this.CheckSignature(this.BinaryFileBytes(file), signature, checkSignatureOnly, providerUid);
    }

    /// <summary>
    /// Проверить сигнатуру подписанных данных (для указанного пользователя или провайдера)
    /// Все перевызовы ведут сюда
    /// </summary>
    /// <param name="content"></param>
    /// <param name="signature"></param>
    /// <param name="checkSignatureOnly"></param>
    /// <param name="user"></param>
    /// <param name="providerUid"></param>
    /// <returns></returns>
    public virtual IVerifyResult CheckSignature(
      byte[] content,
      byte[] signature,
      bool checkSignatureOnly,
      EleWise.ELMA.Security.Models.IUser user,
      Guid? providerUid)
    {
      try
      {
        if (signature.Length == 0)
          return (IVerifyResult) VerifyResult.Fail(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1596821387 ^ -1596839175)));
        T obj = providerUid.HasValue ? this.GetProviderByUid(providerUid.Value) : (user == null ? this.GetCurrentUserProvider() : this.GetUserProvider(user));
        if ((object) obj == null)
          return (IVerifyResult) VerifyResult.Fail(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2086891181 ^ 2086876181)));
        IVerifyResult verifyResult = obj.Verify(content, signature, checkSignatureOnly);
        if (verifyResult != null && string.IsNullOrEmpty(verifyResult.ProviderName))
          verifyResult.ProviderName = obj.DisplayName;
        return verifyResult;
      }
      catch (Exception ex)
      {
        this.Logger.Error((object) ex);
        return (IVerifyResult) VerifyResult.Fail(ex.Message);
      }
    }

    /// <summary>Выполнить действие с указанием провайдера</summary>
    /// <param name="providerUid"></param>
    /// <param name="action"></param>
    public void RunWithProvider(Guid? providerUid, Action action)
    {
      Guid? currentProviderUid = this.CurrentProviderUid;
      this.CurrentProviderUid = providerUid;
      try
      {
        action();
      }
      finally
      {
        this.CurrentProviderUid = currentProviderUid;
      }
    }

    protected byte[] SignatureToBytes(string signature)
    {
      int num1 = 1;
      byte[] bytes;
      while (true)
      {
        switch (num1)
        {
          case 1:
            bytes = new byte[0];
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_10;
          default:
            goto label_2;
        }
      }
label_2:
      try
      {
        bytes = Convert.FromBase64String(signature);
        int num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      catch (Exception ex)
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              this.Logger.Error((object) ex);
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 != 0 ? 0 : 0;
              continue;
            default:
              goto label_10;
          }
        }
      }
label_10:
      return bytes;
    }

    protected byte[] BinaryFileBytes(BinaryFile file)
    {
      int num1 = 2;
      byte[] numArray;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            numArray = new byte[0];
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e == 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return numArray;
label_3:
      try
      {
        Stream content = file.GetContent();
        int num2 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0)
          num2 = 1;
        switch (num2)
        {
          case 1:
            try
            {
              numArray = content.ReadAllBytes();
              int num3 = 0;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff == 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  goto label_2;
              }
            }
            finally
            {
              int num4;
              if (content == null)
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b == 0 ? 0 : 1;
              else
                goto label_12;
label_11:
              switch (num4)
              {
                case 1:
                case 2:
              }
label_12:
              content.Dispose();
              num4 = 2;
              goto label_11;
            }
          default:
            goto label_2;
        }
      }
      catch (Exception ex)
      {
        int num5 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 != 0)
          num5 = 0;
        while (true)
        {
          switch (num5)
          {
            case 1:
              this.Logger.Error((object) ex);
              num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
      }
    }

    private Guid? CurrentProviderUid
    {
      get => this.ContextBoundVariableService.GetOrAdd<Guid?>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2008710664 - -232311158 ^ -1776414598), (Func<Guid?>) (() => new Guid?()));
      set => this.ContextBoundVariableService.Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1690209562 ^ 116876444 ^ 1648997010), (object) value);
    }

    protected CryptoProviderServiceBase()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool cqIoYCWxtorbJVlSw9o() => CryptoProviderServiceBase<T>.iKUi1NWacEoJjiViEBj == null;

    internal static object yGxfHkWC3xqEqtbY08b() => CryptoProviderServiceBase<T>.iKUi1NWacEoJjiViEBj;
  }
}

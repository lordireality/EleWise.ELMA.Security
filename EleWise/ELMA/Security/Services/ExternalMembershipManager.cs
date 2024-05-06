// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.ExternalMembershipManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Общий сервис работы с внешними модулями авторизации IExternalMembershipModule и провайдерами авторизации IExternalMembershipService
  /// </summary>
  [Service]
  internal class ExternalMembershipManager : IExternalMembershipManager
  {
    private static ExternalMembershipManager FCS7C3Wi1w4eqJnHUlh;

    /// <summary>Все модули авторизации</summary>
    public IEnumerable<IExternalMembershipModule> Modules { get; set; }

    /// <summary>
    /// Получение внешнего модуля авторизации по уникальному идентификатору
    /// </summary>
    public IExternalMembershipModule GetModule(Guid moduleUid)
    {
      int num = 2;
      Guid moduleUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            moduleUid1 = moduleUid;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec != 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      // ISSUE: reference to a compiler-generated method
      return this.Modules.FirstOrDefault<IExternalMembershipModule>((Func<IExternalMembershipModule, bool>) (p => ExternalMembershipManager.\u003C\u003Ec__DisplayClass4_0.sRgRssw3SnqLwCp61mct((object) p) == moduleUid1));
    }

    /// <summary>Сохранить настройки модуля авторизации</summary>
    [Transaction]
    public virtual void SaveSettings(IExternalMembershipModuleSettings settings)
    {
      int num = 12;
      IStoreValuesObject storeValuesObject;
      Guid guid;
      IDictionary<string, string> storageValues;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            if (!ExternalMembershipManager.DDGlW9WNMdSyEApaTGH(guid, Guid.Empty))
            {
              storageValues = storeValuesObject.GetStorageValues();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0 ? 9 : 5;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 3:
            ExternalMembershipManager.ptBE3XWZlOT0MDfUSjQ((object) settings, ExternalMembershipManager.uYNDWdW0nfcwMnYCoK3());
            num = 8;
            continue;
          case 4:
            goto label_10;
          case 5:
            storeValuesObject = (IStoreValuesObject) settings;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 == 0 ? 0 : 10;
            continue;
          case 6:
          case 8:
            guid = ExternalMembershipManager.mcNWhfWA9jjEvoIgGmQ((object) settings);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0 ? 5 : 5;
            continue;
          case 7:
            goto label_19;
          case 9:
            ExternalMembershipManager.IXDmyeWS0uL3s5SdO3Y((object) DataAccessManager.SettingsManager, ExternalMembershipManager.uL70hGW75VUZ0PRBlM8((object) settings.Module()), ExternalMembershipManager.OmA0i9WW8Do1NNn8TOV((object) guid.ToString()), ExternalMembershipManager.GEjKyiWrPgiQWPlCerK((object) ExternalMembershipSettingsHolder.DictionaryToHolder(storageValues), true));
            num = 7;
            continue;
          case 10:
            if (ExternalMembershipManager.dy7masWsmXkYUAa1fvM((object) settings) == null)
            {
              num = 4;
              continue;
            }
            goto case 1;
          case 11:
            if (!ExternalMembershipManager.DDGlW9WNMdSyEApaTGH(settings.InstanceUid, Guid.Empty))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 == 0 ? 2 : 6;
              continue;
            }
            goto case 3;
          case 12:
            if (settings != null)
            {
              num = 11;
              continue;
            }
            goto label_13;
          default:
            goto label_2;
        }
      }
label_7:
      return;
label_6:
      return;
label_10:
      return;
label_19:
      return;
label_2:
      return;
label_13:;
    }

    /// <summary>Загрузить настройки модуля авторизации</summary>
    public IExternalMembershipModuleSettings LoadSettings(
      Guid instanceUid)
    {
      int num1 = 3;
      string key;
      IEnumerator<IExternalMembershipModule> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            enumerator = this.Modules.GetEnumerator();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0 ? 1 : 0;
            continue;
          case 3:
            key = (string) ExternalMembershipManager.OmA0i9WW8Do1NNn8TOV((object) instanceUid.ToString());
            num1 = 2;
            continue;
          default:
            goto label_34;
        }
      }
label_2:
      IExternalMembershipModuleSettings membershipModuleSettings1;
      try
      {
label_26:
        if (ExternalMembershipManager.RlirLjWfCgLtCNYrxDv((object) enumerator))
          goto label_28;
        else
          goto label_27;
label_3:
        IExternalMembershipModule current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              if (current != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 != 0 ? 0 : 1;
                continue;
              }
              goto label_26;
            case 3:
              goto label_26;
            case 4:
              goto label_34;
            default:
              goto label_28;
          }
        }
label_6:
        try
        {
          IDictionary<string, string> allStrings = ((ISettingsManager) ExternalMembershipManager.Wm1EIyWYGpQERlbrb4t()).GetAllStrings(ExternalMembershipManager.uL70hGW75VUZ0PRBlM8((object) current));
          int num3 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 == 0)
            num3 = 0;
          IExternalMembershipModuleSettings membershipModuleSettings2;
          string xml;
          IStoreValuesObject storeValuesObject;
          IDictionary<string, string> dictionary;
          while (true)
          {
            switch (num3)
            {
              case 1:
              case 3:
              case 4:
              case 8:
              case 11:
                goto label_26;
              case 2:
              case 12:
                dictionary = ExternalMembershipSettingsHolder.HolderToDictionary(ClassSerializationHelper.DeserializeObjectByXml<ExternalMembershipSettingsHolder>(xml));
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0 ? 13 : 13;
                continue;
              case 5:
                membershipModuleSettings2 = (IExternalMembershipModuleSettings) ExternalMembershipManager.DkAHESWyGUP5Lsgmujv((object) current);
                num3 = 9;
                continue;
              case 6:
                goto label_35;
              case 7:
                if (!allStrings.TryGetValue(key, out xml))
                {
                  num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0 ? 11 : 1;
                  continue;
                }
                goto case 5;
              case 9:
                storeValuesObject = (IStoreValuesObject) membershipModuleSettings2;
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 == 0 ? 15 : 10;
                continue;
              case 10:
                membershipModuleSettings1 = membershipModuleSettings2;
                num3 = 6;
                continue;
              case 13:
                storeValuesObject.SetStorageValues(dictionary);
                num3 = 10;
                continue;
              case 14:
                if (storeValuesObject != null)
                {
                  num3 = 12;
                  continue;
                }
                goto label_26;
              case 15:
                if (membershipModuleSettings2 == null)
                {
                  num3 = 3;
                  continue;
                }
                goto case 14;
              default:
                if (allStrings == null)
                {
                  num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 != 0 ? 1 : 0;
                  continue;
                }
                goto case 7;
            }
          }
        }
        catch (Exception ex)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_26;
              default:
                ExternalMembershipManager.ORTOusWl3p0Zwm3xoko(ExternalMembershipManager.LE2dI5WVxWoQhnICEdg(), (object) ex);
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_27:
        num2 = 4;
        goto label_3;
label_28:
        current = enumerator.Current;
        num2 = 2;
        goto label_3;
      }
      finally
      {
        int num5;
        if (enumerator == null)
          num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed == 0 ? 0 : 0;
        else
          goto label_32;
label_31:
        switch (num5)
        {
          case 1:
            break;
          default:
        }
label_32:
        ExternalMembershipManager.qLx1WZW4XwBFhFJcQPC((object) enumerator);
        num5 = 2;
        goto label_31;
      }
label_35:
      return membershipModuleSettings1;
label_34:
      return (IExternalMembershipModuleSettings) null;
    }

    /// <summary>Удалить настройки модуля авторизации</summary>
    [Transaction]
    public virtual void DeleteSettings(Guid moduleUid, Guid instanceUid)
    {
      switch (1)
      {
        case 1:
          try
          {
            ExternalMembershipManager.VK7vjpWcMdMq6wjdWMi(ExternalMembershipManager.Wm1EIyWYGpQERlbrb4t(), moduleUid, (object) instanceUid.ToString());
            int num = 0;
            if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0)
              num = 0;
            switch (num)
            {
              case 0:
                return;
              default:
                return;
            }
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_1;
                default:
                  ((ILogger) ExternalMembershipManager.LE2dI5WVxWoQhnICEdg()).Error((object) ex);
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0 ? 0 : 1;
                  continue;
              }
            }
label_1:
            break;
          }
      }
    }

    /// <summary>Загрузить все настройки всех модулей авторизации</summary>
    public IEnumerable<IExternalMembershipModuleSettings> GetAllSettings()
    {
      List<IExternalMembershipModuleSettings> allSettings = new List<IExternalMembershipModuleSettings>();
      foreach (IExternalMembershipModule module in this.Modules)
      {
        if (module != null)
        {
          try
          {
            IDictionary<string, string> allStrings = DataAccessManager.SettingsManager.GetAllStrings(module.Uid);
            if (allStrings != null)
            {
              foreach (KeyValuePair<string, string> keyValuePair in (IEnumerable<KeyValuePair<string, string>>) allStrings)
              {
                try
                {
                  IExternalMembershipModuleSettings defaultSettings = module.CreateDefaultSettings();
                  IStoreValuesObject storeValuesObject = (IStoreValuesObject) defaultSettings;
                  if (defaultSettings != null)
                  {
                    if (storeValuesObject != null)
                    {
                      IDictionary<string, string> dictionary = ExternalMembershipSettingsHolder.HolderToDictionary(ClassSerializationHelper.DeserializeObjectByXml<ExternalMembershipSettingsHolder>(keyValuePair.Value));
                      storeValuesObject.SetStorageValues(dictionary);
                      allSettings.Add(defaultSettings);
                    }
                  }
                }
                catch (Exception ex)
                {
                  Logger.Log.Error((object) ex);
                }
              }
            }
          }
          catch (Exception ex)
          {
            Logger.Log.Error((object) ex);
          }
        }
      }
      return (IEnumerable<IExternalMembershipModuleSettings>) allSettings;
    }

    /// <summary>Создать настройки по умолчанию для модуля авторизации</summary>
    public IExternalMembershipModuleSettings CreateDefaultSettings(
      IExternalMembershipModule module)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (module == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      throw new ArgumentNullException((string) ExternalMembershipManager.NGC9gkWPOwmbW55yPBt(-2143851882 - 923330995 ^ 1227807603));
label_5:
      return this.CreateDefaultSettings(new Func<IExternalMembershipModuleSettings>(module.CreateDefaultSettings));
    }

    /// <summary>Создать настройки по умолчанию для модуля авторизации</summary>
    public IExternalMembershipModuleSettings CreateDefaultSettings(
      Func<IExternalMembershipModuleSettings> createDefaultSettingsFunc)
    {
      return createDefaultSettingsFunc();
    }

    /// <summary>Поиск пользователей по подстроке</summary>
    /// <param name="searchString">Строка поиска</param>
    /// <param name="authProviderGuid">Uid провайдера авторизации</param>
    /// <returns>Список пользователей</returns>
    public IEnumerable<IUser> FindUsers(string searchString, Guid authProviderGuid)
    {
      IExternalMembershipModuleSettings settings = (IExternalMembershipModuleSettings) null;
      try
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        settings = this.GetAllSettings().FirstOrDefault<IExternalMembershipModuleSettings>((Func<IExternalMembershipModuleSettings, bool>) (m => ExternalMembershipManager.\u003C\u003Ec__DisplayClass11_0.LsuRwUw3fGNI1cHw6elm(ExternalMembershipManager.\u003C\u003Ec__DisplayClass11_0.lDUdiGw3lIg7eE3WOKyy((object) m), authProviderGuid)));
        if (settings != null)
          return settings.Module().FindUsers(searchString, settings);
      }
      catch (Exception ex)
      {
        string message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-522456341 ^ -522475189), settings == null ? (object) "" : (object) settings.Name, (object) authProviderGuid);
        Logger.Log.Error((object) message, ex);
        throw new Exception(message, ex);
      }
      string message1 = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(554338340 ^ 554357812), (object) authProviderGuid);
      Logger.Log.Error((object) message1);
      throw new Exception(message1);
    }

    public string Name(Guid authProviderGuid)
    {
      int num1 = 3;
      Guid authProviderGuid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            authProviderGuid1 = authProviderGuid;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 == 0 ? 0 : 0;
            continue;
          case 3:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d == 0 ? 2 : 2;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return string.Empty;
label_5:
      string str;
      try
      {
        // ISSUE: reference to a compiler-generated method
        IExternalMembershipModuleSettings membershipModuleSettings = this.GetAllSettings().FirstOrDefault<IExternalMembershipModuleSettings>((Func<IExternalMembershipModuleSettings, bool>) (m => ExternalMembershipManager.\u003C\u003Ec__DisplayClass12_0.HpCXOKw3QywO3fj0Cn6M(m.InstanceUid, authProviderGuid1)));
        int num2 = 2;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              if (membershipModuleSettings != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 3:
              goto label_2;
            default:
              str = membershipModuleSettings.Name;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 != 0 ? 1 : 0;
              continue;
          }
        }
      }
      catch (Exception ex)
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              ((ILogger) ExternalMembershipManager.LE2dI5WVxWoQhnICEdg()).Error((object) ex);
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            default:
              str = string.Empty;
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 == 0 ? 1 : 2;
              continue;
          }
        }
      }
label_3:
      return str;
    }

    public Dictionary<Guid, string> GetAllName()
    {
      Dictionary<Guid, string> result = new Dictionary<Guid, string>();
      this.GetAllSettings().ForEach<IExternalMembershipModuleSettings>((Action<IExternalMembershipModuleSettings>) (s =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              if (s == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 2:
              goto label_9;
            case 3:
              // ISSUE: reference to a compiler-generated method
              if (!result.ContainsKey(ExternalMembershipManager.\u003C\u003Ec__DisplayClass13_0.IC7uodw3G7gv1nmh7YcA((object) s)))
              {
                num = 4;
                continue;
              }
              goto label_2;
            case 4:
              result.Add(s.InstanceUid, s.Name);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 != 0 ? 2 : 2;
              continue;
            default:
              goto label_10;
          }
        }
label_3:
        return;
label_9:
        return;
label_10:
        return;
label_2:;
      }));
      return result;
    }

    /// <summary>Синхронизировать данные о пользователе</summary>
    public void Sync(IUser user, Guid authProviderGuid)
    {
      int num1 = 5;
      string message1;
      while (true)
      {
        int num2 = num1;
        IExternalMembershipModuleSettings membershipModuleSettings;
        while (true)
        {
          Guid authProviderGuid1;
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              goto label_8;
            case 3:
              ExternalMembershipManager.ORTOusWl3p0Zwm3xoko(ExternalMembershipManager.LE2dI5WVxWoQhnICEdg(), (object) message1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 != 0 ? 1 : 1;
              continue;
            case 4:
              authProviderGuid1 = authProviderGuid;
              num2 = 2;
              continue;
            case 5:
              num2 = 4;
              continue;
            case 6:
              try
              {
                membershipModuleSettings = this.GetAllSettings().FirstOrDefault<IExternalMembershipModuleSettings>((Func<IExternalMembershipModuleSettings, bool>) (m => m.InstanceUid == authProviderGuid1));
                int num3 = 4;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0)
                  num3 = 2;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_21;
                    case 1:
                      ExternalMembershipManager.UptBZZWQfI3AuCiVQyT(ExternalMembershipManager.dy7masWsmXkYUAa1fvM((object) membershipModuleSettings), (object) user, (object) membershipModuleSettings);
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 == 0 ? 0 : 0;
                      continue;
                    case 2:
                    case 3:
                      goto label_7;
                    case 4:
                      if (membershipModuleSettings == null)
                      {
                        num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d != 0 ? 2 : 1;
                        continue;
                      }
                      goto case 1;
                    default:
                      goto label_18;
                  }
                }
label_21:
                return;
label_18:
                return;
              }
              catch (Exception ex)
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 != 0)
                  num4 = 0;
                string message2;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      ExternalMembershipManager.lZDwMpW5YiRHgatgaiN(ExternalMembershipManager.LE2dI5WVxWoQhnICEdg(), (object) message2, (object) ex);
                      num4 = 2;
                      continue;
                    case 2:
                      goto label_22;
                    default:
                      message2 = EleWise.ELMA.SR.T((string) ExternalMembershipManager.NGC9gkWPOwmbW55yPBt(-979995965 << 4 ^ 1499953040), membershipModuleSettings != null ? ExternalMembershipManager.gkRVkHW8nsT8O26J1rt((object) membershipModuleSettings) : (object) "", (object) authProviderGuid1);
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff != 0 ? 1 : 1;
                      continue;
                  }
                }
label_22:
                throw new Exception(message2, ex);
              }
          }
label_7:
          message1 = (string) ExternalMembershipManager.BYiBqqWd4BVUhuVlgsh((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1820204600 ^ 1820213800), (object) new object[1]
          {
            (object) authProviderGuid1
          });
          num2 = 3;
        }
label_8:
        membershipModuleSettings = (IExternalMembershipModuleSettings) null;
        num1 = 6;
      }
label_4:
      throw new Exception(message1);
    }

    /// <summary>Проверить авторизацию пользователя</summary>
    /// <returns><c>true</c>, если пользователь успешно авторизован</returns>
    public void ValidateUser(UserValidationContext validationContext, Guid authProviderGuid)
    {
      int num1 = 10;
      while (true)
      {
        int num2 = num1;
        string message1;
        IExternalMembershipModuleSettings settings;
        Guid authProviderGuid1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_5;
            case 1:
              goto label_4;
            case 2:
              goto label_10;
            case 3:
              ExternalMembershipManager.ORTOusWl3p0Zwm3xoko((object) Logger.Log, (object) message1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 == 0 ? 8 : 6;
              continue;
            case 4:
              goto label_25;
            case 5:
              settings = (IExternalMembershipModuleSettings) null;
              num2 = 2;
              continue;
            case 6:
              goto label_28;
            case 7:
              if (validationContext != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0 ? 0 : 6;
                continue;
              }
              goto label_20;
            case 8:
              goto label_3;
            case 9:
              authProviderGuid1 = authProviderGuid;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 == 0 ? 3 : 7;
              continue;
            case 10:
              num2 = 9;
              continue;
            default:
              goto label_13;
          }
        }
label_3:
        ExternalMembershipManager.CoRrxFWX4ty6h1CBL2r((object) validationContext, (object) new Exception(message1));
        num1 = 4;
        continue;
label_4:
        message1 = (string) ExternalMembershipManager.BYiBqqWd4BVUhuVlgsh(ExternalMembershipManager.NGC9gkWPOwmbW55yPBt(-550634672 ^ -550656192), (object) new object[1]
        {
          (object) authProviderGuid1
        });
        num1 = 3;
        continue;
label_10:
        try
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          settings = this.GetAllSettings().FirstOrDefault<IExternalMembershipModuleSettings>((Func<IExternalMembershipModuleSettings, bool>) (m => ExternalMembershipManager.\u003C\u003Ec__DisplayClass15_0.AbgnJiw3Fra3tAnByQ8p(ExternalMembershipManager.\u003C\u003Ec__DisplayClass15_0.aZOSiow3TCUVnknlscyG((object) m), authProviderGuid1)));
          int num3 = 2;
          while (true)
          {
            switch (num3)
            {
              case 1:
                ExternalMembershipManager.ouQLt5WG73de2lK6LAL((object) validationContext, ((IExternalMembershipModule) ExternalMembershipManager.dy7masWsmXkYUAa1fvM((object) settings)).ValidateUser(validationContext, settings));
                num3 = 3;
                continue;
              case 2:
                if (settings != null)
                {
                  num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 0 : 1;
                  continue;
                }
                goto label_4;
              case 3:
                goto label_24;
              default:
                goto label_4;
            }
          }
label_24:
          return;
        }
        catch (Exception ex)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0)
            num4 = 3;
          string message2;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_4;
              case 2:
                ((ILogger) ExternalMembershipManager.LE2dI5WVxWoQhnICEdg()).Error((object) message2, ex);
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0 ? 0 : 0;
                continue;
              case 3:
                message2 = (string) ExternalMembershipManager.BYiBqqWd4BVUhuVlgsh(ExternalMembershipManager.NGC9gkWPOwmbW55yPBt(-909559362 ^ -398405015 ^ 562671735), (object) new object[2]
                {
                  settings != null ? ExternalMembershipManager.gkRVkHW8nsT8O26J1rt((object) settings) : (object) "",
                  (object) authProviderGuid1
                });
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0 ? 2 : 0;
                continue;
              default:
                ExternalMembershipManager.CoRrxFWX4ty6h1CBL2r((object) validationContext, (object) new Exception(message2, ex));
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 0 : 1;
                continue;
            }
          }
        }
label_28:
        if (!ExternalMembershipManager.LfGR1MWEifyBMTDp1QB((object) validationContext))
          num1 = 5;
        else
          goto label_16;
      }
label_5:
      return;
label_25:
      return;
label_13:
      return;
label_20:
      return;
label_16:;
    }

    public ExternalMembershipManager()
    {
      ExternalMembershipManager.vskqZ8W94yPRgqQWhIM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool TjM7M6W3mELjEkg7tZR() => ExternalMembershipManager.FCS7C3Wi1w4eqJnHUlh == null;

    internal static ExternalMembershipManager xmJnWAWjx438uwuOjOO() => ExternalMembershipManager.FCS7C3Wi1w4eqJnHUlh;

    internal static bool DDGlW9WNMdSyEApaTGH([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static Guid uYNDWdW0nfcwMnYCoK3() => Guid.NewGuid();

    internal static void ptBE3XWZlOT0MDfUSjQ([In] object obj0, [In] Guid obj1) => ((IExternalMembershipModuleSettings) obj0).InstanceUid = obj1;

    internal static Guid mcNWhfWA9jjEvoIgGmQ([In] object obj0) => ((IExternalMembershipModuleSettings) obj0).InstanceUid;

    internal static object dy7masWsmXkYUAa1fvM([In] object obj0) => (object) ((IExternalMembershipModuleSettings) obj0).Module();

    internal static Guid uL70hGW75VUZ0PRBlM8([In] object obj0) => ((IExternalMembershipModule) obj0).Uid;

    internal static object OmA0i9WW8Do1NNn8TOV([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static object GEjKyiWrPgiQWPlCerK([In] object obj0, [In] bool obj1) => (object) ClassSerializationHelper.SerializeObjectByXml(obj0, obj1);

    internal static void IXDmyeWS0uL3s5SdO3Y([In] object obj0, [In] Guid obj1, [In] object obj2, [In] object obj3) => ((ISettingsManager) obj0).SetString(obj1, (string) obj2, (string) obj3);

    internal static object Wm1EIyWYGpQERlbrb4t() => (object) DataAccessManager.SettingsManager;

    internal static object DkAHESWyGUP5Lsgmujv([In] object obj0) => (object) ((IExternalMembershipModule) obj0).CreateDefaultSettings();

    internal static object LE2dI5WVxWoQhnICEdg() => (object) Logger.Log;

    internal static void ORTOusWl3p0Zwm3xoko([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static bool RlirLjWfCgLtCNYrxDv([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void qLx1WZW4XwBFhFJcQPC([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void VK7vjpWcMdMq6wjdWMi([In] object obj0, [In] Guid obj1, [In] object obj2) => ((ISettingsManager) obj0).RemoveString(obj1, (string) obj2);

    internal static object NGC9gkWPOwmbW55yPBt(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void UptBZZWQfI3AuCiVQyT([In] object obj0, [In] object obj1, [In] object obj2) => ((IExternalMembershipModule) obj0).Sync((IUser) obj1, (IExternalMembershipModuleSettings) obj2);

    internal static object gkRVkHW8nsT8O26J1rt([In] object obj0) => (object) ((IExternalMembershipModuleSettings) obj0).Name;

    internal static void lZDwMpW5YiRHgatgaiN([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object BYiBqqWd4BVUhuVlgsh([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);

    internal static bool LfGR1MWEifyBMTDp1QB([In] object obj0) => ((UserValidationContext) obj0).Authorized;

    internal static void ouQLt5WG73de2lK6LAL([In] object obj0, [In] bool obj1) => ((UserValidationContext) obj0).Authorized = obj1;

    internal static void CoRrxFWX4ty6h1CBL2r([In] object obj0, [In] object obj1) => ((UserValidationContext) obj0).Error = (Exception) obj1;

    internal static void vskqZ8W94yPRgqQWhIM() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}

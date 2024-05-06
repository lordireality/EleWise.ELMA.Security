// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.LocalizationService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Web;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>Загрузка текущей локали пользователя</summary>
  [Service(Type = ComponentType.Web)]
  public class LocalizationService : BaseLocalizationService
  {
    private readonly ILazy<ISessionProvider> sessionProvider;
    private readonly string userLangFieldName;
    private readonly string userTableName;
    private readonly string userIdFieldName;
    /// <summary>Ключ кэширования локали текущего пользователя</summary>
    public const string Path = "CurrentUserLanguage";
    private ICacheService cacheService;
    private static LocalizationService OwBTyrr5BtjmHf2T36U;

    /// <summary>Ctor</summary>
    /// <param name="sessionProvider">Провайдер сессий NHibernate</param>
    /// <param name="runtimeApplication">Среда исполнения приложения</param>
    public LocalizationService(
      ILazy<ISessionProvider> sessionProvider,
      IRuntimeApplication runtimeApplication)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.sessionProvider = sessionProvider;
      this.userLangFieldName = runtimeApplication.TransformationProvider.Dialect.QuoteIfNeeded(LinqUtils.NameOf<EleWise.ELMA.Security.Models.IUser>((Expression<Func<EleWise.ELMA.Security.Models.IUser, object>>) (user => user.Lang)));
      this.userTableName = runtimeApplication.TransformationProvider.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1277472395 ^ -1277471555));
      this.userIdFieldName = runtimeApplication.TransformationProvider.Dialect.QuoteIfNeeded(LinqUtils.NameOf<EleWise.ELMA.Security.Models.IUser>((Expression<Func<EleWise.ELMA.Security.Models.IUser, object>>) (user => (object) user.Id)));
    }

    /// <summary>Управление кэшем</summary>
    public ICacheService CacheService
    {
      get
      {
        int num = 1;
        ICacheService serviceNotNull;
        ICacheService cacheService;
        while (true)
        {
          switch (num)
          {
            case 1:
              cacheService = this.cacheService;
              if (cacheService == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.cacheService = serviceNotNull = Locator.GetServiceNotNull<ICacheService>();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a != 0 ? 1 : 2;
              continue;
          }
        }
label_2:
        return cacheService;
label_6:
        return serviceNotNull;
      }
    }

    /// <summary>Сохранить культуру для текущего пользователя</summary>
    /// <param name="info"></param>
    public override void Save(CultureInfo info)
    {
      int num = 1;
      EleWise.ELMA.Security.IUser user;
      while (true)
      {
        switch (num)
        {
          case 1:
            user = (EleWise.ELMA.Security.IUser) LocalizationService.j9K7ibrXOADFLBu6M1R(LocalizationService.Sn0PbmrGri2wcf9Z962((object) this));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            LocalizationService.IRJyGpr9T93hbqwaAIW((object) this, (object) info, (object) user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public override void Save(CultureInfo info, EleWise.ELMA.Security.IUser user)
    {
      int num = 4;
      EleWise.ELMA.Security.Models.IUser user1;
      string str;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            LocalizationService.bhBFOerhyb4u57aOk1H((object) user1, false);
            num = 2;
            continue;
          case 2:
            LocalizationService.KY9hRYrBlKSUpIu7p9q((object) user1);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 != 0 ? 4 : 6;
            continue;
          case 3:
            if (user1 != null)
            {
              num = 5;
              continue;
            }
            goto label_11;
          case 4:
            user1 = user as EleWise.ELMA.Security.Models.IUser;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a == 0 ? 3 : 3;
            continue;
          case 5:
            LocalizationService.ECt0xArMhXDxsKPhGKF((object) user1, LocalizationService.HQFJUZr1TPeIcIpHOHq((object) info));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 == 0 ? 1 : 0;
            continue;
          case 6:
            str = string.Format((string) LocalizationService.zPGGStrpDrwqm08FQ3t(1848373724 >> 1 ^ 924163030), LocalizationService.zPGGStrpDrwqm08FQ3t(~248518394 ^ -248542641), (object) user1.Id);
            num = 7;
            continue;
          case 7:
            LocalizationService.P7pbXarOGHpjdw0vsji((object) this.CacheService, (object) str);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b != 0 ? 0 : 0;
            continue;
          default:
            goto label_12;
        }
      }
label_2:
      return;
label_12:
      return;
label_11:;
    }

    /// <summary>
    /// Загрузить культуру указанного. Если user == null, то загрузит текущего
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public override CultureInfo Load(EleWise.ELMA.Security.IUser user)
    {
      int num1 = 29;
      LanguageHolder languageHolder1;
      CultureInfo cultureByName;
      while (true)
      {
        int num2 = num1;
        HttpCookie httpCookie;
        EleWise.ELMA.Security.Models.IUser user1;
        CultureInfo cultureInfo;
        string str;
        HttpContext httpContext;
        ISession session;
        long? nullable;
        string key;
        while (true)
        {
          switch (num2)
          {
            case 1:
              LanguageHolder languageHolder2 = new LanguageHolder();
              LocalizationService.oJZiC9rqa3d319x9fRJ((object) languageHolder2, (object) str);
              languageHolder1 = languageHolder2;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 == 0 ? 4 : 10;
              continue;
            case 2:
            case 39:
              key = (string) LocalizationService.H739PIrFDXcvns1OKgO(LocalizationService.zPGGStrpDrwqm08FQ3t(1848373724 >> 1 ^ 924163030), LocalizationService.zPGGStrpDrwqm08FQ3t(1801131332 >> 4 ^ 112579102), (object) (user1 == null ? nullable.Value : user1.Id));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 1 : 18;
              continue;
            case 3:
            case 8:
            case 10:
              this.CacheService.Insert<LanguageHolder>(key, languageHolder1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 != 0 ? 0 : 0;
              continue;
            case 4:
            case 17:
              str = (string) LocalizationService.zcwOnlrThuFGgxRVhZm((object) user1);
              num2 = 35;
              continue;
            case 5:
              str = "";
              num2 = 33;
              continue;
            case 6:
              if (httpCookie == null)
              {
                num2 = 20;
                continue;
              }
              goto case 32;
            case 7:
            case 13:
              if (!string.IsNullOrEmpty(str))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 0 : 1;
                continue;
              }
              goto case 25;
            case 9:
              LocalizationService.KY9hRYrBlKSUpIu7p9q((object) user1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 != 0 ? 8 : 8;
              continue;
            case 11:
              LanguageHolder languageHolder3 = new LanguageHolder();
              LocalizationService.oJZiC9rqa3d319x9fRJ((object) languageHolder3, LocalizationService.HQFJUZr1TPeIcIpHOHq((object) cultureInfo));
              languageHolder1 = languageHolder3;
              num2 = 30;
              continue;
            case 12:
            case 20:
            case 23:
              goto label_10;
            case 14:
              session = (ISession) LocalizationService.pyD4o9rvSVbDFx1Md2T((object) this.sessionProvider.Value, (object) "");
              num2 = 31;
              continue;
            case 15:
              goto label_9;
            case 16:
            case 35:
              if (user1 == null)
                goto case 41;
              else
                goto label_15;
            case 18:
              languageHolder1 = this.CacheService.Get<LanguageHolder>(key);
              num2 = 26;
              continue;
            case 19:
              if (cultureByName == null)
              {
                num2 = 23;
                continue;
              }
              goto label_9;
            case 21:
              ((IQuery) LocalizationService.CZvH9LrJBFPd1oGBrND((object) session, (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(908197830 ^ 908172310) + this.userTableName + (string) LocalizationService.zPGGStrpDrwqm08FQ3t(781628008 - 11982093 ^ 769638073) + this.userLangFieldName + (string) LocalizationService.zPGGStrpDrwqm08FQ3t(-901653144 ^ -901661032) + this.userIdFieldName + (string) LocalizationService.zPGGStrpDrwqm08FQ3t(~-1362653258 ^ 1362629601)))).SetParameter<string>((string) LocalizationService.zPGGStrpDrwqm08FQ3t(19590779 ^ 19565147), (string) LocalizationService.HQFJUZr1TPeIcIpHOHq((object) cultureInfo)).SetParameter<long>((string) LocalizationService.zPGGStrpDrwqm08FQ3t(1690209562 ^ 116876444 ^ 1648986694), nullable.Value).ExecuteUpdate();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 3 : 2;
              continue;
            case 22:
            case 24:
              LocalizationService.ECt0xArMhXDxsKPhGKF((object) user1, LocalizationService.HQFJUZr1TPeIcIpHOHq((object) cultureInfo));
              num2 = 9;
              continue;
            case 25:
              cultureInfo = (CultureInfo) LocalizationService.AhNAWErgiOTISv7eESu();
              num2 = 11;
              continue;
            case 26:
              if (languageHolder1 != null)
              {
                num2 = 38;
                continue;
              }
              goto case 36;
            case 27:
              session = (ISession) null;
              num2 = 5;
              continue;
            case 28:
              nullable = new long?();
              num2 = 27;
              continue;
            case 29:
              user1 = user as EleWise.ELMA.Security.Models.IUser;
              num2 = 28;
              continue;
            case 30:
              if (user1 != null)
              {
                num2 = 24;
                continue;
              }
              goto case 21;
            case 31:
              str = session.CreateSQLQuery((string) LocalizationService.zPGGStrpDrwqm08FQ3t(-17837901 ^ -17845305) + this.userLangFieldName + (string) LocalizationService.zPGGStrpDrwqm08FQ3t(150349507 - 521039768 ^ -370682707) + this.userTableName + (string) LocalizationService.zPGGStrpDrwqm08FQ3t(552500104 ^ 552474654) + this.userIdFieldName + (string) LocalizationService.zPGGStrpDrwqm08FQ3t(--1207559533 ^ 1207535301)).SetParameter<long>((string) LocalizationService.zPGGStrpDrwqm08FQ3t(841533798 << 6 ^ -1976419776), nullable.Value).UniqueResult<string>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 13 : 8;
              continue;
            case 32:
              cultureByName = EleWise.ELMA.SR.GetCultureByName(httpCookie.Value);
              num2 = 19;
              continue;
            case 33:
              if (user1 != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e == 0 ? 9 : 17;
                continue;
              }
              goto case 40;
            case 34:
              httpCookie = (HttpCookie) LocalizationService.BiGU26r2G0ZQbulIlyi(LocalizationService.AZ9YBGrLXV8Bn1AJbkY(LocalizationService.seQBavrn34IFQEVHRad((object) httpContext)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-468111058 ^ -468101868));
              num2 = 6;
              continue;
            case 36:
              if (user1 != null)
              {
                num2 = 7;
                continue;
              }
              goto case 14;
            case 37:
              httpContext = (HttpContext) LocalizationService.LNAxA3refREEBxxcacG();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 == 0 ? 37 : 42;
              continue;
            case 40:
              nullable = ((IAuthenticationService) LocalizationService.Sn0PbmrGri2wcf9Z962((object) this)).GetCurrentUserId() as long?;
              num2 = 16;
              continue;
            case 41:
              if (!nullable.HasValue)
              {
                num2 = 37;
                continue;
              }
              goto case 2;
            case 42:
              if (httpContext == null)
              {
                num2 = 12;
                continue;
              }
              goto case 34;
            default:
              goto label_11;
          }
        }
label_15:
        num1 = 2;
      }
label_9:
      return cultureByName;
label_10:
      return (CultureInfo) LocalizationService.AhNAWErgiOTISv7eESu();
label_11:
      return (CultureInfo) LocalizationService.sOTo8SrIfKAwVpYr187((object) languageHolder1);
    }

    /// <summary>Системная локаль по умолчанию</summary>
    public override CultureInfo DefaultCulture
    {
      get
      {
        int num = 4;
        CultureInfo defaultCulture1;
        CultureInfo defaultCulture;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_10;
            case 2:
              goto label_3;
            case 3:
              defaultCulture = (CultureInfo) LocalizationService.voAgfZrHmlJe0XRUuae();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 != 0 ? 0 : 0;
              continue;
            case 4:
              num = 3;
              continue;
            default:
              if (defaultCulture != null)
              {
                defaultCulture1 = EleWise.ELMA.SR.GetCultureNames().FirstOrDefault<CultureInfo>((Func<CultureInfo, bool>) (c => ((string) LocalizationService.\u003C\u003Ec__DisplayClass13_0.DEmNQpwjkiUElYA5ghb5((object) c)).Equals((string) LocalizationService.\u003C\u003Ec__DisplayClass13_0.DEmNQpwjkiUElYA5ghb5((object) defaultCulture), StringComparison.OrdinalIgnoreCase)));
                if (defaultCulture1 == null)
                {
                  num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 != 0 ? 1 : 1;
                  continue;
                }
                goto label_2;
              }
              else
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af != 0 ? 2 : 0;
                continue;
              }
          }
        }
label_3:
        return (CultureInfo) LocalizationService.UAckq0rz9t3pBtoFhBE();
label_2:
        return defaultCulture1;
label_10:
        return (CultureInfo) LocalizationService.UAckq0rz9t3pBtoFhBE();
      }
    }

    /// <summary>Установить системную локаль по умолчанию</summary>
    /// <param name="name"></param>
    public override void SetDefaultCulture(string name)
    {
      int num = 6;
      CommonSettingsModule service;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            LocalizationService.gF4t9tSKDtG8TAUXcSa((object) name);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 0 : 1;
            continue;
          case 3:
            LocalizationService.QgsWYwSuVq0jqQnR2pm((object) service.Settings, (object) name);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_2;
          case 5:
            if (service != null)
            {
              num = 3;
              continue;
            }
            if (!LocalizationService.VMY7q3SbW7WBtHJZuyP((object) name))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 == 0 ? 0 : 2;
              continue;
            }
            goto label_12;
          case 6:
            service = Locator.GetService<CommonSettingsModule>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 == 0 ? 5 : 5;
            continue;
          default:
            LocalizationService.UHqQJsSw5jOHaluffKQ((object) service);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a == 0 ? 4 : 4;
            continue;
        }
      }
label_7:
      return;
label_2:
      return;
label_12:;
    }

    internal static bool AcJUGGrdtVvCWbYZXx6() => LocalizationService.OwBTyrr5BtjmHf2T36U == null;

    internal static LocalizationService PFkx5srEoOFPDnoZ2Rn() => LocalizationService.OwBTyrr5BtjmHf2T36U;

    internal static object Sn0PbmrGri2wcf9Z962([In] object obj0) => (object) ((BaseLocalizationService) obj0).AuthenticationService;

    internal static object j9K7ibrXOADFLBu6M1R([In] object obj0) => (object) ((IAuthenticationService) obj0).GetCurrentUser();

    internal static void IRJyGpr9T93hbqwaAIW([In] object obj0, [In] object obj1, [In] object obj2) => ((BaseLocalizationService) obj0).Save((CultureInfo) obj1, (EleWise.ELMA.Security.IUser) obj2);

    internal static object HQFJUZr1TPeIcIpHOHq([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static void ECt0xArMhXDxsKPhGKF([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Security.Models.IUser) obj0).Lang = (string) obj1;

    internal static void bhBFOerhyb4u57aOk1H([In] object obj0, bool value) => ((EleWise.ELMA.Security.Models.IUser) obj0).IsSystemLocal = value;

    internal static void KY9hRYrBlKSUpIu7p9q([In] object obj0) => ((IEntity) obj0).Save();

    internal static object zPGGStrpDrwqm08FQ3t(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void P7pbXarOGHpjdw0vsji([In] object obj0, [In] object obj1) => ((ICacheService) obj0).Remove((string) obj1);

    internal static object zcwOnlrThuFGgxRVhZm([In] object obj0) => (object) ((EleWise.ELMA.Security.Models.IUser) obj0).Lang;

    internal static object H739PIrFDXcvns1OKgO([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object pyD4o9rvSVbDFx1Md2T([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static void oJZiC9rqa3d319x9fRJ([In] object obj0, [In] object obj1) => ((LanguageHolder) obj0).Name = (string) obj1;

    internal static object AhNAWErgiOTISv7eESu() => (object) EleWise.ELMA.SR.GetDefaultCulture();

    internal static object CZvH9LrJBFPd1oGBrND([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).CreateSQLQuery((string) obj1);

    internal static object sOTo8SrIfKAwVpYr187([In] object obj0) => (object) ((LanguageHolder) obj0).GetCulture();

    internal static object LNAxA3refREEBxxcacG() => (object) HttpContext.Current;

    internal static object seQBavrn34IFQEVHRad([In] object obj0) => (object) ((HttpContext) obj0).Response;

    internal static object AZ9YBGrLXV8Bn1AJbkY([In] object obj0) => (object) ((HttpResponse) obj0).Cookies;

    internal static object BiGU26r2G0ZQbulIlyi([In] object obj0, [In] object obj1) => (object) ((HttpCookieCollection) obj0).Get((string) obj1);

    internal static object voAgfZrHmlJe0XRUuae() => (object) EleWise.ELMA.SR.GetCultureFromSettings();

    internal static object UAckq0rz9t3pBtoFhBE() => (object) EleWise.ELMA.SR.KeyCultureInfo;

    internal static void QgsWYwSuVq0jqQnR2pm([In] object obj0, [In] object obj1) => ((CommonSettings) obj0).SystemDefaultCultureName = (string) obj1;

    internal static void UHqQJsSw5jOHaluffKQ([In] object obj0) => ((GlobalSettingsModuleBase<CommonSettings>) obj0).SaveSettings();

    internal static bool VMY7q3SbW7WBtHJZuyP([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool gF4t9tSKDtG8TAUXcSa([In] object obj0) => EleWise.ELMA.SR.SaveCultureToSettings((string) obj0);
  }
}

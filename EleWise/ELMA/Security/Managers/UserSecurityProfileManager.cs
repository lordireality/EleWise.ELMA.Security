// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.UserSecurityProfileManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Managers
{
  /// <summary>Менеджер профилей безопасности пользователей</summary>
  public class UserSecurityProfileManager : EntityManager<IUserSecurityProfile, long>
  {
    internal static UserSecurityProfileManager qpHyLbGw4gdEqPErCjK;

    /// <summary>Экземпляр менеджера</summary>
    public static UserSecurityProfileManager Instance => Locator.GetServiceNotNull<UserSecurityProfileManager>();

    /// <summary>Настройки</summary>
    private SecuritySettings settings
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (Locator.GetService<SecuritySettingsModule>() == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 != 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return Locator.GetService<SecuritySettingsModule>().Settings;
label_5:
        return (SecuritySettings) null;
      }
    }

    /// <summary>Интерфейс провайдера преобразования БД</summary>
    public ITransformationProvider TransformationProvider
    {
      get => this.\u003CTransformationProvider\u003Ek__BackingField;
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
              this.\u003CTransformationProvider\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0 ? 0 : 0;
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

    /// <summary>Обработчик событий действий с UserSecurityProfile</summary>
    public IUserSecurityProfileEventHandler UserSecurityProfileEventHandler
    {
      get => this.\u003CUserSecurityProfileEventHandler\u003Ek__BackingField;
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
              this.\u003CUserSecurityProfileEventHandler\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0 ? 0 : 0;
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

    /// <summary>Загрузить профиль</summary>
    /// <param name="user">Пользователь</param>
    public IUserSecurityProfile Load([NotNull] EleWise.ELMA.Security.Models.IUser user)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (user == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(150349507 - 521039768 ^ -370694317));
label_3:
      return this.CreateCriteria().Add((ICriterion) UserSecurityProfileManager.N3lLyhGUL1Z28jLT8sO((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2143851882 - 923330995 ^ 1227764173), (object) user.Id)).UniqueResult<IUserSecurityProfile>();
    }

    /// <summary>Загрузить профиль</summary>
    /// <param name="login">Учетная запись</param>
    public IUserSecurityProfile LoadByUserLogin([NotNull] string login)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (login == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      throw new ArgumentNullException((string) UserSecurityProfileManager.wSI8uRGRs2LksBEi6TO(-1807813747 ^ -1807858995));
label_5:
      return ((ICriteria) UserSecurityProfileManager.iQLxh6Gmq4K6q0sOo1P(UserSecurityProfileManager.aEEXlgGtQw3CgAd7deN(UserSecurityProfileManager.NTFNhDGolLQPIPTRQHY((object) this, (object) null), UserSecurityProfileManager.wSI8uRGRs2LksBEi6TO(1677147940 ^ 1677146860), UserSecurityProfileManager.wSI8uRGRs2LksBEi6TO(-522456341 ^ -522481191), JoinType.InnerJoin), UserSecurityProfileManager.N3lLyhGUL1Z28jLT8sO(UserSecurityProfileManager.wSI8uRGRs2LksBEi6TO(631805505 ^ 631777039), (object) login))).UniqueResult<IUserSecurityProfile>();
    }

    /// <summary>Создать профиль с сохранением в БД</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="password">Пароль</param>
    [Transaction]
    internal virtual IUserSecurityProfile CreateProfile(
      [NotNull] EleWise.ELMA.Security.Models.IUser user,
      string password = null)
    {
      int num1 = 7;
      IUserSecurityProfile userSecurityProfile;
      while (true)
      {
        int num2 = num1;
        SecuritySettings settings;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              goto label_14;
            case 3:
              userSecurityProfile = this.Create();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0 ? 0 : 0;
              continue;
            case 4:
              UserSecurityProfileManager.hcdgd7Ga73qgo7CWZRc((object) userSecurityProfile, (object) EncryptionHelper.GetSha256Hash(password, (string) UserSecurityProfileManager.lVYIO4GDSWp8pOshuEQ((object) userSecurityProfile)));
              num2 = 14;
              continue;
            case 5:
              this.SetForcedChangePassword(userSecurityProfile);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 == 0 ? 4 : 16;
              continue;
            case 6:
              goto label_16;
            case 7:
              if (user != null)
              {
                userSecurityProfile = this.Load(user);
                num2 = 17;
                continue;
              }
              num2 = 6;
              continue;
            case 8:
              goto label_9;
            case 9:
            case 15:
            case 16:
              this.Save(userSecurityProfile);
              num2 = 8;
              continue;
            case 10:
              UserSecurityProfileManager.Se1oplGCQc1yQCATWIW((object) userSecurityProfile, false);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 12 : 11;
              continue;
            case 11:
              if (!UserSecurityProfileManager.XuxWUqGidyIAFoxSekj((object) settings))
              {
                num2 = 9;
                continue;
              }
              goto case 5;
            case 12:
              settings = this.settings;
              num2 = 13;
              continue;
            case 13:
              if (settings == null)
              {
                num2 = 15;
                continue;
              }
              goto case 11;
            case 14:
              userSecurityProfile.LastDateChangePassword = new DateTime?(UserSecurityProfileManager.o9nle7Gx5CWT82wPCAc());
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 == 0 ? 8 : 10;
              continue;
            case 17:
              goto label_19;
            default:
              UserSecurityProfileManager.K5ZOmJG6IF5JjW4Rdnf((object) userSecurityProfile, (object) user);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 1 : 0;
              continue;
          }
        }
label_7:
        UserSecurityProfileManager.dvsgq4GklD6eexOqbJD((object) userSecurityProfile, (object) EncryptionHelper.GenerateSalt());
        num1 = 4;
        continue;
label_19:
        if (userSecurityProfile == null)
          num1 = 3;
        else
          goto label_14;
      }
label_9:
      return userSecurityProfile;
label_14:
      return userSecurityProfile;
label_16:
      throw new ArgumentNullException((string) UserSecurityProfileManager.wSI8uRGRs2LksBEi6TO(-1028265253 << 4 ^ 727629256));
    }

    /// <summary>Сменить пароль</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="password">Пароль</param>
    [Transaction]
    public virtual void PasswordReset([NotNull] EleWise.ELMA.Security.Models.IUser user, string password)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        IUserSecurityProfile userSecurityProfile;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (userSecurityProfile == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 7 : 9;
                continue;
              }
              goto case 4;
            case 2:
              userSecurityProfile = this.Load(user);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 == 0 ? 1 : 0;
              continue;
            case 3:
              if (user != null)
              {
                num2 = 2;
                continue;
              }
              goto label_3;
            case 4:
              userSecurityProfile.Salt = (string) UserSecurityProfileManager.DUNDGIG3S5N7OjmHNZ6(16);
              num2 = 7;
              continue;
            case 5:
              goto label_3;
            case 6:
              this.Save(userSecurityProfile);
              num2 = 8;
              continue;
            case 7:
              UserSecurityProfileManager.hcdgd7Ga73qgo7CWZRc((object) userSecurityProfile, UserSecurityProfileManager.xJvUijGjr1d15TdthJK((object) password, UserSecurityProfileManager.lVYIO4GDSWp8pOshuEQ((object) userSecurityProfile)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 != 0 ? 0 : 0;
              continue;
            case 8:
              goto label_9;
            case 9:
              goto label_6;
            default:
              goto label_14;
          }
        }
label_14:
        userSecurityProfile.LastDateChangePassword = new DateTime?(DateTime.Now);
        num1 = 6;
      }
label_9:
      return;
label_6:
      return;
label_3:
      throw new ArgumentNullException((string) UserSecurityProfileManager.wSI8uRGRs2LksBEi6TO(-2143851882 - 923330995 ^ 1227788443));
    }

    /// <summary>Неудачный вход пользователя в систему</summary>
    /// <param name="user">Пользователь</param>
    [Transaction]
    internal virtual void FailedLogon([NotNull] EleWise.ELMA.Security.Models.IUser user)
    {
      int num1 = 12;
      while (true)
      {
        int num2 = num1;
        IUserSecurityProfile userSecurityProfile1;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_7;
            case 1:
              UserSecurityProfileManager.HR6MkJGsRgDsxAS24hK((object) this, (object) userSecurityProfile1);
              num2 = 2;
              continue;
            case 2:
              this.Save(userSecurityProfile1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 0 : 0;
              continue;
            case 3:
              userSecurityProfile1 = this.Load(user);
              num2 = 9;
              continue;
            case 4:
              goto label_19;
            case 5:
              goto label_16;
            case 6:
              if (UserSecurityProfileManager.QBTwIOGAW6Xoi4dVw09((object) userSecurityProfile1) >= (long) num3)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af == 0 ? 0 : 1;
                continue;
              }
              goto case 2;
            case 7:
              if (UserSecurityProfileManager.uEk9ivGN8fw7tQNfB0i((object) user) != UserStatus.System)
              {
                num2 = 3;
                continue;
              }
              goto label_3;
            case 8:
              num3 = UserSecurityProfileManager.lSyEb4GZtrUPM9f5j9B((object) this.settings);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 == 0 ? 4 : 10;
              continue;
            case 9:
              IUserSecurityProfile userSecurityProfile2 = userSecurityProfile1;
              UserSecurityProfileManager.EVvqHTG0YuXIWJmR4dt((object) userSecurityProfile2, userSecurityProfile2.CountFailedLogon + 1L);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0 ? 1 : 4;
              continue;
            case 10:
              if (num3 > 0)
              {
                num2 = 6;
                continue;
              }
              goto case 2;
            case 11:
              if (UserSecurityProfileManager.uEk9ivGN8fw7tQNfB0i((object) user) != UserStatus.Blocked)
              {
                num2 = 7;
                continue;
              }
              goto label_22;
            case 12:
              if (user != null)
              {
                num2 = 11;
                continue;
              }
              goto label_16;
            default:
              goto label_23;
          }
        }
label_19:
        userSecurityProfile1.DateLastFailedLogon = new DateTime?(DateTime.Now);
        num1 = 8;
      }
label_7:
      return;
label_23:
      return;
label_3:
      return;
label_16:
      throw new ArgumentNullException((string) UserSecurityProfileManager.wSI8uRGRs2LksBEi6TO(-1743015995 ^ -1743011907));
label_22:;
    }

    /// <summary>Запретить авторизацию пользователю</summary>
    /// <param name="userSecurityProfile">Профиль пользователя</param>
    [Transaction]
    [ActionMethod("58e59b2b-fd5b-4f36-a2e2-d48ff5cdcaf7")]
    internal virtual void DisallowLogon(IUserSecurityProfile userSecurityProfile)
    {
      int num = 2;
      EntityActionEventArgs entityActionEventArgs;
      List<EleWise.ELMA.Security.Models.IUser> notifyUsers;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!UserSecurityProfileManager.WetjPdG7cK5Z4uOwpJj((object) this.settings))
            {
              num = 8;
              continue;
            }
            goto case 5;
          case 2:
            UserSecurityProfileManager.Se1oplGCQc1yQCATWIW((object) userSecurityProfile, true);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 == 0 ? 1 : 1;
            continue;
          case 3:
            entityActionEventArgs.ExtendedProperties.Add((string) UserSecurityProfileManager.wSI8uRGRs2LksBEi6TO(4869926 >> 3 ^ 653442), (object) notifyUsers);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 != 0 ? 0 : 0;
            continue;
          case 4:
            notifyUsers = this.settings.NotifyUsers;
            num = 3;
            continue;
          case 5:
            entityActionEventArgs = EntityActionEventArgs.TryCreate((IEntity) null, (IEntity) UserSecurityProfileManager.MM00k2GWUXgmrtRFXLO((object) userSecurityProfile), (string) UserSecurityProfileManager.wSI8uRGRs2LksBEi6TO(2110885667 - -1624984630 ^ -559134745));
            num = 4;
            continue;
          case 6:
            goto label_9;
          case 7:
            UserSecurityProfileManager.hoboFRGYFHRolpImSpw(UserSecurityProfileManager.eWiGHCGSrYOwvZrqpJD((object) this), (object) entityActionEventArgs);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 == 0 ? 6 : 2;
            continue;
          case 8:
            goto label_2;
          default:
            entityActionEventArgs.ExtendedProperties.Add((string) UserSecurityProfileManager.wSI8uRGRs2LksBEi6TO(1687460816 ^ 1687431854), UserSecurityProfileManager.LlwxUcGrFrPDmu2cpkJ((object) userSecurityProfile.User));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b0ccb9922b7d45808781104566fa6031 != 0 ? 3 : 7;
            continue;
        }
      }
label_9:
      return;
label_2:;
    }

    /// <summary>
    /// Разрешить авторизацию пользователям с проверкой периода
    /// </summary>
    /// <param name="period">Период</param>
    [Transaction]
    internal virtual void AllowLogonAllWithCheck(TimeSpan period)
    {
      int num = 6;
      IList<long> ids;
      ICriteria criteria;
      DateTime dateTime1;
      DateTime dateTime2;
      while (true)
      {
        switch (num)
        {
          case 1:
            criteria = (ICriteria) UserSecurityProfileManager.NTFNhDGolLQPIPTRQHY((object) this, (object) null);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d != 0 ? 0 : 0;
            continue;
          case 2:
            criteria.SetProjection((IProjection) Projections.Id());
            num = 7;
            continue;
          case 3:
            this.AllowLogon((IEnumerable<long>) ids);
            num = 8;
            continue;
          case 4:
            UserSecurityProfileManager.iQLxh6Gmq4K6q0sOo1P((object) criteria, (object) Restrictions.Le(z2jc63fLkugS1X8Q9N.tE1kD1vbB(658384612 ^ 658413406), (object) dateTime2));
            num = 2;
            continue;
          case 5:
            dateTime2 = dateTime1.Add(-period);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 1 : 1;
            continue;
          case 6:
            dateTime1 = UserSecurityProfileManager.o9nle7Gx5CWT82wPCAc();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0 ? 5 : 1;
            continue;
          case 7:
            ids = criteria.List<long>();
            num = 3;
            continue;
          case 8:
            goto label_2;
          default:
            criteria.Add((ICriterion) UserSecurityProfileManager.N3lLyhGUL1Z28jLT8sO(UserSecurityProfileManager.wSI8uRGRs2LksBEi6TO(-1608980123 ^ -1609017095), (object) true));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0 ? 1 : 4;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Разрешить авторизацию пользователю</summary>
    /// <param name="userSecurityProfile">Пользователь</param>
    /// <param name="period">Период</param>
    [Transaction]
    internal virtual void AllowLogon([NotNull] IUserSecurityProfile userSecurityProfile, TimeSpan period)
    {
      int num = 9;
      DateTime? dateLastFailedLogon;
      DateTime dateTime1;
      DateTime dateTime2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_14;
          case 1:
            goto label_5;
          case 2:
            goto label_9;
          case 3:
            if (!dateLastFailedLogon.HasValue)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0 ? 2 : 10;
              continue;
            }
            goto case 5;
          case 4:
            if (!(UserSecurityProfileManager.o9nle7Gx5CWT82wPCAc() >= dateTime1))
            {
              num = 2;
              continue;
            }
            goto case 6;
          case 5:
            dateTime2 = dateLastFailedLogon.Value;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d != 0 ? 7 : 7;
            continue;
          case 6:
            this.AllowLogon(userSecurityProfile);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 0 : 0;
            continue;
          case 7:
            dateTime1 = dateTime2.Add(period);
            num = 4;
            continue;
          case 8:
            dateLastFailedLogon = userSecurityProfile.DateLastFailedLogon;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 == 0 ? 3 : 0;
            continue;
          case 9:
            if (userSecurityProfile != null)
            {
              num = 8;
              continue;
            }
            goto label_5;
          case 10:
            goto label_4;
          default:
            goto label_2;
        }
      }
label_14:
      return;
label_9:
      return;
label_4:
      return;
label_2:
      return;
label_5:
      throw new ArgumentNullException((string) UserSecurityProfileManager.wSI8uRGRs2LksBEi6TO(1212037053 ^ -1727812018 ^ -784521193));
    }

    /// <summary>Разрешить авторизацию пользователю</summary>
    /// <param name="user">Пользователь</param>
    [Transaction]
    internal virtual void AllowLogon([NotNull] EleWise.ELMA.Security.Models.IUser user)
    {
      int num = 1;
      IUserSecurityProfile userSecurityProfile;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (user == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 0 : 0;
              continue;
            }
            userSecurityProfile = this.Load(user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 != 0 ? 2 : 1;
            continue;
          case 2:
            this.AllowLogon(userSecurityProfile);
            num = 3;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801309555 ^ -801313547));
    }

    /// <summary>Разрешить авторизацию пользователю</summary>
    /// <param name="userSecurityProfile">Профиль пользователя</param>
    [Transaction]
    [ActionMethod("2635ac67-8011-4f05-9d77-ee701271227a")]
    internal virtual void AllowLogon([NotNull] IUserSecurityProfile userSecurityProfile)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            UserSecurityProfileManager.Se1oplGCQc1yQCATWIW((object) userSecurityProfile, false);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef == 0 ? 3 : 3;
            continue;
          case 2:
            if (userSecurityProfile != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 1 : 1;
              continue;
            }
            goto label_7;
          case 3:
            UserSecurityProfileManager.UWXglKGy5eDUmFTnm8t((object) this, (object) userSecurityProfile);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_7;
          default:
            goto label_2;
        }
      }
label_3:
      return;
label_2:
      return;
label_7:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801309555 ^ -801354391));
    }

    /// <summary>Разрешить авторизацию для указанных идентификаторов</summary>
    /// <param name="ids">Идентификаторы userSecurityProfile. Если null, то разрешить для всех</param>
    [Transaction]
    internal virtual void AllowLogon(IEnumerable<long> ids = null)
    {
      if (ids != null && !ids.Any<long>())
        return;
      string[] columns = new string[3]
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-906676699 ^ -906655815),
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1958138283 - -279956781 ^ -1678227060),
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1711335411 ^ -1711298121)
      };
      object[] values = new object[3]
      {
        (object) Convert.ToInt32(false),
        (object) 0,
        null
      };
      string where = ids != null ? string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1848373724 >> 1 ^ 924142300), (object) this.TransformationProvider.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1848373724 >> 1 ^ 924187962)), (object) ids.ToSeparatedString<long>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(384582979 ^ 384587855))) : "";
      this.TransformationProvider.Update(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1403802000 ^ 1403839454), columns, values, where);
      this.Session.CleanUpCache(typeof (IUserSecurityProfile));
      this.UserSecurityProfileEventHandler.AllowLogon(ids);
    }

    /// <summary>
    /// Сброс счетчика количества неудачных попыток с проверкой периода
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <param name="period">Период</param>
    [Transaction]
    internal virtual void ResetCountFailedLogonWithCheck(EleWise.ELMA.Security.Models.IUser user, TimeSpan period)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        bool flag;
        DateTime? dateLastFailedLogon;
        DateTime dateTime1;
        IUserSecurityProfile userSecurityProfile;
        DateTime dateTime2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_13;
            case 2:
              dateTime1 = dateLastFailedLogon.Value;
              num2 = 5;
              continue;
            case 3:
              if (flag)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e == 0 ? 1 : 0;
                continue;
              }
              goto case 2;
            case 4:
              UserSecurityProfileManager.UWXglKGy5eDUmFTnm8t((object) this, (object) userSecurityProfile);
              num2 = 10;
              continue;
            case 5:
              dateTime2 = dateTime1.Add(period);
              num2 = 6;
              continue;
            case 6:
              if (UserSecurityProfileManager.rhPRhGGlinVTdZaRANE(UserSecurityProfileManager.o9nle7Gx5CWT82wPCAc(), dateTime2))
              {
                num2 = 4;
                continue;
              }
              goto label_3;
            case 7:
              flag = UserSecurityProfileManager.rHXuv2GVPDMDMrmVenq((object) userSecurityProfile);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 != 0 ? 0 : 0;
              continue;
            case 8:
              dateLastFailedLogon = userSecurityProfile.DateLastFailedLogon;
              num2 = 7;
              continue;
            case 9:
              goto label_14;
            case 10:
              goto label_18;
            default:
              if (dateLastFailedLogon.HasValue)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a != 0 ? 3 : 0;
                continue;
              }
              goto label_17;
          }
        }
label_14:
        userSecurityProfile = this.Load(user);
        num1 = 8;
      }
label_13:
      return;
label_18:
      return;
label_3:
      return;
label_17:;
    }

    /// <summary>
    /// Сброс счетчика количества неудачных попыток с проверкой периода
    /// </summary>
    /// <param name="period">Период</param>
    [Transaction]
    internal virtual void ResetCountFailedLogonAllWithCheck(TimeSpan period)
    {
      int num = 4;
      ICriteria criteria;
      DateTime dateTime1;
      DateTime dateTime2;
      IList<long> ids;
      while (true)
      {
        switch (num)
        {
          case 1:
            UserSecurityProfileManager.KIGs5kGQ1Qeq92ujcJY((object) criteria, (object) new IProjection[1]
            {
              (IProjection) UserSecurityProfileManager.oVxe1oGPA2Dk2Xnj5qK()
            });
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 0 : 0;
            continue;
          case 2:
            criteria = (ICriteria) UserSecurityProfileManager.NTFNhDGolLQPIPTRQHY((object) this, (object) null);
            num = 8;
            continue;
          case 3:
            dateTime1 = dateTime2.Add(UserSecurityProfileManager.DxOy6sGfMt4dtrPU3SN(period));
            num = 2;
            continue;
          case 4:
            dateTime2 = UserSecurityProfileManager.o9nle7Gx5CWT82wPCAc();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 != 0 ? 3 : 1;
            continue;
          case 5:
            this.ResetCountFailedLogon((IEnumerable<long>) ids);
            num = 9;
            continue;
          case 6:
            UserSecurityProfileManager.iQLxh6Gmq4K6q0sOo1P((object) criteria, UserSecurityProfileManager.KbUr8mGcK4PIdamJ53f(UserSecurityProfileManager.wSI8uRGRs2LksBEi6TO(711486506 ^ 711515536), (object) dateTime1));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 == 0 ? 1 : 1;
            continue;
          case 7:
            UserSecurityProfileManager.iQLxh6Gmq4K6q0sOo1P((object) criteria, UserSecurityProfileManager.CpVLeMG4kWZDsbSm050(UserSecurityProfileManager.wSI8uRGRs2LksBEi6TO(-757186336 ^ -757140754), (object) 0L));
            num = 6;
            continue;
          case 8:
            criteria.Add((ICriterion) UserSecurityProfileManager.N3lLyhGUL1Z28jLT8sO((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1224834736 ^ 1224855340), (object) false));
            num = 7;
            continue;
          case 9:
            goto label_2;
          default:
            ids = criteria.List<long>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 == 0 ? 3 : 5;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Сброс счетчика количества неудачных попыток</summary>
    /// <param name="user">Пользователь</param>
    [Transaction]
    internal virtual void ResetCountFailedLogon([NotNull] EleWise.ELMA.Security.Models.IUser user)
    {
      int num = 2;
      IUserSecurityProfile userSecurityProfile;
      while (true)
      {
        switch (num)
        {
          case 1:
            userSecurityProfile = this.Load(user);
            num = 3;
            continue;
          case 2:
            if (user != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 == 0 ? 0 : 1;
              continue;
            }
            goto label_3;
          case 3:
            this.ResetCountFailedLogon(userSecurityProfile);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0 ? 0 : 4;
            continue;
          case 4:
            goto label_5;
          default:
            goto label_3;
        }
      }
label_5:
      return;
label_3:
      throw new ArgumentNullException((string) UserSecurityProfileManager.wSI8uRGRs2LksBEi6TO(-845204010 ^ 2052495102 ^ -1211518128));
    }

    /// <summary>Сброс счетчика количества неудачных попыток</summary>
    /// <param name="userSecurityProfile">Профиль пользователя</param>
    [ActionMethod("9b776346-d67c-4e66-93e5-4de53e6846eb")]
    [Transaction]
    internal virtual void ResetCountFailedLogon(IUserSecurityProfile userSecurityProfile)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (userSecurityProfile != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          case 3:
            userSecurityProfile.DateLastFailedLogon = new DateTime?();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 != 0 ? 5 : 5;
            continue;
          case 4:
            goto label_8;
          case 5:
            this.Save(userSecurityProfile);
            num = 4;
            continue;
          default:
            UserSecurityProfileManager.EVvqHTG0YuXIWJmR4dt((object) userSecurityProfile, 0L);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 0 : 3;
            continue;
        }
      }
label_8:
      return;
label_2:
      throw new ArgumentNullException((string) UserSecurityProfileManager.wSI8uRGRs2LksBEi6TO(-819366706 ^ -819346134));
    }

    /// <summary>
    /// Сброс счетчика количества неудачных попыток для всех пользователей
    /// </summary>
    [Transaction]
    internal virtual void ResetCountFailedLogonAllUsers()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.ResetCountFailedLogon();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Сброс счетчика количества неудачных попыток для указанных идентификаторов
    /// </summary>
    /// <param name="ids">Идентификаторы userSecurityProfile. Если null, то сбросить для всех</param>
    [Transaction]
    internal virtual void ResetCountFailedLogon(IEnumerable<long> ids = null)
    {
      if (ids != null && !ids.Any<long>())
        return;
      string[] columns = new string[2]
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-816108091 ^ -816078901),
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-296013529 ^ -295993187)
      };
      object[] values = new object[2]{ (object) 0, null };
      string where = ids != null ? ElmaInExpression.ToString(this.TransformationProvider.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-617657301 ^ -617657857)), (IEnumerable) ids, delimiter: z2jc63fLkugS1X8Q9N.tE1kD1vbB(2110195605 ^ 2110198243)) : "";
      this.TransformationProvider.Update(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1095474805 ^ 155418997 ^ 1208528206), columns, values, where);
      this.Session.CleanUpCache(typeof (IUserSecurityProfile));
      this.UserSecurityProfileEventHandler.ResetCountFailedLogon(ids);
    }

    /// <summary>
    /// Установить флаг принудительного изменения пароля с проверкой периода
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <param name="period">Период</param>
    [Transaction]
    internal virtual void SetForcedChangePasswordWithCheck([NotNull] EleWise.ELMA.Security.Models.IUser user, TimeSpan period)
    {
      int num1 = 5;
      DateTime? dateChangePassword;
      UserSecurityProfileManager securityProfileManager;
      IUserSecurityProfile userSecurityProfile;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_13;
          case 2:
            if (!dateChangePassword.HasValue)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ffcd4dd7277748c4a030e6a2e5886496 == 0 ? 6 : 6;
              continue;
            }
            goto case 3;
          case 3:
            if (dateChangePassword.HasValue)
            {
              num1 = 10;
              continue;
            }
            goto label_18;
          case 4:
            securityProfileManager = this;
            num1 = 7;
            continue;
          case 5:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0 ? 0 : 4;
            continue;
          case 6:
          case 8:
            UserSecurityProfileManager.vr8y5pG81gAPf4xfPps((object) this.SecurityService, (object) user, (object) (Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    securityProfileManager.SetForcedChangePassword(userSecurityProfile);
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 9;
            continue;
          case 7:
            if (user == null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 1 : 1;
              continue;
            }
            userSecurityProfile = this.Load(user);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a == 0 ? 0 : 0;
            continue;
          case 9:
            goto label_8;
          case 10:
            if (UserSecurityProfileManager.rhPRhGGlinVTdZaRANE(UserSecurityProfileManager.o9nle7Gx5CWT82wPCAc(), dateChangePassword.Value.Add(period)))
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 != 0 ? 8 : 6;
              continue;
            }
            goto label_2;
          default:
            dateChangePassword = userSecurityProfile.LastDateChangePassword;
            num1 = 2;
            continue;
        }
      }
label_8:
      return;
label_2:
      return;
label_18:
      return;
label_13:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1403802000 ^ 1403797992));
    }

    /// <summary>
    /// Установить флаг принудительного изменения пароля с проверкой периода
    /// </summary>
    /// <param name="excludedUsersId">Идентификаторы пользователей, для которых не требуется устанавливать флаг</param>
    /// <param name="period">Период</param>
    [Transaction]
    internal virtual void SetForcedChangePasswordWithCheck(
      ICollection<long> excludedUsersId,
      TimeSpan period)
    {
      SqlSubQuery namedSubQuery = this.Session.GetNamedSubQuery(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1820204600 ^ 1820240960));
      namedSubQuery.SetParameter(z2jc63fLkugS1X8Q9N.tE1kD1vbB(908197830 ^ 908191136), (object) new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1841261835 ^ 1841256617)));
      AbstractCriterion expression = NHQueryExtensions.Sql(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1958138283 - -279956781 ^ -1678227150) + namedSubQuery.Sql + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1780597820 ^ 1780567012), namedSubQuery.ParametersValues, namedSubQuery.ParametersTypes);
      DateTime dateTime = DateTime.Now.Add(-period);
      ICriteria criteria = this.CreateCriteria();
      criteria.CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1801131332 >> 4 ^ 112571548), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1100789287 - 1555711667 ^ -454918388));
      criteria.Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1527733619 - 442652394 ^ -1970341517), (object) Guid.Empty));
      criteria.Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(711486506 ^ 711515860), (object) UserStatus.Active));
      criteria.Add((ICriterion) Restrictions.Not((ICriterion) Restrictions.In(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~123928154 ^ -123882819), (ICollection) excludedUsersId)));
      criteria.Add((ICriterion) Restrictions.Not((ICriterion) expression));
      criteria.Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1743015995 ^ -1743053585), (object) false));
      criteria.Add((ICriterion) Restrictions.Or((ICriterion) Restrictions.Le(z2jc63fLkugS1X8Q9N.tE1kD1vbB(841533798 << 6 ^ -1976374570), (object) dateTime), (ICriterion) Restrictions.IsNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1224834736 ^ 1224855014))));
      criteria.SetProjection((IProjection) Projections.Id());
      this.SetForcedChangePassword((IEnumerable<long>) criteria.List<long>());
    }

    /// <summary>Установить флаг принудительного изменения пароля</summary>
    /// <param name="user">Пользователь</param>
    [Transaction]
    internal virtual void SetForcedChangePassword([NotNull] EleWise.ELMA.Security.Models.IUser user)
    {
      int num = 1;
      IUserSecurityProfile userSecurityProfile;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (user != null)
            {
              userSecurityProfile = this.Load(user);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 2 : 2;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 != 0 ? 0 : 0;
            continue;
          case 2:
            this.SetForcedChangePassword(userSecurityProfile);
            num = 3;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return;
label_3:
      throw new ArgumentNullException((string) UserSecurityProfileManager.wSI8uRGRs2LksBEi6TO(-1540570615 - 1746246777 ^ 1008154088));
    }

    /// <summary>Установить флаг принудительного изменения пароля</summary>
    /// <param name="userSecurityProfile">Профиль пользователя</param>
    [ActionMethod("cc9044e1-4e2c-46a6-9ed7-6b42aa14daf7")]
    [Transaction]
    internal virtual void SetForcedChangePassword([NotNull] IUserSecurityProfile userSecurityProfile)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (userSecurityProfile != null)
            {
              if (!UserSecurityProfileManager.gG4bo3GdCWZbXMBVevG(UserSecurityProfileManager.bdvInDG5qLpn8BtAeVC(UserSecurityProfileManager.MM00k2GWUXgmrtRFXLO((object) userSecurityProfile)), Guid.Empty))
              {
                num = 4;
                continue;
              }
              goto case 3;
            }
            else
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af != 0 ? 0 : 0;
              continue;
            }
          case 2:
            this.Save(userSecurityProfile);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 != 0 ? 5 : 5;
            continue;
          case 3:
            if (((EleWise.ELMA.Security.Models.IUser) UserSecurityProfileManager.MM00k2GWUXgmrtRFXLO((object) userSecurityProfile)).AllowChangePassword())
            {
              num = 6;
              continue;
            }
            goto label_2;
          case 4:
            goto label_10;
          case 5:
            goto label_13;
          case 6:
            userSecurityProfile.ForcedChangePassword = true;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 == 0 ? 0 : 2;
            continue;
          default:
            goto label_3;
        }
      }
label_10:
      return;
label_13:
      return;
label_3:
      throw new ArgumentNullException((string) UserSecurityProfileManager.wSI8uRGRs2LksBEi6TO(711486506 ^ 711515598));
label_2:;
    }

    /// <summary>Установить флаг принудительного изменения пароля</summary>
    /// <param name="ids">Идентификаторы userSecurityProfile. Если null то установить для всех</param>
    [Transaction]
    internal virtual void SetForcedChangePassword(IEnumerable<long> ids = null)
    {
      if (ids != null && !ids.Any<long>())
        return;
      string[] columns = new string[1]
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1640694811 << 2 ^ 2027117758)
      };
      object[] values = new object[1]
      {
        (object) Convert.ToInt32(true)
      };
      string where = ids != null ? string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(384582979 ^ 384628593), (object) this.TransformationProvider.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(19590779 ^ 19590063)), (object) ids.ToSeparatedString<long>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1257514304 ^ -1257519156))) : "";
      this.TransformationProvider.Update(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-389167216 ^ -389188130), columns, values, where);
      this.Session.CleanUpCache(typeof (IUserSecurityProfile));
      this.UserSecurityProfileEventHandler.SetForcedChangePassword(ids);
    }

    /// <summary>Сброс флага принудительного изменения пароля</summary>
    /// <param name="user">Пользователь</param>
    [Transaction]
    [ActionMethod("d1ef7b26-1d49-408d-a5c4-f204fca7c132")]
    internal virtual void ResetForcedChangePassword([NotNull] EleWise.ELMA.Security.Models.IUser user)
    {
      int num = 2;
      IUserSecurityProfile userSecurityProfile;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_7;
          case 2:
            if (user == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0 ? 1 : 1;
              continue;
            }
            userSecurityProfile = this.Load(user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_824f4981acd94d56a36ed51865c07d7e != 0 ? 0 : 4;
            continue;
          case 3:
            this.Save(userSecurityProfile);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a != 0 ? 0 : 0;
            continue;
          case 4:
            UserSecurityProfileManager.kuX7UjGEBEfMQ3aj1pZ((object) userSecurityProfile, false);
            num = 3;
            continue;
          default:
            goto label_9;
        }
      }
label_2:
      return;
label_9:
      return;
label_7:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788783669 - 1293477238 ^ 1212710445));
    }

    public UserSecurityProfileManager()
    {
      UserSecurityProfileManager.yvvUOsGGlStXpV1C2Mn();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool MKWWNvGbDR3hutvAmN9() => UserSecurityProfileManager.qpHyLbGw4gdEqPErCjK == null;

    internal static UserSecurityProfileManager CUV99VGKTFomUUmatSV() => UserSecurityProfileManager.qpHyLbGw4gdEqPErCjK;

    internal static object N3lLyhGUL1Z28jLT8sO([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object wSI8uRGRs2LksBEi6TO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object NTFNhDGolLQPIPTRQHY([In] object obj0, [In] object obj1) => (object) ((EntityManager<IUserSecurityProfile, long>) obj0).CreateCriteria((IEntityFilter) obj1);

    internal static object aEEXlgGtQw3CgAd7deN(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] JoinType obj3)
    {
      return (object) ((ICriteria) obj0).CreateAlias((string) obj1, (string) obj2, obj3);
    }

    internal static object iQLxh6Gmq4K6q0sOo1P([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static void K5ZOmJG6IF5JjW4Rdnf([In] object obj0, [In] object obj1) => ((IUserSecurityProfile) obj0).User = (EleWise.ELMA.Security.Models.IUser) obj1;

    internal static void dvsgq4GklD6eexOqbJD([In] object obj0, [In] object obj1) => ((IUserSecurityProfile) obj0).Salt = (string) obj1;

    internal static object lVYIO4GDSWp8pOshuEQ([In] object obj0) => (object) ((IUserSecurityProfile) obj0).Salt;

    internal static void hcdgd7Ga73qgo7CWZRc([In] object obj0, [In] object obj1) => ((IUserSecurityProfile) obj0).Password = (string) obj1;

    internal static DateTime o9nle7Gx5CWT82wPCAc() => DateTime.Now;

    internal static void Se1oplGCQc1yQCATWIW([In] object obj0, bool value) => ((IUserSecurityProfile) obj0).DisallowLogon = value;

    internal static bool XuxWUqGidyIAFoxSekj([In] object obj0) => ((SecuritySettings) obj0).ForcedChangePasswordOnFirstLogon;

    internal static object DUNDGIG3S5N7OjmHNZ6([In] int obj0) => (object) EncryptionHelper.GenerateSalt(obj0);

    internal static object xJvUijGjr1d15TdthJK([In] object obj0, [In] object obj1) => (object) EncryptionHelper.GetSha256Hash((string) obj0, (string) obj1);

    internal static UserStatus uEk9ivGN8fw7tQNfB0i([In] object obj0) => ((EleWise.ELMA.Security.Models.IUser) obj0).Status;

    internal static void EVvqHTG0YuXIWJmR4dt([In] object obj0, long value) => ((IUserSecurityProfile) obj0).CountFailedLogon = value;

    internal static int lSyEb4GZtrUPM9f5j9B([In] object obj0) => ((SecuritySettings) obj0).CountLogonAttempts;

    internal static long QBTwIOGAW6Xoi4dVw09([In] object obj0) => ((IUserSecurityProfile) obj0).CountFailedLogon;

    internal static void HR6MkJGsRgDsxAS24hK([In] object obj0, [In] object obj1) => ((UserSecurityProfileManager) obj0).DisallowLogon((IUserSecurityProfile) obj1);

    internal static bool WetjPdG7cK5Z4uOwpJj([In] object obj0) => ((SecuritySettings) obj0).NotifyBlocking;

    internal static object MM00k2GWUXgmrtRFXLO([In] object obj0) => (object) ((IUserSecurityProfile) obj0).User;

    internal static object LlwxUcGrFrPDmu2cpkJ([In] object obj0) => (object) ((EleWise.ELMA.Security.Models.IUser) obj0).GetShortName();

    internal static object eWiGHCGSrYOwvZrqpJD([In] object obj0) => (object) ((EntityManager<IUserSecurityProfile, long>) obj0).ActionHandler;

    internal static void hoboFRGYFHRolpImSpw([In] object obj0, [In] object obj1) => ((IEntityActionHandler) obj0).ActionExecuted((EntityActionEventArgs) obj1);

    internal static void UWXglKGy5eDUmFTnm8t([In] object obj0, [In] object obj1) => ((UserSecurityProfileManager) obj0).ResetCountFailedLogon((IUserSecurityProfile) obj1);

    internal static bool rHXuv2GVPDMDMrmVenq([In] object obj0) => ((IUserSecurityProfile) obj0).DisallowLogon;

    internal static bool rhPRhGGlinVTdZaRANE([In] DateTime obj0, [In] DateTime obj1) => obj0 >= obj1;

    internal static TimeSpan DxOy6sGfMt4dtrPU3SN([In] TimeSpan obj0) => -obj0;

    internal static object CpVLeMG4kWZDsbSm050([In] object obj0, [In] object obj1) => (object) Restrictions.Gt((string) obj0, obj1);

    internal static object KbUr8mGcK4PIdamJ53f([In] object obj0, [In] object obj1) => (object) Restrictions.Le((string) obj0, obj1);

    internal static object oVxe1oGPA2Dk2Xnj5qK() => (object) Projections.Id();

    internal static object KIGs5kGQ1Qeq92ujcJY([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).SetProjection((IProjection[]) obj1);

    internal static void vr8y5pG81gAPf4xfPps([In] object obj0, [In] object obj1, [In] object obj2) => ((ISecurityService) obj0).RunByUser((EleWise.ELMA.Security.IUser) obj1, (Action) obj2);

    internal static Guid bdvInDG5qLpn8BtAeVC([In] object obj0) => ((EleWise.ELMA.Security.Models.IUser) obj0).AuthProviderGuid;

    internal static bool gG4bo3GdCWZbXMBVevG([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static void kuX7UjGEBEfMQ3aj1pZ([In] object obj0, bool value) => ((IUserSecurityProfile) obj0).ForcedChangePassword = value;

    internal static void yvvUOsGGlStXpV1C2Mn() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}

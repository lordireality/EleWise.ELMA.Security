// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.UserManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Actions;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Hubs.Services;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text.RegularExpressions;
using System.Web;

namespace EleWise.ELMA.Security.Managers
{
  /// <summary>Менеджер пользователей</summary>
  [DeveloperApi(DeveloperApiType.Manager)]
  public class UserManager : EntityManager<EleWise.ELMA.Security.Models.IUser, long>
  {
    [NotNull]
    private readonly ConcurrentDictionary<string, long> _userLoginIdMap;
    public const string PHOTO_FORMATS = "jpg,jpeg,gif,png";
    private static UserManager instance;
    /// <summary>Сервис для работы с хабом ELMA Агента</summary>
    private IAgentHubService agentHubService;
    internal Dictionary<string, List<Pair<string, EleWise.ELMA.Security.Models.IUser>>> changeUserNames;
    internal static UserManager WEc6jcT3vWu87xGdXhr;

    [NotNull]
    public static UserManager Instance
    {
      get
      {
        int num = 1;
        UserManager instance;
        while (true)
        {
          switch (num)
          {
            case 1:
              instance = UserManager.instance;
              if (instance == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return instance;
label_5:
        return UserManager.instance = Locator.GetServiceNotNull<UserManager>();
      }
    }

    private IInternalSecurityService InternalSecurityService => (IInternalSecurityService) UserManager.qVYG5ST7fQOjatUGxTW((object) (ILicensedModuleAssembly) UserManager.M8IImkTsRw9KcjADYMF(UserManager.KYtHXATZgQSLkmauEXT(UserManager.oW5qWlT0IW5Hw1t92Jn()), UserManager.KfHcfVTAUXpbPPS4I2x()));

    private ICacheService CacheService => Locator.GetServiceNotNull<ICacheService>();

    public UserSecurityProfileManager UserSecurityProfileManager
    {
      get => this.\u003CUserSecurityProfileManager\u003Ek__BackingField;
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
              this.\u003CUserSecurityProfileManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 != 0 ? 0 : 0;
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

    /// <summary>Сервис для работы с активными сессиями пользователей</summary>
    public ActiveUserSessionService ActiveUserSessionService
    {
      get => this.\u003CActiveUserSessionService\u003Ek__BackingField;
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
              this.\u003CActiveUserSessionService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 == 0 ? 0 : 0;
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
    /// Менеджер сущности <see cref="!:IPublicClientSession" />
    /// </summary>
    public PublicClientSessionManager PublicClientSessionManager
    {
      get => this.\u003CPublicClientSessionManager\u003Ek__BackingField;
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
              this.\u003CPublicClientSessionManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0 ? 0 : 0;
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
    /// Компонент для получения текущего контекста <see cref="!:HttpContextBase" />
    /// </summary>
    public IHttpContextAccessor HttpContextAccessor
    {
      get => this.\u003CHttpContextAccessor\u003Ek__BackingField;
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
              this.\u003CHttpContextAccessor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 != 0 ? 0 : 0;
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

    private IAgentHubService AgentHubService
    {
      get
      {
        int num = 2;
        IAgentHubService serviceNotNull;
        IAgentHubService agentHubService;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.agentHubService = serviceNotNull = Locator.GetServiceNotNull<IAgentHubService>();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 != 0 ? 0 : 0;
              continue;
            case 2:
              agentHubService = this.agentHubService;
              if (agentHubService == null)
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return agentHubService;
label_6:
        return serviceNotNull;
      }
    }

    /// <summary>
    /// Сохраняет сущность пользователя в базу данных и устанавливает принадлежность указанным группам (удаляя принадлежность остальным группам)
    /// </summary>
    /// <param name="obj">пользователь</param>
    /// <param name="password">Пароль</param>
    /// <param name="newGroups">Список идендификаторов групп, с которыми нужно ассоциировать пользователя</param>
    /// <param name="oldGroupsCondition">Условие для групп, из которых можно удалять (используется для того, чтобы не удалить из групп проектов)</param>
    [Transaction]
    public virtual void SaveUserWithGroups(
      [NotNull] EleWise.ELMA.Security.Models.IUser obj,
      string password,
      IEnumerable<long> newGroups,
      Func<IUserGroup, bool> oldGroupsCondition = null)
    {
      if (obj == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1433051380 + 1051547170 ^ -1810421490));
      IEnumerable<long> source = obj.IsNew() ? (IEnumerable<long>) null : UserGroupManager.Instance.GetGroupsByUser(obj.Id, false);
      if (source != null && newGroups != null)
        UserGroupManager.Instance.FindByIdArray(source.Where<long>((Func<long, bool>) (i =>
        {
          int num = 1;
          long i1;
          while (true)
          {
            switch (num)
            {
              case 1:
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_3;
              default:
                i1 = i;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 != 0 ? 2 : 2;
                continue;
            }
          }
label_3:
          return newGroups.All<long>((Func<long, bool>) (i2 => i2 != i1));
        })).ToArray<long>()).Where<IUserGroup>((Func<IUserGroup, bool>) (g => g != null)).Where<IUserGroup>(oldGroupsCondition ?? (Func<IUserGroup, bool>) (g => true)).ForEach<IUserGroup>((Action<IUserGroup>) (g =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                g.Users.Remove(obj);
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_2;
              default:
                // ISSUE: reference to a compiler-generated method
                UserManager.\u003C\u003Ec__DisplayClass31_0.kWychFwSdhRApp79wrMU((object) g);
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b2b0511a4719412e810dfb29247e1a88 != 0 ? 1 : 2;
                continue;
            }
          }
label_2:;
        }));
      if (newGroups != null)
        UserGroupManager.Instance.FindByIdArray(newGroups.ToArray<long>()).Where<IUserGroup>((Func<IUserGroup, bool>) (g => g != null)).ForEach<IUserGroup>((Action<IUserGroup>) (g =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                g.Users.AddIfNotContains<EleWise.ELMA.Security.Models.IUser>(obj);
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 == 0 ? 0 : 0;
                continue;
              case 2:
                goto label_2;
              default:
                // ISSUE: reference to a compiler-generated method
                UserManager.\u003C\u003Ec__DisplayClass31_0.kWychFwSdhRApp79wrMU((object) g);
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d == 0 ? 2 : 2;
                continue;
            }
          }
label_2:;
        }));
      this.Save(obj, password);
    }

    protected virtual void CheckPhoto([NotNull] EleWise.ELMA.Security.Models.IUser obj)
    {
      int num = 8;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_13;
          case 2:
            goto label_3;
          case 3:
            if (UserManager.zGbuxyTfDSoVKGFKEM0(UserManager.jWvjE4TYRaHFcpbju49(UserManager.jyQ7wRTS15iKr0xfKaH((object) obj)), UserManager.UBHn2aTlQhdtLgmgkow(UserManager.jSH4gDTycwkCxhWdYvg(--353012470 ^ 352998612), UserManager.EZIIhbTVs9C55p0VdK4(UserManager.jSH4gDTycwkCxhWdYvg(552500104 ^ 552510884), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1587467489 ^ 1587464685), UserManager.jSH4gDTycwkCxhWdYvg(-17837901 ^ -17847481)), UserManager.jSH4gDTycwkCxhWdYvg(1013954274 ^ 1013934258)), RegexOptions.IgnoreCase))
            {
              if (UserManager.gY0OJxT4K6Sbr8oAWXH((object) obj.Photo) <= 1048576L)
              {
                num = 4;
                continue;
              }
              break;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 1 : 6;
            continue;
          case 4:
            goto label_10;
          case 5:
            goto label_14;
          case 6:
            UserManager.p9w1whTrBcJDE7myVjx((object) obj, (object) null);
            num = 2;
            continue;
          case 7:
            goto label_6;
          case 8:
            if (obj.Photo == null)
            {
              num = 7;
              continue;
            }
            if (!UserManager.chIkdRTWJQ5qetaV1sf((object) obj.Photo.Name))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 0 : 3;
              continue;
            }
            goto case 9;
          case 9:
            UserManager.p9w1whTrBcJDE7myVjx((object) obj, (object) null);
            num = 5;
            continue;
        }
        UserManager.p9w1whTrBcJDE7myVjx((object) obj, (object) null);
        num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 1 : 1;
      }
label_10:
      return;
label_14:
      return;
label_6:
      return;
label_3:
      throw new Exception(EleWise.ELMA.SR.T((string) UserManager.jSH4gDTycwkCxhWdYvg(-1859356887 ^ -1859344015)));
label_13:
      throw new Exception(EleWise.ELMA.SR.T((string) UserManager.jSH4gDTycwkCxhWdYvg(839394233 ^ 839449899), (object) 1));
    }

    /// <summary>Сохранить пользователя в БД</summary>
    /// <param name="obj">Пользователь системы</param>
    [PublicApiMember]
    public override void Save([NotNull] EleWise.ELMA.Security.Models.IUser obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Save(obj, (string) null, false);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Сохранить пользователя в БД</summary>
    /// <param name="obj">Пользователь системы</param>
    /// <param name="password">Пароль</param>
    [PublicApiMember]
    public void Save([NotNull] EleWise.ELMA.Security.Models.IUser obj, string password)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Save(obj, password, false);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Сохранить пользователя в БД</summary>
    /// <param name="obj">Пользователь системы</param>
    /// <param name="password">Пароль</param>
    /// <param name="saveAsBlocked">Сохранить блокированным</param>
    [PublicApiMember]
    [Transaction]
    public virtual void Save([NotNull] EleWise.ELMA.Security.Models.IUser obj, string password, bool saveAsBlocked)
    {
      int num1 = 14;
      while (true)
      {
        int num2 = num1;
        IEnumerator<KeyValuePair<string, long>> enumerator;
        EleWise.ELMA.Security.Models.IUser obj1;
        UserManager userManager;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (this._userLoginIdMap.Any<KeyValuePair<string, long>>((Func<KeyValuePair<string, long>, bool>) (l => l.Value == obj1.Id)))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 8 : 1;
                continue;
              }
              goto case 24;
            case 2:
              goto label_37;
            case 3:
              this.CheckPhoto(obj1);
              num2 = 19;
              continue;
            case 4:
              UserManager.jODkThTGkyhpS8C8bnd((object) this.PublicClientSessionManager, obj1.Id);
              num2 = 9;
              continue;
            case 5:
              goto label_11;
            case 6:
              if (UserManager.s48xrLTPJJR9Af5Zsqq((object) obj1) != UserStatus.System)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 != 0 ? 20 : 21;
                continue;
              }
              goto case 12;
            case 7:
              UserManager.yK75LMT8VLMt4pZd0Kv((object) obj1, true);
              num2 = 18;
              continue;
            case 8:
              goto label_42;
            case 9:
            case 23:
              ((IUnitOfWorkManager) UserManager.NGaMc3T9kFwJQARqDZx((object) this)).RegisterPostCommitAction((Action) (() =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      userManager.AgentHubService.SendAll<string>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-315619370 - -1325004768 ^ 1009305502), obj1.Id.ToString((IFormatProvider) UserManager.\u003C\u003Ec__DisplayClass35_0.I7uemGwSJgVrnq3k8yAb()));
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = 2;
              continue;
            case 11:
              try
              {
label_31:
                if (UserManager.ulYmTRT52BJsJBnr1Ip((object) enumerator))
                  goto label_29;
                else
                  goto label_32;
label_28:
                KeyValuePair<string, long> current;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_31;
                    case 2:
                      this._userLoginIdMap.TryRemove(current.Key, out long _);
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 1 : 0;
                      continue;
                    case 3:
                      goto label_16;
                    default:
                      goto label_29;
                  }
                }
label_29:
                current = enumerator.Current;
                num4 = 2;
                goto label_28;
label_32:
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b != 0 ? 0 : 3;
                goto label_28;
              }
              finally
              {
                if (enumerator != null)
                {
                  int num5 = 1;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0)
                    num5 = 1;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        UserManager.PnK6r9Td7OMss5iIhgy((object) enumerator);
                        num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_39;
                    }
                  }
                }
label_39:;
              }
            case 12:
              obj1.Lang = EleWise.ELMA.SR.GetDefaultCulture().Name;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0 ? 7 : 7;
              continue;
            case 13:
              obj1 = obj;
              num2 = 22;
              continue;
            case 14:
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0 ? 4 : 13;
              continue;
            case 15:
              if (obj1 == null)
              {
                num2 = 16;
                continue;
              }
              UserManager.e2l6r6Tc2YZKlU1Bi1O((object) this, (object) obj1);
              num2 = 3;
              continue;
            case 16:
              goto label_22;
            case 17:
              UserManager.UserLoginIdMapContextCache.Add((string) UserManager.HFLqG6TXC14JhXq7EdO((object) obj1));
              num2 = 23;
              continue;
            case 18:
              this.UserSecurityProfileManager.CreateProfile(obj1, password);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0 ? 3 : 10;
              continue;
            case 19:
              if (!this.IsNew(obj1))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 != 0 ? 0 : 0;
                continue;
              }
              goto case 6;
            case 20:
              UserManager.xxinYrTEiFObTykUIpW((object) this.ActiveUserSessionService, (object) obj1.Id);
              num2 = 4;
              continue;
            case 21:
              UserManager.Ms7DOhTQLyfihaDKeeB((object) obj1, saveAsBlocked ? UserStatus.Blocked : UserStatus.Active);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 != 0 ? 12 : 2;
              continue;
            case 22:
              userManager = this;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc != 0 ? 6 : 15;
              continue;
            case 24:
label_16:
              if (UserManager.s48xrLTPJJR9Af5Zsqq((object) obj1) == UserStatus.Blocked)
              {
                num2 = 20;
                continue;
              }
              goto label_11;
            default:
              base.Save(obj1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c == 0 ? 1 : 0;
              continue;
          }
        }
label_11:
        this._userLoginIdMap.AddOrUpdate((string) UserManager.HFLqG6TXC14JhXq7EdO((object) obj1), obj1.Id, (Func<string, long, long>) ((s, l) => obj1.Id));
        num1 = 17;
        continue;
label_42:
        enumerator = this._userLoginIdMap.Where<KeyValuePair<string, long>>((Func<KeyValuePair<string, long>, bool>) (l => l.Value == obj1.Id)).GetEnumerator();
        num1 = 11;
      }
label_37:
      return;
label_22:
      throw new ArgumentNullException((string) UserManager.jSH4gDTycwkCxhWdYvg(-817081027 ^ 243500131 ^ -1043394746));
    }

    /// <summary>Можно ли добавлять пользователей в систему</summary>
    /// <returns></returns>
    public bool CanCreateNewUser() => this.CanCreateNewUser(out string _);

    /// <summary>Можно ли добавлять пользователей в систему</summary>
    /// <param name="reason">Причина отказа</param>
    /// <returns></returns>
    public bool CanCreateNewUser(out string reason)
    {
      int num = 2;
      bool newUser;
      while (true)
      {
        switch (num)
        {
          case 1:
            reason = newUser ? "" : EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-624171910 - 757669187 ^ -1381885471));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0 ? 0 : 0;
            continue;
          case 2:
            newUser = UserManager.rwX6aQT1BPZtiIx6lAY((object) this.InternalSecurityService);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 == 0 ? 1 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return newUser;
    }

    /// <summary>Можно ли разблокировать очередного пользователя</summary>
    /// <param name="reason">Причина отказа</param>
    /// <returns></returns>
    public bool CanUnBlockUser(out string reason)
    {
      int num = 2;
      bool flag;
      while (true)
      {
        switch (num)
        {
          case 1:
            reason = !flag ? (string) UserManager.xIcnTaTMxnCVDimgcW0((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788054269 >> 5 ^ -55853698)) : "";
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 0 : 0;
            continue;
          case 2:
            flag = UserManager.rwX6aQT1BPZtiIx6lAY((object) this.InternalSecurityService);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 == 0 ? 1 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return flag;
    }

    /// <summary>
    /// Загрузить пользователя по идентификатору.Если не найдена - вызывается исключение.
    /// </summary>
    /// <param name="id">Идентификатор пользователя</param>
    /// <returns>Пользователь</returns>
    [PublicApiMember]
    public override EleWise.ELMA.Security.Models.IUser Load(long id)
    {
      int num = 7;
      EleWise.ELMA.Security.Models.IUser res;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (UserManager.HFLqG6TXC14JhXq7EdO((object) res) == null)
            {
              num = 5;
              continue;
            }
            goto case 4;
          case 2:
          case 5:
            goto label_7;
          case 3:
            UserManager.UserLoginIdMapContextCache.Add(res.UserName);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 == 0 ? 2 : 2;
            continue;
          case 4:
            this._userLoginIdMap.AddOrUpdate((string) UserManager.HFLqG6TXC14JhXq7EdO((object) res), res.Id, (Func<string, long, long>) ((s, l) => res.Id));
            num = 3;
            continue;
          case 6:
            res = base.Load(id);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a == 0 ? 0 : 0;
            continue;
          case 7:
            num = 6;
            continue;
          default:
            if (UserManager.s48xrLTPJJR9Af5Zsqq((object) res) != UserStatus.Blocked)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e != 0 ? 1 : 0;
              continue;
            }
            goto label_7;
        }
      }
label_7:
      return res;
    }

    protected override EleWise.ELMA.Security.Models.IUser LoadByUid(Guid uid)
    {
      int num1 = 2;
      EleWise.ELMA.Security.Models.IUser res;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 == 0 ? 0 : 1;
              continue;
            case 3:
              this._userLoginIdMap.AddOrUpdate(res.UserName, res.Id, (Func<string, long, long>) ((s, l) => res.Id));
              num2 = 5;
              continue;
            case 4:
              if (res.Status != UserStatus.Blocked)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 0 : 0;
                continue;
              }
              goto label_12;
            case 5:
              UserManager.UserLoginIdMapContextCache.Add((string) UserManager.HFLqG6TXC14JhXq7EdO((object) res));
              num2 = 6;
              continue;
            case 6:
              goto label_12;
            case 7:
              if (res != null)
              {
                num2 = 4;
                continue;
              }
              goto label_12;
            default:
              if (res.UserName != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 == 0 ? 0 : 3;
                continue;
              }
              goto label_12;
          }
        }
label_3:
        res = base.LoadByUid(uid);
        num1 = 7;
      }
label_12:
      return res;
    }

    /// <summary>Загрузить пользователя по идентификатору</summary>
    /// <param name="id">Идентификатор пользователя</param>
    /// <returns></returns>
    [PublicApiMember]
    public override EleWise.ELMA.Security.Models.IUser LoadOrNull(long id)
    {
      int num = 4;
      EleWise.ELMA.Security.Models.IUser res;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._userLoginIdMap.AddOrUpdate((string) UserManager.HFLqG6TXC14JhXq7EdO((object) res), res.Id, (Func<string, long, long>) ((s, l) => res.Id));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            res = base.LoadOrNull(id);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 0 : 5;
            continue;
          case 4:
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0 ? 3 : 0;
            continue;
          case 5:
            if (res != null)
            {
              num = 7;
              continue;
            }
            goto label_2;
          case 6:
            if (res.UserName != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 0 : 1;
              continue;
            }
            goto label_2;
          case 7:
            if (UserManager.s48xrLTPJJR9Af5Zsqq((object) res) != UserStatus.Blocked)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 == 0 ? 5 : 6;
              continue;
            }
            goto label_2;
          default:
            UserManager.UserLoginIdMapContextCache.Add((string) UserManager.HFLqG6TXC14JhXq7EdO((object) res));
            num = 2;
            continue;
        }
      }
label_2:
      return res;
    }

    /// <summary>Блокировать учетную запись пользователя</summary>
    /// <example>
    /// <para>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.PortalApiRoot.SecurityPortalApi.UserSecurityApi.Load(System.Int64)">Как загрузить пользователя</seealso>
    /// </para>
    /// <code>
    /// //загружаем пользователя по идентификатору
    /// var user = PublicAPI.Portal.Security.User.Load(3);
    /// 
    /// //блокируем учетную запись пользователя
    /// PublicAPI.Portal.Security.User.Block(user);
    /// </code>
    /// </example>
    /// <param name="user">Пользователь</param>
    [PublicApiMember]
    [ActionPermission("2C44BA05-91A6-49E4-89C1-84AC5B371B7F")]
    [ActionMethod("baf28d51-cab7-4fd2-9bcb-4a7d44e3ad05")]
    [Transaction]
    public virtual void Block(EleWise.ELMA.Security.Models.IUser user)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        ReplacementManager replacementManager;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_9;
            case 1:
              goto label_3;
            case 2:
              if (user == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            case 3:
              goto label_8;
            case 4:
              goto label_4;
            case 5:
              replacementManager.FindPlannedReplacement((EleWise.ELMA.Security.IUser) null, (EleWise.ELMA.Security.IUser) user, new DateTime?(UserManager.y9D9UoTBQJ811jb8Rit()), new DateTime?()).Each<IReplacement>(new Action<IReplacement>(replacementManager.Complete));
              num2 = 3;
              continue;
            case 6:
              this.Save(user);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 == 0 ? 0 : 0;
              continue;
            default:
              goto label_11;
          }
        }
label_4:
        replacementManager = (ReplacementManager) UserManager.WMVr9pThjyaUaKMUVw0();
        num1 = 5;
        continue;
label_8:
        UserManager.Ms7DOhTQLyfihaDKeeB((object) user, UserStatus.Blocked);
        num1 = 6;
      }
label_9:
      return;
label_3:
      return;
label_11:;
    }

    /// <summary>
    /// Проверка возможности выполнения действия <see cref="M:EleWise.ELMA.Security.Managers.UserManager.Block(EleWise.ELMA.Security.Models.IUser)" />
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <returns><c>true</c>, если можно выполнить действие</returns>
    [ActionCheck("baf28d51-cab7-4fd2-9bcb-4a7d44e3ad05")]
    protected virtual bool CanBlock(EleWise.ELMA.Security.Models.IUser user)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
          case 5:
            goto label_3;
          case 2:
            if (UserManager.s48xrLTPJJR9Af5Zsqq((object) user) != UserStatus.Active)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc != 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          case 4:
            if (user == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0 ? 2 : 3;
              continue;
            }
            goto default;
          case 6:
            goto label_2;
          default:
            if (this.IsNew(user))
            {
              num = 5;
              continue;
            }
            goto case 2;
        }
      }
label_2:
      return UserManager.Lcx1NQTpYuZI4EKEexd(user.Uid, SecurityConstants.AdminUserUid);
label_3:
      return false;
    }

    /// <summary>Разблокировать учетную запись пользователя</summary>
    /// <example>
    /// <para>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.PortalApiRoot.SecurityPortalApi.UserSecurityApi.Load(System.Int64)">Как загрузить пользователя</seealso>
    /// </para>
    /// <code>
    /// //загружаем пользователя по идентификатору
    /// var user = PublicAPI.Portal.Security.User.Load(3);
    /// 
    /// //отменяем блокировку учетной записи пользователя
    /// PublicAPI.Portal.Security.User.Block(user);
    /// </code>
    /// </example>
    /// <param name="user">Пользователь</param>
    [PublicApiMember]
    [Transaction]
    [ActionMethod("90387e19-8ba0-4e47-a7b3-3d690bbe0431")]
    [ActionPermission("2C44BA05-91A6-49E4-89C1-84AC5B371B7F")]
    public virtual void UnBlock(EleWise.ELMA.Security.Models.IUser user)
    {
      int num1 = 1;
      string reason;
      IEnumerator<long> enumerator;
      EleWise.ELMA.Security.Models.IUser user1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 == 0 ? 0 : 0;
            continue;
          case 2:
            UserManager.Ms7DOhTQLyfihaDKeeB((object) user1, UserStatus.Active);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e == 0 ? 2 : 5;
            continue;
          case 3:
            goto label_7;
          case 4:
            goto label_3;
          case 5:
            this.Save(user1);
            num1 = 9;
            continue;
          case 6:
            goto label_25;
          case 7:
            if (user1 == null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 10 : 6;
              continue;
            }
            goto case 8;
          case 8:
            if (this.CanUnBlockUser(out reason))
            {
              ComponentManager.Current.GetExtensionPoints<IUnblockUserExtension>().ForEach<IUnblockUserExtension>((Action<IUnblockUserExtension>) (e =>
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      UserManager.\u003C\u003Ec__DisplayClass44_0.Dy0Bm8wYt1kFN5iHKkfD((object) e, (object) user1);
                      num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc == 0 ? 2 : 0;
              continue;
            }
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0 ? 0 : 4;
            continue;
          case 9:
            enumerator = ((UserGroupManager) UserManager.aAjwRhTTvZfMHR71v0P()).GetGroupsByUser(user1.Id).GetEnumerator();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0 ? 2 : 3;
            continue;
          case 10:
            goto label_17;
          default:
            user1 = user;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0 ? 5 : 7;
            continue;
        }
      }
label_25:
      return;
label_17:
      return;
label_3:
      throw new SecurityException((string) UserManager.ydRYOQTO8LyeaVmdwki(UserManager.jSH4gDTycwkCxhWdYvg(-1859356887 ^ -1859344339), (object) new object[1]
      {
        (object) reason
      }));
label_7:
      try
      {
label_9:
        if (UserManager.ulYmTRT52BJsJBnr1Ip((object) enumerator))
          goto label_11;
        else
          goto label_10;
label_8:
        long current;
        IUserGroup userGroup;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              UserManager.qfdYnfTF7RRdZhVviTH((object) userGroup);
              num3 = 3;
              continue;
            case 2:
              if (userGroup != null)
              {
                num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 1 : 0;
                continue;
              }
              goto label_9;
            case 3:
              goto label_9;
            case 4:
              goto label_11;
            case 5:
              goto label_22;
            default:
              userGroup = ((AbstractNHEntityManager<IUserGroup, long>) UserManager.aAjwRhTTvZfMHR71v0P()).LoadOrNull(current);
              num3 = 2;
              continue;
          }
        }
label_22:
        return;
label_10:
        num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 == 0 ? 5 : 5;
        goto label_8;
label_11:
        current = enumerator.Current;
        num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba == 0)
        {
          num3 = 0;
          goto label_8;
        }
        else
          goto label_8;
      }
      finally
      {
        if (enumerator != null)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 != 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_24;
              default:
                UserManager.PnK6r9Td7OMss5iIhgy((object) enumerator);
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d71fc9ce2bb44da5a16f4d0dfb15cec6 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_24:;
      }
    }

    /// <summary>
    /// Проверка возможности выполнения действия <see cref="M:EleWise.ELMA.Security.Managers.UserManager.UnBlock(EleWise.ELMA.Security.Models.IUser)" />
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <returns><c>true</c>, если можно выполнить действие</returns>
    [ActionCheck("90387e19-8ba0-4e47-a7b3-3d690bbe0431")]
    protected virtual bool CanUnBlock(EleWise.ELMA.Security.Models.IUser user)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.IsNew(user))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            if (user != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 == 0 ? 1 : 0;
              continue;
            }
            goto label_7;
          default:
            goto label_6;
        }
      }
label_6:
      return user.Status == UserStatus.Blocked;
label_7:
      return false;
    }

    /// <summary>Сменить пароль</summary>
    [ActionMethod("0c15db7e-0291-4d60-b225-35ae01eaa90f")]
    [Transaction]
    public virtual void PasswordReset(long userId, string password)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        HttpContextBase httpContextBase;
        EleWise.ELMA.Security.Models.IUser user;
        EleWise.ELMA.Security.Models.IUser currentUser;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_15;
            case 1:
              httpContextBase = this.HttpContextAccessor.Current();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 == 0 ? 3 : 0;
              continue;
            case 2:
              UserManager.WvKYngTgMeHwUA8FsYt((object) ((HttpCookieCollection) UserManager.xTHhwnTqvjIXO9MRunV(UserManager.j941nMTveUQvHScZVi8((object) httpContextBase))).Get((string) UserManager.jSH4gDTycwkCxhWdYvg(84189367 + 1997579375 ^ 2081779252)), DateTime.MinValue);
              num2 = 10;
              continue;
            case 3:
              currentUser = this.GetCurrentUser();
              num2 = 9;
              continue;
            case 4:
              this.UserSecurityProfileManager.PasswordReset(user, password);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 != 0 ? 1 : 1;
              continue;
            case 5:
              goto label_14;
            case 6:
              if (userId == currentUser.Id)
              {
                num2 = 2;
                continue;
              }
              goto label_6;
            case 7:
              if (currentUser == null)
              {
                num2 = 8;
                continue;
              }
              goto case 6;
            case 8:
              goto label_3;
            case 9:
              if (httpContextBase == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0 ? 0 : 0;
                continue;
              }
              goto case 7;
            case 10:
              goto label_17;
            default:
              goto label_18;
          }
        }
label_14:
        user = this.LoadOrNull(userId);
        num1 = 4;
      }
label_15:
      return;
label_3:
      return;
label_17:
      return;
label_18:
      return;
label_6:;
    }

    /// <summary>Загрузить пользователя по логину - паролю</summary>
    /// <param name="login">Логин</param>
    /// <param name="password">Пароль</param>
    /// <returns>Модель пользователя или <c>null</c>, если не найдено соответствия</returns>
    public EleWise.ELMA.Security.Models.IUser Login(string login, string password)
    {
      int num1 = 7;
      IUserSecurityProfile userSecurityProfile;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_13;
            case 2:
              goto label_14;
            case 3:
              goto label_9;
            case 4:
              goto label_11;
            case 5:
              goto label_6;
            case 6:
              if (userSecurityProfile == null)
              {
                num2 = 5;
                continue;
              }
              if (userSecurityProfile.Salt == null)
              {
                num2 = 4;
                continue;
              }
              if (UserManager.YNtYebTLwS4L0NSMlAP(UserManager.x2EUDhTewxtaBpbQb0S((object) userSecurityProfile), UserManager.m2HWv8TnxJjrFNZ6yvD((object) password, (object) userSecurityProfile.Salt)))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0 ? 0 : 0;
                continue;
              }
              goto label_9;
            case 7:
              userSecurityProfile = this.UserSecurityProfileManager.LoadByUserLogin(login);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 != 0 ? 6 : 0;
              continue;
            default:
              goto label_10;
          }
        }
label_11:
        if (userSecurityProfile.Password.SlowEquals((string) UserManager.Bfd1A6TJm2BkvE1vgu3((object) password)))
          num1 = 2;
        else
          goto label_13;
      }
label_6:
      return (EleWise.ELMA.Security.Models.IUser) null;
label_9:
      return (EleWise.ELMA.Security.Models.IUser) null;
label_10:
      return (EleWise.ELMA.Security.Models.IUser) UserManager.UM3TuOTIdUjjFfKhyyG((object) userSecurityProfile);
label_13:
      return (EleWise.ELMA.Security.Models.IUser) null;
label_14:
      return (EleWise.ELMA.Security.Models.IUser) UserManager.UM3TuOTIdUjjFfKhyyG((object) userSecurityProfile);
    }

    /// <summary>Загрузить пользователя по логину</summary>
    /// <example>
    /// <code>
    /// //userLogin - логин пользователя которого требуется загрузить
    /// 
    /// var user = PublicAPI.Portal.Security.User.LoadByLogin(userLogin);
    /// </code>
    /// </example>
    /// <param name="login">Логин учетной записи</param>
    /// <returns>Пользователь или <c>null</c>, если не найдено соответствия</returns>
    [PublicApiMember]
    public EleWise.ELMA.Security.Models.IUser LoadByLogin(string login)
    {
      int num1 = 3;
      UserManager userManager;
      string login1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              login1 = login;
              num2 = 4;
              continue;
            case 2:
              userManager = this;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8b591865919f4fd588ab82ccbce064f2 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_5;
            case 4:
              if (UserManager.chIkdRTWJQ5qetaV1sf((object) login1))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_302109734225462aa09af77e95ca4ce8 == 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            default:
              goto label_6;
          }
        }
label_5:
        num1 = 2;
      }
label_6:
      return (EleWise.ELMA.Security.Models.IUser) null;
label_7:
      return ContextVars.GetOrAdd<EleWise.ELMA.Security.Models.IUser>((string) UserManager.utWSI4T2LjQjiDaWTKD(UserManager.jSH4gDTycwkCxhWdYvg(-1331070742 ^ -1331058764), (object) login1), (Func<EleWise.ELMA.Security.Models.IUser>) (() =>
      {
        int num3 = 3;
        long id;
        long? nullable;
        while (true)
        {
          int num4 = num3;
          ICriteria criteria;
          while (true)
          {
            switch (num4)
            {
              case 1:
                try
                {
                  nullable = criteria.UniqueResult<long?>();
                  int num5 = 0;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 == 0)
                    num5 = 0;
                  switch (num5)
                  {
                    default:
                      goto label_5;
                  }
                }
                catch (NonUniqueResultException ex)
                {
                  int num6 = 0;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 != 0)
                    num6 = 0;
                  switch (num6)
                  {
                    default:
                      throw new UserNameAlreadyExistsException(login1);
                  }
                }
              case 2:
                if (userManager._userLoginIdMap.TryGetValue(login1, out id))
                {
                  num4 = 7;
                  continue;
                }
                goto label_4;
              case 3:
                goto label_7;
              case 4:
                nullable = new long?();
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 1 : 0;
                continue;
              case 5:
                goto label_19;
              case 6:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                UserManager.\u003C\u003Ec__DisplayClass48_0.R6t3aZwYjqQetBKsJh9w(UserManager.\u003C\u003Ec__DisplayClass48_0.Rdrc6MwY3xeTetBGlGJV(UserManager.\u003C\u003Ec__DisplayClass48_0.ITkGyGwYiRwybabpD0K5((object) criteria, UserManager.\u003C\u003Ec__DisplayClass48_0.G47J0cwYCroJPOdqAAKK((object) Restrictions.Eq((string) UserManager.\u003C\u003Ec__DisplayClass48_0.b0OYIgwYxWOpMSvh9M0v(2110195605 ^ 2110254731), (object) login1))), (object) new IProjection[1]
                {
                  (IProjection) Projections.Id()
                }), true);
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 4 : 0;
                continue;
              case 7:
                goto label_3;
              case 8:
label_5:
                if (!nullable.HasValue)
                {
                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 0 : 0;
                  continue;
                }
                goto label_19;
              default:
                goto label_20;
            }
          }
label_4:
          // ISSUE: reference to a compiler-generated method
          criteria = (ICriteria) UserManager.\u003C\u003Ec__DisplayClass48_0.pZnqkgwYaHyEPJ59oj0C((object) userManager, (object) null);
          num3 = 6;
          continue;
label_7:
          if (userManager._userLoginIdMap.ContainsKey(login1))
            num3 = 2;
          else
            goto label_4;
        }
label_3:
        return userManager.Load(id);
label_19:
        return userManager.Load(nullable.Value);
label_20:
        return (EleWise.ELMA.Security.Models.IUser) null;
      }));
    }

    /// <summary>
    /// Назначить пользователя на указанную должность. Существующие должности пользователя остаются.
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <param name="organizationItem">Должность, на которую нужно назначить</param>
    [PublicApiMember]
    [PublicApiNodeId("OrganizationItemSecurityApi")]
    public virtual void Appoint(EleWise.ELMA.Security.Models.IUser user, IOrganizationItem organizationItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Appoint(user, new IOrganizationItem[1]
            {
              organizationItem
            });
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a == 0 ? 0 : 0;
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
    /// Назначить пользователя на указанные должности. Существующие должности пользователя остаются.
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <param name="organizationItems">Должности, на которые нужно назначить</param>
    [PublicApiNodeId("OrganizationItemSecurityApi")]
    [Transaction]
    [PublicApiMember]
    public virtual void Appoint(EleWise.ELMA.Security.Models.IUser user, params IOrganizationItem[] organizationItems)
    {
      int num = 10;
      int index;
      IOrganizationItem organizationItem;
      IOrganizationItem[] organizationItemArray;
      while (true)
      {
        switch (num)
        {
          case 1:
            index = 0;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0 ? 12 : 4;
            continue;
          case 2:
            organizationItem.User = user;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e != 0 ? 6 : 0;
            continue;
          case 3:
            if (user.OrganizationGroups.Contains(organizationItem))
            {
              num = 13;
              continue;
            }
            goto case 16;
          case 4:
            if (organizationItem.ItemType == OrganizationItemType.EmployeeGroup)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 != 0 ? 3 : 3;
              continue;
            }
            goto case 6;
          case 5:
            goto label_22;
          case 6:
          case 14:
          case 19:
            ++index;
            num = 15;
            continue;
          case 7:
            if (!user.OrganizationItems.Contains(organizationItem))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 17 : 4;
              continue;
            }
            goto case 2;
          case 8:
            organizationItem.Users.Add(user);
            num = 14;
            continue;
          case 9:
            if (organizationItems != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d == 0 ? 0 : 0;
              continue;
            }
            goto label_17;
          case 10:
            UserManager.z9m9aZTH0f4C2O3xHRm((object) user, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(658384612 ^ 658388636));
            num = 9;
            continue;
          case 11:
          case 13:
            if (organizationItem.Users.Contains(user))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0 ? 12 : 19;
              continue;
            }
            goto case 8;
          case 12:
          case 15:
            if (index >= organizationItemArray.Length)
            {
              num = 5;
              continue;
            }
            goto case 18;
          case 16:
            user.OrganizationGroups.Add(organizationItem);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 3 : 11;
            continue;
          case 17:
            user.OrganizationItems.Add(organizationItem);
            num = 2;
            continue;
          case 18:
            organizationItem = organizationItemArray[index];
            num = 20;
            continue;
          case 20:
            if (organizationItem.ItemType == OrganizationItemType.Position)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 == 0 ? 0 : 7;
              continue;
            }
            goto case 4;
          default:
            organizationItemArray = organizationItems;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec != 0 ? 0 : 1;
            continue;
        }
      }
label_22:
      return;
label_17:;
    }

    /// <summary>
    /// Назначить пользователя на указанные должности с удалением с прежних должностей.
    /// </summary>
    /// <example>
    /// <para>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.PortalApiRoot.SecurityPortalApi.UserSecurityApi.Load(System.Int64)">Как загрузить пользователя</seealso>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.PortalApiRoot.SecurityPortalApi.OrganizationItemSecurityApi.Load(System.Int64)">Как загрузить элемент оргструктуры</seealso>
    /// </para>
    /// <code>
    /// //загружаем пользователя по идентификатору
    /// var user = PublicAPI.Portal.Security.User.Load(3);
    /// //загружаем должности по идентификаторам и добавляем их в список
    /// <![CDATA[var orgItemList = new List<IOrganizationItem>();]]>
    /// orgItemList.Add(PublicAPI.Portal.Security.OrganizationItem.Load(3));
    /// orgItemList.Add(PublicAPI.Portal.Security.OrganizationItem.Load(4));
    /// 
    /// //назначаем пользователя на должности
    /// PublicAPI.Portal.Security.OrganizationItem.SetAppointments(user, orgItemList);
    /// </code>
    /// </example>
    /// <param name="user">Пользователь</param>
    /// <param name="organizationItems">Должности, на которые нужно назначить</param>
    [PublicApiMember]
    [Transaction]
    [PublicApiNodeId("OrganizationItemSecurityApi")]
    public virtual void SetAppointments(
      EleWise.ELMA.Security.Models.IUser user,
      IEnumerable<IOrganizationItem> organizationItems)
    {
      Contract.ArgumentNotNull((object) user, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1744916777 - 891549337 ^ 853363432));
      foreach (IOrganizationItem organizationItem in (IEnumerable<IOrganizationItem>) user.OrganizationItems)
        organizationItem.User = (EleWise.ELMA.Security.Models.IUser) null;
      user.OrganizationItems.Clear();
      foreach (IOrganizationItem organizationGroup in (IEnumerable<IOrganizationItem>) user.OrganizationGroups)
      {
        if (organizationGroup.Users.Contains(user))
          organizationGroup.Users.Remove(user);
      }
      user.OrganizationGroups.Clear();
      if (organizationItems != null)
      {
        foreach (IOrganizationItem organizationItem in organizationItems)
        {
          if (organizationItem.ItemType == OrganizationItemType.Position)
          {
            user.OrganizationItems.Add(organizationItem);
            organizationItem.User = user;
          }
          else if (organizationItem.ItemType == OrganizationItemType.EmployeeGroup)
          {
            user.OrganizationGroups.Add(organizationItem);
            organizationItem.Users.Add(user);
          }
        }
      }
      this.Save(user);
    }

    public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
    {
      int num1 = 39;
      while (true)
      {
        int num2 = num1;
        List<long> longList1;
        IUserFilter userFilter1;
        AbstractCriterion abstractCriterion;
        ITransformationProvider serviceNotNull1;
        SqlSubQuery sqlSubQuery1;
        SqlSubQuery sqlSubQuery2;
        EleWise.ELMA.Security.Models.IUser currentUser1;
        while (true)
        {
          List<long> longList2;
          EleWise.ELMA.Security.Models.IUser currentUser2;
          ITransformationProvider serviceNotNull2;
          ITransformationProvider serviceNotNull3;
          SqlSubQuery sqlSubQuery3;
          ITransformationProvider serviceNotNull4;
          string str;
          List<long> longList3;
          List<Worker>.Enumerator enumerator;
          SqlSubQuery sqlSubQuery4;
          object obj1;
          switch (num2)
          {
            case 1:
              longList1 = new List<long>();
              num2 = 29;
              continue;
            case 2:
              serviceNotNull4 = Locator.GetServiceNotNull<ITransformationProvider>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 != 0 ? 23 : 64;
              continue;
            case 3:
              UserManager.g5QAIxFwm4UXfxf2OQf((object) criteria, UserManager.N523wFFyDC7j4tIInTA((object) string.Format((string) UserManager.jSH4gDTycwkCxhWdYvg(1687460816 ^ 1687452332), (object) serviceNotNull2.Dialect.QuoteIfNeeded((string) UserManager.jSH4gDTycwkCxhWdYvg(2110195605 ^ 2110194241)), UserManager.zEKxXMF6QcUDLR8htdM((object) sqlSubQuery2)), UserManager.g4f2XCFSVlWuaYoYL9j((object) sqlSubQuery2), UserManager.qDIS5IFYw2olxvKmO5I((object) sqlSubQuery2)));
              num2 = 37;
              continue;
            case 4:
              UserManager.RxNuXLTzdGiRnmvef7L((object) this, (object) criteria, (object) filter);
              num2 = 6;
              continue;
            case 5:
              criteria.CreateAlias((string) UserManager.jSH4gDTycwkCxhWdYvg(-296013529 ^ -295965501), (string) UserManager.jSH4gDTycwkCxhWdYvg(-1536327508 ^ -1536342484), JoinType.LeftOuterJoin);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 == 0 ? 10 : 54;
              continue;
            case 6:
            case 42:
              goto label_49;
            case 7:
            case 51:
              UserManager.g5QAIxFwm4UXfxf2OQf((object) criteria, UserManager.iMOI0vF3qGlDcIItSO1(UserManager.NobeAdFjTyirTydc5Ki((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-909559362 ^ -398405015 ^ 562629131), (object) userFilter1.OrganizationItemIds), UserManager.NobeAdFjTyirTydc5Ki(UserManager.jSH4gDTycwkCxhWdYvg(-1324692970 << 3 ^ -2007584422), (object) userFilter1.OrganizationItemIds)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 == 0 ? 32 : 19;
              continue;
            case 8:
              if (UserManager.OWOpZyFuxJeWa4fCd6u((object) longList1) != 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 56 : 27;
                continue;
              }
              goto case 24;
            case 9:
              goto label_109;
            case 10:
              goto label_13;
            case 11:
            case 23:
            case 52:
              if (!UserManager.NoCEiXFfGWIX91bZe2U((object) userFilter1))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 == 0 ? 0 : 0;
                continue;
              }
              goto case 55;
            case 12:
              if (userFilter1.OrganizationItemIds.Count <= 0)
              {
                num2 = 28;
                continue;
              }
              goto case 58;
            case 13:
              serviceNotNull1 = Locator.GetServiceNotNull<ITransformationProvider>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 18 : 33;
              continue;
            case 14:
            case 47:
              if (UserManager.hnmK6YFaITDEftxWxek((object) userFilter1) == OrganizationItemFindMode.ByItem)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 == 0 ? 46 : 48;
                continue;
              }
              goto case 28;
            case 15:
              serviceNotNull3 = Locator.GetServiceNotNull<ITransformationProvider>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 != 0 ? 27 : 23;
              continue;
            case 16:
            case 46:
              if (UserManager.dZNViQFb7BpFvBE56c1((object) userFilter1) == null)
              {
                num2 = 41;
                continue;
              }
              goto case 58;
            case 17:
              goto label_83;
            case 18:
              UserManager.g5QAIxFwm4UXfxf2OQf((object) criteria, UserManager.M4YlgeFcKmIh0eVSvqJ((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1458233619 ^ 1458176857)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0 ? 36 : 43;
              continue;
            case 19:
            case 56:
              goto label_10;
            case 20:
              try
              {
label_65:
                if (enumerator.MoveNext())
                  goto label_75;
                else
                  goto label_66;
label_52:
                Worker current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                    case 3:
                    case 8:
                    case 14:
                    case 17:
                    case 21:
                      goto label_65;
                    case 2:
                      longList2.Add(current.WorkerId);
                      num3 = 17;
                      continue;
                    case 5:
                      longList3.Add(UserManager.WK5tYiFsmbiVDOQMeI8((object) current));
                      num3 = 8;
                      continue;
                    case 6:
                      if (!longList3.Contains(UserManager.WK5tYiFsmbiVDOQMeI8((object) current)))
                      {
                        num3 = 5;
                        continue;
                      }
                      goto label_65;
                    case 7:
                      if (UserManager.WK5tYiFsmbiVDOQMeI8((object) current) <= 0L)
                      {
                        num3 = 4;
                        continue;
                      }
                      goto case 18;
                    case 9:
                      if (longList1.Contains(UserManager.WK5tYiFsmbiVDOQMeI8((object) current)))
                      {
                        num3 = 21;
                        continue;
                      }
                      goto case 16;
                    case 10:
                    case 11:
                      if (!(UserManager.sPYOLQF04IMu7uMOfEn((object) current) == UserManager.aILsnWF7xRiKEwIF5PZ()))
                      {
                        num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 19 : 7;
                        continue;
                      }
                      goto case 7;
                    case 12:
                      goto label_105;
                    case 13:
                      if (UserManager.WK5tYiFsmbiVDOQMeI8((object) current) <= 0L)
                      {
                        num3 = 10;
                        continue;
                      }
                      goto case 6;
                    case 15:
                      goto label_75;
                    case 16:
                      longList1.Add(UserManager.WK5tYiFsmbiVDOQMeI8((object) current));
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 == 0 ? 1 : 0;
                      continue;
                    case 18:
                      if (!longList2.Contains(UserManager.WK5tYiFsmbiVDOQMeI8((object) current)))
                      {
                        num3 = 2;
                        continue;
                      }
                      goto label_65;
                    case 20:
                      if (UserManager.Lqk0EMFArY6Gq44MyZn(UserManager.sPYOLQF04IMu7uMOfEn((object) current), UserManager.rskoo9FZLk165Keeapc()))
                      {
                        num3 = 13;
                        continue;
                      }
                      goto case 10;
                    case 22:
                      if (current.WorkerId <= 0L)
                      {
                        num3 = 3;
                        continue;
                      }
                      goto case 9;
                    default:
                      if (!UserManager.Lqk0EMFArY6Gq44MyZn(UserManager.sPYOLQF04IMu7uMOfEn((object) current), UserDTO.UID))
                      {
                        num3 = 14;
                        continue;
                      }
                      goto case 22;
                  }
                }
label_66:
                num3 = 12;
                goto label_52;
label_75:
                current = enumerator.Current;
                num3 = 20;
                goto label_52;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 21:
              currentUser2 = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 57 : 20;
              continue;
            case 22:
              if (userFilter1 != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 34 : 31;
                continue;
              }
              goto label_3;
            case 24:
              criteria.Add((ICriterion) abstractCriterion);
              num2 = 52;
              continue;
            case 25:
              goto label_35;
            case 26:
            case 37:
              if (!userFilter1.ShowOnlySubordinateAndSelf)
              {
                num2 = 42;
                continue;
              }
              goto case 21;
            case 27:
              UserManager.g5QAIxFwm4UXfxf2OQf((object) criteria, UserManager.N523wFFyDC7j4tIInTA(UserManager.GdOJVUF82mMPc2LBpnP(UserManager.jSH4gDTycwkCxhWdYvg(-1212789817 - 1827404527 ^ 1254798306), UserManager.D2RgaFFoh9bM9e3USiU(UserManager.MCJ58SFtgoqawPdWhAD((object) serviceNotNull3), UserManager.jSH4gDTycwkCxhWdYvg(-696756495 ^ -696757467)), (object) sqlSubQuery3.Sql, (object) currentUser2.Id), UserManager.g4f2XCFSVlWuaYoYL9j((object) sqlSubQuery3), UserManager.qDIS5IFYw2olxvKmO5I((object) sqlSubQuery3)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 4 : 4;
              continue;
            case 28:
            case 32:
            case 53:
            case 62:
              if (userFilter1.Workers == null)
                goto case 11;
              else
                goto label_85;
            case 29:
              enumerator = userFilter1.Workers.GetEnumerator();
              num2 = 20;
              continue;
            case 30:
              if (UserManager.McZPmtFNLNvHHgbKQiR((object) userFilter1.Workers) <= 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 == 0 ? 16 : 23;
                continue;
              }
              goto case 50;
            case 31:
              currentUser1 = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
              num2 = 17;
              continue;
            case 33:
              if (UserManager.dZNViQFb7BpFvBE56c1((object) userFilter1) == null)
              {
                num2 = 63;
                continue;
              }
              obj1 = UserManager.j8CvcqFUNQ8VniEgCQO((object) serviceNotNull1, UserManager.jSH4gDTycwkCxhWdYvg(-296013529 ^ -295972567), (object) ((IEntity<long>) UserManager.dZNViQFb7BpFvBE56c1((object) userFilter1)).Id.ToString());
              goto label_104;
            case 34:
              if (userFilter1.UserIds == null)
              {
                num2 = 16;
                continue;
              }
              goto case 35;
            case 35:
              if (UserManager.OWOpZyFuxJeWa4fCd6u((object) userFilter1.UserIds) > 0)
              {
                num2 = 49;
                continue;
              }
              goto case 16;
            case 36:
              goto label_99;
            case 38:
              if (!(filter is IUserFilter userFilter2))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 == 0 ? 58 : 61;
                continue;
              }
              break;
            case 39:
              UserManager.RxNuXLTzdGiRnmvef7L((object) this, (object) criteria, (object) filter);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 != 0 ? 31 : 38;
              continue;
            case 40:
label_105:
              SqlSubQuery namedSubQuery = ((ISession) UserManager.xDqYA7FRVjvOKGJN8Oi((object) this)).GetNamedSubQuery((string) UserManager.jSH4gDTycwkCxhWdYvg(--180540780 ^ 180499604));
              object name = UserManager.jSH4gDTycwkCxhWdYvg(1658561670 << 4 ^ 767208002);
              object vals;
              if (UserManager.OWOpZyFuxJeWa4fCd6u((object) longList2) <= 0)
              {
                vals = (object) new long[1];
                vals[0] = (object) -1L;
              }
              else
                vals = UserManager.JxJYjvFWbm5DXEskOIZ((object) longList2);
              SqlSubQuery sqlSubQuery5 = namedSubQuery.SetParameterList((string) name, (ICollection) vals);
              object obj2 = UserManager.jSH4gDTycwkCxhWdYvg(-110921701 >> 6 ^ -1740844);
              object obj3;
              if (UserManager.OWOpZyFuxJeWa4fCd6u((object) longList3) <= 0)
              {
                obj3 = (object) new long[1];
                obj3[0] = (object) -1L;
              }
              else
                obj3 = UserManager.JxJYjvFWbm5DXEskOIZ((object) longList3);
              sqlSubQuery4 = (SqlSubQuery) UserManager.JPxfGvFrbolejiwNwnE((object) sqlSubQuery5, obj2, obj3);
              num2 = 2;
              continue;
            case 41:
              if (userFilter1.OrganizationItemIds != null)
              {
                num2 = 12;
                continue;
              }
              goto case 28;
            case 43:
              if (!UserManager.ErAjlpFPxhsEKHaLEFf((object) userFilter1))
              {
                num2 = 26;
                continue;
              }
              goto case 31;
            case 44:
              serviceNotNull2 = Locator.GetServiceNotNull<ITransformationProvider>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 3 : 1;
              continue;
            case 45:
              sqlSubQuery1 = (SqlSubQuery) UserManager.MydSbeFmpj3byp688bY(UserManager.xDqYA7FRVjvOKGJN8Oi((object) this), (object) string.Format((string) UserManager.jSH4gDTycwkCxhWdYvg(-468111058 ^ -468070116), (object) str, UserManager.D2RgaFFoh9bM9e3USiU((object) serviceNotNull1.Dialect, UserManager.jSH4gDTycwkCxhWdYvg(44166125 ^ 44114481)), (object) ((Dialect) UserManager.MCJ58SFtgoqawPdWhAD((object) serviceNotNull1)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1028265253 << 4 ^ 727606438)), UserManager.D2RgaFFoh9bM9e3USiU(UserManager.MCJ58SFtgoqawPdWhAD((object) serviceNotNull1), UserManager.jSH4gDTycwkCxhWdYvg(1940240517 ^ 974551502 ^ 1236518019)), UserManager.D2RgaFFoh9bM9e3USiU(UserManager.MCJ58SFtgoqawPdWhAD((object) serviceNotNull1), UserManager.jSH4gDTycwkCxhWdYvg(-517128429 ^ -517129529)), UserManager.D2RgaFFoh9bM9e3USiU(UserManager.MCJ58SFtgoqawPdWhAD((object) serviceNotNull1), UserManager.jSH4gDTycwkCxhWdYvg(1007654939 ^ 1007669391)), UserManager.D2RgaFFoh9bM9e3USiU((object) serviceNotNull1.Dialect, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2086891181 ^ 2086890497))));
              num2 = 10;
              continue;
            case 48:
              UserManager.mTyFtDFx3QhTxl0fcCA((object) criteria, (object) CriteriaSpecification.DistinctRootEntity);
              num2 = 5;
              continue;
            case 49:
              UserManager.g5QAIxFwm4UXfxf2OQf((object) criteria, (object) Restrictions.In((string) UserManager.jSH4gDTycwkCxhWdYvg(1780597820 ^ 1780597224), (ICollection) userFilter1.UserIds));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef != 0 ? 10 : 46;
              continue;
            case 50:
              longList3 = new List<long>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60e828321ba24272818e085dc04abb44 != 0 ? 59 : 43;
              continue;
            case 54:
              UserManager.kAWeZVFCTloytT72phS((object) criteria, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788054269 >> 5 ^ -55868924), UserManager.jSH4gDTycwkCxhWdYvg(1687460816 ^ 1687452164), JoinType.LeftOuterJoin);
              num2 = 25;
              continue;
            case 55:
              if (userFilter1.ShowOnlyReplacement)
              {
                num2 = 18;
                continue;
              }
              goto case 43;
            case 57:
              sqlSubQuery3 = ((SqlSubQuery) UserManager.MydSbeFmpj3byp688bY(UserManager.xDqYA7FRVjvOKGJN8Oi((object) this), UserManager.jSH4gDTycwkCxhWdYvg(928696104 ^ 928654660))).SetParameter((string) UserManager.jSH4gDTycwkCxhWdYvg(-347045778 ^ -347020370), (object) currentUser2.Id);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f2b6ed45fbb4f44ac8a075741cd00ef != 0 ? 3 : 15;
              continue;
            case 58:
              if (userFilter1.OrganizationItemFindMode != OrganizationItemFindMode.ByTree)
              {
                num2 = 14;
                continue;
              }
              goto case 13;
            case 59:
              longList2 = new List<long>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 == 0 ? 1 : 1;
              continue;
            case 60:
              goto label_3;
            case 61:
              userFilter2 = InterfaceActivator.Create<IUserFilter>();
              break;
            case 63:
              obj1 = (object) serviceNotNull1.TableFunction(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1587467489 ^ 1587415817), (string) UserManager.owunR6FKaF2dCvF3Pdx((object) serviceNotNull1.Dialect, (object) userFilter1.OrganizationItemIds.ToSeparatedString<long>((string) UserManager.jSH4gDTycwkCxhWdYvg(1458233619 ^ 1458240543))));
              goto label_104;
            case 64:
              abstractCriterion = (AbstractCriterion) UserManager.N523wFFyDC7j4tIInTA((object) string.Format((string) UserManager.jSH4gDTycwkCxhWdYvg(-1702973981 - 773209001 ^ 1818792774), (object) ((Dialect) UserManager.MCJ58SFtgoqawPdWhAD((object) serviceNotNull4)).QuoteIfNeeded((string) UserManager.jSH4gDTycwkCxhWdYvg(-1640694811 << 2 ^ 2027153984)), UserManager.zEKxXMF6QcUDLR8htdM((object) sqlSubQuery4)), UserManager.g4f2XCFSVlWuaYoYL9j((object) sqlSubQuery4), UserManager.qDIS5IFYw2olxvKmO5I((object) sqlSubQuery4));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 == 0 ? 8 : 8;
              continue;
            default:
              goto label_24;
          }
          userFilter1 = userFilter2;
          num2 = 22;
          continue;
label_104:
          str = (string) obj1;
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 == 0 ? 45 : 15;
        }
label_3:
        UserManager.g5QAIxFwm4UXfxf2OQf((object) criteria, (object) Restrictions.Not((ICriterion) UserManager.SiVoG6FiehGO5wdso7x(UserManager.jSH4gDTycwkCxhWdYvg(1820204600 ^ 1820204004), (object) UserStatus.System)));
        num1 = 9;
        continue;
label_10:
        UserManager.g5QAIxFwm4UXfxf2OQf((object) criteria, (object) Restrictions.Or((ICriterion) abstractCriterion, (ICriterion) UserManager.EdS61PFl9HMZ9Yd4Hmh(UserManager.tbgEB7FV72YPGO4MoqL(UserManager.jSH4gDTycwkCxhWdYvg(554338340 ^ 554339824)), (object) longList1)));
        num1 = 11;
        continue;
label_13:
        UserManager.g5QAIxFwm4UXfxf2OQf((object) criteria, UserManager.Sg2oJfFDYK6dLgfw9Ho(UserManager.QG2ZxCFkSI66up0mGbO(UserManager.jSH4gDTycwkCxhWdYvg(4869926 >> 3 ^ 632984), UserManager.D2RgaFFoh9bM9e3USiU(UserManager.MCJ58SFtgoqawPdWhAD((object) serviceNotNull1), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(2016571091 >> 5 ^ 63018658)), UserManager.zEKxXMF6QcUDLR8htdM((object) sqlSubQuery1))));
        num1 = 62;
        continue;
label_24:
        UserManager.g5QAIxFwm4UXfxf2OQf((object) criteria, UserManager.KMW6FfF4sqgduASlB6o(UserManager.SiVoG6FiehGO5wdso7x(UserManager.jSH4gDTycwkCxhWdYvg(-1489118656 ^ 643054122 ^ -2123766346), (object) UserStatus.Blocked)));
        num1 = 55;
        continue;
label_35:
        if (UserManager.dZNViQFb7BpFvBE56c1((object) userFilter1) == null)
        {
          num1 = 7;
          continue;
        }
        goto label_99;
label_49:
        this.SetupYearlyBirthDate(criteria, UserManager.fD80eDF5nBlJofItpkb((object) userFilter1));
        num1 = 60;
        continue;
label_83:
        sqlSubQuery2 = (SqlSubQuery) UserManager.udcGoMFQaWveMBLMnrh(UserManager.MydSbeFmpj3byp688bY(UserManager.xDqYA7FRVjvOKGJN8Oi((object) this), UserManager.jSH4gDTycwkCxhWdYvg(928696104 ^ 928654660)), UserManager.jSH4gDTycwkCxhWdYvg(-1254421137 >> 4 ^ -78392554), (object) currentUser1.Id);
        num1 = 44;
        continue;
label_85:
        num1 = 30;
        continue;
label_99:
        UserManager.g5QAIxFwm4UXfxf2OQf((object) criteria, UserManager.iMOI0vF3qGlDcIItSO1(UserManager.SiVoG6FiehGO5wdso7x(UserManager.jSH4gDTycwkCxhWdYvg(781628008 - 11982093 ^ 769604743), (object) ((IEntity<long>) UserManager.dZNViQFb7BpFvBE56c1((object) userFilter1)).Id), UserManager.SiVoG6FiehGO5wdso7x(UserManager.jSH4gDTycwkCxhWdYvg(-1277802350 ^ -1277777544), (object) ((IEntity<long>) UserManager.dZNViQFb7BpFvBE56c1((object) userFilter1)).Id)));
        num1 = 53;
      }
label_109:;
    }

    private void SetupYearlyBirthDate(ICriteria criteria, DateTimeRange range)
    {
      int num1 = 13;
      while (true)
      {
        int num2 = num1;
        DateTime? nullable;
        DateTime dateTime;
        int day1;
        Disjunction disjunction;
        int month1;
        int month2;
        int day2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 26:
              if (month1 >= month2)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed == 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 3:
              disjunction.Add((ICriterion) UserManager.mCjiOCFXLFkYqfIM4Ln(UserManager.mCjiOCFXLFkYqfIM4Ln((object) Restrictions.Conjunction(), UserManager.T9MMtCFMOuMBUTCruii(UserManager.ecuq4oFEbdwlS0ioVZl(UserManager.jSH4gDTycwkCxhWdYvg(-1640694811 << 2 ^ 2027097100), (object) NHibernateUtil.Int32, (object) new IProjection[1]
              {
                (IProjection) UserManager.tbgEB7FV72YPGO4MoqL(UserManager.jSH4gDTycwkCxhWdYvg(-169284490 ^ -169340976))
              }), (object) month1)), (object) Restrictions.Lt((IProjection) UserManager.ecuq4oFEbdwlS0ioVZl(UserManager.jSH4gDTycwkCxhWdYvg(334323849 << 5 ^ 2108486328), (object) NHibernateUtil.Int32, (object) new IProjection[1]
              {
                (IProjection) UserManager.tbgEB7FV72YPGO4MoqL(UserManager.jSH4gDTycwkCxhWdYvg(868767899 ^ 868793149))
              }), (object) month2)));
              num2 = 2;
              continue;
            case 4:
              day1 = dateTime.Day;
              num2 = 19;
              continue;
            case 5:
              UserManager.mCjiOCFXLFkYqfIM4Ln((object) disjunction.Add((ICriterion) UserManager.T9MMtCFMOuMBUTCruii(UserManager.ecuq4oFEbdwlS0ioVZl(UserManager.jSH4gDTycwkCxhWdYvg(-1751467293 ^ -1751492229), (object) NHibernateUtil.Int32, (object) new IProjection[1]
              {
                (IProjection) UserManager.tbgEB7FV72YPGO4MoqL(UserManager.jSH4gDTycwkCxhWdYvg(1100789287 - 1555711667 ^ -454914862))
              }), (object) month1)), UserManager.GvNwqZFhGZPgrgABwCQ(UserManager.ecuq4oFEbdwlS0ioVZl(UserManager.jSH4gDTycwkCxhWdYvg(-1640694811 << 2 ^ 2027097100), (object) NHibernateUtil.Int32, (object) new IProjection[1]
              {
                (IProjection) UserManager.tbgEB7FV72YPGO4MoqL((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(841533798 << 6 ^ -1976387034))
              }), (object) month2));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 6 : 7;
              continue;
            case 6:
              month1 = dateTime.Month;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 == 0 ? 3 : 10;
              continue;
            case 8:
              goto label_18;
            case 9:
              goto label_9;
            case 10:
              nullable = range.To;
              num2 = 28;
              continue;
            case 11:
              dateTime = nullable.Value;
              num2 = 20;
              continue;
            case 12:
              if (!nullable.HasValue)
              {
                num2 = 8;
                continue;
              }
              goto case 24;
            case 13:
              nullable = range.From;
              num2 = 12;
              continue;
            case 14:
              if (month1 <= month2)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 != 0 ? 1 : 1;
                continue;
              }
              goto case 5;
            case 15:
              dateTime = nullable.Value;
              num2 = 6;
              continue;
            case 16:
              nullable = range.From;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af == 0 ? 3 : 18;
              continue;
            case 17:
              if (nullable.HasValue)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 14 : 16;
                continue;
              }
              goto label_15;
            case 18:
              goto label_20;
            case 19:
              goto label_33;
            case 20:
              month2 = dateTime.Month;
              num2 = 23;
              continue;
            case 21:
              day2 = dateTime.Day;
              num2 = 25;
              continue;
            case 22:
              UserManager.mCjiOCFXLFkYqfIM4Ln((object) disjunction, (object) ((Junction) UserManager.veuWZqF1aIeqlVlrmZZ()).Add((ICriterion) Restrictions.Eq(Projections.SqlFunction((string) UserManager.jSH4gDTycwkCxhWdYvg(552500104 ^ 552507408), (IType) NHibernateUtil.Int32, (IProjection) Projections.Property((string) UserManager.jSH4gDTycwkCxhWdYvg(-1976147292 - 421656521 ^ 1897171325))), (object) month2)).Add((ICriterion) Restrictions.Le(Projections.SqlFunction((string) UserManager.jSH4gDTycwkCxhWdYvg(1053060681 ^ 1053068789), (IType) NHibernateUtil.Int32, (IProjection) UserManager.tbgEB7FV72YPGO4MoqL(UserManager.jSH4gDTycwkCxhWdYvg(-1536327508 ^ -1536335094))), (object) day1)));
              num2 = 14;
              continue;
            case 23:
              goto label_7;
            case 24:
              nullable = range.To;
              num2 = 17;
              continue;
            case 25:
              nullable = range.From;
              num2 = 15;
              continue;
            case 27:
              UserManager.mCjiOCFXLFkYqfIM4Ln((object) disjunction, UserManager.mCjiOCFXLFkYqfIM4Ln(UserManager.mCjiOCFXLFkYqfIM4Ln((object) Restrictions.Conjunction(), UserManager.sPNEV7FGKhxXc2je5Me(UserManager.ecuq4oFEbdwlS0ioVZl((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1820204600 ^ 1820261792), (object) NHibernateUtil.Int32, (object) new IProjection[1]
              {
                (IProjection) Projections.Property((string) UserManager.jSH4gDTycwkCxhWdYvg(-1457346863 ^ -1457371785))
              }), (object) month1)), UserManager.KvZy81F9JDuhDMyNNTM(UserManager.ecuq4oFEbdwlS0ioVZl(UserManager.jSH4gDTycwkCxhWdYvg(-1702973981 - 773209001 ^ 1818792326), (object) NHibernateUtil.Int32, (object) new IProjection[1]
              {
                (IProjection) UserManager.tbgEB7FV72YPGO4MoqL(UserManager.jSH4gDTycwkCxhWdYvg(-1424960806 ^ -1425002116))
              }), (object) day2)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 == 0 ? 22 : 22;
              continue;
            case 28:
              dateTime = nullable.Value;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0 ? 4 : 0;
              continue;
            default:
              UserManager.g5QAIxFwm4UXfxf2OQf((object) criteria, (object) disjunction);
              num2 = 9;
              continue;
          }
        }
label_7:
        disjunction = (Disjunction) UserManager.oeDVvyFdmjBC1HXhR64();
        num1 = 27;
        continue;
label_20:
        dateTime = nullable.Value;
        num1 = 21;
        continue;
label_33:
        nullable = range.To;
        num1 = 11;
      }
label_18:
      return;
label_9:
      return;
label_15:;
    }

    /// <summary>
    /// Проверить, является ли один пользователь начальником другого
    /// </summary>
    /// <param name="cheifUser">Начальник</param>
    /// <param name="subordinateUser">Подчиненный</param>
    /// <returns><c>true</c> если один является начальником другого</returns>
    [PublicApiMember]
    public bool IsSubordinateUser([NotNull] EleWise.ELMA.Security.Models.IUser cheifUser, [NotNull] EleWise.ELMA.Security.Models.IUser subordinateUser)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (cheifUser.Id != subordinateUser.Id)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            goto label_6;
          case 3:
            if (subordinateUser != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 == 0 ? 0 : 1;
              continue;
            }
            goto label_9;
          case 4:
            if (cheifUser != null)
            {
              num = 3;
              continue;
            }
            goto label_6;
          case 5:
            goto label_9;
          default:
            goto label_4;
        }
      }
label_4:
      return UserManager.k9QYaHFOfS6bAp4WMc2(UserManager.si3L0vFpG6HLoR4aAFu((object) ((IQuery) UserManager.EkyLbSFB0vVecJEha9q((object) this.Session, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1007654939 ^ 1007647717))).SetParameter<long>((string) UserManager.jSH4gDTycwkCxhWdYvg(-1310136491 - -570921450 ^ -739214445), cheifUser.Id).SetParameter<long>((string) UserManager.jSH4gDTycwkCxhWdYvg(384582979 ^ 384565693), subordinateUser.Id).CleanUpCache(false))) > 0;
label_5:
      return false;
label_6:
      throw new ArgumentNullException((string) UserManager.jSH4gDTycwkCxhWdYvg(384582979 ^ 384607877));
label_9:
      throw new ArgumentNullException((string) UserManager.jSH4gDTycwkCxhWdYvg(-629935560 ^ -1103494022 ^ 1682511262));
    }

    /// <summary>
    /// Проверяет, есть ли в группе сотрудников подчиненные пользователя
    /// </summary>
    /// <param name="cheifUser">Начальник</param>
    /// <param name="subordinateUsers">Группа</param>
    /// <returns><c>true</c> если в группе есть подчиненные</returns>
    [PublicApiMember]
    public bool IsSubordinateUsers([NotNull] EleWise.ELMA.Security.Models.IUser cheifUser, [NotNull] IEnumerable<EleWise.ELMA.Security.Models.IUser> subordinateUsers)
    {
      if (cheifUser == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~123928154 ^ -123870621));
      if (subordinateUsers == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-757186336 ^ -757160912));
      EleWise.ELMA.Security.Models.IUser[] array = subordinateUsers.Where<EleWise.ELMA.Security.Models.IUser>((Func<EleWise.ELMA.Security.Models.IUser, bool>) (u => u.Id != cheifUser.Id)).ToArray<EleWise.ELMA.Security.Models.IUser>();
      return array.Length != 0 && Convert.ToInt32(this.Session.CreateSQLQuery(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1527733619 - 442652394 ^ -1970360489)).SetParameter<long>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--353012470 ^ 353011802), cheifUser.Id).SetParameterList(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1940240517 ^ 974551502 ^ 1236477081), (IEnumerable) array).CleanUpCache(false).UniqueResult()) > 0;
    }

    /// <summary>Проверяет, есть ли начальник у пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <returns><c>true</c> если у пользователя есть начальник</returns>
    [PublicApiMember]
    public bool HasChiefForUser([NotNull] EleWise.ELMA.Security.Models.IUser user)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (user != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      throw new ArgumentNullException((string) UserManager.jSH4gDTycwkCxhWdYvg(~123928154 ^ -123924003));
label_5:
      return UserManager.k9QYaHFOfS6bAp4WMc2(UserManager.si3L0vFpG6HLoR4aAFu(UserManager.eu5N1oFTte59R1ttZG2((object) ((IQuery) UserManager.EkyLbSFB0vVecJEha9q(UserManager.xDqYA7FRVjvOKGJN8Oi((object) this), UserManager.jSH4gDTycwkCxhWdYvg(-1277802350 ^ -1277776536))).SetParameter<long>((string) UserManager.jSH4gDTycwkCxhWdYvg(711486506 ^ 711462890), user.Id), false))) > 0;
    }

    /// <summary>Получить начальников пользователя</summary>
    /// <example>
    /// <para>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.PortalApiRoot.SecurityPortalApi.UserSecurityApi.Load(System.Int64)">Как загрузить пользователя</seealso>
    /// </para>
    /// <code>
    /// //загружаем пользователя по идентификатору
    /// var user = PublicAPI.Portal.Security.User.Load(3);
    /// 
    /// //получаем список начальников пользователя
    /// var userList = PublicAPI.Portal.Security.OrganizationItem.GetChiefByUser(user);
    /// 
    /// //userList - полученный список начальников пользователя
    /// </code>
    /// </example>
    /// <param name="user">Пользователь</param>
    /// <returns>Список начальников пользователя</returns>
    [PublicApiNodeId("OrganizationItemSecurityApi")]
    [PublicApiMember]
    public IEnumerable<EleWise.ELMA.Security.Models.IUser> GetChiefByUser([NotNull] EleWise.ELMA.Security.Models.IUser user)
    {
      if (user == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2008710664 - -232311158 ^ -1776395498));
      SqlSubQuery sqlSubQuery = this.Session.CreateSQLSubQuery(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1257514304 ^ -1257554932)).SetParameter(z2jc63fLkugS1X8Q9N.tE1kD1vbB(839394233 ^ 839401593), (object) user.Id);
      ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
      return (IEnumerable<EleWise.ELMA.Security.Models.IUser>) this.CreateCriteria().Add((ICriterion) Expression.Sql(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1458233619 ^ 1458177673) + serviceNotNull.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1028265253 << 4 ^ 727623780)) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1587467489 ^ 1587426127) + sqlSubQuery.Sql + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-624171910 - 757669187 ^ -1381873425), sqlSubQuery.ParametersValues, sqlSubQuery.ParametersTypes)).List<EleWise.ELMA.Security.Models.IUser>();
    }

    /// <summary>Проверяет, есть ли подчиненные у пользователя</summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public bool HaveSubordinatesForUser([NotNull] EleWise.ELMA.Security.Models.IUser user)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (user == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-94240706 ^ -94236602));
label_5:
      return UserManager.yNfLqyFFBRVbN1tWiCe((object) this, user.Id);
    }

    /// <summary>Получить подчиненных пользователя</summary>
    /// <example>
    /// <para>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.PortalApiRoot.SecurityPortalApi.UserSecurityApi.Load(System.Int64)">Как загрузить пользователя</seealso>
    /// </para>
    /// <code>
    /// //загружаем пользователя по идентификатору
    /// var user = PublicAPI.Portal.Security.User.Load(3);
    /// 
    /// //получаем список подчиненных пользователя
    /// var userList = PublicAPI.Portal.Security.OrganizationItem.GetSubordinateByUser(user);
    /// 
    /// //userList - полученный список подчиненных пользователя
    /// </code>
    /// </example>
    /// <param name="user">Пользователь</param>
    /// <returns>Список подчиненных пользователя</returns>
    [PublicApiMember]
    [PublicApiNodeId("OrganizationItemSecurityApi")]
    public IEnumerable<EleWise.ELMA.Security.Models.IUser> GetSubordinateByUser(
      [NotNull] EleWise.ELMA.Security.Models.IUser user)
    {
      if (user == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1536327508 ^ -1536323372));
      SqlSubQuery sqlSubQuery = this.Session.CreateSQLSubQuery(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1596821387 ^ -1596812775)).SetParameter(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--353012470 ^ 353036598), (object) user.Id);
      ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
      return (IEnumerable<EleWise.ELMA.Security.Models.IUser>) this.CreateCriteria().Add((ICriterion) Expression.Sql(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-169284490 ^ -169341972) + serviceNotNull.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-347045778 ^ -347044422)) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(2086891181 ^ 2086897923) + sqlSubQuery.Sql + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1940240517 ^ 974551502 ^ 1236487827), sqlSubQuery.ParametersValues, sqlSubQuery.ParametersTypes)).List<EleWise.ELMA.Security.Models.IUser>();
    }

    /// <summary>
    /// Получить пользователей по элементу оргструктуры, если элемент является должностью, то возвращается пользователь соотв. должности,
    /// если отдел то все сотрудники отдела в т.ч. вложенные должности
    /// </summary>
    /// <example>
    /// <para>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.PortalApiRoot.SecurityPortalApi.OrganizationItemSecurityApi.Load(System.Int64)">Как загрузить элемент оргструктуры</seealso>
    /// </para>
    /// <code>
    /// //загружаем элемент оргструктуры по идентификатору
    /// var orgItem = PublicAPI.Portal.Security.OrganizationItem.Load(3);
    /// 
    /// //получаем список пользователей
    /// var userList = PublicAPI.Portal.Security.OrganizationItem.GetUsersByDepartament(orgItem);
    /// 
    /// //userList - полученный список пользователей
    /// </code>
    /// </example>
    /// <param name="orgItem">Элемент оргструктуры</param>
    /// <returns>Список сотрудников</returns>
    [PublicApiMember]
    [PublicApiNodeId("OrganizationItemSecurityApi")]
    public IEnumerable<EleWise.ELMA.Security.Models.IUser> GetUsersByDepartament(
      [NotNull] IOrganizationItem orgItem)
    {
      if (orgItem == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1859356887 ^ -1859350379));
      ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
      SqlSubQuery sqlSubQuery = this.Session.CreateSQLSubQuery(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1458233619 ^ 1458177757), (object) serviceNotNull.TableFunction(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1028265253 << 4 ^ 727599684), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1212037053 ^ -1727812018 ^ -784502289)))).SetParameter(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~248518394 ^ -248577735), (object) orgItem.Id);
      return (IEnumerable<EleWise.ELMA.Security.Models.IUser>) this.CreateCriteria().Add((ICriterion) Expression.Sql(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-522456341 ^ -522513039) + serviceNotNull.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1007654939 ^ 1007656399)) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-696756495 ^ -696733345) + sqlSubQuery.Sql + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1687460816 ^ 1687426056), sqlSubQuery.ParametersValues, sqlSubQuery.ParametersTypes)).List<EleWise.ELMA.Security.Models.IUser>();
    }

    [ContextCache]
    protected virtual bool HaveSubordinatesForUser(long userId) => Convert.ToInt32(UserManager.si3L0vFpG6HLoR4aAFu(UserManager.eu5N1oFTte59R1ttZG2((object) ((IQuery) UserManager.EkyLbSFB0vVecJEha9q((object) this.Session, UserManager.jSH4gDTycwkCxhWdYvg(-522456341 ^ -522511695))).SetParameter<long>((string) UserManager.jSH4gDTycwkCxhWdYvg(-1536327508 ^ -1536302228), userId), false))) > 0;

    /// <summary>Список дублирующихся логинов</summary>
    /// <returns></returns>
    public List<string> CheckDuplicateUserName()
    {
      IProjection projection = Projections.Count(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2008710664 - -232311158 ^ -1776377232)).As(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1100789287 - 1555711667 ^ -454916538));
      List<object[]> list = this.CreateCriteria().SetProjection((IProjection) Projections.ProjectionList().Add((IProjection) Projections.GroupProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1100789287 - 1555711667 ^ -454916502)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(789532496 ^ 1575286436 ^ 1928024298)).Add(projection)).Add((ICriterion) Restrictions.Gt(projection, (object) 1)).List<object[]>().ToList<object[]>();
      return !list.Any<object[]>() ? new List<string>() : list.Select<object[], string>((Func<object[], string>) (i => i[0].ToString())).ToList<string>();
    }

    /// <summary>Найти именинников в течение года</summary>
    /// <param name="range">Диапазон в течение года</param>
    /// <param name="options">Опции выборки (offset, max)</param>
    /// <returns>Именинники</returns>
    public IEnumerable<EleWise.ELMA.Security.Models.IUser> FindOrderedBirthDateUsers(
      DateTimeRange range,
      FetchOptions options)
    {
      Contract.ArgumentNotNull((object) range.From, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1277802350 ^ -1277779502));
      Contract.ArgumentNotNull((object) range.To, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1848373724 >> 1 ^ 924127670));
      int day1 = range.From.Value.Day;
      int month1 = range.From.Value.Month;
      int day2 = range.To.Value.Day;
      int month2 = range.To.Value.Month;
      IUserFilter filter = InterfaceActivator.Create<IUserFilter>();
      filter.YearlyBirthDate = range;
      ICriteria criteria = this.CreateCriteria((IEntityFilter) filter);
      this.SetupFilter(criteria, (IEntityFilter) filter);
      if (options != (FetchOptions) null)
      {
        IProjection projection1;
        if (month1 > month2)
          projection1 = Projections.Conditional((ICriterion) Restrictions.Le(Projections.SqlFunction(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--534238571 ^ 534198003), (IType) NHibernateUtil.Int32, (IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1690209562 ^ 116876444 ^ 1648953888))), (object) month2), CalculatedRestrictions.Addition(Projections.SqlFunction(z2jc63fLkugS1X8Q9N.tE1kD1vbB(384582979 ^ 384607963), (IType) NHibernateUtil.Int32, (IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1801131332 >> 4 ^ 112546546))), Projections.Constant((object) 12)), Projections.SqlFunction(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-110921701 >> 6 ^ -1741192), (IType) NHibernateUtil.Int32, (IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~123928154 ^ -123870717))));
        else
          projection1 = Projections.SqlFunction(z2jc63fLkugS1X8Q9N.tE1kD1vbB(552500104 ^ 552507408), (IType) NHibernateUtil.Int32, (IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1310136491 - -570921450 ^ -739206503)));
        IProjection projection2 = Projections.SqlFunction(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-347045778 ^ -347053102), (IType) NHibernateUtil.Int32, (IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-272519830 ^ 272544051)));
        Order order1 = options.SortDirection == ListSortDirection.Ascending ? Order.Asc(projection1) : Order.Desc(projection1);
        Order order2 = options.SortDirection == ListSortDirection.Ascending ? Order.Asc(projection2) : Order.Desc(projection2);
        criteria.AddOrder(order1);
        criteria.AddOrder(order2);
        if (options.FirstResult != 0)
          criteria.SetFirstResult(options.FirstResult);
        if (options.MaxResults != 0)
          criteria.SetMaxResults(options.MaxResults);
      }
      return (IEnumerable<EleWise.ELMA.Security.Models.IUser>) criteria.List<EleWise.ELMA.Security.Models.IUser>();
    }

    /// <summary>Проверяет уникальность имени среди всех сущностей</summary>
    /// <param name="entity"></param>
    protected virtual void CheckName(EleWise.ELMA.Security.Models.IUser entity)
    {
      int num = 4;
      List<EleWise.ELMA.Security.IUser> list;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (list.Count <= 0)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e != 0 ? 1 : 0;
              continue;
            }
            goto label_7;
          case 3:
            goto label_2;
          case 4:
            if (entity == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 == 0 ? 3 : 2;
              continue;
            }
            list = ((ICriteria) UserManager.g5QAIxFwm4UXfxf2OQf(UserManager.g5QAIxFwm4UXfxf2OQf((object) this.CreateCriteria(), UserManager.P6pMNhFvvj1qx4kbCuo((object) Restrictions.Eq((string) UserManager.jSH4gDTycwkCxhWdYvg(-1859356887 ^ -1859346889), UserManager.HFLqG6TXC14JhXq7EdO((object) entity)))), (object) Restrictions.Not((ICriterion) Restrictions.IdEq((object) entity.Id)))).List<EleWise.ELMA.Security.IUser>().ToList<EleWise.ELMA.Security.IUser>();
            num = 2;
            continue;
          default:
            goto label_7;
        }
      }
label_5:
      return;
label_2:
      return;
label_7:
      throw new UserNameAlreadyExistsException((EleWise.ELMA.Security.IUser) entity, list);
    }

    public override ExportRuleList ExportRules()
    {
      int num = 1;
      System.Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            type = InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      ExportRuleList exportRuleList = new ExportRuleList();
      ExportRule exportRule1 = new ExportRule();
      exportRule1.ParentType = type;
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(150349507 - 521039768 ^ -370713017));
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule1, ExportRuleType.Export);
      exportRuleList.Add(exportRule1);
      ExportRule exportRule2 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule2, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule2, UserManager.jSH4gDTycwkCxhWdYvg(-1596821387 ^ -1596812333));
      exportRule2.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule2);
      ExportRule exportRule3 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule3, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule3, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(44166125 ^ 44117387));
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule3, ExportRuleType.Export);
      exportRuleList.Add(exportRule3);
      ExportRule exportRule4 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule4, type);
      exportRule4.PropertyName = (string) UserManager.jSH4gDTycwkCxhWdYvg(-1691384762 ^ -1691390506);
      exportRule4.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule4);
      ExportRule exportRule5 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule5, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule5, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1658561670 << 4 ^ 767226380));
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule5, ExportRuleType.Export);
      exportRuleList.Add(exportRule5);
      ExportRule exportRule6 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule6, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule6, UserManager.jSH4gDTycwkCxhWdYvg(-110921701 >> 6 ^ -1743788));
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule6, ExportRuleType.Export);
      exportRuleList.Add(exportRule6);
      ExportRule exportRule7 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule7, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule7, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1807813747 ^ -1807869375));
      exportRule7.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule7);
      ExportRule exportRule8 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule8, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule8, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1440374117 ^ -1440396425));
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule8, ExportRuleType.Export);
      exportRuleList.Add(exportRule8);
      ExportRule exportRule9 = new ExportRule();
      exportRule9.ParentType = type;
      exportRule9.PropertyName = (string) UserManager.jSH4gDTycwkCxhWdYvg(1100789287 - 1555711667 ^ -454916746);
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule9, ExportRuleType.Export);
      exportRuleList.Add(exportRule9);
      ExportRule exportRule10 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule10, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule10, UserManager.jSH4gDTycwkCxhWdYvg(1530848604 ^ 1530807618));
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule10, ExportRuleType.Export);
      exportRuleList.Add(exportRule10);
      ExportRule exportRule11 = new ExportRule();
      exportRule11.ParentType = type;
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule11, UserManager.jSH4gDTycwkCxhWdYvg(1053060681 ^ 1053066335));
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule11, ExportRuleType.Export);
      exportRuleList.Add(exportRule11);
      ExportRule exportRule12 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule12, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule12, UserManager.jSH4gDTycwkCxhWdYvg(-17837901 ^ -17876327));
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule12, ExportRuleType.Export);
      exportRuleList.Add(exportRule12);
      ExportRule exportRule13 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule13, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule13, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(617026523 ^ 617085413));
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule13, ExportRuleType.Export);
      exportRuleList.Add(exportRule13);
      ExportRule exportRule14 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule14, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule14, UserManager.jSH4gDTycwkCxhWdYvg(784628100 ^ 784634838));
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule14, ExportRuleType.Export);
      exportRuleList.Add(exportRule14);
      ExportRule exportRule15 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule15, type);
      exportRule15.PropertyName = (string) UserManager.jSH4gDTycwkCxhWdYvg(2110885667 - -1624984630 ^ -559140557);
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule15, ExportRuleType.Export);
      exportRuleList.Add(exportRule15);
      ExportRule exportRule16 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule16, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule16, UserManager.jSH4gDTycwkCxhWdYvg(-1788054269 >> 5 ^ -55868924));
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule16, ExportRuleType.Export);
      exportRuleList.Add(exportRule16);
      ExportRule exportRule17 = new ExportRule();
      exportRule17.ParentType = type;
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule17, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1212789817 - 1827404527 ^ 1254814668));
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule17, ExportRuleType.Export);
      exportRuleList.Add(exportRule17);
      ExportRule exportRule18 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule18, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule18, UserManager.jSH4gDTycwkCxhWdYvg(1458233619 ^ 1458191607));
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule18, ExportRuleType.Export);
      exportRuleList.Add(exportRule18);
      ExportRule exportRule19 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule19, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule19, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--534238571 ^ 534214357));
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule19, ExportRuleType.Export);
      exportRuleList.Add(exportRule19);
      ExportRule exportRule20 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule20, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule20, UserManager.jSH4gDTycwkCxhWdYvg(-201065280 ^ -201124284));
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule20, ExportRuleType.Export);
      exportRuleList.Add(exportRule20);
      ExportRule exportRule21 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule21, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule21, UserManager.jSH4gDTycwkCxhWdYvg(-801309555 ^ -801368555));
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule21, ExportRuleType.Export);
      exportRuleList.Add(exportRule21);
      ExportRule exportRule22 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule22, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule22, UserManager.jSH4gDTycwkCxhWdYvg(1095474805 ^ 155418997 ^ 1208528096));
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule22, ExportRuleType.Export);
      exportRuleList.Add(exportRule22);
      ExportRule exportRule23 = new ExportRule();
      exportRule23.ParentType = type;
      exportRule23.PropertyName = (string) UserManager.jSH4gDTycwkCxhWdYvg(--306199571 ^ 306239157);
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule23, ExportRuleType.Export);
      exportRuleList.Add(exportRule23);
      ExportRule exportRule24 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule24, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule24, UserManager.jSH4gDTycwkCxhWdYvg(-1324692970 << 3 ^ -2007584006));
      exportRule24.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule24);
      ExportRule exportRule25 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule25, type);
      exportRule25.PropertyName = (string) UserManager.jSH4gDTycwkCxhWdYvg(1687460816 ^ 1687449880);
      exportRule25.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule25);
      ExportRule exportRule26 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule26, type);
      exportRule26.PropertyName = (string) UserManager.jSH4gDTycwkCxhWdYvg(-1457346863 ^ -1457387839);
      exportRule26.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule26);
      ExportRule exportRule27 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule27, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule27, UserManager.jSH4gDTycwkCxhWdYvg(1687460816 ^ 1687461388));
      exportRule27.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule27);
      exportRuleList.Add(new ExportRule()
      {
        ParentType = type,
        PropertyName = (string) UserManager.jSH4gDTycwkCxhWdYvg(-201065280 ^ -201064862),
        ExportRuleType = ExportRuleType.Export
      });
      ExportRule exportRule28 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule28, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule28, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1028265253 << 4 ^ 727598254));
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule28, ExportRuleType.Export);
      exportRuleList.Add(exportRule28);
      ExportRule exportRule29 = new ExportRule();
      UserManager.k4xZbSFJbwnw8hGMRW1((object) exportRule29, type);
      UserManager.B33m2tFqsGoRedJwK5n((object) exportRule29, UserManager.jSH4gDTycwkCxhWdYvg(1055964645 ^ 1055938309));
      UserManager.RDaHVOFgRW1sfeQD38S((object) exportRule29, ExportRuleType.Export);
      exportRuleList.Add(exportRule29);
      return exportRuleList;
    }

    /// <summary>Проверить, активна ли учетная запись пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <exception cref="T:System.ArgumentNullException">Передан пустой <c>User</c></exception>
    [PublicApiMember]
    public bool IsActive(EleWise.ELMA.Security.Models.IUser user)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              goto label_5;
            case 3:
              if (user != null)
              {
                if (UserManager.s48xrLTPJJR9Af5Zsqq((object) user) == UserStatus.Active)
                {
                  num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 == 0 ? 0 : 0;
                  continue;
                }
                goto label_3;
              }
              else
                goto label_9;
            default:
              goto label_4;
          }
        }
label_9:
        num1 = 2;
      }
label_3:
      return UserManager.s48xrLTPJJR9Af5Zsqq((object) user) == UserStatus.System;
label_4:
      return true;
label_5:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-817081027 ^ 243500131 ^ -1043349210));
    }

    internal void ChangeUserNames()
    {
      int num1 = 4;
      UserManager userManager;
      ICollection<EleWise.ELMA.Security.Models.IUser> allUsers;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_9;
          case 2:
            object obj = UserManager.RnZdFUFIPq63XkEelLP();
            InstanceOf<IUserFilter> instanceOf = new InstanceOf<IUserFilter>();
            UserManager.bMf5N3FeqgfkeObSqQO((object) instanceOf.New, false);
            IUserFilter filter = instanceOf.New;
            allUsers = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) obj).Find((IEntityFilter) filter, (FetchOptions) null);
            num1 = 5;
            continue;
          case 3:
            userManager = this;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 0 : 0;
            continue;
          case 4:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 == 0 ? 1 : 3;
            continue;
          case 5:
            ICollection<EleWise.ELMA.Security.Models.IUser> source1 = allUsers;
            // ISSUE: reference to a compiler-generated field
            Func<EleWise.ELMA.Security.Models.IUser, string> func1 = UserManager.\u003C\u003Ec.\u003C\u003E9__68_0;
            Func<EleWise.ELMA.Security.Models.IUser, string> keySelector;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              UserManager.\u003C\u003Ec.\u003C\u003E9__68_0 = keySelector = (Func<EleWise.ELMA.Security.Models.IUser, string>) (u => (string) UserManager.\u003C\u003Ec.QpdYBNwSOU4O38RXWpCD(UserManager.\u003C\u003Ec.F2nIf7wSpxpQ2JCHrWdh((object) u)));
            }
            else
              goto label_13;
label_8:
            IEnumerable<IGrouping<string, EleWise.ELMA.Security.Models.IUser>> source2 = source1.GroupBy<EleWise.ELMA.Security.Models.IUser, string>(keySelector);
            // ISSUE: reference to a compiler-generated field
            Func<IGrouping<string, EleWise.ELMA.Security.Models.IUser>, bool> func2 = UserManager.\u003C\u003Ec.\u003C\u003E9__68_1;
            Func<IGrouping<string, EleWise.ELMA.Security.Models.IUser>, bool> predicate;
            if (func2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              UserManager.\u003C\u003Ec.\u003C\u003E9__68_1 = predicate = (Func<IGrouping<string, EleWise.ELMA.Security.Models.IUser>, bool>) (g => g.Count<EleWise.ELMA.Security.Models.IUser>() > 1);
            }
            else
              goto label_12;
label_11:
            source2.Where<IGrouping<string, EleWise.ELMA.Security.Models.IUser>>(predicate).Each<IGrouping<string, EleWise.ELMA.Security.Models.IUser>>((Action<IGrouping<string, EleWise.ELMA.Security.Models.IUser>>) (g =>
            {
              userManager.changeUserNames[g.Key] = new List<Pair<string, EleWise.ELMA.Security.Models.IUser>>();
              g.OrderBy<EleWise.ELMA.Security.Models.IUser, long>((Func<EleWise.ELMA.Security.Models.IUser, long>) (u => u.Id)).Each<EleWise.ELMA.Security.Models.IUser>((Action<EleWise.ELMA.Security.Models.IUser>) (user =>
              {
                int num4 = 5;
                int num5;
                EleWise.ELMA.Security.Models.IUser user2;
                int index;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (allUsers.Any<EleWise.ELMA.Security.Models.IUser>((Func<EleWise.ELMA.Security.Models.IUser, bool>) (u => ((string) UserManager.\u003C\u003Ec__DisplayClass68_2.bm5EbBwYdl2VcDDDwSZ5((object) u)).Equals((string) UserManager.\u003C\u003Ec__DisplayClass68_2.s70mXEwYEdXq1Lmrjr41(UserManager.\u003C\u003Ec__DisplayClass68_2.bm5EbBwYdl2VcDDDwSZ5((object) user2), (object) index), StringComparison.InvariantCultureIgnoreCase))))
                      {
                        num4 = 9;
                        continue;
                      }
                      goto case 8;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      userManager.changeUserNames[g.Key].Add(new Pair<string, EleWise.ELMA.Security.Models.IUser>((string) UserManager.\u003C\u003Ec__DisplayClass68_1.sIl01lwYVKFV2rOOpQOj((object) user2), user2));
                      num4 = 10;
                      continue;
                    case 4:
                      user2 = user;
                      num4 = 2;
                      continue;
                    case 5:
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 4 : 3;
                      continue;
                    case 6:
                      index = num5;
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 != 0 ? 1 : 1;
                      continue;
                    case 7:
                      goto label_2;
                    case 8:
                      EleWise.ELMA.Security.Models.IUser user4 = user2;
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      UserManager.\u003C\u003Ec__DisplayClass68_1.HBpksOwY4tZ3MMQNMI5b((object) user4, UserManager.\u003C\u003Ec__DisplayClass68_1.zEEimKwYfKk7ijvUN9Bu(UserManager.\u003C\u003Ec__DisplayClass68_1.sIl01lwYVKFV2rOOpQOj((object) user4), (object) index));
                      num4 = 12;
                      continue;
                    case 10:
                      // ISSUE: reference to a compiler-generated method
                      if (UserManager.\u003C\u003Ec__DisplayClass68_1.PEgvCAwYlscc9WttBVCB((object) userManager.changeUserNames[g.Key]) != 1)
                      {
                        index = 2;
                        num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 3 : 1;
                        continue;
                      }
                      num4 = 11;
                      continue;
                    case 11:
                      goto label_15;
                    case 12:
                      // ISSUE: reference to a compiler-generated method
                      UserManager.\u003C\u003Ec__DisplayClass68_1.o8lypmwYcd8ekihWYC8Y((object) user2);
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 == 0 ? 6 : 7;
                      continue;
                    default:
                      num5 = index + 1;
                      num4 = 6;
                      continue;
                  }
                }
label_2:
                return;
label_15:;
              }));
            }));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 == 0 ? 1 : 1;
            continue;
label_12:
            predicate = func2;
            goto label_11;
label_13:
            keySelector = func1;
            goto label_8;
          default:
            this.changeUserNames = new Dictionary<string, List<Pair<string, EleWise.ELMA.Security.Models.IUser>>>();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0 ? 0 : 2;
            continue;
        }
      }
label_9:;
    }

    internal void NotifyChangeUserNames()
    {
      int num1 = 5;
      while (true)
      {
        IMessageManager serviceNotNull;
        Dictionary<string, List<Pair<string, EleWise.ELMA.Security.Models.IUser>>>.Enumerator enumerator1;
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            enumerator1 = this.changeUserNames.GetEnumerator();
            num1 = 3;
            continue;
          case 3:
            try
            {
label_12:
              if (enumerator1.MoveNext())
                goto label_17;
              else
                goto label_13;
label_10:
              IMessage message1;
              KeyValuePair<string, List<Pair<string, EleWise.ELMA.Security.Models.IUser>>> current1;
              List<Pair<string, EleWise.ELMA.Security.Models.IUser>>.Enumerator enumerator2;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    UserManager.b8qNEEvwxiHmcsLjIBF((object) serviceNotNull, (object) message1);
                    num2 = 8;
                    continue;
                  case 2:
label_18:
                    message1 = serviceNotNull.Create();
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 4 : 3;
                    continue;
                  case 3:
                    try
                    {
label_31:
                      if (enumerator2.MoveNext())
                        goto label_30;
                      else
                        goto label_32;
label_21:
                      Pair<string, EleWise.ELMA.Security.Models.IUser> current2;
                      IMessage message2;
                      int num3;
                      while (true)
                      {
                        switch (num3)
                        {
                          case 1:
                            serviceNotNull.Send((IMessageBase) message2);
                            num3 = 8;
                            continue;
                          case 2:
                            UserManager.LhdYmDFzYJRSpL9e5Ae((object) message2, UserManager.ydRYOQTO8LyeaVmdwki(UserManager.jSH4gDTycwkCxhWdYvg(-1212789817 - 1827404527 ^ 1254800370), (object) new object[2]
                            {
                              (object) current2.First,
                              UserManager.HFLqG6TXC14JhXq7EdO((object) current2.Second)
                            }));
                            num3 = 9;
                            continue;
                          case 3:
                            message2 = serviceNotNull.Create();
                            num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c != 0 ? 10 : 5;
                            continue;
                          case 4:
                            UserManager.Npn8LEF2OLF8SDSE8Vq((object) message2, (object) current2.Second);
                            num3 = 5;
                            continue;
                          case 5:
                            UserManager.sg68xcFHEGs9GoEWVbV((object) message2, UserManager.xIcnTaTMxnCVDimgcW0(UserManager.jSH4gDTycwkCxhWdYvg(978908330 << 6 ^ -1774337930)));
                            num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e != 0 ? 2 : 2;
                            continue;
                          case 6:
                            goto label_30;
                          case 7:
                            if (!UserManager.NOIkX2FnSvEEALkl7To((object) current2.First, (object) current2.Second.UserName))
                            {
                              num3 = 3;
                              continue;
                            }
                            goto label_31;
                          case 8:
                            goto label_31;
                          case 9:
                            UserManager.RiTyc9vuCx9tClyCbeo((object) message2, UserManager.ydRYOQTO8LyeaVmdwki((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1540570615 - 1746246777 ^ 1008191878), (object) new object[2]
                            {
                              (object) current2.First,
                              UserManager.HFLqG6TXC14JhXq7EdO((object) current2.Second)
                            }));
                            num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3587fb5590494aa3ada5f6ef5435f6bc != 0 ? 1 : 1;
                            continue;
                          case 10:
                            UserManager.ei6u5xFLcVBoWdpmBIU((object) message2, (object) null);
                            num3 = 4;
                            continue;
                          default:
                            goto label_18;
                        }
                      }
label_30:
                      current2 = enumerator2.Current;
                      num3 = 7;
                      goto label_21;
label_32:
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff != 0 ? 0 : 0;
                      goto label_21;
                    }
                    finally
                    {
                      enumerator2.Dispose();
                      int num4 = 0;
                      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 == 0)
                        num4 = 0;
                      switch (num4)
                      {
                        default:
                      }
                    }
                  case 4:
                    UserManager.ei6u5xFLcVBoWdpmBIU((object) message1, (object) null);
                    num2 = 6;
                    continue;
                  case 5:
                    enumerator2 = current1.Value.GetEnumerator();
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b != 0 ? 3 : 0;
                    continue;
                  case 6:
                    UserManager.Npn8LEF2OLF8SDSE8Vq((object) message1, (object) ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) UserManager.RnZdFUFIPq63XkEelLP()).Load(SecurityConstants.AdminUserUid));
                    num2 = 10;
                    continue;
                  case 7:
                    goto label_8;
                  case 8:
                    goto label_12;
                  case 9:
                    goto label_17;
                  case 10:
                    UserManager.sg68xcFHEGs9GoEWVbV((object) message1, UserManager.ydRYOQTO8LyeaVmdwki(UserManager.jSH4gDTycwkCxhWdYvg(1055964645 ^ 1055936895), (object) new object[1]
                    {
                      (object) current1.Key
                    }));
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b != 0 ? 0 : 0;
                    continue;
                  default:
                    IMessage message3 = message1;
                    IMessage message4 = message1;
                    object obj1 = UserManager.jSH4gDTycwkCxhWdYvg(1534797734 ^ 1534839672);
                    object[] objArray = new object[2]
                    {
                      (object) current1.Key,
                      null
                    };
                    string separator = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-94240706 ^ -94228362);
                    List<Pair<string, EleWise.ELMA.Security.Models.IUser>> source = current1.Value;
                    // ISSUE: reference to a compiler-generated field
                    Func<Pair<string, EleWise.ELMA.Security.Models.IUser>, string> func = UserManager.\u003C\u003Ec.\u003C\u003E9__69_0;
                    Func<Pair<string, EleWise.ELMA.Security.Models.IUser>, string> selector;
                    if (func == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      UserManager.\u003C\u003Ec.\u003C\u003E9__69_0 = selector = (Func<Pair<string, EleWise.ELMA.Security.Models.IUser>, string>) (p => string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(44166125 ^ 44094459), (object) p.Second.UserName, (object) p.Second.GetFullName()));
                    }
                    else
                      goto label_2;
label_40:
                    IEnumerable<string> values = source.Select<Pair<string, EleWise.ELMA.Security.Models.IUser>, string>(selector);
                    objArray[1] = (object) string.Join(separator, values);
                    object obj2;
                    string str1 = (string) (obj2 = UserManager.ydRYOQTO8LyeaVmdwki(obj1, (object) objArray));
                    UserManager.RiTyc9vuCx9tClyCbeo((object) message4, obj2);
                    string str2 = str1;
                    UserManager.LhdYmDFzYJRSpL9e5Ae((object) message3, (object) str2);
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a == 0 ? 1 : 1;
                    continue;
label_2:
                    selector = func;
                    goto label_40;
                }
              }
label_13:
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af == 0 ? 6 : 7;
              goto label_10;
label_17:
              current1 = enumerator1.Current;
              num2 = 5;
              goto label_10;
            }
            finally
            {
              enumerator1.Dispose();
              int num5 = 0;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0)
                num5 = 0;
              switch (num5)
              {
                default:
              }
            }
          case 4:
            goto label_44;
          case 5:
            if (this.changeUserNames != null)
            {
              serviceNotNull = Locator.GetServiceNotNull<IMessageManager>();
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 1 : 2;
              continue;
            }
            num1 = 4;
            continue;
        }
label_8:
        this.changeUserNames = (Dictionary<string, List<Pair<string, EleWise.ELMA.Security.Models.IUser>>>) null;
        num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 == 0 ? 1 : 1;
      }
label_3:
      return;
label_44:;
    }

    /// <summary>Получить текущего авторизованного пользователя</summary>
    /// <returns>Пользователь</returns>
    [PublicApiMember]
    public EleWise.ELMA.Security.Models.IUser GetCurrentUser() => ((IAuthenticationService) UserManager.XKitm2vbaosFIktMWCY((object) this)).GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();

    /// <summary>
    /// Получить подчиненных пользователя по уровню вложенности
    /// </summary>
    /// <example>
    /// <para>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.PortalApiRoot.SecurityPortalApi.UserSecurityApi.Load(System.Int64)">Как загрузить пользователя</seealso>
    /// </para>
    /// <code>
    /// //загружаем пользователя по идентификатору
    /// var user = PublicAPI.Portal.Security.User.Load(3);
    /// 
    /// //получаем подчиненных пользователя по уровню вложенности. Если таковых нет, вернет пустой список
    /// var subUserList = PublicAPI.Portal.Security.User.GetSubUsers(user, 2);
    /// 
    /// //subUserList - список подчиненных пользователя на 2 уровня вниз
    /// </code>
    /// </example>
    /// <param name="user">Пользователь</param>
    /// <param name="lvl">Уровень вложенности</param>
    /// <returns>Список пользователей(подчиненных)</returns>
    [PublicApiMember]
    public virtual IEnumerable<EleWise.ELMA.Security.Models.IUser> GetSubUsersByLvl(
      EleWise.ELMA.Security.Models.IUser user,
      int lvl)
    {
      if (user == null)
        throw new NullReferenceException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1534797734 ^ 1534839420)));
      List<EleWise.ELMA.Security.Models.IUser> subUsersByLvl = new List<EleWise.ELMA.Security.Models.IUser>();
      foreach (IOrganizationItem organizationItem1 in (IEnumerable<IOrganizationItem>) user.OrganizationItems)
      {
        foreach (IOrganizationItem organizationItem2 in OrganizationItemManager.Instance.GetSubItemsByLvl(organizationItem1, lvl))
        {
          if (organizationItem2.ItemType == OrganizationItemType.Position && organizationItem2.User != null)
            subUsersByLvl.Add(organizationItem2.User);
          if (organizationItem2.ItemType == OrganizationItemType.EmployeeGroup && organizationItem2.Users.Any<EleWise.ELMA.Security.Models.IUser>())
            subUsersByLvl.AddRange((IEnumerable<EleWise.ELMA.Security.Models.IUser>) organizationItem2.Users);
        }
      }
      return (IEnumerable<EleWise.ELMA.Security.Models.IUser>) subUsersByLvl;
    }

    /// <summary>Получить все должности пользователя</summary>
    /// <example>
    /// <para>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.PortalApiRoot.SecurityPortalApi.UserSecurityApi.Load(System.Int64)">Как загрузить пользователя</seealso>
    /// </para>
    /// <code>
    /// //загружаем пользователя по идентификатору
    /// var user = PublicAPI.Portal.Security.User.Load(3);
    /// 
    /// //получаем все должности пользователя. Если таковых нет, вернет пустой список
    /// var positionList = PublicAPI.Portal.Security.User.GetUserPositions(user);
    /// 
    /// //positionList - список должностей пользователя
    /// </code>
    /// </example>
    /// <param name="user">Пользователь</param>
    /// <returns>Список должностей</returns>
    [PublicApiMember]
    public virtual IEnumerable<IOrganizationItem> GetUserPositions(
      EleWise.ELMA.Security.Models.IUser user)
    {
      List<IOrganizationItem> userPositions = new List<IOrganizationItem>();
      if (user.OrganizationGroups != null && user.OrganizationGroups.Any<IOrganizationItem>())
        userPositions.AddRange((IEnumerable<IOrganizationItem>) user.OrganizationGroups);
      if (user.OrganizationItems != null && user.OrganizationItems.Any<IOrganizationItem>())
        userPositions.AddRange((IEnumerable<IOrganizationItem>) user.OrganizationItems);
      return (IEnumerable<IOrganizationItem>) userPositions;
    }

    /// <summary>Получить все отделы пользователя</summary>
    /// <example>
    /// <para>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.PortalApiRoot.SecurityPortalApi.UserSecurityApi.Load(System.Int64)">Как загрузить пользователя</seealso>
    /// </para>
    /// <code>
    /// //загружаем пользователя по идентификатору
    /// var user = PublicAPI.Portal.Security.User.Load(3);
    /// 
    /// //получаем все отделы пользователя. Если таковых нет, вернет пустой список
    /// var departmentList = PublicAPI.Portal.Security.User.GetUserDepartments(user);
    /// 
    /// //departmentList - список всех отделов пользователя
    /// </code>
    /// </example>
    /// <param name="user">Пользователь</param>
    /// <returns>Список отделов пользователя</returns>
    [PublicApiMember]
    public virtual IEnumerable<IOrganizationItem> GetUserDepartments(
      EleWise.ELMA.Security.Models.IUser user)
    {
      List<IOrganizationItem> source = new List<IOrganizationItem>();
      if (user.OrganizationItems != null && user.OrganizationItems.Any<IOrganizationItem>())
      {
        foreach (IOrganizationItem organizationItem1 in (IEnumerable<IOrganizationItem>) user.OrganizationItems)
        {
          for (IOrganizationItem organizationItem2 = organizationItem1; organizationItem2 != null; organizationItem2 = organizationItem2.ParentItem)
          {
            if (organizationItem2.ItemType == OrganizationItemType.Department)
              source.Add(organizationItem2);
          }
        }
      }
      if (user.OrganizationGroups != null && user.OrganizationGroups.Any<IOrganizationItem>())
      {
        foreach (IOrganizationItem organizationGroup in (IEnumerable<IOrganizationItem>) user.OrganizationGroups)
        {
          for (IOrganizationItem organizationItem = organizationGroup; organizationItem != null; organizationItem = organizationItem.ParentItem)
          {
            if (organizationItem.ItemType == OrganizationItemType.Department)
              source.Add(organizationItem);
          }
        }
      }
      return source.Distinct<IOrganizationItem>();
    }

    /// <summary>
    /// Получить модель отображения начальников пользователя в порядке иерархии
    /// </summary>
    /// <param name="user">Пользователь, начальников которого нужно получить</param>
    /// <returns>Модель отображения</returns>
    [PublicApiMember]
    [PublicApiNodeId("OrganizationItemSecurityApi")]
    public virtual HierarchyChiefDisplayModel GetUserChiefsHierarchy(
      EleWise.ELMA.Security.Models.IUser user)
    {
      int num1 = 3;
      Dictionary<IOrganizationItem, IEnumerable<HierarchyChiefDisplayModel.HierarchyChiefModel>> dictionary;
      IEnumerator<IGrouping<long, HierarchyChiefDisplayModel.HierarchyChiefModel>> enumerator1;
      ICollection<IOrganizationItem> byIdArray1;
      ICollection<EleWise.ELMA.Security.Models.IUser> byIdArray2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_38;
          case 2:
            IList<HierarchyChiefDisplayModel.HierarchyChiefModel> hierarchyChiefModelList1 = ((IQuery) UserManager.eu5N1oFTte59R1ttZG2(UserManager.t1FcBhvK2QsUaiO4TOC((object) ((ISession) UserManager.xDqYA7FRVjvOKGJN8Oi((object) this)).GetNamedQuery(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1893095749 ^ -1893119833)).SetParameter<long>((string) UserManager.jSH4gDTycwkCxhWdYvg(-901653144 ^ -901696732), user.Id), (object) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(typeof (HierarchyChiefDisplayModel.HierarchyChiefModel))), false)).List<HierarchyChiefDisplayModel.HierarchyChiefModel>();
            List<long> userIdList = new List<long>();
            List<long> orgItemIdList = new List<long>();
            hierarchyChiefModelList1.ForEach<HierarchyChiefDisplayModel.HierarchyChiefModel>((Action<HierarchyChiefDisplayModel.HierarchyChiefModel>) (q =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    userIdList.AddIfNotContains<long>(q.UserId);
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e == 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_2;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    orgItemIdList.AddIfNotContains<long>(UserManager.\u003C\u003Ec__DisplayClass74_0.BZ5hcLwYhocBmnL3yi3p((object) q));
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e != 0 ? 2 : 0;
                    continue;
                  default:
                    // ISSUE: reference to a compiler-generated method
                    orgItemIdList.AddIfNotContains<long>(UserManager.\u003C\u003Ec__DisplayClass74_0.OPH7nXwYMtU7TD5W1TYl((object) q));
                    num2 = 3;
                    continue;
                }
              }
label_2:;
            }));
            byIdArray2 = ((AbstractNHEntityManager<EleWise.ELMA.Security.Models.IUser, long>) UserManager.RnZdFUFIPq63XkEelLP()).FindByIdArray((long[]) UserManager.JxJYjvFWbm5DXEskOIZ((object) userIdList));
            byIdArray1 = ((AbstractNHEntityManager<IOrganizationItem, long>) UserManager.eqfVYevUiyKf0HVWlSl()).FindByIdArray(orgItemIdList.ToArray());
            dictionary = new Dictionary<IOrganizationItem, IEnumerable<HierarchyChiefDisplayModel.HierarchyChiefModel>>();
            // ISSUE: reference to a compiler-generated field
            Func<HierarchyChiefDisplayModel.HierarchyChiefModel, long> func = UserManager.\u003C\u003Ec.\u003C\u003E9__74_1;
            Func<HierarchyChiefDisplayModel.HierarchyChiefModel, long> keySelector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              UserManager.\u003C\u003Ec.\u003C\u003E9__74_1 = keySelector = (Func<HierarchyChiefDisplayModel.HierarchyChiefModel, long>) (q => q.StartItemId);
            }
            else
              goto label_42;
label_41:
            enumerator1 = hierarchyChiefModelList1.GroupBy<HierarchyChiefDisplayModel.HierarchyChiefModel, long>(keySelector).GetEnumerator();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0 ? 0 : 0;
            continue;
label_42:
            keySelector = func;
            goto label_41;
          case 3:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_df5fd3add5d843868cf65a0a9e6fa2b4 == 0 ? 1 : 2;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      try
      {
label_7:
        if (enumerator1.MoveNext())
          goto label_26;
        else
          goto label_8;
label_4:
        IOrganizationItem key;
        List<HierarchyChiefDisplayModel.HierarchyChiefModel> hierarchyChiefModelList2;
        IEnumerator<HierarchyChiefDisplayModel.HierarchyChiefModel> enumerator2;
        int num3;
        IGrouping<long, HierarchyChiefDisplayModel.HierarchyChiefModel> item;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_26;
            case 2:
              // ISSUE: reference to a compiler-generated method
              enumerator2 = item.OrderBy<HierarchyChiefDisplayModel.HierarchyChiefModel, long>((Func<HierarchyChiefDisplayModel.HierarchyChiefModel, long>) (i => UserManager.\u003C\u003Ec.ayjXl6wST9Q5eTUh3SQe((object) i))).GetEnumerator();
              num3 = 6;
              continue;
            case 3:
              goto label_38;
            case 4:
label_5:
              dictionary.Add(key, (IEnumerable<HierarchyChiefDisplayModel.HierarchyChiefModel>) hierarchyChiefModelList2);
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 0 : 0;
              continue;
            case 5:
              item = enumerator1.Current;
              num3 = 7;
              continue;
            case 6:
              try
              {
label_11:
                if (UserManager.ulYmTRT52BJsJBnr1Ip((object) enumerator2))
                  goto label_17;
                else
                  goto label_12;
label_10:
                int num4;
                HierarchyChiefDisplayModel.HierarchyChiefModel hierarchyChiefModel;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_5;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      UserManager.ihHDKxvtbKxK7hQlubb((object) hierarchyChiefModel, (object) byIdArray1.First<IOrganizationItem>((Func<IOrganizationItem, bool>) (q => q.Id == UserManager.\u003C\u003Ec__DisplayClass74_2.omW8wSwYIGWXAdAZ5s13((object) hierarchyChiefModel))));
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 == 0 ? 6 : 5;
                      continue;
                    case 3:
                      hierarchyChiefModel = enumerator2.Current;
                      num4 = 4;
                      continue;
                    case 4:
                      // ISSUE: reference to a compiler-generated method
                      UserManager.cHjbf2vR8oBFf6Dog8m((object) hierarchyChiefModel, (object) byIdArray2.First<EleWise.ELMA.Security.Models.IUser>((Func<EleWise.ELMA.Security.Models.IUser, bool>) (q => q.Id == UserManager.\u003C\u003Ec__DisplayClass74_2.GaY4utwYJKxkZquuH2c5((object) hierarchyChiefModel))));
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 0 : 0;
                      continue;
                    case 5:
                      goto label_17;
                    case 6:
                      hierarchyChiefModelList2.Add(hierarchyChiefModel);
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_95399a04db00456bb419898ac4cbed9a != 0 ? 3 : 7;
                      continue;
                    case 7:
                      goto label_11;
                    default:
                      UserManager.i6xlDHvoqlZp5FiKAvj((object) hierarchyChiefModel, (object) key);
                      num4 = 2;
                      continue;
                  }
                }
label_12:
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 == 0 ? 1 : 1;
                goto label_10;
label_17:
                num4 = 2;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 == 0)
                {
                  num4 = 3;
                  goto label_10;
                }
                else
                  goto label_10;
              }
              finally
              {
                if (enumerator2 != null)
                {
                  int num5 = 0;
                  if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 == 0)
                    num5 = 0;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        goto label_25;
                      default:
                        UserManager.PnK6r9Td7OMss5iIhgy((object) enumerator2);
                        num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 != 0 ? 0 : 1;
                        continue;
                    }
                  }
                }
label_25:;
              }
            case 7:
              key = byIdArray1.First<IOrganizationItem>((Func<IOrganizationItem, bool>) (q => q.Id == item.Key));
              num3 = 8;
              continue;
            case 8:
              hierarchyChiefModelList2 = new List<HierarchyChiefDisplayModel.HierarchyChiefModel>();
              num3 = 2;
              continue;
            default:
              goto label_7;
          }
        }
label_8:
        num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8baab377066d4cefb59cfe4028784091 != 0 ? 3 : 3;
        goto label_4;
label_26:
        num3 = 5;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0)
        {
          num3 = 0;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num6 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af != 0)
            num6 = 0;
          while (true)
          {
            switch (num6)
            {
              case 1:
                goto label_36;
              default:
                UserManager.PnK6r9Td7OMss5iIhgy((object) enumerator1);
                num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_36:;
      }
label_38:
      return new HierarchyChiefDisplayModel(dictionary);
    }

    private static ISet<string> UserLoginIdMapContextCache => ContextVars.GetOrAdd<ISet<string>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-1362653258 ^ 1362665007), (Func<ISet<string>>) (() => (ISet<string>) new HashSet<string>()));

    public UserManager()
    {
      UserManager.WgfZ8avmP6HsuQgaFCm();
      this._userLoginIdMap = new ConcurrentDictionary<string, long>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_404287ba5e79420cbf0d7c0c04fc841b != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool KlA13tTjR0cPLy9ebmu() => UserManager.WEc6jcT3vWu87xGdXhr == null;

    internal static UserManager lVLPDBTNiOkcd1sovtM() => UserManager.WEc6jcT3vWu87xGdXhr;

    internal static object oW5qWlT0IW5Hw1t92Jn() => (object) ComponentManager.Current;

    internal static object KYtHXATZgQSLkmauEXT([In] object obj0) => (object) ((ComponentManager) obj0).ModuleManager;

    internal static Guid KfHcfVTAUXpbPPS4I2x() => __AssemblyInfo.UID;

    internal static object M8IImkTsRw9KcjADYMF([In] object obj0, [In] Guid obj1) => (object) ((IModuleManager) obj0).FindUnitByUid(obj1);

    internal static object qVYG5ST7fQOjatUGxTW([In] object obj0) => (object) ((ILicensedModuleAssembly) obj0).LicenseUnit;

    internal static bool chIkdRTWJQ5qetaV1sf([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void p9w1whTrBcJDE7myVjx([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Security.Models.IUser) obj0).Photo = (BinaryFile) obj1;

    internal static object jyQ7wRTS15iKr0xfKaH([In] object obj0) => (object) ((EleWise.ELMA.Security.Models.IUser) obj0).Photo;

    internal static object jWvjE4TYRaHFcpbju49([In] object obj0) => (object) ((BinaryFile) obj0).Name;

    internal static object jSH4gDTycwkCxhWdYvg(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object EZIIhbTVs9C55p0VdK4([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object UBHn2aTlQhdtLgmgkow([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static bool zGbuxyTfDSoVKGFKEM0([In] object obj0, [In] object obj1, [In] RegexOptions obj2) => Regex.IsMatch((string) obj0, (string) obj1, obj2);

    internal static long gY0OJxT4K6Sbr8oAWXH([In] object obj0) => ((BinaryFile) obj0).GetSize();

    internal static void e2l6r6Tc2YZKlU1Bi1O([In] object obj0, [In] object obj1) => ((UserManager) obj0).CheckName((EleWise.ELMA.Security.Models.IUser) obj1);

    internal static UserStatus s48xrLTPJJR9Af5Zsqq([In] object obj0) => ((EleWise.ELMA.Security.Models.IUser) obj0).Status;

    internal static void Ms7DOhTQLyfihaDKeeB([In] object obj0, UserStatus value) => ((EleWise.ELMA.Security.Models.IUser) obj0).Status = value;

    internal static void yK75LMT8VLMt4pZd0Kv([In] object obj0, bool value) => ((EleWise.ELMA.Security.Models.IUser) obj0).IsSystemLocal = value;

    internal static bool ulYmTRT52BJsJBnr1Ip([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void PnK6r9Td7OMss5iIhgy([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void xxinYrTEiFObTykUIpW([In] object obj0, [In] object obj1) => ((ActiveUserSessionService) obj0).RemoveAllUserSessions(obj1);

    internal static void jODkThTGkyhpS8C8bnd([In] object obj0, long authUser) => ((PublicClientSessionManager) obj0).DeleteByAuthUser(authUser);

    internal static object HFLqG6TXC14JhXq7EdO([In] object obj0) => (object) ((EleWise.ELMA.Security.Models.IUser) obj0).UserName;

    internal static object NGaMc3T9kFwJQARqDZx([In] object obj0) => (object) ((EntityManager<EleWise.ELMA.Security.Models.IUser, long>) obj0).UnitOfWorkManager;

    internal static bool rwX6aQT1BPZtiIx6lAY([In] object obj0) => ((IInternalSecurityService) obj0).CanCreateNewUser();

    internal static object xIcnTaTMxnCVDimgcW0([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object WMVr9pThjyaUaKMUVw0() => (object) ReplacementManager.Instance;

    internal static DateTime y9D9UoTBQJ811jb8Rit() => DateTime.Today;

    internal static bool Lcx1NQTpYuZI4EKEexd([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object ydRYOQTO8LyeaVmdwki([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);

    internal static object aAjwRhTTvZfMHR71v0P() => (object) UserGroupManager.Instance;

    internal static void qfdYnfTF7RRdZhVviTH([In] object obj0) => ((IEntity) obj0).Save();

    internal static object j941nMTveUQvHScZVi8([In] object obj0) => (object) ((HttpContextBase) obj0).Response;

    internal static object xTHhwnTqvjIXO9MRunV([In] object obj0) => (object) ((HttpResponseBase) obj0).Cookies;

    internal static void WvKYngTgMeHwUA8FsYt([In] object obj0, [In] DateTime obj1) => ((HttpCookie) obj0).Expires = obj1;

    internal static object Bfd1A6TJm2BkvE1vgu3([In] object obj0) => (object) EncryptionHelper.GetMd5Hash((string) obj0);

    internal static object UM3TuOTIdUjjFfKhyyG([In] object obj0) => (object) ((IUserSecurityProfile) obj0).User;

    internal static object x2EUDhTewxtaBpbQb0S([In] object obj0) => (object) ((IUserSecurityProfile) obj0).Password;

    internal static object m2HWv8TnxJjrFNZ6yvD([In] object obj0, [In] object obj1) => (object) EncryptionHelper.GetSha256Hash((string) obj0, (string) obj1);

    internal static bool YNtYebTLwS4L0NSMlAP([In] object obj0, [In] object obj1) => ((string) obj0).SlowEquals((string) obj1);

    internal static object utWSI4T2LjQjiDaWTKD([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void z9m9aZTH0f4C2O3xHRm([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void RxNuXLTzdGiRnmvef7L([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((EntityManager<EleWise.ELMA.Security.Models.IUser, long>) obj0).SetupFilter((ICriteria) obj1, (IEntityFilter) obj2));

    internal static int OWOpZyFuxJeWa4fCd6u([In] object obj0) => ((List<long>) obj0).Count;

    internal static object g5QAIxFwm4UXfxf2OQf([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object dZNViQFb7BpFvBE56c1([In] object obj0) => (object) ((IUserFilter) obj0).OrganizationItem;

    internal static object owunR6FKaF2dCvF3Pdx([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteString((string) obj1);

    internal static object j8CvcqFUNQ8VniEgCQO([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ITransformationProvider) obj0).TableFunction((string) obj1, (string) obj2);

    internal static object xDqYA7FRVjvOKGJN8Oi([In] object obj0) => (object) ((NHManagerBase) obj0).Session;

    internal static object D2RgaFFoh9bM9e3USiU([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object MCJ58SFtgoqawPdWhAD([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object MydSbeFmpj3byp688bY([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).CreateSQLSubQuery((string) obj1);

    internal static object zEKxXMF6QcUDLR8htdM([In] object obj0) => (object) ((SqlSubQuery) obj0).Sql;

    internal static object QG2ZxCFkSI66up0mGbO([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object Sg2oJfFDYK6dLgfw9Ho([In] object obj0) => (object) Expression.Sql((string) obj0);

    internal static OrganizationItemFindMode hnmK6YFaITDEftxWxek([In] object obj0) => ((IUserFilter) obj0).OrganizationItemFindMode;

    internal static object mTyFtDFx3QhTxl0fcCA([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).SetResultTransformer((IResultTransformer) obj1);

    internal static object kAWeZVFCTloytT72phS(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] JoinType obj3)
    {
      return (object) ((ICriteria) obj0).CreateAlias((string) obj1, (string) obj2, obj3);
    }

    internal static object SiVoG6FiehGO5wdso7x([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object iMOI0vF3qGlDcIItSO1([In] object obj0, [In] object obj1) => (object) Restrictions.Or((ICriterion) obj0, (ICriterion) obj1);

    internal static object NobeAdFjTyirTydc5Ki([In] object obj0, [In] object obj1) => (object) Restrictions.In((string) obj0, (ICollection) obj1);

    internal static int McZPmtFNLNvHHgbKQiR([In] object obj0) => ((List<Worker>) obj0).Count;

    internal static Guid sPYOLQF04IMu7uMOfEn([In] object obj0) => ((Worker) obj0).WorkerType;

    internal static Guid rskoo9FZLk165Keeapc() => OrganizationItemDTO.MetadataUid;

    internal static bool Lqk0EMFArY6Gq44MyZn([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static long WK5tYiFsmbiVDOQMeI8([In] object obj0) => ((Worker) obj0).WorkerId;

    internal static Guid aILsnWF7xRiKEwIF5PZ() => UserGroupDTO.MetadataUid;

    internal static object JxJYjvFWbm5DXEskOIZ([In] object obj0) => (object) ((List<long>) obj0).ToArray();

    internal static object JPxfGvFrbolejiwNwnE([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SqlSubQuery) obj0).SetParameterList((string) obj1, (ICollection) obj2);

    internal static object g4f2XCFSVlWuaYoYL9j([In] object obj0) => (object) ((SqlSubQuery) obj0).ParametersValues;

    internal static object qDIS5IFYw2olxvKmO5I([In] object obj0) => (object) ((SqlSubQuery) obj0).ParametersTypes;

    internal static object N523wFFyDC7j4tIInTA([In] object obj0, [In] object obj1, [In] object obj2) => (object) Expression.Sql((string) obj0, (object[]) obj1, (IType[]) obj2);

    internal static object tbgEB7FV72YPGO4MoqL([In] object obj0) => (object) Projections.Property((string) obj0);

    internal static object EdS61PFl9HMZ9Yd4Hmh([In] object obj0, [In] object obj1) => (object) Restrictions.In((IProjection) obj0, (ICollection) obj1);

    internal static bool NoCEiXFfGWIX91bZe2U([In] object obj0) => ((IUserFilter) obj0).ShowBlock;

    internal static object KMW6FfF4sqgduASlB6o([In] object obj0) => (object) Restrictions.Not((ICriterion) obj0);

    internal static object M4YlgeFcKmIh0eVSvqJ([In] object obj0) => (object) Restrictions.IsNotNull((string) obj0);

    internal static bool ErAjlpFPxhsEKHaLEFf([In] object obj0) => ((IUserFilter) obj0).ShowOnlySubordinate;

    internal static object udcGoMFQaWveMBLMnrh([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SqlSubQuery) obj0).SetParameter((string) obj1, obj2);

    internal static object GdOJVUF82mMPc2LBpnP([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) string.Format((string) obj0, obj1, obj2, obj3);

    internal static DateTimeRange fD80eDF5nBlJofItpkb([In] object obj0) => ((IUserFilter) obj0).YearlyBirthDate;

    internal static object oeDVvyFdmjBC1HXhR64() => (object) Restrictions.Disjunction();

    internal static object ecuq4oFEbdwlS0ioVZl([In] object obj0, [In] object obj1, [In] object obj2) => (object) Projections.SqlFunction((string) obj0, (IType) obj1, (IProjection[]) obj2);

    internal static object sPNEV7FGKhxXc2je5Me([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((IProjection) obj0, obj1);

    internal static object mCjiOCFXLFkYqfIM4Ln([In] object obj0, [In] object obj1) => (object) ((Junction) obj0).Add((ICriterion) obj1);

    internal static object KvZy81F9JDuhDMyNNTM([In] object obj0, [In] object obj1) => (object) Restrictions.Ge((IProjection) obj0, obj1);

    internal static object veuWZqF1aIeqlVlrmZZ() => (object) Restrictions.Conjunction();

    internal static object T9MMtCFMOuMBUTCruii([In] object obj0, [In] object obj1) => (object) Restrictions.Gt((IProjection) obj0, obj1);

    internal static object GvNwqZFhGZPgrgABwCQ([In] object obj0, [In] object obj1) => (object) Restrictions.Lt((IProjection) obj0, obj1);

    internal static object EkyLbSFB0vVecJEha9q([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).CreateSQLQuery((string) obj1);

    internal static object si3L0vFpG6HLoR4aAFu([In] object obj0) => ((IQuery) obj0).UniqueResult();

    internal static int k9QYaHFOfS6bAp4WMc2([In] object obj0) => Convert.ToInt32(obj0);

    internal static object eu5N1oFTte59R1ttZG2([In] object obj0, [In] bool obj1) => (object) ((IQuery) obj0).CleanUpCache(obj1);

    internal static bool yNfLqyFFBRVbN1tWiCe([In] object obj0, long userId) => ((UserManager) obj0).HaveSubordinatesForUser(userId);

    internal static object P6pMNhFvvj1qx4kbCuo([In] object obj0) => (object) ((SimpleExpression) obj0).IgnoreCase();

    internal static void B33m2tFqsGoRedJwK5n([In] object obj0, [In] object obj1) => ((ExportRule) obj0).PropertyName = (string) obj1;

    internal static void RDaHVOFgRW1sfeQD38S([In] object obj0, [In] ExportRuleType obj1) => ((ExportRule) obj0).ExportRuleType = obj1;

    internal static void k4xZbSFJbwnw8hGMRW1([In] object obj0, [In] System.Type obj1) => ((ExportRule) obj0).ParentType = obj1;

    internal static object RnZdFUFIPq63XkEelLP() => (object) UserManager.Instance;

    internal static void bMf5N3FeqgfkeObSqQO([In] object obj0, bool value) => ((IUserFilter) obj0).ShowBlock = value;

    internal static bool NOIkX2FnSvEEALkl7To([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static void ei6u5xFLcVBoWdpmBIU([In] object obj0, [In] object obj1) => ((IMessage) obj0).Author = obj1;

    internal static void Npn8LEF2OLF8SDSE8Vq([In] object obj0, [In] object obj1) => ((IMessage) obj0).Recipient = obj1;

    internal static void sg68xcFHEGs9GoEWVbV([In] object obj0, [In] object obj1) => ((IMessage) obj0).Subject = (string) obj1;

    internal static void LhdYmDFzYJRSpL9e5Ae([In] object obj0, [In] object obj1) => ((IMessage) obj0).FullMessageText = (string) obj1;

    internal static void RiTyc9vuCx9tClyCbeo([In] object obj0, [In] object obj1) => ((IMessage) obj0).ShortMessageText = (string) obj1;

    internal static void b8qNEEvwxiHmcsLjIBF([In] object obj0, [In] object obj1) => ((IMessageManager) obj0).Send((IMessageBase) obj1);

    internal static object XKitm2vbaosFIktMWCY([In] object obj0) => (object) ((EntityManager<EleWise.ELMA.Security.Models.IUser, long>) obj0).AuthenticationService;

    internal static object t1FcBhvK2QsUaiO4TOC([In] object obj0, [In] object obj1) => (object) ((IQuery) obj0).SetResultTransformer((IResultTransformer) obj1);

    internal static object eqfVYevUiyKf0HVWlSl() => (object) OrganizationItemManager.Instance;

    internal static void cHjbf2vR8oBFf6Dog8m([In] object obj0, [In] object obj1) => ((HierarchyChiefDisplayModel.HierarchyChiefModel) obj0).User = (EleWise.ELMA.Security.Models.IUser) obj1;

    internal static void i6xlDHvoqlZp5FiKAvj([In] object obj0, [In] object obj1) => ((HierarchyChiefDisplayModel.HierarchyChiefModel) obj0).StartItem = (IOrganizationItem) obj1;

    internal static void ihHDKxvtbKxK7hQlubb([In] object obj0, [In] object obj1) => ((HierarchyChiefDisplayModel.HierarchyChiefModel) obj0).OrgItem = (IOrganizationItem) obj1;

    internal static void WgfZ8avmP6HsuQgaFCm() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    [Component]
    private sealed class LicenseWorkplaceExceededExceptionEventHandler : 
      ILicenseWorkplaceExceededExceptionEventHandler,
      IEventHandler
    {
      private static object P6GhPKwSldDMJQHDbcdf;

      public void UserLicenseWorkplaceExceededException(EleWise.ELMA.Security.Models.IUser user)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              UserManager.UserLoginIdMapContextCache.Count<string>(new Func<string, bool>(((IDictionary<string, long>) ((UserManager) UserManager.LicenseWorkplaceExceededExceptionEventHandler.YgrmNBwScmQgnmgOIawS())._userLoginIdMap).Remove));
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public LicenseWorkplaceExceededExceptionEventHandler()
      {
        UserManager.LicenseWorkplaceExceededExceptionEventHandler.JEve86wSPpt7wWCREmdb();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object YgrmNBwScmQgnmgOIawS() => (object) UserManager.Instance;

      internal static bool yTDECVwSf83Rr5PAddHc() => UserManager.LicenseWorkplaceExceededExceptionEventHandler.P6GhPKwSldDMJQHDbcdf == null;

      internal static UserManager.LicenseWorkplaceExceededExceptionEventHandler kKIpfTwS4gSZB9gV598X() => (UserManager.LicenseWorkplaceExceededExceptionEventHandler) UserManager.LicenseWorkplaceExceededExceptionEventHandler.P6GhPKwSldDMJQHDbcdf;

      internal static void JEve86wSPpt7wWCREmdb() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
    }
  }
}

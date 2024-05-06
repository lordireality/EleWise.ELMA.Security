// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Managers.UserGroupManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Security.Managers
{
  /// <summary>Менеджер групп пользователей</summary>
  [DeveloperApi(DeveloperApiType.Manager)]
  public class UserGroupManager : EntityManager<IUserGroup, long>
  {
    [Obsolete("Not used", true)]
    public const string GETGROUPSFORUSERS_CACHE_REGION = "GetGroupsByUser";
    internal static UserGroupManager bnikLFOcPNO3f8cP6uv;

    /// <summary>Экземпляр менеджера</summary>
    public static UserGroupManager Instance => Locator.GetServiceNotNull<UserGroupManager>();

    private static IComplexCacheService ComplexCacheService => Locator.GetServiceNotNull<IComplexCacheService>();

    /// <summary>Провайдер преобразования БД</summary>
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
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 0 : 0;
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

    protected override void SetupAutoFilter(ICriteria criteria, IEntityFilter filter)
    {
      int num = 1;
      IUserGroupFilter userGroupFilter;
      bool? addToNewUser;
      while (true)
      {
        switch (num)
        {
          case 1:
            UserGroupManager.iba1VkO8Hp1ByP0if9U((object) this, (object) criteria, (object) filter);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            addToNewUser = userGroupFilter.AddToNewUser;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 == 0 ? 5 : 2;
            continue;
          case 4:
            UserGroupManager.TINv3UOdjKd4oVCAjsE((object) criteria, (object) Restrictions.Eq((string) UserGroupManager.oZL6bEO5iiFWghxXv9n(-517128429 ^ -517085597), (object) userGroupFilter.AddToNewUser));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 == 0 ? 2 : 1;
            continue;
          case 5:
            if (addToNewUser.HasValue)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 != 0 ? 2 : 4;
              continue;
            }
            goto label_9;
          default:
            userGroupFilter = (IUserGroupFilter) filter;
            num = 3;
            continue;
        }
      }
label_2:
      return;
label_9:;
    }

    /// <summary>Получить группы польователя</summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    public virtual IEnumerable<long> GetGroupsByUser(long userId) => this.GetGroupsByUser(userId, true);

    /// <summary>Получить группы польователя</summary>
    /// <param name="userId"></param>
    /// <param name="recursive"></param>
    /// <returns></returns>
    public virtual IEnumerable<long> GetGroupsByUser(long userId, bool recursive) => (IEnumerable<long>) UserGroupManager.ComplexCacheService.GetOrAdd<long[]>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1277472395 ^ -1277458183) + (object) userId + z2jc63fLkugS1X8Q9N.tE1kD1vbB(928696104 ^ 928698718) + recursive.ToString(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-617657301 ^ -617638501), (Func<long[]>) (() =>
    {
      int num = 1;
      int index;
      SqlSubQuery sqlSubQuery;
      ISQLQuery query;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated method
            sqlSubQuery = (SqlSubQuery) UserGroupManager.\u003C\u003Ec__DisplayClass12_0.swLmXuwStp73wTXKBSnN((object) this, userId, recursive);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a != 0 ? 0 : 0;
            continue;
          case 2:
          case 4:
            // ISSUE: reference to a compiler-generated method
            if (index >= UserGroupManager.\u003C\u003Ec__DisplayClass12_0.oCpgLmwSDehwb0p2KL4H((object) sqlSubQuery).Length)
            {
              num = 3;
              continue;
            }
            goto case 5;
          case 3:
            goto label_5;
          case 5:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            UserGroupManager.\u003C\u003Ec__DisplayClass12_0.uD2o74wSaQcKZupndXgd((object) query, index, UserGroupManager.\u003C\u003Ec__DisplayClass12_0.oCpgLmwSDehwb0p2KL4H((object) sqlSubQuery)[index]);
            num = 7;
            continue;
          case 6:
            index = 0;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0 ? 2 : 2;
            continue;
          case 7:
            ++index;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 == 0 ? 0 : 4;
            continue;
          default:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            query = (ISQLQuery) UserGroupManager.\u003C\u003Ec__DisplayClass12_0.d2HT5AwSkTHIDOC2vUiw(UserGroupManager.\u003C\u003Ec__DisplayClass12_0.THiN54wSmOp2ZWG6qH1o((object) this), UserGroupManager.\u003C\u003Ec__DisplayClass12_0.TyVcXGwS6hEqfT5JDNNZ((object) sqlSubQuery));
            num = 6;
            continue;
        }
      }
label_5:
      return query.CleanUpCache(false).List<object>().Select<object, long>(new Func<object, long>(Convert.ToInt64)).ToArray<long>();
    }));

    /// <summary>Получить подзапрос поиска групп пользователя</summary>
    /// <param name="userId"></param>
    /// <param name="recursive"></param>
    /// <returns></returns>
    public virtual SqlSubQuery GetGroupsByUserQuery(long userId, bool recursive) => (SqlSubQuery) UserGroupManager.YsnUDBOMWH4saujeO3Q(UserGroupManager.kt94HCO1g7ioBvHtt2p(UserGroupManager.N8TuGQOEcRNjmVlbx1b((object) this), UserGroupManager.lWbhBXO91FQckmxlHmy(recursive ? UserGroupManager.oZL6bEO5iiFWghxXv9n(2016571091 >> 5 ^ 62998870) : (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1277802350 ^ -1277783744), UserGroupManager.Re7A23OXGAGipJtQINB(UserGroupManager.Q3eZyMOG2VkAuAYBWoE((object) this.TransformationProvider), UserGroupManager.oZL6bEO5iiFWghxXv9n(-278393783 ^ -278394369)), UserGroupManager.Re7A23OXGAGipJtQINB((object) this.TransformationProvider.Dialect, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1744916777 - 891549337 ^ 853366844)), (object) ((Dialect) UserGroupManager.Q3eZyMOG2VkAuAYBWoE((object) this.TransformationProvider)).QuoteIfNeeded(recursive ? (string) UserGroupManager.oZL6bEO5iiFWghxXv9n(868767899 ^ 868752253) : (string) UserGroupManager.oZL6bEO5iiFWghxXv9n(2110885667 - -1624984630 ^ -559096105)))), UserGroupManager.oZL6bEO5iiFWghxXv9n(-29763048 >> 5 ^ -938736), (object) userId);

    /// <summary>Получить подзапрос поиска групп польователя</summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    public virtual SqlSubQuery GetGroupsByUserQuery(long userId) => (SqlSubQuery) UserGroupManager.tlFGQpOhOSOluNUsy5T((object) this, userId, true);

    /// <summary>Получить группы по массиву идентификаторов</summary>
    /// <param name="Ids"></param>
    /// <param name="typeGuid"></param>
    /// <returns></returns>
    public virtual IEnumerable<IUserGroup> GetGroupsByIds(
      long[] Ids,
      Guid typeGuid)
    {
      if (Ids == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788054269 >> 5 ^ -55854806));
      if (Ids.Length == 0)
        return (IEnumerable<IUserGroup>) new List<IUserGroup>();
      ICriteria criteria = this.Session.CreateCriteria(typeof (IUserGroup)).Add((ICriterion) Restrictions.In(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1976147292 - 421656521 ^ 1897164559), (ICollection) Ids));
      if (typeGuid != Guid.Empty)
        criteria.Add((ICriterion) Restrictions.Eq(this.EntityTypeUidPropertyName, (object) typeGuid));
      return (IEnumerable<IUserGroup>) this.Find(criteria);
    }

    /// <summary>Получить пользователей группы</summary>
    /// <param name="groupId"></param>
    /// <returns></returns>
    [ContextCache]
    public virtual IEnumerable<long> GetUsersByGroup(long groupId) => this.GetUsersByGroup(groupId, (UserStatus[]) null);

    /// <summary>Получить идентификаторы пользователей по группам</summary>
    /// <param name="groupIds">Идентификаторы групп пользователей</param>
    /// <returns></returns>
    public virtual IDictionary<long, List<long>> GetUsersByManyGroups(long[] groupIds) => (IDictionary<long, List<long>>) this.CreateUsersByManyGroupsSQLQuery(groupIds, (UserStatus[]) null, false, true).List<object[]>().Select(o =>
    {
      long result1 = 0;
      long result2 = 0;
      if (o[0] != null)
        long.TryParse(o[0].ToString(), out result1);
      long.TryParse(o[1].ToString(), out result2);
      // ISSUE: object of a compiler-generated type is created
      return new \u003C\u003Ef__AnonymousType2<long?, long>(result1 == 0L ? new long?() : new long?(result1), result2);
    }).GroupBy(v => v.GroupdId).ToDictionary<IGrouping<long, \u003C\u003Ef__AnonymousType2<long?, long>>, long, List<long>>(g => g.Key, g => g.Where(o => o.UserId.HasValue).Select(s => s.UserId.Value).ToList<long>());

    /// <summary>
    /// Получить пользователей группы с фильтрацией по статусу пользователя
    /// </summary>
    /// <param name="groupId">Идентификатор группы</param>
    /// <param name="userStatuses">Статусы пользователя</param>
    /// <returns>Результирующая коллекция</returns>
    public virtual IEnumerable<long> GetUsersByGroup(
      long groupId,
      UserStatus[] userStatuses)
    {
      return this.CreateUsersByGroupSQLQuery(groupId, userStatuses, false).List<object>().Select<object, long>(new Func<object, long>(Convert.ToInt64));
    }

    /// <summary>
    /// Получить пользователей группы с фильтрацией по статусу пользователя
    /// </summary>
    /// <param name="groupId">Идентификатор группы</param>
    /// <param name="userStatuses">Статусы пользователя</param>
    /// <returns>Результирующая коллекция</returns>
    public virtual IEnumerable<EleWise.ELMA.Security.Models.IUser> GetUsersByGroupAsEntity(
      long groupId,
      UserStatus[] userStatuses)
    {
      return (IEnumerable<EleWise.ELMA.Security.Models.IUser>) this.CreateUsersByGroupSQLQuery(groupId, userStatuses, true).AddEntity(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-94240706 ^ -94184782), InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>()).List<EleWise.ELMA.Security.Models.IUser>();
    }

    /// <summary>
    /// Возвращает запрос NH для получения коллекции идентификаторов пользователей или же сущностей пользователей.
    /// </summary>
    /// <param name="groupId">Идентификатор группы</param>
    /// <param name="userStatuses">Статусы пользователя</param>
    /// <param name="resultAsEntity">Тип результирующей коллекции</param>
    /// <returns>Результирующий запрос</returns>
    protected virtual ISQLQuery CreateUsersByGroupSQLQuery(
      long groupId,
      UserStatus[] userStatuses,
      bool resultAsEntity)
    {
      return this.CreateUsersByManyGroupsSQLQuery(new long[1]
      {
        groupId
      }, userStatuses, resultAsEntity);
    }

    /// <summary>
    /// Возвращает запрос NH для получения коллекции идентификаторов пользователей или же сущностей пользователей.
    /// </summary>
    /// <param name="groupIds">Идентификаторы групп</param>
    /// <param name="userStatuses">Статусы пользователя</param>
    /// <param name="resultAsEntity">Тип результирующей коллекции</param>
    /// <param name="forceGrouping">Включение принудительной выборки группы</param>
    /// <returns>Результирующий запрос</returns>
    private ISQLQuery CreateUsersByManyGroupsSQLQuery(
      long[] groupIds,
      UserStatus[] userStatuses,
      bool resultAsEntity,
      bool forceGrouping = false)
    {
      int num1 = 6;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        string str1;
        bool flag1;
        while (true)
        {
          string str2;
          string str3;
          string str4;
          string str5;
          bool flag2;
          int num3;
          switch (num2)
          {
            case 1:
              UserGroupManager.MyfQE2Op9VnWYUdpjI8((object) stringBuilder, UserGroupManager.oZL6bEO5iiFWghxXv9n(-94240706 ^ -94184664), (object) str1, UserGroupManager.Re7A23OXGAGipJtQINB((object) this.TransformationProvider.Dialect, UserGroupManager.oZL6bEO5iiFWghxXv9n(386642440 ^ 386643932)));
              num2 = 10;
              continue;
            case 2:
              goto label_12;
            case 3:
              UserGroupManager.anw8UAOOUU1aEx34fTI((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(617026523 ^ 617072897), (object) str4);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 != 0 ? 1 : 0;
              continue;
            case 4:
            case 25:
              if (flag2)
                goto case 32;
              else
                goto label_26;
            case 5:
              if (userStatuses == null)
              {
                num2 = 7;
                continue;
              }
              goto case 16;
            case 6:
              stringBuilder = new StringBuilder();
              num2 = 5;
              continue;
            case 7:
              num3 = 1;
              break;
            case 8:
              UserGroupManager.MyfQE2Op9VnWYUdpjI8((object) stringBuilder, UserGroupManager.oZL6bEO5iiFWghxXv9n(-906676699 ^ -906629995), (object) str2, (object) str3);
              num2 = 3;
              continue;
            case 9:
              UserGroupManager.MyfQE2Op9VnWYUdpjI8((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1458233619 ^ 1458190931), (object) str5, (object) string.Join<int>((string) UserGroupManager.oZL6bEO5iiFWghxXv9n(~123928154 ^ -123921239), (IEnumerable<int>) userStatuses.Cast<int>().ToArray<int>()));
              num2 = 24;
              continue;
            case 10:
              if (!flag2)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c == 0 ? 10 : 17;
                continue;
              }
              goto label_22;
            case 11:
            case 12:
            case 26:
              goto label_22;
            case 13:
              UserGroupManager.MyfQE2Op9VnWYUdpjI8((object) stringBuilder, UserGroupManager.oZL6bEO5iiFWghxXv9n(1458233619 ^ 1458191267), (object) str2, (object) str3);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 27 : 18;
              continue;
            case 14:
              if (!resultAsEntity)
              {
                num2 = 25;
                continue;
              }
              goto case 30;
            case 15:
              UserGroupManager.anw8UAOOUU1aEx34fTI((object) stringBuilder, UserGroupManager.oZL6bEO5iiFWghxXv9n(2086891181 ^ 2086909223), (object) str4);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 24 : 33;
              continue;
            case 16:
              num3 = userStatuses.Length == 0 ? 1 : 0;
              break;
            case 17:
              UserGroupManager.MyfQE2Op9VnWYUdpjI8((object) stringBuilder, UserGroupManager.oZL6bEO5iiFWghxXv9n(-1440374117 ^ -1440384549), (object) str5, (object) string.Join<int>((string) UserGroupManager.oZL6bEO5iiFWghxXv9n(-315619370 - -1325004768 ^ 1009377978), (IEnumerable<int>) userStatuses.Cast<int>().ToArray<int>()));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 != 0 ? 4 : 11;
              continue;
            case 18:
              str3 = (string) UserGroupManager.Re7A23OXGAGipJtQINB((object) this.TransformationProvider.Dialect, UserGroupManager.oZL6bEO5iiFWghxXv9n(~-192923496 ^ 192922287));
              num2 = 28;
              continue;
            case 19:
              str2 = (string) UserGroupManager.Re7A23OXGAGipJtQINB(UserGroupManager.Q3eZyMOG2VkAuAYBWoE((object) this.TransformationProvider), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-206147790 ^ -206164780));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e == 0 ? 0 : 0;
              continue;
            case 20:
              if (flag1)
              {
                num2 = 15;
                continue;
              }
              goto case 33;
            case 21:
              str1 = ((Dialect) UserGroupManager.Q3eZyMOG2VkAuAYBWoE((object) this.TransformationProvider)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-347045778 ^ -347045182));
              num2 = 19;
              continue;
            case 22:
              UserGroupManager.MyfQE2Op9VnWYUdpjI8((object) stringBuilder, UserGroupManager.oZL6bEO5iiFWghxXv9n(2110195605 ^ 2110250115), (object) str1, UserGroupManager.Re7A23OXGAGipJtQINB(UserGroupManager.Q3eZyMOG2VkAuAYBWoE((object) this.TransformationProvider), UserGroupManager.oZL6bEO5iiFWghxXv9n(-522456341 ^ -522455233)));
              num2 = 9;
              continue;
            case 23:
            case 31:
              goto label_30;
            case 24:
              UserGroupManager.anw8UAOOUU1aEx34fTI((object) stringBuilder, UserGroupManager.oZL6bEO5iiFWghxXv9n(-1880054609 ^ -1880064237), (object) str1);
              num2 = 26;
              continue;
            case 27:
              UserGroupManager.anw8UAOOUU1aEx34fTI((object) stringBuilder, UserGroupManager.oZL6bEO5iiFWghxXv9n(-845204010 ^ 2052495102 ^ -1211532814), (object) str4);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a == 0 ? 22 : 22;
              continue;
            case 28:
              str5 = (string) UserGroupManager.Re7A23OXGAGipJtQINB(UserGroupManager.Q3eZyMOG2VkAuAYBWoE((object) this.TransformationProvider), UserGroupManager.oZL6bEO5iiFWghxXv9n(-94240706 ^ -94239262));
              num2 = 2;
              continue;
            case 29:
              UserGroupManager.anw8UAOOUU1aEx34fTI((object) stringBuilder, UserGroupManager.oZL6bEO5iiFWghxXv9n(447286529 ^ 447338459), (object) str4);
              num2 = 12;
              continue;
            case 30:
              UserGroupManager.sgThhjOBlKcFBMVKCwy((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(839394233 ^ 839448875));
              num2 = 8;
              continue;
            case 32:
              stringBuilder.AppendFormat((string) UserGroupManager.oZL6bEO5iiFWghxXv9n(--1403802000 ^ 1403816698), (object) str1);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba == 0 ? 20 : 9;
              continue;
            case 33:
              UserGroupManager.anw8UAOOUU1aEx34fTI((object) stringBuilder, UserGroupManager.oZL6bEO5iiFWghxXv9n(1530848604 ^ 1530806012), (object) str2);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_697e4e741c714ce086e1f4271fcc4947 != 0 ? 15 : 29;
              continue;
            default:
              str4 = (string) UserGroupManager.Re7A23OXGAGipJtQINB(UserGroupManager.Q3eZyMOG2VkAuAYBWoE((object) this.TransformationProvider), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1200636245 >> 6 ^ 18760883));
              num2 = 18;
              continue;
          }
          flag2 = num3 != 0;
          num2 = 21;
        }
label_12:
        flag1 = groupIds.Length > 1 | forceGrouping;
        num1 = 14;
        continue;
label_26:
        num1 = 23;
        continue;
label_30:
        UserGroupManager.anw8UAOOUU1aEx34fTI((object) stringBuilder, UserGroupManager.oZL6bEO5iiFWghxXv9n(-1212789817 - 1827404527 ^ 1254788018), (object) str1);
        num1 = 13;
      }
label_22:
      return (ISQLQuery) UserGroupManager.MgNarWOFYfwQkW2eJ1i(UserGroupManager.ew3G4GOTKst29XD92JG((object) ((ISession) UserGroupManager.N8TuGQOEcRNjmVlbx1b((object) this)).CreateSQLQuery(stringBuilder.ToString()), false), UserGroupManager.oZL6bEO5iiFWghxXv9n(150349507 - 521039768 ^ -370709301), (object) groupIds);
    }

    /// <summary>Загрузить группу по имени</summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public IUserGroup Load(string name) => ((ICriteria) UserGroupManager.TINv3UOdjKd4oVCAjsE(UserGroupManager.RVctOEOvWO8kAYN53PE((object) this, (object) null), UserGroupManager.TD57ufOqF16elZ8BfbN(UserGroupManager.oZL6bEO5iiFWghxXv9n(581409346 ^ 581390232), (object) name))).UniqueResult<IUserGroup>();

    public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
    {
      int num1 = 18;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          ILicensedUnit licensedUnit;
          List<long> list;
          IConcurrentLicenseInfo concurrentLicenseInfo1;
          IUserGroupFilter userGroupFilter;
          IConcurrentLicenseInfo concurrentLicenseInfo2;
          switch (num2)
          {
            case 1:
              UserGroupManager.TINv3UOdjKd4oVCAjsE((object) criteria, (object) Expression.Sql(string.Format((string) UserGroupManager.oZL6bEO5iiFWghxXv9n(1762575989 ^ 1762532737), UserGroupManager.Re7A23OXGAGipJtQINB(UserGroupManager.Q3eZyMOG2VkAuAYBWoE((object) this.TransformationProvider), UserGroupManager.oZL6bEO5iiFWghxXv9n(-801309555 ^ -801310375)), UserGroupManager.wGmrvITbalt6dMML5gv((object) this.TransformationProvider, UserGroupManager.oZL6bEO5iiFWghxXv9n(1013954274 ^ 1013934728), UserGroupManager.oZL6bEO5iiFWghxXv9n(-1640694811 << 2 ^ 2027107088)), UserGroupManager.jvOqlrTKNfJueSbhhpC(UserGroupManager.Q3eZyMOG2VkAuAYBWoE((object) this.TransformationProvider), DbType.Int64)), new object[2]
              {
                (object) string.Join<long>((string) UserGroupManager.oZL6bEO5iiFWghxXv9n(-817081027 ^ 243500131 ^ -1043347672), (IEnumerable<long>) list),
                UserGroupManager.oZL6bEO5iiFWghxXv9n(19590779 ^ 19593229)
              }, (IType[]) new StringType[2]
              {
                (StringType) NHibernateUtil.StringClob,
                NHibernateUtil.String
              }));
              num2 = 19;
              continue;
            case 2:
            case 4:
            case 19:
              UserGroupManager.lbNJllTobYL0rHipLdw((object) this, (object) criteria, (object) filter);
              num2 = 10;
              continue;
            case 3:
            case 15:
              UserGroupManager.TINv3UOdjKd4oVCAjsE((object) criteria, UserGroupManager.nTZy43Oz48ScojKEHqC(UserGroupManager.TD57ufOqF16elZ8BfbN((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1224834736 ^ 1224834066), (object) SecurityConstants.PrivilegeUsersGroupUid)));
              num2 = 22;
              continue;
            case 5:
              UserGroupManager.TINv3UOdjKd4oVCAjsE((object) criteria, UserGroupManager.YnlHl8TRBN2m4VwqEqY(UserGroupManager.UJt1bjTUoIwQJ8hPDIJ(UserGroupManager.oZL6bEO5iiFWghxXv9n(-2143851882 - 923330995 ^ 1227785527)), (object) list));
              num2 = 4;
              continue;
            case 6:
            case 20:
              licensedUnit = (ILicensedUnit) UserGroupManager.ippKF6OLvZLUVAth1QX(UserGroupManager.PCgZ3EOnHaC4FPpQSYD(UserGroupManager.AhKxyhOeHpcOtLeuDxJ()));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 != 0 ? 0 : 0;
              continue;
            case 7:
              goto label_17;
            case 8:
              IEnumerable<Worker> source = userGroupFilter.Workers.Where<Worker>((Func<Worker, bool>) (w =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (UserGroupManager.\u003C\u003Ec.nVakUnwSjshW9TjkwklJ((object) w) == UserGroupManager.\u003C\u003Ec.tHotiEwSNv8lP9RLfVw7())
                      {
                        num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_5;
                    default:
                      goto label_4;
                  }
                }
label_4:
                // ISSUE: reference to a compiler-generated method
                return UserGroupManager.\u003C\u003Ec.HWXEwTwS0Whp9kN9RNWt((object) w) > 0L;
label_5:
                return false;
              }));
              // ISSUE: reference to a compiler-generated field
              Func<Worker, long> func = UserGroupManager.\u003C\u003Ec.\u003C\u003E9__23_1;
              Func<Worker, long> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                UserGroupManager.\u003C\u003Ec.\u003C\u003E9__23_1 = selector = (Func<Worker, long>) (w => UserGroupManager.\u003C\u003Ec.HWXEwTwS0Whp9kN9RNWt((object) w));
              }
              else
                goto label_35;
label_34:
              list = source.Select<Worker, long>(selector).ToList<long>();
              num2 = 14;
              continue;
label_35:
              selector = func;
              goto label_34;
            case 9:
              concurrentLicenseInfo2 = (IConcurrentLicenseInfo) null;
              break;
            case 10:
              goto label_32;
            case 11:
              if (userGroupFilter.Workers != null)
              {
                num2 = 13;
                continue;
              }
              goto case 2;
            case 12:
              if (!UserGroupManager.Uss1sOOHwy30X8icME4((object) concurrentLicenseInfo1))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_48ade2120f174ae893844a7b8cec6997 == 0 ? 3 : 3;
                continue;
              }
              goto case 22;
            case 13:
              if (UserGroupManager.n0TUMjTu4txAZlM85sL((object) userGroupFilter.Workers) > 0)
              {
                num2 = 8;
                continue;
              }
              goto case 2;
            case 14:
              if (UserGroupManager.LOXIZsTwgvI2KyJxg1y((object) list) > 1000)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0 ? 1 : 1;
                continue;
              }
              goto case 5;
            case 16:
              if (concurrentLicenseInfo1 != null)
                goto case 12;
              else
                goto label_11;
            case 17:
              if (!(UserGroupManager.OZRE3OOgXMfqBfUADxB((object) filter) == (System.Type) null))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_87c34df25735471595e3f4057325aa6c == 0 ? 5 : 6;
                continue;
              }
              goto label_17;
            case 18:
              if (filter != null)
              {
                num2 = 17;
                continue;
              }
              goto label_17;
            case 21:
              if (userGroupFilter == null)
              {
                num2 = 2;
                continue;
              }
              goto case 11;
            case 22:
              userGroupFilter = filter as IUserGroupFilter;
              num2 = 21;
              continue;
            default:
              if (licensedUnit == null)
              {
                num2 = 9;
                continue;
              }
              concurrentLicenseInfo2 = UserGroupManager.fXuLVeO2fMOrLqCsidn((object) licensedUnit) as IConcurrentLicenseInfo;
              break;
          }
          concurrentLicenseInfo1 = concurrentLicenseInfo2;
          num2 = 16;
        }
label_11:
        num1 = 15;
        continue;
label_17:
        criteria.Add((ICriterion) UserGroupManager.TD57ufOqF16elZ8BfbN(UserGroupManager.CJF5DvOJ8TewEX1ie9Q((object) this), (object) UserGroupManager.qpiuhDOINAU62ZwZVWo((object) this)));
        num1 = 20;
      }
label_32:;
    }

    public uint? GetMaxGroupUsersCount(IUserGroup group)
    {
      // ISSUE: reference to a compiler-generated method
      ILicensedModuleAccessGroup moduleAccessGroup1 = ComponentManager.Current.GetExtensionPoints<ILicensedModuleAccessGroup>().FirstOrDefault<ILicensedModuleAccessGroup>((Func<ILicensedModuleAccessGroup, bool>) (g => g.UserGroupUid == UserGroupManager.\u003C\u003Ec__DisplayClass24_0.td6Sq1wSYYItNDJfRx5O((object) group)));
      if (moduleAccessGroup1 != null && ComponentManager.Current.ModuleManager.FindUnitByUid(moduleAccessGroup1.ModuleUid) is ILicensedUnit unitByUid1 && unitByUid1.GetLicenseInfo() is IWorkplaceLicenseInfo licenseInfo1 && licenseInfo1.WorkplaceCount.HasValue)
        return new uint?(licenseInfo1.WorkplaceCount.Value);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      IPrivilegeModuleAccessGroup moduleAccessGroup2 = ComponentManager.Current.GetExtensionPoints<IPrivilegeModuleAccessGroup>().FirstOrDefault<IPrivilegeModuleAccessGroup>((Func<IPrivilegeModuleAccessGroup, bool>) (g => UserGroupManager.\u003C\u003Ec__DisplayClass24_0.rfwNcvwSVnupQjFJ3DUT(UserGroupManager.\u003C\u003Ec__DisplayClass24_0.E70r9gwSyq5kaAwEw1Tu((object) g), group.Uid)));
      return moduleAccessGroup2 != null && ComponentManager.Current.ModuleManager.FindUnitByUid(moduleAccessGroup2.ModuleUid) is ILicensedUnit unitByUid2 && unitByUid2.GetLicenseInfo() is IConcurrentLicenseInfo licenseInfo2 ? licenseInfo2.PrivilegeCount : new uint?();
    }

    /// <summary>Сохранить группу пользователей в БД</summary>
    /// <param name="obj">Объект для сохранения</param>
    [PublicApiMember]
    [Transaction]
    public override void Save(IUserGroup obj)
    {
      int num = 7;
      uint? maxGroupUsersCount;
      int licensedGroupUsers;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_15;
          case 1:
            base.Save(obj);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_7;
          case 3:
            goto label_9;
          case 4:
            obj.Groups.Clear();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0 ? 1 : 1;
            continue;
          case 5:
            if (maxGroupUsersCount.HasValue)
            {
              num = 8;
              continue;
            }
            goto case 1;
          case 6:
            maxGroupUsersCount = this.GetMaxGroupUsersCount(obj);
            num = 5;
            continue;
          case 7:
            if (!this.HasCircle(obj))
            {
              num = 6;
              continue;
            }
            goto label_7;
          case 8:
            licensedGroupUsers = UserGroupManager.GetLicensedGroupUsers((IEnumerable) obj.Users);
            num = 9;
            continue;
          case 9:
            if ((long) licensedGroupUsers <= (long) maxGroupUsersCount.Value)
            {
              UserGroupManager.odRyoYTkAmBUQ8UOkmH((object) obj.OrganizationItems);
              num = 4;
              continue;
            }
            num = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_15:
      return;
label_2:
      return;
label_7:
      throw new InvalidOperationException((string) UserGroupManager.nEcAPdTtRmVbx3i7QRk(UserGroupManager.oZL6bEO5iiFWghxXv9n(-1743015995 ^ -1743031467)));
label_9:
      throw new LicenseException((string) UserGroupManager.UrGGADT6Aa3wgd8yoRl((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-389167216 ^ -389211320), (object) new object[3]
      {
        UserGroupManager.mc8h7WTmraPiHWxcgbp((object) obj),
        (object) maxGroupUsersCount.Value,
        (object) ((long) licensedGroupUsers - (long) maxGroupUsersCount.Value)
      }));
    }

    public static int GetLicensedGroupUsers(IEnumerable groupUsers)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (groupUsers != null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 0 : 0;
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
      return 0;
label_5:
      return groupUsers.OfType<EleWise.ELMA.Security.Models.IUser>().Count<EleWise.ELMA.Security.Models.IUser>((Func<EleWise.ELMA.Security.Models.IUser, bool>) (u =>
      {
        int num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (UserGroupManager.\u003C\u003Ec.W5J8VbwSZpMYFYX5C2OH((object) u) == UserStatus.Active)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return UserGroupManager.\u003C\u003Ec.d3JxinwSs4fHv79hHvyD(UserGroupManager.\u003C\u003Ec.ASYKB8wSA4S0oiAm8WaJ((object) u), SecurityConstants.AdminUserUid);
label_5:
        return false;
      }));
    }

    public bool HasCircle(IUserGroup userGroup) => UserGroupManager.FindCircle((object) userGroup, (ISet<IUserGroup>) new HashSet<IUserGroup>(), (object) userGroup);

    private static bool FindCircle(object findGroup, ISet<IUserGroup> set, object userGroup)
    {
      foreach (IUserGroup group in (IEnumerable<IUserGroup>) ((IUserGroup) userGroup).Groups)
      {
        if (group == findGroup)
          return true;
        if (!set.Contains(group))
        {
          set.Add(group);
          if (UserGroupManager.FindCircle(findGroup, set, (object) group))
            return true;
        }
      }
      return false;
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
            type = InterfaceActivator.TypeOf<IUserGroup>();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      ExportRuleList exportRuleList = new ExportRuleList();
      ExportRule exportRule1 = new ExportRule();
      UserGroupManager.QogvoqTDyrdgrykDMLi((object) exportRule1, type);
      UserGroupManager.scWJgSTaIEJRy7j10Yp((object) exportRule1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1807813747 ^ -1807865091));
      exportRule1.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule1);
      ExportRule exportRule2 = new ExportRule();
      UserGroupManager.QogvoqTDyrdgrykDMLi((object) exportRule2, type);
      exportRule2.PropertyName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(4869926 >> 3 ^ 590942);
      exportRule2.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule2);
      ExportRule exportRule3 = new ExportRule();
      UserGroupManager.QogvoqTDyrdgrykDMLi((object) exportRule3, type);
      UserGroupManager.scWJgSTaIEJRy7j10Yp((object) exportRule3, UserGroupManager.oZL6bEO5iiFWghxXv9n(-1880054609 ^ -1880067809));
      UserGroupManager.Wdmw6mTx50VS3xfYnLf((object) exportRule3, ExportRuleType.Export);
      exportRuleList.Add(exportRule3);
      ExportRule exportRule4 = new ExportRule();
      UserGroupManager.QogvoqTDyrdgrykDMLi((object) exportRule4, type);
      exportRule4.PropertyName = (string) UserGroupManager.oZL6bEO5iiFWghxXv9n(-814831182 ^ -814815340);
      UserGroupManager.Wdmw6mTx50VS3xfYnLf((object) exportRule4, ExportRuleType.Export);
      exportRuleList.Add(exportRule4);
      ExportRule exportRule5 = new ExportRule();
      UserGroupManager.QogvoqTDyrdgrykDMLi((object) exportRule5, type);
      UserGroupManager.scWJgSTaIEJRy7j10Yp((object) exportRule5, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-201065280 ^ -201088402));
      exportRule5.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule5);
      ExportRule exportRule6 = new ExportRule();
      UserGroupManager.QogvoqTDyrdgrykDMLi((object) exportRule6, type);
      UserGroupManager.scWJgSTaIEJRy7j10Yp((object) exportRule6, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1277472395 ^ -1277454573));
      exportRule6.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule6);
      ExportRule exportRule7 = new ExportRule();
      UserGroupManager.QogvoqTDyrdgrykDMLi((object) exportRule7, type);
      UserGroupManager.scWJgSTaIEJRy7j10Yp((object) exportRule7, UserGroupManager.oZL6bEO5iiFWghxXv9n(-278393783 ^ -278343199));
      exportRule7.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule7);
      ExportRule exportRule8 = new ExportRule();
      UserGroupManager.QogvoqTDyrdgrykDMLi((object) exportRule8, type);
      exportRule8.PropertyName = (string) UserGroupManager.oZL6bEO5iiFWghxXv9n(1658561670 << 4 ^ 767202776);
      UserGroupManager.Wdmw6mTx50VS3xfYnLf((object) exportRule8, ExportRuleType.Export);
      exportRuleList.Add(exportRule8);
      ExportRule exportRule9 = new ExportRule();
      UserGroupManager.QogvoqTDyrdgrykDMLi((object) exportRule9, type);
      UserGroupManager.scWJgSTaIEJRy7j10Yp((object) exportRule9, UserGroupManager.oZL6bEO5iiFWghxXv9n(386642440 ^ 386625496));
      UserGroupManager.Wdmw6mTx50VS3xfYnLf((object) exportRule9, ExportRuleType.Export);
      exportRuleList.Add(exportRule9);
      ExportRule exportRule10 = new ExportRule();
      UserGroupManager.QogvoqTDyrdgrykDMLi((object) exportRule10, type);
      UserGroupManager.scWJgSTaIEJRy7j10Yp((object) exportRule10, UserGroupManager.oZL6bEO5iiFWghxXv9n(~-272519830 ^ 272533327));
      exportRule10.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule10);
      ExportRule exportRule11 = new ExportRule();
      UserGroupManager.QogvoqTDyrdgrykDMLi((object) exportRule11, type);
      exportRule11.PropertyName = (string) UserGroupManager.oZL6bEO5iiFWghxXv9n(-845204010 ^ 2052495102 ^ -1211531572);
      UserGroupManager.Wdmw6mTx50VS3xfYnLf((object) exportRule11, ExportRuleType.Export);
      exportRuleList.Add(exportRule11);
      ExportRule exportRule12 = new ExportRule();
      UserGroupManager.QogvoqTDyrdgrykDMLi((object) exportRule12, type);
      UserGroupManager.scWJgSTaIEJRy7j10Yp((object) exportRule12, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(631805505 ^ 631780863));
      UserGroupManager.Wdmw6mTx50VS3xfYnLf((object) exportRule12, ExportRuleType.Export);
      exportRuleList.Add(exportRule12);
      ExportRule exportRule13 = new ExportRule();
      exportRule13.ParentType = type;
      UserGroupManager.scWJgSTaIEJRy7j10Yp((object) exportRule13, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1893095749 ^ -1893096423));
      UserGroupManager.Wdmw6mTx50VS3xfYnLf((object) exportRule13, ExportRuleType.Export);
      exportRuleList.Add(exportRule13);
      ExportRule exportRule14 = new ExportRule();
      UserGroupManager.QogvoqTDyrdgrykDMLi((object) exportRule14, type);
      UserGroupManager.scWJgSTaIEJRy7j10Yp((object) exportRule14, UserGroupManager.oZL6bEO5iiFWghxXv9n(-1880054609 ^ -1880065371));
      UserGroupManager.Wdmw6mTx50VS3xfYnLf((object) exportRule14, ExportRuleType.Export);
      exportRuleList.Add(exportRule14);
      ExportRule exportRule15 = new ExportRule();
      exportRule15.ParentType = type;
      exportRule15.PropertyName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-979995965 << 4 ^ 1499969774);
      UserGroupManager.Wdmw6mTx50VS3xfYnLf((object) exportRule15, ExportRuleType.Export);
      exportRuleList.Add(exportRule15);
      return exportRuleList;
    }

    /// <summary>Принадлежит ли пользователь к данной группе</summary>
    /// <example>
    /// <para>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.PortalApiRoot.SecurityPortalApi.UserSecurityApi.Load(System.Int64)">Как загрузить пользователя</seealso>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.PortalApiRoot.SecurityPortalApi.UserGroupSecurityApi.Load(System.Int64)">Как загрузить группу пользователей</seealso>
    /// </para>
    /// <code>
    /// //загружаем пользователя по идентификатору
    /// var user = PublicAPI.Portal.Security.User.Load(3);
    /// //загружаем группу пользователей по идентификатору
    /// var userGroup = PublicAPI.Portal.Security.UserGroup.Load(3);
    /// 
    /// //проверяем на наличие пользователя в группе
    /// var check = PublicAPI.Portal.Security.UserGroup.CheckUserInGroup(user, userGroup);
    /// 
    /// //check = true, если пользователь принадлежит группе
    /// //check = false, если пользователь не принадлежит данной группе
    /// </code>
    /// </example>
    /// <param name="user">Пользователь</param>
    /// <param name="userGroup">Группа</param>
    /// <returns><c>true</c> если пользователь состоит в группе</returns>
    [PublicApiMember]
    public virtual bool CheckUserInGroup(EleWise.ELMA.Security.Models.IUser user, IUserGroup userGroup) => ((UserGroupManager) UserGroupManager.hhejKoTC7ofZRwakvme()).GetUsersByGroup(userGroup.Id).Contains<long>(user.Id);

    /// <summary>Получить всех пользователей группы</summary>
    /// <example>
    /// <para>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.PortalApiRoot.SecurityPortalApi.UserGroupSecurityApi.Load(System.Int64)">Как загрузить группу пользователей</seealso>
    /// </para>
    /// <code>
    /// //загружаем группу пользователей по идентификатору
    /// var userGroup = PublicAPI.Portal.Security.UserGroup.Load(3);
    /// 
    /// //получаем список пользователей
    /// var users = PublicAPI.Portal.Security.UserGroup.GetUsersByGroup(userGroup);
    /// </code>
    /// </example>
    /// <returns>Список пользователей</returns>
    [PublicApiMember]
    public virtual IEnumerable<EleWise.ELMA.Security.IUser> GetUsersByGroup(
      IUserGroup userGroup)
    {
      return (IEnumerable<EleWise.ELMA.Security.IUser>) this.GetUsersByGroup(userGroup, (UserStatus[]) null);
    }

    /// <summary>
    /// Получить всех пользователей группы с учетом статуса пользователя
    /// </summary>
    /// <example>
    /// <para>
    /// <seealso cref="M:EleWise.ELMA.API.PublicAPI.PortalApiRoot.SecurityPortalApi.UserGroupSecurityApi.Load(System.Int64)">Как загрузить группу пользователей</seealso>
    /// </para>
    /// <code>
    /// //загружаем группу пользователей по идентификатору
    /// var userGroup = PublicAPI.Portal.Security.UserGroup.Load(3);
    /// 
    /// //получаем список пользователей
    /// var users = PublicAPI.Portal.Security.UserGroup.GetUsersByGroup(userGroup, new[] { UserStatus.Active });
    /// </code>
    /// </example>
    /// <returns>Список пользователей</returns>
    [PublicApiMember]
    public virtual IEnumerable<EleWise.ELMA.Security.Models.IUser> GetUsersByGroup(
      IUserGroup userGroup,
      UserStatus[] userStatus)
    {
      return this.GetUsersByGroupAsEntity(userGroup.Id, userStatus);
    }

    public UserGroupManager()
    {
      UserGroupManager.wWyLukTiOqTWNIyjFwh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bd9d1e4a221644c1bfc13a9d3bf9ad40 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool vqHM7HOPYvhACwKOQsD() => UserGroupManager.bnikLFOcPNO3f8cP6uv == null;

    internal static UserGroupManager lO9rGOOQMxO2uPq3F26() => UserGroupManager.bnikLFOcPNO3f8cP6uv;

    internal static void iba1VkO8Hp1ByP0if9U([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((EntityManager<IUserGroup, long>) obj0).SetupAutoFilter((ICriteria) obj1, (IEntityFilter) obj2));

    internal static object oZL6bEO5iiFWghxXv9n(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object TINv3UOdjKd4oVCAjsE([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object N8TuGQOEcRNjmVlbx1b([In] object obj0) => (object) ((NHManagerBase) obj0).Session;

    internal static object Q3eZyMOG2VkAuAYBWoE([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object Re7A23OXGAGipJtQINB([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object lWbhBXO91FQckmxlHmy([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) string.Format((string) obj0, obj1, obj2, obj3);

    internal static object kt94HCO1g7ioBvHtt2p([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).CreateSQLSubQuery((string) obj1);

    internal static object YsnUDBOMWH4saujeO3Q([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((SqlSubQuery) obj0).SetParameter((string) obj1, obj2);

    internal static object tlFGQpOhOSOluNUsy5T([In] object obj0, long userId, bool recursive) => (object) ((UserGroupManager) obj0).GetGroupsByUserQuery(userId, recursive);

    internal static object sgThhjOBlKcFBMVKCwy([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static object MyfQE2Op9VnWYUdpjI8([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) ((StringBuilder) obj0).AppendFormat((string) obj1, obj2, obj3);

    internal static object anw8UAOOUU1aEx34fTI([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((StringBuilder) obj0).AppendFormat((string) obj1, obj2);

    internal static object ew3G4GOTKst29XD92JG([In] object obj0, [In] bool obj1) => (object) ((IQuery) obj0).CleanUpCache(obj1);

    internal static object MgNarWOFYfwQkW2eJ1i([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IQuery) obj0).SetParameterList((string) obj1, (IEnumerable) obj2);

    internal static object RVctOEOvWO8kAYN53PE([In] object obj0, [In] object obj1) => (object) ((EntityManager<IUserGroup, long>) obj0).CreateCriteria((IEntityFilter) obj1);

    internal static object TD57ufOqF16elZ8BfbN([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static System.Type OZRE3OOgXMfqBfUADxB([In] object obj0) => ((IEntityFilter) obj0).Subtype;

    internal static object CJF5DvOJ8TewEX1ie9Q([In] object obj0) => (object) ((EntityManager<IUserGroup, long>) obj0).EntityTypeUidPropertyName;

    internal static Guid qpiuhDOINAU62ZwZVWo([In] object obj0) => ((EntityManager<IUserGroup, long>) obj0).ImplementationTypeUid;

    internal static object AhKxyhOeHpcOtLeuDxJ() => (object) ComponentManager.Current;

    internal static object PCgZ3EOnHaC4FPpQSYD([In] object obj0) => (object) ((ComponentManager) obj0).ModuleManager;

    internal static object ippKF6OLvZLUVAth1QX([In] object obj0) => (object) ((IModuleManager) obj0).MainLicensedUnit;

    internal static object fXuLVeO2fMOrLqCsidn([In] object obj0) => (object) ((ILicensedUnit) obj0).GetLicenseInfo();

    internal static bool Uss1sOOHwy30X8icME4([In] object obj0) => ((IConcurrentLicenseInfo) obj0).IsConcurrent;

    internal static object nTZy43Oz48ScojKEHqC([In] object obj0) => (object) Restrictions.Not((ICriterion) obj0);

    internal static int n0TUMjTu4txAZlM85sL([In] object obj0) => ((List<Worker>) obj0).Count;

    internal static int LOXIZsTwgvI2KyJxg1y([In] object obj0) => ((List<long>) obj0).Count;

    internal static object wGmrvITbalt6dMML5gv([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((ITransformationProvider) obj0).TableFunction((string) obj1, (string) obj2);

    internal static object jvOqlrTKNfJueSbhhpC([In] object obj0, [In] DbType obj1) => (object) ((Dialect) obj0).GetTypeName(obj1);

    internal static object UJt1bjTUoIwQJ8hPDIJ([In] object obj0) => (object) Projections.Property((string) obj0);

    internal static object YnlHl8TRBN2m4VwqEqY([In] object obj0, [In] object obj1) => (object) Restrictions.In((IProjection) obj0, (ICollection) obj1);

    internal static void lbNJllTobYL0rHipLdw([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((EntityManager<IUserGroup, long>) obj0).SetupFilter((ICriteria) obj1, (IEntityFilter) obj2));

    internal static object nEcAPdTtRmVbx3i7QRk([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object mc8h7WTmraPiHWxcgbp([In] object obj0) => (object) ((IUserGroup) obj0).Name;

    internal static object UrGGADT6Aa3wgd8yoRl([In] object obj0, [In] object obj1) => (object) EleWise.ELMA.SR.T((string) obj0, (object[]) obj1);

    internal static void odRyoYTkAmBUQ8UOkmH([In] object obj0) => ((ICollection<IOrganizationItem>) obj0).Clear();

    internal static void QogvoqTDyrdgrykDMLi([In] object obj0, [In] System.Type obj1) => ((ExportRule) obj0).ParentType = obj1;

    internal static void scWJgSTaIEJRy7j10Yp([In] object obj0, [In] object obj1) => ((ExportRule) obj0).PropertyName = (string) obj1;

    internal static void Wdmw6mTx50VS3xfYnLf([In] object obj0, [In] ExportRuleType obj1) => ((ExportRule) obj0).ExportRuleType = obj1;

    internal static object hhejKoTC7ofZRwakvme() => (object) UserGroupManager.Instance;

    internal static void wWyLukTiOqTWNIyjFwh() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    [Component]
    internal class SecurityCacheSetIdAction : ISecurityCacheSetIdAction
    {
      private static UserGroupManager.SecurityCacheSetIdAction FrJZEVwrLw6Pf0HUlLMo;

      public void Execute()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              UserGroupManager.SecurityCacheSetIdAction.vLefTUwSwhd27mVxxrAT(UserGroupManager.SecurityCacheSetIdAction.mno6muwrzujs7MWt2IDy(), UserGroupManager.SecurityCacheSetIdAction.QJC6RowSuoXQGMoE32mi(-517128429 ^ -517085533));
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public SecurityCacheSetIdAction()
      {
        UserGroupManager.SecurityCacheSetIdAction.qS5c0xwSbgQos0CPSfLv();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object mno6muwrzujs7MWt2IDy() => (object) UserGroupManager.ComplexCacheService;

      internal static object QJC6RowSuoXQGMoE32mi(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static void vLefTUwSwhd27mVxxrAT([In] object obj0, [In] object obj1) => ((IComplexCacheService) obj0).RefreshTimestamp((string) obj1);

      internal static bool Vu00dJwr2YvOF8HrjnQU() => UserGroupManager.SecurityCacheSetIdAction.FrJZEVwrLw6Pf0HUlLMo == null;

      internal static UserGroupManager.SecurityCacheSetIdAction xqdkGcwrHvk55lwiYKHM() => UserGroupManager.SecurityCacheSetIdAction.FrJZEVwrLw6Pf0HUlLMo;

      internal static void qS5c0xwSbgQos0CPSfLv() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.UpdateUserSecuritySetCacheQueueManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Actors;
using EleWise.ELMA.Security.Events;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Listeners;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Служба для управления очередью обновления UserSecuritySetCache
  /// </summary>
  [Service]
  public class UpdateUserSecuritySetCacheQueueManager
  {
    internal const string TableName = "UpdateUSSCQueue";
    internal const string UidColumnName = "Uid";
    internal const string CreationDateColumnName = "CreationDate";
    internal const string DataColumnName = "Data";
    private readonly ITransformationProvider transformationProvider;
    private readonly ILockManager lockManager;
    private readonly ISessionProvider sessionProvider;
    private readonly IUnitOfWorkManager unitOfWorkManager;
    private readonly IEnumerable<ISecurityCacheSetIdAction> securityCacheSetIdAction;
    private readonly ISecurityCacheSetIdEventHandler securityCacheSetIdEventHandler;
    private readonly IActorModelRuntime actorModelRuntime;
    private static readonly ILogger Logger;
    private static UpdateUserSecuritySetCacheQueueManager g6dYg5WI6dJBV7p5lZc;

    /// <summary>ctor</summary>
    /// <param name="transformationProvider">Интерфейс провайдера преобразования БД</param>
    /// <param name="lockManager">Интерфейс менеджера блокировок</param>
    /// <param name="sessionProvider">Провайдер сессий NHibernate</param>
    /// <param name="unitOfWorkManager">Фабрика единиц работ</param>
    /// <param name="securityCacheSetIdAction">Действия на сброс кэша для Security</param>
    /// <param name="securityCacheSetIdEventHandler">Обработчик события после изменения структуры групп или оргструктур</param>
    /// <param name="actorModelRuntime">Интерфейс Модели Акторов</param>
    public UpdateUserSecuritySetCacheQueueManager(
      ITransformationProvider transformationProvider,
      ILockManager lockManager,
      ISessionProvider sessionProvider,
      IUnitOfWorkManager unitOfWorkManager,
      IEnumerable<ISecurityCacheSetIdAction> securityCacheSetIdAction,
      ISecurityCacheSetIdEventHandler securityCacheSetIdEventHandler,
      IActorModelRuntime actorModelRuntime)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.transformationProvider = transformationProvider;
      this.lockManager = lockManager;
      this.sessionProvider = sessionProvider;
      this.unitOfWorkManager = unitOfWorkManager;
      this.securityCacheSetIdAction = securityCacheSetIdAction;
      this.securityCacheSetIdEventHandler = securityCacheSetIdEventHandler;
      this.actorModelRuntime = actorModelRuntime;
    }

    private static TimeSpan WaitTimeSpan
    {
      get
      {
        int num1 = 1;
        int setting;
        while (true)
        {
          switch (num1)
          {
            case 1:
              setting = EleWise.ELMA.SR.GetSetting<int>((string) UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-1277472395 ^ -1277489889));
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            default:
              if (setting <= 0)
              {
                num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 2 : 2;
                continue;
              }
              goto label_6;
          }
        }
label_5:
        int num2 = 0;
        goto label_7;
label_6:
        num2 = setting;
label_7:
        return TimeSpan.FromSeconds((double) num2);
      }
    }

    internal void ExecuteFullUpdate(bool needlock = true)
    {
      int num1 = 4;
      IDisposable disposable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_26;
          case 2:
label_25:
            IEnumerable<ISecurityCacheSetIdAction> cacheSetIdAction = this.securityCacheSetIdAction;
            // ISSUE: reference to a compiler-generated field
            Action<ISecurityCacheSetIdAction> action1 = UpdateUserSecuritySetCacheQueueManager.\u003C\u003Ec.\u003C\u003E9__17_0;
            Action<ISecurityCacheSetIdAction> action2;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              UpdateUserSecuritySetCacheQueueManager.\u003C\u003Ec.\u003C\u003E9__17_0 = action2 = (Action<ISecurityCacheSetIdAction>) (a => UpdateUserSecuritySetCacheQueueManager.\u003C\u003Ec.dHttj8w3LZpe04CVWElE((object) a));
            }
            else
              goto label_29;
label_28:
            cacheSetIdAction.ForEach<ISecurityCacheSetIdAction>(action2);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 == 0 ? 5 : 7;
            continue;
label_29:
            action2 = action1;
            goto label_28;
          case 3:
            if (!needlock)
            {
              num1 = 8;
              continue;
            }
            goto case 5;
          case 4:
            disposable = (IDisposable) null;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e == 0 ? 2 : 3;
            continue;
          case 5:
            disposable = (IDisposable) UpdateUserSecuritySetCacheQueueManager.iNuIPLW2LcuVPDpU1US((object) this.lockManager, UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(1658561670 << 4 ^ 767169748));
            num1 = 6;
            continue;
          case 6:
          case 8:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 0 : 0;
            continue;
          case 7:
            ISecurityCacheSetIdEventHandler setIdEventHandler = this.securityCacheSetIdEventHandler;
            SecurityCacheSetIdEventArgs cacheSetIdEventArgs = new SecurityCacheSetIdEventArgs();
            UpdateUserSecuritySetCacheQueueManager.xQg1lcrodEhBZIjAlSV((object) cacheSetIdEventArgs, true);
            UpdateUserSecuritySetCacheQueueManager.zcetITrtMQgXnNm7Ql0((object) setIdEventHandler, (object) cacheSetIdEventArgs);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc == 0 ? 1 : 1;
            continue;
          default:
            try
            {
              UpdateUserSecuritySetCacheQueueManager.Logger.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--534238571 ^ 534218859));
              int num2 = 3;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    UpdateUserSecuritySetCacheQueueManager.IeuowxrKIbUm6plNndn((object) UpdateUserSecuritySetCacheQueueManager.Logger, UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(1458233619 ^ 1458224345));
                    num2 = 2;
                    continue;
                  case 2:
                    goto label_25;
                  case 3:
                    this.transformationProvider.ExecuteNonQuery((string) UpdateUserSecuritySetCacheQueueManager.dUrNFnWzfwLQqQsk5cc(UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(1013954274 ^ 1013967784), UpdateUserSecuritySetCacheQueueManager.HPJ8trWHNjrJVUldeUh((object) this.transformationProvider.Dialect, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1540570615 - 1746246777 ^ 1008171260))));
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 != 0 ? 0 : 0;
                    continue;
                  default:
                    IQuery namedQuery = ((ISession) UpdateUserSecuritySetCacheQueueManager.RbgyAGrulgJ9P2p62xi((object) this.sessionProvider, (object) "")).GetNamedQuery((string) UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-906676699 ^ -906662997));
                    UpdateUserSecuritySetCacheQueueManager.onSL6UrwnfS3TIojTdk((object) namedQuery, 0);
                    UpdateUserSecuritySetCacheQueueManager.c4ApBvrb6qytVhJaGv3((object) namedQuery, false);
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 != 0 ? 1 : 1;
                    continue;
                }
              }
            }
            catch (Exception ex)
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 == 0)
                num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    UpdateUserSecuritySetCacheQueueManager.Y5fJlprUN4nZuqjPuZj((object) UpdateUserSecuritySetCacheQueueManager.Logger, UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-1310136491 - -570921450 ^ -739236035), (object) ex);
                    num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_15;
                }
              }
label_15:
              throw new TransactionRollbackException((string) UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-1711335411 ^ -1711323591), ex);
            }
            finally
            {
              if (needlock)
              {
                int num4 = 1;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_db9bec5650824ebca21c7d722587b741 != 0)
                  num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      UpdateUserSecuritySetCacheQueueManager.ramRUxrRL0IqI7DfTMw((object) disposable);
                      num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_21;
                  }
                }
              }
label_21:;
            }
        }
      }
label_26:;
    }

    /// <summary>
    /// Формирование параметра для запуска хранимой процедуры UpdateUserSecuritySetCache
    /// </summary>
    /// <param name="users">Данные по обновляемым пользователям</param>
    /// <param name="groups">Данные по обновляемым группам пользователей</param>
    /// <param name="organizationItems">Данные по обновляемым элементам оргструктуры</param>
    private string GetParameter(
      Dictionary<EleWise.ELMA.Security.Models.IUser, byte> users,
      Dictionary<IUserGroup, GroupUpdate> groups,
      Dictionary<IOrganizationItem, OrganizationItemUpdate> organizationItems)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      Func<long[], string> list = (Func<long[], string>) (l => string.Concat(((IEnumerable<long>) l).Select<long, string>((Func<long, string>) (i => (string) UpdateUserSecuritySetCacheQueueManager.\u003C\u003Ec.yiwuq3w3HQBxVbYuTyeL((object) i, UpdateUserSecuritySetCacheQueueManager.\u003C\u003Ec.lQE3uNw32iTG0OThILri(1534797734 ^ 1534802602))))));
      Func<KeyValuePair<EleWise.ELMA.Security.Models.IUser, byte>, string> selector1 = (Func<KeyValuePair<EleWise.ELMA.Security.Models.IUser, byte>, string>) (u => u.Key.Id.ToString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(658384612 ^ 658378594));
      Func<KeyValuePair<IUserGroup, GroupUpdate>, string> selector2 = (Func<KeyValuePair<IUserGroup, GroupUpdate>, string>) (g => g.Key.Id.ToString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801309555 ^ -801256927) + list(g.Value.AddUsers) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-814831182 ^ -814768354) + list(g.Value.RemoveUsers) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1596821387 ^ -1596766503) + list(g.Value.AddOrganizationItems) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1711335411 ^ -1711395167) + list(g.Value.RemoveOrganizationItems) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(781628008 - 11982093 ^ 769584119) + list(g.Value.AddGroups) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1807813747 ^ -1807760095) + list(g.Value.RemoveGroups) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-389167216 ^ -389157354));
      Func<KeyValuePair<IOrganizationItem, OrganizationItemUpdate>, string> selector3 = (Func<KeyValuePair<IOrganizationItem, OrganizationItemUpdate>, string>) (oi => oi.Key.Id.ToString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1893095749 ^ -1893167081) + list(oi.Value.AddUsers) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1124861159 ^ 1124938315) + list(oi.Value.RemoveUsers) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1690209562 ^ 116876444 ^ 1649000448));
      return string.Concat(groups.EmptyIfNull<KeyValuePair<IUserGroup, GroupUpdate>>().Select<KeyValuePair<IUserGroup, GroupUpdate>, string>(selector2).Concat<string>(organizationItems.EmptyIfNull<KeyValuePair<IOrganizationItem, OrganizationItemUpdate>>().Select<KeyValuePair<IOrganizationItem, OrganizationItemUpdate>, string>(selector3)).Concat<string>(users.EmptyIfNull<KeyValuePair<EleWise.ELMA.Security.Models.IUser, byte>>().Select<KeyValuePair<EleWise.ELMA.Security.Models.IUser, byte>, string>(selector1)));
    }

    internal void ExecuteUpdate(
      Dictionary<EleWise.ELMA.Security.Models.IUser, byte> users,
      Dictionary<IUserGroup, GroupUpdate> groups,
      Dictionary<IOrganizationItem, OrganizationItemUpdate> organizationItems,
      Guid auditUid)
    {
      if ((users == null || users.Count == 0) && (groups == null || groups.Count == 0) && (organizationItems == null || organizationItems.Count == 0))
        return;
      string parameter = this.GetParameter(users, groups, organizationItems);
      if (UpdateUserSecuritySetCacheQueueManager.WaitTimeSpan == TimeSpan.Zero)
      {
        this.ExecuteUpdateInternal(parameter, auditUid);
      }
      else
      {
        Guid guid = Guid.NewGuid();
        UpdateUserSecuritySetCacheQueueManager.Logger.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-278393783 ^ -278375731), (object) guid, (object) parameter);
        this.transformationProvider.Insert(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1958977588 ^ -1959001440), new string[3]
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-522456341 ^ -522457015),
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1257514304 ^ -1257536402),
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(1534797734 ^ 1534818668)
        }, new object[3]
        {
          (object) guid,
          (object) new SqlExpressionParameter(this.transformationProvider.Dialect.CurrentTimestamp),
          (object) parameter
        });
        try
        {
          this.actorModelRuntime.GetActor<IUpdateUserSecuritySetCacheQueueManagerActor>(0L).RegisterExecute(UpdateUserSecuritySetCacheQueueManager.WaitTimeSpan);
        }
        catch (Exception ex)
        {
          UpdateUserSecuritySetCacheQueueManager.Logger.Warn((object) ex);
        }
        // ISSUE: reference to a compiler-generated method
        this.securityCacheSetIdAction.ForEach<ISecurityCacheSetIdAction>((Action<ISecurityCacheSetIdAction>) (a => UpdateUserSecuritySetCacheQueueManager.\u003C\u003Ec.dHttj8w3LZpe04CVWElE((object) a)));
      }
    }

    /// <summary>
    /// Выполнить накопившиеся обновление UserSecuritySetCache
    /// </summary>
    internal void Execute()
    {
      int num1 = 3;
      CallContextSessionOwner contextSessionOwner;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_72:
            UpdateUserSecuritySetCacheQueueManager.IeuowxrKIbUm6plNndn((object) UpdateUserSecuritySetCacheQueueManager.Logger, UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(1076316568 ^ 1076308426));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_059a0ebcd3d24eadbd1193476e39cd00 != 0 ? 4 : 2;
            continue;
          case 2:
            contextSessionOwner = (CallContextSessionOwner) UpdateUserSecuritySetCacheQueueManager.vFHP1trm4JN6WpS4TUV();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9a9693b5c8a34626b7c93f9145c6a71e != 0 ? 0 : 0;
            continue;
          case 3:
            UpdateUserSecuritySetCacheQueueManager.IeuowxrKIbUm6plNndn((object) UpdateUserSecuritySetCacheQueueManager.Logger, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-624171910 - 757669187 ^ -1381852703));
            num1 = 2;
            continue;
          case 4:
            goto label_70;
          default:
            try
            {
              IUnitOfWork unitOfWork = this.unitOfWorkManager.Create(string.Empty, true);
              int num2 = 0;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 != 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  try
                  {
                    IDisposable disposable = (IDisposable) UpdateUserSecuritySetCacheQueueManager.iNuIPLW2LcuVPDpU1US((object) this.lockManager, UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(~123928154 ^ -123904175));
                    int num3 = 1;
                    if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af == 0)
                      num3 = 1;
                    while (true)
                    {
                      switch (num3)
                      {
                        case 1:
                          try
                          {
                            List<string> values = new List<string>();
                            int num4 = 11;
                            if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a266711490a41e4918c7863d684a456 == 0)
                              num4 = 6;
                            Dictionary<DateTime, List<Guid>> dictionary1;
                            IDataReader dataReader;
                            KeyValuePair<DateTime, List<Guid>> keyValuePair;
                            while (true)
                            {
                              switch (num4)
                              {
                                case 1:
                                  goto label_68;
                                case 2:
                                  try
                                  {
label_26:
                                    if (UpdateUserSecuritySetCacheQueueManager.DcjLZ1rxBDNwESXQt7g((object) dataReader))
                                      goto label_21;
                                    else
                                      goto label_27;
label_20:
                                    int num5;
                                    while (true)
                                    {
                                      DateTime key;
                                      List<Guid> guidList;
                                      switch (num5)
                                      {
                                        case 1:
                                          if (!dictionary1.TryGetValue(key, out guidList))
                                          {
                                            num5 = 2;
                                            continue;
                                          }
                                          break;
                                        case 2:
                                          dictionary1[key] = guidList = new List<Guid>();
                                          num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 == 0 ? 0 : 0;
                                          continue;
                                        case 3:
                                          goto label_26;
                                        case 4:
                                          goto label_13;
                                        case 5:
                                          key = UpdateUserSecuritySetCacheQueueManager.OlXEmjraSOaW2JyOMGp(UpdateUserSecuritySetCacheQueueManager.EUXAIkrDZjKt3sCeUjh((object) dataReader, UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-468111058 ^ -468095104)));
                                          num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0 ? 1 : 1;
                                          continue;
                                        case 6:
                                          goto label_21;
                                      }
                                      guidList.Add(((Dialect) UpdateUserSecuritySetCacheQueueManager.m5M7dar6nQgIqySabpE((object) this.transformationProvider)).GetGuid(UpdateUserSecuritySetCacheQueueManager.EUXAIkrDZjKt3sCeUjh((object) dataReader, UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(1658561670 << 4 ^ 767183554))));
                                      num5 = 3;
                                    }
label_21:
                                    values.Add(Convert.ToString(UpdateUserSecuritySetCacheQueueManager.EUXAIkrDZjKt3sCeUjh((object) dataReader, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1489118656 ^ 643054122 ^ -2123776352))));
                                    num5 = 5;
                                    goto label_20;
label_27:
                                    num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 == 0 ? 4 : 4;
                                    goto label_20;
                                  }
                                  finally
                                  {
                                    if (dataReader != null)
                                    {
                                      int num6 = 1;
                                      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a == 0)
                                        num6 = 1;
                                      while (true)
                                      {
                                        switch (num6)
                                        {
                                          case 1:
                                            UpdateUserSecuritySetCacheQueueManager.ramRUxrRL0IqI7DfTMw((object) dataReader);
                                            num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 == 0 ? 0 : 0;
                                            continue;
                                          default:
                                            goto label_34;
                                        }
                                      }
                                    }
label_34:;
                                  }
                                case 3:
label_13:
                                  if (UpdateUserSecuritySetCacheQueueManager.sAI20drCEppg90NmVjS((object) dictionary1) != 0)
                                  {
                                    num4 = 7;
                                    continue;
                                  }
                                  goto case 4;
                                case 4:
                                  UpdateUserSecuritySetCacheQueueManager.IeuowxrKIbUm6plNndn((object) UpdateUserSecuritySetCacheQueueManager.Logger, UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-1254421137 >> 4 ^ -78385330));
                                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 == 0 ? 1 : 0;
                                  continue;
                                case 5:
                                case 7:
                                  this.ExecuteUpdateInternal(string.Concat((IEnumerable<string>) values), UpdateUserSecuritySetCacheQueueManager.lTcc4Driw4piX7ELpov());
                                  num4 = 8;
                                  continue;
                                case 6:
                                  ITransformationProvider transformationProvider = this.transformationProvider;
                                  object sql = UpdateUserSecuritySetCacheQueueManager.XJMeDqrNmHNKnyHVsEI(UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(1124861159 ^ 1124883211), UpdateUserSecuritySetCacheQueueManager.HPJ8trWHNjrJVUldeUh(UpdateUserSecuritySetCacheQueueManager.m5M7dar6nQgIqySabpE((object) this.transformationProvider), UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-1310136491 - -570921450 ^ -739236781)), UpdateUserSecuritySetCacheQueueManager.HPJ8trWHNjrJVUldeUh(UpdateUserSecuritySetCacheQueueManager.m5M7dar6nQgIqySabpE((object) this.transformationProvider), UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-522456341 ^ -522457015)), (object) string.Join((string) UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-468111058 ^ -468108030), keyValuePair.Value.Select<Guid, string>((Func<Guid, int, string>) ((g, i) => UpdateUserSecuritySetCacheQueueManager.MCKndRr3MvGuXZH4aW7((object) this.transformationProvider).ToString() + UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(1185105284 ^ 1185113256) + (object) i))));
                                  IEnumerable<KeyValuePair<string, object>> source1 = keyValuePair.Value.Select<Guid, KeyValuePair<string, object>>((Func<Guid, int, KeyValuePair<string, object>>) ((g, i) => new KeyValuePair<string, object>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1530848604 ^ 1530840176) + (object) i, (object) g)));
                                  // ISSUE: reference to a compiler-generated field
                                  Func<KeyValuePair<string, object>, string> func1 = UpdateUserSecuritySetCacheQueueManager.\u003C\u003Ec.\u003C\u003E9__20_3;
                                  Func<KeyValuePair<string, object>, string> keySelector1;
                                  if (func1 == null)
                                  {
                                    // ISSUE: reference to a compiler-generated field
                                    UpdateUserSecuritySetCacheQueueManager.\u003C\u003Ec.\u003C\u003E9__20_3 = keySelector1 = (Func<KeyValuePair<string, object>, string>) (p => p.Key);
                                  }
                                  else
                                    goto label_76;
label_43:
                                  // ISSUE: reference to a compiler-generated field
                                  Func<KeyValuePair<string, object>, object> func2 = UpdateUserSecuritySetCacheQueueManager.\u003C\u003Ec.\u003C\u003E9__20_4;
                                  Func<KeyValuePair<string, object>, object> elementSelector;
                                  if (func2 == null)
                                  {
                                    // ISSUE: reference to a compiler-generated field
                                    UpdateUserSecuritySetCacheQueueManager.\u003C\u003Ec.\u003C\u003E9__20_4 = elementSelector = (Func<KeyValuePair<string, object>, object>) (p => p.Value);
                                  }
                                  else
                                    goto label_75;
label_45:
                                  Dictionary<string, object> dictionary2 = source1.ToDictionary<KeyValuePair<string, object>, string, object>(keySelector1, elementSelector);
                                  transformationProvider.ExecuteNonQuery((string) sql, dictionary2);
                                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 != 0 ? 10 : 9;
                                  continue;
label_75:
                                  elementSelector = func2;
                                  goto label_45;
label_76:
                                  keySelector1 = func1;
                                  goto label_43;
                                case 8:
                                  Dictionary<DateTime, List<Guid>> source2 = dictionary1;
                                  // ISSUE: reference to a compiler-generated field
                                  Func<KeyValuePair<DateTime, List<Guid>>, DateTime> func3 = UpdateUserSecuritySetCacheQueueManager.\u003C\u003Ec.\u003C\u003E9__20_0;
                                  Func<KeyValuePair<DateTime, List<Guid>>, DateTime> keySelector2;
                                  if (func3 == null)
                                  {
                                    // ISSUE: reference to a compiler-generated field
                                    UpdateUserSecuritySetCacheQueueManager.\u003C\u003Ec.\u003C\u003E9__20_0 = keySelector2 = (Func<KeyValuePair<DateTime, List<Guid>>, DateTime>) (p => p.Key);
                                  }
                                  else
                                    goto label_77;
label_40:
                                  keyValuePair = source2.OrderByDescending<KeyValuePair<DateTime, List<Guid>>, DateTime>(keySelector2).First<KeyValuePair<DateTime, List<Guid>>>();
                                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 0 : 0;
                                  continue;
label_77:
                                  keySelector2 = func3;
                                  goto label_40;
                                case 9:
                                  dataReader = this.transformationProvider.ExecuteQuery((string) UpdateUserSecuritySetCacheQueueManager.TeFOacrkuCX8vp4nkFN(UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-880091293 >> 4 ^ -54988106), (object) new object[4]
                                  {
                                    UpdateUserSecuritySetCacheQueueManager.HPJ8trWHNjrJVUldeUh(UpdateUserSecuritySetCacheQueueManager.m5M7dar6nQgIqySabpE((object) this.transformationProvider), UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(841533798 << 6 ^ -1976411358)),
                                    UpdateUserSecuritySetCacheQueueManager.HPJ8trWHNjrJVUldeUh(UpdateUserSecuritySetCacheQueueManager.m5M7dar6nQgIqySabpE((object) this.transformationProvider), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-169284490 ^ -169299268)),
                                    (object) this.transformationProvider.Dialect.QuoteIfNeeded((string) UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-340788466 ^ -340810336)),
                                    (object) ((Dialect) UpdateUserSecuritySetCacheQueueManager.m5M7dar6nQgIqySabpE((object) this.transformationProvider)).QuoteIfNeeded((string) UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-1859356887 ^ -1859376571))
                                  }), (Dictionary<string, object>) null);
                                  num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d == 0 ? 2 : 2;
                                  continue;
                                case 10:
                                  goto label_57;
                                case 11:
                                  dictionary1 = new Dictionary<DateTime, List<Guid>>();
                                  num4 = 9;
                                  continue;
                                case 12:
                                  this.transformationProvider.ExecuteNonQuery((string) UpdateUserSecuritySetCacheQueueManager.XJMeDqrNmHNKnyHVsEI(UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-347045778 ^ -347021372), (object) this.transformationProvider.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1807813747 ^ -1807831327)), UpdateUserSecuritySetCacheQueueManager.HPJ8trWHNjrJVUldeUh(UpdateUserSecuritySetCacheQueueManager.m5M7dar6nQgIqySabpE((object) this.transformationProvider), UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-17837901 ^ -17854947)), UpdateUserSecuritySetCacheQueueManager.fPsVrurjViBISCf5cNQ(UpdateUserSecuritySetCacheQueueManager.MCKndRr3MvGuXZH4aW7((object) this.transformationProvider), UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(1690569372 >> 6 ^ 26431108))), new Dictionary<string, object>()
                                  {
                                    {
                                      (string) UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(617710536 ^ 617733478),
                                      (object) keyValuePair.Key
                                    }
                                  });
                                  num4 = 6;
                                  continue;
                                default:
                                  if (UpdateUserSecuritySetCacheQueueManager.sAI20drCEppg90NmVjS((object) dictionary1) > 1)
                                  {
                                    num4 = 12;
                                    continue;
                                  }
                                  goto case 6;
                              }
                            }
label_68:
                            return;
                          }
                          catch (Exception ex)
                          {
                            int num7 = 1;
                            if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 == 0)
                              num7 = 0;
                            while (true)
                            {
                              switch (num7)
                              {
                                case 1:
                                  UpdateUserSecuritySetCacheQueueManager.DqDugtr0EQ3feEPFsxd((object) unitOfWork);
                                  num7 = 2;
                                  continue;
                                case 2:
                                  UpdateUserSecuritySetCacheQueueManager.Y5fJlprUN4nZuqjPuZj(UpdateUserSecuritySetCacheQueueManager.B7x9WyrZrXrmIDVPnL1(), UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(4869926 >> 3 ^ 595920), (object) ex);
                                  num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0 ? 0 : 0;
                                  continue;
                                case 3:
                                  goto label_63;
                                default:
                                  UpdateUserSecuritySetCacheQueueManager.uX83yXrAVd0gSkaGg9M((object) UpdateUserSecuritySetCacheQueueManager.Logger, (object) ex, UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-1788054269 >> 5 ^ -55901284), (object) Array.Empty<object>());
                                  num7 = 3;
                                  continue;
                              }
                            }
label_63:
                            return;
                          }
                          finally
                          {
                            int num8;
                            if (disposable == null)
                              num8 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0 ? 0 : 1;
                            else
                              goto label_55;
label_54:
                            switch (num8)
                            {
                              case 1:
                              case 2:
                            }
label_55:
                            UpdateUserSecuritySetCacheQueueManager.ramRUxrRL0IqI7DfTMw((object) disposable);
                            num8 = 2;
                            goto label_54;
                          }
                        case 2:
                          goto label_72;
                      }
label_57:
                      UpdateUserSecuritySetCacheQueueManager.XtKMffrsVVRBPMqlmd4((object) unitOfWork);
                      num3 = 2;
                    }
                  }
                  finally
                  {
                    int num9;
                    if (unitOfWork == null)
                      num9 = 2;
                    else
                      goto label_61;
label_60:
                    switch (num9)
                    {
                      case 1:
                        break;
                      default:
                    }
label_61:
                    unitOfWork.Dispose();
                    num9 = 0;
                    if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0)
                    {
                      num9 = 0;
                      goto label_60;
                    }
                    else
                      goto label_60;
                  }
              }
            }
            finally
            {
              int num10;
              if (contextSessionOwner == null)
                num10 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af == 0 ? 0 : 0;
              else
                goto label_69;
label_67:
              switch (num10)
              {
                case 1:
                  break;
                default:
              }
label_69:
              UpdateUserSecuritySetCacheQueueManager.ramRUxrRL0IqI7DfTMw((object) contextSessionOwner);
              num10 = 2;
              goto label_67;
            }
        }
      }
label_70:;
    }

    private void ExecuteUpdateInternal(string param, Guid auditUid)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        SecurityCacheSetIdEventArgs cacheSetIdEventArgs;
        IDisposable disposable;
        while (true)
        {
          switch (num2)
          {
            case 1:
              cacheSetIdEventArgs = new SecurityCacheSetIdEventArgs();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 == 0 ? 0 : 0;
              continue;
            case 2:
              UpdateUserSecuritySetCacheQueueManager.zcetITrtMQgXnNm7Ql0((object) this.securityCacheSetIdEventHandler, (object) cacheSetIdEventArgs);
              num2 = 4;
              continue;
            case 3:
              try
              {
                UpdateUserSecuritySetCacheQueueManager.pfjYnjr7ciaB9LCcduv((object) UpdateUserSecuritySetCacheQueueManager.Logger, UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(1677147940 ^ 1677156178), (object) new object[1]
                {
                  (object) param
                });
                int num3 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_bbeecc35b62c4bfbb4fff6405725f192 == 0)
                  num3 = 0;
                while (true)
                {
                  int num4;
                  List<Tuple<long, long>> tupleList1;
                  List<Tuple<long, long>> tupleList2;
                  List<Tuple<long, long>> tupleList3;
                  List<Tuple<long, long>> tupleList4;
                  IEnumerator<UpdateUserSecuritySetCacheQueueManager.UUSSCGroupData> enumerator;
                  List<Tuple<long, long>> tupleList5;
                  List<Tuple<long, long>> tupleList6;
                  List<Tuple<long, long>> tupleList7;
                  List<Tuple<long, long>> tupleList8;
                  ISession session;
                  string queryString;
                  switch (num3)
                  {
                    case 1:
                      tupleList4 = new List<Tuple<long, long>>();
                      num4 = 12;
                      break;
                    case 2:
label_80:
                      cacheSetIdEventArgs.GroupAddUsers = (IEnumerable<Tuple<long, long>>) tupleList7;
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 18 : 3;
                      continue;
                    case 3:
                      cacheSetIdEventArgs.OrganizationItemAddUsers = (IEnumerable<Tuple<long, long>>) tupleList6;
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af == 0 ? 10 : 9;
                      continue;
                    case 4:
                      cacheSetIdEventArgs.GroupAddOrganizationItems = (IEnumerable<Tuple<long, long>>) tupleList8;
                      num3 = 21;
                      continue;
                    case 5:
                      tupleList7 = new List<Tuple<long, long>>();
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_072c2ccfa3eb41439f786d2bee5b4a4b != 0 ? 1 : 1;
                      continue;
                    case 6:
                      tupleList6 = new List<Tuple<long, long>>();
                      num3 = 16;
                      continue;
                    case 7:
                      // ISSUE: type reference
                      enumerator = ((IQuery) UpdateUserSecuritySetCacheQueueManager.V798GLrSt8RT2AdAnfR((object) session.CreateSQLQuery(queryString), (object) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(UpdateUserSecuritySetCacheQueueManager.n60KhTrre0uvcvyUCud(__typeref (UpdateUserSecuritySetCacheQueueManager.UUSSCGroupData))))).CleanUpCache(false).List<UpdateUserSecuritySetCacheQueueManager.UUSSCGroupData>().GetEnumerator();
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 != 0 ? 19 : 12;
                      continue;
                    case 8:
                      UpdateUserSecuritySetCacheQueueManager.c4ApBvrb6qytVhJaGv3((object) ((IQuery) UpdateUserSecuritySetCacheQueueManager.TM7M5hrWXDDj5vkAUNg((object) session, UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-404268492 ^ -404276594))).SetParameter<string>((string) UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-1257514304 ^ -1257522630), param).SetParameter<Guid>((string) UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(928696104 ^ 928687674), auditUid).SetTimeout(0), false);
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 9 : 4;
                      continue;
                    case 9:
                      UpdateUserSecuritySetCacheQueueManager.IeuowxrKIbUm6plNndn((object) UpdateUserSecuritySetCacheQueueManager.Logger, UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(2110885667 - -1624984630 ^ -559105409));
                      num3 = 5;
                      continue;
                    case 10:
                      cacheSetIdEventArgs.OrganizationItemRemoveUsers = (IEnumerable<Tuple<long, long>>) tupleList3;
                      num3 = 14;
                      continue;
                    case 11:
                      cacheSetIdEventArgs.GroupRemoveGroups = (IEnumerable<Tuple<long, long>>) tupleList2;
                      num3 = 3;
                      continue;
                    case 12:
                      tupleList8 = new List<Tuple<long, long>>();
                      num4 = 20;
                      break;
                    case 13:
                      tupleList2 = new List<Tuple<long, long>>();
                      num4 = 6;
                      break;
                    case 14:
                      goto label_104;
                    case 15:
                      queryString = (string) UpdateUserSecuritySetCacheQueueManager.TeFOacrkuCX8vp4nkFN(UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-94240706 ^ -94215848), (object) new object[7]
                      {
                        UpdateUserSecuritySetCacheQueueManager.HPJ8trWHNjrJVUldeUh(UpdateUserSecuritySetCacheQueueManager.m5M7dar6nQgIqySabpE((object) this.transformationProvider), UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-1711335411 ^ -1711333927)),
                        UpdateUserSecuritySetCacheQueueManager.HPJ8trWHNjrJVUldeUh(UpdateUserSecuritySetCacheQueueManager.m5M7dar6nQgIqySabpE((object) this.transformationProvider), UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(1841261835 ^ 1841237843)),
                        UpdateUserSecuritySetCacheQueueManager.HPJ8trWHNjrJVUldeUh(UpdateUserSecuritySetCacheQueueManager.m5M7dar6nQgIqySabpE((object) this.transformationProvider), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(911364681 ^ 911364325)),
                        UpdateUserSecuritySetCacheQueueManager.HPJ8trWHNjrJVUldeUh(UpdateUserSecuritySetCacheQueueManager.m5M7dar6nQgIqySabpE((object) this.transformationProvider), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1640694811 << 2 ^ 2027136768)),
                        UpdateUserSecuritySetCacheQueueManager.HPJ8trWHNjrJVUldeUh(UpdateUserSecuritySetCacheQueueManager.m5M7dar6nQgIqySabpE((object) this.transformationProvider), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-315619370 - -1325004768 ^ 1009383936)),
                        UpdateUserSecuritySetCacheQueueManager.HPJ8trWHNjrJVUldeUh(UpdateUserSecuritySetCacheQueueManager.m5M7dar6nQgIqySabpE((object) this.transformationProvider), UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(978908330 << 6 ^ -1774368532)),
                        UpdateUserSecuritySetCacheQueueManager.HPJ8trWHNjrJVUldeUh(UpdateUserSecuritySetCacheQueueManager.m5M7dar6nQgIqySabpE((object) this.transformationProvider), UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-1028265253 << 4 ^ 727633724))
                      });
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0 ? 0 : 7;
                      continue;
                    case 16:
                      tupleList3 = new List<Tuple<long, long>>();
                      num3 = 15;
                      continue;
                    case 17:
                      tupleList1 = new List<Tuple<long, long>>();
                      num4 = 13;
                      break;
                    case 18:
                      cacheSetIdEventArgs.GroupRemoveUsers = (IEnumerable<Tuple<long, long>>) tupleList4;
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 == 0 ? 1 : 4;
                      continue;
                    case 19:
                      try
                      {
label_46:
                        if (UpdateUserSecuritySetCacheQueueManager.rNUEWmryosTcv9Eirgg((object) enumerator))
                          goto label_57;
                        else
                          goto label_47;
label_16:
                        UpdateUserSecuritySetCacheQueueManager.UUSSCGroupData current;
                        int num5;
                        while (true)
                        {
                          int num6;
                          long? nullable;
                          int? addCount;
                          long num7;
                          List<Tuple<long, long>> tupleList9;
                          List<Tuple<long, long>> tupleList10;
                          List<Tuple<long, long>> tupleList11;
                          List<Tuple<long, long>> tupleList12;
                          switch (num5)
                          {
                            case 1:
                              if (addCount.GetValueOrDefault() > num6 & addCount.HasValue)
                              {
                                num5 = 23;
                                continue;
                              }
                              goto case 19;
                            case 2:
                              addCount = current.AddCount;
                              num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec != 0 ? 21 : 33;
                              continue;
                            case 3:
                              goto label_57;
                            case 4:
                              nullable = current.OrgItemId;
                              num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0 ? 17 : 1;
                              continue;
                            case 5:
                            case 14:
                            case 32:
                            case 34:
                            case 35:
                            case 40:
                              goto label_46;
                            case 6:
                              tupleList10 = tupleList3;
                              break;
                            case 7:
                              tupleList11 = tupleList2;
                              goto label_68;
                            case 8:
                            case 12:
                              nullable = current.GroupId;
                              num5 = 24;
                              continue;
                            case 9:
                              addCount = current.AddCount;
                              num5 = 42;
                              continue;
                            case 10:
                              nullable = current.UserId;
                              num5 = 27;
                              continue;
                            case 11:
                              if (nullable.HasValue)
                              {
                                num5 = 9;
                                continue;
                              }
                              goto case 4;
                            case 13:
                              if (!(nullable.GetValueOrDefault() == num7 & nullable.HasValue))
                              {
                                num5 = 20;
                                continue;
                              }
                              goto case 10;
                            case 15:
                              if (addCount.GetValueOrDefault() > num6 & addCount.HasValue)
                              {
                                num5 = 18;
                                continue;
                              }
                              goto case 6;
                            case 16:
                              addCount = current.AddCount;
                              num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 38 : 17;
                              continue;
                            case 17:
                              if (!nullable.HasValue)
                              {
                                num5 = 12;
                                continue;
                              }
                              goto case 25;
                            case 18:
                              tupleList10 = tupleList6;
                              break;
                            case 19:
                              tupleList9 = tupleList4;
                              goto label_64;
                            case 20:
                            case 31:
                              nullable = current.UserId;
                              num5 = 11;
                              continue;
                            case 21:
                              num7 = -1L;
                              num5 = 13;
                              continue;
                            case 22:
                              if (addCount.GetValueOrDefault() > num6 & addCount.HasValue)
                              {
                                num5 = 41;
                                continue;
                              }
                              goto case 7;
                            case 23:
                              tupleList9 = tupleList7;
                              goto label_64;
                            case 24:
                              if (!nullable.HasValue)
                              {
                                num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 != 0 ? 10 : 34;
                                continue;
                              }
                              goto case 2;
                            case 25:
                              addCount = current.AddCount;
                              num5 = 36;
                              continue;
                            case 26:
                              num7 = -1L;
                              num5 = 39;
                              continue;
                            case 27:
                              if (!nullable.HasValue)
                              {
                                num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 14 : 1;
                                continue;
                              }
                              goto case 16;
                            case 28:
                              if (!(addCount.GetValueOrDefault() > num6 & addCount.HasValue))
                              {
                                num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 != 0 ? 24 : 29;
                                continue;
                              }
                              tupleList12 = tupleList8;
                              goto label_66;
                            case 29:
                              tupleList12 = tupleList5;
                              goto label_66;
                            case 30:
                              nullable = current.GroupId;
                              num5 = 21;
                              continue;
                            case 33:
                              num6 = 0;
                              num5 = 22;
                              continue;
                            case 36:
                              num6 = 0;
                              num5 = 28;
                              continue;
                            case 37:
                              nullable = current.OrgItemId;
                              num5 = 26;
                              continue;
                            case 38:
                              num6 = 0;
                              num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af != 0 ? 7 : 15;
                              continue;
                            case 39:
                              if (nullable.GetValueOrDefault() == num7 & nullable.HasValue)
                              {
                                num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e != 0 ? 30 : 10;
                                continue;
                              }
                              goto case 20;
                            case 41:
                              tupleList11 = tupleList1;
                              goto label_68;
                            case 42:
                              num6 = 0;
                              num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e != 0 ? 1 : 1;
                              continue;
                            default:
                              goto label_80;
                          }
                          long num8 = UpdateUserSecuritySetCacheQueueManager.i6tVsxrYFlOdZdWPmWZ((object) current);
                          nullable = current.UserId;
                          long num9 = nullable.Value;
                          Tuple<long, long> tuple1 = new Tuple<long, long>(num8, num9);
                          tupleList10.Add(tuple1);
                          num5 = 40;
                          continue;
label_64:
                          long id1 = current.Id;
                          nullable = current.UserId;
                          long num10 = nullable.Value;
                          Tuple<long, long> tuple2 = new Tuple<long, long>(id1, num10);
                          tupleList9.Add(tuple2);
                          num5 = 32;
                          continue;
label_66:
                          long num11 = UpdateUserSecuritySetCacheQueueManager.i6tVsxrYFlOdZdWPmWZ((object) current);
                          nullable = current.OrgItemId;
                          long num12 = nullable.Value;
                          Tuple<long, long> tuple3 = new Tuple<long, long>(num11, num12);
                          tupleList12.Add(tuple3);
                          num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 23 : 35;
                          continue;
label_68:
                          long id2 = current.Id;
                          nullable = current.GroupId;
                          long num13 = nullable.Value;
                          Tuple<long, long> tuple4 = new Tuple<long, long>(id2, num13);
                          tupleList11.Add(tuple4);
                          num5 = 5;
                        }
label_47:
                        num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 == 0 ? 0 : 0;
                        goto label_16;
label_57:
                        current = enumerator.Current;
                        num5 = 10;
                        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_17a674104f744d148c88ef2875093851 == 0)
                        {
                          num5 = 37;
                          goto label_16;
                        }
                        else
                          goto label_16;
                      }
                      finally
                      {
                        int num14;
                        if (enumerator == null)
                          num14 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0 ? 2 : 0;
                        else
                          goto label_72;
label_71:
                        switch (num14)
                        {
                          case 1:
                            break;
                          default:
                        }
label_72:
                        enumerator.Dispose();
                        num14 = 0;
                        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_884358aafda34ae282ee800d4963a840 == 0)
                        {
                          num14 = 0;
                          goto label_71;
                        }
                        else
                          goto label_71;
                      }
                    case 20:
                      tupleList5 = new List<Tuple<long, long>>();
                      num3 = 17;
                      continue;
                    case 21:
                      cacheSetIdEventArgs.GroupRemoveOrganizationItems = (IEnumerable<Tuple<long, long>>) tupleList5;
                      num3 = 22;
                      continue;
                    case 22:
                      cacheSetIdEventArgs.GroupAddGroups = (IEnumerable<Tuple<long, long>>) tupleList1;
                      num3 = 11;
                      continue;
                    default:
                      session = (ISession) UpdateUserSecuritySetCacheQueueManager.RbgyAGrulgJ9P2p62xi((object) this.sessionProvider, (object) "");
                      num3 = 8;
                      continue;
                  }
                  num3 = num4;
                }
              }
              catch (Exception ex)
              {
                int num15 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 == 0)
                  num15 = 1;
                while (true)
                {
                  switch (num15)
                  {
                    case 1:
                      UpdateUserSecuritySetCacheQueueManager.Y5fJlprUN4nZuqjPuZj((object) EleWise.ELMA.Logging.Logger.Log, UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(--2002186503 ^ 2002169651), (object) ex);
                      num15 = 3;
                      continue;
                    case 2:
                      goto label_102;
                    case 3:
                      UpdateUserSecuritySetCacheQueueManager.Y5fJlprUN4nZuqjPuZj((object) UpdateUserSecuritySetCacheQueueManager.Logger, UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(--306199571 ^ 306208419), (object) ex);
                      num15 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 == 0 ? 0 : 0;
                      continue;
                    default:
                      this.ExecuteFullUpdate(false);
                      num15 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0 ? 2 : 0;
                      continue;
                  }
                }
label_102:
                return;
              }
              finally
              {
                int num16;
                if (disposable == null)
                  num16 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_cde98c0f35af4e08af88e0011c2c9c56 != 0 ? 1 : 0;
                else
                  goto label_100;
label_99:
                switch (num16)
                {
                  case 1:
                  case 2:
                }
label_100:
                UpdateUserSecuritySetCacheQueueManager.ramRUxrRL0IqI7DfTMw((object) disposable);
                num16 = 2;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 != 0)
                {
                  num16 = 2;
                  goto label_99;
                }
                else
                  goto label_99;
              }
            case 4:
              goto label_105;
            case 5:
label_104:
              IEnumerable<ISecurityCacheSetIdAction> cacheSetIdAction = this.securityCacheSetIdAction;
              // ISSUE: reference to a compiler-generated field
              Action<ISecurityCacheSetIdAction> action1 = UpdateUserSecuritySetCacheQueueManager.\u003C\u003Ec.\u003C\u003E9__22_0;
              Action<ISecurityCacheSetIdAction> action2;
              if (action1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                UpdateUserSecuritySetCacheQueueManager.\u003C\u003Ec.\u003C\u003E9__22_0 = action2 = (Action<ISecurityCacheSetIdAction>) (a => UpdateUserSecuritySetCacheQueueManager.\u003C\u003Ec.dHttj8w3LZpe04CVWElE((object) a));
              }
              else
                goto label_108;
label_107:
              cacheSetIdAction.ForEach<ISecurityCacheSetIdAction>(action2);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0 ? 2 : 2;
              continue;
label_108:
              action2 = action1;
              goto label_107;
            default:
              goto label_5;
          }
        }
label_5:
        disposable = (IDisposable) UpdateUserSecuritySetCacheQueueManager.iNuIPLW2LcuVPDpU1US((object) this.lockManager, UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(-1958138283 - -279956781 ^ -1678203082));
        num1 = 3;
      }
label_105:;
    }

    static UpdateUserSecuritySetCacheQueueManager()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            UpdateUserSecuritySetCacheQueueManager.IsWURRrVtT5wvYnEcZI();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d7f8066b0dc4566857bdad63dd2c766 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            UpdateUserSecuritySetCacheQueueManager.Logger = (ILogger) UpdateUserSecuritySetCacheQueueManager.KSTxhlrlR2PsmbiObpp(UpdateUserSecuritySetCacheQueueManager.Mk4NwyWLAm1MOuvVH10(2086891181 ^ 2086865991));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object Mk4NwyWLAm1MOuvVH10(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool Ss3ntaWesqcTRkcindU() => UpdateUserSecuritySetCacheQueueManager.g6dYg5WI6dJBV7p5lZc == null;

    internal static UpdateUserSecuritySetCacheQueueManager K2koEfWnKc9iUOQxU4G() => UpdateUserSecuritySetCacheQueueManager.g6dYg5WI6dJBV7p5lZc;

    internal static object iNuIPLW2LcuVPDpU1US([In] object obj0, [In] object obj1) => (object) ((ILockManager) obj0).Lock((string) obj1);

    internal static object HPJ8trWHNjrJVUldeUh([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object dUrNFnWzfwLQqQsk5cc([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object RbgyAGrulgJ9P2p62xi([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static object onSL6UrwnfS3TIojTdk([In] object obj0, [In] int obj1) => (object) ((IQuery) obj0).SetTimeout(obj1);

    internal static int c4ApBvrb6qytVhJaGv3([In] object obj0, [In] bool obj1) => ((IQuery) obj0).ExecuteUpdate(obj1);

    internal static void IeuowxrKIbUm6plNndn([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);

    internal static void Y5fJlprUN4nZuqjPuZj([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void ramRUxrRL0IqI7DfTMw([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void xQg1lcrodEhBZIjAlSV([In] object obj0, bool value) => ((SecurityCacheSetIdEventArgs) obj0).FullUpdate = value;

    internal static void zcetITrtMQgXnNm7Ql0([In] object obj0, [In] object obj1) => ((ISecurityCacheSetIdEventHandler) obj0).PostCacheSet((SecurityCacheSetIdEventArgs) obj1);

    internal static object vFHP1trm4JN6WpS4TUV() => (object) CallContextSessionOwner.Create();

    internal static object m5M7dar6nQgIqySabpE([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object TeFOacrkuCX8vp4nkFN([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static object EUXAIkrDZjKt3sCeUjh([In] object obj0, [In] object obj1) => ((IDataRecord) obj0)[(string) obj1];

    internal static DateTime OlXEmjraSOaW2JyOMGp([In] object obj0) => Convert.ToDateTime(obj0);

    internal static bool DcjLZ1rxBDNwESXQt7g([In] object obj0) => ((IDataReader) obj0).Read();

    internal static int sAI20drCEppg90NmVjS([In] object obj0) => ((Dictionary<DateTime, List<Guid>>) obj0).Count;

    internal static Guid lTcc4Driw4piX7ELpov() => Guid.NewGuid();

    internal static object MCKndRr3MvGuXZH4aW7([In] object obj0) => (object) ((ITransformationProvider) obj0).ParameterSeparator;

    internal static object fPsVrurjViBISCf5cNQ([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object XJMeDqrNmHNKnyHVsEI([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => (object) string.Format((string) obj0, obj1, obj2, obj3);

    internal static void DqDugtr0EQ3feEPFsxd([In] object obj0) => ((IUnitOfWork) obj0).Rollback();

    internal static object B7x9WyrZrXrmIDVPnL1() => (object) EleWise.ELMA.Logging.Logger.Log;

    internal static void uX83yXrAVd0gSkaGg9M([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((ILogger) obj0).Error((Exception) obj1, (string) obj2, (object[]) obj3);

    internal static void XtKMffrsVVRBPMqlmd4([In] object obj0) => ((IUnitOfWork) obj0).Commit();

    internal static void pfjYnjr7ciaB9LCcduv([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).DebugFormat((string) obj1, (object[]) obj2);

    internal static object TM7M5hrWXDDj5vkAUNg([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).GetNamedQuery((string) obj1);

    internal static Type n60KhTrre0uvcvyUCud([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object V798GLrSt8RT2AdAnfR([In] object obj0, [In] object obj1) => (object) ((IQuery) obj0).SetResultTransformer((IResultTransformer) obj1);

    internal static long i6tVsxrYFlOdZdWPmWZ([In] object obj0) => ((UpdateUserSecuritySetCacheQueueManager.UUSSCGroupData) obj0).Id;

    internal static bool rNUEWmryosTcv9Eirgg([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void IsWURRrVtT5wvYnEcZI() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static object KSTxhlrlR2PsmbiObpp([In] object obj0) => (object) EleWise.ELMA.Logging.Logger.GetLogger((string) obj0);

    private class UUSSCGroupData
    {
      private static object h5Elkkw3vitGtPa04QXd;

      public long Id
      {
        get => this.\u003CId\u003Ek__BackingField;
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
                this.\u003CId\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2b497184d7c84c9ba554dbc2c3535cc2 != 0 ? 0 : 0;
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

      public int? AddCount { get; set; }

      public long? UserId { get; set; }

      public long? OrgItemId { get; set; }

      public long? GroupId { get; set; }

      public UUSSCGroupData()
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool tJZ7S1w3qKEUmfVSfgDL() => UpdateUserSecuritySetCacheQueueManager.UUSSCGroupData.h5Elkkw3vitGtPa04QXd == null;

      internal static UpdateUserSecuritySetCacheQueueManager.UUSSCGroupData d5aZWUw3gRCQnjAda5Wm() => (UpdateUserSecuritySetCacheQueueManager.UUSSCGroupData) UpdateUserSecuritySetCacheQueueManager.UUSSCGroupData.h5Elkkw3vitGtPa04QXd;
    }
  }
}

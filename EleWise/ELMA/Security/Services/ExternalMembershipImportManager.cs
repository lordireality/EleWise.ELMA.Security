// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.ExternalMembershipImportManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Actors;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Менеджер импорта пользователей из внешних провайдеров авторизации
  /// </summary>
  [Service]
  public class ExternalMembershipImportManager
  {
    /// <summary>Уникальный идентификатор хранилища</summary>
    private Guid UID;
    internal static ExternalMembershipImportManager sQC3XI7Q0obpqZrytHC;

    /// <summary>Менеджер пользователей</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public UserManager UserManager
    {
      get => this.\u003CUserManager\u003Ek__BackingField;
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
              this.\u003CUserManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 == 0 ? 0 : 0;
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
    /// Интерфейс общего сервиса работы с внешними модулями авторизации IExternalMembershipModule и провайдерами авторизации IExternalMembershipService
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public IExternalMembershipManager ExternalMembershipManager
    {
      get => this.\u003CExternalMembershipManager\u003Ek__BackingField;
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
              this.\u003CExternalMembershipManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 == 0 ? 0 : 0;
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

    /// <summary>Интерфейс менеджера блокировок</summary>
    [Obsolete("NotUsed", true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ILockManager LockManager
    {
      get => this.\u003CLockManager\u003Ek__BackingField;
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
              this.\u003CLockManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 != 0 ? 0 : 0;
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

    /// <summary>Интерфейс сервиса временных штампов</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ITimestampService TimestampService
    {
      get => this.\u003CTimestampService\u003Ek__BackingField;
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
              this.\u003CTimestampService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d != 0 ? 0 : 0;
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

    /// <summary>Интерфейс Модели Акторов</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public IActorModelRuntime ActorModelRuntime
    {
      get => this.\u003CActorModelRuntime\u003Ek__BackingField;
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
              this.\u003CActorModelRuntime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 != 0 ? 0 : 0;
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
    ///  Проверить производится ли импорт по провайдеру авторизации
    /// </summary>
    /// <param name="authProviderUid">Уникальный идентификатор провайдера авторизации</param>
    /// <returns></returns>
    public bool CheckImportProgress(Guid authProviderUid) => this.GetAuthProviderImportInfo(authProviderUid) != null;

    /// <summary>Добавить данные импорта</summary>
    /// <param name="users">UserName пользователей для импорта</param>
    /// <param name="groups">Группы</param>
    /// <param name="authProviderUid">Идентификатор провайдера авторизации</param>
    public void AddUsersToImport(
      IEnumerable<string> users,
      EditableListModel groups,
      Guid authProviderUid)
    {
      this.AddUsersToImport(users, groups.Items.Select<EditableListItem, long>((Func<EditableListItem, long>) (a => a.Value.FromJson<long>())), authProviderUid);
    }

    /// <summary>Добавить данные импорта</summary>
    /// <param name="users">UserName пользователей для импорта</param>
    /// <param name="groups">Id групп</param>
    /// <param name="authProviderUid">Идентификатор провайдера авторизации</param>
    public void AddUsersToImport(
      IEnumerable<string> users,
      IEnumerable<long> groups,
      Guid authProviderUid)
    {
      Task.Run((Func<Task>) (() => this.ActorModelRuntime.GetActor<IExternalMembershipImportManagerActor>(0L).AddUsersToImport((ICollection<string>) users.ToArray<string>(), (ICollection<long>) groups.ToArray<long>(), authProviderUid))).Wait();
    }

    /// <summary>Добавить данные импорта</summary>
    /// <param name="users">UserName пользователей для импорта</param>
    /// <param name="groups">Id групп</param>
    /// <param name="authProviderUid">Идентификатор провайдера авторизации</param>
    internal void AddUsersToImportInternal(
      IEnumerable<string> users,
      IEnumerable<long> groups,
      Guid authProviderUid)
    {
      this.AddUsersToImport(new ExternalMembershipImportManager.ImportModel(users, groups, authProviderUid, ExternalMembershipImportManager.ProcessingStatus.None));
    }

    /// <summary>Добавить данные импорта</summary>
    /// <param name="model">Модель данных импорта</param>
    private void AddUsersToImport(ExternalMembershipImportManager.ImportModel model)
    {
      int num = 3;
      List<ExternalMembershipImportManager.ImportModel> importModelList;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
          case 9:
            importModelList.Add(model);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f != 0 ? 4 : 2;
            continue;
          case 2:
            if (model.ProcessingItems.Any<ExternalMembershipImportManager.ProcessingItem>())
            {
              importModelList = this.GetAllImportInfo();
              num = 7;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 0 : 0;
            continue;
          case 3:
            if (model.ProcessingItems != null)
            {
              num = 2;
              continue;
            }
            goto label_7;
          case 4:
          case 8:
            ((IBLOBDataManager) ExternalMembershipImportManager.esvwma7dEYPHgenTXwk()).SetBLOB<List<ExternalMembershipImportManager.ImportModel>>(this.UID, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1403802000 ^ 1403782904), importModelList);
            num = 6;
            continue;
          case 5:
            importModelList = new List<ExternalMembershipImportManager.ImportModel>()
            {
              model
            };
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed == 0 ? 1 : 8;
            continue;
          case 6:
            goto label_12;
          case 7:
            if (importModelList != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_124feb60869b48cf91517a63723aebab != 0 ? 1 : 1;
              continue;
            }
            goto case 5;
          default:
            goto label_2;
        }
      }
label_3:
      return;
label_12:
      return;
label_2:
      return;
label_7:;
    }

    private List<ExternalMembershipImportManager.ImportModel> GetAllImportInfo() => DataAccessManager.BLOBManager.GetBLOB<List<ExternalMembershipImportManager.ImportModel>>(this.UID, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1100789287 - 1555711667 ^ -454936548));

    private ExternalMembershipImportManager.ImportModel GetAuthProviderImportInfo(
      Guid uid)
    {
      int num = 2;
      List<ExternalMembershipImportManager.ImportModel> allImportInfo;
      Guid uid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            uid1 = uid;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_857db9714dc3446cba736520b25a71dc == 0 ? 1 : 1;
            continue;
          case 3:
            if (allImportInfo == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 != 0 ? 2 : 4;
              continue;
            }
            goto label_3;
          case 4:
            goto label_2;
          default:
            allImportInfo = this.GetAllImportInfo();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e == 0 ? 3 : 3;
            continue;
        }
      }
label_2:
      return (ExternalMembershipImportManager.ImportModel) null;
label_3:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return allImportInfo.FirstOrDefault<ExternalMembershipImportManager.ImportModel>((Func<ExternalMembershipImportManager.ImportModel, bool>) (a => ExternalMembershipImportManager.\u003C\u003Ec__DisplayClass26_0.JUfMB1wiSwRPQMSHfXFV(ExternalMembershipImportManager.\u003C\u003Ec__DisplayClass26_0.KZ6ke4wirhRnJt5wFMmS((object) a), uid1)));
    }

    /// <summary>Удалить данные об импорте</summary>
    /// <returns><see langword="true" />, если импорт больше не продолжается</returns>
    private bool SetImportEnd(Guid uid)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        List<ExternalMembershipImportManager.ImportModel> blob;
        ExternalMembershipImportManager.ImportModel importModel;
        Guid uid1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (blob != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 == 0 ? 9 : 3;
                continue;
              }
              goto label_15;
            case 2:
              uid1 = uid;
              num2 = 4;
              continue;
            case 3:
              num2 = 2;
              continue;
            case 4:
              blob = ((IBLOBDataManager) ExternalMembershipImportManager.esvwma7dEYPHgenTXwk()).GetBLOB<List<ExternalMembershipImportManager.ImportModel>>(this.UID, (string) ExternalMembershipImportManager.hTKoWc7EA1dJMUeuOds(-1424960806 ^ -1424980558));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 1 : 1;
              continue;
            case 5:
              goto label_6;
            case 6:
              blob.Remove(importModel);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_81d39122ee4f448693ffaadf9f7011a2 != 0 ? 0 : 0;
              continue;
            case 7:
              goto label_15;
            case 8:
              goto label_13;
            case 9:
              goto label_16;
            case 10:
              ((IBLOBDataManager) ExternalMembershipImportManager.esvwma7dEYPHgenTXwk()).RemoveBLOB<List<ExternalMembershipImportManager.ImportModel>>(this.UID, (string) ExternalMembershipImportManager.hTKoWc7EA1dJMUeuOds(-1424960806 ^ -1424980558));
              num2 = 5;
              continue;
            default:
              if (ExternalMembershipImportManager.Xi6c3u7GY2yVaRkiCwS((object) blob) == 0)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abc57594f0124f61b27d5653ef0816c2 != 0 ? 10 : 9;
                continue;
              }
              ((IBLOBDataManager) ExternalMembershipImportManager.esvwma7dEYPHgenTXwk()).SetBLOB<List<ExternalMembershipImportManager.ImportModel>>(this.UID, (string) ExternalMembershipImportManager.hTKoWc7EA1dJMUeuOds(150349507 - 521039768 ^ -370679741), blob);
              num2 = 8;
              continue;
          }
        }
label_16:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        importModel = blob.FirstOrDefault<ExternalMembershipImportManager.ImportModel>((Func<ExternalMembershipImportManager.ImportModel, bool>) (a => ExternalMembershipImportManager.\u003C\u003Ec__DisplayClass27_0.tTlJXAwifIIn0Z2aW5Y9(ExternalMembershipImportManager.\u003C\u003Ec__DisplayClass27_0.FYRoJ3wilotcMgk83wDn((object) a), uid1)));
        num1 = 6;
      }
label_6:
      return true;
label_13:
      return false;
label_15:
      return true;
    }

    /// <summary>Запустить обработку импорта пользователей</summary>
    public void StartImportUsers()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ExternalMembershipImportManager.kLhEwW79fZEeOrvyjxa(ExternalMembershipImportManager.YpSqj67XZoGuWX2k9Us((object) this.ActorModelRuntime.GetActor<IExternalMembershipImportManagerActor>(0L)));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Обработка импорта пользователей</summary>
    internal void ImportUsersInternal()
    {
      int num1 = 4;
      IDisposable isolated;
      ExternalMembershipImportManager membershipImportManager;
      ExternalMembershipImportManager.ImportModel importInfo;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_26;
          case 2:
            isolated = ELMAContext.CreateIsolated();
            num1 = 7;
            continue;
          case 3:
            membershipImportManager = this;
            num1 = 6;
            continue;
          case 4:
            num1 = 3;
            continue;
          case 5:
            goto label_4;
          case 6:
            importInfo = this.GetObjectsForImport();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af != 0 ? 0 : 0;
            continue;
          case 7:
            goto label_6;
          default:
            if (importInfo != null)
            {
              num1 = 2;
              continue;
            }
            goto label_18;
        }
      }
label_26:
      return;
label_4:
      return;
label_18:
      return;
label_6:
      try
      {
        CallContextSessionOwner contextSessionOwner = CallContextSessionOwner.Create();
        int num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              ExternalMembershipImportManager.FxiI1H71ZQnBb6LnI1m((object) new BackgroundTask((Action) (() =>
              {
                switch (1)
                {
                  case 1:
                    try
                    {
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      membershipImportManager.ImportUsers(importInfo.ProcessingItems.Select<ExternalMembershipImportManager.ProcessingItem, string>((Func<ExternalMembershipImportManager.ProcessingItem, string>) (a => (string) ExternalMembershipImportManager.\u003C\u003Ec.v41EdxwiiGVvkwKS8LVN((object) a))), importInfo.Groups, ExternalMembershipImportManager.\u003C\u003Ec__DisplayClass29_0.UymjdZwi8jkIyUgqsnoZ((object) importInfo));
                      int num3 = 0;
                      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 != 0)
                        num3 = 0;
                      switch (num3)
                      {
                        case 0:
                          return;
                        default:
                          return;
                      }
                    }
                    catch (Exception ex)
                    {
                      int num4 = 0;
                      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_76283ae6473c490382987716c084078e == 0)
                        num4 = 0;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            goto label_4;
                          default:
                            // ISSUE: reference to a compiler-generated method
                            ExternalMembershipImportManager.\u003C\u003Ec__DisplayClass29_0.w9pwb9wi5ni1WnGRjLWi((object) Logger.Log, (object) ex);
                            num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 1 : 0;
                            continue;
                        }
                      }
label_4:
                      break;
                    }
                    finally
                    {
                      membershipImportManager.RemoveProcessingObjects(importInfo);
                      int num5 = 0;
                      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0)
                        num5 = 0;
                      switch (num5)
                      {
                        default:
                      }
                    }
                }
              }), typeof (EleWise.ELMA.Security.IUser), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-617657301 ^ -617669737), z2jc63fLkugS1X8Q9N.tE1kD1vbB(784628100 ^ 784608824)));
              int num6 = 0;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d0ea6e195405439b980908920ebd8cef != 0)
                num6 = 0;
              switch (num6)
              {
                case 0:
                  return;
                default:
                  return;
              }
            }
            finally
            {
              int num7;
              if (contextSessionOwner == null)
                num7 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec == 0 ? 0 : 0;
              else
                goto label_19;
label_16:
              switch (num7)
              {
                case 2:
                  break;
                default:
              }
label_19:
              contextSessionOwner.Dispose();
              num7 = 1;
              if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0)
              {
                num7 = 0;
                goto label_16;
              }
              else
                goto label_16;
            }
        }
      }
      finally
      {
        if (isolated != null)
        {
          int num8 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 == 0)
            num8 = 0;
          while (true)
          {
            switch (num8)
            {
              case 1:
                goto label_28;
              default:
                ExternalMembershipImportManager.iR9qI67MLBIXg6WXwtI((object) isolated);
                num8 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c7fadd9c35e4440d855e46c7e870bf68 == 0 ? 1 : 0;
                continue;
            }
          }
        }
label_28:;
      }
    }

    /// <summary>Произвести импорт пользователей</summary>
    /// <param name="userNames">UserName импортируемых пользователей</param>
    /// <param name="groups">Идентификатор групп</param>
    /// <param name="authProviderUid">Идентификатор провайдера</param>
    public void ImportUsers(
      IEnumerable<string> userNames,
      IEnumerable<long> groups,
      Guid authProviderUid)
    {
      ICollection<EleWise.ELMA.Security.Models.IUser> source = this.UserManager.Find((Expression<Func<EleWise.ELMA.Security.Models.IUser, bool>>) (user => userNames.Contains<string>(user.UserName)));
      foreach (string userName1 in userNames)
      {
        string userName = userName1;
        try
        {
          // ISSUE: reference to a compiler-generated method
          EleWise.ELMA.Security.Models.IUser user = source.FirstOrDefault<EleWise.ELMA.Security.Models.IUser>((Func<EleWise.ELMA.Security.Models.IUser, bool>) (a => (string) ExternalMembershipImportManager.\u003C\u003Ec__DisplayClass30_1.Pn6JUZwih2UiFWOTT3Gh((object) a) == userName));
          bool flag = false;
          if (user == null)
          {
            flag = true;
            user = this.UserManager.Create();
            user.UserName = userName;
          }
          Dictionary<Guid, string> allName = this.ExternalMembershipManager.GetAllName();
          if ((user.AuthProviderGuid == Guid.Empty || !allName.ContainsKey(user.AuthProviderGuid)) && user.Status == UserStatus.Active)
          {
            user.AuthProviderGuid = authProviderUid;
            this.ExternalMembershipManager.Sync((EleWise.ELMA.Security.IUser) user, authProviderUid);
            if (groups != null & flag)
            {
              if (this.UserManager.CanCreateNewUser())
                this.UserManager.SaveUserWithGroups(user, "", groups, (Func<IUserGroup, bool>) (g =>
                {
                  int num = 1;
                  while (true)
                  {
                    switch (num)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (ExternalMembershipImportManager.\u003C\u003Ec.gTRrsGwij1wgN5blNQ8d(ExternalMembershipImportManager.\u003C\u003Ec.TAIkYhwi3qqtY3Qfp63G((object) g), Guid.Empty))
                        {
                          num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_65b52f31690e4fe4a596fb62126415ff != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_2;
                      case 2:
                        goto label_2;
                      default:
                        goto label_3;
                    }
                  }
label_2:
                  // ISSUE: reference to a compiler-generated method
                  return ExternalMembershipImportManager.\u003C\u003Ec.gTRrsGwij1wgN5blNQ8d(g.TypeUid, InterfaceActivator.UID<IUserGroup>());
label_3:
                  return true;
                }));
              else
                Logger.Log.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1540570615 - 1746246777 ^ 1008169546), (object) userName));
            }
            else
              this.UserManager.Save(user, "");
            Logger.Log.Info((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1290337431 ^ 1290314937), (object) userName));
          }
          else
            Logger.Log.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1458233619 ^ 1458223437), (object) userName));
        }
        catch (Exception ex)
        {
          Logger.Log.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(617710536 ^ 617732978), (object) userName, (object) ex.Message), ex);
        }
      }
    }

    /// <summary>Получить пачку объектов для импорта</summary>
    /// <returns>Пачка объектов импорта</returns>
    private ExternalMembershipImportManager.ImportModel GetObjectsForImport()
    {
      int num1 = 1;
      ExternalMembershipImportManager.ImportModel objectsForImport;
      while (true)
      {
        int num2 = num1;
        IEnumerator<ExternalMembershipImportManager.ProcessingItem> enumerator;
        List<ExternalMembershipImportManager.ProcessingItem> processingItemList;
        List<ExternalMembershipImportManager.ProcessingItem> list;
        List<ExternalMembershipImportManager.ImportModel> allImportInfo;
        long timestampNow;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 0 : 0;
              continue;
            case 2:
              list = objectsForImport.ProcessingItems.ToList<ExternalMembershipImportManager.ProcessingItem>();
              num2 = 4;
              continue;
            case 3:
              if (objectsForImport.ProcessingItems == null)
              {
                num2 = 22;
                continue;
              }
              goto case 7;
            case 4:
              timestampNow = this.TimestampService.GetTimestamp();
              num2 = 6;
              continue;
            case 5:
            case 22:
              if (this.SetImportEnd(ExternalMembershipImportManager.fCiZZ67hPT3qtPXDvcB((object) objectsForImport)))
                goto case 11;
              else
                goto label_28;
            case 6:
              List<ExternalMembershipImportManager.ProcessingItem> source = list;
              Func<ExternalMembershipImportManager.ProcessingItem, bool> func;
              Func<ExternalMembershipImportManager.ProcessingItem, bool> func1 = func;
              Func<ExternalMembershipImportManager.ProcessingItem, bool> predicate = func1 == null ? (func = (Func<ExternalMembershipImportManager.ProcessingItem, bool>) (a =>
              {
                int num3 = 5;
                long? processingTimestamp;
                long num4;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      num4 = timestampNow;
                      num3 = 6;
                      continue;
                    case 2:
                      processingTimestamp = a.ExpireProcessingTimestamp;
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 1 : 0;
                      continue;
                    case 3:
                      goto label_8;
                    case 4:
                      processingTimestamp = a.ExpireProcessingTimestamp;
                      num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 == 0 ? 0 : 0;
                      continue;
                    case 5:
                      if (a.Status == ExternalMembershipImportManager.ProcessingStatus.Process)
                      {
                        num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 == 0 ? 4 : 1;
                        continue;
                      }
                      goto label_8;
                    case 6:
                      goto label_7;
                    default:
                      if (!processingTimestamp.HasValue)
                      {
                        num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_375d633a8e534fcab720ba66aa920b78 != 0 ? 1 : 3;
                        continue;
                      }
                      goto case 2;
                  }
                }
label_7:
                return processingTimestamp.GetValueOrDefault() < num4 & processingTimestamp.HasValue;
label_8:
                return true;
              })) : func1;
              enumerator = source.Where<ExternalMembershipImportManager.ProcessingItem>(predicate).GetEnumerator();
              num2 = 14;
              continue;
            case 7:
              if (!objectsForImport.ProcessingItems.Any<ExternalMembershipImportManager.ProcessingItem>())
                goto case 5;
              else
                goto label_33;
            case 8:
              goto label_25;
            case 9:
              if (allImportInfo != null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_920e3d776819428d810c2d2dde9eb138 != 0 ? 20 : 6;
                continue;
              }
              goto case 12;
            case 10:
              goto label_29;
            case 11:
              ((Task) ExternalMembershipImportManager.htMg8n7BZdhlvHbt754((object) this.ActorModelRuntime.GetActor<IExternalMembershipImportManagerActor>(0L))).Wait();
              num2 = 17;
              continue;
            case 12:
              ExternalMembershipImportManager.kLhEwW79fZEeOrvyjxa((object) this.ActorModelRuntime.GetActor<IExternalMembershipImportManagerActor>(0L).ImportComplete());
              num2 = 10;
              continue;
            case 13:
              goto label_30;
            case 14:
              try
              {
label_11:
                if (ExternalMembershipImportManager.BGE1627FpkyXnfPV7qI((object) enumerator))
                  goto label_5;
                else
                  goto label_12;
label_4:
                ExternalMembershipImportManager.ProcessingItem current;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      current.ExpireProcessingTimestamp = new long?(ExternalMembershipImportManager.NGw1sn7ps9PoWXbm5vv((object) this.TimestampService, TimeSpan.FromMinutes((double) this.ProcessingTimeout)));
                      num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d == 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_11;
                    case 3:
                      processingItemList.Add(current);
                      num5 = 6;
                      continue;
                    case 4:
                    case 7:
                      goto label_40;
                    case 5:
                      goto label_5;
                    case 6:
                      if (ExternalMembershipImportManager.l8RsMi7TtDsmq8wZT5h((object) processingItemList) >= this.ProcessingCount)
                      {
                        num5 = 7;
                        continue;
                      }
                      goto label_11;
                    default:
                      ExternalMembershipImportManager.xRTVPG7OoZGOWJVjbWu((object) current, ExternalMembershipImportManager.ProcessingStatus.Process);
                      num5 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9db0a354f8944ff68ff9b9331b34328e != 0 ? 3 : 2;
                      continue;
                  }
                }
label_5:
                current = enumerator.Current;
                num5 = 0;
                if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f20cfc797c0242f88727e70430138c2b == 0)
                {
                  num5 = 1;
                  goto label_4;
                }
                else
                  goto label_4;
label_12:
                num5 = 4;
                goto label_4;
              }
              finally
              {
                int num6;
                if (enumerator == null)
                  num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 == 0 ? 1 : 1;
                else
                  goto label_17;
label_16:
                switch (num6)
                {
                  case 1:
                  case 2:
                }
label_17:
                ExternalMembershipImportManager.iR9qI67MLBIXg6WXwtI((object) enumerator);
                num6 = 2;
                goto label_16;
              }
            case 15:
              objectsForImport.ProcessingItems = (IEnumerable<ExternalMembershipImportManager.ProcessingItem>) processingItemList;
              num2 = 19;
              continue;
            case 16:
              processingItemList = new List<ExternalMembershipImportManager.ProcessingItem>();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 1 : 2;
              continue;
            case 17:
            case 18:
              goto label_38;
            case 19:
              goto label_31;
            case 20:
              if (allImportInfo.Any<ExternalMembershipImportManager.ImportModel>())
              {
                num2 = 13;
                continue;
              }
              goto case 12;
            case 21:
label_40:
              objectsForImport.ProcessingItems = (IEnumerable<ExternalMembershipImportManager.ProcessingItem>) list;
              num2 = 8;
              continue;
            default:
              allImportInfo = this.GetAllImportInfo();
              num2 = 9;
              continue;
          }
        }
label_25:
        DataAccessManager.BLOBManager.SetBLOB<List<ExternalMembershipImportManager.ImportModel>>(this.UID, (string) ExternalMembershipImportManager.hTKoWc7EA1dJMUeuOds(-1341618464 ^ -1341599352), allImportInfo);
        num1 = 15;
        continue;
label_28:
        num1 = 18;
        continue;
label_30:
        objectsForImport = allImportInfo.FirstOrDefault<ExternalMembershipImportManager.ImportModel>();
        num1 = 3;
        continue;
label_33:
        num1 = 16;
      }
label_29:
      return (ExternalMembershipImportManager.ImportModel) null;
label_31:
      return objectsForImport;
label_38:
      return objectsForImport;
    }

    /// <summary>Удалить обработанные объекты из очереди</summary>
    /// <param name="model">Модель обработанных объектов</param>
    private void RemoveProcessingObjects(ExternalMembershipImportManager.ImportModel model)
    {
      int num1 = 11;
      ExternalMembershipImportManager.ImportModel importModel;
      List<ExternalMembershipImportManager.ImportModel> allImportInfo;
      ExternalMembershipImportManager.ImportModel model1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (allImportInfo.Any<ExternalMembershipImportManager.ImportModel>())
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99d14ae5db0b4461a38c946c2a7eb05f == 0 ? 1 : 5;
              continue;
            }
            goto label_2;
          case 2:
            goto label_5;
          case 3:
            if (allImportInfo != null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 == 0 ? 1 : 1;
              continue;
            }
            goto label_21;
          case 4:
            ((IBLOBDataManager) ExternalMembershipImportManager.esvwma7dEYPHgenTXwk()).SetBLOB<List<ExternalMembershipImportManager.ImportModel>>(this.UID, z2jc63fLkugS1X8Q9N.tE1kD1vbB(44166125 ^ 44153989), allImportInfo);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7978ba9bf7964b69b5161d52b4aab693 != 0 ? 2 : 2;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            importModel = allImportInfo.FirstOrDefault<ExternalMembershipImportManager.ImportModel>((Func<ExternalMembershipImportManager.ImportModel, bool>) (a => ExternalMembershipImportManager.\u003C\u003Ec__DisplayClass32_0.i2F5pkwiJYpUaGRHW0qJ((object) a) == ExternalMembershipImportManager.\u003C\u003Ec__DisplayClass32_0.i2F5pkwiJYpUaGRHW0qJ((object) model1)));
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5c3ad647668d47dcb6376fd655d08805 != 0 ? 9 : 6;
            continue;
          case 6:
            goto label_11;
          case 7:
            allImportInfo = this.GetAllImportInfo();
            num1 = 3;
            continue;
          case 8:
            if (!importModel.ProcessingItems.Any<ExternalMembershipImportManager.ProcessingItem>())
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 9:
            if (importModel == null)
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_9d7910dd673d46c791072528b4063de9 != 0 ? 4 : 6;
              continue;
            }
            importModel.ProcessingItems = (IEnumerable<ExternalMembershipImportManager.ProcessingItem>) importModel.ProcessingItems.Where<ExternalMembershipImportManager.ProcessingItem>((Func<ExternalMembershipImportManager.ProcessingItem, bool>) (a =>
            {
              int num2 = 2;
              ExternalMembershipImportManager.ProcessingItem a1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    a1 = a;
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af == 0 ? 1 : 1;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_4:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              return !model1.ProcessingItems.Any<ExternalMembershipImportManager.ProcessingItem>((Func<ExternalMembershipImportManager.ProcessingItem, bool>) (b => ExternalMembershipImportManager.\u003C\u003Ec__DisplayClass32_1.AnBGluwiHJv3AQXUO7I9(ExternalMembershipImportManager.\u003C\u003Ec__DisplayClass32_1.PdD7cIwi2FkdE0YShbdL((object) b), ExternalMembershipImportManager.\u003C\u003Ec__DisplayClass32_1.PdD7cIwi2FkdE0YShbdL((object) a1))));
            })).ToList<ExternalMembershipImportManager.ProcessingItem>();
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8e4aaa3a8af04f1999e7153bbf707d23 == 0 ? 8 : 8;
            continue;
          case 10:
            model1 = model;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 != 0 ? 7 : 5;
            continue;
          case 11:
            num1 = 10;
            continue;
          case 12:
            goto label_8;
          default:
            allImportInfo.Remove(importModel);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 != 0 ? 0 : 4;
            continue;
        }
      }
label_5:
      return;
label_11:
      return;
label_8:
      return;
label_2:
      return;
label_21:;
    }

    private int ProcessingCount => EleWise.ELMA.SR.GetSetting<int>((string) ExternalMembershipImportManager.hTKoWc7EA1dJMUeuOds(-901653144 ^ -901675642), 50);

    /// <summary>
    /// Интервал за который должна быть обработана пачка данных (в минутах)
    /// </summary>
    private int ProcessingTimeout => EleWise.ELMA.SR.GetSetting<int>((string) ExternalMembershipImportManager.hTKoWc7EA1dJMUeuOds(-1958977588 ^ -1959000420), 50);

    public ExternalMembershipImportManager()
    {
      ExternalMembershipImportManager.BQahAj7v3g2EbpfRLMw();
      this.UID = new Guid((string) ExternalMembershipImportManager.hTKoWc7EA1dJMUeuOds(617710536 ^ 617732734));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool OLu6Mq78gUoal73D9E3() => ExternalMembershipImportManager.sQC3XI7Q0obpqZrytHC == null;

    internal static ExternalMembershipImportManager SEWNWc75lhMWU45M0u8() => ExternalMembershipImportManager.sQC3XI7Q0obpqZrytHC;

    internal static object esvwma7dEYPHgenTXwk() => (object) DataAccessManager.BLOBManager;

    internal static object hTKoWc7EA1dJMUeuOds(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static int Xi6c3u7GY2yVaRkiCwS([In] object obj0) => ((List<ExternalMembershipImportManager.ImportModel>) obj0).Count;

    internal static object YpSqj67XZoGuWX2k9Us([In] object obj0) => (object) ((IExternalMembershipImportManagerActor) obj0).Start();

    internal static void kLhEwW79fZEeOrvyjxa([In] object obj0) => ((Task) obj0).Wait();

    internal static void FxiI1H71ZQnBb6LnI1m([In] object obj0) => ((BackgroundTask) obj0).Execute();

    internal static void iR9qI67MLBIXg6WXwtI([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static Guid fCiZZ67hPT3qtPXDvcB([In] object obj0) => ((ExternalMembershipImportManager.ImportModel) obj0).Uid;

    internal static object htMg8n7BZdhlvHbt754([In] object obj0) => (object) ((IExternalMembershipImportManagerActor) obj0).ImportComplete();

    internal static long NGw1sn7ps9PoWXbm5vv([In] object obj0, [In] TimeSpan obj1) => ((ITimestampService) obj0).GetTimeStampRelativeToNow(obj1);

    internal static void xRTVPG7OoZGOWJVjbWu(
      [In] object obj0,
      ExternalMembershipImportManager.ProcessingStatus value)
    {
      ((ExternalMembershipImportManager.ProcessingItem) obj0).Status = value;
    }

    internal static int l8RsMi7TtDsmq8wZT5h([In] object obj0) => ((List<ExternalMembershipImportManager.ProcessingItem>) obj0).Count;

    internal static bool BGE1627FpkyXnfPV7qI([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void BQahAj7v3g2EbpfRLMw() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    /// <summary>Модель для хранения данных между повторами импорта</summary>
    [Serializable]
    private class ImportModel
    {
      [XmlAttribute]
      private string groups;
      private static object EP9uAFwiuh1eqiBvZSsH;

      /// <summary>Ctor</summary>
      public ImportModel()
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              this.Groups = Enumerable.Empty<long>();
              num = 3;
              continue;
            case 3:
              this.Uid = ExternalMembershipImportManager.ImportModel.MjaGjdwiKvJ0PFR5Rako();
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 == 0 ? 1 : 0;
              continue;
            default:
              this.ProcessingItems = Enumerable.Empty<ExternalMembershipImportManager.ProcessingItem>();
              num = 2;
              continue;
          }
        }
label_3:;
      }

      /// <summary>Ctor</summary>
      /// <param name="users">UserName пользователей</param>
      /// <param name="groups">Модель для отображения групп пользователей</param>
      /// <param name="authProviderUid">Идентификатор провайдера авторизации</param>
      /// <param name="status">Статус обработки</param>
      public ImportModel(
        IEnumerable<string> users,
        EditableListModel groups,
        Guid authProviderUid,
        ExternalMembershipImportManager.ProcessingStatus status)
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.ProcessingItems = users.Select<string, ExternalMembershipImportManager.ProcessingItem>((Func<string, ExternalMembershipImportManager.ProcessingItem>) (a =>
        {
          ExternalMembershipImportManager.ProcessingItem processingItem = new ExternalMembershipImportManager.ProcessingItem();
          // ISSUE: reference to a compiler-generated method
          ExternalMembershipImportManager.ImportModel.\u003C\u003Ec__DisplayClass1_0.d5dLHmw45Dx9uq4HmNJZ((object) processingItem, (object) a);
          processingItem.Status = status;
          return processingItem;
        }));
        this.Groups = groups.Items.Select<EditableListItem, long>((Func<EditableListItem, long>) (a => a.Value.FromJson<long>()));
        this.AuthProviderGuid = authProviderUid;
        this.Uid = Guid.NewGuid();
      }

      /// <summary>Ctor</summary>
      /// <param name="users">UserName пользователей</param>
      /// <param name="groups">Идентификаторы групп</param>
      /// <param name="authProviderUid">Идентификатор провайдера авторизации</param>
      /// <param name="status">Статус обработки</param>
      public ImportModel(
        IEnumerable<string> users,
        IEnumerable<long> groups,
        Guid authProviderUid,
        ExternalMembershipImportManager.ProcessingStatus status)
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.ProcessingItems = users.Select<string, ExternalMembershipImportManager.ProcessingItem>((Func<string, ExternalMembershipImportManager.ProcessingItem>) (a =>
        {
          ExternalMembershipImportManager.ProcessingItem processingItem = new ExternalMembershipImportManager.ProcessingItem();
          // ISSUE: reference to a compiler-generated method
          ExternalMembershipImportManager.ImportModel.\u003C\u003Ec__DisplayClass2_0.Hgba3Uw4hJhyqAwCJxjp((object) processingItem, (object) a);
          // ISSUE: reference to a compiler-generated method
          ExternalMembershipImportManager.ImportModel.\u003C\u003Ec__DisplayClass2_0.HIA5JVw4BqP0tAi630AR((object) processingItem, status);
          return processingItem;
        }));
        this.Groups = groups;
        this.AuthProviderGuid = authProviderUid;
        this.Uid = Guid.NewGuid();
      }

      /// <summary>Список Объектов для обработки</summary>
      [XmlIgnore]
      public IEnumerable<ExternalMembershipImportManager.ProcessingItem> ProcessingItems
      {
        get => new JsonSerializer().Deserialize<IEnumerable<ExternalMembershipImportManager.ProcessingItem>>(this.userNames);
        set => this.userNames = new JsonSerializer().Serialize((object) value);
      }

      [XmlAttribute]
      private string userNames
      {
        get => this.\u003CuserNames\u003Ek__BackingField;
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
                this.\u003CuserNames\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_52a33ff028824a8185d2cb4cf647ded5 == 0 ? 0 : 0;
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

      /// <summary>Идентификаторы групп</summary>
      [XmlIgnore]
      public IEnumerable<long> Groups
      {
        get => new JsonSerializer().Deserialize<IEnumerable<long>>(this.groups);
        set => this.groups = new JsonSerializer().Serialize((object) value);
      }

      /// <summary>Идентификатор провайдера авторизации</summary>
      public Guid AuthProviderGuid
      {
        get => this.\u003CAuthProviderGuid\u003Ek__BackingField;
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
                this.\u003CAuthProviderGuid\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5cd6edd47dc94c43a14e8ba39b6483d8 == 0 ? 0 : 0;
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

      /// <summary>Идентификатор модели</summary>
      public Guid Uid
      {
        get => this.\u003CUid\u003Ek__BackingField;
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
                this.\u003CUid\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af6c8a69966d4850a7f0555da3e828d9 != 0 ? 0 : 0;
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

      internal static Guid MjaGjdwiKvJ0PFR5Rako() => Guid.NewGuid();

      internal static bool xJBv3wwiwfof4d2fwRDN() => ExternalMembershipImportManager.ImportModel.EP9uAFwiuh1eqiBvZSsH == null;

      internal static ExternalMembershipImportManager.ImportModel QQRZoDwibIFTQIaTZY2u() => (ExternalMembershipImportManager.ImportModel) ExternalMembershipImportManager.ImportModel.EP9uAFwiuh1eqiBvZSsH;
    }

    /// <summary>Объект для обработки</summary>
    internal class ProcessingItem
    {
      private static ExternalMembershipImportManager.ProcessingItem lXLt66wiUWNhbvwEm6Ei;

      /// <summary>USerName пользователя</summary>
      public string UserName
      {
        get => this.\u003CUserName\u003Ek__BackingField;
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
                this.\u003CUserName\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a != 0 ? 0 : 0;
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

      /// <summary>Статус обработки</summary>
      public ExternalMembershipImportManager.ProcessingStatus Status
      {
        get => this.\u003CStatus\u003Ek__BackingField;
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
                this.\u003CStatus\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_8398674f3c754093863acdef5d68f791 == 0 ? 0 : 0;
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

      /// <summary>Время, когда объект был взят в работу</summary>
      public DateTime? StartProcessing { get; set; }

      /// <summary>
      /// Временная отметка, когда истекает таймаут обработки объекта
      /// </summary>
      public long? ExpireProcessingTimestamp { get; set; }

      public ProcessingItem()
      {
        ExternalMembershipImportManager.ProcessingItem.df3pVowitvd2G12cCjHj();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ef8a939afd774c3fb830b6302a692c5b == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool CHngCBwiR0Wi5JG3ve5p() => ExternalMembershipImportManager.ProcessingItem.lXLt66wiUWNhbvwEm6Ei == null;

      internal static ExternalMembershipImportManager.ProcessingItem AynanZwioEcXxKWu5CcF() => ExternalMembershipImportManager.ProcessingItem.lXLt66wiUWNhbvwEm6Ei;

      internal static void df3pVowitvd2G12cCjHj() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
    }

    /// <summary>Статус обработки</summary>
    internal enum ProcessingStatus
    {
      /// <summary>Не выполнено</summary>
      None,
      /// <summary>Обрабатывается</summary>
      Process,
      /// <summary>Завершено</summary>
      Complete,
    }
  }
}
